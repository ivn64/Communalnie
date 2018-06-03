using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Communalnie
{
    public partial class CommunalTable : Form
    {
        public House SelHouse { get; set; }
        public bool isSave { get; set; }
        private int selectedTablesListIndex = -1;

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
                    if (uint.Parse(yearComboBox.Items[j].ToString()) == SelHouse.TablesList[i].Year)
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
            if (monthComboBox.SelectedIndex >= 0)
            {
                ProfitForm ProfitForm = new ProfitForm();
                ProfitForm.ShowDialog();
                if (ProfitForm.Issave == true)
                {
                    SelHouse.TablesList[selectedTablesListIndex].ProfitsList.Add(new Profit(ProfitForm.Service, ProfitForm.Indications, ProfitForm.Unit, ProfitForm.Cost, ProfitForm.Accruals));
                    communalnieDataGridView.Rows.Add();
                    communalnieDataGridView[0, communalnieDataGridView.Rows.Count - 1].Value = ProfitForm.Service;
                    communalnieDataGridView[1, communalnieDataGridView.Rows.Count - 1].Value = ProfitForm.Indications;
                    communalnieDataGridView[2, communalnieDataGridView.Rows.Count - 1].Value = ProfitForm.Unit;
                    communalnieDataGridView[3, communalnieDataGridView.Rows.Count - 1].Value = ProfitForm.Cost;
                    communalnieDataGridView[4, communalnieDataGridView.Rows.Count - 1].Value = ProfitForm.Accruals;
                }
            }
            else
            {
                MessageBox.Show("выберите дату");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int index = communalnieDataGridView.CurrentRow.Index;
            communalnieDataGridView.Rows.RemoveAt(index);
            SelHouse.TablesList[selectedTablesListIndex].ProfitsList.RemoveAt(index);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addDateButton_Click(object sender, EventArgs e)
        {
            DateAndMonthAddForm DAM = new DateAndMonthAddForm();
            DAM.ShowDialog();
            bool isExist = false;
            if (DAM.isSave == true)
            {
                for (int i = 0; i < SelHouse.TablesList.Count; i++)
                {
                    if (DAM.Year == SelHouse.TablesList[i].Year && DAM.Month == SelHouse.TablesList[i].Month)
                        isExist = true;
                }
                if (isExist == false)
                {
                    SelHouse.TablesList.Add(new ProfitTable(DAM.Year, DAM.Month));
                    SelHouse.TablesList = SelHouse.TablesList.OrderBy(s => DateTime.ParseExact(s.Month, "MMMM", new CultureInfo("ru-RU"))).ToList();
                    SelHouse.TablesList = SelHouse.TablesList.OrderBy(x => x.Year).ToList();
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
            removeDateButton.Enabled = false;
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
            int i = selectedTablesListIndex;
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
            communalnieDataGridView.Rows.Clear();
            removeDateButton.Enabled = false;
        }

        private void monthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            removeDateButton.Enabled = true;
            if (monthComboBox.SelectedIndex >= 0)
            {
                for (int i = 0; i < SelHouse.TablesList.Count; i++)
                {
                    if (SelHouse.TablesList[i].Year == uint.Parse(yearComboBox.SelectedItem.ToString()) && SelHouse.TablesList[i].Month == monthComboBox.SelectedItem.ToString())
                    {
                        selectedTablesListIndex = i;
                        break;
                    }
                }
                communalnieDataGridView.Rows.Clear();
                for (int i = 0; i < SelHouse.TablesList[selectedTablesListIndex].ProfitsList.Count; i++)
                {
                    communalnieDataGridView.Rows.Add();
                    communalnieDataGridView[0, communalnieDataGridView.Rows.Count - 1].Value = SelHouse.TablesList[selectedTablesListIndex].ProfitsList[i].Service;
                    communalnieDataGridView[1, communalnieDataGridView.Rows.Count - 1].Value = SelHouse.TablesList[selectedTablesListIndex].ProfitsList[i].Indications;
                    communalnieDataGridView[2, communalnieDataGridView.Rows.Count - 1].Value = SelHouse.TablesList[selectedTablesListIndex].ProfitsList[i].Unit;
                    communalnieDataGridView[3, communalnieDataGridView.Rows.Count - 1].Value = SelHouse.TablesList[selectedTablesListIndex].ProfitsList[i].Cost;
                    communalnieDataGridView[4, communalnieDataGridView.Rows.Count - 1].Value = SelHouse.TablesList[selectedTablesListIndex].ProfitsList[i].Accruals;
                }
            }
        }
    }
}
