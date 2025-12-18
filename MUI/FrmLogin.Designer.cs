namespace GVC.MUI
{
    partial class FrmLogin
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
            lblEsqueciSenha = new Label();
            btnCancelar = new Krypton.Toolkit.KryptonButton();
            panel3 = new Panel();
            panel1 = new Panel();
            btnLogin = new Krypton.Toolkit.KryptonButton();
            pictureBoxUser = new PictureBox();
            pictureBoxRepetePassWord = new PictureBox();
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            label18 = new Label();
            txtUsuario = new Krypton.Toolkit.KryptonTextBox();
            txtSenha = new Krypton.Toolkit.KryptonTextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRepetePassWord).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblEsqueciSenha
            // 
            lblEsqueciSenha.AutoSize = true;
            lblEsqueciSenha.ForeColor = Color.FromArgb(8, 142, 254);
            lblEsqueciSenha.Location = new Point(168, 295);
            lblEsqueciSenha.Name = "lblEsqueciSenha";
            lblEsqueciSenha.Size = new Size(91, 15);
            lblEsqueciSenha.TabIndex = 10;
            lblEsqueciSenha.Text = "Esqueci a Senha";
            lblEsqueciSenha.Click += lblEsqueciSenha_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.CornerRoundingRadius = 20F;
            btnCancelar.Location = new Point(159, 234);
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
            btnCancelar.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            btnCancelar.Size = new Size(100, 30);
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
            btnCancelar.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
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
            btnCancelar.TabIndex = 4;
            btnCancelar.TabStop = false;
            btnCancelar.Values.Text = "&Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(34, 198);
            panel3.Name = "panel3";
            panel3.Size = new Size(230, 2);
            panel3.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(34, 140);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 2);
            panel1.TabIndex = 17;
            // 
            // btnLogin
            // 
            btnLogin.CornerRoundingRadius = 20F;
            btnLogin.Location = new Point(25, 231);
            btnLogin.Name = "btnLogin";
            btnLogin.OverrideDefault.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnLogin.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnLogin.OverrideDefault.Back.ColorAngle = 45F;
            btnLogin.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnLogin.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLogin.OverrideDefault.Border.ColorAngle = 45F;
            btnLogin.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLogin.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLogin.OverrideDefault.Border.Rounding = 20F;
            btnLogin.OverrideDefault.Border.Width = 1;
            btnLogin.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            btnLogin.Size = new Size(100, 30);
            btnLogin.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnLogin.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnLogin.StateCommon.Back.ColorAngle = 45F;
            btnLogin.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnLogin.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLogin.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLogin.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLogin.StateCommon.Border.Rounding = 20F;
            btnLogin.StateCommon.Border.Width = 1;
            btnLogin.StateCommon.Content.ShortText.Color1 = Color.White;
            btnLogin.StateCommon.Content.ShortText.Color2 = Color.White;
            btnLogin.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
            btnLogin.StateDisabled.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnLogin.StateDisabled.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnLogin.StateDisabled.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnLogin.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLogin.StateDisabled.Content.ShortText.Color1 = Color.White;
            btnLogin.StateNormal.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnLogin.StateNormal.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnLogin.StateNormal.Content.LongText.Color1 = Color.White;
            btnLogin.StateNormal.Content.LongText.Color2 = Color.White;
            btnLogin.StateNormal.Content.ShortText.Color1 = Color.White;
            btnLogin.StateNormal.Content.ShortText.Color2 = Color.White;
            btnLogin.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnLogin.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnLogin.StatePressed.Back.ColorAngle = 135F;
            btnLogin.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnLogin.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnLogin.StatePressed.Border.ColorAngle = 135F;
            btnLogin.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLogin.StatePressed.Border.Rounding = 20F;
            btnLogin.StatePressed.Border.Width = 1;
            btnLogin.StatePressed.Content.LongText.Color1 = Color.White;
            btnLogin.StatePressed.Content.LongText.Color2 = Color.White;
            btnLogin.StatePressed.Content.ShortText.Color1 = Color.White;
            btnLogin.StatePressed.Content.ShortText.Color2 = Color.White;
            btnLogin.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnLogin.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnLogin.StateTracking.Back.ColorAngle = 45F;
            btnLogin.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnLogin.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLogin.StateTracking.Border.ColorAngle = 45F;
            btnLogin.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLogin.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLogin.StateTracking.Border.Rounding = 20F;
            btnLogin.StateTracking.Border.Width = 1;
            btnLogin.StateTracking.Content.ShortText.Color1 = Color.White;
            btnLogin.TabIndex = 2;
            btnLogin.Values.Text = "&Login";
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBoxUser
            // 
            pictureBoxUser.Image = Properties.Resources.Usuario24;
            pictureBoxUser.Location = new Point(9, 109);
            pictureBoxUser.Name = "pictureBoxUser";
            pictureBoxUser.Size = new Size(20, 25);
            pictureBoxUser.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxUser.TabIndex = 6;
            pictureBoxUser.TabStop = false;
            // 
            // pictureBoxRepetePassWord
            // 
            pictureBoxRepetePassWord.Image = Properties.Resources.Senhas24;
            pictureBoxRepetePassWord.Location = new Point(9, 169);
            pictureBoxRepetePassWord.Name = "pictureBoxRepetePassWord";
            pictureBoxRepetePassWord.Size = new Size(20, 25);
            pictureBoxRepetePassWord.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxRepetePassWord.TabIndex = 8;
            pictureBoxRepetePassWord.TabStop = false;
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
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 9.25F);
            label18.ForeColor = Color.FromArgb(8, 142, 254);
            label18.Location = new Point(34, 91);
            label18.Name = "label18";
            label18.Size = new Size(54, 16);
            label18.TabIndex = 185;
            label18.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(34, 109);
            txtUsuario.MaxLength = 14;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(231, 27);
            txtUsuario.StateCommon.Back.Color1 = Color.White;
            txtUsuario.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtUsuario.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtUsuario.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtUsuario.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtUsuario.StateCommon.Border.Rounding = 8F;
            txtUsuario.StateCommon.Border.Width = 1;
            txtUsuario.StateCommon.Content.Color1 = Color.Gray;
            txtUsuario.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtUsuario.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtUsuario.TabIndex = 0;
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.KeyDown += txtUsuario_KeyDown;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtSenha
            // 
            txtSenha.CharacterCasing = CharacterCasing.Lower;
            txtSenha.Location = new Point(34, 165);
            txtSenha.MaxLength = 100;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(231, 27);
            txtSenha.StateCommon.Back.Color1 = Color.White;
            txtSenha.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtSenha.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtSenha.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtSenha.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtSenha.StateCommon.Border.Rounding = 8F;
            txtSenha.StateCommon.Border.Width = 1;
            txtSenha.StateCommon.Content.Color1 = Color.Gray;
            txtSenha.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtSenha.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtSenha.TabIndex = 1;
            txtSenha.Enter += txtSenha_Enter;
            txtSenha.KeyDown += txtSenha_KeyDown;
            txtSenha.Leave += txtSenha_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.25F);
            label1.ForeColor = Color.FromArgb(8, 142, 254);
            label1.Location = new Point(34, 146);
            label1.Name = "label1";
            label1.Size = new Size(46, 16);
            label1.TabIndex = 186;
            label1.Text = "Senha";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.GVC_Gestao_de_Vendas_e_Cobrancas;
            pictureBox1.Location = new Point(100, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 187;
            pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(276, 319);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(txtSenha);
            Controls.Add(label18);
            Controls.Add(txtUsuario);
            Controls.Add(btnLogin);
            Controls.Add(btnCancelar);
            Controls.Add(panel1);
            Controls.Add(lblEsqueciSenha);
            Controls.Add(pictureBoxUser);
            Controls.Add(panel3);
            Controls.Add(pictureBoxRepetePassWord);
            ForeColor = Color.FromArgb(252, 252, 250);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLogin";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            StateCommon.Header.Border.Color1 = Color.FromArgb(8, 142, 254);
            StateCommon.Header.Border.Color2 = Color.FromArgb(8, 142, 254);
            StateCommon.Header.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            StateInactive.Border.Color1 = Color.FromArgb(8, 142, 254);
            StateInactive.Border.Color2 = Color.FromArgb(8, 142, 254);
            StateInactive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Text = " ";
            Load += FrmLogin_Load;
            KeyDown += FrmLogin_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRepetePassWord).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.PictureBox pictureBoxRepetePassWord;
        private System.Windows.Forms.Label lblEsqueciSenha;
        private Krypton.Toolkit.KryptonButton btnCancelar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private Krypton.Toolkit.KryptonButton btnLogin;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Label label18;
        public Krypton.Toolkit.KryptonTextBox txtUsuario;
        public Krypton.Toolkit.KryptonTextBox txtSenha;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
