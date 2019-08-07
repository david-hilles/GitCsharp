using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFApp.Views
{
    /// <summary>
    /// Interação lógica para ucTaskbar.xam
    /// </summary>
    public partial class ucTaskbar : UserControl
    {
        double acumula = 0;
        string operacao = "";

        public ucTaskbar()

        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "7";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            display.Text += "8";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            display.Text += "9";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            display.Text += "4";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            display.Text += "5";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            display.Text += "6";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            display.Text += "1";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            display.Text += "2";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            display.Text += "3";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            //display.Text += "0";

        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            display.Text += "0";
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            display.Text = "";
            operacao = "";
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            if (operacao == "*" || operacao == "-" || operacao == "/")
            {
                operacao = "+";
            }
            else
            {
                acumula = double.Parse(display.Text);
                display.Text = "";
                operacao = "+";
            }


        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            if (operacao == "+")
            {
                acumula += double.Parse(display.Text);
                display.Text = acumula.ToString();
            }
            else if (operacao == "-")
            {
                acumula -= double.Parse(display.Text);
                display.Text = acumula.ToString();
            }
            else if (operacao == "*")
            {
                acumula *= double.Parse(display.Text);
                display.Text = acumula.ToString();
            }
            else if (operacao == "/")
            {
                if (double.Parse(display.Text) != 0)
                {
                    acumula /= double.Parse(display.Text);
                    display.Text = acumula.ToString();
                }
                else
                {
                    display.Text = "Dividindo por zero";
                }
            }



        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            if (operacao == "*" || operacao == "+" || operacao == "/")
            {
                operacao = "-";
            }
            else
            {
                acumula = double.Parse(display.Text);
                display.Text = "";
                operacao = "-";
            }


        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            if (operacao == "*" || operacao == "+" || operacao == "-")
            {
                operacao = "/";
            }
            else
            {
                acumula = double.Parse(display.Text);
                display.Text = "";
                operacao = "/";
            }


        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            if (operacao == "-" || operacao == "+" || operacao == "/")
            {
                operacao = "*";
            }
            else
            {
                acumula = double.Parse(display.Text);
                display.Text = "";
                operacao = "*";
            }

        }
    }
}
