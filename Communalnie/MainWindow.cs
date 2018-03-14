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
        private House THouse = new House();
        private DataArray<House> HousesArray = new DataArray<House>();
        public string Entity { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void servicesButton_Click(object sender, EventArgs e)
        {
            ServiceManagement serviceManagementForm = new ServiceManagement();
            serviceManagementForm.ShowDialog();
        }

        private void MainWindow_Activated(object sender, EventArgs e)
        {
            HousesArray.LoadFromFile("Heuses.dat");
            for (int i = 0; i < HousesArray.GetTop(); i++)
            {
                THouse = HousesArray.GetItem(i);
                housesComboBox.Items.Add(THouse.Name);
            }
        }

        private void housesButton_Click(object sender, EventArgs e)
        {
            HousesManagement HousesManagementForm = new HousesManagement();
            HousesManagementForm.ShowDialog();
        }

        private void graphButton_Click(object sender, EventArgs e)
        {
            Graph GraphForm = new Graph();
            GraphForm.ShowDialog();
        }

        private void MainWindow_Deactivate(object sender, EventArgs e)
        {
            housesComboBox.Items.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (housesComboBox.SelectedIndex >= 0)
            {
                CommunalTable TableEditForm = new CommunalTable(housesComboBox.SelectedItem.ToString());
                TableEditForm.ShowDialog();
            }
            else
                MessageBox.Show("Выберите объект");
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
