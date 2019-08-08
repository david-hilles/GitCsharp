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
using WPFAppNew.Data;

namespace WPFAppNew
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public BiblicotecaDBContext context;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            context = new BiblicotecaDBContext();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(context.Usuarios
                .OrderBy(x => x.Nome)
                 .FirstOrDefault(x => x.Id > 0).Nome);


            var runList = context.Usuarios
                .OrderBy(x => x.Nome).ToList<Usuario>();


            gridViwe1.ItemsSource = runList;

        }
    }
}
