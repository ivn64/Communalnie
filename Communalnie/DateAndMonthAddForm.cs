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

        public DateAndMonthAddForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Year = (int)yearComboBox.SelectedItem;
            Month = (string)monthComboBox.SelectedItem;
            Close();
        }
    }
}
