using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Communalnie
{
    class DataArray<T>
    {
        private int[] Arr = new int[10];

        private T[] myArray;

        private int length, top; //длина и последний элемент

        public DataArray()
        {
            length = 10;
            myArray = new T[length];
        }

        public void AddItem(T item)
        {
            if (top < length)
                myArray[top++] = item;
        }

        public void RemoveItem(int index)
        {
            if (index < top)
                for (int i = index; i < top; i++)
                {
                    myArray[i] = myArray[i + 1];
                }
            top--;
        }

        public int GetTop()
        {
            return top;
        }

        public T GetItem(int i)
        {
            return myArray[i];
        }

        public void SetItem(T item, int index)
        {
            myArray[index] = item;
        }

        public void SaveToFile(string fileName)
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            using (FileStream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                byte[] bArray = BitConverter.GetBytes(top);
                fStream.Write(bArray, 0, bArray.Length);
                for (int i = 0; i < top; i++)
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
                    top = BitConverter.ToInt32(bArray, 0);
                    for (int i = 0; i < top; i++)
                    {
                        myArray[i] = (T)binFormat.Deserialize(fStream);
                    }
                }
            }
            catch
            {

            }
        }
    }
}
