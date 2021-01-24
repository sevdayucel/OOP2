using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //gerçek müşteri - tüzel müşteri

            //sevda yücel
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "1903";
            musteri1.Adi = "Sevda";
            musteri1.Soyadi = "Yücel";

            //kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "190333";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);



        }
    }
}
