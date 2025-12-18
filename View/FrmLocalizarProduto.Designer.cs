namespace GVC.View
{
    partial class FrmLocalizarProduto
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
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            txtPesquisar = new Krypton.Toolkit.KryptonTextBox();
            kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            rbtCodigo = new Krypton.Toolkit.KryptonRadioButton();
            rbtDescricao = new Krypton.Toolkit.KryptonRadioButton();
            btnSai = new Krypton.Toolkit.KryptonButton();
            kryptonStatusStrip1 = new Krypton.Toolkit.KryptonStatusStrip();
            ((System.ComponentModel.ISupportInitialize)dataGridPesquisar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).BeginInit();
            kryptonPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridPesquisar
            // 
            dataGridPesquisar.AllowUserToAddRows = false;
            dataGridPesquisar.AllowUserToDeleteRows = false;
            dataGridPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridPesquisar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPesquisar.Location = new Point(2, 51);
            dataGridPesquisar.Margin = new Padding(4, 3, 4, 3);
            dataGridPesquisar.MultiSelect = false;
            dataGridPesquisar.Name = "dataGridPesquisar";
            dataGridPesquisar.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlueDarkMode;
            dataGridPesquisar.ReadOnly = true;
            dataGridPesquisar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridPesquisar.Size = new Size(779, 186);
            dataGridPesquisar.TabIndex = 599;
            dataGridPesquisar.TabStop = false;
            dataGridPesquisar.CellDoubleClick += dataGridPesquisar_CellDoubleClick;
            dataGridPesquisar.SelectionChanged += dataGridPesquisar_SelectionChanged;
            dataGridPesquisar.KeyDown += dataGridPesquisar_KeyDown;
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
            // txtPesquisar
            // 
            txtPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisar.CharacterCasing = CharacterCasing.Upper;
            txtPesquisar.Location = new Point(170, 15);
            txtPesquisar.Margin = new Padding(5, 6, 5, 6);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlueDarkMode;
            txtPesquisar.Size = new Size(600, 27);
            txtPesquisar.StateCommon.Back.Color1 = Color.White;
            txtPesquisar.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtPesquisar.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtPesquisar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtPesquisar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtPesquisar.StateCommon.Border.Rounding = 8F;
            txtPesquisar.StateCommon.Border.Width = 1;
            txtPesquisar.StateCommon.Content.Color1 = Color.Gray;
            txtPesquisar.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtPesquisar.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtPesquisar.TabIndex = 0;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            txtPesquisar.KeyDown += txtPesquisar_KeyDown;
            // 
            // kryptonPanel3
            // 
            kryptonPanel3.Controls.Add(rbtCodigo);
            kryptonPanel3.Controls.Add(rbtDescricao);
            kryptonPanel3.Location = new Point(-2, 15);
            kryptonPanel3.Name = "kryptonPanel3";
            kryptonPanel3.PaletteMode = Krypton.Toolkit.PaletteMode.Office365Blue;
            kryptonPanel3.Size = new Size(164, 28);
            kryptonPanel3.TabIndex = 626;
            // 
            // rbtCodigo
            // 
            rbtCodigo.Location = new Point(91, 3);
            rbtCodigo.Margin = new Padding(5, 6, 5, 6);
            rbtCodigo.Name = "rbtCodigo";
            rbtCodigo.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            rbtCodigo.Size = new Size(62, 20);
            rbtCodigo.TabIndex = 123;
            rbtCodigo.TabStop = false;
            rbtCodigo.Values.Text = "Código";
            // 
            // rbtDescricao
            // 
            rbtDescricao.Checked = true;
            rbtDescricao.Location = new Point(10, 3);
            rbtDescricao.Margin = new Padding(5, 6, 5, 6);
            rbtDescricao.Name = "rbtDescricao";
            rbtDescricao.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            rbtDescricao.Size = new Size(75, 20);
            rbtDescricao.TabIndex = 100;
            rbtDescricao.TabStop = false;
            rbtDescricao.Values.Text = "Descrição";
            // 
            // btnSai
            // 
            btnSai.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSai.CornerRoundingRadius = 10F;
            btnSai.Location = new Point(701, 243);
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
            btnSai.TabIndex = 625;
            btnSai.TabStop = false;
            btnSai.Values.Text = "&OK";
            btnSai.Click += btnSai_Click;
            // 
            // kryptonStatusStrip1
            // 
            kryptonStatusStrip1.Font = new Font("Segoe UI", 9F);
            kryptonStatusStrip1.Location = new Point(0, 279);
            kryptonStatusStrip1.Name = "kryptonStatusStrip1";
            kryptonStatusStrip1.ProgressBars = null;
            kryptonStatusStrip1.RenderMode = ToolStripRenderMode.ManagerRenderMode;
            kryptonStatusStrip1.Size = new Size(784, 22);
            kryptonStatusStrip1.TabIndex = 627;
            kryptonStatusStrip1.Text = "kryptonStatusStrip1";
            // 
            // FrmLocalizarProduto
            // 
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(784, 301);
            Controls.Add(kryptonStatusStrip1);
            Controls.Add(txtPesquisar);
            Controls.Add(kryptonPanel3);
            Controls.Add(btnSai);
            Controls.Add(dataGridPesquisar);
            Margin = new Padding(5, 3, 5, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLocalizarProduto";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Text = "Localizar Produto...";
            FormClosing += FrmLocalizarProduto_FormClosing;
            Load += FrmLocalizarProduto_Load;
            Shown += FrmLocalizarProduto_Shown;
            ((System.ComponentModel.ISupportInitialize)dataGridPesquisar).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).EndInit();
            kryptonPanel3.ResumeLayout(false);
            kryptonPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView dataGridPesquisar;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        public Krypton.Toolkit.KryptonTextBox txtPesquisar;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        public Krypton.Toolkit.KryptonRadioButton rbtCodigo;
        private Krypton.Toolkit.KryptonRadioButton rbtDescricao;
        public Krypton.Toolkit.KryptonButton btnSai;
        private Krypton.Toolkit.KryptonStatusStrip kryptonStatusStrip1;
    }
}
