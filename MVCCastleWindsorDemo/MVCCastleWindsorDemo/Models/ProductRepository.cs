using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCastleWindsorDemo.Models
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> products = new List<Product>
        {
            new Product{ Id = 100 ,Name = "Book" , category = "Education", price = 100 }
        };
        public Product Add(Product item)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Product item)
        {
            throw new NotImplementedException();
        }
    }
}