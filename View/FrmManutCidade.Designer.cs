namespace GVC
{
    partial class FrmManutCidade
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
            timer1 = new System.Windows.Forms.Timer(components);
            dataGridPesquisar = new Krypton.Toolkit.KryptonDataGridView();
            kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            rbtCodig = new Krypton.Toolkit.KryptonRadioButton();
            rbtDescrica = new Krypton.Toolkit.KryptonRadioButton();
            btnSai = new Krypton.Toolkit.KryptonButton();
            btnExclui = new Krypton.Toolkit.KryptonButton();
            btnNov = new Krypton.Toolkit.KryptonButton();
            btnAltera = new Krypton.Toolkit.KryptonButton();
            txtLocaliza = new Krypton.Toolkit.KryptonTextBox();
            kryptonStatusStrip2 = new Krypton.Toolkit.KryptonStatusStrip();
            toolStripStatusLabelTotalRegistro = new ToolStripStatusLabel();
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            ((System.ComponentModel.ISupportInitialize)dataGridPesquisar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).BeginInit();
            kryptonPanel3.SuspendLayout();
            kryptonStatusStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // dataGridPesquisar
            // 
            dataGridPesquisar.AllowUserToAddRows = false;
            dataGridPesquisar.AllowUserToDeleteRows = false;
            dataGridPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridPesquisar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPesquisar.Location = new Point(7, 51);
            dataGridPesquisar.Margin = new Padding(4, 3, 4, 3);
            dataGridPesquisar.MultiSelect = false;
            dataGridPesquisar.Name = "dataGridPesquisar";
            dataGridPesquisar.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlueDarkMode;
            dataGridPesquisar.ReadOnly = true;
            dataGridPesquisar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridPesquisar.Size = new Size(791, 272);
            dataGridPesquisar.TabIndex = 597;
            // 
            // kryptonPanel3
            // 
            kryptonPanel3.Controls.Add(rbtCodig);
            kryptonPanel3.Controls.Add(rbtDescrica);
            kryptonPanel3.Location = new Point(7, 15);
            kryptonPanel3.Name = "kryptonPanel3";
            kryptonPanel3.PaletteMode = Krypton.Toolkit.PaletteMode.Office365Blue;
            kryptonPanel3.Size = new Size(164, 28);
            kryptonPanel3.TabIndex = 620;
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
            rbtCodig.CheckedChanged += rbtCodig_CheckedChanged;
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
            rbtDescrica.CheckedChanged += rbtDescrica_CheckedChanged;
            // 
            // btnSai
            // 
            btnSai.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSai.CornerRoundingRadius = 10F;
            btnSai.Location = new Point(815, 288);
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
            btnSai.Size = new Size(80, 35);
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
            btnSai.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            btnSai.TabIndex = 618;
            btnSai.Values.Text = "&Sair";
            btnSai.Click += btnSai_Click;
            // 
            // btnExclui
            // 
            btnExclui.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExclui.CornerRoundingRadius = 10F;
            btnExclui.Location = new Point(815, 133);
            btnExclui.Margin = new Padding(5, 3, 5, 3);
            btnExclui.Name = "btnExclui";
            btnExclui.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnExclui.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnExclui.OverrideDefault.Back.ColorAngle = 45F;
            btnExclui.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnExclui.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnExclui.OverrideDefault.Border.ColorAngle = 45F;
            btnExclui.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExclui.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnExclui.OverrideDefault.Border.Rounding = 20F;
            btnExclui.OverrideDefault.Border.Width = 1;
            btnExclui.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnExclui.Size = new Size(80, 35);
            btnExclui.StateCommon.Back.Color1 = Color.Red;
            btnExclui.StateCommon.Back.Color2 = Color.Red;
            btnExclui.StateCommon.Back.ColorAngle = 45F;
            btnExclui.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnExclui.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnExclui.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExclui.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnExclui.StateCommon.Border.Rounding = 10F;
            btnExclui.StateCommon.Border.Width = 1;
            btnExclui.StateCommon.Content.ShortText.Color1 = Color.White;
            btnExclui.StateCommon.Content.ShortText.Color2 = Color.White;
            btnExclui.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExclui.StateNormal.Back.Color1 = Color.Red;
            btnExclui.StateNormal.Back.Color2 = Color.Red;
            btnExclui.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnExclui.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnExclui.StatePressed.Back.ColorAngle = 135F;
            btnExclui.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnExclui.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnExclui.StatePressed.Border.ColorAngle = 135F;
            btnExclui.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExclui.StatePressed.Border.Rounding = 20F;
            btnExclui.StatePressed.Border.Width = 1;
            btnExclui.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnExclui.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnExclui.StateTracking.Back.ColorAngle = 45F;
            btnExclui.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnExclui.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnExclui.StateTracking.Border.ColorAngle = 45F;
            btnExclui.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExclui.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnExclui.StateTracking.Border.Rounding = 20F;
            btnExclui.StateTracking.Border.Width = 1;
            btnExclui.TabIndex = 616;
            btnExclui.Values.Text = "&Excluir";
            btnExclui.Click += btnExclui_Click;
            // 
            // btnNov
            // 
            btnNov.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNov.CornerRoundingRadius = 10F;
            btnNov.Location = new Point(815, 51);
            btnNov.Margin = new Padding(5, 3, 5, 3);
            btnNov.Name = "btnNov";
            btnNov.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnNov.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnNov.OverrideDefault.Back.ColorAngle = 45F;
            btnNov.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnNov.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnNov.OverrideDefault.Border.ColorAngle = 45F;
            btnNov.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnNov.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnNov.OverrideDefault.Border.Rounding = 20F;
            btnNov.OverrideDefault.Border.Width = 1;
            btnNov.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnNov.Size = new Size(80, 35);
            btnNov.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnNov.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnNov.StateCommon.Back.ColorAngle = 45F;
            btnNov.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnNov.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnNov.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnNov.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnNov.StateCommon.Border.Rounding = 10F;
            btnNov.StateCommon.Border.Width = 1;
            btnNov.StateCommon.Content.ShortText.Color1 = Color.White;
            btnNov.StateCommon.Content.ShortText.Color2 = Color.White;
            btnNov.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNov.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnNov.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnNov.StatePressed.Back.ColorAngle = 135F;
            btnNov.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnNov.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnNov.StatePressed.Border.ColorAngle = 135F;
            btnNov.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnNov.StatePressed.Border.Rounding = 20F;
            btnNov.StatePressed.Border.Width = 1;
            btnNov.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnNov.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnNov.StateTracking.Back.ColorAngle = 45F;
            btnNov.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnNov.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnNov.StateTracking.Border.ColorAngle = 45F;
            btnNov.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnNov.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnNov.StateTracking.Border.Rounding = 20F;
            btnNov.StateTracking.Border.Width = 1;
            btnNov.TabIndex = 619;
            btnNov.Values.Text = "&Novo";
            btnNov.Click += btnNov_Click;
            // 
            // btnAltera
            // 
            btnAltera.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAltera.CornerRoundingRadius = 10F;
            btnAltera.Location = new Point(815, 92);
            btnAltera.Margin = new Padding(5, 3, 5, 3);
            btnAltera.Name = "btnAltera";
            btnAltera.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnAltera.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnAltera.OverrideDefault.Back.ColorAngle = 45F;
            btnAltera.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnAltera.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnAltera.OverrideDefault.Border.ColorAngle = 45F;
            btnAltera.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAltera.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAltera.OverrideDefault.Border.Rounding = 20F;
            btnAltera.OverrideDefault.Border.Width = 1;
            btnAltera.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnAltera.Size = new Size(80, 35);
            btnAltera.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnAltera.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnAltera.StateCommon.Back.ColorAngle = 45F;
            btnAltera.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnAltera.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnAltera.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAltera.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAltera.StateCommon.Border.Rounding = 10F;
            btnAltera.StateCommon.Border.Width = 1;
            btnAltera.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnAltera.StateCommon.Content.ShortText.Color2 = Color.White;
            btnAltera.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAltera.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnAltera.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnAltera.StatePressed.Back.ColorAngle = 135F;
            btnAltera.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnAltera.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnAltera.StatePressed.Border.ColorAngle = 135F;
            btnAltera.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAltera.StatePressed.Border.Rounding = 20F;
            btnAltera.StatePressed.Border.Width = 1;
            btnAltera.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnAltera.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnAltera.StateTracking.Back.ColorAngle = 45F;
            btnAltera.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnAltera.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnAltera.StateTracking.Border.ColorAngle = 45F;
            btnAltera.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAltera.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAltera.StateTracking.Border.Rounding = 20F;
            btnAltera.StateTracking.Border.Width = 1;
            btnAltera.StateTracking.Content.ShortText.Color1 = Color.White;
            btnAltera.TabIndex = 617;
            btnAltera.Values.Text = "&Alterar";
            btnAltera.Click += btnAltera_Click;
            // 
            // txtLocaliza
            // 
            txtLocaliza.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLocaliza.CharacterCasing = CharacterCasing.Upper;
            txtLocaliza.Location = new Point(183, 15);
            txtLocaliza.Margin = new Padding(5, 6, 5, 6);
            txtLocaliza.Name = "txtLocaliza";
            txtLocaliza.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlueDarkMode;
            txtLocaliza.Size = new Size(615, 27);
            txtLocaliza.StateCommon.Back.Color1 = Color.White;
            txtLocaliza.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtLocaliza.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtLocaliza.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtLocaliza.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtLocaliza.StateCommon.Border.Rounding = 8F;
            txtLocaliza.StateCommon.Border.Width = 1;
            txtLocaliza.StateCommon.Content.Color1 = Color.Gray;
            txtLocaliza.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtLocaliza.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtLocaliza.TabIndex = 615;
            txtLocaliza.TextChanged += txtLocaliza_TextChanged;
            // 
            // kryptonStatusStrip2
            // 
            kryptonStatusStrip2.Font = new Font("Segoe UI", 9F);
            kryptonStatusStrip2.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelTotalRegistro });
            kryptonStatusStrip2.Location = new Point(0, 343);
            kryptonStatusStrip2.Name = "kryptonStatusStrip2";
            kryptonStatusStrip2.ProgressBars = null;
            kryptonStatusStrip2.RenderMode = ToolStripRenderMode.ManagerRenderMode;
            kryptonStatusStrip2.Size = new Size(909, 22);
            kryptonStatusStrip2.TabIndex = 621;
            kryptonStatusStrip2.Text = "kryptonStatusStrip2";
            // 
            // toolStripStatusLabelTotalRegistro
            // 
            toolStripStatusLabelTotalRegistro.Name = "toolStripStatusLabelTotalRegistro";
            toolStripStatusLabelTotalRegistro.Size = new Size(118, 17);
            toolStripStatusLabelTotalRegistro.Text = "toolStripStatusLabel1";
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
            // FrmManutCidade
            // 
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(909, 365);
            ControlBox = false;
            Controls.Add(kryptonStatusStrip2);
            Controls.Add(kryptonPanel3);
            Controls.Add(btnSai);
            Controls.Add(btnExclui);
            Controls.Add(btnNov);
            Controls.Add(btnAltera);
            Controls.Add(txtLocaliza);
            Controls.Add(dataGridPesquisar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5, 3, 5, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmManutCidade";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            StateCommon.Back.Color1 = Color.White;
            StateCommon.Back.Color2 = Color.White;
            Text = "Manutenção de Cidade";
            Load += FrmManutCidade_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridPesquisar).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).EndInit();
            kryptonPanel3.ResumeLayout(false);
            kryptonPanel3.PerformLayout();
            kryptonStatusStrip2.ResumeLayout(false);
            kryptonStatusStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Krypton.Toolkit.KryptonDataGridView dataGridPesquisar;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        public Krypton.Toolkit.KryptonRadioButton rbtCodig;
        private Krypton.Toolkit.KryptonRadioButton rbtDescrica;
        public Krypton.Toolkit.KryptonButton btnSai;
        public Krypton.Toolkit.KryptonButton btnExclui;
        public Krypton.Toolkit.KryptonButton btnNov;
        public Krypton.Toolkit.KryptonButton btnAltera;
        public Krypton.Toolkit.KryptonTextBox txtLocaliza;
        private Krypton.Toolkit.KryptonStatusStrip kryptonStatusStrip1;
        private Label lblTotalRegistros;        
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Label lblTotalRegistro;
        private Krypton.Toolkit.KryptonStatusStrip kryptonStatusStrip2;
        private ToolStripStatusLabel toolStripStatusLabelTotalRegistro;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
    }
}
