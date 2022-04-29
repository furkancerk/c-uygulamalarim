using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje3
{
    class Program
    {
        static void Main(string[] args)
        {
            string sifre, kullaniciadi;
            Console.WriteLine("KULLANICI GİRİS PANELİNE HOS GELDİNİZ!");
            Console.WriteLine();
            Console.Write("Kullanıcı Adı: ");
            kullaniciadi = Console.ReadLine();
            Console.Write("Şifre: ");
            sifre = Console.ReadLine();
            if (kullaniciadi == "cerkfurkan" && sifre == "12345")
            {
                Console.WriteLine("Giriş işlemi başarılı.");
            }
            else
            {
                Console.WriteLine("Giriş işlemi başarısız.");
            }
            Console.Read();

        }
    }
}
