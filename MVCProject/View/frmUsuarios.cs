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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var usuariosSelect = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as MVCProject.SistemaBibliotecaDBDataSet.UsuariosRow;

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

                       this.usuariosTableAdapter.UpdateQuery(
                       editUsuarios.UsuariosRow.Nome,
                       editUsuarios.UsuariosRow.Login,
                       editUsuarios.UsuariosRow.Senha,
                       editUsuarios.UsuariosRow.Email,
                       editUsuarios.UsuariosRow.Ativo,
                       editUsuarios.UsuariosRow.UsuInc,
                       editUsuarios.UsuariosRow.UsuAlt,
                       editUsuarios.UsuariosRow.DatInc,
                       editUsuarios.UsuariosRow.DatAlt,
                       editUsuarios.UsuariosRow.Id);
                  


                        //this.usuariosTableAdapter.Update(editUsuarios.UsuariosRow);


                    }
                    break;
            }

            // this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);
            this.usuariosTableAdapter.CustomQuery(this.sistemaBibliotecaDBDataSet.Usuarios);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarUsuarios NovaTelaUsuarios = new frmAdicionarUsuarios();
            NovaTelaUsuarios.ShowDialog();

            if (!string.IsNullOrEmpty(NovaTelaUsuarios.usuariosRow?.Nome))
                this.usuariosTableAdapter.Insert(
                    NovaTelaUsuarios.usuariosRow.Nome,
                    NovaTelaUsuarios.usuariosRow.Login,
                    NovaTelaUsuarios.usuariosRow.Senha,
                    NovaTelaUsuarios.usuariosRow.Email,
                    NovaTelaUsuarios.usuariosRow.Ativo,
                    NovaTelaUsuarios.usuariosRow.UsuInc,
                    NovaTelaUsuarios.usuariosRow.UsuAlt,
                    DateTime.Now,
                    DateTime.Now
                    );

            this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);
        }
    }
}
