using MVCProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View.Adicionar
{
    public partial class frmAdicionarLivroAutor : Form
    {
        public frmAdicionarLivroAutor()
        {
            InitializeComponent();
        }
        public LivroAutor livroAutorRow;



        private void Button1_Click(object sender, EventArgs e)
        {
            livroAutorRow = new LivroAutor
            {
                Autor = (int)comboBox1.SelectedValue

            };
            this.Close();

        }
    }
}
