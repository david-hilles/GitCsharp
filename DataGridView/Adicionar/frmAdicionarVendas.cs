using DataGridView.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView.Adicionar
{
    public partial class frmAdicionarVendas : Form
    {
        public frmAdicionarVendas()
        {
            InitializeComponent();
        }
        public Venda vendasRow;

        private void Button1_Click(object sender, EventArgs e)
        {
            decimal.TryParse(textBox1.Text, out decimal valor);
            vendasRow = new Venda
            {
                Nomecarros = (int)comboBox1.SelectedValue,
                Quantidade = (int)numericUpDown1.Value,
                Valor = valor

            };
            this.Close();

        }

        private void FrmAdicionarVendas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'querysInnerJoinDataSet1.Carros'. Você pode movê-la ou removê-la conforme necessário.
            this.carrosTableAdapter.Fill(this.querysInnerJoinDataSet1.Carros);

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
