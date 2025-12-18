namespace GVC.View
{
    partial class FrmRelatorios
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
            btnImprimir = new Krypton.Toolkit.KryptonButton();
            dgvContasReceber = new Krypton.Toolkit.KryptonDataGridView();
            gbNomeCliente = new Krypton.Toolkit.KryptonGroupBox();
            btnLocalizarCliente = new Krypton.Toolkit.KryptonButton();
            txtClienteID = new Krypton.Toolkit.KryptonTextBox();
            txtNomeCliente = new Krypton.Toolkit.KryptonTextBox();
            label3 = new Label();
            label1 = new Label();
            gbPeriodo = new Krypton.Toolkit.KryptonGroupBox();
            dtpDataVencimentoInicio = new Krypton.Toolkit.KryptonDateTimePicker();
            dtpDataVencimentoFim = new Krypton.Toolkit.KryptonDateTimePicker();
            label2 = new Label();
            label4 = new Label();
            gbStatus = new Krypton.Toolkit.KryptonGroupBox();
            rbAberto = new RadioButton();
            rbPago = new RadioButton();
            btnFiltro = new Krypton.Toolkit.KryptonButton();
            kryptonGroupBox1 = new Krypton.Toolkit.KryptonGroupBox();
            cmbFiltro = new Krypton.Toolkit.KryptonComboBox();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            lblTotalRegistro = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            lblTotalRecebido = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            lblTotal = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            btnExportarExcel = new Krypton.Toolkit.KryptonButton();
            dgvItensVenda = new Krypton.Toolkit.KryptonDataGridView();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            label5 = new Label();
            label6 = new Label();
            btnSair = new Krypton.Toolkit.KryptonButton();
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            ((System.ComponentModel.ISupportInitialize)dgvContasReceber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gbNomeCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gbNomeCliente.Panel).BeginInit();
            gbNomeCliente.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gbPeriodo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gbPeriodo.Panel).BeginInit();
            gbPeriodo.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gbStatus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gbStatus.Panel).BeginInit();
            gbStatus.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonGroupBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonGroupBox1.Panel).BeginInit();
            kryptonGroupBox1.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbFiltro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensVenda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnImprimir
            // 
            btnImprimir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnImprimir.CornerRoundingRadius = 20F;
            btnImprimir.Location = new Point(715, 576);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnImprimir.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnImprimir.OverrideDefault.Back.ColorAngle = 45F;
            btnImprimir.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnImprimir.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnImprimir.OverrideDefault.Border.ColorAngle = 45F;
            btnImprimir.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnImprimir.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnImprimir.OverrideDefault.Border.Rounding = 20F;
            btnImprimir.OverrideDefault.Border.Width = 1;
            btnImprimir.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnImprimir.Size = new Size(121, 35);
            btnImprimir.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnImprimir.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnImprimir.StateCommon.Back.ColorAngle = 45F;
            btnImprimir.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnImprimir.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnImprimir.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnImprimir.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnImprimir.StateCommon.Border.Rounding = 20F;
            btnImprimir.StateCommon.Border.Width = 1;
            btnImprimir.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnImprimir.StateCommon.Content.ShortText.Color2 = Color.White;
            btnImprimir.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnImprimir.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnImprimir.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnImprimir.StatePressed.Back.ColorAngle = 135F;
            btnImprimir.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnImprimir.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnImprimir.StatePressed.Border.ColorAngle = 135F;
            btnImprimir.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnImprimir.StatePressed.Border.Rounding = 20F;
            btnImprimir.StatePressed.Border.Width = 1;
            btnImprimir.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnImprimir.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnImprimir.StateTracking.Back.ColorAngle = 45F;
            btnImprimir.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnImprimir.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnImprimir.StateTracking.Border.ColorAngle = 45F;
            btnImprimir.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnImprimir.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnImprimir.StateTracking.Border.Rounding = 20F;
            btnImprimir.StateTracking.Border.Width = 1;
            btnImprimir.StateTracking.Content.ShortText.Color1 = Color.White;
            btnImprimir.TabIndex = 4;
            btnImprimir.Values.Text = "Imprimir PDF";
            btnImprimir.Click += btnImprimir_Click;
            // 
            // dgvContasReceber
            // 
            dgvContasReceber.AllowUserToAddRows = false;
            dgvContasReceber.AllowUserToDeleteRows = false;
            dgvContasReceber.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContasReceber.Location = new Point(13, 116);
            dgvContasReceber.Name = "dgvContasReceber";
            dgvContasReceber.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlueDarkMode;
            dgvContasReceber.ReadOnly = true;
            dgvContasReceber.Size = new Size(944, 151);
            dgvContasReceber.TabIndex = 5;
            // 
            // gbNomeCliente
            // 
            gbNomeCliente.CaptionStyle = Krypton.Toolkit.LabelStyle.ItalicControl;
            gbNomeCliente.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlAlternate;
            gbNomeCliente.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.ControlCustom1;
            gbNomeCliente.Location = new Point(427, 44);
            gbNomeCliente.Name = "gbNomeCliente";
            // 
            // 
            // 
            gbNomeCliente.Panel.Controls.Add(btnLocalizarCliente);
            gbNomeCliente.Panel.Controls.Add(txtClienteID);
            gbNomeCliente.Panel.Controls.Add(txtNomeCliente);
            gbNomeCliente.Panel.Controls.Add(label3);
            gbNomeCliente.Panel.Controls.Add(label1);
            gbNomeCliente.Size = new Size(442, 68);
            gbNomeCliente.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            gbNomeCliente.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            gbNomeCliente.StateCommon.Border.ColorAngle = 45F;
            gbNomeCliente.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.SolidTopLine;
            gbNomeCliente.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            gbNomeCliente.StateCommon.Border.Width = 1;
            gbNomeCliente.StateCommon.Content.LongText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbNomeCliente.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbNomeCliente.TabIndex = 591;
            gbNomeCliente.Values.Heading = "Nome";
            gbNomeCliente.Visible = false;
            // 
            // btnLocalizarCliente
            // 
            btnLocalizarCliente.ButtonStyle = Krypton.Toolkit.ButtonStyle.Custom1;
            btnLocalizarCliente.CornerRoundingRadius = 1F;
            btnLocalizarCliente.Location = new Point(314, 15);
            btnLocalizarCliente.Name = "btnLocalizarCliente";
            btnLocalizarCliente.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnLocalizarCliente.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnLocalizarCliente.OverrideDefault.Back.ColorAngle = 45F;
            btnLocalizarCliente.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnLocalizarCliente.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLocalizarCliente.OverrideDefault.Border.ColorAngle = 45F;
            btnLocalizarCliente.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLocalizarCliente.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLocalizarCliente.OverrideDefault.Border.Rounding = 1F;
            btnLocalizarCliente.OverrideDefault.Border.Width = 1;
            btnLocalizarCliente.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue;
            btnLocalizarCliente.Size = new Size(123, 24);
            btnLocalizarCliente.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnLocalizarCliente.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnLocalizarCliente.StateCommon.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            btnLocalizarCliente.StateCommon.Back.ColorAngle = 45F;
            btnLocalizarCliente.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnLocalizarCliente.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLocalizarCliente.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLocalizarCliente.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLocalizarCliente.StateCommon.Border.Rounding = 1F;
            btnLocalizarCliente.StateCommon.Border.Width = 1;
            btnLocalizarCliente.StateCommon.Content.Image.Effect = Krypton.Toolkit.PaletteImageEffect.Normal;
            btnLocalizarCliente.StateCommon.Content.ShortText.Color1 = Color.White;
            btnLocalizarCliente.StateCommon.Content.ShortText.Color2 = Color.White;
            btnLocalizarCliente.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLocalizarCliente.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnLocalizarCliente.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnLocalizarCliente.StatePressed.Back.ColorAngle = 135F;
            btnLocalizarCliente.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnLocalizarCliente.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnLocalizarCliente.StatePressed.Border.ColorAngle = 135F;
            btnLocalizarCliente.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLocalizarCliente.StatePressed.Border.Rounding = 1F;
            btnLocalizarCliente.StatePressed.Border.Width = 1;
            btnLocalizarCliente.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnLocalizarCliente.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnLocalizarCliente.StateTracking.Back.ColorAngle = 45F;
            btnLocalizarCliente.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnLocalizarCliente.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLocalizarCliente.StateTracking.Border.ColorAngle = 45F;
            btnLocalizarCliente.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLocalizarCliente.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLocalizarCliente.StateTracking.Border.Rounding = 1F;
            btnLocalizarCliente.StateTracking.Border.Width = 1;
            btnLocalizarCliente.TabIndex = 1004;
            btnLocalizarCliente.Values.Text = "&Localizar (F4)";
            btnLocalizarCliente.Click += btnLocalizarCliente_Click;
            // 
            // txtClienteID
            // 
            txtClienteID.Location = new Point(7, 19);
            txtClienteID.Name = "txtClienteID";
            txtClienteID.Size = new Size(60, 23);
            txtClienteID.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtClienteID.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtClienteID.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtClienteID.TabIndex = 593;
            txtClienteID.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(70, 19);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(286, 23);
            txtNomeCliente.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtNomeCliente.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtNomeCliente.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtNomeCliente.TabIndex = 592;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 9F);
            label3.ForeColor = Color.FromArgb(8, 100, 255);
            label3.Location = new Point(7, -2);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 575;
            label3.Text = "ID Cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 9F);
            label1.ForeColor = Color.FromArgb(8, 100, 255);
            label1.Location = new Point(63, -2);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 573;
            label1.Text = "Nome Cliente";
            // 
            // gbPeriodo
            // 
            gbPeriodo.CaptionStyle = Krypton.Toolkit.LabelStyle.ItalicControl;
            gbPeriodo.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlAlternate;
            gbPeriodo.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.ControlCustom1;
            gbPeriodo.Location = new Point(423, 44);
            gbPeriodo.Name = "gbPeriodo";
            // 
            // 
            // 
            gbPeriodo.Panel.Controls.Add(dtpDataVencimentoInicio);
            gbPeriodo.Panel.Controls.Add(dtpDataVencimentoFim);
            gbPeriodo.Panel.Controls.Add(label2);
            gbPeriodo.Panel.Controls.Add(label4);
            gbPeriodo.Size = new Size(385, 68);
            gbPeriodo.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            gbPeriodo.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            gbPeriodo.StateCommon.Border.ColorAngle = 45F;
            gbPeriodo.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.SolidTopLine;
            gbPeriodo.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            gbPeriodo.StateCommon.Border.Width = 1;
            gbPeriodo.StateCommon.Content.LongText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbPeriodo.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbPeriodo.TabIndex = 592;
            gbPeriodo.Values.Heading = "Período";
            gbPeriodo.Visible = false;
            // 
            // dtpDataVencimentoInicio
            // 
            dtpDataVencimentoInicio.CornerRoundingRadius = -1F;
            dtpDataVencimentoInicio.Format = DateTimePickerFormat.Short;
            dtpDataVencimentoInicio.Location = new Point(83, 12);
            dtpDataVencimentoInicio.Name = "dtpDataVencimentoInicio";
            dtpDataVencimentoInicio.Size = new Size(97, 21);
            dtpDataVencimentoInicio.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            dtpDataVencimentoInicio.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            dtpDataVencimentoInicio.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpDataVencimentoInicio.TabIndex = 595;
            // 
            // dtpDataVencimentoFim
            // 
            dtpDataVencimentoFim.CornerRoundingRadius = -1F;
            dtpDataVencimentoFim.Format = DateTimePickerFormat.Short;
            dtpDataVencimentoFim.Location = new Point(268, 12);
            dtpDataVencimentoFim.Name = "dtpDataVencimentoFim";
            dtpDataVencimentoFim.Size = new Size(97, 21);
            dtpDataVencimentoFim.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            dtpDataVencimentoFim.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            dtpDataVencimentoFim.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpDataVencimentoFim.TabIndex = 594;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F);
            label2.ForeColor = Color.FromArgb(8, 100, 255);
            label2.Location = new Point(6, 14);
            label2.Name = "label2";
            label2.Size = new Size(77, 17);
            label2.TabIndex = 579;
            label2.Text = "Data Inícial";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F);
            label4.ForeColor = Color.FromArgb(8, 100, 255);
            label4.Location = new Point(194, 14);
            label4.Name = "label4";
            label4.Size = new Size(72, 17);
            label4.TabIndex = 578;
            label4.Text = "Data Final";
            // 
            // gbStatus
            // 
            gbStatus.CaptionStyle = Krypton.Toolkit.LabelStyle.ItalicControl;
            gbStatus.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlAlternate;
            gbStatus.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.ControlCustom1;
            gbStatus.Location = new Point(269, 44);
            gbStatus.Name = "gbStatus";
            // 
            // 
            // 
            gbStatus.Panel.Controls.Add(rbAberto);
            gbStatus.Panel.Controls.Add(rbPago);
            gbStatus.Size = new Size(150, 68);
            gbStatus.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            gbStatus.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            gbStatus.StateCommon.Border.ColorAngle = 45F;
            gbStatus.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.SolidTopLine;
            gbStatus.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            gbStatus.StateCommon.Border.Width = 1;
            gbStatus.TabIndex = 593;
            gbStatus.Values.Heading = "Status";
            gbStatus.Visible = false;
            // 
            // rbAberto
            // 
            rbAberto.AutoSize = true;
            rbAberto.BackColor = Color.White;
            rbAberto.Checked = true;
            rbAberto.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbAberto.ForeColor = Color.FromArgb(8, 100, 255);
            rbAberto.Location = new Point(8, 12);
            rbAberto.Name = "rbAberto";
            rbAberto.Size = new Size(75, 24);
            rbAberto.TabIndex = 584;
            rbAberto.TabStop = true;
            rbAberto.Text = "Aberto";
            rbAberto.UseVisualStyleBackColor = false;
            // 
            // rbPago
            // 
            rbPago.AutoSize = true;
            rbPago.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbPago.ForeColor = Color.FromArgb(8, 100, 255);
            rbPago.Location = new Point(84, 13);
            rbPago.Name = "rbPago";
            rbPago.Size = new Size(64, 24);
            rbPago.TabIndex = 585;
            rbPago.TabStop = true;
            rbPago.Text = "Pago";
            rbPago.UseVisualStyleBackColor = true;
            // 
            // btnFiltro
            // 
            btnFiltro.ButtonStyle = Krypton.Toolkit.ButtonStyle.Cluster;
            btnFiltro.CornerRoundingRadius = -1F;
            btnFiltro.Location = new Point(872, 76);
            btnFiltro.Name = "btnFiltro";
            btnFiltro.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnFiltro.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnFiltro.OverrideDefault.Back.ColorAngle = 45F;
            btnFiltro.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnFiltro.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnFiltro.OverrideDefault.Border.ColorAngle = 45F;
            btnFiltro.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnFiltro.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnFiltro.OverrideDefault.Border.Rounding = 20F;
            btnFiltro.OverrideDefault.Border.Width = 1;
            btnFiltro.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Silver;
            btnFiltro.Size = new Size(91, 35);
            btnFiltro.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnFiltro.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnFiltro.StateCommon.Back.ColorAngle = 45F;
            btnFiltro.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnFiltro.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnFiltro.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnFiltro.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnFiltro.StateCommon.Border.Width = 1;
            btnFiltro.StateCommon.Content.ShortText.Color1 = Color.White;
            btnFiltro.StateCommon.Content.ShortText.Color2 = Color.White;
            btnFiltro.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFiltro.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnFiltro.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnFiltro.StatePressed.Back.ColorAngle = 135F;
            btnFiltro.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnFiltro.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnFiltro.StatePressed.Border.ColorAngle = 135F;
            btnFiltro.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnFiltro.StatePressed.Border.Rounding = 20F;
            btnFiltro.StatePressed.Border.Width = 1;
            btnFiltro.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnFiltro.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnFiltro.StateTracking.Back.ColorAngle = 45F;
            btnFiltro.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnFiltro.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnFiltro.StateTracking.Border.ColorAngle = 45F;
            btnFiltro.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnFiltro.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnFiltro.StateTracking.Border.Rounding = 20F;
            btnFiltro.StateTracking.Border.Width = 1;
            btnFiltro.TabIndex = 594;
            btnFiltro.Values.Text = "&Filtrar";
            btnFiltro.Visible = false;
            btnFiltro.Click += btnFiltro_Click;
            // 
            // kryptonGroupBox1
            // 
            kryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ButtonForm;
            kryptonGroupBox1.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.ButtonAlternate;
            kryptonGroupBox1.Location = new Point(4, 44);
            kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // 
            // 
            kryptonGroupBox1.Panel.Controls.Add(cmbFiltro);
            kryptonGroupBox1.Size = new Size(261, 68);
            kryptonGroupBox1.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            kryptonGroupBox1.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonGroupBox1.StateCommon.Border.ColorAngle = 45F;
            kryptonGroupBox1.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.SolidTopLine;
            kryptonGroupBox1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonGroupBox1.StateCommon.Border.Width = 1;
            kryptonGroupBox1.TabIndex = 595;
            kryptonGroupBox1.Values.Heading = "Filtrar Por";
            // 
            // cmbFiltro
            // 
            cmbFiltro.CornerRoundingRadius = -1F;
            cmbFiltro.DropDownWidth = 244;
            cmbFiltro.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon;
            cmbFiltro.IntegralHeight = false;
            cmbFiltro.Items.AddRange(new object[] { "", "PesquisarPorStatusGeral", "PesquisarPorNomeClienteEStatus", "PesquisarPorPeriodoEStatus", "PesquisarContasVencidas", "PesquisarContasNaoVencidas" });
            cmbFiltro.Location = new Point(6, 13);
            cmbFiltro.Name = "cmbFiltro";
            cmbFiltro.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            cmbFiltro.Size = new Size(248, 18);
            cmbFiltro.TabIndex = 588;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kryptonPanel1.Controls.Add(lblTotalRegistro);
            kryptonPanel1.Controls.Add(kryptonLabel4);
            kryptonPanel1.Controls.Add(lblTotalRecebido);
            kryptonPanel1.Controls.Add(kryptonLabel2);
            kryptonPanel1.Controls.Add(lblTotal);
            kryptonPanel1.Controls.Add(kryptonLabel3);
            kryptonPanel1.Location = new Point(-1, 617);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Black;
            kryptonPanel1.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.HeaderPrimary;
            kryptonPanel1.Size = new Size(974, 43);
            kryptonPanel1.TabIndex = 629;
            // 
            // lblTotalRegistro
            // 
            lblTotalRegistro.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotalRegistro.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel;
            lblTotalRegistro.Location = new Point(14, 5);
            lblTotalRegistro.Name = "lblTotalRegistro";
            lblTotalRegistro.Size = new Size(20, 29);
            lblTotalRegistro.StateCommon.LongText.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalRegistro.StateDisabled.LongText.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalRegistro.StateDisabled.ShortText.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalRegistro.StateNormal.ShortText.Color1 = Color.White;
            lblTotalRegistro.TabIndex = 618;
            lblTotalRegistro.Values.Text = "-";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            kryptonLabel4.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel;
            kryptonLabel4.Location = new Point(47, 5);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(94, 29);
            kryptonLabel4.StateCommon.LongText.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel4.StateDisabled.LongText.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel4.StateDisabled.ShortText.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel4.StateNormal.ShortText.Color1 = Color.White;
            kryptonLabel4.TabIndex = 617;
            kryptonLabel4.Values.Text = "Registros";
            // 
            // lblTotalRecebido
            // 
            lblTotalRecebido.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotalRecebido.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel;
            lblTotalRecebido.Location = new Point(460, 5);
            lblTotalRecebido.Name = "lblTotalRecebido";
            lblTotalRecebido.Size = new Size(20, 29);
            lblTotalRecebido.StateCommon.LongText.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalRecebido.StateDisabled.LongText.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalRecebido.StateDisabled.ShortText.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalRecebido.StateNormal.ShortText.Color1 = Color.White;
            lblTotalRecebido.TabIndex = 616;
            lblTotalRecebido.Values.Text = "-";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            kryptonLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel;
            kryptonLabel2.Location = new Point(348, 5);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(112, 29);
            kryptonLabel2.StateCommon.LongText.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel2.StateDisabled.LongText.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel2.StateDisabled.ShortText.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel2.StateNormal.ShortText.Color1 = Color.White;
            kryptonLabel2.TabIndex = 615;
            kryptonLabel2.Values.Text = "Total pago:";
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotal.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel;
            lblTotal.Location = new Point(847, 5);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(20, 29);
            lblTotal.StateCommon.LongText.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.StateDisabled.LongText.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.StateDisabled.ShortText.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.StateNormal.ShortText.Color1 = Color.White;
            lblTotal.TabIndex = 614;
            lblTotal.Values.Text = "-";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            kryptonLabel3.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel;
            kryptonLabel3.Location = new Point(722, 5);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(125, 29);
            kryptonLabel3.StateCommon.LongText.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel3.StateDisabled.LongText.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel3.StateDisabled.ShortText.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel3.StateNormal.ShortText.Color1 = Color.White;
            kryptonLabel3.TabIndex = 3;
            kryptonLabel3.Values.Text = "Total aberto:";
            // 
            // btnExportarExcel
            // 
            btnExportarExcel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExportarExcel.CornerRoundingRadius = 20F;
            btnExportarExcel.Location = new Point(588, 576);
            btnExportarExcel.Name = "btnExportarExcel";
            btnExportarExcel.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnExportarExcel.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnExportarExcel.OverrideDefault.Back.ColorAngle = 45F;
            btnExportarExcel.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnExportarExcel.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnExportarExcel.OverrideDefault.Border.ColorAngle = 45F;
            btnExportarExcel.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExportarExcel.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnExportarExcel.OverrideDefault.Border.Rounding = 20F;
            btnExportarExcel.OverrideDefault.Border.Width = 1;
            btnExportarExcel.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnExportarExcel.Size = new Size(121, 35);
            btnExportarExcel.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnExportarExcel.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnExportarExcel.StateCommon.Back.ColorAngle = 45F;
            btnExportarExcel.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnExportarExcel.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnExportarExcel.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExportarExcel.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnExportarExcel.StateCommon.Border.Rounding = 20F;
            btnExportarExcel.StateCommon.Border.Width = 1;
            btnExportarExcel.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnExportarExcel.StateCommon.Content.ShortText.Color2 = Color.White;
            btnExportarExcel.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnExportarExcel.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnExportarExcel.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnExportarExcel.StatePressed.Back.ColorAngle = 135F;
            btnExportarExcel.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnExportarExcel.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnExportarExcel.StatePressed.Border.ColorAngle = 135F;
            btnExportarExcel.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExportarExcel.StatePressed.Border.Rounding = 20F;
            btnExportarExcel.StatePressed.Border.Width = 1;
            btnExportarExcel.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnExportarExcel.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnExportarExcel.StateTracking.Back.ColorAngle = 45F;
            btnExportarExcel.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnExportarExcel.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnExportarExcel.StateTracking.Border.ColorAngle = 45F;
            btnExportarExcel.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExportarExcel.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnExportarExcel.StateTracking.Border.Rounding = 20F;
            btnExportarExcel.StateTracking.Border.Width = 1;
            btnExportarExcel.StateTracking.Content.ShortText.Color1 = Color.White;
            btnExportarExcel.TabIndex = 630;
            btnExportarExcel.Values.Text = "&Exportar Excel";
            btnExportarExcel.Click += btnExportarExcel_Click;
            // 
            // dgvItensVenda
            // 
            dgvItensVenda.AllowUserToAddRows = false;
            dgvItensVenda.AllowUserToDeleteRows = false;
            dgvItensVenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensVenda.Location = new Point(12, 303);
            dgvItensVenda.Name = "dgvItensVenda";
            dgvItensVenda.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlueDarkMode;
            dgvItensVenda.ReadOnly = true;
            dgvItensVenda.Size = new Size(945, 197);
            dgvItensVenda.TabIndex = 631;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(label5);
            kryptonPanel2.Location = new Point(12, 271);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue;
            kryptonPanel2.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            kryptonPanel2.Size = new Size(945, 29);
            kryptonPanel2.TabIndex = 632;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 14F);
            label5.ForeColor = Color.FromArgb(8, 100, 255);
            label5.Location = new Point(363, 3);
            label5.Name = "label5";
            label5.Size = new Size(216, 24);
            label5.TabIndex = 596;
            label5.Text = "Ìtens da Venda Produtos";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 18F);
            label6.ForeColor = Color.FromArgb(8, 100, 255);
            label6.Location = new Point(407, 8);
            label6.Name = "label6";
            label6.Size = new Size(123, 29);
            label6.TabIndex = 597;
            label6.Text = "Relatórios";
            // 
            // btnSair
            // 
            btnSair.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSair.CornerRoundingRadius = 20F;
            btnSair.Location = new Point(842, 576);
            btnSair.Name = "btnSair";
            btnSair.OverrideDefault.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnSair.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.OverrideDefault.Back.ColorAngle = 45F;
            btnSair.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnSair.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.OverrideDefault.Border.ColorAngle = 45F;
            btnSair.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSair.OverrideDefault.Border.Rounding = 20F;
            btnSair.OverrideDefault.Border.Width = 1;
            btnSair.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnSair.Size = new Size(121, 35);
            btnSair.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnSair.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnSair.StateCommon.Back.ColorAngle = 45F;
            btnSair.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSair.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSair.StateCommon.Border.Rounding = 20F;
            btnSair.StateCommon.Border.Width = 1;
            btnSair.StateCommon.Content.ShortText.Color1 = Color.White;
            btnSair.StateCommon.Content.ShortText.Color2 = Color.White;
            btnSair.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnSair.StateDisabled.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnSair.StateDisabled.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.StateDisabled.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnSair.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.StateDisabled.Content.ShortText.Color1 = Color.White;
            btnSair.StateNormal.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnSair.StateNormal.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.StateNormal.Content.LongText.Color1 = Color.White;
            btnSair.StateNormal.Content.LongText.Color2 = Color.White;
            btnSair.StateNormal.Content.ShortText.Color1 = Color.White;
            btnSair.StateNormal.Content.ShortText.Color2 = Color.White;
            btnSair.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnSair.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnSair.StatePressed.Back.ColorAngle = 135F;
            btnSair.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnSair.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnSair.StatePressed.Border.ColorAngle = 135F;
            btnSair.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.StatePressed.Border.Rounding = 20F;
            btnSair.StatePressed.Border.Width = 1;
            btnSair.StatePressed.Content.LongText.Color1 = Color.White;
            btnSair.StatePressed.Content.LongText.Color2 = Color.White;
            btnSair.StatePressed.Content.ShortText.Color1 = Color.White;
            btnSair.StatePressed.Content.ShortText.Color2 = Color.White;
            btnSair.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnSair.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnSair.StateTracking.Back.ColorAngle = 45F;
            btnSair.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSair.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.StateTracking.Border.ColorAngle = 45F;
            btnSair.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSair.StateTracking.Border.Rounding = 20F;
            btnSair.StateTracking.Border.Width = 1;
            btnSair.StateTracking.Content.ShortText.Color1 = Color.White;
            btnSair.TabIndex = 633;
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
            // FrmRelatorios
            // 
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(969, 661);
            ControlBox = false;
            Controls.Add(btnSair);
            Controls.Add(label6);
            Controls.Add(kryptonPanel2);
            Controls.Add(dgvItensVenda);
            Controls.Add(btnExportarExcel);
            Controls.Add(kryptonPanel1);
            Controls.Add(kryptonGroupBox1);
            Controls.Add(btnFiltro);
            Controls.Add(gbStatus);
            Controls.Add(gbPeriodo);
            Controls.Add(gbNomeCliente);
            Controls.Add(dgvContasReceber);
            Controls.Add(btnImprimir);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmRelatorios";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Load += FrmRelatorios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvContasReceber).EndInit();
            ((System.ComponentModel.ISupportInitialize)gbNomeCliente.Panel).EndInit();
            gbNomeCliente.Panel.ResumeLayout(false);
            gbNomeCliente.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gbNomeCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)gbPeriodo.Panel).EndInit();
            gbPeriodo.Panel.ResumeLayout(false);
            gbPeriodo.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gbPeriodo).EndInit();
            ((System.ComponentModel.ISupportInitialize)gbStatus.Panel).EndInit();
            gbStatus.Panel.ResumeLayout(false);
            gbStatus.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gbStatus).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonGroupBox1.Panel).EndInit();
            kryptonGroupBox1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonGroupBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbFiltro).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensVenda).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            kryptonPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonButton btnImprimir;
        private Krypton.Toolkit.KryptonDataGridView dgvContasReceber;
        private Krypton.Toolkit.KryptonGroupBox gbNomeCliente;
        public Krypton.Toolkit.KryptonTextBox txtClienteID;
        public Krypton.Toolkit.KryptonTextBox txtNomeCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Krypton.Toolkit.KryptonGroupBox gbPeriodo;
        private Krypton.Toolkit.KryptonDateTimePicker dtpDataVencimentoInicio;
        private Krypton.Toolkit.KryptonDateTimePicker dtpDataVencimentoFim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Krypton.Toolkit.KryptonGroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbAberto;
        private System.Windows.Forms.RadioButton rbPago;
        private Krypton.Toolkit.KryptonButton btnFiltro;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        public Krypton.Toolkit.KryptonComboBox cmbFiltro;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel lblTotal;
        private Krypton.Toolkit.KryptonButton btnExportarExcel;
        private Krypton.Toolkit.KryptonDataGridView dgvItensVenda;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Krypton.Toolkit.KryptonLabel lblTotalRecebido;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonButton btnSair;
        private Krypton.Toolkit.KryptonLabel lblTotalRegistro;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonButton btnLocalizarCliente;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
    }
}
