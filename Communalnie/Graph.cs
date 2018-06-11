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
            

            /*for (int i = fromIndex; i < byIndex; i++)
            {
                for (int j = 0; j < SelHouse.TablesList[i].ProfitsList.Count; j++)
                    if (SelHouse.TablesList[i].ProfitsList[j].Service == servicesComboBox.SelectedItem.ToString())
                    {
                        tempProfits.Add(SelHouse.TablesList[i]);
                    }

                   // servicesComboBox.Items.Add(SelHouse.TablesList[i].ProfitsList[j].Service);
            }*/


            /*Pen myPen = new Pen(Brushes.Green);
            myPen.Width = 2.0F;
            Font legendFont = new Font("Arial", 10);
            e.Graphics.DrawString("0", legendFont, new SolidBrush(Color.Black), 0, 400);
            e.Graphics.DrawLine(myPen, 0, 400, 100, 100);
            e.Graphics.DrawLine(myPen, 100, 100, 150, 90);
            myPen.Dispose();*/
        }

        private void fromYearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            servicesComboBox.Enabled = false;
            byYearComboBox.Enabled = false;
            byMonthComboBox.Enabled = false;
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
            if (byMonthComboBox.Items.Count == 0)
                byMonthComboBox.Items.Add(SelHouse.TablesList[SelHouse.TablesList.Count - 1].Month);
        }

        private void fromMonthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            servicesComboBox.Enabled = false;
            byYearComboBox.Items.Clear();
            byYearComboBox.Enabled = true;
            byMonthComboBox.Enabled = false;

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
            readingsRadioButton.Checked = false;
            priceRadioButton.Checked = false;
        }

        private void readingsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            float minValue = 0;
            float maxValue = 0;
            //int monthCount = 0;
            List<String> monthList = new List<string>();


            for (int i = fromIndex; i < byIndex; i++)
            {
                for (int j = 0; j < SelHouse.TablesList[i].ProfitsList.Count; j++)
                    if (SelHouse.TablesList[i].ProfitsList[j].Service == servicesComboBox.SelectedItem.ToString())
                    {
                        if (minValue > SelHouse.TablesList[i].ProfitsList[j].Cost)
                            minValue = SelHouse.TablesList[i].ProfitsList[j].Cost;
                        if (maxValue < SelHouse.TablesList[i].ProfitsList[j].Cost)
                            maxValue = SelHouse.TablesList[i].ProfitsList[j].Cost;
                        monthList.Add(SelHouse.TablesList[i].Month.Substring(0, 3) + " " + SelHouse.TablesList[i].Year.ToString());
                    }




                    //servicesComboBox.Items.Add(SelHouse.TablesList[i].ProfitsList[j].Service);
            }





            Graphics gr = graphPictureBox.CreateGraphics();
            Graphics grText = graphPictureBox.CreateGraphics();


            Pen myPen = new Pen(Brushes.Green);
            myPen.Width = 2.0F;
            Font legendFont = new Font("Arial", 10);
            grText.TranslateTransform(-400, 420);
            grText.RotateTransform(-90);
            grText.DrawString("январь 2018", legendFont, new SolidBrush(Color.Black), 0, 400);
            grText.TranslateTransform(0, 50);
            grText.DrawString("февраль 2018", legendFont, new SolidBrush(Color.Black), 0, 400);
            gr.DrawLine(myPen, 0, 400, 100, 100);
            gr.DrawLine(myPen, 100, 100, 150, 90);
            myPen.Dispose();

        }
    }
}
