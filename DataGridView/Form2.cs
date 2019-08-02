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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'querysInnerJoinDataSet1.Marcas'. Você pode movê-la ou removê-la conforme necessário.
            this.marcasTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Marcas);

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            frmAdicionarMarcas formAdd = new frmAdicionarMarcas();
            formAdd.ShowDialog();

            if (!string.IsNullOrEmpty(formAdd.marcasRow?.Nome))
            this.marcasTableAdapter.Insert(
            formAdd.marcasRow.Nome,

            true,
            1,
            1,
            DateTime.Now,
            DateTime.Now
            );
            //ATUALIZA A TABELA //
            this.marcasTableAdapter.Fill(this.querysInnerJoinDataSet1.Marcas);


        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var marcasSelect = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as DataGridView.QuerysInnerJoinDataSet1.MarcasRow;
            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.marcasTableAdapter.DeleteQuery(marcasSelect.Id);
                    }
                    break;
                case 1:
                    {
                        frmEdicaoMarcas editMarcas = new frmEdicaoMarcas();
                        editMarcas.MarcasRow = marcasSelect;
                        editMarcas.ShowDialog();

                        //COM ESSE EXEMPLO NAO PRECISA CRIAR QUERY
                        this.marcasTableAdapter.Update(editMarcas.MarcasRow); 


                    }
                    break;
            }

            

            this.marcasTableAdapter.CustomQuery(querysInnerJoinDataSet1.Marcas);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            LixeiraMarcas lixo = new LixeiraMarcas();
            lixo.ShowDialog();
            this.marcasTableAdapter.CustomQuery(querysInnerJoinDataSet1.Marcas);
        }
    }
}
