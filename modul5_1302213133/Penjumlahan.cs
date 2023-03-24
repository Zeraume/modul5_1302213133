using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302213133
{
    public class Penjumlahan
    {

        public static T JumlahTigaAngka<T>(T input1, T input2, T input3)
        {
            dynamic hasil = null;
            hasil = (dynamic)input1 + (dynamic)input2 + (dynamic)input3;
            return hasil;
        }
    }
}
