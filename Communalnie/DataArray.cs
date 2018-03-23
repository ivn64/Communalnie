using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Communalnie
{
    [Serializable]
    public class DataArray<T>
    {
        private List<T> myArray;

        public DataArray()
        {
            myArray = new List<T>();
        }

        public DataArray(DataArray<T> Temp)
        {
            myArray = new List<T>();
            myArray.AddRange(Temp.myArray);
        }

        public void Clone(DataArray<T> Temp)
        {
            myArray.AddRange(Temp.myArray);
        }

        public void AddItem(T item)
        {
            myArray.Add(item);
        }

        public void RemoveItem(int index)
        {
            myArray.RemoveAt(index);
        }

        public int GetTop()
        {
            return myArray.Count();
        }

        public T GetItem(int i)
        {
            return myArray[i];
        }

        public void SetItem(T item, int index)
        {
            myArray[index] = item;
        }

        public void RemoveItems()
        {
            myArray.Clear();
        }

        public void SaveToFile(string fileName)
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            using (FileStream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                byte[] bArray = BitConverter.GetBytes(myArray.Count());
                fStream.Write(bArray, 0, bArray.Length);
                for (int i = 0; i < myArray.Count(); i++)
                {
                    binFormat.Serialize(fStream, myArray[i]);
                }
            }
        }

        public void LoadFromFile(string fileName)
        {
            try
            {
                BinaryFormatter binFormat = new BinaryFormatter();
                using (FileStream fStream = File.OpenRead(fileName))
                {
                    byte[] bArray = new byte[sizeof(int)];
                    fStream.Read(bArray, 0, bArray.Length);
                    int top = BitConverter.ToInt32(bArray, 0);
                    for (int i = 0; i < top; i++)
                    {
                        myArray.Add((T)binFormat.Deserialize(fStream));
                    }
                }
            }
            catch
            {

            }
        }
    }
}
