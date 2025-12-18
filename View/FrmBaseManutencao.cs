using Dapper;
using GVC.Helpers;
using Krypton.Toolkit;
using Microsoft.Data.Sqlite;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GVC
{
    public partial class FrmBaseManutencao : KryptonForm
    {
        public FrmBaseManutencao()
        {
            InitializeComponent();
            this.KeyPreview = true; // Permite capturar teclas no form
            this.Load += FrmBaseManutencao_Load;
        }

        private void FrmBaseManutencao_Load(object sender, EventArgs e)
        {
            Utilitario.AplicarEfeitoFoco(this);
        }

        // ==============================================================
        // PROPRIEDADES PÚBLICAS (mantidas para compatibilidade)
        // ==============================================================
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string NomeUsuario { get; set; } = "";
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string NivelAcesso { get; set; } = "";
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int ProdutoID { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int ClienteID { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int FornecedorID { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int VendaID { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string NomeCliente { get; set; } = "";
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string NomeProduto { get; set; } = "";
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string NomeFornecedor { get; set; } = "";

        // ==============================================================
        // MÉTODOS UTILITÁRIOS MODERNOS
        // ==============================================================

        /// <summary>
        /// Limpa todos os campos do formulário (TextBox, ComboBox, DateTimePicker, etc) - SUPORTE COMPLETO AO KRYPTON
        /// </summary>
        public virtual void LimparCampos()
        {
            Utilitario.LimparCampos(this);
        }

        /// <summary>
        /// Gera o próximo ID de qualquer tabela de forma segura
        /// </summary>
        public virtual int ProximoId(string query)
        {
            using var conn = Conexao.Conex();
            var max = conn.ExecuteScalar<int?>(query);
            return (max ?? 0) + 1;
        }

        /// <summary>
        /// Executa uma consulta e retorna DataTable (para grids)
        /// </summary>
        public virtual DataTable ExecutarConsulta(string sql, object parametros = null)
        {
            using var conn = GVC.Helpers.Conexao.Conex();
            var dt = new DataTable();
            dt.Load(conn.ExecuteReader(sql, parametros));
            return dt;
        }

        /// <summary>
        /// Executa comando INSERT/UPDATE/DELETE
        /// </summary>
        public virtual int ExecutarComando(string sql, object parametros)
        {
            using var conn = GVC.Helpers.Conexao.Conex();
            return conn.Execute(sql, parametros);
        }

        /// <summary>
        /// Busca um registro único e retorna como objeto (Dapper)
        /// </summary>
        public virtual T BuscarUnico<T>(string sql, object parametros = null)
        {
            using var conn = GVC.Helpers.Conexao.Conex();
            return conn.QueryFirstOrDefault<T>(sql, parametros);
        }

        // ==============================================================
        // EVENTOS GLOBAIS DO FORMULÁRIO
        // ==============================================================

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.KeyCode == Keys.Escape)
            {
                if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    this.Close();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // Aplica efeito de foco em todos os KryptonTextBox
            Utilitario.AplicarEfeitoFoco(this);
        }

        // ==============================================================
        // MÉTODOS ANTIGOS MANTIDOS POR COMPATIBILIDADE (opcional)
        // ==============================================================

        [Obsolete("Use LimparCampos() em vez disso")]
        public virtual void LimparCamposObsoleto()
        {
            LimparCampos();
        }

        [Obsolete("Use ProximoId() em vez disso")]
        public virtual int RetornaCodigoContaMaisUm(string query)
        {
            using var conn = GVC.Helpers.Conexao.Conex();
            var result = conn.ExecuteScalar(query);
            return (result == null || result == DBNull.Value) ? 1 : (Convert.ToInt32(result) + 1);
        }

        [Obsolete("Use ExecutarConsulta() em vez disso")]
        public virtual DataTable LocalizarGeral(SqliteCommand comando)
        {
            using var conn = GVC.Helpers.Conexao.Conex();
            comando.Connection = conn;
            conn.Open();

            var dt = new DataTable();
            dt.Load(comando.ExecuteReader());  // <--- ESSA É A FORMA CORRETA E MODERNA

            return dt;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}