using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        //Bağımlılığını constructor injection ile yapıyoruz.

        ICategoryDal _categoryDal;

        //Bu şu demek ben categorydal olarak veri erişim katmanına bağımlıyım.Sen bütün kurallarıma uy.
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public Category GetById(int categoryId)
        {
            return _categoryDal.Get(c=> c.CategoryId == categoryId);
        }

        //Select * from Categories where CategoryId = 3
       
    }
}
