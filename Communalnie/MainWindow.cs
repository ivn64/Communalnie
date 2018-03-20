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
        private DataArray<ProfitTable> ProfitTableArray;
        public string Entity { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            HousesArray = new DataArray<House>();
            ProfitTableArray = new DataArray<ProfitTable>();
        }

        private void servicesButton_Click(object sender, EventArgs e)
        {
            ServiceManagement serviceManagementForm = new ServiceManagement();
            serviceManagementForm.ShowDialog();
        }

        private void housesButton_Click(object sender, EventArgs e)
        {
            HousesManagement HousesManagementForm = new HousesManagement();
            HousesManagementForm.ShowDialog();
            housesComboBox.Items.Clear();
            ProfitTableArray.RemoveItems();
            ProfitTableArray.LoadFromFile("Tables.dat");
            for (int i = 0; i < ProfitTableArray.GetTop(); i++)
            {
                housesComboBox.Items.Add(ProfitTableArray.GetItem(i).Entity);
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
                CommunalTable TableEditForm = new CommunalTable(housesComboBox.SelectedIndex, ProfitTableArray);
                TableEditForm.ShowDialog();
            }
            else
                MessageBox.Show("Выберите объект");
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            ProfitTableArray.LoadFromFile("Tables.dat");
            for (int i = 0; i < ProfitTableArray.GetTop(); i++)
            {
                housesComboBox.Items.Add(ProfitTableArray.GetItem(i).Entity);
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
