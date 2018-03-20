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
        public string Entity { get; set; }
        public int Year { get; set; }
        public string Month { get; set; }
        private List<Profit> profitList;

        public ProfitTable()
        {
            profitList = new List<Profit>();
        }

        public ProfitTable(string tEntity)
        {
            Entity = tEntity;
        }
    }
}
