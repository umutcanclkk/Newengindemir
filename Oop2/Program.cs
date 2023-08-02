﻿using System;

namespace Oop2
{
    public class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Umut Can";
            musteri1.Soyadi = "Çelik";
            musteri1.TcNo = "12345678910";




            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "5656560";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "252525";



            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);






        }
    }
}
