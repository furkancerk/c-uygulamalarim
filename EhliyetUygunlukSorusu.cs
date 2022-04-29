using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje2
{
    class Program
    {
        static void Main(string[] args)
        {
            int yas;
            Console.WriteLine("EHLİYET UYGUNLUK SORUSU");
            Console.WriteLine();
            Console.Write("Yaşınızı giriniz: ");
            yas = Convert.ToInt16(Console.ReadLine());
            if (yas >= 18)
            {
                Console.WriteLine("Ehliyet alabilirsiniz.");
            }
            else
            {
                Console.WriteLine("Ehliyet almaya yaşınız yetmiyor.");
            }

            Console.Read();
        }
    }
}
