using GVC.MODEL;
using System;
using System.Collections.Generic;
using System.IO;

// ALIASES para evitar conflitos
using Document = iTextSharp.text.Document;
using PdfWriter = iTextSharp.text.pdf.PdfWriter;
using PageSize = iTextSharp.text.PageSize;
using BaseFont = iTextSharp.text.pdf.BaseFont;
using Font = iTextSharp.text.Font;
using Paragraph = iTextSharp.text.Paragraph;
using Phrase = iTextSharp.text.Phrase;
using PdfPTable = iTextSharp.text.pdf.PdfPTable;
using PdfPCell = iTextSharp.text.pdf.PdfPCell;
using BaseColor = iTextSharp.text.BaseColor;
using Element = iTextSharp.text.Element;

namespace GVC.UTIL
{
    public class PDFGenerator
    {
        public static void GerarExtratoPDF(ExtratoCliente extrato, string caminhoArquivo)
        {
            Document doc = new Document(PageSize.A4);
            doc.SetMargins(40, 40, 40, 40);

            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminhoArquivo, FileMode.Create));
            doc.Open();

            // Configurar fonte padrão
            BaseFont baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);

            Font fonteNormal = new Font(baseFont, 10);
            Font fonteNegrito = new Font(baseFont, 10, Font.BOLD);
            Font fonteTitulo = new Font(baseFont, 14, Font.BOLD);
            Font fontePequena = new Font(baseFont, 8);

            // Cabeçalho
            Paragraph titulo = new Paragraph("EXTRATO FINANCEIRO", fonteTitulo);
            titulo.Alignment = Element.ALIGN_CENTER;
            titulo.SpacingAfter = 20;
            doc.Add(titulo);

            // Informações do Cliente
            doc.Add(new Paragraph($"Cliente: {extrato.NomeCliente}", fonteNegrito));
            if (!string.IsNullOrEmpty(extrato.CPF_CNPJ))
                doc.Add(new Paragraph($"CPF/CNPJ: {extrato.CPF_CNPJ}", fonteNormal));
            if (!string.IsNullOrEmpty(extrato.Endereco))
                doc.Add(new Paragraph($"Endereço: {extrato.Endereco}", fonteNormal));
            if (!string.IsNullOrEmpty(extrato.Telefone))
                doc.Add(new Paragraph($"Telefone: {extrato.Telefone}", fonteNormal));

            doc.Add(new Paragraph($"Data de Emissão: {extrato.DataEmissao:dd/MM/yyyy HH:mm}", fonteNormal));
            doc.Add(new Paragraph(" "));

            // Tabela de Itens
            PdfPTable tabela = new PdfPTable(8);
            tabela.WidthPercentage = 100;
            tabela.SetWidths(new float[] { 12, 10, 10, 12, 12, 12, 12, 10 });

            // Cabeçalho da tabela
            tabela.AddCell(new PdfPCell(new Phrase("Venda", fonteNegrito)) { HorizontalAlignment = Element.ALIGN_CENTER });
            tabela.AddCell(new PdfPCell(new Phrase("Parcela", fonteNegrito)) { HorizontalAlignment = Element.ALIGN_CENTER });
            tabela.AddCell(new PdfPCell(new Phrase("Vencimento", fonteNegrito)) { HorizontalAlignment = Element.ALIGN_CENTER });
            tabela.AddCell(new PdfPCell(new Phrase("Pagamento", fonteNegrito)) { HorizontalAlignment = Element.ALIGN_CENTER });
            tabela.AddCell(new PdfPCell(new Phrase("Valor", fonteNegrito)) { HorizontalAlignment = Element.ALIGN_CENTER });
            tabela.AddCell(new PdfPCell(new Phrase("Recebido", fonteNegrito)) { HorizontalAlignment = Element.ALIGN_CENTER });
            tabela.AddCell(new PdfPCell(new Phrase("Saldo", fonteNegrito)) { HorizontalAlignment = Element.ALIGN_CENTER });
            tabela.AddCell(new PdfPCell(new Phrase("Status", fonteNegrito)) { HorizontalAlignment = Element.ALIGN_CENTER });

            // Adicionar itens
            foreach (var item in extrato.ItensExtrato)
            {
                tabela.AddCell(new PdfPCell(new Phrase(item.VendaID.ToString(), fonteNormal)) { HorizontalAlignment = Element.ALIGN_CENTER });
                tabela.AddCell(new PdfPCell(new Phrase(item.NumeroParcela.ToString(), fonteNormal)) { HorizontalAlignment = Element.ALIGN_CENTER });
                tabela.AddCell(new PdfPCell(new Phrase(item.DataVencimento.ToString("dd/MM/yyyy"), fonteNormal)) { HorizontalAlignment = Element.ALIGN_CENTER });
                tabela.AddCell(new PdfPCell(new Phrase(item.DataPagamento?.ToString("dd/MM/yyyy") ?? "-", fonteNormal)) { HorizontalAlignment = Element.ALIGN_CENTER });
                tabela.AddCell(new PdfPCell(new Phrase(item.ValorParcela.ToString("C2"), fonteNormal)) { HorizontalAlignment = Element.ALIGN_RIGHT });
                tabela.AddCell(new PdfPCell(new Phrase(item.ValorRecebido.ToString("C2"), fonteNormal)) { HorizontalAlignment = Element.ALIGN_RIGHT });
                tabela.AddCell(new PdfPCell(new Phrase(item.Saldo.ToString("C2"), fonteNormal)) { HorizontalAlignment = Element.ALIGN_RIGHT });

                // Cor do status
                Phrase statusPhrase = new Phrase(item.Status, fonteNormal);
                if (item.Status == "Paga")
                    statusPhrase.Font.Color = BaseColor.GREEN;
                else if (item.Status == "Atrasada")
                    statusPhrase.Font.Color = BaseColor.RED;
                else if (item.Status == "Parcialmente Paga")
                    statusPhrase.Font.Color = BaseColor.BLUE;

                tabela.AddCell(new PdfPCell(statusPhrase) { HorizontalAlignment = Element.ALIGN_CENTER });
            }

            doc.Add(tabela);
            doc.Add(new Paragraph(" "));

            // Resumo
            PdfPTable tabelaResumo = new PdfPTable(3);
            tabelaResumo.WidthPercentage = 60;
            tabelaResumo.HorizontalAlignment = Element.ALIGN_RIGHT;

            tabelaResumo.AddCell(new PdfPCell(new Phrase("Total Pago:", fonteNegrito)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = 0 });
            tabelaResumo.AddCell(new PdfPCell(new Phrase(extrato.TotalPago.ToString("C2"), fonteNegrito)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = 0 });
            tabelaResumo.AddCell(new PdfPCell(new Phrase("")) { Border = 0 });

            tabelaResumo.AddCell(new PdfPCell(new Phrase("Total Devendo:", fonteNegrito)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = 0 });
            tabelaResumo.AddCell(new PdfPCell(new Phrase(extrato.TotalDevendo.ToString("C2"), fonteNegrito)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = 0 });
            tabelaResumo.AddCell(new PdfPCell(new Phrase("")) { Border = 0 });

            tabelaResumo.AddCell(new PdfPCell(new Phrase("SALDO ATUAL:", fonteNegrito)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = 0 });
            tabelaResumo.AddCell(new PdfPCell(new Phrase(extrato.SaldoAtual.ToString("C2"), fonteNegrito))
            {
                HorizontalAlignment = Element.ALIGN_RIGHT,
                Border = 0,
                BackgroundColor = extrato.SaldoAtual > 0 ? BaseColor.RED : BaseColor.GREEN
            });
            tabelaResumo.AddCell(new PdfPCell(new Phrase("")) { Border = 0 });

            doc.Add(tabelaResumo);
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph(" "));

            // Rodapé
            Paragraph rodape = new Paragraph("Documento gerado automaticamente pelo sistema GVC", fontePequena);
            rodape.Alignment = Element.ALIGN_CENTER;
            rodape.SpacingBefore = 20;
            doc.Add(rodape);

            doc.Close();
        }

        public static void GerarReciboPDF(ExtratoCliente extrato, List<dynamic> parcelasSelecionadas, string caminhoArquivo)
        {
            Document doc = new Document(PageSize.A4);
            doc.SetMargins(40, 40, 40, 40);

            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminhoArquivo, FileMode.Create));
            doc.Open();

            BaseFont baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);

            Font fonteNormal = new Font(baseFont, 10);
            Font fonteNegrito = new Font(baseFont, 10, Font.BOLD);
            Font fonteTitulo = new Font(baseFont, 16, Font.BOLD);

            // Título
            Paragraph titulo = new Paragraph("RECIBO DE PARCELAS", fonteTitulo);
            titulo.Alignment = Element.ALIGN_CENTER;
            titulo.SpacingAfter = 20;
            doc.Add(titulo);

            // Informações
            doc.Add(new Paragraph($"Cliente: {extrato.NomeCliente}", fonteNegrito));
            doc.Add(new Paragraph($"Data: {DateTime.Now:dd/MM/yyyy HH:mm}", fonteNormal));
            doc.Add(new Paragraph(" "));

            // Lista de parcelas incluídas
            Paragraph subtitulo = new Paragraph("Parcelas incluídas:", fonteNegrito);
            subtitulo.SpacingAfter = 10;
            doc.Add(subtitulo);

            PdfPTable tabela = new PdfPTable(4);
            tabela.WidthPercentage = 100;
            tabela.SetWidths(new float[] { 15, 20, 25, 20 });

            tabela.AddCell(new PdfPCell(new Phrase("Venda", fonteNegrito)) { HorizontalAlignment = Element.ALIGN_CENTER });
            tabela.AddCell(new PdfPCell(new Phrase("Parcela", fonteNegrito)) { HorizontalAlignment = Element.ALIGN_CENTER });
            tabela.AddCell(new PdfPCell(new Phrase("Vencimento", fonteNegrito)) { HorizontalAlignment = Element.ALIGN_CENTER });
            tabela.AddCell(new PdfPCell(new Phrase("Valor", fonteNegrito)) { HorizontalAlignment = Element.ALIGN_CENTER });

            decimal totalRecibo = 0;
            foreach (var parcela in parcelasSelecionadas)
            {
                tabela.AddCell(new PdfPCell(new Phrase(parcela.VendaID.ToString(), fonteNormal)) { HorizontalAlignment = Element.ALIGN_CENTER });
                tabela.AddCell(new PdfPCell(new Phrase(parcela.NumeroParcela.ToString(), fonteNormal)) { HorizontalAlignment = Element.ALIGN_CENTER });
                tabela.AddCell(new PdfPCell(new Phrase(((DateTime)parcela.DataVencimento).ToString("dd/MM/yyyy"), fonteNormal)) { HorizontalAlignment = Element.ALIGN_CENTER });
                tabela.AddCell(new PdfPCell(new Phrase(((decimal)parcela.ValorParcela).ToString("C2"), fonteNormal)) { HorizontalAlignment = Element.ALIGN_RIGHT });

                totalRecibo += (decimal)parcela.ValorParcela;
            }

            doc.Add(tabela);
            doc.Add(new Paragraph(" "));

            // Total
            Paragraph total = new Paragraph($"TOTAL: {totalRecibo.ToString("C2")}", new Font(baseFont, 14, Font.BOLD));
            total.Alignment = Element.ALIGN_RIGHT;
            total.SpacingBefore = 20;
            doc.Add(total);

            // Assinatura
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph(" "));

            Paragraph linha = new Paragraph("________________________________________", fonteNormal);
            linha.Alignment = Element.ALIGN_CENTER;
            doc.Add(linha);

            Paragraph assinatura = new Paragraph("Assinatura do Cliente", fonteNormal);
            assinatura.Alignment = Element.ALIGN_CENTER;
            doc.Add(assinatura);

            // Rodapé
            Paragraph rodape = new Paragraph("Recibo válido para fins de comprovação de pagamento", fonteNormal);
            rodape.Alignment = Element.ALIGN_CENTER;
            rodape.SpacingBefore = 30;
            doc.Add(rodape);

            doc.Close();
        }
    }
}