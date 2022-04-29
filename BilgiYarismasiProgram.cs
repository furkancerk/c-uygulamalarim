using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilgiyarismasideneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME");
            Console.WriteLine();
            Console.WriteLine("--------------");
            Console.WriteLine();
            string cevap;
            int soru = 1;
            
            if(soru==1)
            {
                Console.WriteLine("1-) Cumhuriyetin kuruluş yılı?");
                Console.WriteLine();
                Console.WriteLine("A-) 1923");
                Console.WriteLine("B-) 1920");
                Console.WriteLine("C-) 1924");
                Console.WriteLine("D-) 1922");
                Console.Write("Cevabınız: ");
                cevap =(Console.ReadLine());
                if (cevap == "a" | cevap == "A")
                {
                    soru = soru + 1;
                }
                else
                {
                    Console.WriteLine("Cevabınız yanlış.");
                }
            }
            if(soru==2)
            {
                Console.WriteLine("2-) Atatürk'ün doğum yılı?");
                Console.WriteLine();
                Console.WriteLine("A-) 1880");
                Console.WriteLine("B-) 1938");
                Console.WriteLine("C-) 1881");
                Console.WriteLine("D-) 1934");
                Console.Write("cevabınız: ");
                cevap = Console.ReadLine();
                if (cevap == "c" | cevap == "C") 
                {
                    soru = soru + 1;
                }
                else
                {
                    Console.WriteLine("Cevabınız yanlış.");
                }
            }
            if(soru==3)
            {
                Console.WriteLine("3-) TBMM'nin kuruluş yılı nedir?");
                Console.WriteLine();
                Console.WriteLine("A-) 1923");
                Console.WriteLine("B-) 1934");
                Console.WriteLine("C-) 1920");
                Console.WriteLine("D-) 1921");
                Console.Write("Cevabınız: ");
                cevap = Console.ReadLine();
                if (cevap == "c" | cevap == "C")
                {
                    Console.WriteLine("TEBRİKLER!");
                }
                else
                {
                    Console.WriteLine("Cevabınız yanlış.");
                }
            }


            Console.Read();


        }
    }
}
