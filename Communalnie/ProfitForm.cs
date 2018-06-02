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
    public partial class ProfitForm : Form
    {
        public string Service { get; set; }
        public float Indications { get; set; }
        public string Unit { get; set; }
        public float Cost { get; set; }
        public float Accruals { get; set; }
        private DataArray<Services> DArr;
        public bool Issave { get; set; }

        public ProfitForm()
        {
            InitializeComponent();
            DArr = new DataArray<Services>();
            Issave = false;
        }

        private void ProfitForm_Load(object sender, EventArgs e)
        {
            string meter = "по тарифу";
            DArr.LoadFromFile("Services.dat");
            for (int i = 0; i < DArr.GetTop(); i++)
            {
                if (DArr.GetItem(i).IsMeter == true)
                    meter = "по счётчику";
                servicesComboBox.Items.Add(DArr.GetItem(i).Name + " (" + meter + ")");
            }
        }

        private void servicesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            costTextBox.Text = DArr.GetItem(servicesComboBox.SelectedIndex).Price.ToString();
            Service = DArr.GetItem(servicesComboBox.SelectedIndex).Name;
            Cost = DArr.GetItem(servicesComboBox.SelectedIndex).Price;
            Unit = DArr.GetItem(servicesComboBox.SelectedIndex).Unit;
            unitLabel.Text = Unit;
        }

        private void indicationsTextBox_TextChanged(object sender, EventArgs e)
        {
            if (servicesComboBox.SelectedIndex >= 0)
                try
                {
                    {
                        float result = Convert.ToSingle(indicationsTextBox.Text) * DArr.GetItem(servicesComboBox.SelectedIndex).Price;
                        accrualsTextBox.Text = result.ToString();
                        Accruals = result;
                        Indications = Convert.ToSingle(indicationsTextBox.Text);
                    }
                }
                catch
                {
                    if (indicationsTextBox.Text.Length != 0)
                    {
                        indicationsTextBox.Text = indicationsTextBox.Text.Remove(indicationsTextBox.Text.Length - 1);
                        indicationsTextBox.SelectionStart = indicationsTextBox.Text.Length;
                    }
                }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Issave = true;
            Close();
        }
    }
}
