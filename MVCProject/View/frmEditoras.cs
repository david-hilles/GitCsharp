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
    public partial class frmEditoras : Form
    {
        public frmEditoras()
        {
            InitializeComponent();
        }

        private void FrmEditoras_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Editoras'. Você pode movê-la ou removê-la conforme necessário.
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarEditoras NovaTela = new frmAdicionarEditoras();
            NovaTela.ShowDialog();

            if (!string.IsNullOrEmpty(NovaTela.EditoraRow?.Nome))
                this.editorasTableAdapter.Insert(
                    NovaTela.EditoraRow.Nome,
                    NovaTela.EditoraRow.Descricao
                    );

            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var editorasSelect = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as MVCProject.SistemaBibliotecaDBDataSet.EditorasRow;


            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.editorasTableAdapter.DeleteQuery(editorasSelect.Id);
                    }
                    break;
                case 1:
                    {
                        frmEdicaoEditoras editEditoras = new frmEdicaoEditoras();
                        editEditoras.EditorasRow = editorasSelect;
                        editEditoras.ShowDialog();

                        this.editorasTableAdapter.UpdateQuery(
                            editEditoras.EditorasRow.Nome,
                            editEditoras.EditorasRow.Descricao,
                            editEditoras.EditorasRow.Id);

                    }
                    break;

            }
            this.editorasTableAdapter.CustomQuery(this.sistemaBibliotecaDBDataSet.Editoras);



        }
    }
}
