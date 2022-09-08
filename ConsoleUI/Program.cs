﻿using DataAccess.Concrete.InMemory;
using Business.Concrete;
using System;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

class Program
{
    static void Main(string[] args)
    {
        //ProductTest();
        //CategoryTest();
    }

    private static void CategoryTest()
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        foreach (var category in categoryManager.GetAll())
        {
            Console.WriteLine(category.CategoryName);
        }
    }

    private static void ProductTest()
    {
        ProductManager productManager = new ProductManager(new EfProductDal());

        foreach (var product in productManager.GetAll())
        {
            Console.WriteLine(product.ProductName);
        }

        //ProductManager productManager = new ProductManager(new EfProductDal());

        //foreach (var product in productManager.GetProductDetails())
        //{
        //    Console.WriteLine(product.ProductName + '/' + product.CategoryName);
        //}

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