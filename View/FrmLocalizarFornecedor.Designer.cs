namespace GVC.View
{
    partial class FrmLocalizarFornecedor
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
            btnSair = new Krypton.Toolkit.KryptonButton();
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
            dataGridPesquisar.Location = new Point(4, 41);
            dataGridPesquisar.Margin = new Padding(4, 3, 4, 3);
            dataGridPesquisar.MultiSelect = false;
            dataGridPesquisar.Name = "dataGridPesquisar";
            dataGridPesquisar.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlueDarkMode;
            dataGridPesquisar.ReadOnly = true;
            dataGridPesquisar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridPesquisar.Size = new Size(767, 212);
            dataGridPesquisar.TabIndex = 598;
            dataGridPesquisar.SelectionChanged += dataGridPesquisar_SelectionChanged;
            dataGridPesquisar.DoubleClick += dataGridPesquisar_DoubleClick;
            dataGridPesquisar.Enter += dataGridPesquisar_Enter;
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
            txtPesquisar.Location = new Point(176, 5);
            txtPesquisar.Margin = new Padding(5, 6, 5, 6);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlueDarkMode;
            txtPesquisar.Size = new Size(594, 27);
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
            kryptonPanel3.Location = new Point(4, 5);
            kryptonPanel3.Name = "kryptonPanel3";
            kryptonPanel3.PaletteMode = Krypton.Toolkit.PaletteMode.Office365Blue;
            kryptonPanel3.Size = new Size(164, 28);
            kryptonPanel3.TabIndex = 629;
            // 
            // rbtCodigo
            // 
            rbtCodigo.Location = new Point(91, 3);
            rbtCodigo.Margin = new Padding(5, 6, 5, 6);
            rbtCodigo.Name = "rbtCodigo";
            rbtCodigo.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            rbtCodigo.Size = new Size(62, 20);
            rbtCodigo.TabIndex = 102;
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
            // btnSair
            // 
            btnSair.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSair.CornerRoundingRadius = 10F;
            btnSair.Location = new Point(691, 259);
            btnSair.Margin = new Padding(5, 3, 5, 3);
            btnSair.Name = "btnSair";
            btnSair.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnSair.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.OverrideDefault.Back.ColorAngle = 45F;
            btnSair.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSair.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.OverrideDefault.Border.ColorAngle = 45F;
            btnSair.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSair.OverrideDefault.Border.Rounding = 20F;
            btnSair.OverrideDefault.Border.Width = 1;
            btnSair.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnSair.Size = new Size(80, 30);
            btnSair.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnSair.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.StateCommon.Back.ColorAngle = 45F;
            btnSair.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSair.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSair.StateCommon.Border.Rounding = 10F;
            btnSair.StateCommon.Border.Width = 1;
            btnSair.StateCommon.Content.ShortText.Color1 = Color.White;
            btnSair.StateCommon.Content.ShortText.Color2 = Color.White;
            btnSair.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 10.25F);
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
            btnSair.TabIndex = 628;
            btnSair.TabStop = false;
            btnSair.Values.Text = "&OK";
            btnSair.Click += btnSair_Click_1;
            // 
            // FrmLocalizarFornecedor
            // 
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(784, 301);
            Controls.Add(txtPesquisar);
            Controls.Add(kryptonPanel3);
            Controls.Add(btnSair);
            Controls.Add(dataGridPesquisar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 3, 5, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLocalizarFornecedor";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Text = "Localizar Fornecedor";
            FormClosed += FrmLocalizarFornecedor_FormClosed;
            Load += FrmLocalizarFornecedor_Load;
            Shown += FrmLocalizarFornecedor_Shown;
            KeyDown += FrmLocalizarFornecedor_KeyDown;
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
        public Krypton.Toolkit.KryptonButton btnSair;
    }
}
