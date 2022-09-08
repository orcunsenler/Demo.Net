using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ ProductId=1,  CategoryId=1, ProductName="computer", UnitsInStock=10, UnitPrice=100},
                new Product{ ProductId=2,  CategoryId=2, ProductName="keyboard", UnitsInStock=20, UnitPrice=10},
                new Product{ ProductId=3,  CategoryId=2, ProductName="mouse", UnitsInStock=20, UnitPrice=10},
                new Product{ ProductId=4,  CategoryId=1, ProductName="monitor", UnitsInStock=10, UnitPrice=50},
                new Product{ ProductId=5,  CategoryId=2, ProductName="mousepad", UnitsInStock=20, UnitPrice=5}
            }.ToList();
        }

        public List<Product> GelAll()
        {
            return _products;
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //if I didn't use LINQ(Language Integrated Query), I would write as below
            //var productToDelete;
            //foreach (var item in _products)
            //{
            //    if(item.ProductId == product.ProductId)
            //    {
            //        productToDelete = item;
            //    }
            //}

            
            var productToDelete = _products.SingleOrDefault(x=>x.ProductId==product.ProductId); //by using LINQ
            _products.Remove(productToDelete);
        }

        
        public void Update(Product product)
        {
            var productToUpdate = _products.SingleOrDefault(x => x.ProductId == product.ProductId); //by using LINQ
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            productToUpdate.UnitPrice = product.UnitPrice;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            _products.Where(x => x.CategoryId == categoryId).ToList();
            return _products;
        }

        public List<Product> GelAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
