using DataAccess.Concrete.InMemory;
using Business.Concrete;
using System;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using DataAccess.Abstract;

class Program
{
    static void Main(string[] args)
    {
        ProductTest();
        //CategoryTest();
    }

    private static void CategoryTest()
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        foreach (var category in categoryManager.GetAll().Data)
        {
            Console.WriteLine(category.CategoryName);
        }
    }

    private static void ProductTest()
    {
        ProductManager productManager = new ProductManager(new EfProductDal(), new CategoryManager(new EfCategoryDal()));

        var result = productManager.GetAll();

        if (result.Success)
        {
            foreach (var product in result.Data)
            {
                Console.WriteLine(product.ProductName);
            }
        }
        else
        {
            Console.WriteLine(result.Message);
        }


        //Data Transformation Object

        //var result = productManager.GetProductDetails();

        //if (result.Success)
        //{
        //    foreach (var product in result.Data)
        //    {
        //        Console.WriteLine(product.ProductName + '/' + product.CategoryName);
        //    }
        //}
        //else
        //{
        //    Console.WriteLine(result.Message);
        //}


        //var result = productManager.GetByCategoryId(1);

        //if (result.Success)
        //{
        //    foreach (var product in result.Data)
        //    {
        //        Console.WriteLine(product.ProductName);
        //    }
        //}
        //else
        //{
        //    Console.WriteLine(result.Message);
        //}


        //var result = productManager.GetByUnitPrice(50,100);

        //if (result.Success)
        //{
        //    foreach (var product in result.Data)
        //    {
        //        Console.WriteLine(product.ProductName);
        //    }
        //}
        //else
        //{
        //    Console.WriteLine(result.Message);
        //}

    }
}