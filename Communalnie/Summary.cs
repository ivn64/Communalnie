using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communalnie
{
    [Serializable]
    class Summary
    {
        public string Entity {get; set;}
        public int Year { get; set; }
        public string Month { get; set; }
        public string Service { get; set; }
        public float Indications { get; set; }
        public float Cost { get; set; }

        private float accruals;

        public float GetAccruals()
        {
            return accruals;
        }

        public void SetAccruals()
        {
            accruals = Indications * Cost;
        }
    }
}
