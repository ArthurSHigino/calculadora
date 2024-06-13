using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Calculadora_do_Arthur_Nova
{


    public partial class Form1 : Form
    {
        int casas_depois_virgula = 0;
        int tem_virgula = 0;
        double resultado = 0;
        string up = null;
        double un = 0;
        double auxiliar;
        NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;

        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Botão C Zera tudo
            textBox1.Text = "0";
            textBox2.Text = null;
            up = null;
            un = 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //botão inverter sinal
            textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * -1);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text += 0;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += 3;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += 4;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += 5;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += 6;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += 8;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += 9;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += 2;
            }
        }

        private void button_soma_Click(object sender, EventArgs e)
        {
            un = Convert.ToDouble(textBox1.Text);
            if (up == "+")
            {
                resultado = resultado + un;
                textBox2.Text += textBox1.Text + "+";
                textBox1.Text = null;
            }
            else if (up == "-")
            {
                resultado = resultado - un;
                textBox2.Text += textBox1.Text + "+";
                textBox1.Text = null;
            }
            else if (up == "x")
            {
                resultado = resultado * un;
                textBox2.Text += textBox1.Text + "+";
                textBox1.Text = null;
            }
            else if (up == "/")
            {
                resultado = resultado / un;
                textBox2.Text += textBox1.Text + "+";
                textBox1.Text = null;
            }
            else //se nao tiver nada é pq é a primeira entrada
            {
                
                resultado = Convert.ToDouble(textBox1.Text);
                textBox2.Text = textBox1.Text + "+";
                textBox1.Text = null;
            }

            up = "+";



        }

        private void button_igualdade_Click(object sender, EventArgs e)
        {
            
            un = Convert.ToDouble(textBox1.Text);
            if (up == "+")
            {
                resultado = resultado + un;
            }
            else if (up == "-")
            {
                resultado = resultado - un;
            }
            else if (up == "x")
            {
                resultado = resultado * un;
            }
            else if (up == "/")
            {
                resultado = resultado / un;
            }
            else //se nao tiver nada é pq é a primeira entrada
            {
                resultado = Convert.ToDouble(textBox1.Text);
            }
            textBox2.Text = null;
            textBox1.Text = Convert.ToString(resultado);
            un = 0;
            up = null;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += 7;
            }
        }

        //ta recebendo o resultado negativo
        private void button_subtração_Click(object sender, EventArgs e)
        {
            un = Convert.ToDouble(textBox1.Text);
            if (up == "+")
            {
                resultado = resultado + un;
                textBox2.Text += textBox1.Text + "-";
                textBox1.Text = null;
            }
            else if (up == "-")
            {
                resultado = resultado - un;
                textBox2.Text += textBox1.Text + "-";
                textBox1.Text = null;
            }
            else if (up == "x")
            {
                resultado = resultado * un;
                textBox2.Text += textBox1.Text + "-";
                textBox1.Text = null;
            }
            else if (up == "/")
            {
                resultado = resultado / un;
                textBox2.Text += textBox1.Text + "-";
                textBox1.Text = null;
            }
            else //se nao tiver nada é pq é a primeira entrada
            {
                resultado = Convert.ToDouble(textBox1.Text);
                textBox2.Text = textBox1.Text + "-";
                textBox1.Text = null;
            }

            up = "-";
        }

        private void button_multiplicação_Click(object sender, EventArgs e)
        {
            un = Convert.ToDouble(textBox1.Text);
            if (up == "+")
            {
                resultado = resultado + un;
                textBox2.Text += textBox1.Text + "×";
                textBox1.Text = null;
            }
            else if (up == "-")
            {
                resultado = resultado - un;
                textBox2.Text += textBox1.Text + "×";
                textBox1.Text = null;
            }
            else if (up == "x")
            {
                resultado = resultado * un;
                textBox2.Text += textBox1.Text + "×";
                textBox1.Text = null;
            }
            else if (up == "/")
            {
                resultado = resultado / un;
                textBox2.Text += textBox1.Text + "×";
                textBox1.Text = null;
            }
            else //se nao tiver nada é pq é a primeira entrada
            {
                resultado = Convert.ToDouble(textBox1.Text);
                textBox2.Text = textBox1.Text + "×";
                textBox1.Text = null;
            }

            up = "x";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if(textBox1.Text == "")
            {
                textBox1.Text = "0";
            }

            casas_depois_virgula = 0;
            tem_virgula = 0;
            char[] letras = textBox1.Text.ToCharArray();
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (letras[i] == ',')
                {
                    tem_virgula = 1;
                    casas_depois_virgula = textBox1.Text.Length - i;
                }

            }

            if(casas_depois_virgula > 1)
            {
                nfi.NumberDecimalDigits = casas_depois_virgula - 1;
            }
            else
            {
                nfi.NumberDecimalDigits = 0;
            }
            
            nfi.NumberDecimalSeparator = ",";
            nfi.NumberGroupSeparator = ".";
            auxiliar = Convert.ToDouble(textBox1.Text);
            textBox3.Text = auxiliar.ToString("N", nfi);
            
        }

        private void button_divisão_Click(object sender, EventArgs e)
        {
            un = Convert.ToDouble(textBox1.Text);
            if (up == "+")
            {
                resultado = resultado + un;
                textBox2.Text += textBox1.Text + "÷";
                textBox1.Text = null;
            }
            else if (up == "-")
            {
                resultado = resultado - un;
                textBox2.Text += textBox1.Text + "÷";
                textBox1.Text = null;
            }
            else if (up == "x")
            {
                resultado = resultado * un;
                textBox2.Text += textBox1.Text + "÷";
                textBox1.Text = null;
            }
            else if (up == "/")
            {
                resultado = resultado / un;
                textBox2.Text += textBox1.Text + "÷";
                textBox1.Text = null;
            }
            else //se nao tiver nada é pq é a primeira entrada
            {
                resultado = Convert.ToDouble(textBox1.Text);
                textBox2.Text = textBox1.Text + "÷";
                textBox1.Text = "0";
            }

            up = "/";
        }

        private void button_apagar_Click(object sender, EventArgs e)
        {
            string auxiliar = null;
            char[] letters = textBox1.Text.ToCharArray();
            for (int i = 0; i < textBox1.Text.Length - 1; i++)
            {
                auxiliar += letters[i];
            }
            textBox1.Text = auxiliar;
            auxiliar = null;

            
        }

        private void button_CE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button_virgula_Click(object sender, EventArgs e)
        {
            if(tem_virgula == 0)
            {
                textBox1.Text += ",";
                textBox3.Text += ",";
            }
            
        }

        private void button_raiz_Click(object sender, EventArgs e)
        {
            //raiz quadrada
            textBox1.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(textBox1.Text)));
        }

        private void button_exponencial_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text));
        }

        private void button_sobrefração_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(1/Convert.ToDouble(textBox1.Text));
        }

        private void button_porcentagem_Click(object sender, EventArgs e)
        {
            
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text)/100);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
