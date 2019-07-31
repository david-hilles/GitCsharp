using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TabelaDeVIsualizacaoDeValores.Model;

namespace TabelaDeVIsualizacaoDeValores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Contrac> listContracs = new List<Contrac>();

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {

            listContracs.Add(new Contrac()
            {
                Id = listContracs.Count,
                value = new Random().Next(100),
                DatInc = DateTime.Now

            });
            BindList();

        }
        private void BindList()
        {
            var newList = new List<Contrac>();

            foreach (Contrac item in listContracs)
                newList.Add(new Contrac()
                {
                    Id = item.Id,
                    value = item.value,
                    DatInc = item.DatInc
                });

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = newList;
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var collumId = dataGridView1.Rows[e.RowIndex].Cells[0];
                var collValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                switch (e.ColumnIndex)
                {
                    case 0:
                        {//Caso que representa minha coluna ID
                            MessageBox.Show("Não é possivel ajustar esta coluna.");
                        }
                        break;
                    case 1:
                        {
                            #region First Collumn edit
                            if (MessageBox.Show("Deseja realmente ajustar este valor ?"
                                , "Edição"
                                , MessageBoxButtons.YesNo
                                , MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                listContracs.FirstOrDefault(x =>
                                x.Id == (int)collumId.Value).value = (int)collValue.Value;
                            }
                            #endregion
                        }
                        break;
                    case 2:
                        {
                            #region Second Collumn Edit
                            var dialogResult = MessageBox.Show("Deseja realmente ajustar este valor ?"
                            , "Edição"
                            , MessageBoxButtons.YesNoCancel
                            , MessageBoxIcon.Error);
                            if (dialogResult == DialogResult.Yes)
                            {
                                var dataInformada = DateTime.Parse(collValue.Value.ToString());

                                if (dataInformada <= DateTime.Now)
                                    listContracs.FirstOrDefault(x =>
                                    x.Id == (int)collumId.Value).DatInc = DateTime.Parse(collValue.Value.ToString());
                                else
                                    MessageBox.Show("Não foi possivel alterar o registro de data.");
                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                //TODO: Codigo para quando o mesmo não realizar a operação corretamente
                            }
                            #endregion
                        }
                        break;
                }
            }

            BindList();
        }
    }
}
