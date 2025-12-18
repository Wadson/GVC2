namespace GVC.View
{
    partial class FrmExclusaoOrfaos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvVendas = new Krypton.Toolkit.KryptonDataGridView();
            dgvPagamentosParciais = new Krypton.Toolkit.KryptonDataGridView();
            dgvItensVenda = new Krypton.Toolkit.KryptonDataGridView();
            dgvParcelas = new Krypton.Toolkit.KryptonDataGridView();
            btnExcluirPagamentoParcial = new Krypton.Toolkit.KryptonButton();
            btnExcluirVenda = new Krypton.Toolkit.KryptonButton();
            btnExcluirParcelas = new Krypton.Toolkit.KryptonButton();
            btnExcluirItensVenda = new Krypton.Toolkit.KryptonButton();
            label28 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnSair = new Krypton.Toolkit.KryptonButton();
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            ((System.ComponentModel.ISupportInitialize)dgvVendas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPagamentosParciais).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvItensVenda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvParcelas).BeginInit();
            SuspendLayout();
            // 
            // dgvVendas
            // 
            dgvVendas.AllowUserToAddRows = false;
            dgvVendas.AllowUserToDeleteRows = false;
            dgvVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVendas.Location = new Point(-1, 52);
            dgvVendas.Name = "dgvVendas";
            dgvVendas.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlueDarkMode;
            dgvVendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVendas.Size = new Size(387, 154);
            dgvVendas.TabIndex = 596;
            // 
            // dgvPagamentosParciais
            // 
            dgvPagamentosParciais.AllowUserToAddRows = false;
            dgvPagamentosParciais.AllowUserToDeleteRows = false;
            dgvPagamentosParciais.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPagamentosParciais.Location = new Point(406, 52);
            dgvPagamentosParciais.Name = "dgvPagamentosParciais";
            dgvPagamentosParciais.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlueDarkMode;
            dgvPagamentosParciais.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPagamentosParciais.Size = new Size(362, 154);
            dgvPagamentosParciais.TabIndex = 597;
            // 
            // dgvItensVenda
            // 
            dgvItensVenda.AllowUserToAddRows = false;
            dgvItensVenda.AllowUserToDeleteRows = false;
            dgvItensVenda.Location = new Point(406, 281);
            dgvItensVenda.Name = "dgvItensVenda";
            dgvItensVenda.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlueDarkMode;
            dgvItensVenda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItensVenda.Size = new Size(362, 154);
            dgvItensVenda.TabIndex = 599;
            // 
            // dgvParcelas
            // 
            dgvParcelas.AllowUserToAddRows = false;
            dgvParcelas.AllowUserToDeleteRows = false;
            dgvParcelas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParcelas.Location = new Point(-1, 281);
            dgvParcelas.Name = "dgvParcelas";
            dgvParcelas.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlueDarkMode;
            dgvParcelas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvParcelas.Size = new Size(387, 154);
            dgvParcelas.TabIndex = 600;
            // 
            // btnExcluirPagamentoParcial
            // 
            btnExcluirPagamentoParcial.ButtonStyle = Krypton.Toolkit.ButtonStyle.Cluster;
            btnExcluirPagamentoParcial.CornerRoundingRadius = -1F;
            btnExcluirPagamentoParcial.Location = new Point(655, 212);
            btnExcluirPagamentoParcial.Name = "btnExcluirPagamentoParcial";
            btnExcluirPagamentoParcial.OverrideDefault.Back.Color1 = Color.Red;
            btnExcluirPagamentoParcial.OverrideDefault.Back.Color2 = Color.Red;
            btnExcluirPagamentoParcial.OverrideDefault.Back.ColorAngle = 45F;
            btnExcluirPagamentoParcial.OverrideDefault.Border.Color1 = Color.Red;
            btnExcluirPagamentoParcial.OverrideDefault.Border.Color2 = Color.Red;
            btnExcluirPagamentoParcial.OverrideDefault.Border.ColorAngle = 45F;
            btnExcluirPagamentoParcial.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExcluirPagamentoParcial.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnExcluirPagamentoParcial.OverrideDefault.Border.Rounding = 20F;
            btnExcluirPagamentoParcial.OverrideDefault.Border.Width = 1;
            btnExcluirPagamentoParcial.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Silver;
            btnExcluirPagamentoParcial.Size = new Size(113, 25);
            btnExcluirPagamentoParcial.StateCommon.Back.Color1 = Color.Red;
            btnExcluirPagamentoParcial.StateCommon.Back.Color2 = Color.Red;
            btnExcluirPagamentoParcial.StateCommon.Back.ColorAngle = 45F;
            btnExcluirPagamentoParcial.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnExcluirPagamentoParcial.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnExcluirPagamentoParcial.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExcluirPagamentoParcial.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnExcluirPagamentoParcial.StateCommon.Border.Width = 1;
            btnExcluirPagamentoParcial.StateCommon.Content.ShortText.Color1 = Color.White;
            btnExcluirPagamentoParcial.StateCommon.Content.ShortText.Color2 = Color.White;
            btnExcluirPagamentoParcial.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluirPagamentoParcial.StatePressed.Back.Color1 = Color.Red;
            btnExcluirPagamentoParcial.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnExcluirPagamentoParcial.StatePressed.Back.ColorAngle = 135F;
            btnExcluirPagamentoParcial.StatePressed.Border.Color1 = Color.Red;
            btnExcluirPagamentoParcial.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnExcluirPagamentoParcial.StatePressed.Border.ColorAngle = 135F;
            btnExcluirPagamentoParcial.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExcluirPagamentoParcial.StatePressed.Border.Rounding = 20F;
            btnExcluirPagamentoParcial.StatePressed.Border.Width = 1;
            btnExcluirPagamentoParcial.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnExcluirPagamentoParcial.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnExcluirPagamentoParcial.StateTracking.Back.ColorAngle = 45F;
            btnExcluirPagamentoParcial.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnExcluirPagamentoParcial.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnExcluirPagamentoParcial.StateTracking.Border.ColorAngle = 45F;
            btnExcluirPagamentoParcial.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExcluirPagamentoParcial.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnExcluirPagamentoParcial.StateTracking.Border.Rounding = 20F;
            btnExcluirPagamentoParcial.StateTracking.Border.Width = 1;
            btnExcluirPagamentoParcial.TabIndex = 628;
            btnExcluirPagamentoParcial.Values.Text = "&Excluir";
            btnExcluirPagamentoParcial.Click += btnExcluirPagamentoParcial_Click;
            // 
            // btnExcluirVenda
            // 
            btnExcluirVenda.ButtonStyle = Krypton.Toolkit.ButtonStyle.Cluster;
            btnExcluirVenda.CornerRoundingRadius = -1F;
            btnExcluirVenda.Location = new Point(273, 212);
            btnExcluirVenda.Name = "btnExcluirVenda";
            btnExcluirVenda.OverrideDefault.Back.Color1 = Color.Red;
            btnExcluirVenda.OverrideDefault.Back.Color2 = Color.Red;
            btnExcluirVenda.OverrideDefault.Back.ColorAngle = 45F;
            btnExcluirVenda.OverrideDefault.Border.Color1 = Color.Red;
            btnExcluirVenda.OverrideDefault.Border.Color2 = Color.Red;
            btnExcluirVenda.OverrideDefault.Border.ColorAngle = 45F;
            btnExcluirVenda.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExcluirVenda.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnExcluirVenda.OverrideDefault.Border.Rounding = 20F;
            btnExcluirVenda.OverrideDefault.Border.Width = 1;
            btnExcluirVenda.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Silver;
            btnExcluirVenda.Size = new Size(113, 25);
            btnExcluirVenda.StateCommon.Back.Color1 = Color.Red;
            btnExcluirVenda.StateCommon.Back.Color2 = Color.Red;
            btnExcluirVenda.StateCommon.Back.ColorAngle = 45F;
            btnExcluirVenda.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnExcluirVenda.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnExcluirVenda.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExcluirVenda.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnExcluirVenda.StateCommon.Border.Width = 1;
            btnExcluirVenda.StateCommon.Content.ShortText.Color1 = Color.White;
            btnExcluirVenda.StateCommon.Content.ShortText.Color2 = Color.White;
            btnExcluirVenda.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluirVenda.StatePressed.Back.Color1 = Color.Red;
            btnExcluirVenda.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnExcluirVenda.StatePressed.Back.ColorAngle = 135F;
            btnExcluirVenda.StatePressed.Border.Color1 = Color.Red;
            btnExcluirVenda.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnExcluirVenda.StatePressed.Border.ColorAngle = 135F;
            btnExcluirVenda.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExcluirVenda.StatePressed.Border.Rounding = 20F;
            btnExcluirVenda.StatePressed.Border.Width = 1;
            btnExcluirVenda.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnExcluirVenda.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnExcluirVenda.StateTracking.Back.ColorAngle = 45F;
            btnExcluirVenda.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnExcluirVenda.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnExcluirVenda.StateTracking.Border.ColorAngle = 45F;
            btnExcluirVenda.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExcluirVenda.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnExcluirVenda.StateTracking.Border.Rounding = 20F;
            btnExcluirVenda.StateTracking.Border.Width = 1;
            btnExcluirVenda.TabIndex = 629;
            btnExcluirVenda.Values.Text = "&Excluir";
            btnExcluirVenda.Click += btnExcluirVenda_Click;
            // 
            // btnExcluirParcelas
            // 
            btnExcluirParcelas.ButtonStyle = Krypton.Toolkit.ButtonStyle.Cluster;
            btnExcluirParcelas.CornerRoundingRadius = -1F;
            btnExcluirParcelas.Location = new Point(273, 441);
            btnExcluirParcelas.Name = "btnExcluirParcelas";
            btnExcluirParcelas.OverrideDefault.Back.Color1 = Color.Red;
            btnExcluirParcelas.OverrideDefault.Back.Color2 = Color.Red;
            btnExcluirParcelas.OverrideDefault.Back.ColorAngle = 45F;
            btnExcluirParcelas.OverrideDefault.Border.Color1 = Color.Red;
            btnExcluirParcelas.OverrideDefault.Border.Color2 = Color.Red;
            btnExcluirParcelas.OverrideDefault.Border.ColorAngle = 45F;
            btnExcluirParcelas.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExcluirParcelas.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnExcluirParcelas.OverrideDefault.Border.Rounding = 20F;
            btnExcluirParcelas.OverrideDefault.Border.Width = 1;
            btnExcluirParcelas.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Silver;
            btnExcluirParcelas.Size = new Size(113, 25);
            btnExcluirParcelas.StateCommon.Back.Color1 = Color.Red;
            btnExcluirParcelas.StateCommon.Back.Color2 = Color.Red;
            btnExcluirParcelas.StateCommon.Back.ColorAngle = 45F;
            btnExcluirParcelas.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnExcluirParcelas.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnExcluirParcelas.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExcluirParcelas.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnExcluirParcelas.StateCommon.Border.Width = 1;
            btnExcluirParcelas.StateCommon.Content.ShortText.Color1 = Color.White;
            btnExcluirParcelas.StateCommon.Content.ShortText.Color2 = Color.White;
            btnExcluirParcelas.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluirParcelas.StatePressed.Back.Color1 = Color.Red;
            btnExcluirParcelas.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnExcluirParcelas.StatePressed.Back.ColorAngle = 135F;
            btnExcluirParcelas.StatePressed.Border.Color1 = Color.Red;
            btnExcluirParcelas.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnExcluirParcelas.StatePressed.Border.ColorAngle = 135F;
            btnExcluirParcelas.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExcluirParcelas.StatePressed.Border.Rounding = 20F;
            btnExcluirParcelas.StatePressed.Border.Width = 1;
            btnExcluirParcelas.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnExcluirParcelas.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnExcluirParcelas.StateTracking.Back.ColorAngle = 45F;
            btnExcluirParcelas.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnExcluirParcelas.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnExcluirParcelas.StateTracking.Border.ColorAngle = 45F;
            btnExcluirParcelas.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExcluirParcelas.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnExcluirParcelas.StateTracking.Border.Rounding = 20F;
            btnExcluirParcelas.StateTracking.Border.Width = 1;
            btnExcluirParcelas.TabIndex = 630;
            btnExcluirParcelas.Values.Text = "&Excluir";
            btnExcluirParcelas.Click += btnExcluirParcelas_Click;
            // 
            // btnExcluirItensVenda
            // 
            btnExcluirItensVenda.ButtonStyle = Krypton.Toolkit.ButtonStyle.Cluster;
            btnExcluirItensVenda.CornerRoundingRadius = -1F;
            btnExcluirItensVenda.Location = new Point(655, 441);
            btnExcluirItensVenda.Name = "btnExcluirItensVenda";
            btnExcluirItensVenda.OverrideDefault.Back.Color1 = Color.Red;
            btnExcluirItensVenda.OverrideDefault.Back.Color2 = Color.Red;
            btnExcluirItensVenda.OverrideDefault.Back.ColorAngle = 45F;
            btnExcluirItensVenda.OverrideDefault.Border.Color1 = Color.Red;
            btnExcluirItensVenda.OverrideDefault.Border.Color2 = Color.Red;
            btnExcluirItensVenda.OverrideDefault.Border.ColorAngle = 45F;
            btnExcluirItensVenda.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExcluirItensVenda.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnExcluirItensVenda.OverrideDefault.Border.Rounding = 20F;
            btnExcluirItensVenda.OverrideDefault.Border.Width = 1;
            btnExcluirItensVenda.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Silver;
            btnExcluirItensVenda.Size = new Size(113, 25);
            btnExcluirItensVenda.StateCommon.Back.Color1 = Color.Red;
            btnExcluirItensVenda.StateCommon.Back.Color2 = Color.Red;
            btnExcluirItensVenda.StateCommon.Back.ColorAngle = 45F;
            btnExcluirItensVenda.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnExcluirItensVenda.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnExcluirItensVenda.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExcluirItensVenda.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnExcluirItensVenda.StateCommon.Border.Width = 1;
            btnExcluirItensVenda.StateCommon.Content.ShortText.Color1 = Color.White;
            btnExcluirItensVenda.StateCommon.Content.ShortText.Color2 = Color.White;
            btnExcluirItensVenda.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluirItensVenda.StatePressed.Back.Color1 = Color.Red;
            btnExcluirItensVenda.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnExcluirItensVenda.StatePressed.Back.ColorAngle = 135F;
            btnExcluirItensVenda.StatePressed.Border.Color1 = Color.Red;
            btnExcluirItensVenda.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnExcluirItensVenda.StatePressed.Border.ColorAngle = 135F;
            btnExcluirItensVenda.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExcluirItensVenda.StatePressed.Border.Rounding = 20F;
            btnExcluirItensVenda.StatePressed.Border.Width = 1;
            btnExcluirItensVenda.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnExcluirItensVenda.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnExcluirItensVenda.StateTracking.Back.ColorAngle = 45F;
            btnExcluirItensVenda.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnExcluirItensVenda.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnExcluirItensVenda.StateTracking.Border.ColorAngle = 45F;
            btnExcluirItensVenda.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExcluirItensVenda.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnExcluirItensVenda.StateTracking.Border.Rounding = 20F;
            btnExcluirItensVenda.StateTracking.Border.Width = 1;
            btnExcluirItensVenda.TabIndex = 631;
            btnExcluirItensVenda.Values.Text = "&Excluir";
            btnExcluirItensVenda.Click += btnExcluirItensVenda_Click;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Microsoft Sans Serif", 14.25F);
            label28.ForeColor = Color.Green;
            label28.Location = new Point(141, 25);
            label28.Name = "label28";
            label28.Size = new Size(88, 24);
            label28.TabIndex = 632;
            label28.Text = "VENDAS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(478, 25);
            label1.Name = "label1";
            label1.Size = new Size(233, 24);
            label1.TabIndex = 633;
            label1.Text = "PAGAMENTOS PARCIAIS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(120, 254);
            label3.Name = "label3";
            label3.Size = new Size(109, 24);
            label3.TabIndex = 635;
            label3.Text = "PARCELAS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F);
            label4.ForeColor = Color.Green;
            label4.Location = new Point(524, 254);
            label4.Name = "label4";
            label4.Size = new Size(136, 24);
            label4.TabIndex = 636;
            label4.Text = "ITENS VENDA";
            // 
            // btnSair
            // 
            btnSair.Anchor = AnchorStyles.Left;
            btnSair.CornerRoundingRadius = 1F;
            btnSair.Location = new Point(578, 491);
            btnSair.Name = "btnSair";
            btnSair.OverrideDefault.Back.Color1 = Color.White;
            btnSair.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.OverrideDefault.Back.ColorAngle = 45F;
            btnSair.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnSair.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.OverrideDefault.Border.ColorAngle = 45F;
            btnSair.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSair.OverrideDefault.Border.Rounding = 1F;
            btnSair.OverrideDefault.Border.Width = 1;
            btnSair.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnSair.Size = new Size(190, 30);
            btnSair.StateCommon.Back.Color1 = Color.White;
            btnSair.StateCommon.Back.Color2 = Color.White;
            btnSair.StateCommon.Back.ColorAngle = 45F;
            btnSair.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSair.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSair.StateCommon.Border.Rounding = 1F;
            btnSair.StateCommon.Border.Width = 1;
            btnSair.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnSair.StateCommon.Content.ShortText.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.StatePressed.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnSair.StatePressed.Back.Color2 = Color.White;
            btnSair.StatePressed.Back.ColorAngle = 135F;
            btnSair.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnSair.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnSair.StatePressed.Border.ColorAngle = 135F;
            btnSair.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.StatePressed.Border.Rounding = 1F;
            btnSair.StatePressed.Border.Width = 1;
            btnSair.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnSair.StateTracking.Back.Color2 = Color.White;
            btnSair.StateTracking.Back.ColorAngle = 45F;
            btnSair.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSair.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.StateTracking.Border.ColorAngle = 45F;
            btnSair.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSair.StateTracking.Border.Rounding = 1F;
            btnSair.StateTracking.Border.Width = 1;
            btnSair.StateTracking.Content.ShortText.Color1 = Color.White;
            btnSair.TabIndex = 637;
            btnSair.Values.Text = "&Sair";
            btnSair.Click += btnSair_Click;
            // 
            // kryptonPalette1
            // 
            kryptonPalette1.ButtonSpecs.FormClose.Image = Properties.Resources.Exit;
            kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImagePressed = Properties.Resources.Sairr;
            kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImageTracking = Properties.Resources.Sairr;
            kryptonPalette1.ButtonSpecs.FormMax.Image = Properties.Resources.Maximize;
            kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImagePressed = Properties.Resources.Minimiza24;
            kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImageTracking = Properties.Resources.Minimiza24;
            kryptonPalette1.ButtonSpecs.FormMin.Image = Properties.Resources.Minimize;
            kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImagePressed = Properties.Resources.Minimizar24;
            kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImageTracking = Properties.Resources.Minimizar24;
            kryptonPalette1.ButtonSpecs.FormRestore.Image = Properties.Resources.Maximize;
            kryptonPalette1.ButtonSpecs.FormRestore.ImageStates.ImagePressed = Properties.Resources.Minimiza24;
            kryptonPalette1.ButtonSpecs.FormRestore.ImageStates.ImageTracking = Properties.Resources.Maximize;
            kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 12F;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new Padding(10, -1, -1, -1);
            // 
            // FrmExclusaoOrfaos
            // 
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(780, 533);
            Controls.Add(btnSair);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label28);
            Controls.Add(btnExcluirItensVenda);
            Controls.Add(btnExcluirParcelas);
            Controls.Add(btnExcluirVenda);
            Controls.Add(btnExcluirPagamentoParcial);
            Controls.Add(dgvParcelas);
            Controls.Add(dgvItensVenda);
            Controls.Add(dgvPagamentosParciais);
            Controls.Add(dgvVendas);
            Name = "FrmExclusaoOrfaos";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Text = "MANUTENÇÃO DE REGISTROS ORFÃOS";
            Load += FrmExclusaoOrfao_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVendas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPagamentosParciais).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvItensVenda).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvParcelas).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonDataGridView dgvVendas;
        private Krypton.Toolkit.KryptonDataGridView dgvPagamentosParciais;
        private Krypton.Toolkit.KryptonDataGridView dgvItensVenda;
        private Krypton.Toolkit.KryptonDataGridView dgvParcelas;
        private Krypton.Toolkit.KryptonButton btnExcluirPagamentoParcial;
        private Krypton.Toolkit.KryptonButton btnExcluirVenda;
        private Krypton.Toolkit.KryptonButton btnExcluirParcelas;
        private Krypton.Toolkit.KryptonButton btnExcluirItensVenda;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Krypton.Toolkit.KryptonButton btnSair;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
    }
}
