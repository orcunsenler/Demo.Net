using DataAccess.Concrete.InMemory;
using Business.Concrete;
using System;
using DataAccess.Concrete.EntityFramework;

class Program
{
    static void Main(string[] args)
    {
        ProductManager productManager = new ProductManager(new EfProductDal());

        foreach (var product in productManager.GetAll())
        {
            Console.WriteLine(product.ProductName);
        }
        //foreach (var product in productManager.GetByCategoryId(1))
        //{
        //    Console.WriteLine(product.ProductName);
        //}
        //foreach (var product in productManager.GetByUnitPrice(50,100))
        //{
        //    Console.WriteLine(product.ProductName);
        //}

    }
}