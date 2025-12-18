namespace GVC
{
    partial class FrmBaixarConta
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
            label1 = new Label();
            txtParcelaID = new Krypton.Toolkit.KryptonTextBox();
            btnReceber = new Krypton.Toolkit.KryptonButton();
            btnSair = new Krypton.Toolkit.KryptonButton();
            txtValorParcela = new Krypton.Toolkit.KryptonTextBox();
            label2 = new Label();
            txtNumeroParcela = new Krypton.Toolkit.KryptonTextBox();
            label3 = new Label();
            label4 = new Label();
            txtValorPago = new Krypton.Toolkit.KryptonTextBox();
            label5 = new Label();
            dtpDataVencimento = new Krypton.Toolkit.KryptonDateTimePicker();
            dtpDataPagamento = new Krypton.Toolkit.KryptonDateTimePicker();
            label6 = new Label();
            txtSaldoRestante = new Krypton.Toolkit.KryptonTextBox();
            label7 = new Label();
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 15.25F);
            label1.Location = new Point(22, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 0;
            label1.Text = "Código:";
            // 
            // txtParcelaID
            // 
            txtParcelaID.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtParcelaID.Location = new Point(245, 28);
            txtParcelaID.Margin = new Padding(4, 3, 4, 3);
            txtParcelaID.Name = "txtParcelaID";
            txtParcelaID.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue;
            txtParcelaID.ReadOnly = true;
            txtParcelaID.Size = new Size(156, 31);
            txtParcelaID.StateCommon.Back.Color1 = Color.White;
            txtParcelaID.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtParcelaID.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtParcelaID.StateCommon.Border.ColorAngle = 1F;
            txtParcelaID.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtParcelaID.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtParcelaID.StateCommon.Border.Rounding = 20F;
            txtParcelaID.StateCommon.Border.Width = 1;
            txtParcelaID.StateCommon.Content.Color1 = Color.Gray;
            txtParcelaID.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtParcelaID.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtParcelaID.TabIndex = 140;
            txtParcelaID.TextAlign = HorizontalAlignment.Center;
            // 
            // btnReceber
            // 
            btnReceber.CornerRoundingRadius = 20F;
            btnReceber.Location = new Point(252, 412);
            btnReceber.Margin = new Padding(4, 3, 4, 3);
            btnReceber.Name = "btnReceber";
            btnReceber.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnReceber.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnReceber.OverrideDefault.Back.ColorAngle = 45F;
            btnReceber.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnReceber.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnReceber.OverrideDefault.Border.ColorAngle = 45F;
            btnReceber.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnReceber.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnReceber.OverrideDefault.Border.Rounding = 20F;
            btnReceber.OverrideDefault.Border.Width = 1;
            btnReceber.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnReceber.Size = new Size(190, 50);
            btnReceber.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnReceber.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnReceber.StateCommon.Back.ColorAngle = 45F;
            btnReceber.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnReceber.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnReceber.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnReceber.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnReceber.StateCommon.Border.Rounding = 20F;
            btnReceber.StateCommon.Border.Width = 1;
            btnReceber.StateCommon.Content.ShortText.Color1 = Color.White;
            btnReceber.StateCommon.Content.ShortText.Color2 = Color.White;
            btnReceber.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReceber.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnReceber.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnReceber.StatePressed.Back.ColorAngle = 135F;
            btnReceber.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnReceber.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnReceber.StatePressed.Border.ColorAngle = 135F;
            btnReceber.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnReceber.StatePressed.Border.Rounding = 20F;
            btnReceber.StatePressed.Border.Width = 1;
            btnReceber.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnReceber.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnReceber.StateTracking.Back.ColorAngle = 45F;
            btnReceber.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnReceber.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnReceber.StateTracking.Border.ColorAngle = 45F;
            btnReceber.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnReceber.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnReceber.StateTracking.Border.Rounding = 20F;
            btnReceber.StateTracking.Border.Width = 1;
            btnReceber.TabIndex = 2;
            btnReceber.Values.Text = "&Receber";
            btnReceber.Click += btnReceber_Click;
            // 
            // btnSair
            // 
            btnSair.CornerRoundingRadius = 20F;
            btnSair.Location = new Point(483, 412);
            btnSair.Margin = new Padding(4, 3, 4, 3);
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
            btnSair.Size = new Size(190, 50);
            btnSair.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnSair.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnSair.StateCommon.Back.ColorAngle = 45F;
            btnSair.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSair.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSair.StateCommon.Border.Rounding = 20F;
            btnSair.StateCommon.Border.Width = 1;
            btnSair.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
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
            btnSair.StateTracking.Content.ShortText.Color1 = Color.White;
            btnSair.TabIndex = 3;
            btnSair.Values.Text = "&Sair";
            btnSair.Click += btnSair_Click;
            // 
            // txtValorParcela
            // 
            txtValorParcela.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtValorParcela.Location = new Point(245, 80);
            txtValorParcela.Margin = new Padding(4, 3, 4, 3);
            txtValorParcela.Name = "txtValorParcela";
            txtValorParcela.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue;
            txtValorParcela.ReadOnly = true;
            txtValorParcela.Size = new Size(442, 31);
            txtValorParcela.StateCommon.Back.Color1 = Color.White;
            txtValorParcela.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtValorParcela.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtValorParcela.StateCommon.Border.ColorAngle = 1F;
            txtValorParcela.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtValorParcela.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtValorParcela.StateCommon.Border.Rounding = 20F;
            txtValorParcela.StateCommon.Border.Width = 1;
            txtValorParcela.StateCommon.Content.Color1 = Color.Gray;
            txtValorParcela.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValorParcela.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtValorParcela.TabIndex = 140;
            txtValorParcela.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 15.25F);
            label2.Location = new Point(22, 81);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(177, 25);
            label2.TabIndex = 5;
            label2.Text = "Valor da Parcela:";
            // 
            // txtNumeroParcela
            // 
            txtNumeroParcela.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtNumeroParcela.Location = new Point(245, 183);
            txtNumeroParcela.Margin = new Padding(4, 3, 4, 3);
            txtNumeroParcela.Name = "txtNumeroParcela";
            txtNumeroParcela.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue;
            txtNumeroParcela.ReadOnly = true;
            txtNumeroParcela.Size = new Size(442, 31);
            txtNumeroParcela.StateCommon.Back.Color1 = Color.White;
            txtNumeroParcela.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtNumeroParcela.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtNumeroParcela.StateCommon.Border.ColorAngle = 1F;
            txtNumeroParcela.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtNumeroParcela.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtNumeroParcela.StateCommon.Border.Rounding = 20F;
            txtNumeroParcela.StateCommon.Border.Width = 1;
            txtNumeroParcela.StateCommon.Content.Color1 = Color.Gray;
            txtNumeroParcela.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumeroParcela.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtNumeroParcela.TabIndex = 143;
            txtNumeroParcela.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 15.25F);
            label3.Location = new Point(22, 185);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(150, 25);
            label3.TabIndex = 7;
            label3.Text = "Nº da Parcela:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 15.25F);
            label4.Location = new Point(22, 235);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(136, 25);
            label4.TabIndex = 9;
            label4.Text = "Data Vencto:";
            // 
            // txtValorPago
            // 
            txtValorPago.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtValorPago.Location = new Point(245, 283);
            txtValorPago.Margin = new Padding(4, 3, 4, 3);
            txtValorPago.Name = "txtValorPago";
            txtValorPago.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue;
            txtValorPago.Size = new Size(442, 31);
            txtValorPago.StateCommon.Back.Color1 = Color.White;
            txtValorPago.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtValorPago.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtValorPago.StateCommon.Border.ColorAngle = 1F;
            txtValorPago.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtValorPago.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtValorPago.StateCommon.Border.Rounding = 20F;
            txtValorPago.StateCommon.Border.Width = 1;
            txtValorPago.StateCommon.Content.Color1 = Color.Gray;
            txtValorPago.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValorPago.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtValorPago.TabIndex = 0;
            txtValorPago.Leave += txtValorPago_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 15.25F);
            label5.ForeColor = Color.LimeGreen;
            label5.Location = new Point(22, 285);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(165, 25);
            label5.TabIndex = 11;
            label5.Text = "Valor Recebido:";
            // 
            // dtpDataVencimento
            // 
            dtpDataVencimento.CornerRoundingRadius = -1F;
            dtpDataVencimento.Format = DateTimePickerFormat.Short;
            dtpDataVencimento.Location = new Point(245, 235);
            dtpDataVencimento.Margin = new Padding(4, 3, 4, 3);
            dtpDataVencimento.Name = "dtpDataVencimento";
            dtpDataVencimento.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue;
            dtpDataVencimento.Size = new Size(156, 25);
            dtpDataVencimento.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            dtpDataVencimento.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            dtpDataVencimento.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpDataVencimento.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDataVencimento.TabIndex = 605;
            dtpDataVencimento.TabStop = false;
            // 
            // dtpDataPagamento
            // 
            dtpDataPagamento.CornerRoundingRadius = -1F;
            dtpDataPagamento.Format = DateTimePickerFormat.Short;
            dtpDataPagamento.Location = new Point(245, 335);
            dtpDataPagamento.Margin = new Padding(4, 3, 4, 3);
            dtpDataPagamento.Name = "dtpDataPagamento";
            dtpDataPagamento.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue;
            dtpDataPagamento.Size = new Size(156, 25);
            dtpDataPagamento.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            dtpDataPagamento.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            dtpDataPagamento.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpDataPagamento.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDataPagamento.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 15.25F);
            label6.ForeColor = Color.LimeGreen;
            label6.Location = new Point(22, 335);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(113, 25);
            label6.TabIndex = 606;
            label6.Text = "Data Pgto:";
            // 
            // txtSaldoRestante
            // 
            txtSaldoRestante.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtSaldoRestante.Location = new Point(245, 132);
            txtSaldoRestante.Margin = new Padding(4, 3, 4, 3);
            txtSaldoRestante.Name = "txtSaldoRestante";
            txtSaldoRestante.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue;
            txtSaldoRestante.ReadOnly = true;
            txtSaldoRestante.Size = new Size(442, 31);
            txtSaldoRestante.StateCommon.Back.Color1 = Color.White;
            txtSaldoRestante.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtSaldoRestante.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtSaldoRestante.StateCommon.Border.ColorAngle = 1F;
            txtSaldoRestante.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtSaldoRestante.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtSaldoRestante.StateCommon.Border.Rounding = 20F;
            txtSaldoRestante.StateCommon.Border.Width = 1;
            txtSaldoRestante.StateCommon.Content.Color1 = Color.Gray;
            txtSaldoRestante.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSaldoRestante.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtSaldoRestante.TabIndex = 607;
            txtSaldoRestante.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 15.25F);
            label7.Location = new Point(22, 130);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(165, 25);
            label7.TabIndex = 608;
            label7.Text = "Saldo Restante:";
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
            // FrmBaixarConta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(701, 510);
            Controls.Add(txtSaldoRestante);
            Controls.Add(label7);
            Controls.Add(dtpDataPagamento);
            Controls.Add(label6);
            Controls.Add(dtpDataVencimento);
            Controls.Add(txtValorPago);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtNumeroParcela);
            Controls.Add(label3);
            Controls.Add(txtValorParcela);
            Controls.Add(label2);
            Controls.Add(btnSair);
            Controls.Add(btnReceber);
            Controls.Add(txtParcelaID);
            Controls.Add(label1);
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmBaixarConta";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            StateActive.Back.Color1 = Color.White;
            StateActive.Back.Color2 = Color.White;
            StateActive.Border.Color1 = Color.White;
            StateActive.Border.Color2 = Color.White;
            StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            StateCommon.Back.Color1 = Color.White;
            StateCommon.Back.Color2 = Color.White;
            StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            StateCommon.Header.Back.Color1 = Color.White;
            StateCommon.Header.Back.Color2 = Color.White;
            Text = "Receber conta";
            KeyDown += FrmBaixarConta_KeyDown;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Krypton.Toolkit.KryptonTextBox txtParcelaID;
        private Krypton.Toolkit.KryptonButton btnReceber;
        private Krypton.Toolkit.KryptonButton btnSair;
        private Krypton.Toolkit.KryptonTextBox txtValorParcela;
        private System.Windows.Forms.Label label2;
        private Krypton.Toolkit.KryptonTextBox txtNumeroParcela;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Krypton.Toolkit.KryptonTextBox txtValorPago;
        private System.Windows.Forms.Label label5;
        private Krypton.Toolkit.KryptonDateTimePicker dtpDataVencimento;
        private Krypton.Toolkit.KryptonDateTimePicker dtpDataPagamento;
        private System.Windows.Forms.Label label6;
        private Krypton.Toolkit.KryptonTextBox txtSaldoRestante;
        private System.Windows.Forms.Label label7;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
    }
}