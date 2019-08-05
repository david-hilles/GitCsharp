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
    public partial class frmLivros : Form
    {
        public frmLivros()
        {
            InitializeComponent();
        }

        private void FrmLivros_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Livros'. Você pode movê-la ou removê-la conforme necessário.
            this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livros);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var livrosSelect = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as MVCProject.SistemaBibliotecaDBDataSet.LivrosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {

                        this.livrosTableAdapter.DeleteQuery(livrosSelect.Id);
                    }
                    break;
                case 1:
                    {
                        frmEdicaoLivros editLivros = new frmEdicaoLivros();
                        editLivros.LivrosRow = livrosSelect;
                        editLivros.ShowDialog();

                        this.livrosTableAdapter.UpdateQuery(
                            editLivros.LivrosRow.Registro,
                            editLivros.LivrosRow.TItulo,
                            editLivros.LivrosRow.Isbn,
                            editLivros.LivrosRow.Genero,
                            editLivros.LivrosRow.Editora,
                            editLivros.LivrosRow.Sinopse,
                            editLivros.LivrosRow.Observacoes,
                            editLivros.LivrosRow.Ativo,
                            editLivros.LivrosRow.UsuInc,
                            editLivros.LivrosRow.UsuAlt,
                            editLivros.LivrosRow.DatInc,
                            editLivros.LivrosRow.DatAlt,
                            editLivros.LivrosRow.Id);


                    }
                    break;

            }
            this.livrosTableAdapter.CustomQuerys(this.sistemaBibliotecaDBDataSet.Livros);


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarLivros NovaTela = new frmAdicionarLivros();
            NovaTela.ShowDialog();

            if (!string.IsNullOrEmpty(NovaTela.livrosRow?.Titulo))
                this.livrosTableAdapter.Insert(
                    NovaTela.livrosRow.Registro,
                    NovaTela.livrosRow.Titulo,
                    NovaTela.livrosRow.Isbn,
                    NovaTela.livrosRow.Genero,
                    NovaTela.livrosRow.Editora,
                    NovaTela.livrosRow.Sinopse,
                    NovaTela.livrosRow.Observacoes,
                    NovaTela.livrosRow.Ativo,
                    NovaTela.livrosRow.UsuInc,
                    NovaTela.livrosRow.UsuAlt,
                    DateTime.Now,
                    DateTime.Now

                    );

            this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livros);

        }
    }
}
