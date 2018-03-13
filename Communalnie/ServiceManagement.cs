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
    public partial class ServiceManagement : Form
    {
        private Services Serv=new Services();
        private DataArray<Services> DArr = new DataArray<Services>();

        public ServiceManagement()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DArr.AddItem(new Services());
            servicesListBox.Items.Add(DArr.GetItem(DArr.GetTop() - 1).Name);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DArr.SaveToFile("Services.dat");
            Close();
        }

        private void ServiceManagement_Load(object sender, EventArgs e)
        {
            DArr.LoadFromFile("Services.dat");
            for (int i = 0; i < DArr.GetTop(); i++)
            {
                Serv = DArr.GetItem(i);
                servicesListBox.Items.Add(Serv.Name);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (servicesListBox.SelectedIndex >= 0)
            {
                DArr.RemoveItem(servicesListBox.SelectedIndex);
                servicesListBox.Items.Remove(servicesListBox.SelectedItem);
            }
        }

        private void serviceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (servicesListBox.SelectedIndex >= 0)
            {
                Serv.Name = serviceTextBox.Text;
                DArr.SetItem(Serv, servicesListBox.SelectedIndex);
                servicesListBox.Items[servicesListBox.SelectedIndex] = serviceTextBox.Text;
            }
        }

        private void servicesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (servicesListBox.SelectedIndex >= 0)
            {
                Serv = DArr.GetItem(servicesListBox.SelectedIndex);
                serviceTextBox.Text = Serv.Name;
                if (Serv.IsMeter == true)
                    meterRadioButton.PerformClick();
                else
                    tariffRadioButton.PerformClick();
                for (int i = 0; i < unitComboBox.Items.Count; i++)
                    if (unitComboBox.Items[i].ToString() == Serv.Unit)
                        unitComboBox.SelectedIndex = i;
                priceTextBox.Text = Serv.Price.ToString();
            }
        }

        private void meterRadioButton_Click(object sender, EventArgs e)
        {
            if (servicesListBox.SelectedIndex >= 0)
            {
                Serv.IsMeter = true;
                DArr.SetItem(Serv, servicesListBox.SelectedIndex);
            }
        }

        private void tariffRadioButton_Click(object sender, EventArgs e)
        {
            if (servicesListBox.SelectedIndex >= 0)
            {
                Serv.IsMeter = false;
                DArr.SetItem(Serv, servicesListBox.SelectedIndex);
            }
        }

        private void unitComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (servicesListBox.SelectedIndex >= 0)
            {
                Serv.Unit = unitComboBox.Items[unitComboBox.SelectedIndex].ToString();
                DArr.SetItem(Serv, servicesListBox.SelectedIndex);
            }
        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (servicesListBox.SelectedIndex >= 0)
                try
                {
                    {
                        Serv.Price = Convert.ToSingle(priceTextBox.Text);
                        DArr.SetItem(Serv, servicesListBox.SelectedIndex);
                    }
                }
                catch
                {
                    if (priceTextBox.Text.Length != 0)
                    {
                        priceTextBox.Text = priceTextBox.Text.Remove(priceTextBox.Text.Length - 1);
                        priceTextBox.SelectionStart = priceTextBox.Text.Length;
                    }
                }
        }

        private void tariffSelectButton_Click(object sender, EventArgs e)
        {
            TariffSelection TariffForm = new TariffSelection();
            TariffForm.ShowDialog();
            priceTextBox.Text = TariffForm.TarifPrice;
        }
    }
}
