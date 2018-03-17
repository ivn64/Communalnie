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
        private ProfitDate TableRow = new ProfitDate();
        //private DataArray<Profit> RowsArray = new DataArray<Profit>();
        private DataArray<Profit> RowsArray;
        private string entity;
        private int year;
        private string month;

        public CommunalTable(string tEntity)
        {
            InitializeComponent();
            entity = tEntity;
        }

        public CommunalTable(string tEntity, int tYear, string tMonth)
        {
            InitializeComponent();
            entity = tEntity;
            year = tYear;
            month = tMonth;
        }

        private void CommunalTable_Load(object sender, EventArgs e)
        {
            entityLabel.Text = "Объект: " + entity;

            /*RowsArray.LoadFromFile("Table.dat");
            for (int i = 0; i < RowsArray.GetTop(); i++)
            {
                TableRow = RowsArray.GetItem(i);
                communalnieDataGridView.Rows.Add();
            }*/
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ProfitForm Profit = new ProfitForm();
            Profit.ShowDialog();
            if (Profit.Accruals > 0)
            {
                communalnieDataGridView.Rows.Add();
                communalnieDataGridView[0, communalnieDataGridView.Rows.Count - 1].Value = Profit.Service;
                communalnieDataGridView[1, communalnieDataGridView.Rows.Count - 1].Value = Profit.Indications;
                communalnieDataGridView[2, communalnieDataGridView.Rows.Count - 1].Value = Profit.Cost;
                communalnieDataGridView[3, communalnieDataGridView.Rows.Count - 1].Value = Profit.Accruals;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            communalnieDataGridView.Rows.RemoveAt(communalnieDataGridView.CurrentRow.Index);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void addDateButton_Click(object sender, EventArgs e)
        {
            DateAndMonthAddForm DAM = new DateAndMonthAddForm();
            DAM.ShowDialog();
        }
    }
}
