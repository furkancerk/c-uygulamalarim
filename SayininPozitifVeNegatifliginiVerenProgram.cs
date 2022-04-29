using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.WriteLine("SAYININ POZİTİF VEYA NEGATİFLİĞİNİ GÖSTEREN ALGORİTMA");
            Console.WriteLine();
            Console.Write("Sayı: ");
            sayi = Convert.ToInt16(Console.ReadLine());

            if (sayi < 0)
            {
                Console.WriteLine("-");
            }
            else if (sayi > 0)
            {
                Console.WriteLine("+");
            }
            else if (sayi == 0)
            {
                Console.WriteLine("Nötr");
            }

            Console.ReadLine();
        }
    }
}
