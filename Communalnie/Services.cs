using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communalnie
{
    [Serializable]
    class Services
    {
        public string Name {get; set;}

        public bool IsMeter { get; set; }

        public string Unit { get; set; }

        public float Price { get; set; }

        public Services()
        {
            Name = "Новая услуга";
            IsMeter = true;
            Unit = "м2";
            Price = 0;
        }
    }
}
