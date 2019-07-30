using CadastroDeAlunos.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDeAlunos
{
    public partial class TabelaDeCadastro : Form
    {
        public TabelaDeCadastro()
        {
            InitializeComponent();
        }
        public Alunos novoAluno = new Alunos();

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            novoAluno.Aluno = txtNome.Text;
            novoAluno.Idade = (int)nrIdade.Value;

            this.Close();
        }

        private void NrIdade_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
