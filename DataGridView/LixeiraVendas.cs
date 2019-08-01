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
    public partial class LixeiraVendas : Form
    {
        public LixeiraVendas()
        {
            InitializeComponent();
        }

        private void LixeiraVendas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'querysInnerJoinDataSet1.Vendas'. Você pode movê-la ou removê-la conforme necessário.
            this.vendasTableAdapter.RegistrosInativo(this.querysInnerJoinDataSet1.Vendas);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var VendasSelect = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as DataGridView.QuerysInnerJoinDataSet1.VendasRow;

            switch (e.ColumnIndex)
            {
                //COLUNA DELETAR
                case 0:
                    {
                        this.vendasTableAdapter.Restaurar(VendasSelect.Id);
                    }
                    break;
            }
            this.vendasTableAdapter.RegistrosInativo(this.querysInnerJoinDataSet1.Vendas);


        }
    }
}
