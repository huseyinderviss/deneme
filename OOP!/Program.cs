﻿using System;

namespace OOP_
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id=2,CategoryId=5,UnitsInStock=5,ProductName="kalem",UnitPrice=35};

            //PascalCase camelCase
            //case sesnsitive
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);



            /*int toplamaSonucu = productManager.Topla1(3, 6);
            Console.WriteLine(toplamaSonucu * 2);*/




        }
    }
}