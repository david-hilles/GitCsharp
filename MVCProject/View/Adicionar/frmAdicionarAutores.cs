﻿using MVCProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View.Adicionar
{
    public partial class frmAdicionarAutores : Form
    {
        public frmAdicionarAutores()
        {
            InitializeComponent();
        }
        public Autor AutorRow;
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AutorRow = new Autor
            {
                Nome = textBox1.Text,
                Descricao = textBox2.Text

            };
            this.Close();

        }
    }
}
