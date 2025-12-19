namespace GVC.View
{
    partial class FrmVendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            txtNomeCliente = new Krypton.Toolkit.KryptonTextBox();
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            dgvitens = new Krypton.Toolkit.KryptonDataGridView();
            lblDesconto = new Label();
            txtDesconto = new Krypton.Toolkit.KryptonTextBox();
            lblTotalGeral = new Label();
            txtTotalGeral = new Krypton.Toolkit.KryptonTextBox();
            cmbFormaPagamento = new Krypton.Toolkit.KryptonComboBox();
            btnAdicionarItem = new Krypton.Toolkit.KryptonButton();
            btnSalvarVenda = new Krypton.Toolkit.KryptonButton();
            btnCancelar = new Krypton.Toolkit.KryptonButton();
            btnImprimir = new Krypton.Toolkit.KryptonButton();
            btnGerarParcelas = new Krypton.Toolkit.KryptonButton();
            label10 = new Label();
            txtNomeProduto = new Krypton.Toolkit.KryptonTextBox();
            txtPrecoUnitario = new Krypton.Toolkit.KryptonTextBox();
            label13 = new Label();
            label12 = new Label();
            txtValorRecebido = new Krypton.Toolkit.KryptonTextBox();
            lblValorRecebido = new Label();
            kryptonStatusStrip1 = new Krypton.Toolkit.KryptonStatusStrip();
            lblStatusParcelas = new ToolStripStatusLabel();
            label1 = new Label();
            lblVendaID = new Label();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            label3 = new Label();
            lblData = new Label();
            txtCpf = new Krypton.Toolkit.KryptonTextBox();
            lblCpf = new Label();
            label2 = new Label();
            txtQuantidade = new Krypton.Toolkit.KryptonTextBox();
            txtSubTotal = new Krypton.Toolkit.KryptonTextBox();
            lblSubTotal = new Label();
            txtTroco = new Krypton.Toolkit.KryptonTextBox();
            lblTroco = new Label();
            tabControlPagamento = new TabControl();
            tabPagamento = new TabPage();
            lblFormaPgto = new Label();
            tabParcelas = new TabPage();
            txtValorTotalParcelado = new Krypton.Toolkit.KryptonTextBox();
            label6 = new Label();
            numIntervalo = new Krypton.Toolkit.KryptonNumericUpDown();
            lblIntervalo = new Label();
            dgvParcelas = new Krypton.Toolkit.KryptonDataGridView();
            btnGerar = new Krypton.Toolkit.KryptonButton();
            btnCancelarParcelas = new Krypton.Toolkit.KryptonButton();
            numParcelas = new Krypton.Toolkit.KryptonNumericUpDown();
            lblQtdParcelas = new Label();
            lblPrimeiroVenc = new Label();
            dtPrimeira = new Krypton.Toolkit.KryptonDateTimePicker();
            txtValorParcela = new Krypton.Toolkit.KryptonTextBox();
            lblValorParcela = new Label();
            panel1 = new Panel();
            txtObservacao = new Krypton.Toolkit.KryptonTextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvitens).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbFormaPagamento).BeginInit();
            kryptonStatusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            tabControlPagamento.SuspendLayout();
            tabPagamento.SuspendLayout();
            tabParcelas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvParcelas).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNomeCliente.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtNomeCliente.Location = new Point(7, 56);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtNomeCliente.Size = new Size(391, 24);
            txtNomeCliente.StateCommon.Back.Color1 = Color.White;
            txtNomeCliente.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtNomeCliente.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtNomeCliente.StateCommon.Border.ColorAngle = 1F;
            txtNomeCliente.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtNomeCliente.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtNomeCliente.StateCommon.Border.Rounding = 6F;
            txtNomeCliente.StateCommon.Border.Width = 1;
            txtNomeCliente.StateCommon.Content.Color1 = Color.Gray;
            txtNomeCliente.StateCommon.Content.Font = new Font("Segoe UI", 9.75F);
            txtNomeCliente.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtNomeCliente.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtNomeCliente.StateNormal.Back.Color1 = Color.FromArgb(192, 255, 255);
            txtNomeCliente.StateNormal.Content.Color1 = Color.FromArgb(192, 255, 255);
            txtNomeCliente.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtNomeCliente.TabIndex = 100;
            txtNomeCliente.TabStop = false;
            txtNomeCliente.TextChanged += txtNomeCliente_TextChanged;
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
            // dgvitens
            // 
            dgvitens.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvitens.Location = new Point(7, 185);
            dgvitens.Name = "dgvitens";
            dgvitens.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            dgvitens.RowHeadersWidth = 23;
            dgvitens.Size = new Size(560, 207);
            dgvitens.TabIndex = 635;
            dgvitens.TabStop = false;
            dgvitens.CellContentClick += dgvItensVenda_CellContentClick;
            dgvitens.CellEndEdit += dgvitens_CellEndEdit;
            // 
            // lblDesconto
            // 
            lblDesconto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDesconto.AutoSize = true;
            lblDesconto.BackColor = Color.Transparent;
            lblDesconto.Font = new Font("Segoe UI", 9.75F);
            lblDesconto.ForeColor = Color.FromArgb(0, 76, 172);
            lblDesconto.Location = new Point(10, 44);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(66, 17);
            lblDesconto.TabIndex = 638;
            lblDesconto.Text = "Desconto:";
            // 
            // txtDesconto
            // 
            txtDesconto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtDesconto.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtDesconto.Location = new Point(102, 38);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtDesconto.Size = new Size(188, 25);
            txtDesconto.StateCommon.Back.Color1 = Color.White;
            txtDesconto.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtDesconto.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtDesconto.StateCommon.Border.ColorAngle = 1F;
            txtDesconto.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtDesconto.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtDesconto.StateCommon.Border.Rounding = 6F;
            txtDesconto.StateCommon.Border.Width = 1;
            txtDesconto.StateCommon.Content.Color1 = Color.Gray;
            txtDesconto.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 12F);
            txtDesconto.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtDesconto.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtDesconto.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtDesconto.TabIndex = 30;
            txtDesconto.TabStop = false;
            txtDesconto.Leave += txtDesconto_Leave;
            // 
            // lblTotalGeral
            // 
            lblTotalGeral.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalGeral.AutoSize = true;
            lblTotalGeral.BackColor = Color.Transparent;
            lblTotalGeral.Font = new Font("Segoe UI", 12.75F);
            lblTotalGeral.ForeColor = Color.FromArgb(0, 76, 172);
            lblTotalGeral.Location = new Point(10, 78);
            lblTotalGeral.Name = "lblTotalGeral";
            lblTotalGeral.Size = new Size(95, 23);
            lblTotalGeral.TabIndex = 640;
            lblTotalGeral.Text = "Total Geral:";
            // 
            // txtTotalGeral
            // 
            txtTotalGeral.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTotalGeral.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtTotalGeral.Location = new Point(102, 74);
            txtTotalGeral.Name = "txtTotalGeral";
            txtTotalGeral.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtTotalGeral.ReadOnly = true;
            txtTotalGeral.Size = new Size(188, 34);
            txtTotalGeral.StateCommon.Back.Color1 = Color.White;
            txtTotalGeral.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtTotalGeral.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtTotalGeral.StateCommon.Border.ColorAngle = 1F;
            txtTotalGeral.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtTotalGeral.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtTotalGeral.StateCommon.Border.Rounding = 6F;
            txtTotalGeral.StateCommon.Border.Width = 1;
            txtTotalGeral.StateCommon.Content.Color1 = Color.Gray;
            txtTotalGeral.StateCommon.Content.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalGeral.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtTotalGeral.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtTotalGeral.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtTotalGeral.TabIndex = 641;
            txtTotalGeral.TabStop = false;
            // 
            // cmbFormaPagamento
            // 
            cmbFormaPagamento.CornerRoundingRadius = 6F;
            cmbFormaPagamento.DropDownWidth = 171;
            cmbFormaPagamento.IntegralHeight = false;
            cmbFormaPagamento.Items.AddRange(new object[] { "Á Vista", "Crediário Parcelado", "Cartão de Crédito", "Cartão de Débito", "Pix", "Transferência" });
            cmbFormaPagamento.Location = new Point(102, 179);
            cmbFormaPagamento.Name = "cmbFormaPagamento";
            cmbFormaPagamento.Size = new Size(190, 27);
            cmbFormaPagamento.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbFormaPagamento.StateCommon.ComboBox.Border.Rounding = 6F;
            cmbFormaPagamento.StateCommon.ComboBox.Border.Width = 1;
            cmbFormaPagamento.StateCommon.ComboBox.Content.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbFormaPagamento.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbFormaPagamento.TabIndex = 1014;
            cmbFormaPagamento.TabStop = false;
            cmbFormaPagamento.SelectedIndexChanged += cmbFormaPgto_SelectedIndexChanged;
            // 
            // btnAdicionarItem
            // 
            btnAdicionarItem.CornerRoundingRadius = 6F;
            btnAdicionarItem.Location = new Point(397, 152);
            btnAdicionarItem.Name = "btnAdicionarItem";
            btnAdicionarItem.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnAdicionarItem.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnAdicionarItem.OverrideDefault.Back.ColorAngle = 45F;
            btnAdicionarItem.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnAdicionarItem.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnAdicionarItem.OverrideDefault.Border.ColorAngle = 45F;
            btnAdicionarItem.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAdicionarItem.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAdicionarItem.OverrideDefault.Border.Rounding = 20F;
            btnAdicionarItem.OverrideDefault.Border.Width = 1;
            btnAdicionarItem.Size = new Size(170, 27);
            btnAdicionarItem.StateCommon.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnAdicionarItem.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnAdicionarItem.StateCommon.Back.ColorAngle = 45F;
            btnAdicionarItem.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAdicionarItem.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAdicionarItem.StateCommon.Border.Rounding = 6F;
            btnAdicionarItem.StateCommon.Border.Width = 1;
            btnAdicionarItem.StateCommon.Content.ShortText.Color1 = Color.White;
            btnAdicionarItem.StateCommon.Content.ShortText.Color2 = Color.White;
            btnAdicionarItem.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
            btnAdicionarItem.StatePressed.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnAdicionarItem.StatePressed.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnAdicionarItem.StatePressed.Back.ColorAngle = 135F;
            btnAdicionarItem.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnAdicionarItem.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnAdicionarItem.StatePressed.Border.ColorAngle = 135F;
            btnAdicionarItem.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAdicionarItem.StatePressed.Border.Rounding = 20F;
            btnAdicionarItem.StatePressed.Border.Width = 1;
            btnAdicionarItem.StatePressed.Content.ShortText.Color1 = Color.Black;
            btnAdicionarItem.StatePressed.Content.ShortText.Color2 = Color.Black;
            btnAdicionarItem.StateTracking.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnAdicionarItem.StateTracking.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnAdicionarItem.StateTracking.Back.ColorAngle = 45F;
            btnAdicionarItem.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnAdicionarItem.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnAdicionarItem.StateTracking.Border.ColorAngle = 45F;
            btnAdicionarItem.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAdicionarItem.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAdicionarItem.StateTracking.Border.Rounding = 20F;
            btnAdicionarItem.StateTracking.Border.Width = 1;
            btnAdicionarItem.StateTracking.Content.ShortText.Color1 = Color.Black;
            btnAdicionarItem.StateTracking.Content.ShortText.Color2 = Color.Black;
            btnAdicionarItem.TabIndex = 4;
            btnAdicionarItem.Values.Text = "Adicionar item";
            btnAdicionarItem.Click += btnAdicionarItem_Click;
            // 
            // btnSalvarVenda
            // 
            btnSalvarVenda.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvarVenda.CornerRoundingRadius = 6F;
            btnSalvarVenda.Location = new Point(10, 432);
            btnSalvarVenda.Name = "btnSalvarVenda";
            btnSalvarVenda.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnSalvarVenda.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnSalvarVenda.OverrideDefault.Back.ColorAngle = 45F;
            btnSalvarVenda.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSalvarVenda.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSalvarVenda.OverrideDefault.Border.ColorAngle = 45F;
            btnSalvarVenda.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSalvarVenda.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSalvarVenda.OverrideDefault.Border.Rounding = 20F;
            btnSalvarVenda.OverrideDefault.Border.Width = 1;
            btnSalvarVenda.Size = new Size(284, 30);
            btnSalvarVenda.StateCommon.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnSalvarVenda.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnSalvarVenda.StateCommon.Back.ColorAngle = 45F;
            btnSalvarVenda.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSalvarVenda.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSalvarVenda.StateCommon.Border.Rounding = 6F;
            btnSalvarVenda.StateCommon.Border.Width = 1;
            btnSalvarVenda.StateCommon.Content.ShortText.Color1 = Color.White;
            btnSalvarVenda.StateCommon.Content.ShortText.Color2 = Color.White;
            btnSalvarVenda.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
            btnSalvarVenda.StatePressed.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnSalvarVenda.StatePressed.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnSalvarVenda.StatePressed.Back.ColorAngle = 135F;
            btnSalvarVenda.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnSalvarVenda.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnSalvarVenda.StatePressed.Border.ColorAngle = 135F;
            btnSalvarVenda.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSalvarVenda.StatePressed.Border.Rounding = 20F;
            btnSalvarVenda.StatePressed.Border.Width = 1;
            btnSalvarVenda.StatePressed.Content.ShortText.Color1 = Color.Black;
            btnSalvarVenda.StatePressed.Content.ShortText.Color2 = Color.Black;
            btnSalvarVenda.StateTracking.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnSalvarVenda.StateTracking.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnSalvarVenda.StateTracking.Back.ColorAngle = 45F;
            btnSalvarVenda.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSalvarVenda.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSalvarVenda.StateTracking.Border.ColorAngle = 45F;
            btnSalvarVenda.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSalvarVenda.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSalvarVenda.StateTracking.Border.Rounding = 20F;
            btnSalvarVenda.StateTracking.Border.Width = 1;
            btnSalvarVenda.StateTracking.Content.ShortText.Color1 = Color.Black;
            btnSalvarVenda.StateTracking.Content.ShortText.Color2 = Color.Black;
            btnSalvarVenda.TabIndex = 1016;
            btnSalvarVenda.TabStop = false;
            btnSalvarVenda.Values.Text = "Salvar Venda";
            btnSalvarVenda.Click += btnSalvarVenda_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.CornerRoundingRadius = 6F;
            btnCancelar.Location = new Point(10, 496);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnCancelar.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnCancelar.OverrideDefault.Back.ColorAngle = 45F;
            btnCancelar.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnCancelar.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnCancelar.OverrideDefault.Border.ColorAngle = 45F;
            btnCancelar.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelar.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancelar.OverrideDefault.Border.Rounding = 20F;
            btnCancelar.OverrideDefault.Border.Width = 1;
            btnCancelar.Size = new Size(284, 30);
            btnCancelar.StateCommon.Back.Color1 = Color.Red;
            btnCancelar.StateCommon.Back.Color2 = Color.Red;
            btnCancelar.StateCommon.Back.ColorAngle = 45F;
            btnCancelar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancelar.StateCommon.Border.Rounding = 6F;
            btnCancelar.StateCommon.Border.Width = 1;
            btnCancelar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnCancelar.StateCommon.Content.ShortText.Color2 = Color.White;
            btnCancelar.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
            btnCancelar.StatePressed.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnCancelar.StatePressed.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnCancelar.StatePressed.Back.ColorAngle = 135F;
            btnCancelar.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnCancelar.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnCancelar.StatePressed.Border.ColorAngle = 135F;
            btnCancelar.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelar.StatePressed.Border.Rounding = 20F;
            btnCancelar.StatePressed.Border.Width = 1;
            btnCancelar.StatePressed.Content.ShortText.Color1 = Color.Black;
            btnCancelar.StatePressed.Content.ShortText.Color2 = Color.Black;
            btnCancelar.StateTracking.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnCancelar.StateTracking.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnCancelar.StateTracking.Back.ColorAngle = 45F;
            btnCancelar.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnCancelar.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnCancelar.StateTracking.Border.ColorAngle = 45F;
            btnCancelar.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelar.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancelar.StateTracking.Border.Rounding = 20F;
            btnCancelar.StateTracking.Border.Width = 1;
            btnCancelar.StateTracking.Content.ShortText.Color1 = Color.Black;
            btnCancelar.StateTracking.Content.ShortText.Color2 = Color.Black;
            btnCancelar.TabIndex = 1019;
            btnCancelar.TabStop = false;
            btnCancelar.Values.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnImprimir.CornerRoundingRadius = 6F;
            btnImprimir.Location = new Point(10, 464);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnImprimir.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnImprimir.OverrideDefault.Back.ColorAngle = 45F;
            btnImprimir.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnImprimir.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnImprimir.OverrideDefault.Border.ColorAngle = 45F;
            btnImprimir.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnImprimir.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnImprimir.OverrideDefault.Border.Rounding = 20F;
            btnImprimir.OverrideDefault.Border.Width = 1;
            btnImprimir.Size = new Size(284, 30);
            btnImprimir.StateCommon.Back.Color1 = Color.FromArgb(252, 252, 250);
            btnImprimir.StateCommon.Back.Color2 = Color.FromArgb(252, 252, 250);
            btnImprimir.StateCommon.Back.ColorAngle = 45F;
            btnImprimir.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnImprimir.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnImprimir.StateCommon.Border.Rounding = 6F;
            btnImprimir.StateCommon.Border.Width = 1;
            btnImprimir.StateCommon.Content.ShortText.Color1 = Color.Black;
            btnImprimir.StateCommon.Content.ShortText.Color2 = Color.Black;
            btnImprimir.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
            btnImprimir.StatePressed.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnImprimir.StatePressed.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnImprimir.StatePressed.Back.ColorAngle = 135F;
            btnImprimir.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnImprimir.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnImprimir.StatePressed.Border.ColorAngle = 135F;
            btnImprimir.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnImprimir.StatePressed.Border.Rounding = 20F;
            btnImprimir.StatePressed.Border.Width = 1;
            btnImprimir.StatePressed.Content.ShortText.Color1 = Color.Black;
            btnImprimir.StatePressed.Content.ShortText.Color2 = Color.Black;
            btnImprimir.StateTracking.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnImprimir.StateTracking.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnImprimir.StateTracking.Back.ColorAngle = 45F;
            btnImprimir.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnImprimir.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnImprimir.StateTracking.Border.ColorAngle = 45F;
            btnImprimir.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnImprimir.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnImprimir.StateTracking.Border.Rounding = 20F;
            btnImprimir.StateTracking.Border.Width = 1;
            btnImprimir.StateTracking.Content.ShortText.Color1 = Color.Black;
            btnImprimir.StateTracking.Content.ShortText.Color2 = Color.Black;
            btnImprimir.TabIndex = 1020;
            btnImprimir.TabStop = false;
            btnImprimir.Values.Text = "Imprimir Cupom";
            // 
            // btnGerarParcelas
            // 
            btnGerarParcelas.CornerRoundingRadius = 6F;
            btnGerarParcelas.Location = new Point(6, 215);
            btnGerarParcelas.Name = "btnGerarParcelas";
            btnGerarParcelas.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnGerarParcelas.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnGerarParcelas.OverrideDefault.Back.ColorAngle = 45F;
            btnGerarParcelas.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnGerarParcelas.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnGerarParcelas.OverrideDefault.Border.ColorAngle = 45F;
            btnGerarParcelas.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnGerarParcelas.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnGerarParcelas.OverrideDefault.Border.Rounding = 20F;
            btnGerarParcelas.OverrideDefault.Border.Width = 1;
            btnGerarParcelas.Size = new Size(284, 30);
            btnGerarParcelas.StateCommon.Back.Color1 = Color.FromArgb(252, 252, 250);
            btnGerarParcelas.StateCommon.Back.Color2 = Color.FromArgb(252, 252, 250);
            btnGerarParcelas.StateCommon.Back.ColorAngle = 45F;
            btnGerarParcelas.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnGerarParcelas.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnGerarParcelas.StateCommon.Border.Rounding = 6F;
            btnGerarParcelas.StateCommon.Border.Width = 1;
            btnGerarParcelas.StateCommon.Content.ShortText.Color1 = Color.Black;
            btnGerarParcelas.StateCommon.Content.ShortText.Color2 = Color.White;
            btnGerarParcelas.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
            btnGerarParcelas.StatePressed.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnGerarParcelas.StatePressed.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnGerarParcelas.StatePressed.Back.ColorAngle = 135F;
            btnGerarParcelas.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnGerarParcelas.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnGerarParcelas.StatePressed.Border.ColorAngle = 135F;
            btnGerarParcelas.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnGerarParcelas.StatePressed.Border.Rounding = 20F;
            btnGerarParcelas.StatePressed.Border.Width = 1;
            btnGerarParcelas.StatePressed.Content.ShortText.Color1 = Color.Black;
            btnGerarParcelas.StatePressed.Content.ShortText.Color2 = Color.Black;
            btnGerarParcelas.StateTracking.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnGerarParcelas.StateTracking.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnGerarParcelas.StateTracking.Back.ColorAngle = 45F;
            btnGerarParcelas.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnGerarParcelas.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnGerarParcelas.StateTracking.Border.ColorAngle = 45F;
            btnGerarParcelas.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnGerarParcelas.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnGerarParcelas.StateTracking.Border.Rounding = 20F;
            btnGerarParcelas.StateTracking.Border.Width = 1;
            btnGerarParcelas.StateTracking.Content.ShortText.Color1 = Color.Black;
            btnGerarParcelas.StateTracking.Content.ShortText.Color2 = Color.Black;
            btnGerarParcelas.TabIndex = 1021;
            btnGerarParcelas.TabStop = false;
            btnGerarParcelas.Values.Text = "Gerar Parcelas";
            btnGerarParcelas.Click += btnGerarParcelas_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 9.75F);
            label10.ForeColor = Color.FromArgb(0, 76, 172);
            label10.Location = new Point(7, 36);
            label10.Name = "label10";
            label10.Size = new Size(87, 17);
            label10.TabIndex = 1025;
            label10.Text = "Nome Cliente";
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNomeProduto.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtNomeProduto.Location = new Point(7, 104);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtNomeProduto.Size = new Size(560, 24);
            txtNomeProduto.StateCommon.Back.Color1 = Color.White;
            txtNomeProduto.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtNomeProduto.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtNomeProduto.StateCommon.Border.ColorAngle = 1F;
            txtNomeProduto.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtNomeProduto.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtNomeProduto.StateCommon.Border.Rounding = 6F;
            txtNomeProduto.StateCommon.Border.Width = 1;
            txtNomeProduto.StateCommon.Content.Color1 = Color.Gray;
            txtNomeProduto.StateCommon.Content.Font = new Font("Segoe UI", 9.75F);
            txtNomeProduto.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtNomeProduto.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtNomeProduto.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtNomeProduto.TabIndex = 1;
            txtNomeProduto.TextChanged += txtNomeProduto_TextChanged;
            // 
            // txtPrecoUnitario
            // 
            txtPrecoUnitario.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtPrecoUnitario.Location = new Point(191, 153);
            txtPrecoUnitario.Name = "txtPrecoUnitario";
            txtPrecoUnitario.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtPrecoUnitario.Size = new Size(180, 24);
            txtPrecoUnitario.StateCommon.Back.Color1 = Color.White;
            txtPrecoUnitario.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtPrecoUnitario.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtPrecoUnitario.StateCommon.Border.ColorAngle = 1F;
            txtPrecoUnitario.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtPrecoUnitario.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtPrecoUnitario.StateCommon.Border.Rounding = 6F;
            txtPrecoUnitario.StateCommon.Border.Width = 1;
            txtPrecoUnitario.StateCommon.Content.Color1 = Color.Gray;
            txtPrecoUnitario.StateCommon.Content.Font = new Font("Segoe UI", 9.75F);
            txtPrecoUnitario.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtPrecoUnitario.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtPrecoUnitario.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtPrecoUnitario.TabIndex = 3;
            txtPrecoUnitario.TextChanged += txtPrecoUnitario_TextChanged;
            txtPrecoUnitario.KeyPress += txtPrecoUnitario_KeyPress;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 9.75F);
            label13.ForeColor = Color.FromArgb(0, 76, 172);
            label13.Location = new Point(199, 132);
            label13.Name = "label13";
            label13.Size = new Size(91, 17);
            label13.TabIndex = 646;
            label13.Text = "Preço Unitario";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 9.75F);
            label12.ForeColor = Color.FromArgb(0, 76, 172);
            label12.Location = new Point(7, 131);
            label12.Name = "label12";
            label12.Size = new Size(76, 17);
            label12.TabIndex = 644;
            label12.Text = "Quantidade";
            // 
            // txtValorRecebido
            // 
            txtValorRecebido.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtValorRecebido.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtValorRecebido.Location = new Point(102, 122);
            txtValorRecebido.Name = "txtValorRecebido";
            txtValorRecebido.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtValorRecebido.Size = new Size(188, 25);
            txtValorRecebido.StateCommon.Back.Color1 = Color.White;
            txtValorRecebido.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtValorRecebido.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtValorRecebido.StateCommon.Border.ColorAngle = 1F;
            txtValorRecebido.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtValorRecebido.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtValorRecebido.StateCommon.Border.Rounding = 6F;
            txtValorRecebido.StateCommon.Border.Width = 1;
            txtValorRecebido.StateCommon.Content.Color1 = Color.Gray;
            txtValorRecebido.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 12F);
            txtValorRecebido.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtValorRecebido.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtValorRecebido.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtValorRecebido.TabIndex = 40;
            txtValorRecebido.TabStop = false;
            txtValorRecebido.Leave += txtValorRecebido_Leave;
            // 
            // lblValorRecebido
            // 
            lblValorRecebido.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblValorRecebido.AutoSize = true;
            lblValorRecebido.BackColor = Color.Transparent;
            lblValorRecebido.Font = new Font("Segoe UI", 9.75F);
            lblValorRecebido.ForeColor = Color.FromArgb(0, 76, 172);
            lblValorRecebido.Location = new Point(10, 125);
            lblValorRecebido.Name = "lblValorRecebido";
            lblValorRecebido.Size = new Size(89, 17);
            lblValorRecebido.TabIndex = 642;
            lblValorRecebido.Text = "Vlr. Recebido:";
            // 
            // kryptonStatusStrip1
            // 
            kryptonStatusStrip1.Font = new Font("Segoe UI", 9F);
            kryptonStatusStrip1.Items.AddRange(new ToolStripItem[] { lblStatusParcelas });
            kryptonStatusStrip1.Location = new Point(0, 561);
            kryptonStatusStrip1.Name = "kryptonStatusStrip1";
            kryptonStatusStrip1.ProgressBars = null;
            kryptonStatusStrip1.RenderMode = ToolStripRenderMode.ManagerRenderMode;
            kryptonStatusStrip1.Size = new Size(880, 22);
            kryptonStatusStrip1.TabIndex = 1030;
            kryptonStatusStrip1.Text = "kryptonStatusStrip1";
            // 
            // lblStatusParcelas
            // 
            lblStatusParcelas.Name = "lblStatusParcelas";
            lblStatusParcelas.Size = new Size(95, 17);
            lblStatusParcelas.Text = "lblStatusParcelas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(8, 100, 255);
            label1.Location = new Point(5, 7);
            label1.Name = "label1";
            label1.Size = new Size(92, 17);
            label1.TabIndex = 1033;
            label1.Text = "CÓD. VENDA:";
            // 
            // lblVendaID
            // 
            lblVendaID.AutoSize = true;
            lblVendaID.BackColor = Color.Transparent;
            lblVendaID.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblVendaID.ForeColor = Color.Red;
            lblVendaID.Location = new Point(98, 7);
            lblVendaID.Name = "lblVendaID";
            lblVendaID.Size = new Size(64, 17);
            lblVendaID.TabIndex = 1034;
            lblVendaID.Text = "Venda ID";
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(label3);
            kryptonPanel1.Controls.Add(lblData);
            kryptonPanel1.Controls.Add(label1);
            kryptonPanel1.Controls.Add(lblVendaID);
            kryptonPanel1.Dock = DockStyle.Top;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            kryptonPanel1.Size = new Size(880, 32);
            kryptonPanel1.TabIndex = 1035;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(8, 100, 255);
            label3.Location = new Point(672, 7);
            label3.Name = "label3";
            label3.Size = new Size(95, 17);
            label3.TabIndex = 1035;
            label3.Text = "DATA VENDA:";
            // 
            // lblData
            // 
            lblData.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblData.AutoSize = true;
            lblData.BackColor = Color.Transparent;
            lblData.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblData.ForeColor = Color.Red;
            lblData.Location = new Point(768, 7);
            lblData.Name = "lblData";
            lblData.Size = new Size(64, 17);
            lblData.TabIndex = 1036;
            lblData.Text = "Venda ID";
            // 
            // txtCpf
            // 
            txtCpf.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCpf.CharacterCasing = CharacterCasing.Upper;
            txtCpf.Location = new Point(401, 55);
            txtCpf.Name = "txtCpf";
            txtCpf.ReadOnly = true;
            txtCpf.Size = new Size(166, 24);
            txtCpf.StateCommon.Back.Color1 = Color.White;
            txtCpf.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtCpf.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtCpf.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtCpf.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtCpf.StateCommon.Border.Rounding = 6F;
            txtCpf.StateCommon.Border.Width = 1;
            txtCpf.StateCommon.Content.Color1 = Color.Gray;
            txtCpf.StateCommon.Content.Font = new Font("Segoe UI", 9.75F);
            txtCpf.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtCpf.TabIndex = 1037;
            txtCpf.TabStop = false;
            // 
            // lblCpf
            // 
            lblCpf.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCpf.AutoSize = true;
            lblCpf.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblCpf.ForeColor = Color.FromArgb(0, 76, 172);
            lblCpf.Location = new Point(401, 35);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(33, 16);
            lblCpf.TabIndex = 1038;
            lblCpf.Text = "CPF";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.ForeColor = Color.FromArgb(0, 76, 172);
            label2.Location = new Point(7, 84);
            label2.Name = "label2";
            label2.Size = new Size(55, 17);
            label2.TabIndex = 1026;
            label2.Text = "Produto";
            // 
            // txtQuantidade
            // 
            txtQuantidade.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtQuantidade.Location = new Point(7, 153);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtQuantidade.Size = new Size(180, 24);
            txtQuantidade.StateCommon.Back.Color1 = Color.White;
            txtQuantidade.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtQuantidade.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtQuantidade.StateCommon.Border.ColorAngle = 1F;
            txtQuantidade.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtQuantidade.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtQuantidade.StateCommon.Border.Rounding = 6F;
            txtQuantidade.StateCommon.Border.Width = 1;
            txtQuantidade.StateCommon.Content.Color1 = Color.Gray;
            txtQuantidade.StateCommon.Content.Font = new Font("Segoe UI", 9.75F);
            txtQuantidade.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtQuantidade.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtQuantidade.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtQuantidade.TabIndex = 2;
            txtQuantidade.TextAlign = HorizontalAlignment.Center;
            txtQuantidade.KeyPress += txtQuantidade_KeyPress;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSubTotal.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtSubTotal.Location = new Point(102, 9);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(188, 25);
            txtSubTotal.StateCommon.Back.Color1 = Color.White;
            txtSubTotal.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtSubTotal.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtSubTotal.StateCommon.Border.ColorAngle = 1F;
            txtSubTotal.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtSubTotal.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtSubTotal.StateCommon.Border.Rounding = 6F;
            txtSubTotal.StateCommon.Border.Width = 1;
            txtSubTotal.StateCommon.Content.Color1 = Color.Gray;
            txtSubTotal.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 12F);
            txtSubTotal.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtSubTotal.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtSubTotal.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtSubTotal.TabIndex = 1031;
            txtSubTotal.TabStop = false;
            // 
            // lblSubTotal
            // 
            lblSubTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSubTotal.AutoSize = true;
            lblSubTotal.BackColor = Color.Transparent;
            lblSubTotal.Font = new Font("Segoe UI", 9.75F);
            lblSubTotal.ForeColor = Color.FromArgb(0, 76, 172);
            lblSubTotal.Location = new Point(10, 15);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(61, 17);
            lblSubTotal.TabIndex = 1030;
            lblSubTotal.Text = "SubTotal:";
            // 
            // txtTroco
            // 
            txtTroco.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTroco.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtTroco.Location = new Point(102, 151);
            txtTroco.Name = "txtTroco";
            txtTroco.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtTroco.Size = new Size(188, 25);
            txtTroco.StateCommon.Back.Color1 = Color.White;
            txtTroco.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtTroco.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtTroco.StateCommon.Border.ColorAngle = 1F;
            txtTroco.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtTroco.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtTroco.StateCommon.Border.Rounding = 6F;
            txtTroco.StateCommon.Border.Width = 1;
            txtTroco.StateCommon.Content.Color1 = Color.Gray;
            txtTroco.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 12F);
            txtTroco.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtTroco.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtTroco.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtTroco.TabIndex = 1032;
            txtTroco.TabStop = false;
            // 
            // lblTroco
            // 
            lblTroco.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTroco.AutoSize = true;
            lblTroco.BackColor = Color.Transparent;
            lblTroco.Font = new Font("Segoe UI", 9.75F);
            lblTroco.ForeColor = Color.FromArgb(0, 76, 172);
            lblTroco.Location = new Point(10, 158);
            lblTroco.Name = "lblTroco";
            lblTroco.Size = new Size(44, 17);
            lblTroco.TabIndex = 1033;
            lblTroco.Text = "Troco:";
            // 
            // tabControlPagamento
            // 
            tabControlPagamento.Controls.Add(tabPagamento);
            tabControlPagamento.Controls.Add(tabParcelas);
            tabControlPagamento.Location = new Point(0, 0);
            tabControlPagamento.Name = "tabControlPagamento";
            tabControlPagamento.SelectedIndex = 0;
            tabControlPagamento.Size = new Size(300, 426);
            tabControlPagamento.TabIndex = 1040;
            tabControlPagamento.TabStop = false;
            // 
            // tabPagamento
            // 
            tabPagamento.Controls.Add(lblFormaPgto);
            tabPagamento.Controls.Add(txtTroco);
            tabPagamento.Controls.Add(btnGerarParcelas);
            tabPagamento.Controls.Add(cmbFormaPagamento);
            tabPagamento.Controls.Add(lblDesconto);
            tabPagamento.Controls.Add(lblTroco);
            tabPagamento.Controls.Add(lblValorRecebido);
            tabPagamento.Controls.Add(txtTotalGeral);
            tabPagamento.Controls.Add(txtDesconto);
            tabPagamento.Controls.Add(txtValorRecebido);
            tabPagamento.Controls.Add(lblSubTotal);
            tabPagamento.Controls.Add(txtSubTotal);
            tabPagamento.Controls.Add(lblTotalGeral);
            tabPagamento.Location = new Point(4, 24);
            tabPagamento.Name = "tabPagamento";
            tabPagamento.Padding = new Padding(3);
            tabPagamento.Size = new Size(292, 398);
            tabPagamento.TabIndex = 0;
            tabPagamento.Text = "Pagamento";
            tabPagamento.UseVisualStyleBackColor = true;
            // 
            // lblFormaPgto
            // 
            lblFormaPgto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFormaPgto.AutoSize = true;
            lblFormaPgto.BackColor = Color.Transparent;
            lblFormaPgto.Font = new Font("Segoe UI", 9.75F);
            lblFormaPgto.ForeColor = Color.FromArgb(0, 76, 172);
            lblFormaPgto.Location = new Point(10, 185);
            lblFormaPgto.Name = "lblFormaPgto";
            lblFormaPgto.Size = new Size(76, 17);
            lblFormaPgto.TabIndex = 1034;
            lblFormaPgto.Text = "Forma Pgto";
            // 
            // tabParcelas
            // 
            tabParcelas.BackColor = Color.FromArgb(252, 252, 250);
            tabParcelas.Controls.Add(txtValorTotalParcelado);
            tabParcelas.Controls.Add(label6);
            tabParcelas.Controls.Add(numIntervalo);
            tabParcelas.Controls.Add(lblIntervalo);
            tabParcelas.Controls.Add(dgvParcelas);
            tabParcelas.Controls.Add(btnGerar);
            tabParcelas.Controls.Add(btnCancelarParcelas);
            tabParcelas.Controls.Add(numParcelas);
            tabParcelas.Controls.Add(lblQtdParcelas);
            tabParcelas.Controls.Add(lblPrimeiroVenc);
            tabParcelas.Controls.Add(dtPrimeira);
            tabParcelas.Controls.Add(txtValorParcela);
            tabParcelas.Controls.Add(lblValorParcela);
            tabParcelas.Location = new Point(4, 24);
            tabParcelas.Name = "tabParcelas";
            tabParcelas.Padding = new Padding(3);
            tabParcelas.Size = new Size(292, 398);
            tabParcelas.TabIndex = 1;
            tabParcelas.Text = "Parcelas";
            // 
            // txtValorTotalParcelado
            // 
            txtValorTotalParcelado.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtValorTotalParcelado.Location = new Point(119, 20);
            txtValorTotalParcelado.Name = "txtValorTotalParcelado";
            txtValorTotalParcelado.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtValorTotalParcelado.ReadOnly = true;
            txtValorTotalParcelado.Size = new Size(170, 24);
            txtValorTotalParcelado.StateCommon.Back.Color1 = Color.White;
            txtValorTotalParcelado.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtValorTotalParcelado.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtValorTotalParcelado.StateCommon.Border.ColorAngle = 1F;
            txtValorTotalParcelado.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtValorTotalParcelado.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtValorTotalParcelado.StateCommon.Border.Rounding = 8F;
            txtValorTotalParcelado.StateCommon.Border.Width = 1;
            txtValorTotalParcelado.StateCommon.Content.Color1 = Color.Gray;
            txtValorTotalParcelado.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtValorTotalParcelado.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtValorTotalParcelado.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtValorTotalParcelado.TabIndex = 1050;
            txtValorTotalParcelado.TabStop = false;
            txtValorTotalParcelado.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10.75F);
            label6.ForeColor = Color.FromArgb(8, 100, 255);
            label6.Location = new Point(4, 22);
            label6.Name = "label6";
            label6.Size = new Size(117, 20);
            label6.TabIndex = 1049;
            label6.Text = "Vlr. T. Parcelado:";
            // 
            // numIntervalo
            // 
            numIntervalo.Location = new Point(120, 111);
            numIntervalo.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numIntervalo.Name = "numIntervalo";
            numIntervalo.Size = new Size(170, 28);
            numIntervalo.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            numIntervalo.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            numIntervalo.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            numIntervalo.StateCommon.Border.Rounding = 8F;
            numIntervalo.StateCommon.Border.Width = 1;
            numIntervalo.TabIndex = 1048;
            numIntervalo.Value = new decimal(new int[] { 30, 0, 0, 0 });
            numIntervalo.ValueChanged += numIntervalo_ValueChanged;
            // 
            // lblIntervalo
            // 
            lblIntervalo.AutoSize = true;
            lblIntervalo.BackColor = Color.Transparent;
            lblIntervalo.Font = new Font("Segoe UI", 9.75F);
            lblIntervalo.ForeColor = Color.FromArgb(8, 100, 255);
            lblIntervalo.Location = new Point(5, 117);
            lblIntervalo.Name = "lblIntervalo";
            lblIntervalo.Size = new Size(97, 17);
            lblIntervalo.TabIndex = 1047;
            lblIntervalo.Text = "Intervalo (dias):";
            // 
            // dgvParcelas
            // 
            dgvParcelas.AllowUserToAddRows = false;
            dgvParcelas.Location = new Point(10, 178);
            dgvParcelas.Name = "dgvParcelas";
            dgvParcelas.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            dgvParcelas.RowHeadersWidth = 23;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvParcelas.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvParcelas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvParcelas.Size = new Size(280, 160);
            dgvParcelas.TabIndex = 1036;
            // 
            // btnGerar
            // 
            btnGerar.CornerRoundingRadius = 10F;
            btnGerar.Location = new Point(10, 348);
            btnGerar.Name = "btnGerar";
            btnGerar.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnGerar.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnGerar.OverrideDefault.Back.ColorAngle = 45F;
            btnGerar.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnGerar.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnGerar.OverrideDefault.Border.ColorAngle = 45F;
            btnGerar.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnGerar.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnGerar.OverrideDefault.Border.Rounding = 20F;
            btnGerar.OverrideDefault.Border.Width = 1;
            btnGerar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnGerar.Size = new Size(135, 35);
            btnGerar.StateCommon.Back.Color1 = Color.FromArgb(0, 192, 0);
            btnGerar.StateCommon.Back.Color2 = Color.MediumSeaGreen;
            btnGerar.StateCommon.Back.ColorAngle = 45F;
            btnGerar.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnGerar.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnGerar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnGerar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnGerar.StateCommon.Border.Rounding = 10F;
            btnGerar.StateCommon.Border.Width = 1;
            btnGerar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnGerar.StateCommon.Content.ShortText.Color2 = Color.White;
            btnGerar.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
            btnGerar.StatePressed.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnGerar.StatePressed.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnGerar.StatePressed.Back.ColorAngle = 135F;
            btnGerar.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnGerar.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnGerar.StatePressed.Border.ColorAngle = 135F;
            btnGerar.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnGerar.StatePressed.Border.Rounding = 20F;
            btnGerar.StatePressed.Border.Width = 1;
            btnGerar.StatePressed.Content.ShortText.Color1 = Color.Black;
            btnGerar.StatePressed.Content.ShortText.Color2 = Color.Black;
            btnGerar.StateTracking.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnGerar.StateTracking.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnGerar.StateTracking.Back.ColorAngle = 45F;
            btnGerar.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnGerar.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnGerar.StateTracking.Border.ColorAngle = 45F;
            btnGerar.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnGerar.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnGerar.StateTracking.Border.Rounding = 20F;
            btnGerar.StateTracking.Border.Width = 1;
            btnGerar.StateTracking.Content.ShortText.Color1 = Color.Black;
            btnGerar.StateTracking.Content.ShortText.Color2 = Color.Black;
            btnGerar.TabIndex = 1040;
            btnGerar.Values.Text = "Gerar";
            btnGerar.Click += btnGerar_Click;
            // 
            // btnCancelarParcelas
            // 
            btnCancelarParcelas.CornerRoundingRadius = 10F;
            btnCancelarParcelas.Location = new Point(155, 348);
            btnCancelarParcelas.Name = "btnCancelarParcelas";
            btnCancelarParcelas.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnCancelarParcelas.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnCancelarParcelas.OverrideDefault.Back.ColorAngle = 45F;
            btnCancelarParcelas.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnCancelarParcelas.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnCancelarParcelas.OverrideDefault.Border.ColorAngle = 45F;
            btnCancelarParcelas.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelarParcelas.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancelarParcelas.OverrideDefault.Border.Rounding = 20F;
            btnCancelarParcelas.OverrideDefault.Border.Width = 1;
            btnCancelarParcelas.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnCancelarParcelas.Size = new Size(135, 35);
            btnCancelarParcelas.StateCommon.Back.Color1 = Color.FromArgb(200, 10, 39);
            btnCancelarParcelas.StateCommon.Back.Color2 = Color.Red;
            btnCancelarParcelas.StateCommon.Back.ColorAngle = 45F;
            btnCancelarParcelas.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnCancelarParcelas.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnCancelarParcelas.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelarParcelas.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancelarParcelas.StateCommon.Border.Rounding = 10F;
            btnCancelarParcelas.StateCommon.Border.Width = 1;
            btnCancelarParcelas.StateCommon.Content.ShortText.Color1 = Color.White;
            btnCancelarParcelas.StateCommon.Content.ShortText.Color2 = Color.White;
            btnCancelarParcelas.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
            btnCancelarParcelas.StatePressed.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnCancelarParcelas.StatePressed.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnCancelarParcelas.StatePressed.Back.ColorAngle = 135F;
            btnCancelarParcelas.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnCancelarParcelas.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnCancelarParcelas.StatePressed.Border.ColorAngle = 135F;
            btnCancelarParcelas.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelarParcelas.StatePressed.Border.Rounding = 20F;
            btnCancelarParcelas.StatePressed.Border.Width = 1;
            btnCancelarParcelas.StatePressed.Content.ShortText.Color1 = Color.Black;
            btnCancelarParcelas.StatePressed.Content.ShortText.Color2 = Color.Black;
            btnCancelarParcelas.StateTracking.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnCancelarParcelas.StateTracking.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnCancelarParcelas.StateTracking.Back.ColorAngle = 45F;
            btnCancelarParcelas.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnCancelarParcelas.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnCancelarParcelas.StateTracking.Border.ColorAngle = 45F;
            btnCancelarParcelas.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelarParcelas.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancelarParcelas.StateTracking.Border.Rounding = 20F;
            btnCancelarParcelas.StateTracking.Border.Width = 1;
            btnCancelarParcelas.StateTracking.Content.ShortText.Color1 = Color.Black;
            btnCancelarParcelas.StateTracking.Content.ShortText.Color2 = Color.Black;
            btnCancelarParcelas.TabIndex = 1041;
            btnCancelarParcelas.Values.Text = "Cancelar";
            btnCancelarParcelas.Click += btnCancelarParcelas_Click;
            // 
            // numParcelas
            // 
            numParcelas.Location = new Point(120, 46);
            numParcelas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numParcelas.Name = "numParcelas";
            numParcelas.Size = new Size(170, 28);
            numParcelas.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            numParcelas.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            numParcelas.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            numParcelas.StateCommon.Border.Rounding = 8F;
            numParcelas.StateCommon.Border.Width = 1;
            numParcelas.TabIndex = 1043;
            numParcelas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numParcelas.ValueChanged += numParcelas_ValueChanged;
            // 
            // lblQtdParcelas
            // 
            lblQtdParcelas.AutoSize = true;
            lblQtdParcelas.BackColor = Color.Transparent;
            lblQtdParcelas.Font = new Font("Segoe UI", 9.75F);
            lblQtdParcelas.ForeColor = Color.FromArgb(8, 100, 255);
            lblQtdParcelas.Location = new Point(5, 53);
            lblQtdParcelas.Name = "lblQtdParcelas";
            lblQtdParcelas.Size = new Size(79, 17);
            lblQtdParcelas.TabIndex = 1042;
            lblQtdParcelas.Text = "Nº Parcelas:";
            // 
            // lblPrimeiroVenc
            // 
            lblPrimeiroVenc.AutoSize = true;
            lblPrimeiroVenc.BackColor = Color.Transparent;
            lblPrimeiroVenc.Font = new Font("Segoe UI", 9.75F);
            lblPrimeiroVenc.ForeColor = Color.FromArgb(8, 100, 255);
            lblPrimeiroVenc.Location = new Point(5, 84);
            lblPrimeiroVenc.Name = "lblPrimeiroVenc";
            lblPrimeiroVenc.Size = new Size(74, 17);
            lblPrimeiroVenc.TabIndex = 1045;
            lblPrimeiroVenc.Text = "Data Inicial:";
            // 
            // dtPrimeira
            // 
            dtPrimeira.CornerRoundingRadius = 20F;
            dtPrimeira.Format = DateTimePickerFormat.Short;
            dtPrimeira.Location = new Point(120, 76);
            dtPrimeira.Name = "dtPrimeira";
            dtPrimeira.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue;
            dtPrimeira.Size = new Size(170, 33);
            dtPrimeira.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            dtPrimeira.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            dtPrimeira.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtPrimeira.StateCommon.Border.Rounding = 20F;
            dtPrimeira.StateCommon.Border.Width = 1;
            dtPrimeira.TabIndex = 1044;
            // 
            // txtValorParcela
            // 
            txtValorParcela.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtValorParcela.Location = new Point(120, 141);
            txtValorParcela.Name = "txtValorParcela";
            txtValorParcela.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtValorParcela.ReadOnly = true;
            txtValorParcela.Size = new Size(170, 24);
            txtValorParcela.StateCommon.Back.Color1 = Color.White;
            txtValorParcela.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtValorParcela.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtValorParcela.StateCommon.Border.ColorAngle = 1F;
            txtValorParcela.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtValorParcela.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtValorParcela.StateCommon.Border.Rounding = 8F;
            txtValorParcela.StateCommon.Border.Width = 1;
            txtValorParcela.StateCommon.Content.Color1 = Color.Gray;
            txtValorParcela.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtValorParcela.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtValorParcela.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtValorParcela.TabIndex = 1038;
            txtValorParcela.TabStop = false;
            txtValorParcela.TextAlign = HorizontalAlignment.Center;
            // 
            // lblValorParcela
            // 
            lblValorParcela.AutoSize = true;
            lblValorParcela.BackColor = Color.Transparent;
            lblValorParcela.Font = new Font("Segoe UI", 10.75F);
            lblValorParcela.ForeColor = Color.FromArgb(8, 100, 255);
            lblValorParcela.Location = new Point(5, 144);
            lblValorParcela.Name = "lblValorParcela";
            lblValorParcela.Size = new Size(97, 20);
            lblValorParcela.TabIndex = 1037;
            lblValorParcela.Text = "Valor Parcela:";
            // 
            // panel1
            // 
            panel1.Controls.Add(tabControlPagamento);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnSalvarVenda);
            panel1.Controls.Add(btnImprimir);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(580, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 529);
            panel1.TabIndex = 1041;
            // 
            // txtObservacao
            // 
            txtObservacao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtObservacao.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtObservacao.Location = new Point(4, 439);
            txtObservacao.Multiline = true;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtObservacao.Size = new Size(567, 99);
            txtObservacao.StateCommon.Back.Color1 = Color.White;
            txtObservacao.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtObservacao.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtObservacao.StateCommon.Border.ColorAngle = 1F;
            txtObservacao.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtObservacao.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtObservacao.StateCommon.Border.Rounding = 8F;
            txtObservacao.StateCommon.Border.Width = 1;
            txtObservacao.StateCommon.Content.Color1 = Color.Gray;
            txtObservacao.StateCommon.Content.Font = new Font("Segoe UI", 12.75F);
            txtObservacao.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtObservacao.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtObservacao.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtObservacao.TabIndex = 1027;
            txtObservacao.TabStop = false;
            txtObservacao.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.ForeColor = Color.FromArgb(0, 76, 172);
            label4.Location = new Point(7, 416);
            label4.Name = "label4";
            label4.Size = new Size(78, 17);
            label4.TabIndex = 1028;
            label4.Text = "Observação";
            // 
            // FrmVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(880, 583);
            Controls.Add(label2);
            Controls.Add(txtCpf);
            Controls.Add(txtQuantidade);
            Controls.Add(txtObservacao);
            Controls.Add(txtPrecoUnitario);
            Controls.Add(lblCpf);
            Controls.Add(btnAdicionarItem);
            Controls.Add(label4);
            Controls.Add(txtNomeProduto);
            Controls.Add(label13);
            Controls.Add(txtNomeCliente);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(panel1);
            Controls.Add(kryptonPanel1);
            Controls.Add(kryptonStatusStrip1);
            Controls.Add(dgvitens);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmVendas";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PDV-Ponto de Vendas";
            WindowState = FormWindowState.Maximized;
            Load += FrmVendas_Load;
            Shown += FrmVendas_Shown;
            KeyDown += FrmVendas_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dgvitens).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbFormaPagamento).EndInit();
            kryptonStatusStrip1.ResumeLayout(false);
            kryptonStatusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            tabControlPagamento.ResumeLayout(false);
            tabPagamento.ResumeLayout(false);
            tabPagamento.PerformLayout();
            tabParcelas.ResumeLayout(false);
            tabParcelas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvParcelas).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Krypton.Toolkit.KryptonTextBox txtNomeCliente;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Krypton.Toolkit.KryptonDataGridView dgvitens;
        private Label lblDesconto;
        public Krypton.Toolkit.KryptonTextBox txtDesconto;
        private Label lblTotalGeral;
        public Krypton.Toolkit.KryptonTextBox txtTotalGeral;
        private Krypton.Toolkit.KryptonComboBox cmbFormaPagamento;
        public Krypton.Toolkit.KryptonButton btnAdicionarItem;
        public Krypton.Toolkit.KryptonButton btnSalvarVenda;
        public Krypton.Toolkit.KryptonButton btnCancelar;
        public Krypton.Toolkit.KryptonButton btnImprimir;
        public Krypton.Toolkit.KryptonButton btnGerarParcelas;
        public Krypton.Toolkit.KryptonTextBox txtValorRecebido;
        private Label lblValorRecebido;
        private Label label12;
        public Krypton.Toolkit.KryptonTextBox txtNomeProduto;
        public Krypton.Toolkit.KryptonTextBox txtPrecoUnitario;
        private Label label13;
        private Label label10;
        private Krypton.Toolkit.KryptonStatusStrip kryptonStatusStrip1;
        private ToolStripStatusLabel lblStatusParcelas;
        private Label label1;
        private Label lblVendaID;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Label label3;
        private Label lblData;
        public Krypton.Toolkit.KryptonTextBox txtCpf;
        private Label lblCpf;
        public Krypton.Toolkit.KryptonTextBox txtQuantidade;
        public Krypton.Toolkit.KryptonTextBox txtSubTotal;
        private Label lblSubTotal;
        public Krypton.Toolkit.KryptonTextBox txtTroco;
        private Label lblTroco;
        private TabControl tabControlPagamento;
        private TabPage tabPagamento;
        private TabPage tabParcelas;
        private Label lblFormaPgto;
        private Panel panel1;
        private Label lblIntervalo;
        private Krypton.Toolkit.KryptonDataGridView dgvParcelas;
        private Label lblPrimeiroVenc;
        private Krypton.Toolkit.KryptonDateTimePicker dtPrimeira;
        private Krypton.Toolkit.KryptonNumericUpDown numParcelas;
        private Label lblQtdParcelas;
        public Krypton.Toolkit.KryptonButton btnGerar;
        public Krypton.Toolkit.KryptonButton btnCancelarParcelas;
        public Krypton.Toolkit.KryptonTextBox txtValorParcela;
        private Label lblValorParcela;
        private Krypton.Toolkit.KryptonNumericUpDown numIntervalo;
        public Krypton.Toolkit.KryptonTextBox txtValorTotalParcelado;
        private Label label6;
        private Label label2;
        public Krypton.Toolkit.KryptonTextBox txtObservacao;
        private Label label4;
    }
}