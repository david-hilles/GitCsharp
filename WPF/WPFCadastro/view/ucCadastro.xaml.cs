using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WPFCadastro.view
{
    /// <summary>
    /// Interação lógica para ucCadastro.xam
    /// </summary>
    public partial class ucCadastro : UserControl
    {
        public ucCadastro()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var telefone = txtTelefone.Text;
            Regex rgPhone = new Regex("^\\+(?:[0-9] ?){6,14}[0-9]$");

            if (rgPhone.IsMatch(telefone))
            {
                MessageBox.Show("Telefone Valido!");
            }
            else
            {
                MessageBox.Show("Telefone Inválido!");
            }


            var email = txtEmail.Text;

            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (rg.IsMatch(email))
            {
                MessageBox.Show("Email Valido!");
            }
            else
            {
                MessageBox.Show("Email Inválido!");
            }


        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
