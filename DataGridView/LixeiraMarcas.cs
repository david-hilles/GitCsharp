﻿using System;
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
    public partial class LixeiraMarcas : Form
    {
        public LixeiraMarcas()
        {
            InitializeComponent();
        }

        private void LixeiraMarcas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'querysInnerJoinDataSet1.Marcas'. Você pode movê-la ou removê-la conforme necessário.
            this.marcasTableAdapter.RegistrosInativo(this.querysInnerJoinDataSet1.Marcas);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var MarcasSelect = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as DataGridView.QuerysInnerJoinDataSet1.MarcasRow;

            switch (e.ColumnIndex)
            {
                //COLUNA DELETAR
                case 0:
                    {
                        this.marcasTableAdapter.RestaurarMarcas(MarcasSelect.Id);
                        
                    }
                    break;
            }

            this.marcasTableAdapter.RegistrosInativo(querysInnerJoinDataSet1.Marcas);
        }
    }
}
