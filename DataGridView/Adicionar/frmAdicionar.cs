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
    public partial class frmAdicionar : Form
    {
        public frmAdicionar()
        {
            InitializeComponent();
        }
        public Carro carrosRow;

        private void FrmAdicionar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'querysInnerJoinDataSet1.Marcas'. Você pode movê-la ou removê-la conforme necessário.
            this.marcasTableAdapter.Fill(this.querysInnerJoinDataSet1.Marcas);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            carrosRow = new Carro
            {
                Modelo = textBox1.Text,
                Ano = dateTimePicker1.Value,
                Marca = (int)comboBox1.SelectedValue,
            };

        }
    }

}
    
