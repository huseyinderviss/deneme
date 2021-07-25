using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            ////açığı olan kod
            //Musteri musteri1 = new Musteri();
            //musteri1.Adi = "Hüseyin";
            //musteri1.Soyadi = "Derviş";
            //musteri1.Id = 1;
            //musteri1.TcNo = "2222222";
            //musteri1.MusteriNo = "12345";
            //musteri1.SirketAdi = "?";
            //Gerçek-Tüzel
            //Solid

            //gerçek müşteri hüseyin derviş
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "hüseyin";
            musteri1.Soyadi = "Derviş";
            musteri1.TcNo = "22222";
            musteri1.Id = 1;

            //tüzel müşteri girişi
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";







        }
    }
}
