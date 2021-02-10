using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //İnterface metodları default publictir, interface'in kendisi değil o yüzden public yaptık.
    //Burada IEntityRepository product için yapılandır dedik.
    //Ürüne ait özel operasyonları buraya koyuyoruz.
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
    }
}
