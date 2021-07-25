using System;

namespace deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            //değer tutucu alias
            // int tam sayı double decimal ondalıklı sayı
            // bool veri tipi true false döndürür giriş yapmış mı yapmamış mı gibi


            //arrayler length ne işe yarıyo bak
            
            string[] kurslar = new string[]
            {
                "Yazılım geliştirme kampı","Programlamaya başlamak için temel kurs","Java","Python"
            };
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);

            }

            // foreach dizilere uygulanır -- foreach dizileri dolaşır yani burda kursları dolaşır
            //kurs döngüdeyken kullanılan takma isim 
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa Sonu-Footer");
        }
    }
}
