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
    public partial class frmEdicaoLivros : Form
    {
        public frmEdicaoLivros()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.LivrosRow LivrosRow;

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmEdicaoLivros_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Editoras'. Você pode movê-la ou removê-la conforme necessário.
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Generos'. Você pode movê-la ou removê-la conforme necessário.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);

            numericUpDown1.Value = LivrosRow.Registro;
            textBox2.Text = LivrosRow.TItulo;
            textBox6.Text = LivrosRow.Isbn;
            comboBox1.SelectedValue = LivrosRow.Genero;
            comboBox2.SelectedValue = LivrosRow.Editora;
            textBox1.Text = LivrosRow.Sinopse;
            textBox2.Text = LivrosRow.Observacoes;


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LivrosRow.Registro = (int)numericUpDown1.Value;
            LivrosRow.TItulo = textBox2.Text;
            LivrosRow.Isbn = textBox6.Text;
            LivrosRow.Genero = (int)comboBox1.SelectedValue;
            LivrosRow.Editora = (int)comboBox2.SelectedValue;
            LivrosRow.Sinopse = textBox1.Text;
            LivrosRow.Observacoes = textBox2.Text;


            this.Close();
        }
    }
}
