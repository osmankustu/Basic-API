﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();
            //CategoryTest();
            ProductDtoTest();


        }

        private static void ProductDtoTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetProductDetails();

            if (result.Succes == true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + "/" + product.CategoryName);
                    Console.WriteLine(result.Massage);
                }
            }
            else
            {
                Console.WriteLine(result.Massage);
            }
            
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

            foreach (var product in productManager.GetProductDetails().Data)
            {
                Console.WriteLine(product.ProductName + " / " + product.CategoryName);
            }
        }
    }
}
