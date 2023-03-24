using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302213133
{
    internal class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDate;

        public SimpleDataBase()
        {
            this.storedData= new List<T>();
            this.inputDate= new List<DateTime>();
        }

        public void addNewData(T NewData)
        {
            storedData.Add(NewData);
            inputDate.Add(DateTime.Now);
        }

        public void printAllData()
        {
            for(int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine("Data " + (i+1) + " berisi: " + storedData[i] + ", yang disimpan pada waktu UTC: " + inputDate[i]);
            }
        }
    }
}
