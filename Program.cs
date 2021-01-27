using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Şevval";
            musteri1.Soyad = "Özdemir";
            musteri1.Id = 125672;

            //11 sene oldu gel artık :(

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Metin";
            musteri2.Soyad = "Bahçeci";
            musteri2.Id = 16860254;

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Kadir";
            musteri3.Soyad = "AyranÇeynemez";
            musteri3.Id = 513154354;

            Musteri[] musteriler = new Musteri[] { musteri1,musteri2,musteri3};
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Kullanıcı Adınızı Giriniz :" + musteri1.Ad);
                Console.WriteLine("Kullanıcı Soyadını Giriniz :" + musteri1.Soyad);
                Console.WriteLine("Lütfen Parolayı Giriniz!" + musteri1.Id);
                Console.WriteLine("----------------------------------");

                Console.WriteLine("Kullanıcı Adınızı Giriniz :" + musteri2.Ad);
                Console.WriteLine("Kullanıcı Soyadını Giriniz :" + musteri2.Soyad);
                Console.WriteLine("Lütfen Parolayı Giriniz!" + musteri2.Id);
                Console.WriteLine("----------------------------------");

                Console.WriteLine("Kullanıcı Adınızı Giriniz :" + musteri3.Ad);
                Console.WriteLine("Kullanıcı Soyadını Giriniz :" + musteri3.Soyad);
                Console.WriteLine("Lütfen Parolayı Giriniz!" + musteri3.Id);
                Console.WriteLine("----------------------------------");

            }
            

        }
    }
}
