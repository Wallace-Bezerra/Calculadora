using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class fmr_Calculadora : Form
    {
        double ValorAnterior;
        string operacao;
        bool primeiraoperacao = true;
        double resultado;
        public fmr_Calculadora()
        {
            InitializeComponent();
        }

        private void Clicou_Click(object sender, EventArgs e)
        {
           
            Button botaoApertado = (Button)sender;

            if (txt_visor.Text == "0")
            {
                txt_visor.Clear();
            }
            switch (botaoApertado.Name)
            {
                case "button_1":
                    txt_visor.AppendText("1");
                        break;
                case "button_2":
                    txt_visor.Text += "2";
                    break;
                case "button_3":
                    txt_visor.Text += "3";
                    break;
                case "button_4":
                    txt_visor.Text += "4";
                    break;
                case "button_5":
                    txt_visor.Text += "5";
                    break;
                case "button_6":
                    txt_visor.Text += "6";
                    break;
                case "button_7":
                    txt_visor.Text += "7";
                    break;
                case "button_8":
                    txt_visor.Text += "8";
                    break;
                case "button_9":
                    txt_visor.Text += "9";
                    break;
                case "button_0":
                    txt_visor.Text += "0";
                    break;
                case "button_virgula":
                    if(txt_visor.Text == "")
                    {
                        txt_visor.Text += "0,";
                    }
                    else
                    {
                        txt_visor.Text += ",";
                    }
                    break;

            }

        }

        private void button_Limpar_Click(object sender, EventArgs e)
        {
            
            
            txt_visor.Clear();
            txt_Historico.Clear();
            txt_visor.Text = "0";
            ValorAnterior = 0;
            primeiraoperacao = true;
            
        }

        private void button_Backespace_Click(object sender, EventArgs e)
        {
            if (txt_visor.Text != "")
            {

                txt_visor.Text = txt_visor.Text.Remove(txt_visor.Text.Length - 1);
            }
            
        }
        // Codigo acima ok

        /////////////////////////////////////////////////////////////////////////////


        //SOMA+++++++++++++++++++++++++++++++++++++++++++
        private void button_Somar_Click(object sender, EventArgs e)
        {
            double calculoAnterior;
            if (txt_visor.Text != "")
            {
                if (primeiraoperacao == true)
                {
                    ValorAnterior = double.Parse(txt_visor.Text);
                    txt_Historico.Text += txt_visor.Text + "+";
                    txt_visor.Clear();
                    operacao = "+";
                    primeiraoperacao = false;
                }
                else if (operacao == "√")
                {
                    double valorRaiz = double.Parse(txt_visor.Text);
                    txt_visor.Clear();
                    txt_Historico.Text =  valorRaiz + "+";
                    
                    ValorAnterior = valorRaiz;
                    operacao = "+";

                }

                else
                {
                    calculoAnterior = Calculo();

                    txt_Historico.Text = Convert.ToString(calculoAnterior) + "+";
                    txt_visor.Clear();
                    ValorAnterior = calculoAnterior;
                    operacao = "+";
                }
            }
        }

        // SUBTRAIR --------------------------------------------------
        private void button_Subtrair_Click(object sender, EventArgs e)
        {
            if (txt_visor.Text != "")
            {
                if (primeiraoperacao == true)
                {
                    ValorAnterior = double.Parse(txt_visor.Text);
                    txt_Historico.Text += txt_visor.Text + "-";
                    txt_visor.Clear();
                    operacao = "-";
                    primeiraoperacao = false;
                }
                else if (operacao == "√")
                {
                    double valorRaiz = double.Parse(txt_visor.Text);
                    txt_visor.Clear();
                    txt_Historico.Text = valorRaiz + "-";

                    ValorAnterior = valorRaiz;
                    operacao = "-";

                }
                else
                {

                    double calculoAnterior = Calculo();

                    txt_Historico.Text = Convert.ToString(calculoAnterior) + "-";
                    txt_visor.Clear();
                    ValorAnterior = calculoAnterior;
                    operacao = "-";
                }
            }
        }

        //MULTIPLICAR XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
        private void button_Multiplicar_Click(object sender, EventArgs e)
        {
            if(txt_visor.Text != "")
            {
                if (primeiraoperacao == true)
                {
                    ValorAnterior = double.Parse(txt_visor.Text);
                    txt_Historico.Text = txt_visor.Text + "x";
                    txt_visor.Clear();
                    operacao = "x";
                    primeiraoperacao = false;

                }
                else if (operacao == "√")
                {
                    double valorRaiz = double.Parse(txt_visor.Text);
                    txt_visor.Clear();
                    txt_Historico.Text = valorRaiz + "x";

                    ValorAnterior = valorRaiz;
                    operacao = "x";

                }
                else
                {
                    double calculoAnterior = Calculo();

                    txt_Historico.Text = Convert.ToString(calculoAnterior) + "x";
                    txt_visor.Clear();
                    ValorAnterior = calculoAnterior;
                    operacao = "x";
                }

            }
        }

        private void button_Divisao_Click(object sender, EventArgs e)
        {
            if (txt_visor.Text != "")
            {
                if (primeiraoperacao == true)
                {
                    ValorAnterior = double.Parse(txt_visor.Text);
                    txt_Historico.Text = txt_visor.Text + "/";
                    txt_visor.Clear();
                    operacao = "/";
                    primeiraoperacao = false;

                }
                else if (operacao == "√")
                {
                    double valorRaiz = double.Parse(txt_visor.Text);
                    txt_visor.Clear();
                    txt_Historico.Text = valorRaiz + "/";

                    ValorAnterior = valorRaiz;
                    operacao = "/";

                }
                else
                {
                    double calculoAnterior = Calculo();

                    txt_Historico.Text = Convert.ToString(calculoAnterior) + "/";
                    txt_visor.Clear();
                    ValorAnterior = calculoAnterior;
                    operacao = "/";
                }

            }
        }

        private void button_Raiz_Click(object sender, EventArgs e)
        {
            if (txt_visor.Text != "")
            {
                if (primeiraoperacao == true)
                {
                    ValorAnterior = double.Parse(txt_visor.Text);
                    txt_Historico.Text = "Raiz " + txt_visor.Text;
                    operacao = "√";
                    txt_visor.Text = Convert.ToString(Calculo());
                    
                    primeiraoperacao = false;

                }
                else
                {
                    double calculoAnterior = Calculo();

                    txt_Historico.Text = "Raiz " + calculoAnterior;
                    txt_visor.Text = Convert.ToString(Math.Sqrt(calculoAnterior));
                    ValorAnterior = double.Parse(txt_visor.Text);
                    operacao = "√";
                }

            }
        }

        private void button_Igual_Click(object sender, EventArgs e)
        {
            
            
                txt_visor.Text = Convert.ToString(Calculo());
                txt_Historico.Clear();
                primeiraoperacao = true;
                
            
        }




        public double Calculo()
        {
            double Valor = double.Parse(txt_visor.Text);
            switch (operacao)
            {
                case "+":
                     resultado = ValorAnterior + Valor;
                    break;
                case "-":
                    resultado = ValorAnterior - Valor;
                    break;
                case "x":
                    resultado = ValorAnterior * Valor;
                    break;
                case "/":
                    resultado = ValorAnterior / Valor;
                    break;
                case "√":
                    resultado = Math.Sqrt(double.Parse(txt_visor.Text));
                    break;
            }
            
            return resultado;
        }

        
    }
}
