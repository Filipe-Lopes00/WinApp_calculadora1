using System.Globalization;

namespace WinApp_calculadora1
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Resultado.Text += "3";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Resultado.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Resultado.Text += "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Resultado.Text += "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Resultado.Text += "2";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Resultado.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Resultado.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Resultado.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Resultado.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Resultado.Text += "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Resultado.Text != "")
            {
                Resultado.Text += ".";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (Resultado.Text != "")
            {
                valor1 = decimal.Parse(Resultado.Text, CultureInfo.InvariantCulture);
                Resultado.Text = "";
                operacao = "SOMA";
                lbloperacao.Text = "+";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (Resultado.Text != "")
            {
                valor2 = decimal.Parse(Resultado.Text, CultureInfo.InvariantCulture);
                if (operacao == "SOMA")
                {
                    Resultado.Text = Convert.ToString(valor1 + valor2);

                }
                else if (operacao == "SUBT")
                {
                    Resultado.Text = Convert.ToString(valor1 - valor2);
                }
                else if (operacao == "MULT")
                {
                    Resultado.Text = Convert.ToString(valor1 * valor2);
                }
                else
                {
                    Resultado.Text = Convert.ToString(valor1 / valor2);
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (Resultado.Text != "")
            {
                valor1 = decimal.Parse(Resultado.Text, CultureInfo.InvariantCulture);
                Resultado.Text = "";
                operacao = "SUBT";
                lbloperacao.Text = "-";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (Resultado.Text != "")
            {
                valor1 = decimal.Parse(Resultado.Text, CultureInfo.InvariantCulture);
                Resultado.Text = "";
                operacao = "MULT";
                lbloperacao.Text = "x";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (Resultado.Text != "")
            {
                valor1 = decimal.Parse(Resultado.Text, CultureInfo.InvariantCulture);
                Resultado.Text = "";
                operacao = "Div";
                lbloperacao.Text = "/";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (Resultado.Text != "")
            {
                Resultado.Text = "";
                lbloperacao.Text = "";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (Resultado.Text != "")
            {
                Resultado.Text = "";
                valor1 = 0;
                valor2 = 0;
                lbloperacao.Text = "";
            }


        }
    }
}