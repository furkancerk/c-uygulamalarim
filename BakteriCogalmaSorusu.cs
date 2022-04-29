using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bakterisorusu
{
    class Program
    {
        static void Main(string[] args)
        {
            int saat, bakteri = 1;

            for (saat = 1; saat <= 24; saat = saat + 1)
            {
                bakteri = bakteri * 2;
            }
            Console.WriteLine(bakteri);
            Console.Read();
        }
    }
}
