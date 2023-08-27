using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey secim;
            do
            {
                Console.Clear();
                Console.WriteLine("***********************");
                Console.WriteLine("Öğrenci Kayıt Programı Hoş Geldiniz :)");
                Console.WriteLine("***********************");
                Console.WriteLine("0).Programdan Çıkış.");
                Console.WriteLine("1).Öğrenci Ekle.");
                Console.WriteLine("2).Öğrenci Sil.");
                Console.WriteLine("3).Öğrenci Listele.");
                Console.WriteLine("4).Öğrenci Ara.");
                Console.WriteLine("5).Toplam Öğrenci Sayısını Göster.");
                Console.WriteLine("6).Öğrencilerin Genel Not Ortalaması.");
                Console.WriteLine("*******************************");
                Console.WriteLine("Hangi İşlemi Yapmak istersiniz.");
                Console.WriteLine("*******************************");
                secim = Console.ReadKey().Key;
                MenuIslemleri.Islemler(secim);

            } while (secim != ConsoleKey.D0 && secim != ConsoleKey.NumPad0);

            Console.Clear();
            Console.WriteLine("********************************************");
            Console.WriteLine("Programı Kullandığınız İçin Teşekkür Ederiz :)");
            Console.WriteLine("********************************************");
            Console.WriteLine("Çıkış Yapmak İçin Herhangi Bir Tuşa Basınız.");
            Console.ReadKey();

        }
    }
}
