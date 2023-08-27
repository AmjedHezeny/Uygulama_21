using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_21
{
    public static class Metodlar
    {
        private static bool SayiKontrol(string metin)
        {
            foreach (char item in metin)
            {
                if (char.IsDigit(item))
                {
                    return true;
                }
            }
            return false;

        }
        public static string StringDegerAl(string metin)
        {
            string text = string.Empty;
            bool hata = true;
            do
            {
                Console.Write(metin);
                text = Console.ReadLine();
                if (SayiKontrol(text))
                {
                    Console.WriteLine("Sayısal İfade Kullanmayınız.");
                    hata = true;
                }
                else if (string.IsNullOrEmpty(text))
                {
                    Console.WriteLine("Boş Bırakılamaz.");
                    hata = true;
                }
                else
                {
                    hata = false;
                }

            } while (hata);
            return text;
        }

        public static int IntDegeriAl(string metin, int min = int.MinValue, int max = int.MaxValue)
        {
            int sayi = 0;
            bool hata = true;
            do
            {
                Console.Write(metin);
                try
                {
                    sayi = int.Parse(Console.ReadLine());
                    if (sayi >= min && sayi <= max)
                    {
                        hata = false;
                    }
                    else
                    {
                        hata = true;
                        Console.WriteLine("Girilen Sayı {0} İle {1} Aralığında Olmalı.", min, max);
                        Console.WriteLine();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                    hata = true;

                }


            } while (hata);
            return sayi;
        }

        public static double DoubleDegeriAl(string metin, double min = double.MinValue, double max = double.MaxValue)
        {
            double sayi = 0;
            bool hata = true;
            do
            {
                Console.Write(metin);
                try
                {
                    sayi = double.Parse(Console.ReadLine());
                    if (sayi >= min && sayi <= max)
                    {
                        hata = false;
                    }
                    else
                    {
                        hata = true;
                        Console.WriteLine("Girilen Sayı {0} İle {1} Aralığında Olmalı.", min, max);
                        Console.WriteLine();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                    hata = true;

                }

            } while (hata);
            return sayi;
        }
    }
}
