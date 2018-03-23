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
    public partial class DateAndMonthAddForm : Form
    {
        public int Year { get; set; }
        public string Month { get; set; }
        public bool isSave { get; set; }

        public DateAndMonthAddForm()
        {
            InitializeComponent();
            isSave = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (yearComboBox.SelectedIndex >= 0 && monthComboBox.SelectedIndex >= 0)
            {
                Year = Int32.Parse(yearComboBox.SelectedItem.ToString());
                Month = (string)monthComboBox.SelectedItem;
                isSave = true;
                Close();
            }
            else
            {
                MessageBox.Show("Выберите год и месяц");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
