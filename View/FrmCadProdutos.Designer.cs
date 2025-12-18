namespace GVC.View
{
    partial class FrmCadProdutos
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
            btnSair = new Krypton.Toolkit.KryptonButton();
            btnNovo = new Krypton.Toolkit.KryptonButton();
            btnSalva = new Krypton.Toolkit.KryptonButton();
            label21 = new Label();
            label23 = new Label();
            label25 = new Label();
            label27 = new Label();
            txtProdutoID = new Krypton.Toolkit.KryptonTextBox();
            label1 = new Label();
            label8 = new Label();
            label9 = new Label();
            label11 = new Label();
            txtEstoque = new Krypton.Toolkit.KryptonTextBox();
            txtPrecoDeVenda = new Krypton.Toolkit.KryptonTextBox();
            txtLucro = new Krypton.Toolkit.KryptonTextBox();
            txtPrecoCusto = new Krypton.Toolkit.KryptonTextBox();
            txtReferencia = new Krypton.Toolkit.KryptonTextBox();
            txtNomeProduto = new Krypton.Toolkit.KryptonTextBox();
            cmbStatus = new Krypton.Toolkit.KryptonComboBox();
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            pbImagem = new PictureBox();
            txtGtinEan = new Krypton.Toolkit.KryptonTextBox();
            label2 = new Label();
            txtFornecedor = new Krypton.Toolkit.KryptonTextBox();
            label3 = new Label();
            label6 = new Label();
            txtMarca = new Krypton.Toolkit.KryptonTextBox();
            label7 = new Label();
            txtUnidade = new Krypton.Toolkit.KryptonTextBox();
            label12 = new Label();
            btnLocalizarImagem = new Krypton.Toolkit.KryptonButton();
            txtEnderecoImagem = new Krypton.Toolkit.KryptonTextBox();
            label4 = new Label();
            btnLocalizarFornecedor = new Krypton.Toolkit.KryptonButton();
            cmbSituacao = new Krypton.Toolkit.KryptonComboBox();
            label10 = new Label();
            txtDataValidade = new Krypton.Toolkit.KryptonTextBox();
            txtFornecedorID = new Krypton.Toolkit.KryptonTextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)cmbStatus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbImagem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbSituacao).BeginInit();
            SuspendLayout();
            // 
            // btnSair
            // 
            btnSair.CornerRoundingRadius = 10F;
            btnSair.Location = new Point(402, 372);
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
            btnSair.Size = new Size(100, 30);
            btnSair.StateCommon.Back.Color1 = Color.FromArgb(252, 252, 250);
            btnSair.StateCommon.Back.Color2 = Color.FromArgb(252, 252, 250);
            btnSair.StateCommon.Back.ColorAngle = 45F;
            btnSair.StateCommon.Border.Color1 = Color.FromArgb(4, 162, 254);
            btnSair.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSair.StateCommon.Border.Rounding = 10F;
            btnSair.StateCommon.Border.Width = 1;
            btnSair.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnSair.StateCommon.Content.ShortText.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnSair.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnSair.StatePressed.Back.ColorAngle = 135F;
            btnSair.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnSair.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnSair.StatePressed.Border.ColorAngle = 135F;
            btnSair.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.StatePressed.Border.Rounding = 20F;
            btnSair.StatePressed.Border.Width = 1;
            btnSair.StatePressed.Content.ShortText.Color1 = Color.FromArgb(252, 252, 250);
            btnSair.StatePressed.Content.ShortText.Color2 = Color.FromArgb(252, 252, 250);
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
            btnSair.StateTracking.Content.ShortText.Color1 = Color.FromArgb(252, 252, 250);
            btnSair.StateTracking.Content.ShortText.Color2 = Color.FromArgb(252, 252, 250);
            btnSair.TabIndex = 111;
            btnSair.TabStop = false;
            btnSair.Values.Text = "&Sair";
            btnSair.Click += btnSair_Click;
            // 
            // btnNovo
            // 
            btnNovo.CornerRoundingRadius = 10F;
            btnNovo.Location = new Point(296, 372);
            btnNovo.Name = "btnNovo";
            btnNovo.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnNovo.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnNovo.OverrideDefault.Back.ColorAngle = 45F;
            btnNovo.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnNovo.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnNovo.OverrideDefault.Border.ColorAngle = 45F;
            btnNovo.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnNovo.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnNovo.OverrideDefault.Border.Rounding = 20F;
            btnNovo.OverrideDefault.Border.Width = 1;
            btnNovo.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnNovo.Size = new Size(100, 30);
            btnNovo.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnNovo.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnNovo.StateCommon.Back.ColorAngle = 45F;
            btnNovo.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnNovo.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnNovo.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnNovo.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnNovo.StateCommon.Border.Rounding = 10F;
            btnNovo.StateCommon.Border.Width = 1;
            btnNovo.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnNovo.StateCommon.Content.ShortText.Color2 = Color.White;
            btnNovo.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovo.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnNovo.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnNovo.StatePressed.Back.ColorAngle = 135F;
            btnNovo.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnNovo.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnNovo.StatePressed.Border.ColorAngle = 135F;
            btnNovo.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnNovo.StatePressed.Border.Rounding = 20F;
            btnNovo.StatePressed.Border.Width = 1;
            btnNovo.StatePressed.Content.ShortText.Color1 = Color.FromArgb(252, 252, 250);
            btnNovo.StatePressed.Content.ShortText.Color2 = Color.FromArgb(252, 252, 250);
            btnNovo.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnNovo.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnNovo.StateTracking.Back.ColorAngle = 45F;
            btnNovo.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnNovo.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnNovo.StateTracking.Border.ColorAngle = 45F;
            btnNovo.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnNovo.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnNovo.StateTracking.Border.Rounding = 20F;
            btnNovo.StateTracking.Border.Width = 1;
            btnNovo.StateTracking.Content.ShortText.Color1 = Color.FromArgb(252, 252, 250);
            btnNovo.StateTracking.Content.ShortText.Color2 = Color.FromArgb(252, 252, 250);
            btnNovo.TabIndex = 111;
            btnNovo.TabStop = false;
            btnNovo.Values.Text = "&Novo";
            btnNovo.Click += btnNovo_Click;
            // 
            // btnSalva
            // 
            btnSalva.CornerRoundingRadius = 10F;
            btnSalva.Location = new Point(190, 372);
            btnSalva.Name = "btnSalva";
            btnSalva.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnSalva.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnSalva.OverrideDefault.Back.ColorAngle = 45F;
            btnSalva.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSalva.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSalva.OverrideDefault.Border.ColorAngle = 45F;
            btnSalva.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSalva.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSalva.OverrideDefault.Border.Rounding = 20F;
            btnSalva.OverrideDefault.Border.Width = 1;
            btnSalva.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnSalva.Size = new Size(100, 30);
            btnSalva.StateCommon.Back.Color1 = Color.FromArgb(252, 252, 250);
            btnSalva.StateCommon.Back.Color2 = Color.FromArgb(252, 252, 250);
            btnSalva.StateCommon.Back.ColorAngle = 45F;
            btnSalva.StateCommon.Border.Color1 = Color.FromArgb(4, 162, 254);
            btnSalva.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSalva.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSalva.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSalva.StateCommon.Border.Rounding = 10F;
            btnSalva.StateCommon.Border.Width = 1;
            btnSalva.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnSalva.StateCommon.Content.ShortText.Color2 = Color.FromArgb(8, 142, 254);
            btnSalva.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalva.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnSalva.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnSalva.StatePressed.Back.ColorAngle = 135F;
            btnSalva.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnSalva.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnSalva.StatePressed.Border.ColorAngle = 135F;
            btnSalva.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSalva.StatePressed.Border.Rounding = 20F;
            btnSalva.StatePressed.Border.Width = 1;
            btnSalva.StatePressed.Content.ShortText.Color1 = Color.FromArgb(252, 252, 250);
            btnSalva.StatePressed.Content.ShortText.Color2 = Color.FromArgb(252, 252, 250);
            btnSalva.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnSalva.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnSalva.StateTracking.Back.ColorAngle = 45F;
            btnSalva.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSalva.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSalva.StateTracking.Border.ColorAngle = 45F;
            btnSalva.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSalva.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSalva.StateTracking.Border.Rounding = 20F;
            btnSalva.StateTracking.Border.Width = 1;
            btnSalva.StateTracking.Content.ShortText.Color1 = Color.FromArgb(252, 252, 250);
            btnSalva.StateTracking.Content.ShortText.Color2 = Color.FromArgb(252, 252, 250);
            btnSalva.TabIndex = 13;
            btnSalva.Values.Text = "Salvar";
            btnSalva.Click += btnSalva_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Microsoft Sans Serif", 9.25F);
            label21.ForeColor = Color.FromArgb(0, 76, 172);
            label21.Location = new Point(10, 69);
            label21.Name = "label21";
            label21.Size = new Size(73, 16);
            label21.TabIndex = 236;
            label21.Text = "Referência";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.Transparent;
            label23.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.ForeColor = Color.FromArgb(0, 76, 172);
            label23.Location = new Point(10, 22);
            label23.Name = "label23";
            label23.Size = new Size(57, 16);
            label23.TabIndex = 239;
            label23.Text = "Código";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Microsoft Sans Serif", 9.25F);
            label25.ForeColor = Color.FromArgb(0, 76, 172);
            label25.Location = new Point(90, 22);
            label25.Name = "label25";
            label25.Size = new Size(44, 16);
            label25.TabIndex = 234;
            label25.Text = "Nome";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Microsoft Sans Serif", 9.25F);
            label27.ForeColor = Color.FromArgb(0, 76, 172);
            label27.Location = new Point(10, 162);
            label27.Name = "label27";
            label27.Size = new Size(99, 16);
            label27.TabIndex = 240;
            label27.Text = "Preço de Custo";
            // 
            // txtProdutoID
            // 
            txtProdutoID.Location = new Point(10, 41);
            txtProdutoID.Name = "txtProdutoID";
            txtProdutoID.ReadOnly = true;
            txtProdutoID.Size = new Size(73, 24);
            txtProdutoID.StateCommon.Back.Color1 = Color.White;
            txtProdutoID.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtProdutoID.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtProdutoID.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtProdutoID.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtProdutoID.StateCommon.Border.Rounding = 8F;
            txtProdutoID.StateCommon.Border.Width = 1;
            txtProdutoID.StateCommon.Content.Color1 = Color.Gray;
            txtProdutoID.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtProdutoID.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtProdutoID.TabIndex = 243;
            txtProdutoID.TabStop = false;
            txtProdutoID.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.25F);
            label1.ForeColor = Color.FromArgb(0, 76, 172);
            label1.Location = new Point(10, 213);
            label1.Name = "label1";
            label1.Size = new Size(57, 16);
            label1.TabIndex = 590;
            label1.Text = "Estoque";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9.25F);
            label8.ForeColor = Color.FromArgb(0, 76, 172);
            label8.Location = new Point(161, 162);
            label8.Name = "label8";
            label8.Size = new Size(40, 16);
            label8.TabIndex = 596;
            label8.Text = "Lucro";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9.25F);
            label9.ForeColor = Color.FromArgb(0, 76, 172);
            label9.Location = new Point(311, 162);
            label9.Name = "label9";
            label9.Size = new Size(105, 16);
            label9.TabIndex = 598;
            label9.Text = "Preço de Venda";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9.25F);
            label11.ForeColor = Color.FromArgb(0, 76, 172);
            label11.Location = new Point(10, 260);
            label11.Name = "label11";
            label11.Size = new Size(44, 16);
            label11.TabIndex = 600;
            label11.Text = "Status";
            // 
            // txtEstoque
            // 
            txtEstoque.Location = new Point(10, 232);
            txtEstoque.Name = "txtEstoque";
            txtEstoque.Size = new Size(150, 24);
            txtEstoque.StateCommon.Back.Color1 = Color.White;
            txtEstoque.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtEstoque.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtEstoque.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtEstoque.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtEstoque.StateCommon.Border.Rounding = 8F;
            txtEstoque.StateCommon.Border.Width = 1;
            txtEstoque.StateCommon.Content.Color1 = Color.Gray;
            txtEstoque.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtEstoque.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtEstoque.TabIndex = 8;
            // 
            // txtPrecoDeVenda
            // 
            txtPrecoDeVenda.Location = new Point(310, 181);
            txtPrecoDeVenda.Name = "txtPrecoDeVenda";
            txtPrecoDeVenda.Size = new Size(150, 24);
            txtPrecoDeVenda.StateCommon.Back.Color1 = Color.White;
            txtPrecoDeVenda.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtPrecoDeVenda.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtPrecoDeVenda.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtPrecoDeVenda.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtPrecoDeVenda.StateCommon.Border.Rounding = 8F;
            txtPrecoDeVenda.StateCommon.Border.Width = 1;
            txtPrecoDeVenda.StateCommon.Content.Color1 = Color.Gray;
            txtPrecoDeVenda.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtPrecoDeVenda.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtPrecoDeVenda.TabIndex = 7;
            txtPrecoDeVenda.Leave += txtPrecoDeVenda_Leave;
            // 
            // txtLucro
            // 
            txtLucro.Location = new Point(160, 181);
            txtLucro.Name = "txtLucro";
            txtLucro.Size = new Size(150, 24);
            txtLucro.StateCommon.Back.Color1 = Color.White;
            txtLucro.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtLucro.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtLucro.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtLucro.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtLucro.StateCommon.Border.Rounding = 8F;
            txtLucro.StateCommon.Border.Width = 1;
            txtLucro.StateCommon.Content.Color1 = Color.Gray;
            txtLucro.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtLucro.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtLucro.TabIndex = 6;
            txtLucro.Enter += txtLucro_Enter;
            txtLucro.Leave += txtLucro_Leave;
            // 
            // txtPrecoCusto
            // 
            txtPrecoCusto.Location = new Point(10, 181);
            txtPrecoCusto.Name = "txtPrecoCusto";
            txtPrecoCusto.Size = new Size(150, 24);
            txtPrecoCusto.StateCommon.Back.Color1 = Color.White;
            txtPrecoCusto.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtPrecoCusto.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtPrecoCusto.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtPrecoCusto.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtPrecoCusto.StateCommon.Border.Rounding = 8F;
            txtPrecoCusto.StateCommon.Border.Width = 1;
            txtPrecoCusto.StateCommon.Content.Color1 = Color.Gray;
            txtPrecoCusto.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtPrecoCusto.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtPrecoCusto.TabIndex = 5;
            txtPrecoCusto.Enter += txtPrecoCusto_Enter;
            txtPrecoCusto.Leave += txtPrecoCusto_Leave;
            // 
            // txtReferencia
            // 
            txtReferencia.CharacterCasing = CharacterCasing.Upper;
            txtReferencia.Location = new Point(10, 90);
            txtReferencia.Name = "txtReferencia";
            txtReferencia.Size = new Size(301, 24);
            txtReferencia.StateCommon.Back.Color1 = Color.White;
            txtReferencia.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtReferencia.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtReferencia.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtReferencia.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtReferencia.StateCommon.Border.Rounding = 8F;
            txtReferencia.StateCommon.Border.Width = 1;
            txtReferencia.StateCommon.Content.Color1 = Color.Gray;
            txtReferencia.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtReferencia.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtReferencia.TabIndex = 1;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.CharacterCasing = CharacterCasing.Upper;
            txtNomeProduto.Location = new Point(90, 41);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(587, 24);
            txtNomeProduto.StateCommon.Back.Color1 = Color.White;
            txtNomeProduto.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtNomeProduto.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtNomeProduto.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtNomeProduto.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtNomeProduto.StateCommon.Border.Rounding = 8F;
            txtNomeProduto.StateCommon.Border.Width = 1;
            txtNomeProduto.StateCommon.Content.Color1 = Color.Gray;
            txtNomeProduto.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtNomeProduto.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtNomeProduto.TabIndex = 0;
            // 
            // cmbStatus
            // 
            cmbStatus.CornerRoundingRadius = 8F;
            cmbStatus.DropDownWidth = 115;
            cmbStatus.IntegralHeight = false;
            cmbStatus.Items.AddRange(new object[] { "Descontinuado", "Disponível", "Em Espera", "Em Produção", "Indisponível" });
            cmbStatus.Location = new Point(10, 282);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            cmbStatus.Size = new Size(145, 27);
            cmbStatus.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbStatus.StateCommon.ComboBox.Border.Rounding = 8F;
            cmbStatus.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbStatus.TabIndex = 608;
            cmbStatus.TabStop = false;
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
            // pbImagem
            // 
            pbImagem.Location = new Point(470, 167);
            pbImagem.Name = "pbImagem";
            pbImagem.Size = new Size(207, 191);
            pbImagem.TabIndex = 610;
            pbImagem.TabStop = false;
            // 
            // txtGtinEan
            // 
            txtGtinEan.Location = new Point(311, 285);
            txtGtinEan.Name = "txtGtinEan";
            txtGtinEan.Size = new Size(150, 24);
            txtGtinEan.StateCommon.Back.Color1 = Color.White;
            txtGtinEan.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtGtinEan.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtGtinEan.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtGtinEan.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtGtinEan.StateCommon.Border.Rounding = 8F;
            txtGtinEan.StateCommon.Border.Width = 1;
            txtGtinEan.StateCommon.Content.Color1 = Color.Gray;
            txtGtinEan.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtGtinEan.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtGtinEan.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.25F);
            label2.ForeColor = Color.FromArgb(0, 76, 172);
            label2.Location = new Point(312, 266);
            label2.Name = "label2";
            label2.Size = new Size(71, 16);
            label2.TabIndex = 612;
            label2.Text = "GTIN/EAN";
            // 
            // txtFornecedor
            // 
            txtFornecedor.Location = new Point(90, 137);
            txtFornecedor.Name = "txtFornecedor";
            txtFornecedor.Size = new Size(550, 24);
            txtFornecedor.StateCommon.Back.Color1 = Color.White;
            txtFornecedor.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtFornecedor.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtFornecedor.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtFornecedor.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtFornecedor.StateCommon.Border.Rounding = 8F;
            txtFornecedor.StateCommon.Border.Width = 1;
            txtFornecedor.StateCommon.Content.Color1 = Color.Gray;
            txtFornecedor.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtFornecedor.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtFornecedor.TabIndex = 4;
            txtFornecedor.TextChanged += txtFornecedor_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.25F);
            label3.ForeColor = Color.FromArgb(0, 76, 172);
            label3.Location = new Point(90, 118);
            label3.Name = "label3";
            label3.Size = new Size(77, 16);
            label3.TabIndex = 614;
            label3.Text = "Fornecedor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.25F);
            label6.ForeColor = Color.FromArgb(0, 76, 172);
            label6.Location = new Point(167, 213);
            label6.Name = "label6";
            label6.Size = new Size(91, 16);
            label6.TabIndex = 626;
            label6.Text = "DataValidade";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(318, 90);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(206, 24);
            txtMarca.StateCommon.Back.Color1 = Color.White;
            txtMarca.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtMarca.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtMarca.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtMarca.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtMarca.StateCommon.Border.Rounding = 8F;
            txtMarca.StateCommon.Border.Width = 1;
            txtMarca.StateCommon.Content.Color1 = Color.Gray;
            txtMarca.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtMarca.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtMarca.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.25F);
            label7.ForeColor = Color.FromArgb(0, 76, 172);
            label7.Location = new Point(319, 71);
            label7.Name = "label7";
            label7.Size = new Size(45, 16);
            label7.TabIndex = 624;
            label7.Text = "Marca";
            // 
            // txtUnidade
            // 
            txtUnidade.Location = new Point(527, 90);
            txtUnidade.Name = "txtUnidade";
            txtUnidade.Size = new Size(150, 24);
            txtUnidade.StateCommon.Back.Color1 = Color.White;
            txtUnidade.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtUnidade.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtUnidade.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtUnidade.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtUnidade.StateCommon.Border.Rounding = 8F;
            txtUnidade.StateCommon.Border.Width = 1;
            txtUnidade.StateCommon.Content.Color1 = Color.Gray;
            txtUnidade.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtUnidade.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtUnidade.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 9.25F);
            label12.ForeColor = Color.FromArgb(0, 76, 172);
            label12.Location = new Point(528, 71);
            label12.Name = "label12";
            label12.Size = new Size(59, 16);
            label12.TabIndex = 620;
            label12.Text = "Unidade";
            // 
            // btnLocalizarImagem
            // 
            btnLocalizarImagem.CornerRoundingRadius = 10F;
            btnLocalizarImagem.Location = new Point(438, 330);
            btnLocalizarImagem.Name = "btnLocalizarImagem";
            btnLocalizarImagem.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnLocalizarImagem.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnLocalizarImagem.OverrideDefault.Back.ColorAngle = 45F;
            btnLocalizarImagem.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnLocalizarImagem.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLocalizarImagem.OverrideDefault.Border.ColorAngle = 45F;
            btnLocalizarImagem.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLocalizarImagem.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLocalizarImagem.OverrideDefault.Border.Rounding = 20F;
            btnLocalizarImagem.OverrideDefault.Border.Width = 1;
            btnLocalizarImagem.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnLocalizarImagem.Size = new Size(30, 29);
            btnLocalizarImagem.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnLocalizarImagem.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnLocalizarImagem.StateCommon.Back.ColorAngle = 45F;
            btnLocalizarImagem.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnLocalizarImagem.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLocalizarImagem.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLocalizarImagem.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLocalizarImagem.StateCommon.Border.Rounding = 10F;
            btnLocalizarImagem.StateCommon.Border.Width = 1;
            btnLocalizarImagem.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnLocalizarImagem.StateCommon.Content.ShortText.Color2 = Color.White;
            btnLocalizarImagem.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLocalizarImagem.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnLocalizarImagem.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnLocalizarImagem.StatePressed.Back.ColorAngle = 135F;
            btnLocalizarImagem.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnLocalizarImagem.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnLocalizarImagem.StatePressed.Border.ColorAngle = 135F;
            btnLocalizarImagem.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLocalizarImagem.StatePressed.Border.Rounding = 20F;
            btnLocalizarImagem.StatePressed.Border.Width = 1;
            btnLocalizarImagem.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnLocalizarImagem.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnLocalizarImagem.StateTracking.Back.ColorAngle = 45F;
            btnLocalizarImagem.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnLocalizarImagem.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLocalizarImagem.StateTracking.Border.ColorAngle = 45F;
            btnLocalizarImagem.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLocalizarImagem.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLocalizarImagem.StateTracking.Border.Rounding = 20F;
            btnLocalizarImagem.StateTracking.Border.Width = 1;
            btnLocalizarImagem.StateTracking.Content.ShortText.Color1 = Color.White;
            btnLocalizarImagem.TabIndex = 12;
            btnLocalizarImagem.TabStop = false;
            btnLocalizarImagem.Values.Image = Properties.Resources.Pesquisar;
            btnLocalizarImagem.Values.Text = "";
            btnLocalizarImagem.Click += btnLocalizarImagem_Click;
            // 
            // txtEnderecoImagem
            // 
            txtEnderecoImagem.Location = new Point(10, 334);
            txtEnderecoImagem.Name = "txtEnderecoImagem";
            txtEnderecoImagem.Size = new Size(426, 24);
            txtEnderecoImagem.StateCommon.Back.Color1 = Color.White;
            txtEnderecoImagem.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtEnderecoImagem.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtEnderecoImagem.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtEnderecoImagem.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtEnderecoImagem.StateCommon.Border.Rounding = 8F;
            txtEnderecoImagem.StateCommon.Border.Width = 1;
            txtEnderecoImagem.StateCommon.Content.Color1 = Color.Gray;
            txtEnderecoImagem.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtEnderecoImagem.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtEnderecoImagem.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.25F);
            label4.ForeColor = Color.FromArgb(0, 76, 172);
            label4.Location = new Point(10, 315);
            label4.Name = "label4";
            label4.Size = new Size(137, 16);
            label4.TabIndex = 1021;
            label4.Text = "Endereço da imagem";
            // 
            // btnLocalizarFornecedor
            // 
            btnLocalizarFornecedor.CornerRoundingRadius = 10F;
            btnLocalizarFornecedor.Location = new Point(646, 133);
            btnLocalizarFornecedor.Name = "btnLocalizarFornecedor";
            btnLocalizarFornecedor.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnLocalizarFornecedor.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnLocalizarFornecedor.OverrideDefault.Back.ColorAngle = 45F;
            btnLocalizarFornecedor.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnLocalizarFornecedor.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLocalizarFornecedor.OverrideDefault.Border.ColorAngle = 45F;
            btnLocalizarFornecedor.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLocalizarFornecedor.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLocalizarFornecedor.OverrideDefault.Border.Rounding = 20F;
            btnLocalizarFornecedor.OverrideDefault.Border.Width = 1;
            btnLocalizarFornecedor.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnLocalizarFornecedor.Size = new Size(30, 29);
            btnLocalizarFornecedor.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnLocalizarFornecedor.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnLocalizarFornecedor.StateCommon.Back.ColorAngle = 45F;
            btnLocalizarFornecedor.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnLocalizarFornecedor.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLocalizarFornecedor.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLocalizarFornecedor.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLocalizarFornecedor.StateCommon.Border.Rounding = 10F;
            btnLocalizarFornecedor.StateCommon.Border.Width = 1;
            btnLocalizarFornecedor.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnLocalizarFornecedor.StateCommon.Content.ShortText.Color2 = Color.White;
            btnLocalizarFornecedor.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLocalizarFornecedor.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnLocalizarFornecedor.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnLocalizarFornecedor.StatePressed.Back.ColorAngle = 135F;
            btnLocalizarFornecedor.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnLocalizarFornecedor.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnLocalizarFornecedor.StatePressed.Border.ColorAngle = 135F;
            btnLocalizarFornecedor.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLocalizarFornecedor.StatePressed.Border.Rounding = 20F;
            btnLocalizarFornecedor.StatePressed.Border.Width = 1;
            btnLocalizarFornecedor.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnLocalizarFornecedor.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnLocalizarFornecedor.StateTracking.Back.ColorAngle = 45F;
            btnLocalizarFornecedor.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnLocalizarFornecedor.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLocalizarFornecedor.StateTracking.Border.ColorAngle = 45F;
            btnLocalizarFornecedor.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLocalizarFornecedor.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLocalizarFornecedor.StateTracking.Border.Rounding = 20F;
            btnLocalizarFornecedor.StateTracking.Border.Width = 1;
            btnLocalizarFornecedor.StateTracking.Content.ShortText.Color1 = Color.White;
            btnLocalizarFornecedor.TabIndex = 40;
            btnLocalizarFornecedor.TabStop = false;
            btnLocalizarFornecedor.Values.Image = Properties.Resources.Pesquisar;
            btnLocalizarFornecedor.Values.Text = "";
            btnLocalizarFornecedor.Click += btnLocalizarFornecedor_Click;
            // 
            // cmbSituacao
            // 
            cmbSituacao.CornerRoundingRadius = 8F;
            cmbSituacao.DropDownWidth = 115;
            cmbSituacao.IntegralHeight = false;
            cmbSituacao.Items.AddRange(new object[] { "Ativo", "Inativo" });
            cmbSituacao.Location = new Point(161, 282);
            cmbSituacao.Name = "cmbSituacao";
            cmbSituacao.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            cmbSituacao.Size = new Size(145, 27);
            cmbSituacao.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbSituacao.StateCommon.ComboBox.Border.Rounding = 8F;
            cmbSituacao.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbSituacao.TabIndex = 1026;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9.25F);
            label10.ForeColor = Color.FromArgb(0, 76, 172);
            label10.Location = new Point(161, 263);
            label10.Name = "label10";
            label10.Size = new Size(60, 16);
            label10.TabIndex = 1025;
            label10.Text = "Situação";
            // 
            // txtDataValidade
            // 
            txtDataValidade.Location = new Point(161, 232);
            txtDataValidade.Name = "txtDataValidade";
            txtDataValidade.Size = new Size(150, 24);
            txtDataValidade.StateCommon.Back.Color1 = Color.White;
            txtDataValidade.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtDataValidade.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtDataValidade.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtDataValidade.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtDataValidade.StateCommon.Border.Rounding = 8F;
            txtDataValidade.StateCommon.Border.Width = 1;
            txtDataValidade.StateCommon.Content.Color1 = Color.Gray;
            txtDataValidade.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtDataValidade.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtDataValidade.TabIndex = 9;
            txtDataValidade.TextChanged += txtDataValidade_TextChanged;
            txtDataValidade.Leave += txtDataValidade_Leave;
            // 
            // txtFornecedorID
            // 
            txtFornecedorID.Location = new Point(10, 135);
            txtFornecedorID.Name = "txtFornecedorID";
            txtFornecedorID.ReadOnly = true;
            txtFornecedorID.Size = new Size(73, 24);
            txtFornecedorID.StateCommon.Back.Color1 = Color.White;
            txtFornecedorID.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtFornecedorID.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtFornecedorID.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtFornecedorID.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtFornecedorID.StateCommon.Border.Rounding = 8F;
            txtFornecedorID.StateCommon.Border.Width = 1;
            txtFornecedorID.StateCommon.Content.Color1 = Color.Gray;
            txtFornecedorID.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtFornecedorID.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtFornecedorID.TabIndex = 1028;
            txtFornecedorID.TabStop = false;
            txtFornecedorID.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 76, 172);
            label5.Location = new Point(10, 116);
            label5.Name = "label5";
            label5.Size = new Size(57, 16);
            label5.TabIndex = 1027;
            label5.Text = "Código";
            // 
            // FrmCadProdutos
            // 
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(688, 414);
            Controls.Add(txtFornecedorID);
            Controls.Add(label5);
            Controls.Add(txtDataValidade);
            Controls.Add(cmbSituacao);
            Controls.Add(label10);
            Controls.Add(btnLocalizarFornecedor);
            Controls.Add(txtEnderecoImagem);
            Controls.Add(label4);
            Controls.Add(btnLocalizarImagem);
            Controls.Add(label6);
            Controls.Add(txtMarca);
            Controls.Add(label7);
            Controls.Add(txtUnidade);
            Controls.Add(label12);
            Controls.Add(txtFornecedor);
            Controls.Add(label3);
            Controls.Add(txtGtinEan);
            Controls.Add(label2);
            Controls.Add(pbImagem);
            Controls.Add(cmbStatus);
            Controls.Add(txtEstoque);
            Controls.Add(txtPrecoDeVenda);
            Controls.Add(txtProdutoID);
            Controls.Add(label23);
            Controls.Add(txtLucro);
            Controls.Add(txtPrecoCusto);
            Controls.Add(label1);
            Controls.Add(txtReferencia);
            Controls.Add(txtNomeProduto);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(btnSair);
            Controls.Add(btnNovo);
            Controls.Add(btnSalva);
            Controls.Add(label21);
            Controls.Add(label25);
            Controls.Add(label27);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCadProdutos";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Produtos";
            Load += FrmCadProdutos_Load;
            Shown += FrmCadProdutos_Shown;
            ((System.ComponentModel.ISupportInitialize)cmbStatus).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbImagem).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbSituacao).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        public Krypton.Toolkit.KryptonButton btnSair;
        public Krypton.Toolkit.KryptonButton btnNovo;
        public Krypton.Toolkit.KryptonButton btnSalva;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label27;
        public Krypton.Toolkit.KryptonTextBox txtProdutoID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        public Krypton.Toolkit.KryptonDateTimePicker dtpDataDeEntrada;
        public Krypton.Toolkit.KryptonTextBox txtEstoque;
        public Krypton.Toolkit.KryptonTextBox txtPrecoDeVenda;
        public Krypton.Toolkit.KryptonTextBox txtLucro;
        public Krypton.Toolkit.KryptonTextBox txtPrecoCusto;
        public Krypton.Toolkit.KryptonTextBox txtReferencia;
        public Krypton.Toolkit.KryptonTextBox txtNomeProduto;
        public Krypton.Toolkit.KryptonTextBox txtGtinEan;
        public Krypton.Toolkit.KryptonTextBox txtUnidade;
        public Krypton.Toolkit.KryptonTextBox txtMarca;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        public Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Label label2;
        public Krypton.Toolkit.KryptonTextBox txtFornecedor;
        private Label label3;
        private Label label6;        
        private Label label7;
        public Krypton.Toolkit.KryptonTextBox kryptonTextBox7;
        public Krypton.Toolkit.KryptonTextBox kryptonTextBox8;
        private Label label12;
        public Krypton.Toolkit.KryptonButton btnLocalizarImagem;
        public Krypton.Toolkit.KryptonTextBox txtEnderecoImagem;
        private Label label4;
        public Krypton.Toolkit.KryptonButton btnLocalizarFornecedor;
        private Label label10;
        public Krypton.Toolkit.KryptonTextBox txtDataValidade;
        public Krypton.Toolkit.KryptonComboBox cmbStatus;
        public PictureBox pbImagem;
        public Krypton.Toolkit.KryptonComboBox cmbSituacao;
        public Krypton.Toolkit.KryptonTextBox txtFornecedorID;
        private Label label5;
        //private System.Windows.Forms.DateTimePicker dtpDataDeEntrada;
    }
}
