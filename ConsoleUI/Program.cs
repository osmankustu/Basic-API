using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {

            ProductManager manager = new ProductManager(new EfProductDal());

            foreach (var product in manager.GetByUnitsPrice(40,100))
            {
                Console.WriteLine(product.ProductName +" Fiyat : "+ product.UnitPrice);
            }
             
             
        }
    }
}
