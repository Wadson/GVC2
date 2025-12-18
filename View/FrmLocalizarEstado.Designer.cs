namespace GVC.View
{
    partial class FrmLocalizarEstado
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
            dataGridPesquisar = new Krypton.Toolkit.KryptonDataGridView();
            txtLocalizar = new Krypton.Toolkit.KryptonTextBox();
            rbtCodig = new Krypton.Toolkit.KryptonRadioButton();
            kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            rbtDescrica = new Krypton.Toolkit.KryptonRadioButton();
            btnSai = new Krypton.Toolkit.KryptonButton();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelTotalRegistros = new ToolStripStatusLabel();
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            ((System.ComponentModel.ISupportInitialize)dataGridPesquisar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).BeginInit();
            kryptonPanel3.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridPesquisar
            // 
            dataGridPesquisar.AllowUserToAddRows = false;
            dataGridPesquisar.AllowUserToDeleteRows = false;
            dataGridPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridPesquisar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPesquisar.Location = new Point(5, 44);
            dataGridPesquisar.Margin = new Padding(4, 3, 4, 3);
            dataGridPesquisar.MultiSelect = false;
            dataGridPesquisar.Name = "dataGridPesquisar";
            dataGridPesquisar.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            dataGridPesquisar.ReadOnly = true;
            dataGridPesquisar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridPesquisar.Size = new Size(468, 213);
            dataGridPesquisar.TabIndex = 602;
            dataGridPesquisar.SelectionChanged += dataGridPesquisar_SelectionChanged;
            dataGridPesquisar.KeyDown += dataGridPesquisar_KeyDown;
            // 
            // txtLocalizar
            // 
            txtLocalizar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLocalizar.CharacterCasing = CharacterCasing.Upper;
            txtLocalizar.Location = new Point(177, 8);
            txtLocalizar.Margin = new Padding(5, 6, 5, 6);
            txtLocalizar.Name = "txtLocalizar";
            txtLocalizar.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlueDarkMode;
            txtLocalizar.Size = new Size(296, 27);
            txtLocalizar.StateCommon.Back.Color1 = Color.White;
            txtLocalizar.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtLocalizar.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtLocalizar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtLocalizar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtLocalizar.StateCommon.Border.Rounding = 8F;
            txtLocalizar.StateCommon.Border.Width = 1;
            txtLocalizar.StateCommon.Content.Color1 = Color.Gray;
            txtLocalizar.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtLocalizar.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtLocalizar.TabIndex = 621;
            txtLocalizar.TextChanged += txtLocalizar_TextChanged;
            // 
            // rbtCodig
            // 
            rbtCodig.Location = new Point(91, 3);
            rbtCodig.Margin = new Padding(5, 6, 5, 6);
            rbtCodig.Name = "rbtCodig";
            rbtCodig.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            rbtCodig.Size = new Size(62, 20);
            rbtCodig.TabIndex = 0;
            rbtCodig.Values.Text = "Código";
            rbtCodig.KeyPress += rbtCodig_KeyPress;
            // 
            // kryptonPanel3
            // 
            kryptonPanel3.Controls.Add(rbtCodig);
            kryptonPanel3.Controls.Add(rbtDescrica);
            kryptonPanel3.Location = new Point(5, 8);
            kryptonPanel3.Name = "kryptonPanel3";
            kryptonPanel3.PaletteMode = Krypton.Toolkit.PaletteMode.Office365Blue;
            kryptonPanel3.Size = new Size(164, 28);
            kryptonPanel3.TabIndex = 623;
            // 
            // rbtDescrica
            // 
            rbtDescrica.Checked = true;
            rbtDescrica.Location = new Point(10, 3);
            rbtDescrica.Margin = new Padding(5, 6, 5, 6);
            rbtDescrica.Name = "rbtDescrica";
            rbtDescrica.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            rbtDescrica.Size = new Size(75, 20);
            rbtDescrica.TabIndex = 1;
            rbtDescrica.Values.Text = "Descrição";
            rbtDescrica.KeyDown += rbtDescrica_KeyDown;
            // 
            // btnSai
            // 
            btnSai.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSai.CornerRoundingRadius = 10F;
            btnSai.Location = new Point(388, 259);
            btnSai.Margin = new Padding(5, 3, 5, 3);
            btnSai.Name = "btnSai";
            btnSai.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnSai.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnSai.OverrideDefault.Back.ColorAngle = 45F;
            btnSai.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSai.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSai.OverrideDefault.Border.ColorAngle = 45F;
            btnSai.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSai.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSai.OverrideDefault.Border.Rounding = 20F;
            btnSai.OverrideDefault.Border.Width = 1;
            btnSai.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnSai.Size = new Size(80, 30);
            btnSai.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnSai.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnSai.StateCommon.Back.ColorAngle = 45F;
            btnSai.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSai.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSai.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSai.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSai.StateCommon.Border.Rounding = 10F;
            btnSai.StateCommon.Border.Width = 1;
            btnSai.StateCommon.Content.ShortText.Color1 = Color.White;
            btnSai.StateCommon.Content.ShortText.Color2 = Color.White;
            btnSai.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 10.25F);
            btnSai.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnSai.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnSai.StatePressed.Back.ColorAngle = 135F;
            btnSai.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnSai.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnSai.StatePressed.Border.ColorAngle = 135F;
            btnSai.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSai.StatePressed.Border.Rounding = 20F;
            btnSai.StatePressed.Border.Width = 1;
            btnSai.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnSai.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnSai.StateTracking.Back.ColorAngle = 45F;
            btnSai.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSai.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSai.StateTracking.Border.ColorAngle = 45F;
            btnSai.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSai.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSai.StateTracking.Border.Rounding = 20F;
            btnSai.StateTracking.Border.Width = 1;
            btnSai.TabIndex = 622;
            btnSai.Values.Text = "&OK";
            btnSai.Click += btnSai_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelTotalRegistros });
            statusStrip1.Location = new Point(0, 296);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(482, 22);
            statusStrip1.TabIndex = 624;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelTotalRegistros
            // 
            toolStripStatusLabelTotalRegistros.Name = "toolStripStatusLabelTotalRegistros";
            toolStripStatusLabelTotalRegistros.Size = new Size(103, 17);
            toolStripStatusLabelTotalRegistros.Text = "Total de Registros:";
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
            // FrmLocalizarEstado
            // 
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(482, 318);
            Controls.Add(statusStrip1);
            Controls.Add(txtLocalizar);
            Controls.Add(kryptonPanel3);
            Controls.Add(btnSai);
            Controls.Add(dataGridPesquisar);
            Margin = new Padding(5, 3, 5, 3);
            Name = "FrmLocalizarEstado";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Text = "Localizar Estado...";
            FormClosing += FrmLocalizarEstado_FormClosing;
            FormClosed += FrmLocalizarEstado_FormClosed;
            Load += FrmLocalizarEstado_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridPesquisar).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).EndInit();
            kryptonPanel3.ResumeLayout(false);
            kryptonPanel3.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonDataGridView dataGridPesquisar;
        public Krypton.Toolkit.KryptonTextBox txtLocalizar;
        public Krypton.Toolkit.KryptonRadioButton rbtCodig;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private Krypton.Toolkit.KryptonRadioButton rbtDescrica;
        public Krypton.Toolkit.KryptonButton btnSai;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelTotalRegistros;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
    }
}
