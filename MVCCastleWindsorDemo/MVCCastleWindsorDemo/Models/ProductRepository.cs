using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCastleWindsorDemo.Models
{
    public class ProductRepository : IProductRepository
    {
        private ProductDbContext ProductDatabase = new ProductDbContext();
        public IEnumerable<Product> GetAll()
        {
            var products = ProductDatabase.Products.ToList();
            return products;
        }

        public Product Get(int id)
        {
            Product product = ProductDatabase.Products.Find(id);
            return product;
        }

        public Product Add(Product product)
        {

            ProductDatabase.Products.Add(product);
            ProductDatabase.SaveChanges();
            return product;
        }

        public void Remove(int id)
        {
            Product product = ProductDatabase.Products.Find(id);
            ProductDatabase.Products.Remove(product);
            ProductDatabase.SaveChanges();


        }

        public bool Update(Product product)
        {

            var result = ProductDatabase.Products.SingleOrDefault(x => x.Id == product.Id);
            if (result != null)
            {
                result.Name = product.Name;
                result.category = product.category;
                result.price = product.price;
                ProductDatabase.SaveChanges();
                return true;

            }
            else
                throw new ArgumentNullException();

        }
    }
}