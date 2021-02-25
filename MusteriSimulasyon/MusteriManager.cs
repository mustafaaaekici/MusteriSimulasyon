using System;
using System.Collections.Generic;
using System.Text;

namespace MusteriSimulasyon
{
    class MusteriManager
    {
        public void MusteriEkleme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi.Eklenen Müşteri Bilgileri : " + musteri.Id + " -> " + musteri.Ad + " " + musteri.Soyad + " -> " + musteri.Cinsiyet);
        }
        public void MusteriSilme(Musteri musteri) 
        {
            Console.WriteLine("Müşteri Silindi.Silinen Müşteri Bilgileri : " + musteri.Id + " -> " + musteri.Ad + " " + musteri.Soyad + " -> " + musteri.Cinsiyet);
        }
        public void MusteriListeleme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listelendi.Listelenen Müşteri Bilgileri : " + musteri.Id + " -> " + musteri.Ad + " " + musteri.Soyad + " -> " + musteri.Cinsiyet);
        }
    }
}
