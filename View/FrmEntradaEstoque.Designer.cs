namespace GVC.View
{
    partial class FrmEntradaEstoque
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
            txtQuantidade = new Krypton.Toolkit.KryptonTextBox();
            txtPrecoDeVenda = new Krypton.Toolkit.KryptonTextBox();
            txtLucro = new Krypton.Toolkit.KryptonTextBox();
            txtPrecoCusto = new Krypton.Toolkit.KryptonTextBox();
            txtReferencia = new Krypton.Toolkit.KryptonTextBox();
            txtNomeProduto = new Krypton.Toolkit.KryptonTextBox();
            label11 = new Label();
            label9 = new Label();
            label8 = new Label();
            label29 = new Label();
            txtProdutoID = new Krypton.Toolkit.KryptonTextBox();
            label23 = new Label();
            btnSair = new Krypton.Toolkit.KryptonButton();
            btnNovo = new Krypton.Toolkit.KryptonButton();
            btnSalva = new Krypton.Toolkit.KryptonButton();
            label21 = new Label();
            label25 = new Label();
            label27 = new Label();
            btnLocalizarProduto = new Krypton.Toolkit.KryptonButton();
            dtpDataDeEntrada = new Krypton.Toolkit.KryptonDateTimePicker();
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            SuspendLayout();
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(530, 201);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(130, 30);
            txtQuantidade.StateCommon.Back.Color1 = Color.White;
            txtQuantidade.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtQuantidade.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtQuantidade.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtQuantidade.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtQuantidade.StateCommon.Border.Rounding = 10F;
            txtQuantidade.StateCommon.Border.Width = 1;
            txtQuantidade.StateCommon.Content.Color1 = Color.Gray;
            txtQuantidade.StateCommon.Content.Font = new Font("Segoe UI", 12F);
            txtQuantidade.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtQuantidade.TabIndex = 606;
            txtQuantidade.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPrecoDeVenda
            // 
            txtPrecoDeVenda.Location = new Point(400, 201);
            txtPrecoDeVenda.Name = "txtPrecoDeVenda";
            txtPrecoDeVenda.Size = new Size(130, 30);
            txtPrecoDeVenda.StateCommon.Back.Color1 = Color.White;
            txtPrecoDeVenda.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtPrecoDeVenda.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtPrecoDeVenda.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtPrecoDeVenda.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtPrecoDeVenda.StateCommon.Border.Rounding = 10F;
            txtPrecoDeVenda.StateCommon.Border.Width = 1;
            txtPrecoDeVenda.StateCommon.Content.Color1 = Color.Gray;
            txtPrecoDeVenda.StateCommon.Content.Font = new Font("Segoe UI", 12F);
            txtPrecoDeVenda.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtPrecoDeVenda.TabIndex = 605;
            // 
            // txtLucro
            // 
            txtLucro.Location = new Point(270, 201);
            txtLucro.Name = "txtLucro";
            txtLucro.Size = new Size(130, 30);
            txtLucro.StateCommon.Back.Color1 = Color.White;
            txtLucro.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtLucro.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtLucro.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtLucro.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtLucro.StateCommon.Border.Rounding = 10F;
            txtLucro.StateCommon.Border.Width = 1;
            txtLucro.StateCommon.Content.Color1 = Color.Gray;
            txtLucro.StateCommon.Content.Font = new Font("Segoe UI", 12F);
            txtLucro.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtLucro.TabIndex = 604;
            // 
            // txtPrecoCusto
            // 
            txtPrecoCusto.Location = new Point(140, 201);
            txtPrecoCusto.Name = "txtPrecoCusto";
            txtPrecoCusto.Size = new Size(130, 30);
            txtPrecoCusto.StateCommon.Back.Color1 = Color.White;
            txtPrecoCusto.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtPrecoCusto.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtPrecoCusto.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtPrecoCusto.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtPrecoCusto.StateCommon.Border.Rounding = 10F;
            txtPrecoCusto.StateCommon.Border.Width = 1;
            txtPrecoCusto.StateCommon.Content.Color1 = Color.Gray;
            txtPrecoCusto.StateCommon.Content.Font = new Font("Segoe UI", 12F);
            txtPrecoCusto.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtPrecoCusto.TabIndex = 603;
            // 
            // txtReferencia
            // 
            txtReferencia.CharacterCasing = CharacterCasing.Upper;
            txtReferencia.Location = new Point(12, 201);
            txtReferencia.Name = "txtReferencia";
            txtReferencia.Size = new Size(130, 30);
            txtReferencia.StateCommon.Back.Color1 = Color.White;
            txtReferencia.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtReferencia.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtReferencia.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtReferencia.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtReferencia.StateCommon.Border.Rounding = 10F;
            txtReferencia.StateCommon.Border.Width = 1;
            txtReferencia.StateCommon.Content.Color1 = Color.Gray;
            txtReferencia.StateCommon.Content.Font = new Font("Segoe UI", 12F);
            txtReferencia.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtReferencia.TabIndex = 602;
            txtReferencia.Leave += txtReferencia_Leave;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.CharacterCasing = CharacterCasing.Upper;
            txtNomeProduto.Location = new Point(12, 136);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(618, 30);
            txtNomeProduto.StateCommon.Back.Color1 = Color.White;
            txtNomeProduto.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtNomeProduto.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtNomeProduto.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtNomeProduto.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtNomeProduto.StateCommon.Border.Rounding = 10F;
            txtNomeProduto.StateCommon.Border.Width = 1;
            txtNomeProduto.StateCommon.Content.Color1 = Color.Gray;
            txtNomeProduto.StateCommon.Content.Font = new Font("Segoe UI", 12F);
            txtNomeProduto.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtNomeProduto.TabIndex = 600;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F);
            label11.ForeColor = Color.FromArgb(0, 76, 172);
            label11.Location = new Point(530, 181);
            label11.Name = "label11";
            label11.Size = new Size(76, 17);
            label11.TabIndex = 619;
            label11.Text = "Quantidade";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F);
            label9.ForeColor = Color.FromArgb(0, 76, 172);
            label9.Location = new Point(400, 181);
            label9.Name = "label9";
            label9.Size = new Size(93, 17);
            label9.TabIndex = 618;
            label9.Text = "P. Venda ( R$ )";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F);
            label8.ForeColor = Color.FromArgb(0, 76, 172);
            label8.Location = new Point(270, 181);
            label8.Name = "label8";
            label8.Size = new Size(75, 17);
            label8.TabIndex = 617;
            label8.Text = "Lucro ( R$ )";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.BackColor = Color.Transparent;
            label29.Font = new Font("Segoe UI", 9.75F);
            label29.ForeColor = Color.FromArgb(0, 76, 172);
            label29.Location = new Point(556, 50);
            label29.Name = "label29";
            label29.Size = new Size(84, 17);
            label29.TabIndex = 246;
            label29.Text = "Data Entrada";
            // 
            // txtProdutoID
            // 
            txtProdutoID.Location = new Point(12, 69);
            txtProdutoID.Name = "txtProdutoID";
            txtProdutoID.ReadOnly = true;
            txtProdutoID.Size = new Size(90, 30);
            txtProdutoID.StateCommon.Back.Color1 = Color.White;
            txtProdutoID.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtProdutoID.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtProdutoID.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtProdutoID.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtProdutoID.StateCommon.Border.Rounding = 10F;
            txtProdutoID.StateCommon.Border.Width = 1;
            txtProdutoID.StateCommon.Content.Color1 = Color.Gray;
            txtProdutoID.StateCommon.Content.Font = new Font("Segoe UI", 12F);
            txtProdutoID.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtProdutoID.TabIndex = 243;
            txtProdutoID.TabStop = false;
            txtProdutoID.TextAlign = HorizontalAlignment.Center;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label23.ForeColor = Color.FromArgb(0, 76, 172);
            label23.Location = new Point(12, 50);
            label23.Name = "label23";
            label23.Size = new Size(51, 17);
            label23.TabIndex = 239;
            label23.Text = "Código";
            // 
            // btnSair
            // 
            btnSair.CornerRoundingRadius = 10F;
            btnSair.Location = new Point(560, 255);
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
            btnSair.TabIndex = 609;
            btnSair.Values.Text = "&Sair";
            btnSair.Click += btnSair_Click;
            // 
            // btnNovo
            // 
            btnNovo.CornerRoundingRadius = 10F;
            btnNovo.Location = new Point(452, 255);
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
            btnNovo.StateTracking.Content.ShortText.Color1 = Color.White;
            btnNovo.TabIndex = 608;
            btnNovo.Values.Text = "&Novo";
            btnNovo.Click += btnNovo_Click;
            // 
            // btnSalva
            // 
            btnSalva.CornerRoundingRadius = 10F;
            btnSalva.Location = new Point(344, 255);
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
            btnSalva.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnSalva.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnSalva.StateCommon.Back.ColorAngle = 45F;
            btnSalva.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSalva.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSalva.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSalva.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSalva.StateCommon.Border.Rounding = 10F;
            btnSalva.StateCommon.Border.Width = 1;
            btnSalva.StateCommon.Content.ShortText.Color1 = Color.White;
            btnSalva.StateCommon.Content.ShortText.Color2 = Color.White;
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
            btnSalva.TabIndex = 607;
            btnSalva.Values.Text = "Salvar";
            btnSalva.Click += btnSalva_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9.75F);
            label21.ForeColor = Color.FromArgb(0, 76, 172);
            label21.Location = new Point(12, 181);
            label21.Name = "label21";
            label21.Size = new Size(69, 17);
            label21.TabIndex = 612;
            label21.Text = "Referência";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 9.75F);
            label25.ForeColor = Color.FromArgb(0, 76, 172);
            label25.Location = new Point(12, 117);
            label25.Name = "label25";
            label25.Size = new Size(55, 17);
            label25.TabIndex = 611;
            label25.Text = "Produto";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 9.75F);
            label27.ForeColor = Color.FromArgb(0, 76, 172);
            label27.Location = new Point(140, 181);
            label27.Name = "label27";
            label27.Size = new Size(82, 17);
            label27.TabIndex = 613;
            label27.Text = "P. Custo R$ )";
            // 
            // btnLocalizarProduto
            // 
            btnLocalizarProduto.CornerRoundingRadius = 10F;
            btnLocalizarProduto.Location = new Point(636, 135);
            btnLocalizarProduto.Name = "btnLocalizarProduto";
            btnLocalizarProduto.OverrideDefault.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnLocalizarProduto.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnLocalizarProduto.OverrideDefault.Back.ColorAngle = 45F;
            btnLocalizarProduto.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnLocalizarProduto.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLocalizarProduto.OverrideDefault.Border.ColorAngle = 45F;
            btnLocalizarProduto.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLocalizarProduto.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLocalizarProduto.OverrideDefault.Border.Rounding = 20F;
            btnLocalizarProduto.OverrideDefault.Border.Width = 1;
            btnLocalizarProduto.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnLocalizarProduto.Size = new Size(37, 30);
            btnLocalizarProduto.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnLocalizarProduto.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnLocalizarProduto.StateCommon.Back.ColorAngle = 45F;
            btnLocalizarProduto.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnLocalizarProduto.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLocalizarProduto.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLocalizarProduto.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLocalizarProduto.StateCommon.Border.Rounding = 10F;
            btnLocalizarProduto.StateCommon.Border.Width = 1;
            btnLocalizarProduto.StateCommon.Content.ShortText.Color1 = Color.White;
            btnLocalizarProduto.StateCommon.Content.ShortText.Color2 = Color.White;
            btnLocalizarProduto.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnLocalizarProduto.StateDisabled.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnLocalizarProduto.StateDisabled.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnLocalizarProduto.StateDisabled.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnLocalizarProduto.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLocalizarProduto.StateDisabled.Content.ShortText.Color1 = Color.White;
            btnLocalizarProduto.StateNormal.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnLocalizarProduto.StateNormal.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnLocalizarProduto.StateNormal.Content.LongText.Color1 = Color.White;
            btnLocalizarProduto.StateNormal.Content.LongText.Color2 = Color.White;
            btnLocalizarProduto.StateNormal.Content.ShortText.Color1 = Color.White;
            btnLocalizarProduto.StateNormal.Content.ShortText.Color2 = Color.White;
            btnLocalizarProduto.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnLocalizarProduto.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnLocalizarProduto.StatePressed.Back.ColorAngle = 135F;
            btnLocalizarProduto.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnLocalizarProduto.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnLocalizarProduto.StatePressed.Border.ColorAngle = 135F;
            btnLocalizarProduto.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLocalizarProduto.StatePressed.Border.Rounding = 20F;
            btnLocalizarProduto.StatePressed.Border.Width = 1;
            btnLocalizarProduto.StatePressed.Content.LongText.Color1 = Color.White;
            btnLocalizarProduto.StatePressed.Content.LongText.Color2 = Color.White;
            btnLocalizarProduto.StatePressed.Content.ShortText.Color1 = Color.White;
            btnLocalizarProduto.StatePressed.Content.ShortText.Color2 = Color.White;
            btnLocalizarProduto.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnLocalizarProduto.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnLocalizarProduto.StateTracking.Back.ColorAngle = 45F;
            btnLocalizarProduto.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnLocalizarProduto.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLocalizarProduto.StateTracking.Border.ColorAngle = 45F;
            btnLocalizarProduto.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLocalizarProduto.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLocalizarProduto.StateTracking.Border.Rounding = 20F;
            btnLocalizarProduto.StateTracking.Border.Width = 1;
            btnLocalizarProduto.StateTracking.Content.ShortText.Color1 = Color.White;
            btnLocalizarProduto.TabIndex = 601;
            btnLocalizarProduto.Values.Image = Properties.Resources.Pesquisar;
            btnLocalizarProduto.Values.Text = "";
            btnLocalizarProduto.Click += btnLocalizarProduto_Click;
            // 
            // dtpDataDeEntrada
            // 
            dtpDataDeEntrada.CornerRoundingRadius = 10F;
            dtpDataDeEntrada.Format = DateTimePickerFormat.Short;
            dtpDataDeEntrada.Location = new Point(542, 69);
            dtpDataDeEntrada.Name = "dtpDataDeEntrada";
            dtpDataDeEntrada.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007SilverLightMode;
            dtpDataDeEntrada.Size = new Size(131, 26);
            dtpDataDeEntrada.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpDataDeEntrada.StateCommon.Border.Rounding = 10F;
            dtpDataDeEntrada.StateCommon.Border.Width = 1;
            dtpDataDeEntrada.StateCommon.Content.Font = new Font("Segoe UI", 8F);
            dtpDataDeEntrada.TabIndex = 1013;
            // 
            // FrmEntradaEstoque
            // 
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(685, 326);
            ControlBox = false;
            Controls.Add(label29);
            Controls.Add(dtpDataDeEntrada);
            Controls.Add(btnLocalizarProduto);
            Controls.Add(txtQuantidade);
            Controls.Add(txtPrecoDeVenda);
            Controls.Add(txtProdutoID);
            Controls.Add(label23);
            Controls.Add(txtLucro);
            Controls.Add(txtPrecoCusto);
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
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmEntradaEstoque";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Load += FrmEntradaEstoque_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        public Krypton.Toolkit.KryptonTextBox txtQuantidade;
        public Krypton.Toolkit.KryptonTextBox txtPrecoDeVenda;
        public Krypton.Toolkit.KryptonTextBox txtLucro;
        public Krypton.Toolkit.KryptonTextBox txtPrecoCusto;
        public Krypton.Toolkit.KryptonTextBox txtReferencia;
        public Krypton.Toolkit.KryptonTextBox txtNomeProduto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label29;
        public Krypton.Toolkit.KryptonTextBox txtProdutoID;
        private System.Windows.Forms.Label label23;
        public Krypton.Toolkit.KryptonButton btnSair;
        public Krypton.Toolkit.KryptonButton btnNovo;
        public Krypton.Toolkit.KryptonButton btnSalva;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label27;
        private Krypton.Toolkit.KryptonButton btnLocalizarProduto;
        private Krypton.Toolkit.KryptonDateTimePicker dtpDataDeEntrada;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
    }
}
