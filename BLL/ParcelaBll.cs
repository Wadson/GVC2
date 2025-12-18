using Dapper;
using GVC.DALL;
using GVC.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.BLL
{
    internal class ParcelaBLL
    {
        private readonly ParcelaDal _dal;

        public ParcelaBLL()
        {
            _dal = new ParcelaDal();
        }

        // ==========================================================
        // 1. BAIXA TOTAL DE UMA PARCELA (força pagamento completo)
        // ==========================================================
        public void BaixarParcelaTotal(long parcelaId)
        {
            var parcela = _dal.BuscarPorId(parcelaId)
                ?? throw new Exception("Parcela não encontrada.");

            // Calcular o saldo restante em decimal
            decimal totalDevido = (parcela.ValorParcela + parcela.Juros + parcela.Multa);
            decimal valorRecebido = parcela.ValorRecebido;
            decimal saldoRestante = totalDevido - valorRecebido;

            if (saldoRestante <= 0)
                return; // Já está quitada

            // Arredondar para evitar problemas de precisão
            saldoRestante = Math.Round(saldoRestante, 2, MidpointRounding.AwayFromZero);

            // Inserir pagamento do saldo restante
            _dal.BaixarParcela(parcelaId, saldoRestante, DateTime.Now);
        }
        /// <summary>
        /// Baixa total de múltiplas parcelas (usado no botão de baixa em lote com checkbox)
        /// </summary>
        /// <param name="parcelasIds">Lista de IDs das parcelas selecionadas</param>
        public void BaixarParcelasEmLote(List<long> parcelasIds)
        {
            if (parcelasIds == null || parcelasIds.Count == 0)
                throw new Exception("Nenhuma parcela selecionada para baixa.");

            _dal.BaixarParcelasEmLote(parcelasIds, DateTime.Now);
        }
        // ==========================================================
        // 2. BAIXA PARCIAL DE UMA PARCELA (valor informado pelo usuário)
        // ==========================================================
        public void BaixarParcelaParcial(long parcelaId, decimal valorPago)
        {
            if (valorPago <= 0m)
                throw new Exception("O valor pago deve ser maior que zero.");

            var parcela = _dal.BuscarPorId(parcelaId)
                ?? throw new Exception("Parcela não encontrada.");

            // Agora tudo é diretamente em reais (decimal)
            decimal totalDevido = parcela.ValorParcela + parcela.Juros + parcela.Multa;
            decimal saldoAtual = totalDevido - parcela.ValorRecebido;

            // Arredonda para 2 casas (boa prática)
            valorPago = Math.Round(valorPago, 2, MidpointRounding.AwayFromZero);

            if (valorPago > saldoAtual)
                throw new Exception($"Valor pago ({valorPago:C2}) maior que o saldo devido ({saldoAtual:C2}).");

            // Aplica a baixa (o DAL já soma diretamente em decimal)
            _dal.BaixarParcela(parcelaId, valorPago, DateTime.Now);

            // O trigger do banco cuida do Status e DataPagamento automaticamente
        }

        // ==========================================================
        // 3. BAIXA EM LOTE (várias parcelas selecionadas no grid)
        // ==========================================================
        public void BaixarParcelasEmLote(List<int> parcelasIds)
        {
            if (parcelasIds == null || parcelasIds.Count == 0)
                throw new Exception("Nenhuma parcela selecionada.");

            foreach (var parcelaId in parcelasIds)
            {
                BaixarParcelaTotal(parcelaId);
            }
        }

        // ==========================================================
        // ALTERAR STATUS MANUALMENTE
        // ==========================================================
        public void AlterarStatus(int parcelaId, string novoStatus)
        {
            if (string.IsNullOrWhiteSpace(novoStatus))
                throw new Exception("Status inválido.");

            ParcelaModel parcela = _dal.BuscarPorId(parcelaId)
                ?? throw new Exception("Parcela não encontrada.");

            parcela.Status = novoStatus;
            _dal.UpdateParcela(parcela);
        }

        // ==========================================================
        // EXCLUSÃO
        // ==========================================================
        public void Excluir(ParcelaModel parcela)
        {
            if (parcela == null)
                throw new Exception("Parcela inválida.");

            _dal.Excluir(parcela);
        }

        /// <summary>
        /// Estorna um pagamento (parcial ou total) de uma parcela
        /// </summary>
        /// <param name="parcelaId">ID da parcela</param>
        /// <param name="valorEstorno">Valor a estornar (positivo)</param>
        /// <param name="motivo">Motivo do estorno (para auditoria)</param>
        public void EstornarPagamento(long parcelaId, decimal valorEstorno, DateTime? dataEstorno = null, string motivo = null)
        {
            dataEstorno ??= DateTime.Now;

            if (valorEstorno <= 0m)
                throw new Exception("O valor do estorno deve ser maior que zero.");

            var parcela = _dal.BuscarPorId(parcelaId)
                ?? throw new Exception("Parcela não encontrada.");

            if (valorEstorno > parcela.ValorRecebido)
                throw new Exception($"Valor do estorno ({valorEstorno:C2}) maior que o valor recebido ({parcela.ValorRecebido:C2}).");

            _dal.EstornarPagamento(parcelaId, valorEstorno, dataEstorno.Value, motivo);

            // Trigger atualiza Status e DataPagamento automaticamente
        }
        public void EstornarPagamentosEmLote(List<long> parcelasIds, decimal valorEstornoPorParcela, string motivo = null)
        {
            var dataEstorno = DateTime.Now;

            foreach (var parcelaId in parcelasIds)
            {
                EstornarPagamento(parcelaId, valorEstornoPorParcela, dataEstorno, motivo);
            }
        }
        //public void EstornarPagamentosEmLote(List<int> parcelasIds, decimal valorEstornoPorParcela, string motivo)
        //{
        //    if (parcelasIds == null || parcelasIds.Count == 0)
        //        throw new Exception("Nenhuma parcela selecionada para estorno.");

        //    if (valorEstornoPorParcela <= 0m)
        //        throw new Exception("O valor do estorno deve ser maior que zero.");

        //    if (string.IsNullOrWhiteSpace(motivo))
        //        motivo = "Estorno sem motivo informado";

        //    var dataEstorno = DateTime.Now;

        //    using var conn = Helpers.Conexao.Conex();
        //    conn.Open();
        //    using var transaction = conn.BeginTransaction();

        //    try
        //    {
        //        foreach (var parcelaId in parcelasIds)
        //        {
        //            var parcela = _dal.BuscarPorId(parcelaId);
        //            if (parcela == null)
        //                throw new Exception($"Parcela ID {parcelaId} não encontrada.");

        //            if (valorEstornoPorParcela > parcela.ValorRecebido)
        //                throw new Exception($"Parcela {parcelaId}: estorno ({valorEstornoPorParcela:C2}) maior que recebido ({parcela.ValorRecebido:C2}).");

        //            _dal.EstornarPagamento(parcelaId, valorEstornoPorParcela, motivo, dataEstorno);
        //        }

        //        transaction.Commit();
        //    }
        //    catch
        //    {
        //        transaction.Rollback();
        //        throw;
        //    }
        //}
    }
}
