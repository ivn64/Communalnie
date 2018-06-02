using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communalnie
{
    [Serializable]
    public class House
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public float TotalArea { get; set; }
        public int NumberOfPeoples { get; set; }
        public bool IsPrivate { get; set; }
        public List<ProfitTable> TablesList { get; set; }

        public House()
        {
            Name = "Новый объект";
            Adress = "адрес";
            TotalArea = 0;
            NumberOfPeoples = 0;
            IsPrivate = false;
            TablesList = new List<ProfitTable>();
        }

        public House(House Temp)
        {
            Name = Temp.Name;
            Adress = Temp.Adress;
            TotalArea = Temp.TotalArea;
            NumberOfPeoples = Temp.NumberOfPeoples;
            IsPrivate = Temp.IsPrivate;
            TablesList = new List<ProfitTable>();
            for (int i = 0; i < Temp.TablesList.Count; i++)
            {
                TablesList.Add(new ProfitTable(Temp.TablesList[i]));
            }
        }
    }
}
