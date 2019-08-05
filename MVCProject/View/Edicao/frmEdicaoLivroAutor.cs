using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View.Edicao
{
    public partial class frmEdicaoLivroAutor : Form
    {
        public frmEdicaoLivroAutor()
        {
            InitializeComponent();
        }
        public MVCProject.SistemaBibliotecaDBDataSet.LivroAutorRow LivroAutorRow;
        private void FrmEdicaoLivroAutor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Autores'. Você pode movê-la ou removê-la conforme necessário.
            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Autores);


            comboBox1.SelectedValue = LivroAutorRow.Autor;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LivroAutorRow.Autor = (int)comboBox1.SelectedValue;
          

            this.Close();

        }
    }
}
