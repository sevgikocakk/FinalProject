﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        //abstractlara referans tutucuları koyuyoruz.abstract ile uygulamalar arasındaki
        //bağımlıkları minimize ediyoruz.
        //concrete gerçek işi yapan somutları koyuyoruz.

        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            //foreach (var product in productManager.GetAll())
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            //foreach (var product in productManager.GetAllByCategoryId(2))
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            //ProductTest();
            //CategoryTest();

            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName +"/"+product.CategoryName);
            }

        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest(ProductManager productManager)
        {
            foreach (var product in productManager.GetByUnitPrice(50, 100))
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
