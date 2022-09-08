using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            using (AppDbContext context = new AppDbContext())  //IDisposable pattern implamentation of c#
            {
                var addProduct = context.Entry(entity);
                addProduct.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Product entity)
        {
            using (AppDbContext context = new AppDbContext())  
            {
                var deleteProduct = context.Entry(entity);
                deleteProduct.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Product> GelAll(Expression<Func<Product, bool>> filter = null)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return filter == null ? context.Set<Product>().ToList() : context.Set<Product>().Where(filter).ToList();
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);

            }
        }

        public void Update(Product entity)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var updateProduct = context.Entry(entity);
                updateProduct.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
