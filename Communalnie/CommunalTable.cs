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

        public House SelHouse { get; set; }
        public bool isSave { get; set; }

        public CommunalTable(House TSelHouse)
        {
            InitializeComponent();
            SelHouse = new House(TSelHouse);
            isSave = false;
            entityLabel.Text = "Объект: " + SelHouse.Name;
        }

        private void CommunalTable_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < SelHouse.TablesList.Count; i++)
            {
                bool count = false;
                for (int j = 0; j < yearComboBox.Items.Count; j++)
                {
                    if (UInt32.Parse(yearComboBox.Items[j].ToString()) == SelHouse.TablesList[i].Year)
                    {
                        count = true;
                    }
                }
                if (count == false)
                    yearComboBox.Items.Add(SelHouse.TablesList[i].Year);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ProfitForm Profit = new ProfitForm();
            Profit.ShowDialog();
            if (Profit.Issave == true)
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
            bool isCoincidence = false;
            if (DAM.isSave == true)
            {
                for (int i = 0; i < SelHouse.TablesList.Count; i++)
                {
                    if (DAM.Year == SelHouse.TablesList[i].Year && DAM.Month == SelHouse.TablesList[i].Month)
                        isCoincidence = true;
                }
                if (isCoincidence == false)
                {
                    SelHouse.TablesList.Add(new ProfitTable(DAM.Year, DAM.Month));
                    bool test = false;
                    for (int i = 0; i < yearComboBox.Items.Count; i++)
                    {
                        if (Convert.ToInt32(yearComboBox.Items[i]) == DAM.Year)
                            test = true;
                    }
                    if (test == false)
                        yearComboBox.Items.Add(DAM.Year);
                    yearComboBox.SelectedIndex = -1;
                    monthComboBox.Enabled = false;
                    removeDateButton.Enabled = false;
                }
                else
                    MessageBox.Show("Такие даты уже есть");
            }
        }

        private void yearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            monthComboBox.Items.Clear();
            monthComboBox.Enabled = true;
            for (int i = 0; i < SelHouse.TablesList.Count; i++)
            {
                if (SelHouse.TablesList[i].Year == Convert.ToInt32(yearComboBox.SelectedItem)) 
                {
                    monthComboBox.Items.Add(SelHouse.TablesList[i].Month);
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            isSave = true;
            Close();
        }

        private void removeDateButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < SelHouse.TablesList.Count; i++)
            {
                if (SelHouse.TablesList[i].Year == uint.Parse(yearComboBox.SelectedItem.ToString()) && SelHouse.TablesList[i].Month == monthComboBox.SelectedItem.ToString())
                {
                    SelHouse.TablesList.RemoveAt(i);
                    if (monthComboBox.Items.Count > 1)
                    {
                        monthComboBox.Items.RemoveAt(monthComboBox.SelectedIndex);
                    }
                    else
                    {
                        yearComboBox.Items.RemoveAt(yearComboBox.SelectedIndex);
                        monthComboBox.SelectedIndex = -1;
                        monthComboBox.Enabled = false;
                    }
                    removeDateButton.Enabled = false;
                    break;
                }
            }
        }

        private void monthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            removeDateButton.Enabled = true;
        }
    }
}
