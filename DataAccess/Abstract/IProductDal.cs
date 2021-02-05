using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //İnterface metodları default publictir, interface'in kendisi değil o yüzden public yaptık.
    //Burada IEntityRepository product için yapılandır dedik.
    public interface IProductDal:IEntityRepository<Product>
    {
        
    }
}
