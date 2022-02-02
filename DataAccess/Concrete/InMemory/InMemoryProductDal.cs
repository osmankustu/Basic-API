using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            //Oracle SQL ,SQL Server Simüle
            _products = new List<Product> {
                new Product {CategoryId = 1,ProductId=1, ProductName ="Bardak",UnitPrice=15,UnitInStock=15},
                new Product {CategoryId = 2,ProductId=1, ProductName ="Kamera",UnitPrice=500,UnitInStock=3},
                new Product {CategoryId = 3,ProductId=2, ProductName ="Telefon",UnitPrice=1500,UnitInStock=2},
                new Product {CategoryId = 4,ProductId=2, ProductName ="Klavye",UnitPrice=150,UnitInStock=65},
                new Product {CategoryId = 5,ProductId=2, ProductName ="Fare",UnitPrice=85,UnitInStock=1}
               };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ - Language Integrated Query
            Product productToDelete = _products.SingleOrDefault(p => p.CategoryId == product.ProductId);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            //Gönderdiğim ürün idsine sahip olan ürünü bul
            Product productToUpdate = _products.SingleOrDefault(p => p.CategoryId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitInStock = product.UnitInStock;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
           return _products.Where(p => p.CategoryId == categoryId).ToList();
        }
    }
}
