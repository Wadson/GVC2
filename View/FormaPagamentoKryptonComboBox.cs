using Krypton.Toolkit;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaVendas.CustomControls
{
    public class FormaPagamentoKryptonComboBox : KryptonComboBox
    {
        public FormaPagamentoKryptonComboBox()
        {
            // Configurações básicas
            this.DrawMode = DrawMode.OwnerDrawFixed; // altura fixa
            this.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ItemHeight = 30; // altura dos itens
            this.StateCommon.ComboBox.Content.Font = new Font("Segoe UI", 10);
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            e.DrawBackground();

            if (e.Index >= 0 && e.Index < Items.Count)
            {
                if (Items[e.Index] is FormaPagamento forma)
                {
                    // Cor do texto
                    Brush brush = forma.Id == 0 ? Brushes.Gray : Brushes.Black;

                    // Ícone baseado na descrição
                    string icone = "";
                    Brush iconeBrush = Brushes.Black;

                    if (forma.Descricao.Contains("Dinheiro"))
                    {
                        icone = "💰";
                        iconeBrush = Brushes.Green;
                    }
                    else if (forma.Descricao.Contains("PIX"))
                    {
                        icone = "📱";
                        iconeBrush = Brushes.Blue;
                    }
                    else if (forma.Descricao.Contains("Cartão"))
                    {
                        icone = "💳";
                        iconeBrush = Brushes.Orange;
                    }

                    // Desenhar ícone
                    e.Graphics.DrawString(icone, this.StateCommon.ComboBox.Content.Font, iconeBrush,
                        e.Bounds.Left, e.Bounds.Top);

                    // Desenhar texto
                    e.Graphics.DrawString(forma.Descricao, this.StateCommon.ComboBox.Content.Font, brush,
                        e.Bounds.Left + 30, e.Bounds.Top);
                }
            }

            e.DrawFocusRectangle();
        }
    }

    // Classe auxiliar para representar forma de pagamento
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public override string ToString() => Descricao;
    }
}
