using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_21
{
    internal static class MenuIslemleri
    {
        static List<Ogrenci> ogrenciler = new List<Ogrenci>();

        public static void Islemler(ConsoleKey secim)
        {
            switch (secim)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    OgrenciEkle("Öğrenci Ekleme Ekranı.");
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    OgrencSil("Öğrenci Silme Ekranı.");
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    OgrencileriListele("Kayıtlı Öğrencilerin Listesi.");
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    OgrenciAra("Öğrenci Arama Ekranı.");
                    break;
                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    ToplamOgrenci("Toplam Öğrenci Sayısı."); break;
                case ConsoleKey.D6:
                case ConsoleKey.NumPad6:
                    GenelNotOrtalamasi("Öğrencilerin Genel Not Ortalaması.");
                    break;
                case ConsoleKey.D0:
                case ConsoleKey.NumPad0:

                    break;
                default:
                    Console.Clear();
                    AnaMenuyeDon("Geçersiz İşlem Türü Seçtiniz.");
                    break;

            }
        }

        private static void AnaMenuyeDon(string metin)
        {
            Console.WriteLine();
            Console.WriteLine(metin);
            Console.WriteLine("Ana Menüye Dönmek İçin Herhangi Bir Tuşa Basınız.");
            Console.ReadKey();
        }
        private static void BaslikYazdir(string metin)
        {
            Console.Clear();
            Console.WriteLine(metin);
            Console.WriteLine("****************");
            Console.WriteLine();
        }

        // ------------ Switch Case İşlem Metodları -----------------
        private static void OgrenciEkle(string metin)
        {
            BaslikYazdir(metin);
            Ogrenci ogr = new Ogrenci();
            ogr.ad = Metodlar.StringDegerAl("Öğrencinin Adını Giriniz: ");
            ogr.soyad = Metodlar.StringDegerAl("Öğrenci Soyadını Giriniz: ");
            ogr.okulNo = Metodlar.IntDegeriAl("Öğrencinin Okul No Sunu Giriniz: ");
            ogr.n1 = Metodlar.DoubleDegeriAl("Öğrencinin Vize Sınav Notunu Giriniz: ", 1, 100);
            ogr.n2 = Metodlar.DoubleDegeriAl("Öğrencinin Finel Sınav Notunu Giriniz: ", 1, 100);
            ogrenciler.Add(ogr);
            AnaMenuyeDon("Kayıt İşlemi Başarılı Bir Şekilde Gerçekleşti.");
        }

        private static void OgrencSil(string metin)
        {
            BaslikYazdir(metin);
            if (ogrenciler.Any())//if(ogrenciler.Count>0)
            {
                for (int i = 0; i < ogrenciler.Count; i++)
                {
                    ogrenciler[i].Yazdir(i + 1);
                }
                int siraNo = Metodlar.IntDegeriAl("Silmek İstediğiniz Öğrencinin Sıra Numarasını Giriniz: ", 1, ogrenciler.Count);
                ogrenciler.RemoveAt(siraNo - 1);
                AnaMenuyeDon("Silme İşlemi Başarıyla Gerçekleşti.");
            }
            else
            {
                AnaMenuyeDon("Kayıtlı Öğrenci Bulunamadı.");

            }
        }

        private static void OgrencileriListele(string metin)
        {
            BaslikYazdir(metin);
            if (ogrenciler.Any())
            {
                foreach (var item in ogrenciler)
                {
                    item.Yazdir();
                    Console.WriteLine();
                }
                AnaMenuyeDon(string.Format("Toplam {0} Adet Öğrenci Listelenmiştir.", ogrenciler.Count));

            }
            else
            {
                AnaMenuyeDon("Kayıtlı Öğrenci Bulunamadı.");

            }
        }
        private static void OgrenciAra(string metin)
        {
            BaslikYazdir(metin);
            if (ogrenciler.Any())
            {
                string aranacakOgrenci = Metodlar.StringDegerAl("Aramak İstediğiniz Öğrencinin Adını Veya Soyadını Giriniz: ");
                int adet = 0;
                foreach (var item in ogrenciler)
                {
                    if (item.tamAd.ToLower().Contains(aranacakOgrenci.ToLower()))
                    {
                        adet++;
                        item.Yazdir(adet);
                    }
                }
                AnaMenuyeDon(string.Format("{0} Kelimesine Karşılık {1} Tane Sonuç Bulunmuştur.", aranacakOgrenci, adet));
            }
            else
            {
                AnaMenuyeDon("Listede Kayıtlı Öğrenci Bulunamadı.");
            }
        }
        private static void ToplamOgrenci(string metin)
        {
            BaslikYazdir(metin);
            if (ogrenciler.Any())
            {
                AnaMenuyeDon(string.Format("Listede {0} Adet Öğrenci Vardır.", ogrenciler.Count));
            }
            else
            {
                AnaMenuyeDon("Listede Kayıtlı Öğrenci Bulunamadı.");

            }

        }
        private static void GenelNotOrtalamasi(string metin)
        {
            BaslikYazdir(metin);
            if (ogrenciler.Any())
            {
                double ortToplam = 0;
                foreach (var item in ogrenciler)
                {
                    ortToplam += item.ortalama;
                }
                double ortSonuc = ortToplam / ogrenciler.Count;
                AnaMenuyeDon(string.Format("{0} Adet Öğrencinin Genel Not Ortalması = {1}", ogrenciler.Count, Math.Round(ortSonuc, 2)));

            }
            else
            {
                AnaMenuyeDon("Listede Kayıtlı Öğrenci Bulunamadı.");

            }
        }
    }
}