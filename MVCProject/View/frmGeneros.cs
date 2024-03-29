﻿using MVCProject.View.Adicionar;
using MVCProject.View.Edicao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View
{
    public partial class frmGeneros : Form
    {
        public frmGeneros()
        {
            InitializeComponent();
        }

        private void FrmGeneros_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Generos'. Você pode movê-la ou removê-la conforme necessário.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarGeneros NovaTela = new frmAdicionarGeneros();
            NovaTela.ShowDialog();

            if (!string.IsNullOrEmpty(NovaTela.GeneroRow?.Tipo))
                this.generosTableAdapter.Insert(
                    NovaTela.GeneroRow.Tipo,
                    NovaTela.GeneroRow.Descricao
                    );

            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);


        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var generosSelect = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as MVCProject.SistemaBibliotecaDBDataSet.GenerosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        frmEdicaoGeneros editGeneros = new frmEdicaoGeneros();
                        editGeneros.GenerosRow = generosSelect;
                        editGeneros.ShowDialog();

                        this.generosTableAdapter.UpdateQuery(
                            editGeneros.GenerosRow.Tipo,
                            editGeneros.GenerosRow.Descricao,
                            editGeneros.GenerosRow.Id);

                        //this.generosTableAdapter.DeleteQuery(generosSelect.Id);
                    }
                    break;


            }
            this.generosTableAdapter.CustomQuery(this.sistemaBibliotecaDBDataSet.Generos);



        }
    }
}
