using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communalnie
{
    [Serializable]
    class House
    {
        public string Name { get; set; }

        public string Adress { get; set; }

        public float TotalArea { get; set; }

        public int NumberOfPeoples { get; set; }

        public bool IsPrivate { get; set; }

        public House()
        {
            Name = "Новый объект";
            Adress = "адрес";
            TotalArea = 0;
            NumberOfPeoples = 0;
            IsPrivate = false;
        }
    }
}
