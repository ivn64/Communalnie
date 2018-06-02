using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communalnie
{
    [Serializable]
    public class Profit
    {
        public string Service { get; set; }
        public float Indications { get; set; }
        public string Unit { get; set; }
        public float Cost { get; set; }
        public float Accruals { get; set; }

        public Profit(string tService, float tIndications, string tUnit, float tCost, float taccruals)
        {
            Service = tService;
            Indications = tIndications;
            Unit = tUnit;
            Cost = tCost;
            Accruals = taccruals;
        }

        public float GetAccruals()
        {
            return Accruals;
        }

        public void SetAccruals()
        {
            Accruals = Indications * Cost;
        }
    }
}
