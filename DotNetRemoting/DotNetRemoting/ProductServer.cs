using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProduct;

namespace DotNetRemoting
{
    public class ProductServer : MarshalByRefObject, IProduct
    {
        public Product find()
        {
            //throw new NotImplementedException();
            return new Product { Id = "1", Name = "Product 1", Price = 100 };
        }

        public List<Product> findAll()
        {
            //throw new NotImplementedException();
            List<Product> listProducts = new List<Product>();
            listProducts.Add(new Product { Id = "1", Name = "Product 1", Price = 100 });
            listProducts.Add(new Product { Id = "2", Name = "Product 2", Price = 200 });
            listProducts.Add(new Product { Id = "3", Name = "Product 3", Price = 300 });
            return listProducts;
        }
    }
}
