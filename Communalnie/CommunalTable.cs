using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Communalnie
{
    public partial class CommunalTable : Form
    {
        private Profit TableRow = new Profit();
        private DataArray<Profit> RowsArray = new DataArray<Profit>();
        private string entityName;

        public CommunalTable(string entity)
        {
            InitializeComponent();
            entityName = entity;
        }

        private void CommunalTable_Load(object sender, EventArgs e)
        {
            communalnieDataGridView.Rows.Add();
            communalnieDataGridView[0, 0].Value = "123";
            communalnieDataGridView.Rows.Add();
            communalnieDataGridView[0, 1].Value = "12345";
            
            entityLabel.Text = "Объект: " + entityName;
            RowsArray.LoadFromFile("Table.dat");
            for (int i = 0; i < RowsArray.GetTop(); i++)
            {
                TableRow = RowsArray.GetItem(i);
                communalnieDataGridView.Rows.Add();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ProfitForm Profit = new ProfitForm();
            Profit.ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            communalnieDataGridView.Rows.RemoveAt(communalnieDataGridView.CurrentRow.Index);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
