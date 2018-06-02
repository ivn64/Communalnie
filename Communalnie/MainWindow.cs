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
    public partial class MainWindow : Form
    {
        private DataArray<House> HousesArray;
        public string Entity { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            HousesArray = new DataArray<House>();
        }

        private void servicesButton_Click(object sender, EventArgs e)
        {
            ServiceManagement serviceManagementForm = new ServiceManagement();
            serviceManagementForm.ShowDialog();
        }

        private void housesButton_Click(object sender, EventArgs e)
        {
            yearComboBox.SelectedIndex = -1;
            yearComboBox.Enabled = false;
            monthComboBox.SelectedIndex = -1;
            monthComboBox.Enabled = false;
            HousesManagement HousesManagementForm = new HousesManagement(HousesArray);
            HousesManagementForm.ShowDialog();
            if (HousesManagementForm.isSave == true)
            {
                housesComboBox.Items.Clear();
                HousesArray.RemoveItems();
                HousesArray.Clone(HousesManagementForm.HousesArray);
                HousesArray.SaveToFile("Houses.dat");
                for (int i = 0; i < HousesArray.GetTop(); i++)
                {
                    housesComboBox.Items.Add(HousesArray.GetItem(i).Name);
                }
            }
            housesComboBox.SelectedIndex = -1;
        }

        private void graphButton_Click(object sender, EventArgs e)
        {
            if (housesComboBox.SelectedIndex >= 0)
            {
                int index = housesComboBox.SelectedIndex;
                Graph GraphForm = new Graph(HousesArray.GetItem(index));
                GraphForm.ShowDialog();
            }
            else
                MessageBox.Show("Выберите объект");
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (housesComboBox.SelectedIndex >= 0)
            {
                int index = housesComboBox.SelectedIndex;
                CommunalTable TableEditForm = new CommunalTable(HousesArray.GetItem(index));
                TableEditForm.ShowDialog();
                if (TableEditForm.isSave == true)
                {
                    HousesArray.SetItem(TableEditForm.SelHouse, index);
                    HousesArray.SaveToFile("Houses.dat");
                }
                housesComboBox.SelectedIndex = -1;
            }
            else
                MessageBox.Show("Выберите объект");
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            HousesArray.LoadFromFile("Houses.dat");
            for (int i = 0; i < HousesArray.GetTop(); i++)
            {
                housesComboBox.Items.Add(HousesArray.GetItem(i).Name);
            }
        }

        private void housesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            communalnieDataGridView.Rows.Clear();
            yearComboBox.Items.Clear();
            if (housesComboBox.SelectedIndex >= 0)
            {
                for (int i = 0; i < HousesArray.GetItem(housesComboBox.SelectedIndex).TablesList.Count; i++)
                {
                    bool count = false;
                    for (int j = 0; j < yearComboBox.Items.Count; j++)
                    {
                        if (uint.Parse(yearComboBox.Items[j].ToString()) == HousesArray.GetItem(housesComboBox.SelectedIndex).TablesList[i].Year)
                        {
                            count = true;
                        }
                    }
                    if (count == false)
                        yearComboBox.Items.Add(HousesArray.GetItem(housesComboBox.SelectedIndex).TablesList[i].Year);
                }
                yearComboBox.Enabled = true;
                monthComboBox.Enabled = false;
            }
            else
            {
                monthComboBox.Items.Clear();
                yearComboBox.Enabled = false;
                monthComboBox.Enabled = false;
            }
        }

        private void yearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            monthComboBox.Items.Clear();
            monthComboBox.Enabled = true;
            for (int i = 0; i < HousesArray.GetItem(housesComboBox.SelectedIndex).TablesList.Count; i++)
            {
                if (HousesArray.GetItem(housesComboBox.SelectedIndex).TablesList[i].Year == Convert.ToInt32(yearComboBox.SelectedItem))
                {
                    monthComboBox.Items.Add(HousesArray.GetItem(housesComboBox.SelectedIndex).TablesList[i].Month);
                }
            }
        }

        private void monthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedTablesListIndex = 0;
            if (monthComboBox.SelectedIndex >= 0)
            {
                for (int i = 0; i < HousesArray.GetItem(housesComboBox.SelectedIndex).TablesList.Count; i++)
                {
                    if (HousesArray.GetItem(housesComboBox.SelectedIndex).TablesList[i].Year == uint.Parse(yearComboBox.SelectedItem.ToString()) && HousesArray.GetItem(housesComboBox.SelectedIndex).TablesList[i].Month == monthComboBox.SelectedItem.ToString())
                    {
                        selectedTablesListIndex = i;
                        break;
                    }
                }
                communalnieDataGridView.Rows.Clear();
                for (int i = 0; i < HousesArray.GetItem(housesComboBox.SelectedIndex).TablesList[selectedTablesListIndex].ProfitsList.Count; i++)
                {
                    communalnieDataGridView.Rows.Add();
                    communalnieDataGridView[0, communalnieDataGridView.Rows.Count - 1].Value = HousesArray.GetItem(housesComboBox.SelectedIndex).TablesList[selectedTablesListIndex].ProfitsList[i].Service;
                    communalnieDataGridView[1, communalnieDataGridView.Rows.Count - 1].Value = HousesArray.GetItem(housesComboBox.SelectedIndex).TablesList[selectedTablesListIndex].ProfitsList[i].Indications;
                    communalnieDataGridView[2, communalnieDataGridView.Rows.Count - 1].Value = HousesArray.GetItem(housesComboBox.SelectedIndex).TablesList[selectedTablesListIndex].ProfitsList[i].Cost;
                    communalnieDataGridView[3, communalnieDataGridView.Rows.Count - 1].Value = HousesArray.GetItem(housesComboBox.SelectedIndex).TablesList[selectedTablesListIndex].ProfitsList[i].Accruals;
                }
            }
        }
    }
}
