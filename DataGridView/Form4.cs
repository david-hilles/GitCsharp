using DataGridView.Adicionar;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'querysInnerJoinDataSet1.Vendas'. Você pode movê-la ou removê-la conforme necessário.
            this.vendasTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Vendas);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var vendasSelect = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as DataGridView.QuerysInnerJoinDataSet1.VendasRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.vendasTableAdapter.DeleteQuery(vendasSelect.Id);
                    }
                    break;
                case 1:
                    {
                        frmEdicaoVendas editVendas = new frmEdicaoVendas();
                        editVendas.VendasRow = vendasSelect;
                        editVendas.ShowDialog();

                        //COM ESSE EXEMPLO NAO PRECISA CRIAR QUERY

                        this.vendasTableAdapter.Update(editVendas.VendasRow);

                    }
                    break;
            }

            this.vendasTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Vendas);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            LixeiraVendas lixo = new LixeiraVendas();
            lixo.ShowDialog();
            this.vendasTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Vendas);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarVendas formAddVendas = new frmAdicionarVendas();
            formAddVendas.ShowDialog();

            if (formAddVendas.vendasRow?.Nomecarros > 0
                && formAddVendas.vendasRow?.Valor > 0)
                
                this.vendasTableAdapter.Insert(
                formAddVendas.vendasRow.Nomecarros,
                formAddVendas.vendasRow.Quantidade,
                formAddVendas.vendasRow.Valor,

                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now
                );
            //ATUALIZA A TABELA //
            //this.usuariosTableAdapter.Fill(this.querysInnerJoinDataSet1.Usuarios);
            this.vendasTableAdapter.CustomQuery(querysInnerJoinDataSet1.Vendas);


        }
    }
}
