using System;
using System.Windows.Forms;

namespace Cinemark
{
    public partial class Form1 : Form
    {
        Button[] lugares = new Button[200];

        public Form1()
        {
            InitializeComponent();
            CriarAssentos();
        }

        private void CriarAssentos()
        {
            // Definindo o tamanho do botão e a margem entre eles
            int buttonWidth = 50;
            int buttonHeight = 30;
            int margin = 5;

            // Loop para criar os botões para cada fileira e coluna
            for (char row = 'A'; row <= 'J'; row++)
            {
                for (int col = 1; col <= 20; col++)
                {
                    int index = (row - 'A') * 20 + (col - 1);
                   
                    lugares[index] = new Button();
                    lugares[index].BackColor = Color.Green;
                    lugares[index].Text = $"{row}{col}";
                    lugares[index].Width = buttonWidth;
                    lugares[index].Height = buttonHeight;
                    lugares[index].Left = (col - 1) * (buttonWidth + margin);
                    lugares[index].Top = (row - 'A') * (buttonHeight + margin);
                    lugares[index].Click += new EventHandler(this.CliqueDoBotao);
                    Controls.Add(lugares[index]);
                }
            }
        }

        private void CliqueDoBotao(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            MessageBox.Show($"Você selecionou o assento: {clickedButton.Text}");

           

            if (clickedButton.BackColor == Color.Green)
            {
                DialogResult result = MessageBox.Show("Deseja Confirmar a reserva?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes){
                    clickedButton.BackColor = Color.Red;
                }
                else
                {
                    clickedButton.BackColor = Color.Green;
                }
 
            }
            else if (clickedButton.BackColor == Color.Red)
            {
                clickedButton.BackColor = Color.Green;
            }
            
              
        }

        private void btnFaturamento_Click(object sender, EventArgs e)
        {
            int faturamento = 0;

            
            for (int i = 0; i < lugares.Length; i++)
            {
                Button lugar = lugares[i];

                if (lugar.BackColor == Color.Red)
                {
                    faturamento += 20;
                }

               
            }

            MessageBox.Show("O faturamento total foi de $" + faturamento.ToString());
           
        }
    }
}
