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
    public partial class frmEdicaoGeneros : Form
    {
        public frmEdicaoGeneros()
        {
            InitializeComponent();
        }
        public MVCProject.SistemaBibliotecaDBDataSet.GenerosRow GenerosRow;

        private void Button1_Click(object sender, EventArgs e)
        {
            GenerosRow.Tipo = textBox1.Text;
            GenerosRow.Descricao = textBox2.Text;

            this.Close();

        }

        private void FrmEdicaoGeneros_Load(object sender, EventArgs e)
        {
            textBox1.Text = GenerosRow.Tipo;
            textBox2.Text = GenerosRow.Descricao;

        }
    }
}
