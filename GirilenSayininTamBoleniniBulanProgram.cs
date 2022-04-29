using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tambolenleribulma
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, bolen;
            Console.Write("Sayıyı giriniz: ");
            sayi = Convert.ToInt16(Console.ReadLine());
            for (bolen = 1; bolen <= sayi; bolen = bolen + 1)
            {
                if (sayi % bolen == 0)
                {
                    Console.WriteLine(bolen);
                }
            }
            Console.Read();
        }
    }
}
