using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //Generic Constraint - generic kısıt.
    //class : referans tip.
    //IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
    //new () newlenebilir olmalı.
    public interface IEntityRepository<T> where T: class, IEntity,new()
    {
        //Generic Repository Design Pattern 
        List<T> GetAll(Expression<Func<T,bool>> filter=null); //Filte = null filtre vermeyede bilirsin demek.
        T Get(Expression<Func<T, bool>> filter); //tek data için.
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
      
    }
}
