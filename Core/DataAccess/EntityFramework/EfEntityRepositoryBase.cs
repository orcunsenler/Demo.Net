using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity,TContext> : IEntityRepository<TEntity>
        where TEntity : class,IEntity,new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())  //IDisposable pattern implamentation of c#
            {
                var addProduct = context.Entry(entity);
                addProduct.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deleteProduct = context.Entry(entity);
                deleteProduct.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<TEntity> GelAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);

            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updateProduct = context.Entry(entity);
                updateProduct.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
