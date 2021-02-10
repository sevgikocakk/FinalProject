using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    //Bu generic yapı bana çalışacağım bir tablo ve çalışacağım bir context ver demektir.Birden fazla T verebiliriz.
    //Tüm tabloyu ilgilendiren operasyonlar için bu yapıyı kuruyoruz.
    public class EfEntityRepositoryBase<TEntity,TContext>:IEntityRepository<TEntity>
        where TEntity:class,IEntity,new() //Generic kısıt.
        where TContext:DbContext,new()
    {
        public void Add(TEntity entity)
        {
            //IDispossable pattern implementation of c#
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity); //Refreansı yakalama.
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity); //Refreansı yakalama.
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList() //ternary operator
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity); //Refreansı yakalama.
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
