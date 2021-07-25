using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_
{
    class ProductManager
    {//encapsulation
        // void sadece işini yapar gidip siler gidip ekler bilgi bilmez
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + "eklendi");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "Güncellendi");
        }

        public int Topla1(int sayi1,int sayi2)
        {
            return sayi1+ sayi2;
        }
        // void 1 kere döndürür yapar bitirir intte hesaplanan veriyi kullanabilirsin tekrardan 4.ders 1.22
        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1+sayi2);
        }
    }
}
