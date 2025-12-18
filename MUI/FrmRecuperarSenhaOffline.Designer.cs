namespace GVC.MUI
{
    partial class FrmRecuperarSenhaOffline
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
            btnGerarToken = new Krypton.Toolkit.KryptonButton();
            btnCancelar = new Krypton.Toolkit.KryptonButton();
            panelCpf = new Panel();
            panelDataNascimento = new Panel();
            label1 = new Label();
            pictureBoxDataNasc = new PictureBox();
            pictureBoxCpf = new PictureBox();
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            label2 = new Label();
            label3 = new Label();
            txtDataNascimento = new Krypton.Toolkit.KryptonTextBox();
            txtCpf = new Krypton.Toolkit.KryptonTextBox();
            txtConfirmarSenha = new Krypton.Toolkit.KryptonTextBox();
            label10 = new Label();
            txtNovaSenha = new Krypton.Toolkit.KryptonTextBox();
            label9 = new Label();
            txtTokens = new Krypton.Toolkit.KryptonTextBox();
            btnRedefinirPass = new Krypton.Toolkit.KryptonButton();
            lblTokenInfo = new Label();
            btnCancel = new Krypton.Toolkit.KryptonButton();
            label8 = new Label();
            label7 = new Label();
            btnRedefinirSenha = new Krypton.Toolkit.KryptonButton();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            painelRecuperacao = new Panel();
            painelRedefinir = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDataNasc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCpf).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            painelRecuperacao.SuspendLayout();
            painelRedefinir.SuspendLayout();
            SuspendLayout();
            // 
            // btnGerarToken
            // 
            btnGerarToken.CornerRoundingRadius = 20F;
            btnGerarToken.Location = new Point(140, 256);
            btnGerarToken.Name = "btnGerarToken";
            btnGerarToken.OverrideDefault.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnGerarToken.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnGerarToken.OverrideDefault.Back.ColorAngle = 45F;
            btnGerarToken.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnGerarToken.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnGerarToken.OverrideDefault.Border.ColorAngle = 45F;
            btnGerarToken.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnGerarToken.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnGerarToken.OverrideDefault.Border.Rounding = 20F;
            btnGerarToken.OverrideDefault.Border.Width = 1;
            btnGerarToken.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            btnGerarToken.Size = new Size(117, 30);
            btnGerarToken.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnGerarToken.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnGerarToken.StateCommon.Back.ColorAngle = 45F;
            btnGerarToken.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnGerarToken.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnGerarToken.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnGerarToken.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnGerarToken.StateCommon.Border.Rounding = 20F;
            btnGerarToken.StateCommon.Border.Width = 1;
            btnGerarToken.StateCommon.Content.ShortText.Color1 = Color.White;
            btnGerarToken.StateCommon.Content.ShortText.Color2 = Color.White;
            btnGerarToken.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGerarToken.StateDisabled.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnGerarToken.StateDisabled.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnGerarToken.StateDisabled.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnGerarToken.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnGerarToken.StateDisabled.Content.ShortText.Color1 = Color.White;
            btnGerarToken.StateNormal.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnGerarToken.StateNormal.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnGerarToken.StateNormal.Content.LongText.Color1 = Color.White;
            btnGerarToken.StateNormal.Content.LongText.Color2 = Color.White;
            btnGerarToken.StateNormal.Content.ShortText.Color1 = Color.White;
            btnGerarToken.StateNormal.Content.ShortText.Color2 = Color.White;
            btnGerarToken.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnGerarToken.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnGerarToken.StatePressed.Back.ColorAngle = 135F;
            btnGerarToken.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnGerarToken.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnGerarToken.StatePressed.Border.ColorAngle = 135F;
            btnGerarToken.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnGerarToken.StatePressed.Border.Rounding = 20F;
            btnGerarToken.StatePressed.Border.Width = 1;
            btnGerarToken.StatePressed.Content.LongText.Color1 = Color.White;
            btnGerarToken.StatePressed.Content.LongText.Color2 = Color.White;
            btnGerarToken.StatePressed.Content.ShortText.Color1 = Color.White;
            btnGerarToken.StatePressed.Content.ShortText.Color2 = Color.White;
            btnGerarToken.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnGerarToken.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnGerarToken.StateTracking.Back.ColorAngle = 45F;
            btnGerarToken.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnGerarToken.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnGerarToken.StateTracking.Border.ColorAngle = 45F;
            btnGerarToken.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnGerarToken.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnGerarToken.StateTracking.Border.Rounding = 20F;
            btnGerarToken.StateTracking.Border.Width = 1;
            btnGerarToken.StateTracking.Content.ShortText.Color1 = Color.White;
            btnGerarToken.TabIndex = 2;
            btnGerarToken.Values.Text = "&Gerar Token";
            btnGerarToken.Click += btnRecuperarSenha_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.CornerRoundingRadius = 20F;
            btnCancelar.Location = new Point(131, 256);
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
            btnCancelar.StateCommon.Border.Rounding = 20F;
            btnCancelar.StateCommon.Border.Width = 1;
            btnCancelar.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnCancelar.StateCommon.Content.ShortText.Color2 = Color.White;
            btnCancelar.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnCancelar.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnCancelar.StatePressed.Back.ColorAngle = 135F;
            btnCancelar.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnCancelar.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnCancelar.StatePressed.Border.ColorAngle = 135F;
            btnCancelar.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelar.StatePressed.Border.Rounding = 20F;
            btnCancelar.StatePressed.Border.Width = 1;
            btnCancelar.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnCancelar.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnCancelar.StateTracking.Back.ColorAngle = 45F;
            btnCancelar.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnCancelar.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnCancelar.StateTracking.Border.ColorAngle = 45F;
            btnCancelar.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelar.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancelar.StateTracking.Border.Rounding = 20F;
            btnCancelar.StateTracking.Border.Width = 1;
            btnCancelar.StateTracking.Content.ShortText.Color1 = Color.White;
            btnCancelar.TabIndex = 3;
            btnCancelar.TabStop = false;
            btnCancelar.Values.Text = "&Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // panelCpf
            // 
            panelCpf.BackColor = Color.White;
            panelCpf.Location = new Point(7, 75);
            panelCpf.Name = "panelCpf";
            panelCpf.Size = new Size(250, 3);
            panelCpf.TabIndex = 23;
            // 
            // panelDataNascimento
            // 
            panelDataNascimento.BackColor = Color.White;
            panelDataNascimento.Location = new Point(7, 153);
            panelDataNascimento.Name = "panelDataNascimento";
            panelDataNascimento.Size = new Size(250, 3);
            panelDataNascimento.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.25F);
            label1.ForeColor = Color.FromArgb(8, 142, 254);
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(136, 17);
            label1.TabIndex = 25;
            label1.Text = "Painal Recuperação";
            // 
            // pictureBoxDataNasc
            // 
            pictureBoxDataNasc.Image = Properties.Resources.calendarioBranco24;
            pictureBoxDataNasc.Location = new Point(7, 119);
            pictureBoxDataNasc.Name = "pictureBoxDataNasc";
            pictureBoxDataNasc.Size = new Size(20, 25);
            pictureBoxDataNasc.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxDataNasc.TabIndex = 24;
            pictureBoxDataNasc.TabStop = false;
            // 
            // pictureBoxCpf
            // 
            pictureBoxCpf.Image = Properties.Resources.cpfBranco24;
            pictureBoxCpf.Location = new Point(9, 45);
            pictureBoxCpf.Name = "pictureBoxCpf";
            pictureBoxCpf.Size = new Size(20, 25);
            pictureBoxCpf.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCpf.TabIndex = 19;
            pictureBoxCpf.TabStop = false;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.25F);
            label2.ForeColor = Color.FromArgb(8, 142, 254);
            label2.Location = new Point(36, 25);
            label2.Name = "label2";
            label2.Size = new Size(27, 16);
            label2.TabIndex = 1014;
            label2.Text = "Cpf";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.25F);
            label3.ForeColor = Color.FromArgb(8, 142, 254);
            label3.Location = new Point(36, 103);
            label3.Name = "label3";
            label3.Size = new Size(108, 16);
            label3.TabIndex = 1015;
            label3.Text = "DataNascimento";
            // 
            // txtDataNascimento
            // 
            txtDataNascimento.CharacterCasing = CharacterCasing.Lower;
            txtDataNascimento.Location = new Point(33, 121);
            txtDataNascimento.MaxLength = 100;
            txtDataNascimento.Name = "txtDataNascimento";
            txtDataNascimento.Size = new Size(224, 27);
            txtDataNascimento.StateCommon.Back.Color1 = Color.White;
            txtDataNascimento.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtDataNascimento.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtDataNascimento.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtDataNascimento.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtDataNascimento.StateCommon.Border.Rounding = 8F;
            txtDataNascimento.StateCommon.Border.Width = 1;
            txtDataNascimento.StateCommon.Content.Color1 = Color.Gray;
            txtDataNascimento.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtDataNascimento.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtDataNascimento.TabIndex = 1;
            txtDataNascimento.TextChanged += txtDataNascimento_TextChanged;
            txtDataNascimento.Enter += txtDataNascimento_Enter;
            txtDataNascimento.Leave += txtDataNascimento_Leave;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(33, 44);
            txtCpf.MaxLength = 14;
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(224, 27);
            txtCpf.StateCommon.Back.Color1 = Color.White;
            txtCpf.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtCpf.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtCpf.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtCpf.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtCpf.StateCommon.Border.Rounding = 8F;
            txtCpf.StateCommon.Border.Width = 1;
            txtCpf.StateCommon.Content.Color1 = Color.Gray;
            txtCpf.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtCpf.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtCpf.TabIndex = 0;
            txtCpf.TextChanged += txtCpf_TextChanged;
            txtCpf.Enter += txtCpf_Enter;
            txtCpf.Leave += txtCpf_Leave;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Location = new Point(11, 165);
            txtConfirmarSenha.MaxLength = 14;
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.Size = new Size(249, 27);
            txtConfirmarSenha.StateCommon.Back.Color1 = Color.White;
            txtConfirmarSenha.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtConfirmarSenha.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtConfirmarSenha.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtConfirmarSenha.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtConfirmarSenha.StateCommon.Border.Rounding = 8F;
            txtConfirmarSenha.StateCommon.Border.Width = 1;
            txtConfirmarSenha.StateCommon.Content.Color1 = Color.Gray;
            txtConfirmarSenha.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtConfirmarSenha.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtConfirmarSenha.TabIndex = 1;
            txtConfirmarSenha.Enter += txtConfirmarSenha_Enter;
            txtConfirmarSenha.Leave += txtConfirmarSenha_Leave;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9.25F);
            label10.ForeColor = Color.FromArgb(8, 142, 254);
            label10.Location = new Point(14, 146);
            label10.Name = "label10";
            label10.Size = new Size(102, 16);
            label10.TabIndex = 1022;
            label10.Text = "Confirma Senha";
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Location = new Point(11, 103);
            txtNovaSenha.MaxLength = 14;
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.Size = new Size(249, 27);
            txtNovaSenha.StateCommon.Back.Color1 = Color.White;
            txtNovaSenha.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtNovaSenha.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtNovaSenha.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtNovaSenha.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtNovaSenha.StateCommon.Border.Rounding = 8F;
            txtNovaSenha.StateCommon.Border.Width = 1;
            txtNovaSenha.StateCommon.Content.Color1 = Color.Gray;
            txtNovaSenha.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtNovaSenha.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtNovaSenha.TabIndex = 0;
            txtNovaSenha.Enter += txtNovaSenha_Enter;
            txtNovaSenha.Leave += txtNovaSenha_Leave;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9.25F);
            label9.ForeColor = Color.FromArgb(8, 142, 254);
            label9.Location = new Point(14, 84);
            label9.Name = "label9";
            label9.Size = new Size(82, 16);
            label9.TabIndex = 1020;
            label9.Text = "Nova Senha";
            // 
            // txtTokens
            // 
            txtTokens.Location = new Point(8, 43);
            txtTokens.MaxLength = 14;
            txtTokens.Name = "txtTokens";
            txtTokens.Size = new Size(252, 27);
            txtTokens.StateCommon.Back.Color1 = Color.White;
            txtTokens.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtTokens.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtTokens.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtTokens.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtTokens.StateCommon.Border.Rounding = 8F;
            txtTokens.StateCommon.Border.Width = 1;
            txtTokens.StateCommon.Content.Color1 = Color.Gray;
            txtTokens.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtTokens.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtTokens.TabIndex = 1015;
            txtTokens.TabStop = false;
            // 
            // btnRedefinirPass
            // 
            btnRedefinirPass.CornerRoundingRadius = 20F;
            btnRedefinirPass.Location = new Point(8, 256);
            btnRedefinirPass.Name = "btnRedefinirPass";
            btnRedefinirPass.OverrideDefault.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnRedefinirPass.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnRedefinirPass.OverrideDefault.Back.ColorAngle = 45F;
            btnRedefinirPass.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnRedefinirPass.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnRedefinirPass.OverrideDefault.Border.ColorAngle = 45F;
            btnRedefinirPass.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnRedefinirPass.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnRedefinirPass.OverrideDefault.Border.Rounding = 20F;
            btnRedefinirPass.OverrideDefault.Border.Width = 1;
            btnRedefinirPass.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnRedefinirPass.Size = new Size(120, 30);
            btnRedefinirPass.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnRedefinirPass.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnRedefinirPass.StateCommon.Back.ColorAngle = 45F;
            btnRedefinirPass.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnRedefinirPass.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnRedefinirPass.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnRedefinirPass.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnRedefinirPass.StateCommon.Border.Rounding = 20F;
            btnRedefinirPass.StateCommon.Border.Width = 1;
            btnRedefinirPass.StateCommon.Content.ShortText.Color1 = Color.White;
            btnRedefinirPass.StateCommon.Content.ShortText.Color2 = Color.White;
            btnRedefinirPass.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRedefinirPass.StateDisabled.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnRedefinirPass.StateDisabled.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnRedefinirPass.StateDisabled.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnRedefinirPass.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnRedefinirPass.StateDisabled.Content.ShortText.Color1 = Color.White;
            btnRedefinirPass.StateNormal.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnRedefinirPass.StateNormal.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnRedefinirPass.StateNormal.Content.LongText.Color1 = Color.White;
            btnRedefinirPass.StateNormal.Content.LongText.Color2 = Color.White;
            btnRedefinirPass.StateNormal.Content.ShortText.Color1 = Color.White;
            btnRedefinirPass.StateNormal.Content.ShortText.Color2 = Color.White;
            btnRedefinirPass.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnRedefinirPass.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnRedefinirPass.StatePressed.Back.ColorAngle = 135F;
            btnRedefinirPass.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnRedefinirPass.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnRedefinirPass.StatePressed.Border.ColorAngle = 135F;
            btnRedefinirPass.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnRedefinirPass.StatePressed.Border.Rounding = 20F;
            btnRedefinirPass.StatePressed.Border.Width = 1;
            btnRedefinirPass.StatePressed.Content.LongText.Color1 = Color.White;
            btnRedefinirPass.StatePressed.Content.LongText.Color2 = Color.White;
            btnRedefinirPass.StatePressed.Content.ShortText.Color1 = Color.White;
            btnRedefinirPass.StatePressed.Content.ShortText.Color2 = Color.White;
            btnRedefinirPass.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnRedefinirPass.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnRedefinirPass.StateTracking.Back.ColorAngle = 45F;
            btnRedefinirPass.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnRedefinirPass.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnRedefinirPass.StateTracking.Border.ColorAngle = 45F;
            btnRedefinirPass.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnRedefinirPass.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnRedefinirPass.StateTracking.Border.Rounding = 20F;
            btnRedefinirPass.StateTracking.Border.Width = 1;
            btnRedefinirPass.StateTracking.Content.ShortText.Color1 = Color.White;
            btnRedefinirPass.TabIndex = 2;
            btnRedefinirPass.Values.Text = "Redefinir";
            btnRedefinirPass.Click += btnRedefinirPass_Click;
            // 
            // lblTokenInfo
            // 
            lblTokenInfo.AutoSize = true;
            lblTokenInfo.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblTokenInfo.ForeColor = Color.FromArgb(8, 142, 254);
            lblTokenInfo.Location = new Point(11, 24);
            lblTokenInfo.Name = "lblTokenInfo";
            lblTokenInfo.Size = new Size(46, 16);
            lblTokenInfo.TabIndex = 1018;
            lblTokenInfo.Text = "Token";
            // 
            // btnCancel
            // 
            btnCancel.CornerRoundingRadius = 20F;
            btnCancel.Location = new Point(186, 286);
            btnCancel.Name = "btnCancel";
            btnCancel.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnCancel.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnCancel.OverrideDefault.Back.ColorAngle = 45F;
            btnCancel.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnCancel.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnCancel.OverrideDefault.Border.ColorAngle = 45F;
            btnCancel.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancel.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancel.OverrideDefault.Border.Rounding = 20F;
            btnCancel.OverrideDefault.Border.Width = 1;
            btnCancel.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnCancel.Size = new Size(120, 30);
            btnCancel.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnCancel.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnCancel.StateCommon.Back.ColorAngle = 45F;
            btnCancel.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnCancel.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnCancel.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancel.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancel.StateCommon.Border.Rounding = 20F;
            btnCancel.StateCommon.Border.Width = 1;
            btnCancel.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnCancel.StateCommon.Content.ShortText.Color2 = Color.White;
            btnCancel.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnCancel.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnCancel.StatePressed.Back.ColorAngle = 135F;
            btnCancel.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnCancel.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnCancel.StatePressed.Border.ColorAngle = 135F;
            btnCancel.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancel.StatePressed.Border.Rounding = 20F;
            btnCancel.StatePressed.Border.Width = 1;
            btnCancel.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnCancel.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnCancel.StateTracking.Back.ColorAngle = 45F;
            btnCancel.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnCancel.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnCancel.StateTracking.Border.ColorAngle = 45F;
            btnCancel.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancel.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancel.StateTracking.Border.Rounding = 20F;
            btnCancel.StateTracking.Border.Width = 1;
            btnCancel.StateTracking.Content.ShortText.Color1 = Color.White;
            btnCancel.TabIndex = 1031;
            btnCancel.TabStop = false;
            btnCancel.Values.Text = "&Cancelar";
            btnCancel.Click += btnCancel_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9.25F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(20, 211);
            label8.Name = "label8";
            label8.Size = new Size(142, 16);
            label8.TabIndex = 1030;
            label8.Text = "Confirmar Nova Senha";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.25F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(20, 161);
            label7.Name = "label7";
            label7.Size = new Size(82, 16);
            label7.TabIndex = 1028;
            label7.Text = "Nova Senha";
            // 
            // btnRedefinirSenha
            // 
            btnRedefinirSenha.CornerRoundingRadius = 20F;
            btnRedefinirSenha.Location = new Point(20, 286);
            btnRedefinirSenha.Name = "btnRedefinirSenha";
            btnRedefinirSenha.OverrideDefault.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnRedefinirSenha.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnRedefinirSenha.OverrideDefault.Back.ColorAngle = 45F;
            btnRedefinirSenha.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnRedefinirSenha.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnRedefinirSenha.OverrideDefault.Border.ColorAngle = 45F;
            btnRedefinirSenha.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnRedefinirSenha.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnRedefinirSenha.OverrideDefault.Border.Rounding = 20F;
            btnRedefinirSenha.OverrideDefault.Border.Width = 1;
            btnRedefinirSenha.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnRedefinirSenha.Size = new Size(120, 30);
            btnRedefinirSenha.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnRedefinirSenha.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnRedefinirSenha.StateCommon.Back.ColorAngle = 45F;
            btnRedefinirSenha.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnRedefinirSenha.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnRedefinirSenha.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnRedefinirSenha.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnRedefinirSenha.StateCommon.Border.Rounding = 20F;
            btnRedefinirSenha.StateCommon.Border.Width = 1;
            btnRedefinirSenha.StateCommon.Content.ShortText.Color1 = Color.White;
            btnRedefinirSenha.StateCommon.Content.ShortText.Color2 = Color.White;
            btnRedefinirSenha.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRedefinirSenha.StateDisabled.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnRedefinirSenha.StateDisabled.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnRedefinirSenha.StateDisabled.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnRedefinirSenha.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnRedefinirSenha.StateDisabled.Content.ShortText.Color1 = Color.White;
            btnRedefinirSenha.StateNormal.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnRedefinirSenha.StateNormal.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnRedefinirSenha.StateNormal.Content.LongText.Color1 = Color.White;
            btnRedefinirSenha.StateNormal.Content.LongText.Color2 = Color.White;
            btnRedefinirSenha.StateNormal.Content.ShortText.Color1 = Color.White;
            btnRedefinirSenha.StateNormal.Content.ShortText.Color2 = Color.White;
            btnRedefinirSenha.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnRedefinirSenha.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnRedefinirSenha.StatePressed.Back.ColorAngle = 135F;
            btnRedefinirSenha.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnRedefinirSenha.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnRedefinirSenha.StatePressed.Border.ColorAngle = 135F;
            btnRedefinirSenha.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnRedefinirSenha.StatePressed.Border.Rounding = 20F;
            btnRedefinirSenha.StatePressed.Border.Width = 1;
            btnRedefinirSenha.StatePressed.Content.LongText.Color1 = Color.White;
            btnRedefinirSenha.StatePressed.Content.LongText.Color2 = Color.White;
            btnRedefinirSenha.StatePressed.Content.ShortText.Color1 = Color.White;
            btnRedefinirSenha.StatePressed.Content.ShortText.Color2 = Color.White;
            btnRedefinirSenha.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnRedefinirSenha.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnRedefinirSenha.StateTracking.Back.ColorAngle = 45F;
            btnRedefinirSenha.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnRedefinirSenha.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnRedefinirSenha.StateTracking.Border.ColorAngle = 45F;
            btnRedefinirSenha.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnRedefinirSenha.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnRedefinirSenha.StateTracking.Border.Rounding = 20F;
            btnRedefinirSenha.StateTracking.Border.Width = 1;
            btnRedefinirSenha.StateTracking.Content.ShortText.Color1 = Color.White;
            btnRedefinirSenha.TabIndex = 1018;
            btnRedefinirSenha.Values.Text = "&Confirmar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.25F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(20, 110);
            label6.Name = "label6";
            label6.Size = new Size(46, 16);
            label6.TabIndex = 1025;
            label6.Text = "Token";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.redefinir_senha;
            pictureBox1.Location = new Point(129, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1032;
            pictureBox1.TabStop = false;
            // 
            // painelRecuperacao
            // 
            painelRecuperacao.Controls.Add(label1);
            painelRecuperacao.Controls.Add(btnGerarToken);
            painelRecuperacao.Controls.Add(label2);
            painelRecuperacao.Controls.Add(label3);
            painelRecuperacao.Controls.Add(pictureBoxCpf);
            painelRecuperacao.Controls.Add(panelDataNascimento);
            painelRecuperacao.Controls.Add(txtCpf);
            painelRecuperacao.Controls.Add(txtDataNascimento);
            painelRecuperacao.Controls.Add(pictureBoxDataNasc);
            painelRecuperacao.Controls.Add(panelCpf);
            painelRecuperacao.Dock = DockStyle.Fill;
            painelRecuperacao.Location = new Point(0, 0);
            painelRecuperacao.Name = "painelRecuperacao";
            painelRecuperacao.Size = new Size(276, 319);
            painelRecuperacao.TabIndex = 1023;
            // 
            // painelRedefinir
            // 
            painelRedefinir.Controls.Add(txtTokens);
            painelRedefinir.Controls.Add(lblTokenInfo);
            painelRedefinir.Controls.Add(btnRedefinirPass);
            painelRedefinir.Controls.Add(txtConfirmarSenha);
            painelRedefinir.Controls.Add(btnCancelar);
            painelRedefinir.Controls.Add(label10);
            painelRedefinir.Controls.Add(txtNovaSenha);
            painelRedefinir.Controls.Add(label9);
            painelRedefinir.Dock = DockStyle.Fill;
            painelRedefinir.Location = new Point(0, 0);
            painelRedefinir.Name = "painelRedefinir";
            painelRedefinir.Size = new Size(276, 319);
            painelRedefinir.TabIndex = 1024;
            // 
            // FrmRecuperarSenhaOffline
            // 
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(276, 319);
            Controls.Add(painelRecuperacao);
            Controls.Add(painelRedefinir);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmRecuperarSenhaOffline";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Load += FrmRecuperarSenhaOffline_Load;
            KeyDown += FrmRecuperarSenhaOffline_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBoxDataNasc).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCpf).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            painelRecuperacao.ResumeLayout(false);
            painelRecuperacao.PerformLayout();
            painelRedefinir.ResumeLayout(false);
            painelRedefinir.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private Krypton.Toolkit.KryptonButton btnGerarToken;
        private Krypton.Toolkit.KryptonButton btnCancelar;
        private System.Windows.Forms.PictureBox pictureBoxCpf;
        private System.Windows.Forms.Panel panelCpf;
        private System.Windows.Forms.Panel panelDataNascimento;
        private System.Windows.Forms.PictureBox pictureBoxDataNasc;
        private System.Windows.Forms.Label label1;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Label label2;
        private Label label3;
        public Krypton.Toolkit.KryptonTextBox txtDataNascimento;
        public Krypton.Toolkit.KryptonTextBox txtCpf;
       
        private Label label8;
       
        private Label label7;
        public Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonButton btnRedefinirSenha;
        private Label label6;
        private Krypton.Toolkit.KryptonButton btnCancel;
        private PictureBox pictureBox1;
        public Krypton.Toolkit.KryptonTextBox txtConfirmarSenha;
        private Label label10;
        public Krypton.Toolkit.KryptonTextBox txtNovaSenha;
        private Label label9;
        public Krypton.Toolkit.KryptonTextBox txtTokens;
        private Krypton.Toolkit.KryptonButton btnRedefinirPass;
        private Label lblTokenInfo;
        private Panel painelRecuperacao;
        private Panel painelRedefinir;
    }
}
