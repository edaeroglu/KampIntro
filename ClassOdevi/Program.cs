using System;

namespace ClassOdevi
{
    /*Herhangi bir e-ticaret sistemine giriniz.Genellikle bir e-ticaret sistemine girdiğinizde ürünler listelenir.
     *Siz de Urun (Product) isimli bir class oluşturup, oluşturduğunuz bir kaç ürünü bir diziye ekleyiniz.
     *Ürünlerinizi for, foreach ve while döngüleri ile ayrı ayrı listeleyiniz.*/

    class Urun
    {
        public string UrunAdi { get; set; }
        public double UrunFiyati { get; set; }
        public int UrunSayisi { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Kulaklık";
            urun1.UrunFiyati = 359.90;
            urun1.UrunSayisi = 30;

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Çanta";
            urun2.UrunFiyati = 145;
            urun2.UrunSayisi = 100;

            Urun urun3 = new Urun();
            urun3.UrunAdi = "Kitap";
            urun3.UrunFiyati = 19.99;
            urun3.UrunSayisi = 50;

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            Console.WriteLine("*****Foreach döngüsüyle yazıldı*****\n");

            foreach (Urun urun in urunler)
            {
                Console.WriteLine("Ürün: " + urun.UrunAdi + "\tFiyatı: " + urun.UrunFiyati + "\tSayısı: " + urun.UrunSayisi);
            }

            Console.WriteLine("\n*****For döngüsüyle yazıldı*****\n");

            for (int i = 0; i < urunler.Length ; i++)
            {
                Console.WriteLine("Ürün: " + urunler[i].UrunAdi);
                Console.WriteLine("Fiyatı: " + urunler[i].UrunFiyati);
                Console.WriteLine("Sayısı: " + urunler[i].UrunSayisi);
                Console.WriteLine("\n");
            }

            Console.WriteLine("\n*****While döngüsüyle yazıldı*****\n");

            int j = 0;
            while (j < urunler.Length)
            {
                Console.WriteLine("Ürün: " + urunler[j].UrunAdi);
                Console.WriteLine("Fiyatı: " + urunler[j].UrunFiyati);
                Console.WriteLine("Sayısı: " + urunler[j].UrunSayisi);
                Console.WriteLine("\n");
                j++;
            }
        }
    }
}
