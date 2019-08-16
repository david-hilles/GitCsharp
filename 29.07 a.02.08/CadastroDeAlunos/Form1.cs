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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Alunos> aluno = new List<Alunos>();  
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            TabelaDeCadastro formCad = new TabelaDeCadastro();
            formCad.ShowDialog();
            aluno.Add(formCad.novoAluno);

        }
    }
}
