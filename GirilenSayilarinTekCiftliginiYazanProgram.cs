using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace girilen10sayinintekciftliginiyazanprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Girilen 10 sayının tek-çiftliğini yazan program.");
            Console.WriteLine();


            int[] sayi = new int[10];
            int i;
            
            for (i = 0; i < 10; i++)
            {
                Console.Write("Sayıyı giriniz..:");
                sayi[i] = Convert.ToInt16(Console.ReadLine());
            }
            
            Console.Write("Çift Sayılar: ");
            

            for (i = 0; i <= 9; i++)
            {
                if (sayi[i] % 2 == 0)
                {
                    Console.WriteLine(sayi[i]);
                }
            } 
            Console.Write("Tek Sayılar: ");
            
            for (i = 0; i <= 9; i++)
            {
                if (sayi[i] % 2 == 1)
                {
                    Console.WriteLine(sayi[i]);
                } 
            }
            Console.ReadKey();
        }
    }
}
