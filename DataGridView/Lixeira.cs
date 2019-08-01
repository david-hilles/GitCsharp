using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class LixeiraUsuarios : Form
    {
        public LixeiraUsuarios()
        {
            InitializeComponent();
        }

        private void Lixeira_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'querysInnerJoinDataSet1.Carros'. Você pode movê-la ou removê-la conforme necessário.
           // this.carrosTableAdapter.Fill(this.querysInnerJoinDataSet1.Carros);
            // TODO: esta linha de código carrega dados na tabela 'querysInnerJoinDataSet1.DataTable1'. Você pode movê-la ou removê-la conforme necessário.
            this.carrosTableAdapter.RegistrosInativos(this.querysInnerJoinDataSet1.Carros);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             var carSelect = ((System.Data.DataRowView)
             this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
             as DataGridView.QuerysInnerJoinDataSet1.CarrosRow;
            switch (e.RowIndex)
            {
                case 0:
                    {
                        this.carrosTableAdapter.Restaurar(carSelect.Id);
                    }
                    break;
                        
            }

            this.carrosTableAdapter.RegistrosInativos(this.querysInnerJoinDataSet1.Carros);
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
