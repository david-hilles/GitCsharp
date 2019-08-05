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

namespace MVCProject.View
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            if (Session.user == null)
                throw new Exception("Erro de critido sistema");
        }

        private void UsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios usuarios = new frmUsuarios();
            usuarios.ShowDialog();

        }

        private void AutosresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAutores autores = new frmAutores();
            autores.ShowDialog();
        }

        private void GenerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGeneros generos = new frmGeneros();
            generos.ShowDialog();

        }

        private void LocaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocações Locação = new frmLocações();
            Locação.ShowDialog();
        }

        private void EditorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditoras editoras = new frmEditoras();
            editoras.ShowDialog();
        }

        private void LocaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocações Locações = new frmLocações();
            Locações.ShowDialog();
        }

        private void LivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLivros livros = new frmLivros();
            livros.ShowDialog();
        }
    }
}
