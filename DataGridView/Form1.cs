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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'querysInnerJoinDataSet1.Carros'. Você pode movê-la ou removê-la conforme necessário.
            this.carrosTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Carros);
            // TODO: esta linha de código carrega dados na tabela 'querysInnerJoinDataSet.Carros'. Você pode movê-la ou removê-la conforme necessário.

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form2 frmMarcas = new Form2();
            frmMarcas.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form3 frmVendas = new Form3();
            frmVendas.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form4 frmUsuario = new Form4();
            frmUsuario.ShowDialog();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //var carSelect =
            // ((System.Windows.Forms.DataGridViewRow)
            //   ((((System.Windows.Forms.DataGridView)sender).Rows).Items[0]))
            //   .DataBoundItem
            var carSelect = ((System.Data.DataRowView)
               this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as DataGridView.QuerysInnerJoinDataSet1.CarrosRow;

            //MessageBox.Show(carSelect.Ano.ToString());
            switch(e.ColumnIndex)
            {
                //COLUNA DELETAR
                case 0:
                    {
                        this.carrosTableAdapter.DeleteQuery(carSelect.Id);
                        //this.carrosTableAdapter.CustomQuery(querysInnerJoinDataSet1.Carros);
                    }break;
            }
          //  this.carrosTableAdapter.DeleteQuery(carSelect.Id);
            this.carrosTableAdapter.CustomQuery(querysInnerJoinDataSet1.Carros);     //PARA MOSTRAR ATUALIZADA
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Lixeira lixo = new Lixeira();
            lixo.ShowDialog();

        }

        private void Button6_Click(object sender, EventArgs e)
        {

            this.carrosTableAdapter.CustomQuery(querysInnerJoinDataSet1.Carros);
        }
    }
}
