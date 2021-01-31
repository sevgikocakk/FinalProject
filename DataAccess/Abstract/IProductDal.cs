using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //İnterface metodları default publictir, interface'in kendisi değil o yüzden public yaptık.
    public interface IProductDal
    {
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);

        //ürünleri categoriye göre filtrele demek.
        List<Product> GetAllByCategory(int categoryId);
    }
}
