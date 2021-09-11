using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "123456";
            musteri1.Adi = "burak";
            musteri1.Soyad = "altay";
            musteri1.Id = 1;
            musteri1.TcNo = "2022222";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "28895";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "74568768";


            //GERCEK MUSTTERİ - Tüzel musteri
            // Solıd

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            MusteriManeger musteriManeger = new MusteriManeger();
            musteriManeger.Ekle(musteri1);
            musteriManeger.Ekle(musteri2);



        }
    }
}
