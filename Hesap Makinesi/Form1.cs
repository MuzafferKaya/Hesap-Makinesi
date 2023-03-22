using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double sayi;
        public string buttonOperator;
        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string buttonText = clickedButton.Text;
            if(textBox1.Text == sayi.ToString())
            {
                textBox1.Text = buttonText;
            }
            else
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Text = buttonText;
                }
                else
                {
                    textBox1.Text += buttonText;
                }
            }
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            buttonOperator = clickedButton.Text;
            if(sayi != 0)
            {
                switch (buttonOperator)
                {
                    case "+":
                        sayi += Convert.ToDouble(textBox1.Text);
                        break;
                    case "-":
                        sayi -= Convert.ToDouble(textBox1.Text);
                        break;
                    case "÷":
                        sayi /= Convert.ToDouble(textBox1.Text);
                        break;
                    case "×":
                        sayi *= Convert.ToDouble(textBox1.Text);
                        break;
                }
                textBox1.Text = sayi.ToString();
            }
            else
            {
                sayi = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "0";
            } 
        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            switch (buttonOperator)
            {
                case "+":
                    sayi += Convert.ToDouble(textBox1.Text);
                    break;
                case "-":
                    sayi -= Convert.ToDouble(textBox1.Text);
                    break;
                case "÷":
                    sayi /= Convert.ToDouble(textBox1.Text);
                    break;
                case "×":
                    sayi *= Convert.ToDouble(textBox1.Text);
                    break;
            }
            textBox1.Text = sayi.ToString();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            sayi = 0;
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string değer = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            textBox1.Text = değer;
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }
    }
}
