using Dapper;
using GVC.Helpers;
using GVC.MODEL;
using iText.Kernel.Colors;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Krypton.Toolkit;
using Microsoft.Data.Sqlite;
using OfficeOpenXml;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Color = System.Drawing.Color;

namespace GVC{
    public static class Utilitario
    {
        private static readonly CultureInfo CulturaBR = new CultureInfo("pt-BR");
        
        // ==============================================================
        // 1. FORMATAR MOEDA (TextBox e KryptonTextBox)
        // ==============================================================
        public static void FormatarMoeda(TextBox txt) => FormatarMoeda(txt, txt.Text);
        public static void FormatarMoeda(KryptonTextBox txt) => FormatarMoeda(txt, txt.Text);

        public static void PesquisarPorCodigoRetornarNomeTexBox(string query, string nomeParametro, string parametro, KryptonTextBox txtResultado)
        {
            using (var connection = GVC.Helpers.Conexao.Conex())
                try
                {
                    connection.Open();

                    // Usando Dapper para consulta única
                    var resultado = connection.QueryFirstOrDefault<dynamic>(query, new Dictionary<string, object>
            {
                { nomeParametro, parametro }
            });

                    if (resultado != null)
                    {
                        // A coluna "Estado" vem do resultado da query
                        txtResultado.Text = resultado.Estado?.ToString() ?? string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Nenhum resultado encontrado.", "Informe.",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        txtResultado.Text = string.Empty;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar nome: " + ex.Message, "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        public static void ExportarParaPDF(KryptonDataGridView dgv, string arquivo = null)
        {
            var salvar = new SaveFileDialog { Filter = "PDF|*.pdf", FileName = arquivo ?? "Relatorio.pdf" };
            if (salvar.ShowDialog() != DialogResult.OK) return;

            // Criar documento (A4 paisagem)
            using (var writer = new PdfWriter(salvar.FileName))
            {
                using (var pdf = new PdfDocument(writer))
                {
                    // A4 em paisagem: 842pt x 595pt
                    var pageSize = iText.Kernel.Geom.PageSize.A4.Rotate();
                    var document = new Document(pdf, pageSize);
                    document.SetMargins(20, 20, 20, 20);

                    // Criar tabela
                    var tabela = new Table(dgv.Columns.Count, true);
                    tabela.SetWidth(UnitValue.CreatePercentValue(100));

                    // Cabeçalho da tabela
                    foreach (DataGridViewColumn col in dgv.Columns)
                    {
                        if (col.Visible)
                        {
                            var cell = new Cell()
                                .Add(new Paragraph(col.HeaderText ?? ""))
                                .SetBackgroundColor(new DeviceRgb(200, 200, 200))
                                .SetFontColor(new DeviceRgb(0, 0, 0))
                                .SetBold();
                            tabela.AddHeaderCell(cell);
                        }
                    }

                    // Dados da tabela
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (row.IsNewRow) continue;

                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.OwningColumn.Visible)
                            {
                                var valor = cell.Value?.ToString() ?? "";
                                tabela.AddCell(new Cell().Add(new Paragraph(valor)));
                            }
                        }
                    }

                    // Adicionar tabela ao documento
                    document.Add(tabela);

                    // Fechar documento (não precisa chamar Close explicitamente com using)
                }
            }

            MessageBox.Show("PDF gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ExportarParaExcel(KryptonDataGridView dgv)
        {
            var salvar = new SaveFileDialog { Filter = "Excel|*.xlsx" };
            if (salvar.ShowDialog() != DialogResult.OK) return;

            using var pacote = new ExcelPackage(new FileInfo(salvar.FileName));
            var planilha = pacote.Workbook.Worksheets.Add("Relatório");

            for (int c = 0; c < dgv.Columns.Count; c++)
                planilha.Cells[1, c + 1].Value = dgv.Columns[c].HeaderText;

            for (int r = 0; r < dgv.Rows.Count; r++)
                for (int c = 0; c < dgv.Columns.Count; c++)
                    planilha.Cells[r + 2, c + 1].Value = dgv.Rows[r].Cells[c].FormattedValue;

            pacote.Save();
            MessageBox.Show("Excel exportado com sucesso!");
        }


        // ==============================================================
        // BUSCA PRODUTO POR REFERÊNCIA E PREENCHE CAMPOS AUTOMATICAMENTE
        // Usado em PDV, Pedidos, Orçamentos — em qualquer lugar!
        // ==============================================================
        public static void PesquisarProdutoPorReferencia(
            string referencia,
            KryptonTextBox txtReferencia,
            KryptonTextBox txtNomeProduto,
            KryptonTextBox txtProdutoID,
            KryptonTextBox txtPrecoVenda = null)
        {
            // Limpa se estiver vazio
            if (string.IsNullOrWhiteSpace(referencia))
            {
                txtNomeProduto.Clear();
                txtProdutoID.Clear();
                txtPrecoVenda?.Clear();
                return;
            }

            try
            {
                using var conn = GVC.Helpers.Conexao.Conex();

                string sql = @"
            SELECT ProdutoID, NomeProduto, PrecoVenda 
            FROM Produtos 
            WHERE Referencia = @Referencia 
            LIMIT 1";

                var produto = conn.QueryFirstOrDefault<dynamic>(sql, new { Referencia = referencia.Trim() });

                if (produto != null)
                {
                    txtProdutoID.Text = produto.ProdutoID.ToString();
                    txtNomeProduto.Text = produto.NomeProduto?.ToString() ?? "";
                    //txtPrecoVend.Text = produto.PrecoVenda != null
                        //? Convert.ToDecimal(produto.PrecoVenda).ToString("F2")
                        //: "";
                }
                else
                {
                    txtProdutoID.Clear();
                    txtNomeProduto.Clear();
                    txtPrecoVenda?.Clear();
                    txtNomeProduto.Text = "PRODUTO NÃO ENCONTRADO";
                    txtNomeProduto.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar produto: " + ex.Message, "Erro",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtProdutoID.Clear();
                txtNomeProduto.Clear();
                txtPrecoVenda?.Clear();
                txtNomeProduto.Text = "ERRO NA BUSCA";
                txtNomeProduto.ForeColor = System.Drawing.Color.DarkRed;
            }
        }
        // ==============================================================
        // PESQUISA GENÉRICA COM PARÂMETRO (sem mensagem automática)
        // Ideal para preencher DataGridView sem exibir "nenhum registro"
        // ==============================================================
        public static void PesquisarComParametro(string sql, string nomeParametro, object valorParametro, KryptonDataGridView dgv)
        {
            try
            {
                using var conn = GVC.Helpers.Conexao.Conex();

                // Usa Dapper (muito mais rápido e limpo que SqlDataReader manual)
                var resultado = conn.Query(sql, new { }, commandType: CommandType.Text)
                                   .Select((dynamic row) =>
                                   {
                                       var dict = (IDictionary<string, object>)row;
                                       var dataRow = new Dictionary<string, object>(dict, StringComparer.OrdinalIgnoreCase);
                                       return dataRow;
                                   });

                var dt = new DataTable();

                if (resultado.Any())
                {
                    // Cria as colunas automaticamente
                    var primeiraLinha = resultado.First();
                    foreach (var coluna in primeiraLinha.Keys)
                    {
                        dt.Columns.Add(coluna);
                    }

                    // Preenche as linhas
                    foreach (var linha in resultado)
                    {
                        var row = dt.NewRow();
                        foreach (var item in linha)
                        {
                            row[item.Key] = item.Value ?? DBNull.Value;
                        }
                        dt.Rows.Add(row);
                    }
                }

                // Atribui ao DataGridView (limpa automaticamente se vazio)
                dgv.DataSource = dt.Rows.Count > 0 ? dt : null;
            }
            catch (Exception ex)
            {
                // Log silencioso opcional (não exibe MessageBox)
                // MessageBox.Show("Erro interno na pesquisa: " + ex.Message);
                dgv.DataSource = null;
            }
        }
        // ==============================================================
        // PESQUISA GENÉRICA COM UM OU MAIS PARÂMETROS (Dapper + Sqlite)
        // Ideal para grids, relatórios, consultas com WHERE, etc.
        // ==============================================================
        public static void PesquisarGeralComParametro(string sql, string nomeParametro, object valorParametro, KryptonDataGridView grid)
        {
            var parametros = new DynamicParameters();
            parametros.Add(nomeParametro, valorParametro);

            PesquisarGeralComParametros(sql, parametros, grid);
        }

        // ==============================================================
        // PESQUISA POR PERÍODO (DATA INÍCIO + DATA FIM)
        // Com opção de suprimir mensagem (muito usado em relatórios)
        // ==============================================================
        public static void PesquisarPorPeriodo(
            string sql,
            string paramInicio,
            DateTime dataInicio,
            string paramFim,
            DateTime dataFim,
            KryptonDataGridView grid,
            bool mostrarMensagemSeVazio = true)
        {
            try
            {
                using var conn = GVC.Helpers.Conexao.Conex();

                var parametros = new DynamicParameters();
                parametros.Add(paramInicio, dataInicio.Date);           // .Date remove hora
                parametros.Add(paramFim, dataFim.Date.AddDays(1).AddSeconds(-1)); // até 23:59:59

                var resultado = conn.Query(sql, parametros);

                var dt = new DataTable();

                if (resultado.Any())
                {
                    // Cria colunas automaticamente
                    foreach (var prop in resultado.First().GetType().GetProperties())
                    {
                        dt.Columns.Add(prop.Name, prop.PropertyType == typeof(DateTime?) ? typeof(DateTime) : prop.PropertyType);
                    }

                    // Preenche linhas
                    foreach (var item in resultado)
                    {
                        var row = dt.NewRow();
                        foreach (var prop in item.GetType().GetProperties())
                        {
                            var valor = prop.GetValue(item) ?? DBNull.Value;
                            row[prop.Name] = valor;
                        }
                        dt.Rows.Add(row);
                    }

                    grid.DataSource = dt;
                }
                else
                {
                    grid.DataSource = null;
                    if (mostrarMensagemSeVazio)
                    {
                        MessageBox.Show("Nenhum registro encontrado no período informado.",
                                       "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar por período: " + ex.Message,
                               "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                grid.DataSource = null;
            }
        }      

        public static int ContaRegistros(KryptonDataGridView grid)
        {
            if (grid == null || grid.DataSource == null)
                return 0;

            // 1. DataTable (mais comum)
            if (grid.DataSource is DataTable dt)
                return dt.Rows.Count;

            // 2. BindingSource (muito usado em alguns forms)
            if (grid.DataSource is BindingSource bs)
                return bs.Count;

            // 3. List<T>, IEnumerable, Array, etc.
            if (grid.DataSource is System.Collections.IEnumerable enumerable &&
                grid.DataSource is not string)
            {
                try
                {
                    return enumerable.Cast<object>().Count();
                }
                catch
                {
                    // fallback silencioso
                }
            }

            // 4. Último recurso: conta as linhas visíveis no grid
            return grid.Rows.Count;
        }

        // ==============================================================
        // VERSÃO QUE IGNORA A LINHA "NOVA" (quando AllowUserToAddRows = true)
        // ==============================================================
        public static int ContaRegistrosSemLinhaNova(KryptonDataGridView grid)
        {
            int total = ContaRegistros(grid);

            if (grid != null && grid.AllowUserToAddRows && total > 0)
                total--; // remove a linha em branco do final

            return total;
        }
        // Sobrecarga para múltiplos parâmetros (mais usada no sistema)
        public static void PesquisarGeralComParametros(string sql, DynamicParameters parametros, KryptonDataGridView grid)
        {
            try
            {
                using var conn = GVC.Helpers.Conexao.Conex();

                // Executa a consulta com Dapper
                var resultado = conn.Query(sql, parametros);

                // Converte para DataTable (necessário para DataGridView)
                var dt = new DataTable();

                if (resultado.Any())
                {
                    // Cria colunas automaticamente
                    foreach (var prop in resultado.First().GetType().GetProperties())
                    {
                        dt.Columns.Add(prop.Name);
                    }

                    // Preenche linhas
                    foreach (var item in resultado)
                    {
                        var row = dt.NewRow();
                        foreach (var prop in item.GetType().GetProperties())
                        {
                            var value = prop.GetValue(item) ?? DBNull.Value;
                            row[prop.Name] = value;
                        }
                        dt.Rows.Add(row);
                    }
                }

                // Atribui ao grid
                grid.DataSource = dt.Rows.Count > 0 ? dt : null;
            }
            catch (Exception ex)
            {
                // Opcional: log silencioso ou MessageBox apenas em debug
                MessageBox.Show("Erro na consulta: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                grid.DataSource = null;
            }
        }

        // Versão mais simples com Dictionary (compatibilidade com códigos antigos)
        public static void PesquisarGeralComParametros(string sql, Dictionary<string, object> parametros, KryptonDataGridView grid)
        {
            var dapperParams = new DynamicParameters();
            if (parametros != null)
            {
                foreach (var p in parametros)
                {
                    dapperParams.Add(p.Key, p.Value ?? DBNull.Value);
                }
            }

            PesquisarGeralComParametros(sql, dapperParams, grid);
        }
        // ==============================================================
        // ADICIONA EFEITO DE FOCO EM TODOS OS KryptonTextBox DO FORMULÁRIO
        // (muito usado no Load de todos os cadastros)
        // ==============================================================
        // ==================== 1. Efeito de foco (cor da borda) ====================
        public static void AdicionarEfeitoFocoEmTodos(Control container)
        {
            foreach (Control ctrl in TodosOsControles(container))
            {
                if (ctrl is KryptonTextBox kTxt)
                {
                    // Cor quando ganha foco
                    kTxt.Enter += (s, e) => kTxt.StateCommon.Border.Color1 = System.Drawing.Color.DeepSkyBlue;
                    // Cor quando perde foco (volta ao padrão do tema)
                    //kTxt.Leave += (s, e) => kTxt.StateCommon.Border.Color1 = System.Drawing.Color.Gray;

                    // ESSA É A PARTE QUE CONSERTA A TABULAÇÃO E ENTER
                    kTxt.KeyDown += (s, e) =>
                    {
                        if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                        {
                            container.SelectNextControl(ctrl, true, true, true, true);
                            e.Handled = true;
                            e.SuppressKeyPress = true; // evita o "ding"
                        }
                    };
                }
                else if (ctrl is TextBox txt)
                {
                    txt.Enter += (s, e) => txt.BackColor = System.Drawing.Color.PaleTurquoise;
                    txt.Leave += (s, e) => txt.BackColor = SystemColors.Window;

                    txt.KeyDown += (s, e) =>
                    {
                        if (e.KeyCode == Keys.Enter)
                        {
                            container.SelectNextControl(ctrl, true, true, true, true);
                            e.Handled = true;
                            e.SuppressKeyPress = true;
                        }
                    };
                }
            }
        }

        // ==================== 2. Método que pega TODOS os controles (recursivo) ====================
        private static IEnumerable<Control> TodosOsControles(Control control)
        {
            var pilha = new Stack<Control>();
            pilha.Push(control);

            while (pilha.Count > 0)
            {
                var atual = pilha.Pop();
                yield return atual;

                foreach (Control filho in atual.Controls)
                    pilha.Push(filho);
            }
        }

        // ==================== 3. (Opcional) Enter funciona como Tab no form inteiro ====================
        public static void ConfigurarEnterComoTab(Form form)
        {
            if (form == null) return;

            form.KeyPreview = true;

            // remove inscrição anterior (se houver) para evitar handlers duplicados
            form.KeyDown -= Utilitario_Form_KeyDown_EnterToTab;
            form.KeyDown += Utilitario_Form_KeyDown_EnterToTab;

            void Utilitario_Form_KeyDown_EnterToTab(object sender, KeyEventArgs e)
            {
                try
                {
                    if (e.KeyCode != Keys.Enter) return;

                    Control active = form.ActiveControl;
                    if (active == null) return;

                    // Debug temporário: grava o tipo do controle ativo ao pressionar Enter
                    try
                    {
                        File.AppendAllText("debug_enter_to_tab.txt",
                            $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - Enter pressed - ActiveControl: {active.GetType().FullName} (Name={active.Name}){Environment.NewLine}");
                    }
                    catch { /* não atrapalha se falhar */ }

                    // Se o controle for um TextBoxBase (TextBox, RichTextBox, MaskedTextBox, etc)
                    if (active is TextBoxBase tb)
                    {
                        // Se for multiline que aceita Enter, deixa o Enter passar
                        if (tb.Multiline)
                            return;
                    }

                    // KryptonTextBox (verificação direta)
                    if (active is KryptonTextBox ktxt)
                    {
                        // KryptonTextBox normalmente não é multiline — avança
                    }

                    // Ignorar onde Enter tem função especial
                    if (active is ButtonBase || active is LinkLabel || active is DataGridView || active is ToolStrip)
                        return;

                    // Controles que queremos avançar com Enter
                    bool deveAvancar =
                        active is TextBox ||
                        active is TextBoxBase ||
                        active is KryptonTextBox ||
                        active is ComboBox ||
                        active is MaskedTextBox ||
                        active is NumericUpDown ||
                        active is DateTimePicker;

                    if (!deveAvancar) return;

                    // Avança para o próximo controle
                    form.SelectNextControl(active, forward: true, tabStopOnly: true, nested: true, wrap: true);
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                catch
                {
                    // se der qualquer erro aqui, não deixe quebrar o app
                }
            }

        }

        // ==============================================================
        // MÉTODO AUXILIAR: aplica o efeito bonito no KryptonTextBox
        // ==============================================================
        public static void AplicarEfeitoFoco(KryptonTextBox textBox)
        {
            // Cor quando ganha foco
            textBox.StateActive.Back.Color1 = System.Drawing.Color.PaleTurquoise;
            

            // Evento Enter
            textBox.Enter += (s, e) =>
            {
                textBox.StateActive.Back.Color1 = System.Drawing.Color.PaleTurquoise;                
            };

            // Evento Leave (volta ao normal)
            textBox.Leave += (s, e) =>
            {
                textBox.StateActive.Back.Color1 = textBox.StateCommon.Back.Color1;                
            };
        }
        private static void FormatarMoeda(Control txt, string valor)
        {
            if (string.IsNullOrWhiteSpace(valor)) { txt.Text = "0,00"; return; }

            if (decimal.TryParse(Regex.Replace(valor, @"[^\d,]", ""), NumberStyles.Any, CulturaBR, out decimal numero))
                txt.Text = numero.ToString("N2", CulturaBR);
            else
                txt.Text = "0,00";

            if (txt is TextBox tb) tb.SelectionStart = tb.Text.Length;
            if (txt is KryptonTextBox ktb) ktb.SelectionStart = ktb.Text.Length;
        }

        /// <summary>
        /// Converte string com máscara monetária para decimal
        /// "R$ 1.234,56" → 1234.56m
        /// "999,90" → 999.90m
        /// "1.000.000,00" → 1000000.00m
        /// </summary>
        public static decimal ToDecimal(this string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
                return 0m;

            // Remove tudo que não for número, vírgula ou ponto
            var limpo = Regex.Replace(valor, @"[^\d,.]", "");

            // Substitui ponto por nada (milhar) e vírgula por ponto (decimal)
            limpo = limpo.Replace(".", "").Replace(",", ".");

            return decimal.TryParse(limpo, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal resultado)
                ? resultado
                : 0m;
        }

        /// <summary>
        /// Versão estática do ToDecimal (caso não queira usar extensão)
        /// </summary>
        public static decimal RemoverMascaraMoeda(string valor) => valor.ToDecimal();
               
        public static int ProximoId(string query)
        {
            using var conn = Conexao.Conex();
            var max = conn.ExecuteScalar<int?>(query);
            return (max ?? 0) + 1;
        }
        public static string FormatarTelefonesString(string telefone)
        {
            telefone = ApenasNumeros(telefone);

            // Telefone com 10 dígitos (ex: fixo: 11 2345-6789)
            if (telefone.Length == 10)
            {
                return $"({telefone.Substring(0, 2)}) {telefone.Substring(2, 4)}-{telefone.Substring(6, 4)}";
            }
            // Telefone com 11 dígitos (ex: celular: 11 91234-5678)
            if (telefone.Length == 11)
            {
                return $"({telefone.Substring(0, 2)}) {telefone.Substring(2, 5)}-{telefone.Substring(7, 4)}";
            }
            // Se não tiver 10 ou 11 dígitos, retorna como está
            return telefone;
        }

        public static void FormatarTelefone(KryptonTextBox txtTelefone)
        {
            txtTelefone.Leave += (sender, e) =>
            {
                string textoOriginal = txtTelefone.Text.Trim();
                string apenasNumeros = Regex.Replace(textoOriginal, @"\D", ""); // remove tudo que não for número

                // Se vazio → aceita
                if (string.IsNullOrWhiteSpace(apenasNumeros))
                {
                    txtTelefone.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
                    txtTelefone.Text = "";
                    return;
                }
                // Celular com DDD deve ter exatamente 11 dígitos
                if (apenasNumeros.Length != 11)
                {
                    txtTelefone.StateCommon.Border.Color1 = System.Drawing.Color.Crimson;
                    MessageBox.Show("Telefone deve conter 11 dígitos (DDD + número).", "Telefone Inválido",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTelefone.Focus();
                    return;
                }
                // Verifica se o DDD é válido (não começa com 0 e está entre 11 e 99)
                string ddd = apenasNumeros.Substring(0, 2);
                if (ddd == "00" || !int.TryParse(ddd, out int n) || n < 11 || n > 99)
                {
                    txtTelefone.StateCommon.Border.Color1 = System.Drawing.Color.Crimson;
                    MessageBox.Show("DDD inválido. Use um DDD válido (ex: 11, 21, 31...)", "Telefone Inválido",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTelefone.Focus();
                    return;
                }
                // Se já estiver perfeitamente formatado → mantém como o usuário digitou
                if (Regex.IsMatch(textoOriginal, @"^\(\d{2}\) \d{5}-\d{4}$"))
                {
                    txtTelefone.Text = textoOriginal;
                }
                else
                {
                    // Formata automaticamente: (11) 98765-4321
                    txtTelefone.Text = $"({apenasNumeros.Substring(0, 2)}) " +
                                       $"{apenasNumeros.Substring(2, 5)}-" +
                                       $"{apenasNumeros.Substring(7, 4)}";
                }
                // Telefone válido → borda verde
                txtTelefone.StateCommon.Border.Color1 = System.Drawing.Color.MediumSeaGreen;
            };
            // Cor ao entrar no campo
            txtTelefone.Enter += (s, e) => txtTelefone.StateCommon.Border.Color1 = System.Drawing.Color.DeepSkyBlue;
        }

        public static void LimparCampos(Control container)
        {
            foreach (Control c in container.Controls)
            {
                switch (c)
                {
                    case TextBoxBase tb: tb.Clear(); break;
                    case Krypton.Toolkit.KryptonTextBox ktb: ktb.Clear(); break;
                    case ComboBox cb: cb.SelectedIndex = -1; break;
                    case Krypton.Toolkit.KryptonComboBox kcb: kcb.SelectedIndex = -1; break;
                    case DateTimePicker dtp: dtp.Value = DateTime.Now; break;
                    case Krypton.Toolkit.KryptonDateTimePicker kdp: kdp.Value = DateTime.Now; break;
                    case CheckBox chk: chk.Checked = false; break;
                    case RadioButton rb: rb.Checked = false; break;

                    // 🔹 Novo: limpar PictureBox
                    case PictureBox pb:
                        if (pb.Image != null)
                        {
                            pb.Image.Dispose();
                            pb.Image = null;
                        }
                        break;                  
                }

                if (c.HasChildren) LimparCampos(c);
            }
        }

        // ==============================================================
        // 7. TOTAL DE REGISTROS NO GRID
        // ==============================================================
        public static void AtualizarTotalKrypton(ToolStripStatusLabel lbl, DataGridView dgv)
            => lbl.Text = $"Total: {dgv.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow)} registro(s)";
        public static void AtualizarTotal(Label lbl, DataGridView dgv)
           => lbl.Text = $"Total: {dgv.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow)} registro(s)";


        public static void AtualizaTotalKrypton(KryptonLabel lbl, DataGridView dgv)
                => lbl.Text = $"Total: {dgv.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow)} registro(s)";


        // ==============================================================
        // 8. SOMAR COLUNA DO DATAGRIDVIEW
        // ==============================================================
        public static decimal SomarColuna(DataGridView dgv, string coluna)
        {
            return dgv.Rows.Cast<DataGridViewRow>()
                .Where(r => !r.IsNewRow)
                .Sum(r => decimal.TryParse(r.Cells[coluna].Value?.ToString(), out decimal v) ? v : 0);
        }
        // ==============================================================
        // 9. PESQUISAR COM DAPPER (RÁPIDO E SEGURO)
        // ==============================================================
        public static void Pesquisar(string query, object parametros, DataGridView dgv)
        {
            using var conn = GVC.Helpers.Conexao.Conex();
            var dt = new DataTable();
            dt.Load(conn.ExecuteReader(query, parametros));
            dgv.DataSource = dt.Rows.Count > 0 ? dt : null;
        }
        // ==============================================================
        // 10. PREENCHER COMBOBOX (COM DAPPER)
        // ==============================================================
        public static void PreencherCombo(ComboBox cb, string query, string display, string value, object param = null)
        {
            using var conn = GVC.Helpers.Conexao.Conex();
            var lista = conn.Query(query, param).Select(x => new { Display = x.GetType().GetProperty(display).GetValue(x), Value = x.GetType().GetProperty(value).GetValue(x) });
            cb.DisplayMember = "Display"; cb.ValueMember = "Value"; cb.DataSource = lista.ToList();
        }

        // ==============================================================
        // 11. VERIFICAR DUPLICIDADE
        // ==============================================================
        public static bool Existe(string query, object parametros = null)
        {
            using var conn = GVC.Helpers.Conexao.Conex();
            return conn.QuerySingle<int>(query, parametros) > 0;
        }

        // ==============================================================
        // 12. EFECTO FOCO NOS KRYPTON TEXTBOX
        // ==============================================================
        public static void AplicarEfeitoFoco(Control container)
        {
            foreach (Control c in container.Controls)
            {
                if (c is KryptonTextBox ktb)
                {
                    ktb.Enter += (s, e) => ktb.StateActive.Back.Color1 = System.Drawing.Color.PaleTurquoise;
                    ktb.Leave += (s, e) => ktb.StateActive.Back.Color1 = ktb.StateCommon.Back.Color1;
                }
                if (c.HasChildren) AplicarEfeitoFoco(c);
            }
        }
    
        public static ProdutosModel? BuscarProdutoPorRef(string referencia)
        {
            if (string.IsNullOrWhiteSpace(referencia)) return null;

            const string sql = "SELECT * FROM Produtos WHERE Referencia = @Ref LIMIT 1";
            using var conn = GVC.Helpers.Conexao.Conex();
            return conn.QueryFirstOrDefault<ProdutosModel>(sql, new { Ref = referencia });
        }
       
        public static string ApenasNumeros(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto)) return "";
            return Regex.Replace(texto, @"\D", "");
        }
        // WRAPPER para TELEFONE -------------------------------------------
        public static void MascaraTelefone(object sender, KeyPressEventArgs e)
        {
            if (sender is KryptonTextBox txt)
                AplicarMascaraTelefone(e, txt);
        }
        public static void AplicarMascaraTelefone(KeyPressEventArgs e, KryptonTextBox textBox)
        {
            // Permite backspace
            if (e.KeyChar == (char)Keys.Back)
                return;

            // Só permite números
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            // Remove tudo que não é número
            string numeros = new string(textBox.Text.Where(char.IsDigit).ToArray());

            // Limite: 11 números (DDD + 9 dígitos)
            if (numeros.Length >= 11)
            {
                e.Handled = true;
                return;
            }

            // Adiciona o novo número
            numeros += e.KeyChar;

            // Monta máscara
            string formatado = "";

            if (numeros.Length <= 2)
            {
                // (DD
                formatado = $"({numeros}";
            }
            else if (numeros.Length <= 6)
            {
                // (DD) XXXX
                formatado = $"({numeros.Substring(0, 2)}) {numeros.Substring(2)}";
            }
            else if (numeros.Length <= 10)
            {
                // 10 dígitos: (DD) XXXX-XXXX
                formatado = $"({numeros.Substring(0, 2)}) {numeros.Substring(2, 4)}-{numeros.Substring(6)}";
            }
            else
            {
                // 11 dígitos: (DD) 9XXXX-XXXX
                formatado = $"({numeros.Substring(0, 2)}) {numeros.Substring(2, 5)}-{numeros.Substring(7)}";
            }

            // Atualiza textbox
            textBox.Text = formatado;

            // Cursor no fim
            textBox.SelectionStart = textBox.Text.Length;

            // Impede caractere "solto"
            e.Handled = true;
        }


        public static string FormatarCPF(string cpf)
        {
            cpf = ApenasNumeros(cpf);
            if (cpf.Length != 11) return cpf;
            return $"{cpf.Substring(0, 3)}.{cpf.Substring(3, 3)}.{cpf.Substring(6, 3)}-{cpf.Substring(9, 2)}";
        }

        public static bool ValidarCPF(string cpf)
        {
            cpf = ApenasNumeros(cpf);
            if (cpf.Length != 11) return false;
            if (new string(cpf[0], 11) == cpf) return false;
            int soma = 0;
            for (int i = 0; i < 9; i++) soma += (cpf[i] - '0') * (10 - i);
            int resto = (soma * 10) % 11;
            if (resto == 10 || resto == 11) resto = 0;
            if (resto != (cpf[9] - '0')) return false;
            soma = 0;
            for (int i = 0; i < 10; i++) soma += (cpf[i] - '0') * (11 - i);
            resto = (soma * 10) % 11;
            if (resto == 10 || resto == 11) resto = 0;
            return resto == (cpf[10] - '0');
        }

        public static string FormatarCNPJ(string cnpj)
        {
            cnpj = ApenasNumeros(cnpj);
            if (cnpj.Length != 14) return cnpj;
            return $"{cnpj.Substring(0, 2)}.{cnpj.Substring(2, 3)}.{cnpj.Substring(5, 3)}/{cnpj.Substring(8, 4)}-{cnpj.Substring(12, 2)}";
        }

        public static bool ValidarCNPJ(string cnpj)
        {
            cnpj = ApenasNumeros(cnpj);
            if (cnpj.Length != 14) return false;
            if (new string(cnpj[0], 14) == cnpj) return false;
            int[] multiplicadores1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicadores2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma = 0;
            for (int i = 0; i < 12; i++) soma += (cnpj[i] - '0') * multiplicadores1[i];
            int resto = soma % 11;
            int digito1 = resto < 2 ? 0 : 11 - resto;
            if ((cnpj[12] - '0') != digito1) return false;
            soma = 0;
            for (int i = 0; i < 13; i++) soma += (cnpj[i] - '0') * multiplicadores2[i];
            resto = soma % 11;
            int digito2 = resto < 2 ? 0 : 11 - resto;
            return (cnpj[13] - '0') == digito2;
        }

        // Novos métodos: validador que aplica formatação e cor. Retorna true se válido.
        public static bool ValidarEFormatarCPFnoTextbox(KryptonTextBox txt)
        {
            var original = txt.Text.Trim();
            var apenasNumeros = ApenasNumeros(original);
            if (string.IsNullOrEmpty(apenasNumeros))
            {
                txt.StateCommon.Border.Color1 = Color.Gray;
                txt.Text = "";
                return true; // vazio é considerado "sem erro" — quem chama decide
            }

            if (apenasNumeros.Length != 11 || !ValidarCPF(apenasNumeros))
            {
                txt.StateCommon.Border.Color1 = Color.Crimson;
                return false;
            }

            txt.Text = FormatarCPF(apenasNumeros);
            txt.StateCommon.Border.Color1 = Color.MediumSeaGreen;
            return true;
        }

        public static bool ValidarEFormatarCNPJnoTextbox(KryptonTextBox txt)
        {
            var original = txt.Text.Trim();
            var apenasNumeros = ApenasNumeros(original);
            if (string.IsNullOrEmpty(apenasNumeros))
            {
                txt.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
                txt.Text = "";
                return true;
            }

            if (apenasNumeros.Length != 14 || !ValidarCNPJ(apenasNumeros))
            {
                txt.StateCommon.Border.Color1 = Color.Crimson;
                return false;
            }

            txt.Text = FormatarCNPJ(apenasNumeros);
            txt.StateCommon.Border.Color1 = Color.MediumSeaGreen;
            return true;
        }

        // Métodos de máscara (KeyPress) — já existentes, mantenha-os.
        public static void AplicarMascaraCPF(KeyPressEventArgs e, KryptonTextBox textBox)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) { e.Handled = true; return; }
            if (e.KeyChar == (char)Keys.Back) return;

            string texto = textBox.Text.Replace(".", "").Replace("-", "");
            if (texto.Length == 11) { e.Handled = true; return; }

            if (texto.Length == 3 || texto.Length == 6) textBox.Text += ".";
            else if (texto.Length == 9) textBox.Text += "-";

            textBox.SelectionStart = textBox.Text.Length;
        }

        public static void AplicarMascaraCNPJ(KeyPressEventArgs e, KryptonTextBox textBox)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) { e.Handled = true; return; }
            if (e.KeyChar == (char)Keys.Back) return;

            string texto = textBox.Text.Replace(".", "").Replace("/", "").Replace("-", "");
            if (texto.Length == 14) { e.Handled = true; return; }

            if (texto.Length == 2 || texto.Length == 5) textBox.Text += ".";
            else if (texto.Length == 8) textBox.Text += "/";
            else if (texto.Length == 12) textBox.Text += "-";

            textBox.SelectionStart = textBox.Text.Length;
        }


        // WRAPPER para CPF -------------------------------------------
        public static void MascaraCPF(object sender, KeyPressEventArgs e)
        {
            if (sender is KryptonTextBox txt)
                AplicarMascaraCPF(e, txt); // chama sua função original
        }

        // WRAPPER para CNPJ ------------------------------------------
        public static void MascaraCNPJ(object sender, KeyPressEventArgs e)
        {
            if (sender is KryptonTextBox txt)
                AplicarMascaraCNPJ(e, txt); // chama sua função original
        }
        public static bool ValidarEFormatarCEPnoTextbox(KryptonTextBox txt)
        {
            var original = txt.Text.Trim();
            var apenasNumeros = ApenasNumeros(original);

            // ⭐ Se estiver vazio → não dá erro
            if (string.IsNullOrWhiteSpace(apenasNumeros))
            {
                txt.StateCommon.Border.Color1 = Color.Gray; // aparência neutra
                txt.Text = "";
                return true; // válido, pode salvar
            }

            // Se não tiver 8 dígitos → inválido
            if (apenasNumeros.Length != 8)
            {
                txt.StateCommon.Border.Color1 = Color.Crimson;
                return false;
            }

            // Formata → 99.999-999
            txt.Text = $"{apenasNumeros.Substring(0, 2)}.{apenasNumeros.Substring(2, 3)}-{apenasNumeros.Substring(5, 3)}";
            txt.StateCommon.Border.Color1 = Color.MediumSeaGreen;
            return true;
        }
        public static void AplicarMascaraCEP(KeyPressEventArgs e, KryptonTextBox textBox)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == (char)Keys.Back) return;

            string texto = ApenasNumeros(textBox.Text);

            if (texto.Length == 8)  // impede mais que 8 números
            {
                e.Handled = true;
                return;
            }

            if (texto.Length == 2)
                textBox.Text += ".";
            else if (texto.Length == 5)
                textBox.Text += "-";

            textBox.SelectionStart = textBox.Text.Length;
        }
        public static void MascaraCEP(object sender, KeyPressEventArgs e)
        {
            if (sender is KryptonTextBox txt)
                AplicarMascaraCEP(e, txt);
        }

      
        public static void MascaraIE(KeyPressEventArgs e, Krypton.Toolkit.KryptonTextBox txt)
        {
            // Permite somente números e Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }

            // Limita a 14 dígitos
            if (char.IsDigit(e.KeyChar) && txt.Text.Length >= 14)
                e.Handled = true;
        }

        public static bool ValidarIE(string ie)
        {
            if (string.IsNullOrWhiteSpace(ie))
                return false;

            ie = ie.Trim();

            // Remove qualquer caractere que não seja número
            ie = new string(ie.Where(char.IsDigit).ToArray());

            // A maioria das IEs tem entre 2 e 14 dígitos
            return ie.Length >= 2 && ie.Length <= 14;
        }

        public class ViaCepResponse
        {
            public string cep { get; set; }
            public string logradouro { get; set; }
            public string complemento { get; set; }
            public string bairro { get; set; }
            public string localidade { get; set; }
            public string uf { get; set; }
            public string ibge { get; set; }
            public string gia { get; set; }
            public string ddd { get; set; }
            public string siafi { get; set; }
            public bool erro { get; set; }
        }

        public static async Task<ViaCepResponse?> BuscarCepAsync(string cep)
        {
            cep = ApenasNumeros(cep);
            if (cep.Length != 8) return null;

            using HttpClient client = new HttpClient();
            string url = $"https://viacep.com.br/ws/{cep}/json/";

            try
            {
                var response = await client.GetAsync(url);
                if (!response.IsSuccessStatusCode) return null;

                string json = await response.Content.ReadAsStringAsync();
                var dados = System.Text.Json.JsonSerializer.Deserialize<ViaCepResponse>(json);

                if (dados == null || dados.erro) return null;

                return dados;
            }
            catch
            {
                return null;
            }
        }


        //public static string FormatarCPF(string cpf)
        //{
        //    cpf = ApenasNumeros(cpf);
        //    return Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
        //}

        //public static string FormatarCNPJ(string cnpj)
        //{
        //    cnpj = ApenasNumeros(cnpj);
        //    return Convert.ToUInt64(cnpj).ToString(@"00\.000\.000\/0000\-00");
        //}
        public static string FormatarCEP(string cep)
        {
            if (string.IsNullOrWhiteSpace(cep))
                return "";

            cep = new string(cep.Where(char.IsDigit).ToArray());

            if (cep.Length == 8)
                return $"{cep.Substring(0, 5)}-{cep.Substring(5, 3)}";

            return cep;
        }

        public static string FormatarTelefoneTexto(string tel)
        {
            tel = ApenasNumeros(tel);

            if (tel.Length == 10)
                return Convert.ToUInt64(tel).ToString(@"(00)0000\-0000");

            if (tel.Length == 11)
                return Convert.ToUInt64(tel).ToString(@"(00)00000\-0000");

            return tel;
        }

        public static string FormatarCepTexto(string cep)
        {
            cep = ApenasNumeros(cep);
            return Convert.ToUInt64(cep).ToString(@"00000\-000");
        }
        /// <summary>
        /// Aplica comportamento de foco em KryptonTextBox:
        /// Verde claro ao ganhar foco, branco ao perder.
        /// </summary>
        public static void AplicarCorFoco(KryptonTextBox txt)
        {
            txt.Enter += (s, e) =>
            {
                txt.StateCommon.Back.Color1 = Color.LightGreen;
            };

            txt.Leave += (s, e) =>
            {
                txt.StateCommon.Back.Color1 = Color.White;
            };
        }
        public static string ZerosEsquerda(int numero, int tamanho) => numero.ToString().PadLeft(tamanho, '0');
        //public static string ZerosEsquerda(string texto, int tamanho) => texto.PadLeft(tamanho, '0');





        public static void CarregarFormasPagamento(KryptonComboBox cmb)
        {
            try
            {
                cmb.Items.Clear();

                // Item padrão tipado (NUNCA string solta)
                cmb.Items.Add(new FormaPagamentoItem(0, "Selecione uma forma de pagamento"));
                cmb.SelectedIndex = 0;

                string query = @"
            SELECT FormaPgtoID, FormaPgto 
            FROM FormaPgto 
            ORDER BY 
                CASE 
                    WHEN FormaPgto LIKE 'Dinheiro%' THEN 1
                    WHEN FormaPgto LIKE 'PIX%' THEN 2
                    WHEN FormaPgto LIKE 'Cartão Débito%' THEN 3
                    WHEN FormaPgto LIKE 'Cartão Crédito%' THEN 4
                    ELSE 5
                END,
                FormaPgto";

                using (var connection = Helpers.Conexao.Conex())
                using (var command = new SqliteCommand(query, connection))
                {
                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmb.Items.Add(new FormaPagamentoItem(
                                Convert.ToInt32(reader["FormaPgtoID"]),
                                reader["FormaPgto"].ToString()
                            ));
                        }
                    }
                }

                // Exibe Descricao corretamente
                cmb.DisplayMember = nameof(FormaPagamentoItem.Descricao);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Erro ao carregar formas de pagamento:\n{ex.Message}",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

    }

    /// <summary>
    /// Classe auxiliar para representar item de forma de pagamento.
    /// </summary>
    public class FormaPagamentoItem
    {
        public int Id { get; }
        public string Descricao { get; }

        public FormaPagamentoItem(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }

        public override string ToString() => Descricao;
    }
}