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
        public List<Profit> profitsList { get; set; }

        public ProfitTable()
        {
            profitsList = new List<Profit>();
        }

        public ProfitTable(int tYear, string tMonth)
        {
            profitsList = new List<Profit>();
            Year = tYear;
            Month = tMonth;
        }
    }
}
