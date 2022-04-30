using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonemSonuNotuHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            int v, f, ort;
            Console.WriteLine("Dönem Sonu Notu Hesaplama!");
            Console.WriteLine();

            Console.Write("Vize: ");
            v = Convert.ToInt16(Console.ReadLine());

            Console.Write("Final: ");
            f = Convert.ToInt16(Console.ReadLine());

            ort = (v * 40 / 100) + (f * 60 / 100);

            Console.WriteLine("Ortalama: " + ort);

            Console.Read();

                




        }
    }
}
