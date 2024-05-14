using System.Diagnostics;

namespace kalkulator_ebaniy
{
    public partial class Form1 : Form
    {
        private string num1;
        private string num2;
        private bool isfnum = true;
        private string mfsym;
        private string savetext;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Butclick(object sender, EventArgs e)
        {
            if (isfnum == true)
            {
                num1 += sender.ToSender();
                textBox1.Text = num1;
            }
            else
            {
                num2 += sender.ToSender();
                textBox1.Text = savetext + num2;
            }
        }

        private void butmf(object sender, EventArgs e)
        {
            isfnum = false;
            mfsym = sender.ToSender();
            textBox1.Text += " " + sender.ToSender() + " ";
            savetext = textBox1.Text;
        }

        private void clear(object sender, EventArgs e)
        {
            isfnum = true;
            num1 = "";
            num2 = "";
            textBox1.Text = "";
            mfsym = "";
            savetext = "";
        }
        private double result()
        {
            return mfsym switch
            {
                "+" => double.Parse(num1) + double.Parse(num2),
                "-" => double.Parse(num1) - double.Parse(num2),
                "/" => double.Parse(num1) / double.Parse(num2),
                "*" => double.Parse(num1) * double.Parse(num2),
                _ => 0
            };
        }

        private void equal(object sender, EventArgs e)
        {
            textBox1.Text += " = " + result().ToString();
        }

        private void butcor(object sender, EventArgs e)
        {
            int num = int.Parse(num1);
            for (int i = 0; i < num; i++)
            {
                if (i * i == num)
                {
                    textBox1.Text = i.ToString();
                    return;
                }
            }
            textBox1.Text = "нет числа";
        }

        private void Pizdanaxuiebanusablyt(object sender, EventArgs e)
        {
            int num = 0;
            for (int i = 0; i < 50; i++)
            {
                
            }
        }
    }
}
