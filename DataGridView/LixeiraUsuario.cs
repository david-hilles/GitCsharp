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
    public partial class LixeiraUsuario : Form
    {
        public LixeiraUsuario()
        {
            InitializeComponent();
        }

        private void LixeiraUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'querysInnerJoinDataSet1.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.Fill(this.querysInnerJoinDataSet1.Usuarios);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var UsuariosSelect = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as DataGridView.QuerysInnerJoinDataSet1.UsuariosRow;

            switch (e.ColumnIndex)
            {
                
                case 0:
                    {
                        this.usuariosTableAdapter.Restaurar(UsuariosSelect.Id);

                    }
                    break;
            }

            this.usuariosTableAdapter.RegistrosInativos(this.querysInnerJoinDataSet1.Usuarios);
        }
    }
}
