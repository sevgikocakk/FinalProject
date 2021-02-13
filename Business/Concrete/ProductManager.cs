using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        //Burada businessin hangi veri erişim yöntemini kullanacağını belirtiyoruz.
        //Ctor injection yapıldı.3
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
            //business codes
            if (product.ProductName.Length<2)
            {
                //magic strings
                return new ErrorResult(Messages.ProductNameInvalid);
            }
             _productDal.Add(product);

            return new SuccessResult(Messages.ProductAdded);
        }

        public Product Get(int productId)
        {
            return _productDal.Get(p => p.ProductId == productId);
        }

        public List<Product> GetAll()
        {
            //İş kodları
            //Yetkisi var mı?

            return _productDal.GetAll();

        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p=>p.CategoryId==id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p=>p.UnitPrice>=min && p.UnitPrice<=max);
        }


        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }
    }
}
