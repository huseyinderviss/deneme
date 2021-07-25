using System;
using System.Collections.Generic;

namespace Genericsİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");
            Console.WriteLine(isimler.Lenght);
            isimler.Add("Ahmet");
            Console.WriteLine(isimler.Lenght);

            foreach (var isim in isimler.Items)
            {

                Console.WriteLine(isim);
            }
        }
    }
}
