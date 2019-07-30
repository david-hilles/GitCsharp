using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TabelaDeVIsualizacaoDeValores.Model;

namespace TabelaDeVIsualizacaoDeValores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Contrac> listContracs = new List<Contrac>();

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {

            listContracs.Add(new Contrac()
            {
                Id = listContracs.Count,
                value = new Random().Next(100),
                DatInc = DateTime.Now

            });

            var newList = new List<Contrac>();
            newList.AddRange(listContracs);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listContracs;
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1);
            {
                var collumId = dataGridView1.Rows[e.RowIndex].Cells[0];
                var collumValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }

        }
    }
}
