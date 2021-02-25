using System;

namespace MusteriSimulasyon
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1234;
            musteri1.Ad = "Mustafa";
            musteri1.Soyad = "EKİCİ";
            musteri1.Cinsiyet = "Erkek";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 1235;
            musteri2.Ad = "Metin";
            musteri2.Soyad = "YILMAZ";
            musteri2.Cinsiyet = "Erkek";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 1236;
            musteri3.Ad = "Ayşe";
            musteri3.Soyad = "ÇELİK";
            musteri3.Cinsiyet = "Kadın";

            Musteri musteri4 = new Musteri();
            musteri4.Id = 1237;
            musteri4.Ad = "Aleyna";
            musteri4.Soyad = "ÇAĞLAYAN";
            musteri4.Cinsiyet = "Kadın";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            foreach  (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Id+" > "+ musteri.Ad+ " "+ musteri.Soyad+" > "+ musteri.Cinsiyet);
            }
            MusteriManager musterimanager = new MusteriManager();
            musterimanager.MusteriEkleme(musteri1);
            musterimanager.MusteriSilme(musteri2);
            musterimanager.MusteriListeleme(musteri3);
            musterimanager.MusteriEkleme(musteri4);
        }
    }
}
