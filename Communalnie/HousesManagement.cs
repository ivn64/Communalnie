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
                THouse = HousesArray.GetItem(i);
                housesListBox.Items.Add(THouse.Name);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //HousesArray.AddItem(THouse);
            HousesArray.AddItem(new House());
            housesListBox.Items.Add(THouse.Name);
            //housesListBox.Items.Add(HousesArray.GetItem.Name());
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (housesListBox.SelectedIndex >= 0)
            {
                HousesArray.RemoveItem(housesListBox.SelectedIndex);
                housesListBox.Items.Remove(housesListBox.SelectedItem);
            }
        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (housesListBox.SelectedIndex >= 0)
            {
                THouse.Name=descriptionTextBox.Text;
                HousesArray.SetItem(THouse, housesListBox.SelectedIndex);
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
            HousesArray.SaveToFile("Heuses.dat");
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
