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
    public partial class TariffSelection : Form
    {
        private SQLRequest Tsql = new SQLRequest();
        private string temp;
        public string TarifPrice { get; set; }

        public TariffSelection()
        {
            InitializeComponent();
        }

        private void TariffSelection_Load(object sender, EventArgs e)
        {
            foreach (var item in Tsql.SqlRequest("SELECT distinct `Субъект РФ` FROM Регион"))
            {
                subjectRFComboBox.Items.Add(item);
            }
        }

        private void subjectRFComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            municipalDistrictComboBox.Items.Clear();
            foreach (var item in Tsql.SqlRequest("SELECT distinct `Муниципальный район` FROM Регион WHERE `Субъект РФ` = '" + subjectRFComboBox.Items[subjectRFComboBox.SelectedIndex] + "'"))
            {
                municipalDistrictComboBox.Items.Add(item);
            }
            municipalDistrictComboBox.Enabled = true;
            municipalityComboBox.Enabled = false;
            YearComboBox.Enabled = false;
            monthComboBox.Enabled = false;
            accommodationsComboBox.Enabled = false;
            communalServiceComboBox.Enabled = false;
            CalculationMethodComboBox.Enabled = false;
            serviceProviderComboBox.Enabled = false;
            improvementKindComboBox.Enabled = false;
        }

        private void municipalDistrictComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            municipalityComboBox.Items.Clear();
            foreach (var item in Tsql.SqlRequest("SELECT distinct `Муниципальное образование` FROM Регион WHERE `Субъект РФ` = '" + subjectRFComboBox.Items[subjectRFComboBox.SelectedIndex] + "' AND `Муниципальный район` = '" + municipalDistrictComboBox.Items[municipalDistrictComboBox.SelectedIndex] + "'"))
            {
                municipalityComboBox.Items.Add(item);
            }
            municipalityComboBox.Enabled = true;
            YearComboBox.Enabled = false;
            monthComboBox.Enabled = false;
            accommodationsComboBox.Enabled = false;
            communalServiceComboBox.Enabled = false;
            CalculationMethodComboBox.Enabled = false;
            serviceProviderComboBox.Enabled = false;
            improvementKindComboBox.Enabled = false;
        }

        private void municipalityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            YearComboBox.Items.Clear();
            foreach (var item in Tsql.SqlRequest("SELECT distinct `Год` FROM Дата"))
            {
                YearComboBox.Items.Add(item);
            }
            YearComboBox.Enabled = true;
            monthComboBox.Enabled = false;
            accommodationsComboBox.Enabled = false;
            communalServiceComboBox.Enabled = false;
            CalculationMethodComboBox.Enabled = false;
            serviceProviderComboBox.Enabled = false;
            improvementKindComboBox.Enabled = false;
        }

        private void YearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            monthComboBox.Items.Clear();
            foreach (var item in Tsql.SqlRequest("SELECT distinct `Месяц` FROM Дата WHERE `Год` = " + YearComboBox.Items[YearComboBox.SelectedIndex]))
            {
                monthComboBox.Items.Add(item);
            }
            monthComboBox.Enabled = true;
            accommodationsComboBox.Enabled = false;
            communalServiceComboBox.Enabled = false;
            CalculationMethodComboBox.Enabled = false;
            serviceProviderComboBox.Enabled = false;
            improvementKindComboBox.Enabled = false;
        }

        private void monthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            temp = Tsql.SqlRequest("SELECT distinct `Расчётный период` FROM Дата WHERE Год = " + YearComboBox.Items[YearComboBox.SelectedIndex] + " AND Месяц = '" + monthComboBox.Items[monthComboBox.SelectedIndex] + "'")[0];
            accommodationsComboBox.Items.Clear();
            foreach (var item in Tsql.SqlRequest("SELECT distinct `Условия проживания` FROM Тариф WHERE `Муниципальное образование` = '" + municipalityComboBox.Items[municipalityComboBox.SelectedIndex] + "' AND `Расчётный период` = " + temp))
            {
                accommodationsComboBox.Items.Add(item);
            }
            accommodationsComboBox.Enabled = true;
            communalServiceComboBox.Enabled = false;
            CalculationMethodComboBox.Enabled = false;
            serviceProviderComboBox.Enabled = false;
            improvementKindComboBox.Enabled = false;
        }

        private void accommodationsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            communalServiceComboBox.Items.Clear();
            foreach (var item in Tsql.SqlRequest("SELECT distinct `Коммунальная услуга` FROM Тариф WHERE `Муниципальное образование` = '" + municipalityComboBox.Items[municipalityComboBox.SelectedIndex] + "' AND `Расчётный период` = " + temp + " AND `Условия проживания` = '" + accommodationsComboBox.Items[accommodationsComboBox.SelectedIndex] + "'"))
            {
                communalServiceComboBox.Items.Add(item);
            }
            communalServiceComboBox.Enabled = true;
            CalculationMethodComboBox.Enabled = false;
            serviceProviderComboBox.Enabled = false;
            improvementKindComboBox.Enabled = false;
        }

        private void communalServiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculationMethodComboBox.Items.Clear();
            foreach (var item in Tsql.SqlRequest("SELECT distinct `Метод расчёта` FROM Тариф WHERE `Муниципальное образование` = '" + municipalityComboBox.Items[municipalityComboBox.SelectedIndex] + "' AND `Расчётный период` = " + temp + " AND `Условия проживания` = '" + accommodationsComboBox.Items[accommodationsComboBox.SelectedIndex] + "' AND `Коммунальная услуга` = '" + communalServiceComboBox.Items[communalServiceComboBox.SelectedIndex] + "'"))
            {
                CalculationMethodComboBox.Items.Add(item);
            }
            CalculationMethodComboBox.Enabled = true;
            serviceProviderComboBox.Enabled = false;
            improvementKindComboBox.Enabled = false;
        }

        private void CalculationMethodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            serviceProviderComboBox.Items.Clear();
            foreach (var item in Tsql.SqlRequest("SELECT distinct `Поставщик услуги` FROM Тариф WHERE `Муниципальное образование` = '" + municipalityComboBox.Items[municipalityComboBox.SelectedIndex] + "' AND `Расчётный период` = " + temp + " AND `Условия проживания` = '" + accommodationsComboBox.Items[accommodationsComboBox.SelectedIndex] + "' AND `Коммунальная услуга` = '" + communalServiceComboBox.Items[communalServiceComboBox.SelectedIndex] + "' AND `Метод расчёта` = '" + CalculationMethodComboBox.Items[CalculationMethodComboBox.SelectedIndex] + "'"))
            {
                serviceProviderComboBox.Items.Add(item);
            }
            serviceProviderComboBox.Enabled = true;
            improvementKindComboBox.Enabled = false;
        }

        private void serviceProviderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            improvementKindComboBox.Items.Clear();
            foreach (var item in Tsql.SqlRequest("SELECT distinct `Вид благоустройства` FROM Тариф WHERE `Муниципальное образование` = '" + municipalityComboBox.Items[municipalityComboBox.SelectedIndex] + "' AND `Расчётный период` = " + temp + " AND `Условия проживания` = '" + accommodationsComboBox.Items[accommodationsComboBox.SelectedIndex] + "' AND `Коммунальная услуга` = '" + communalServiceComboBox.Items[communalServiceComboBox.SelectedIndex] + "' AND `Метод расчёта` = '" + CalculationMethodComboBox.Items[CalculationMethodComboBox.SelectedIndex] + "' AND `Поставщик услуги` = '" + serviceProviderComboBox.Items[serviceProviderComboBox.SelectedIndex] + "'"))
            {
                improvementKindComboBox.Items.Add(item);
            }
            improvementKindComboBox.Enabled = true;
        }

        private void improvementKindComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TarifPrice = (Tsql.SqlRequest("SELECT distinct `Тариф` FROM Тариф WHERE `Муниципальное образование` = '" + municipalityComboBox.Items[municipalityComboBox.SelectedIndex] + "' AND `Расчётный период` = " + temp + " AND `Условия проживания` = '" + accommodationsComboBox.Items[accommodationsComboBox.SelectedIndex] + "' AND `Коммунальная услуга` = '" + communalServiceComboBox.Items[communalServiceComboBox.SelectedIndex] + "' AND `Метод расчёта` = '" + CalculationMethodComboBox.Items[CalculationMethodComboBox.SelectedIndex] + "' AND `Поставщик услуги` = '" + serviceProviderComboBox.Items[serviceProviderComboBox.SelectedIndex] + "' AND `Вид благоустройства` = '" + improvementKindComboBox.Items[improvementKindComboBox.SelectedIndex] + "'")[0]);
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            Tsql.ConnectionClose();
            Close();
        }
    }
}
