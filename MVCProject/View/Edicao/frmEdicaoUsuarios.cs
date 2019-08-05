﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View.Edicao
{
    public partial class frmEdicaoUsuarios : Form
    {
        public frmEdicaoUsuarios()
        {
            InitializeComponent();
        }
        public MVCProject.SistemaBibliotecaDBDataSet.UsuariosRow UsuariosRow;

        private void FrmEdicaoUsuarios_Load(object sender, EventArgs e)
        {
            textBox4.Text = UsuariosRow.Nome;
            textBox3.Text = UsuariosRow.Login;
            textBox2.Text = UsuariosRow.Senha;
            textBox1.Text = UsuariosRow.Email;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           UsuariosRow.Nome = textBox4.Text;
           UsuariosRow.Login = textBox3.Text;
           UsuariosRow.Senha = textBox2.Text;
           UsuariosRow.Email = textBox1.Text;
          
            this.Close();
        }
    }
}
