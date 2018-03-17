using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communalnie
{
    [Serializable]
    class ProfitDate
    {
        public string Entity { get; set; }
        public int Year { get; set; }
        public string Month { get; set; }
        private DataArray<Profit> profitList = new DataArray<Profit>();

        public ProfitDate()
        {

        }

        public ProfitDate(int tYear, string tMonth)
        {
            Year = tYear;
            Month = tMonth;
        }

        public DataArray<Profit> GetProfitList()
        {
            return profitList;
        }

        public void SetProfitList(DataArray<Profit> tProfitList)
        {
            profitList = tProfitList;
        }
    }
}
