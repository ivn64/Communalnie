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
        }

        private void graphButton_Click(object sender, EventArgs e)
        {
            Graph GraphForm = new Graph();
            GraphForm.ShowDialog();
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
            yearComboBox.Enabled = true;
            monthComboBox.Enabled = false;
        }

        private void yearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            monthComboBox.Enabled = true;
        }
    }
}
