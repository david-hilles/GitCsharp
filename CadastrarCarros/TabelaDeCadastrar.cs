using CadastrarCarros.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastrarCarros
{
    public partial class TabelaDeCadastrar : Form
    {
        public TabelaDeCadastrar()
        {
            InitializeComponent();
        }
        public Carro novoCarro = new Carro();

        private void Button1_Click(object sender, EventArgs e)
        {
            novoCarro.Modelo = txtModelo.Text;
                novoCarro.Ano = (int)nrAno.Value;
            novoCarro.Placa = txtPlaca.Text;

            this.Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
