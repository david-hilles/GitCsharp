using CadastrarCarros.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastrarCarros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Carro> carros = new List<Carro>();
        private void Button1_Click(object sender, EventArgs e)
        {
            TabelaDeCadastrar formCad = new TabelaDeCadastrar();
            formCad.ShowDialog();
            carros.Add(formCad.novoCarro);

            var newList = new List<Carro>();

            foreach (Carro item in carros)
                newList.Add(new Carro()
                {
                    Modelo = item.Modelo,
                    Ano = item.Ano,
                    Placa = item.Placa
                });

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = newList;

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
    }
}
