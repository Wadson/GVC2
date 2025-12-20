namespace GVC.View
{
    partial class FrmEstornarPagamento
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
            txtMotivo = new Krypton.Toolkit.KryptonTextBox();
            txtNomeCliente = new Krypton.Toolkit.KryptonTextBox();
            txtValorEstornado = new Krypton.Toolkit.KryptonTextBox();
            lblMotivo = new Label();
            lblValorEstornado = new Label();
            lblCliente = new Label();
            btnCancelar = new Krypton.Toolkit.KryptonButton();
            btnConfirmarEstorno = new Krypton.Toolkit.KryptonButton();
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
            // txtMotivo
            // 
            txtMotivo.Location = new Point(12, 142);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(448, 27);
            txtMotivo.StateCommon.Back.Color1 = Color.White;
            txtMotivo.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtMotivo.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtMotivo.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtMotivo.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtMotivo.StateCommon.Border.Rounding = 8F;
            txtMotivo.StateCommon.Border.Width = 1;
            txtMotivo.StateCommon.Content.Color1 = Color.Gray;
            txtMotivo.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtMotivo.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtMotivo.TabIndex = 1;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.CharacterCasing = CharacterCasing.Upper;
            txtNomeCliente.Location = new Point(12, 34);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(448, 27);
            txtNomeCliente.StateCommon.Back.Color1 = Color.White;
            txtNomeCliente.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtNomeCliente.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtNomeCliente.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtNomeCliente.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtNomeCliente.StateCommon.Border.Rounding = 8F;
            txtNomeCliente.StateCommon.Border.Width = 1;
            txtNomeCliente.StateCommon.Content.Color1 = Color.Gray;
            txtNomeCliente.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtNomeCliente.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtNomeCliente.TabIndex = 251;
            txtNomeCliente.TabStop = false;
            // 
            // txtValorEstornado
            // 
            txtValorEstornado.Location = new Point(12, 89);
            txtValorEstornado.Name = "txtValorEstornado";
            txtValorEstornado.Size = new Size(448, 27);
            txtValorEstornado.StateCommon.Back.Color1 = Color.White;
            txtValorEstornado.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtValorEstornado.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtValorEstornado.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtValorEstornado.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtValorEstornado.StateCommon.Border.Rounding = 8F;
            txtValorEstornado.StateCommon.Border.Width = 1;
            txtValorEstornado.StateCommon.Content.Color1 = Color.Gray;
            txtValorEstornado.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtValorEstornado.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtValorEstornado.TabIndex = 0;
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblMotivo.ForeColor = Color.FromArgb(0, 76, 172);
            lblMotivo.Location = new Point(12, 122);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(47, 16);
            lblMotivo.TabIndex = 256;
            lblMotivo.Text = "Motivo";
            // 
            // lblValorEstornado
            // 
            lblValorEstornado.AutoSize = true;
            lblValorEstornado.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblValorEstornado.ForeColor = Color.FromArgb(0, 76, 172);
            lblValorEstornado.Location = new Point(10, 71);
            lblValorEstornado.Name = "lblValorEstornado";
            lblValorEstornado.Size = new Size(104, 16);
            lblValorEstornado.TabIndex = 255;
            lblValorEstornado.Text = "Valor Estornado";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblCliente.ForeColor = Color.FromArgb(0, 76, 172);
            lblCliente.Location = new Point(12, 13);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(48, 16);
            lblCliente.TabIndex = 254;
            lblCliente.Text = "Cliente";
            // 
            // btnCancelar
            // 
            btnCancelar.CornerRoundingRadius = 6F;
            btnCancelar.Location = new Point(340, 181);
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
            btnCancelar.TabIndex = 1044;
            btnCancelar.TabStop = false;
            btnCancelar.Values.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmarEstorno
            // 
            btnConfirmarEstorno.CornerRoundingRadius = 6F;
            btnConfirmarEstorno.Location = new Point(218, 181);
            btnConfirmarEstorno.Name = "btnConfirmarEstorno";
            btnConfirmarEstorno.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnConfirmarEstorno.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnConfirmarEstorno.OverrideDefault.Back.ColorAngle = 45F;
            btnConfirmarEstorno.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnConfirmarEstorno.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnConfirmarEstorno.OverrideDefault.Border.ColorAngle = 45F;
            btnConfirmarEstorno.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnConfirmarEstorno.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnConfirmarEstorno.OverrideDefault.Border.Rounding = 20F;
            btnConfirmarEstorno.OverrideDefault.Border.Width = 1;
            btnConfirmarEstorno.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnConfirmarEstorno.Size = new Size(120, 30);
            btnConfirmarEstorno.StateCommon.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnConfirmarEstorno.StateCommon.Back.Color2 = Color.FromArgb(6, 180, 240);
            btnConfirmarEstorno.StateCommon.Back.ColorAngle = 45F;
            btnConfirmarEstorno.StateCommon.Border.Color1 = Color.FromArgb(0, 76, 172);
            btnConfirmarEstorno.StateCommon.Border.Color2 = Color.FromArgb(0, 76, 172);
            btnConfirmarEstorno.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnConfirmarEstorno.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnConfirmarEstorno.StateCommon.Border.Rounding = 6F;
            btnConfirmarEstorno.StateCommon.Border.Width = 1;
            btnConfirmarEstorno.StateCommon.Content.ShortText.Color1 = Color.White;
            btnConfirmarEstorno.StateCommon.Content.ShortText.Color2 = Color.White;
            btnConfirmarEstorno.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
            btnConfirmarEstorno.StatePressed.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnConfirmarEstorno.StatePressed.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnConfirmarEstorno.StatePressed.Back.ColorAngle = 135F;
            btnConfirmarEstorno.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnConfirmarEstorno.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnConfirmarEstorno.StatePressed.Border.ColorAngle = 135F;
            btnConfirmarEstorno.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnConfirmarEstorno.StatePressed.Border.Rounding = 20F;
            btnConfirmarEstorno.StatePressed.Border.Width = 1;
            btnConfirmarEstorno.StatePressed.Content.ShortText.Color1 = Color.Black;
            btnConfirmarEstorno.StatePressed.Content.ShortText.Color2 = Color.Black;
            btnConfirmarEstorno.StateTracking.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnConfirmarEstorno.StateTracking.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnConfirmarEstorno.StateTracking.Back.ColorAngle = 45F;
            btnConfirmarEstorno.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnConfirmarEstorno.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnConfirmarEstorno.StateTracking.Border.ColorAngle = 45F;
            btnConfirmarEstorno.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnConfirmarEstorno.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnConfirmarEstorno.StateTracking.Border.Rounding = 20F;
            btnConfirmarEstorno.StateTracking.Border.Width = 1;
            btnConfirmarEstorno.StateTracking.Content.ShortText.Color1 = Color.Black;
            btnConfirmarEstorno.StateTracking.Content.ShortText.Color2 = Color.Black;
            btnConfirmarEstorno.TabIndex = 2;
            btnConfirmarEstorno.Values.Text = "Confirmar";
            btnConfirmarEstorno.Click += btnConfirmarEstorno_Click;
            // 
            // FrmEstornarPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(464, 218);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmarEstorno);
            Controls.Add(txtMotivo);
            Controls.Add(txtNomeCliente);
            Controls.Add(txtValorEstornado);
            Controls.Add(lblMotivo);
            Controls.Add(lblValorEstornado);
            Controls.Add(lblCliente);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmEstornarPagamento";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estornar Pagamento";
            Load += FrmEstornarPagamento_Load;
            Shown += FrmEstornarPagamento_Shown;
            KeyDown += FrmEstornarPagamento_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        public Krypton.Toolkit.KryptonTextBox txtMotivo;
        public Krypton.Toolkit.KryptonTextBox txtNomeCliente;
        public Krypton.Toolkit.KryptonTextBox txtValorEstornado;
        private Label lblMotivo;
        private Label lblValorEstornado;
        private Label lblCliente;
        private Krypton.Toolkit.KryptonButton btnCancelar;
        public Krypton.Toolkit.KryptonButton btnConfirmarEstorno;
    }
}