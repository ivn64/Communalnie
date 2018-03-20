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

        private int index;
        private DataArray<ProfitTable> Tables = new DataArray<ProfitTable>();

        public CommunalTable(int tIndex, DataArray<ProfitTable> tTables)
        {
            InitializeComponent();
            index = tIndex;
            Tables = tTables;
        }

        private void CommunalTable_Load(object sender, EventArgs e)
        {
            entityLabel.Text = "Объект: " + Tables.GetItem(index).Entity;
            for (int i = 0; i < Tables.GetTop(); i++)
            {
                if (Tables.GetItem(i).Entity == Tables.GetItem(index).Entity)
                {
                    if (Tables.GetItem(i).Year != 0)
                        yearComboBox.Items.Add(Tables.GetItem(i).Year);
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ProfitForm Profit = new ProfitForm();
            Profit.ShowDialog();
            /*if (Profit.Accruals > 0)
            {
                communalnieDataGridView.Rows.Add();
                communalnieDataGridView[0, communalnieDataGridView.Rows.Count - 1].Value = Profit.Service;
                communalnieDataGridView[1, communalnieDataGridView.Rows.Count - 1].Value = Profit.Indications;
                communalnieDataGridView[2, communalnieDataGridView.Rows.Count - 1].Value = Profit.Cost;
                communalnieDataGridView[3, communalnieDataGridView.Rows.Count - 1].Value = Profit.Accruals;
            }*/
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //communalnieDataGridView.Rows.RemoveAt(communalnieDataGridView.CurrentRow.Index);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addDateButton_Click(object sender, EventArgs e)
        {
            DateAndMonthAddForm DAM = new DateAndMonthAddForm();
            DAM.ShowDialog();

        }

        private void yearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            monthComboBox.Enabled = true;
        }
    }
}
