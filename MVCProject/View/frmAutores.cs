using MVCProject.View.Adicionar;
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
    public partial class frmAutores : Form
    {
        public frmAutores()
        {
            InitializeComponent();
        }

        private void FrmAutores_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Autores'. Você pode movê-la ou removê-la conforme necessário.
            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Autores);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarAutores NovaTela =  new frmAdicionarAutores();
            NovaTela.ShowDialog();

            if (!string.IsNullOrEmpty(NovaTela.AutorRow?.Nome))
                this.autoresTableAdapter.Insert(
                    NovaTela.AutorRow.Nome,
                    NovaTela.AutorRow.Descricao
                    );

            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Autores);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var autorSelect = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as MVCProject.SistemaBibliotecaDBDataSet.AutoresRow;

            switch(e.ColumnIndex)
            {
                case 0:
                    {
                        this.autoresTableAdapter.DeleteQuery(autorSelect.Id);
                    }
                    break;
                case 1:
                    {
                        frmEdicaoAutores editAutor = new frmEdicaoAutores();
                        editAutor.AutoresRow = autorSelect;
                        editAutor.ShowDialog();

                        this.autoresTableAdapter.UpdateQuery(
                            editAutor.AutoresRow.Nome,
                            editAutor.AutoresRow.Descricao,
                            editAutor.AutoresRow.Id);

                    }
                    break;

            }
            this.autoresTableAdapter.CustomQuery(this.sistemaBibliotecaDBDataSet.Autores);

        }
    }
}
