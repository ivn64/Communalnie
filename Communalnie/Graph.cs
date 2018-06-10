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
    public partial class Graph : Form
    {
        public House SelHouse { get; set; }

        private int fromIndex = 0;
        private int byIndex = 0;

        public Graph(House TSelHouse)
        {
            InitializeComponent();
            SelHouse = new House(TSelHouse);
            byIndex = SelHouse.TablesList.Count;
        }

        private void Graph_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < SelHouse.TablesList.Count; i++)
            {
                bool count = false;
                for (int j = 0; j < fromYearComboBox.Items.Count; j++)
                {
                    if (uint.Parse(fromYearComboBox.Items[j].ToString()) == SelHouse.TablesList[i].Year)
                    {
                        count = true;
                    }
                }
                if (count == false)
                    fromYearComboBox.Items.Add(SelHouse.TablesList[i].Year);
            }
        }

        private void graphPictureBox_Paint(object sender, PaintEventArgs e)
        {
            Pen myPen = new Pen(Brushes.Green);
            myPen.Width = 2.0F;
            Font legendFont = new Font("Arial", 10);
            e.Graphics.DrawString("0", legendFont, new SolidBrush(Color.Black), 0, 400);
            e.Graphics.DrawLine(myPen, 0, 400, 100, 100);
            e.Graphics.DrawLine(myPen, 100, 100, 150, 90);
            myPen.Dispose();
        }

        private void fromYearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            servicesComboBox.Enabled = false;
            byYearComboBox.Enabled = false;
            fromMonthComboBox.Items.Clear();
            fromMonthComboBox.Enabled = true;
            for (int i = 0; i < SelHouse.TablesList.Count; i++)
            {
                if (SelHouse.TablesList[i].Year == Convert.ToInt32(fromYearComboBox.SelectedItem))
                {
                    fromMonthComboBox.Items.Add(SelHouse.TablesList[i].Month);
                }
            }
        }

        private void byYearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            servicesComboBox.Enabled = false;
            byMonthComboBox.Items.Clear();
            byMonthComboBox.Enabled = true;
            for (int i = fromIndex + 1; i < SelHouse.TablesList.Count; i++)
            {
                if (SelHouse.TablesList[i].Year == Convert.ToInt32(byYearComboBox.SelectedItem))
                {
                    byMonthComboBox.Items.Add(SelHouse.TablesList[i].Month);
                }
            }
        }

        private void fromMonthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            servicesComboBox.Enabled = false;
            byYearComboBox.Items.Clear();
            byYearComboBox.Enabled = true;

            for (int i = 0; i < SelHouse.TablesList.Count; i++)
            {
                if (SelHouse.TablesList[i].Year == int.Parse(fromYearComboBox.Items[fromYearComboBox.SelectedIndex].ToString()) && SelHouse.TablesList[i].Month == fromMonthComboBox.Items[fromMonthComboBox.SelectedIndex].ToString())
                {
                    fromIndex = i;
                    break;
                }
            }


            for (int i = fromIndex; i < SelHouse.TablesList.Count; i++)
            {
                bool count = false;
                for (int j = 0; j < byYearComboBox.Items.Count; j++)
                {
                    if (uint.Parse(byYearComboBox.Items[j].ToString()) == SelHouse.TablesList[i].Year)
                    {
                        count = true;
                    }
                }
                if (count == false)
                    byYearComboBox.Items.Add(SelHouse.TablesList[i].Year);
            }
        }

        private void byMonthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            servicesComboBox.Items.Clear();
            servicesComboBox.Enabled = true;
            for (int i = fromIndex; i < byIndex; i++)
            {
                for (int j = 0; j < SelHouse.TablesList[i].ProfitsList.Count; j++)
                    servicesComboBox.Items.Add(SelHouse.TablesList[i].ProfitsList[j].Service);
            }
        }

        private void servicesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
