using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communalnie
{
    [Serializable]
    public class ProfitTable
    {
        public int Year { get; set; }
        public string Month { get; set; }
        public List<Profit> ProfitsList { get; set; }

        public ProfitTable()
        {
            ProfitsList = new List<Profit>();
        }

        public ProfitTable(ProfitTable Temp)
        {
            Year = Temp.Year;
            Month = Temp.Month;
            ProfitsList = new List<Profit>();
            ProfitsList.AddRange(Temp.ProfitsList);
        }

        public ProfitTable(int tYear, string tMonth)
        {
            ProfitsList = new List<Profit>();
            Year = tYear;
            Month = tMonth;
        }
    }
}
