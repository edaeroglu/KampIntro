using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string kurs1 = "Yazilim gelistirici yetistirme kampi";
            string kurs2 = "Programlamaya baslangic icin temel kurs";
            string kurs3 = "Java";

            Console.WriteLine(kurs1); */

            //array = dizi

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("******Baska ornek******");

            string[] kurslar = new string[] { "Yazilim gelistirici yetistirme kampi", "Programlamaya baslangic icin temel kurs", "Java" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("****For bitti****");

            foreach (string kurs in kurslar) //foreach: Dizi temelli yapıları tek tek dönmeye yarar. -> "Kursları dolaş."
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("Sayfa sonu - footer");
        }
    }
}
