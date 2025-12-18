namespace GVC.View
{
    partial class FrmBackup
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
            lblRotulo = new Label();
            txtCaminhoBackup = new Krypton.Toolkit.KryptonTextBox();
            btnSair = new Krypton.Toolkit.KryptonButton();
            btnLocalBackup = new Krypton.Toolkit.KryptonButton();
            btnExecutar = new Krypton.Toolkit.KryptonButton();
            kryptonGroupBox1 = new Krypton.Toolkit.KryptonGroupBox();
            rbtGerarBackup = new Krypton.Toolkit.KryptonRadioButton();
            rbtRestaurarBackup = new Krypton.Toolkit.KryptonRadioButton();
            kryptonStatusStrip1 = new Krypton.Toolkit.KryptonStatusStrip();
            lblMensagem = new ToolStripStatusLabel();
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            ((System.ComponentModel.ISupportInitialize)kryptonGroupBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonGroupBox1.Panel).BeginInit();
            kryptonStatusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblRotulo
            // 
            lblRotulo.AutoSize = true;
            lblRotulo.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotulo.Location = new Point(12, 73);
            lblRotulo.Name = "lblRotulo";
            lblRotulo.Size = new Size(56, 15);
            lblRotulo.TabIndex = 1013;
            lblRotulo.Text = "Caminho";
            // 
            // txtCaminhoBackup
            // 
            txtCaminhoBackup.Location = new Point(12, 91);
            txtCaminhoBackup.Name = "txtCaminhoBackup";
            txtCaminhoBackup.Size = new Size(316, 22);
            txtCaminhoBackup.StateCommon.Back.Color1 = Color.White;
            txtCaminhoBackup.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtCaminhoBackup.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtCaminhoBackup.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtCaminhoBackup.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtCaminhoBackup.StateCommon.Border.Rounding = 6F;
            txtCaminhoBackup.StateCommon.Border.Width = 1;
            txtCaminhoBackup.StateCommon.Content.Color1 = Color.Gray;
            txtCaminhoBackup.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtCaminhoBackup.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtCaminhoBackup.TabIndex = 1012;
            // 
            // btnSair
            // 
            btnSair.CornerRoundingRadius = 10F;
            btnSair.Location = new Point(275, 125);
            btnSair.Name = "btnSair";
            btnSair.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnSair.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnSair.OverrideDefault.Back.ColorAngle = 45F;
            btnSair.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnSair.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.OverrideDefault.Border.ColorAngle = 45F;
            btnSair.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSair.OverrideDefault.Border.Rounding = 20F;
            btnSair.OverrideDefault.Border.Width = 1;
            btnSair.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnSair.Size = new Size(83, 30);
            btnSair.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnSair.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnSair.StateCommon.Back.ColorAngle = 45F;
            btnSair.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSair.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSair.StateCommon.Border.Rounding = 10F;
            btnSair.StateCommon.Border.Width = 1;
            btnSair.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnSair.StateCommon.Content.ShortText.Color2 = Color.White;
            btnSair.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 11F);
            btnSair.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnSair.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnSair.StatePressed.Back.ColorAngle = 135F;
            btnSair.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnSair.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnSair.StatePressed.Border.ColorAngle = 135F;
            btnSair.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.StatePressed.Border.Rounding = 20F;
            btnSair.StatePressed.Border.Width = 1;
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
            btnSair.TabIndex = 1015;
            btnSair.Values.Text = "&Sair";
            btnSair.Click += btnSair_Click;
            // 
            // btnLocalBackup
            // 
            btnLocalBackup.CornerRoundingRadius = 6F;
            btnLocalBackup.Location = new Point(332, 89);
            btnLocalBackup.Name = "btnLocalBackup";
            btnLocalBackup.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnLocalBackup.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnLocalBackup.OverrideDefault.Back.ColorAngle = 45F;
            btnLocalBackup.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnLocalBackup.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLocalBackup.OverrideDefault.Border.ColorAngle = 45F;
            btnLocalBackup.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLocalBackup.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLocalBackup.OverrideDefault.Border.Rounding = 20F;
            btnLocalBackup.OverrideDefault.Border.Width = 1;
            btnLocalBackup.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnLocalBackup.Size = new Size(26, 28);
            btnLocalBackup.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnLocalBackup.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnLocalBackup.StateCommon.Back.ColorAngle = 45F;
            btnLocalBackup.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnLocalBackup.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLocalBackup.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLocalBackup.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLocalBackup.StateCommon.Border.Rounding = 6F;
            btnLocalBackup.StateCommon.Border.Width = 1;
            btnLocalBackup.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnLocalBackup.StateCommon.Content.ShortText.Color2 = Color.White;
            btnLocalBackup.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLocalBackup.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnLocalBackup.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnLocalBackup.StatePressed.Back.ColorAngle = 135F;
            btnLocalBackup.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnLocalBackup.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnLocalBackup.StatePressed.Border.ColorAngle = 135F;
            btnLocalBackup.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLocalBackup.StatePressed.Border.Rounding = 20F;
            btnLocalBackup.StatePressed.Border.Width = 1;
            btnLocalBackup.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnLocalBackup.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnLocalBackup.StateTracking.Back.ColorAngle = 45F;
            btnLocalBackup.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnLocalBackup.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLocalBackup.StateTracking.Border.ColorAngle = 45F;
            btnLocalBackup.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLocalBackup.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLocalBackup.StateTracking.Border.Rounding = 20F;
            btnLocalBackup.StateTracking.Border.Width = 1;
            btnLocalBackup.StateTracking.Content.ShortText.Color1 = Color.White;
            btnLocalBackup.TabIndex = 1016;
            btnLocalBackup.Values.Image = Properties.Resources.pasta;
            btnLocalBackup.Values.Text = "";
            btnLocalBackup.Click += btnLocalBackup_Click;
            // 
            // btnExecutar
            // 
            btnExecutar.CornerRoundingRadius = 10F;
            btnExecutar.Location = new Point(119, 125);
            btnExecutar.Name = "btnExecutar";
            btnExecutar.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnExecutar.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnExecutar.OverrideDefault.Back.ColorAngle = 45F;
            btnExecutar.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnExecutar.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnExecutar.OverrideDefault.Border.ColorAngle = 45F;
            btnExecutar.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExecutar.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnExecutar.OverrideDefault.Border.Rounding = 20F;
            btnExecutar.OverrideDefault.Border.Width = 1;
            btnExecutar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnExecutar.Size = new Size(150, 30);
            btnExecutar.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnExecutar.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnExecutar.StateCommon.Back.ColorAngle = 45F;
            btnExecutar.StateCommon.Border.Color1 = Color.LightGray;
            btnExecutar.StateCommon.Border.Color2 = Color.DarkGray;
            btnExecutar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExecutar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnExecutar.StateCommon.Border.Rounding = 10F;
            btnExecutar.StateCommon.Border.Width = 1;
            btnExecutar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnExecutar.StateCommon.Content.ShortText.Color2 = Color.White;
            btnExecutar.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExecutar.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnExecutar.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnExecutar.StatePressed.Back.ColorAngle = 135F;
            btnExecutar.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnExecutar.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnExecutar.StatePressed.Border.ColorAngle = 135F;
            btnExecutar.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExecutar.StatePressed.Border.Rounding = 20F;
            btnExecutar.StatePressed.Border.Width = 1;
            btnExecutar.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnExecutar.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnExecutar.StateTracking.Back.ColorAngle = 45F;
            btnExecutar.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnExecutar.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnExecutar.StateTracking.Border.ColorAngle = 45F;
            btnExecutar.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExecutar.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnExecutar.StateTracking.Border.Rounding = 20F;
            btnExecutar.StateTracking.Border.Width = 1;
            btnExecutar.TabIndex = 1017;
            btnExecutar.Values.Text = "Iniciar";
            btnExecutar.Click += btnExecutar_Click;
            // 
            // kryptonGroupBox1
            // 
            kryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.InputControlStandalone;
            kryptonGroupBox1.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.ControlRibbon;
            kryptonGroupBox1.Location = new Point(12, 10);
            kryptonGroupBox1.Name = "kryptonGroupBox1";
            kryptonGroupBox1.Size = new Size(145, 47);
            kryptonGroupBox1.TabIndex = 1022;
            kryptonGroupBox1.Values.Heading = "Backup";
            // 
            // rbtGerarBackup
            // 
            rbtGerarBackup.Location = new Point(21, 29);
            rbtGerarBackup.Name = "rbtGerarBackup";
            rbtGerarBackup.Size = new Size(52, 20);
            rbtGerarBackup.TabIndex = 1028;
            rbtGerarBackup.Values.Text = "Gerar";
            rbtGerarBackup.CheckedChanged += rbtGerarBackup_CheckedChanged;
            // 
            // rbtRestaurarBackup
            // 
            rbtRestaurarBackup.Location = new Point(77, 29);
            rbtRestaurarBackup.Name = "rbtRestaurarBackup";
            rbtRestaurarBackup.Size = new Size(74, 20);
            rbtRestaurarBackup.TabIndex = 1029;
            rbtRestaurarBackup.Values.Text = "Restaurar";
            rbtRestaurarBackup.CheckedChanged += rbtRestaurarBackup_CheckedChanged;
            // 
            // kryptonStatusStrip1
            // 
            kryptonStatusStrip1.Font = new Font("Segoe UI", 9F);
            kryptonStatusStrip1.Items.AddRange(new ToolStripItem[] { lblMensagem });
            kryptonStatusStrip1.Location = new Point(0, 179);
            kryptonStatusStrip1.Name = "kryptonStatusStrip1";
            kryptonStatusStrip1.ProgressBars = null;
            kryptonStatusStrip1.RenderMode = ToolStripRenderMode.ManagerRenderMode;
            kryptonStatusStrip1.Size = new Size(375, 22);
            kryptonStatusStrip1.TabIndex = 1030;
            kryptonStatusStrip1.Text = "kryptonStatusStrip1";
            // 
            // lblMensagem
            // 
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(39, 17);
            lblMensagem.Text = "Status";
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
            // FrmBackup
            // 
            BackColor = Color.FromArgb(250, 252, 252);
            ClientSize = new Size(375, 201);
            Controls.Add(kryptonStatusStrip1);
            Controls.Add(rbtRestaurarBackup);
            Controls.Add(rbtGerarBackup);
            Controls.Add(kryptonGroupBox1);
            Controls.Add(btnExecutar);
            Controls.Add(btnLocalBackup);
            Controls.Add(btnSair);
            Controls.Add(lblRotulo);
            Controls.Add(txtCaminhoBackup);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmBackup";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Text = "Backup e Restauração";
            ((System.ComponentModel.ISupportInitialize)kryptonGroupBox1.Panel).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonGroupBox1).EndInit();
            kryptonStatusStrip1.ResumeLayout(false);
            kryptonStatusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRotulo;
        public Krypton.Toolkit.KryptonTextBox txtCaminhoBackup;
        private Krypton.Toolkit.KryptonButton btnSair;
        private Krypton.Toolkit.KryptonButton btnLocalBackup;
        private Krypton.Toolkit.KryptonButton btnExecutar;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private Krypton.Toolkit.KryptonRadioButton rbtGerarBackup;
        private Krypton.Toolkit.KryptonRadioButton rbtRestaurarBackup;
        private Krypton.Toolkit.KryptonStatusStrip kryptonStatusStrip1;
        private ToolStripStatusLabel lblMensagem;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
    }
}
