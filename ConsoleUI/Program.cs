using Business.Concrete;
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

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
