using DataGridView.Edicao;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'querysInnerJoinDataSet1.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Usuarios);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           var usuariosSelect = ((System.Data.DataRowView)
           this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
           as DataGridView.QuerysInnerJoinDataSet1.UsuariosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.usuariosTableAdapter.DeleteQuery(usuariosSelect.Id);
                    }
                    break;
                case 1:
                    {
                        frmEdicaoUsuarios editUsuarios = new frmEdicaoUsuarios();
                        editUsuarios.UsuariosRow = usuariosSelect;
                        editUsuarios.ShowDialog();

                        //COM ESSE EXEMPLO NAO PRECISA CRIAR QUERY

                        this.usuariosTableAdapter.Update(editUsuarios.UsuariosRow); 


                    }
                    break;
            }

            this.usuariosTableAdapter.CustomQuery(querysInnerJoinDataSet1.Usuarios);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            LixeiraUsuarios lixo = new LixeiraUsuarios();
            lixo.ShowDialog();

        }
    }
}
