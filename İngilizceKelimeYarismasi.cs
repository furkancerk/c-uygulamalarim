using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ingilizcekelimeyarismasi
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("----İNGİLİZCE KELİME ÇALIŞMASINA HOŞ GELDİNİZ----");
            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
            string kelime;
            int soru = 1;
            Console.Write("greeting - ");
            kelime = Console.ReadLine();
            if (kelime=="selamlamak")
            {
                soru = soru + 1;
                Console.WriteLine("Doğru.");
            }
            else
            {
                Console.WriteLine("Yanlış.");
            }
            if (soru == 2)
            {
                Console.Write("multiply - ");
                kelime = Console.ReadLine();
                if (kelime == "çoğaltmak")
                {
                    soru = soru + 1;
                    Console.WriteLine("Doğru.");
                }
                else
                {
                    Console.WriteLine("Yanlış.");
                }
            }
            if (soru == 3) 
            {
                Console.Write("devide - ");
                kelime = Console.ReadLine();
                if (kelime == "bölmek")
                {
                    soru = soru + 1;
                    Console.WriteLine("Doğru.");
                }
                else
                {
                    Console.WriteLine("Yanlış.");
                }
            }
            if (soru == 4)
            {
                Console.Write("concaterate - ");
                kelime = Console.ReadLine();
                if (kelime == "birleştirmek")
                {
                    soru = soru + 1;
                    Console.WriteLine("Doğru.");
                }
                else
                {
                    Console.WriteLine("Yanlış.");
                }
            }
            if (soru == 5) 
            {
                Console.Write("variable - ");
                kelime = Console.ReadLine();
                if (kelime == "değişken")
                {
                    soru = soru + 1;
                    Console.WriteLine("Doğru.");
                }
                else
                {
                    Console.WriteLine("Yanlış.");
                }
            }
            if (soru == 6)
            {
                Console.Write("assign - ");
                kelime = Console.ReadLine();
                if (kelime == "atamak")
                {
                    soru = soru + 1;
                    Console.WriteLine("Doğru.");
                }
                else
                {
                    Console.WriteLine("Yanlış.");
                }
            }
            if (soru == 7)
            {
                Console.Write("display - ");
                kelime = Console.ReadLine();
                if (kelime == "görüntü")
                {
                    soru = soru + 1;
                    Console.WriteLine("Doğru.");
                }
                else
                {
                    Console.WriteLine("Yanlış.");
                }
            }
            if (soru == 8)
            {
                Console.Write("appropriate - ");
                kelime = Console.ReadLine();
                if (kelime == "uygun")
                {
                    soru = soru + 1;
                    Console.WriteLine("Doğru.");
                }
                else
                {
                    Console.WriteLine("Yanlış.");
                }
            }
            if (soru == 9)
            {
                Console.Write("value - ");
                kelime = Console.ReadLine();
                if (kelime == "değer")
                {
                    soru = soru + 1;
                    Console.WriteLine("Doğru.");
                }
                else
                {
                    Console.WriteLine("Yanlış.");
                }
            }











            Console.Read();
        }
    }
}
