using System;

namespace Classİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // class mantığına giriş
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.KursunEgitmeni = "Hüseyin Derviş";
            kurs1.IzlenmeOranı = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.KursunEgitmeni = "Kerem";
            kurs2.IzlenmeOranı = 64;
            Console.WriteLine("Hello World!");

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.KursunEgitmeni = " Berkay";
            kurs3.IzlenmeOranı = 80;


            Kurs[] kurslar = new Kurs[] {
            kurs1,kurs2,kurs3
            };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(/*kurs.KursAdi*/kurs.KursAdi+":"+kurs.KursunEgitmeni);

            }



            Console.WriteLine("Hello World!");
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursunEgitmeni { get; set; }
        public int IzlenmeOranı { get; set; }
    }
}
