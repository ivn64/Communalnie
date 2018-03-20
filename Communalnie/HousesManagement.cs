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
    public partial class HousesManagement : Form
    {
        private House THouse = new House();
        private DataArray<ProfitTable> ProfitTableArray = new DataArray<ProfitTable>();
        private DataArray<House> HousesArray = new DataArray<House>();

        public HousesManagement()
        {
            InitializeComponent();
        }

        private void housesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (housesListBox.SelectedIndex >= 0)
            {
                THouse = HousesArray.GetItem(housesListBox.SelectedIndex);
                descriptionTextBox.Text = THouse.Name;
                adressTextBox.Text = THouse.Adress;
                totalAreaTextBox.Text = THouse.TotalArea.ToString();
                numberOfPeoplesTextBox.Text = THouse.NumberOfPeoples.ToString();
                if (THouse.IsPrivate == true)
                    privateHouseRadioButton.PerformClick();
                else
                    apartmentHouseRadioButton.PerformClick();
            }
        }

        private void HousesManagement_Load(object sender, EventArgs e)
        {
            HousesArray.LoadFromFile("Heuses.dat");
            for (int i = 0; i < HousesArray.GetTop(); i++)
            {
                housesListBox.Items.Add(HousesArray.GetItem(i).Name);
            }
            ProfitTableArray.LoadFromFile("Tables.dat");
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            HousesArray.AddItem(new House());
            housesListBox.Items.Add(HousesArray.GetItem(HousesArray.GetTop() - 1).Name);
            ProfitTableArray.AddItem(new ProfitTable(HousesArray.GetItem(HousesArray.GetTop() - 1).Name));
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (housesListBox.SelectedIndex >= 0)
            {
                HousesArray.RemoveItem(housesListBox.SelectedIndex);
                ProfitTableArray.RemoveItem(housesListBox.SelectedIndex);
                housesListBox.Items.RemoveAt(housesListBox.SelectedIndex);
            }
        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (housesListBox.SelectedIndex >= 0)
            {
                THouse.Name=descriptionTextBox.Text;
                HousesArray.SetItem(THouse, housesListBox.SelectedIndex);
                ProfitTableArray.GetItem(housesListBox.SelectedIndex).Entity = descriptionTextBox.Text;
                housesListBox.Items[housesListBox.SelectedIndex] = descriptionTextBox.Text;
            }
        }

        private void adressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (housesListBox.SelectedIndex >= 0)
            {
                THouse.Adress=adressTextBox.Text;
                HousesArray.SetItem(THouse, housesListBox.SelectedIndex);
            }
        }

        private void totalAreaTextBox_TextChanged(object sender, EventArgs e)
        {
            if (housesListBox.SelectedIndex >= 0)
            {
                try
                {
                    THouse.TotalArea = Convert.ToSingle(totalAreaTextBox.Text);
                    HousesArray.SetItem(THouse, housesListBox.SelectedIndex);
                }
                catch
                {
                    if (totalAreaTextBox.Text.Length != 0)
                    {
                        totalAreaTextBox.Text = totalAreaTextBox.Text.Remove(totalAreaTextBox.Text.Length - 1);
                        totalAreaTextBox.SelectionStart = totalAreaTextBox.Text.Length;
                    }
                }
            }
        }

        private void numberOfPeoplesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (housesListBox.SelectedIndex >= 0)
                try
                {
                    {
                        THouse.NumberOfPeoples = Convert.ToInt32(numberOfPeoplesTextBox.Text);
                        HousesArray.SetItem(THouse, housesListBox.SelectedIndex);
                    }
                }
                catch
                {
                    if (numberOfPeoplesTextBox.Text.Length != 0)
                    {
                        numberOfPeoplesTextBox.Text = numberOfPeoplesTextBox.Text.Remove(numberOfPeoplesTextBox.Text.Length - 1);
                        numberOfPeoplesTextBox.SelectionStart = numberOfPeoplesTextBox.Text.Length;
                    }
                }
        }

        private void apartmentHouseRadioButton_Click(object sender, EventArgs e)
        {
            if (housesListBox.SelectedIndex >= 0)
            {
                THouse.IsPrivate = false;
                HousesArray.SetItem(THouse, housesListBox.SelectedIndex);
            }
        }

        private void privateHouseRadioButton_Click(object sender, EventArgs e)
        {
            if (housesListBox.SelectedIndex >= 0)
            {
                THouse.IsPrivate = true;
                HousesArray.SetItem(THouse, housesListBox.SelectedIndex);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int count = 0;
            List<string> lines = new List<string>();
                for (int i = 0; i < HousesArray.GetTop(); i++)
                {
                    lines.Add(HousesArray.GetItem(i).Name);
                }
                for (int i = 0; i < lines.Count; ++i)
                {
                    count = lines.Count(str => str == lines[i]);
                }
            if (count > 1)
                MessageBox.Show("В списке объекты с одинаковыми именами!");
            else
            {
                ProfitTableArray.SaveToFile("Tables.dat");
                HousesArray.SaveToFile("Heuses.dat");
                Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
