namespace GVC.View
{
    partial class FrmBaixarParcela
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
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            lblValorParcela = new Label();
            btnCancelar = new Krypton.Toolkit.KryptonButton();
            btnConfirmarBaixa = new Krypton.Toolkit.KryptonButton();
            lblFormaPgto = new Label();
            cmbFormaPagamento = new Krypton.Toolkit.KryptonComboBox();
            txtSaldo = new Krypton.Toolkit.KryptonTextBox();
            txtValorRecebido = new Krypton.Toolkit.KryptonTextBox();
            lblValorRecebido = new Label();
            kryptonStatusStrip1 = new Krypton.Toolkit.KryptonStatusStrip();
            lblInfo = new ToolStripStatusLabel();
            btnListarControlesDoForm = new Krypton.Toolkit.KryptonButton();
            dgvParcelasBaixa = new Krypton.Toolkit.KryptonDataGridView();
            txtValorParcela = new Krypton.Toolkit.KryptonTextBox();
            lblSaldo = new Label();
            txtClienteNome = new Krypton.Toolkit.KryptonTextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)cmbFormaPagamento).BeginInit();
            kryptonStatusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvParcelasBaixa).BeginInit();
            SuspendLayout();
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
            // lblValorParcela
            // 
            lblValorParcela.AutoSize = true;
            lblValorParcela.BackColor = Color.Transparent;
            lblValorParcela.Font = new Font("Segoe UI", 9.75F);
            lblValorParcela.ForeColor = Color.FromArgb(0, 76, 172);
            lblValorParcela.Location = new Point(-1, 159);
            lblValorParcela.Name = "lblValorParcela";
            lblValorParcela.Size = new Size(87, 17);
            lblValorParcela.TabIndex = 1032;
            lblValorParcela.Text = "Valor Parcela:";
            // 
            // btnCancelar
            // 
            btnCancelar.CornerRoundingRadius = 6F;
            btnCancelar.Location = new Point(396, 233);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnCancelar.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnCancelar.OverrideDefault.Back.ColorAngle = 45F;
            btnCancelar.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnCancelar.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnCancelar.OverrideDefault.Border.ColorAngle = 45F;
            btnCancelar.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelar.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancelar.OverrideDefault.Border.Rounding = 20F;
            btnCancelar.OverrideDefault.Border.Width = 1;
            btnCancelar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnCancelar.Size = new Size(120, 30);
            btnCancelar.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnCancelar.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnCancelar.StateCommon.Back.ColorAngle = 45F;
            btnCancelar.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnCancelar.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnCancelar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancelar.StateCommon.Border.Rounding = 6F;
            btnCancelar.StateCommon.Border.Width = 1;
            btnCancelar.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnCancelar.StateCommon.Content.ShortText.Color2 = Color.White;
            btnCancelar.StateCommon.Content.ShortText.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.StatePressed.Back.Color1 = Color.Red;
            btnCancelar.StatePressed.Back.Color2 = Color.Red;
            btnCancelar.StatePressed.Back.ColorAngle = 135F;
            btnCancelar.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnCancelar.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnCancelar.StatePressed.Border.ColorAngle = 135F;
            btnCancelar.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelar.StatePressed.Border.Rounding = 20F;
            btnCancelar.StatePressed.Border.Width = 1;
            btnCancelar.StateTracking.Back.Color1 = Color.Red;
            btnCancelar.StateTracking.Back.Color2 = Color.Red;
            btnCancelar.StateTracking.Back.ColorAngle = 45F;
            btnCancelar.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnCancelar.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnCancelar.StateTracking.Border.ColorAngle = 45F;
            btnCancelar.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelar.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancelar.StateTracking.Border.Rounding = 20F;
            btnCancelar.StateTracking.Border.Width = 1;
            btnCancelar.StateTracking.Content.ShortText.Color1 = Color.White;
            btnCancelar.TabIndex = 1046;
            btnCancelar.TabStop = false;
            btnCancelar.Values.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmarBaixa
            // 
            btnConfirmarBaixa.CornerRoundingRadius = 6F;
            btnConfirmarBaixa.Location = new Point(523, 233);
            btnConfirmarBaixa.Name = "btnConfirmarBaixa";
            btnConfirmarBaixa.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnConfirmarBaixa.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnConfirmarBaixa.OverrideDefault.Back.ColorAngle = 45F;
            btnConfirmarBaixa.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnConfirmarBaixa.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnConfirmarBaixa.OverrideDefault.Border.ColorAngle = 45F;
            btnConfirmarBaixa.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnConfirmarBaixa.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnConfirmarBaixa.OverrideDefault.Border.Rounding = 20F;
            btnConfirmarBaixa.OverrideDefault.Border.Width = 1;
            btnConfirmarBaixa.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnConfirmarBaixa.Size = new Size(120, 30);
            btnConfirmarBaixa.StateCommon.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnConfirmarBaixa.StateCommon.Back.Color2 = Color.FromArgb(6, 180, 240);
            btnConfirmarBaixa.StateCommon.Back.ColorAngle = 45F;
            btnConfirmarBaixa.StateCommon.Border.Color1 = Color.FromArgb(0, 76, 172);
            btnConfirmarBaixa.StateCommon.Border.Color2 = Color.FromArgb(0, 76, 172);
            btnConfirmarBaixa.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnConfirmarBaixa.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnConfirmarBaixa.StateCommon.Border.Rounding = 6F;
            btnConfirmarBaixa.StateCommon.Border.Width = 1;
            btnConfirmarBaixa.StateCommon.Content.ShortText.Color1 = Color.White;
            btnConfirmarBaixa.StateCommon.Content.ShortText.Color2 = Color.White;
            btnConfirmarBaixa.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
            btnConfirmarBaixa.StatePressed.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnConfirmarBaixa.StatePressed.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnConfirmarBaixa.StatePressed.Back.ColorAngle = 135F;
            btnConfirmarBaixa.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnConfirmarBaixa.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnConfirmarBaixa.StatePressed.Border.ColorAngle = 135F;
            btnConfirmarBaixa.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnConfirmarBaixa.StatePressed.Border.Rounding = 20F;
            btnConfirmarBaixa.StatePressed.Border.Width = 1;
            btnConfirmarBaixa.StatePressed.Content.ShortText.Color1 = Color.Black;
            btnConfirmarBaixa.StatePressed.Content.ShortText.Color2 = Color.Black;
            btnConfirmarBaixa.StateTracking.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnConfirmarBaixa.StateTracking.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnConfirmarBaixa.StateTracking.Back.ColorAngle = 45F;
            btnConfirmarBaixa.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnConfirmarBaixa.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnConfirmarBaixa.StateTracking.Border.ColorAngle = 45F;
            btnConfirmarBaixa.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnConfirmarBaixa.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnConfirmarBaixa.StateTracking.Border.Rounding = 20F;
            btnConfirmarBaixa.StateTracking.Border.Width = 1;
            btnConfirmarBaixa.StateTracking.Content.ShortText.Color1 = Color.Black;
            btnConfirmarBaixa.StateTracking.Content.ShortText.Color2 = Color.Black;
            btnConfirmarBaixa.TabIndex = 2;
            btnConfirmarBaixa.Values.Text = "Confirmar";
            btnConfirmarBaixa.Click += btnConfirmarBaixa_Click;
            // 
            // lblFormaPgto
            // 
            lblFormaPgto.AutoSize = true;
            lblFormaPgto.BackColor = Color.Transparent;
            lblFormaPgto.Font = new Font("Segoe UI", 9.75F);
            lblFormaPgto.ForeColor = Color.FromArgb(0, 76, 172);
            lblFormaPgto.Location = new Point(442, 159);
            lblFormaPgto.Name = "lblFormaPgto";
            lblFormaPgto.Size = new Size(79, 17);
            lblFormaPgto.TabIndex = 1050;
            lblFormaPgto.Text = "Forma Pgto:";
            // 
            // cmbFormaPagamento
            // 
            cmbFormaPagamento.CornerRoundingRadius = 6F;
            cmbFormaPagamento.DropDownWidth = 171;
            cmbFormaPagamento.IntegralHeight = false;
            cmbFormaPagamento.Items.AddRange(new object[] { "Dinheiro", "Cartão de Crédito", "Cartão de Débito", "PIX", "Boleto Bancário", "Transferência Bancária", "Cheque", "Vale Alimentação", "Vale Refeição", "Crediário", "Financiamento", "Carteira Digital", "Outros" });
            cmbFormaPagamento.Location = new Point(433, 179);
            cmbFormaPagamento.Name = "cmbFormaPagamento";
            cmbFormaPagamento.Size = new Size(211, 25);
            cmbFormaPagamento.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbFormaPagamento.StateCommon.ComboBox.Border.Rounding = 6F;
            cmbFormaPagamento.StateCommon.ComboBox.Border.Width = 1;
            cmbFormaPagamento.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbFormaPagamento.TabIndex = 1049;
            cmbFormaPagamento.TabStop = false;
            // 
            // txtSaldo
            // 
            txtSaldo.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtSaldo.Location = new Point(289, 179);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtSaldo.ReadOnly = true;
            txtSaldo.Size = new Size(140, 24);
            txtSaldo.StateCommon.Back.Color1 = Color.White;
            txtSaldo.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtSaldo.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtSaldo.StateCommon.Border.ColorAngle = 1F;
            txtSaldo.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtSaldo.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtSaldo.StateCommon.Border.Rounding = 6F;
            txtSaldo.StateCommon.Border.Width = 1;
            txtSaldo.StateCommon.Content.Color1 = Color.Gray;
            txtSaldo.StateCommon.Content.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSaldo.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtSaldo.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtSaldo.StateNormal.Back.Color1 = Color.FromArgb(192, 255, 255);
            txtSaldo.StateNormal.Content.Color1 = Color.FromArgb(192, 255, 255);
            txtSaldo.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtSaldo.TabIndex = 1054;
            txtSaldo.TabStop = false;
            // 
            // txtValorRecebido
            // 
            txtValorRecebido.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtValorRecebido.Location = new Point(144, 179);
            txtValorRecebido.Name = "txtValorRecebido";
            txtValorRecebido.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtValorRecebido.Size = new Size(140, 24);
            txtValorRecebido.StateCommon.Back.Color1 = Color.White;
            txtValorRecebido.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtValorRecebido.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtValorRecebido.StateCommon.Border.ColorAngle = 1F;
            txtValorRecebido.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtValorRecebido.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtValorRecebido.StateCommon.Border.Rounding = 6F;
            txtValorRecebido.StateCommon.Border.Width = 1;
            txtValorRecebido.StateCommon.Content.Color1 = Color.Gray;
            txtValorRecebido.StateCommon.Content.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValorRecebido.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtValorRecebido.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtValorRecebido.StateNormal.Back.Color1 = Color.FromArgb(192, 255, 255);
            txtValorRecebido.StateNormal.Content.Color1 = Color.FromArgb(192, 255, 255);
            txtValorRecebido.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtValorRecebido.TabIndex = 0;
            txtValorRecebido.TextChanged += txtValorRecebido_TextChanged;
            txtValorRecebido.Leave += txtValorRecebido_Leave;
            // 
            // lblValorRecebido
            // 
            lblValorRecebido.AutoSize = true;
            lblValorRecebido.Font = new Font("Segoe UI", 9.75F);
            lblValorRecebido.ForeColor = Color.FromArgb(0, 76, 172);
            lblValorRecebido.Location = new Point(144, 159);
            lblValorRecebido.Name = "lblValorRecebido";
            lblValorRecebido.Size = new Size(75, 17);
            lblValorRecebido.TabIndex = 1055;
            lblValorRecebido.Text = "Valor Baixa:";
            // 
            // kryptonStatusStrip1
            // 
            kryptonStatusStrip1.Font = new Font("Segoe UI", 9F);
            kryptonStatusStrip1.Items.AddRange(new ToolStripItem[] { lblInfo });
            kryptonStatusStrip1.Location = new Point(0, 286);
            kryptonStatusStrip1.Name = "kryptonStatusStrip1";
            kryptonStatusStrip1.ProgressBars = null;
            kryptonStatusStrip1.RenderMode = ToolStripRenderMode.ManagerRenderMode;
            kryptonStatusStrip1.Size = new Size(644, 22);
            kryptonStatusStrip1.TabIndex = 1057;
            kryptonStatusStrip1.Text = "kryptonStatusStrip1";
            // 
            // lblInfo
            // 
            lblInfo.ForeColor = Color.FromArgb(0, 192, 0);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(41, 17);
            lblInfo.Text = "lblInfo";
            // 
            // btnListarControlesDoForm
            // 
            btnListarControlesDoForm.CornerRoundingRadius = 6F;
            btnListarControlesDoForm.Location = new Point(-1, 233);
            btnListarControlesDoForm.Margin = new Padding(4, 3, 4, 3);
            btnListarControlesDoForm.Name = "btnListarControlesDoForm";
            btnListarControlesDoForm.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnListarControlesDoForm.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnListarControlesDoForm.OverrideDefault.Back.ColorAngle = 45F;
            btnListarControlesDoForm.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnListarControlesDoForm.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnListarControlesDoForm.OverrideDefault.Border.ColorAngle = 45F;
            btnListarControlesDoForm.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnListarControlesDoForm.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnListarControlesDoForm.OverrideDefault.Border.Rounding = 20F;
            btnListarControlesDoForm.OverrideDefault.Border.Width = 1;
            btnListarControlesDoForm.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnListarControlesDoForm.Size = new Size(120, 30);
            btnListarControlesDoForm.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnListarControlesDoForm.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnListarControlesDoForm.StateCommon.Back.ColorAngle = 45F;
            btnListarControlesDoForm.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnListarControlesDoForm.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnListarControlesDoForm.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnListarControlesDoForm.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnListarControlesDoForm.StateCommon.Border.Rounding = 6F;
            btnListarControlesDoForm.StateCommon.Border.Width = 1;
            btnListarControlesDoForm.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnListarControlesDoForm.StateCommon.Content.ShortText.Color2 = Color.White;
            btnListarControlesDoForm.StateCommon.Content.ShortText.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnListarControlesDoForm.StatePressed.Back.Color1 = Color.Red;
            btnListarControlesDoForm.StatePressed.Back.Color2 = Color.Red;
            btnListarControlesDoForm.StatePressed.Back.ColorAngle = 135F;
            btnListarControlesDoForm.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnListarControlesDoForm.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnListarControlesDoForm.StatePressed.Border.ColorAngle = 135F;
            btnListarControlesDoForm.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnListarControlesDoForm.StatePressed.Border.Rounding = 20F;
            btnListarControlesDoForm.StatePressed.Border.Width = 1;
            btnListarControlesDoForm.StateTracking.Back.Color1 = Color.Red;
            btnListarControlesDoForm.StateTracking.Back.Color2 = Color.Red;
            btnListarControlesDoForm.StateTracking.Back.ColorAngle = 45F;
            btnListarControlesDoForm.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnListarControlesDoForm.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnListarControlesDoForm.StateTracking.Border.ColorAngle = 45F;
            btnListarControlesDoForm.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnListarControlesDoForm.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnListarControlesDoForm.StateTracking.Border.Rounding = 20F;
            btnListarControlesDoForm.StateTracking.Border.Width = 1;
            btnListarControlesDoForm.StateTracking.Content.ShortText.Color1 = Color.White;
            btnListarControlesDoForm.TabIndex = 1058;
            btnListarControlesDoForm.TabStop = false;
            btnListarControlesDoForm.Values.Text = "Listar Controles";
            btnListarControlesDoForm.Click += btnListarControlesDoForm_Click;
            // 
            // dgvParcelasBaixa
            // 
            dgvParcelasBaixa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvParcelasBaixa.Location = new Point(0, 43);
            dgvParcelasBaixa.Name = "dgvParcelasBaixa";
            dgvParcelasBaixa.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007SilverDarkMode;
            dgvParcelasBaixa.Size = new Size(644, 114);
            dgvParcelasBaixa.TabIndex = 1059;
            dgvParcelasBaixa.TabStop = false;
            dgvParcelasBaixa.CellFormatting += dgvParcelasBaixa_CellFormatting;
            // 
            // txtValorParcela
            // 
            txtValorParcela.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtValorParcela.Location = new Point(0, 179);
            txtValorParcela.Name = "txtValorParcela";
            txtValorParcela.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtValorParcela.ReadOnly = true;
            txtValorParcela.Size = new Size(140, 24);
            txtValorParcela.StateCommon.Back.Color1 = Color.White;
            txtValorParcela.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtValorParcela.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtValorParcela.StateCommon.Border.ColorAngle = 1F;
            txtValorParcela.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtValorParcela.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtValorParcela.StateCommon.Border.Rounding = 6F;
            txtValorParcela.StateCommon.Border.Width = 1;
            txtValorParcela.StateCommon.Content.Color1 = Color.Gray;
            txtValorParcela.StateCommon.Content.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValorParcela.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtValorParcela.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtValorParcela.StateNormal.Back.Color1 = Color.FromArgb(192, 255, 255);
            txtValorParcela.StateNormal.Content.Color1 = Color.FromArgb(192, 255, 255);
            txtValorParcela.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtValorParcela.TabIndex = 1039;
            txtValorParcela.TabStop = false;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.BackColor = Color.Transparent;
            lblSaldo.Font = new Font("Segoe UI", 9.75F);
            lblSaldo.ForeColor = Color.FromArgb(0, 76, 172);
            lblSaldo.Location = new Point(3, 9);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(50, 17);
            lblSaldo.TabIndex = 1053;
            lblSaldo.Text = "Cliente:";
            // 
            // txtClienteNome
            // 
            txtClienteNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtClienteNome.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtClienteNome.Location = new Point(60, 5);
            txtClienteNome.Name = "txtClienteNome";
            txtClienteNome.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtClienteNome.ReadOnly = true;
            txtClienteNome.Size = new Size(583, 24);
            txtClienteNome.StateCommon.Back.Color1 = Color.White;
            txtClienteNome.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtClienteNome.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtClienteNome.StateCommon.Border.ColorAngle = 1F;
            txtClienteNome.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtClienteNome.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtClienteNome.StateCommon.Border.Rounding = 6F;
            txtClienteNome.StateCommon.Border.Width = 1;
            txtClienteNome.StateCommon.Content.Color1 = Color.Gray;
            txtClienteNome.StateCommon.Content.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClienteNome.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtClienteNome.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtClienteNome.StateNormal.Back.Color1 = Color.FromArgb(192, 255, 255);
            txtClienteNome.StateNormal.Content.Color1 = Color.FromArgb(192, 255, 255);
            txtClienteNome.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtClienteNome.TabIndex = 1028;
            txtClienteNome.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.ForeColor = Color.FromArgb(0, 76, 172);
            label1.Location = new Point(293, 159);
            label1.Name = "label1";
            label1.Size = new Size(44, 17);
            label1.TabIndex = 1060;
            label1.Text = "Saldo:";
            // 
            // FrmBaixarParcela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(644, 308);
            Controls.Add(label1);
            Controls.Add(dgvParcelasBaixa);
            Controls.Add(btnListarControlesDoForm);
            Controls.Add(kryptonStatusStrip1);
            Controls.Add(txtValorRecebido);
            Controls.Add(lblValorRecebido);
            Controls.Add(txtSaldo);
            Controls.Add(lblSaldo);
            Controls.Add(lblFormaPgto);
            Controls.Add(cmbFormaPagamento);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmarBaixa);
            Controls.Add(txtValorParcela);
            Controls.Add(lblValorParcela);
            Controls.Add(txtClienteNome);
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmBaixarParcela";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Baixar Parcela";
            Load += FrmBaixarParcela_Load;
            Shown += FrmBaixarParcela_Shown;
            KeyDown += FrmBaixarParcela_KeyDown;
            ((System.ComponentModel.ISupportInitialize)cmbFormaPagamento).EndInit();
            kryptonStatusStrip1.ResumeLayout(false);
            kryptonStatusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvParcelasBaixa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Label lblValorParcela;
        private Krypton.Toolkit.KryptonButton btnCancelar;
        public Krypton.Toolkit.KryptonButton btnConfirmarBaixa;
        private Label lblFormaPgto;
        private Krypton.Toolkit.KryptonComboBox cmbFormaPagamento;
        public Krypton.Toolkit.KryptonTextBox txtSaldo;
        public Krypton.Toolkit.KryptonTextBox txtValorRecebido;
        private Label lblValorRecebido;
        private Krypton.Toolkit.KryptonStatusStrip kryptonStatusStrip1;
        private Krypton.Toolkit.KryptonButton btnListarControlesDoForm;
        private Krypton.Toolkit.KryptonDataGridView dgvParcelasBaixa;
        public Krypton.Toolkit.KryptonTextBox txtValorParcela;
        private Label lblSaldo;
        public Krypton.Toolkit.KryptonTextBox txtClienteNome;
        private Label label1;
        public ToolStripStatusLabel lblInfo;
    }
}