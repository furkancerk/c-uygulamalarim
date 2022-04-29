using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("KLAVYEDEN GİRİLEN KELİMENİN HARFLERİNİ ALFABETİK SIRALAYAN PROGRAM");
            Console.WriteLine();
            Console.Write("Kelime: ");
            string sonuc = "Sonuç: ";
            string kelime = Console.ReadLine();

            char[] array = new char[kelime.Length];
            for (int i = 0; i < kelime.Length; i++)
            {
                array[i] = kelime[i];
            }

            Array.Sort(array);
            for (int j = 0; j < kelime.Length; j++)
            {
                sonuc += array[j];
            }
            Console.WriteLine(sonuc);







            Console.Write("Sayı: ");
            string sayi = Console.ReadLine();
            
            char[] dizi = new char[sayi.Length];
            for (int i = 0; i < sayi.Length; i++)
            {
                dizi[i] = sayi[i];
            }
            Array.Sort(dizi);
            for (int j = 0; j < sayi.Length; j++)
            {
                Console.WriteLine("Sonuc: " + dizi[j]);
            }
            
            
            


            Console.Read();






        }
    }
}
