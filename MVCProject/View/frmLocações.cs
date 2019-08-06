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
    public partial class frmLocações : Form
    {
        public frmLocações()
        {
            InitializeComponent();
        }

        private void FrmLocações_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Locacao'. Você pode movê-la ou removê-la conforme necessário.
            this.locacaoTableAdapter.CustomQuery(this.sistemaBibliotecaDBDataSet.Locacao);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarLocacoes NovaTela = new frmAdicionarLocacoes();
            NovaTela.ShowDialog();

            if (!string.IsNullOrEmpty(NovaTela.locacaoRow?.Usuario.ToString()))
                this.locacaoTableAdapter.Insert(
                    NovaTela.locacaoRow.Livro,
                    NovaTela.locacaoRow.Usuario,
                    NovaTela.locacaoRow.Tipo,
                    NovaTela.locacaoRow.Devolucao,
                    NovaTela.locacaoRow.Ativo,
                    NovaTela.locacaoRow.UsuInc,
                    NovaTela.locacaoRow.UsuAlt,
                    DateTime.Now,
                    DateTime.Now
                    );

            this.locacaoTableAdapter.CustomQuery(this.sistemaBibliotecaDBDataSet.Locacao);



        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var locacaoSelect = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as MVCProject.SistemaBibliotecaDBDataSet.LocacaoRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.locacaoTableAdapter.DeleteQuery(locacaoSelect.Id);
                    }
                    break;
                case 1:
                    {
                        frmEdicaoLocacoes editLocacao = new frmEdicaoLocacoes();
                        editLocacao.LocacaoRow = locacaoSelect;
                        editLocacao.ShowDialog();

                        this.locacaoTableAdapter.UpdateQuery(
                            editLocacao.LocacaoRow.Livro,
                            editLocacao.LocacaoRow.Usuario,
                            editLocacao.LocacaoRow.Tipo,
                            editLocacao.LocacaoRow.Devolucao,
                            editLocacao.LocacaoRow.Ativo,
                            editLocacao.LocacaoRow.UsuInc,
                            editLocacao.LocacaoRow.UsuAlt,
                            editLocacao.LocacaoRow.DataInc,
                            editLocacao.LocacaoRow.DataAlt,
                            editLocacao.LocacaoRow.Id);

                    }
                    break;

            }
            this.locacaoTableAdapter.CustomQuery(this.sistemaBibliotecaDBDataSet.Locacao);

        }
    }
}
