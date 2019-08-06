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
    public partial class frmEdicaoLocacoes : Form
    {
        public frmEdicaoLocacoes()
        {
            InitializeComponent();
        }
        public MVCProject.SistemaBibliotecaDBDataSet.LocacaoRow LocacaoRow;

        private void FrmEdicaoLocacoes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Livros'. Você pode movê-la ou removê-la conforme necessário.
            this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livros);

            comboBox1.SelectedValue = LocacaoRow.Livro;
            comboBox2.SelectedValue = LocacaoRow.Usuario;
            numericUpDown1.Value = LocacaoRow.Tipo;
            dateTimePicker1.Value = LocacaoRow.Devolucao;


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LocacaoRow.Livro = (int)comboBox1.SelectedValue;
            LocacaoRow.Usuario = (int)comboBox2.SelectedValue;
            LocacaoRow.Tipo = (int)numericUpDown1.Value;
            LocacaoRow.Devolucao = dateTimePicker1.Value;

            this.Close();

        }

    }
}
