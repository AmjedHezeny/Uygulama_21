using System;

namespace Uygulama_21
{
    internal class Ogrenci
    {
        public string ad, soyad;
        public int okulNo;
        public double n1, n2;
        public double ortalama
        {
            get { return (n1 * 40 / 100) + (n2 * 60 / 100) ; }
                
        }
        public string tamAd
        {
            get { return ad + " " + soyad; }
        }

        public void Yazdir()
        {
            Console.WriteLine("Adı ve Soyadı : " + tamAd);
            Console.WriteLine("Öğrenci Okul NO : " + okulNo);
            Console.WriteLine("Öğrencinin Notları : Vize: {0} | Finel: {1}", n1, n2);
            Console.WriteLine("Öğrencinin Ortalaması : " + ortalama);
            if (ortalama < 50)
            {
                Console.WriteLine("********************************************");
                Console.WriteLine("Geçme Notu (50) Üzeri Olmalı.");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("(100/" + ortalama + ")" + " Bu Öğrenci Dersinden Kaldı.");
                Console.WriteLine("********************************************");
            }
            else
            {
                Console.WriteLine("********************************************");
                Console.WriteLine("(100/" + ortalama + ")" + " Bu Öğrenci Dersinden Geçti.");
                Console.WriteLine("********************************************");
            }
        }
        public void Yazdir(int siraNo)
        {
            Console.WriteLine(siraNo + " - " + tamAd);
        }
    }
}
