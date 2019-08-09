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
using WpfAppEntity.Data;

namespace WpfAppEntity.Views
{
    /// <summary>
    /// Interação lógica para ucLogin.xam
    /// </summary>
    public partial class ucLogin : UserControl
    {
        public ucLogin()
        {
            InitializeComponent();
        }
        // PRIMEIRO PASSO 
        public event EventHandler sucess;                         
        public event EventHandler fail;
        public BIbliotecaDBContext context = new BIbliotecaDBContext();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var userName = tbxLogin.Text;
            var userPass = tbxSenha.Password;

            var result = context.Usuarios.FirstOrDefault(x => x.Login == userName && x.Senha == userPass);

            if (result?.Id > 0)
                sucess("Usuario logado com sucesso!", new EventArgs());
            else
                fail($"Falha ao logar com usuario {userName}.", new EventArgs());

        }
    }
}
