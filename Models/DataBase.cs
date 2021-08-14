using System.Collections.Generic;

namespace RobbsProductShop.Models
{
    public class DataBase
    {
        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>
            {
                new Product
                {
                    ProductID = 1,
                    Name = "Product 1",
                    Price = (decimal) 499.00
                },
                new Product
                {
                    ProductID = 2,
                    Name = "Product 2",
                    Price = (decimal) 1109.00
                },
                new Product
                {
                    ProductID = 3,
                    Name = "Product 3",
                    Price = (decimal) 199.00
                },
                new Product
                {
                    ProductID = 4,
                    Name = "Product 4",
                    Price = (decimal) 230.00
                },
                new Product
                {
                    ProductID = 5,
                    Name = "Product 5",
                    Price = (decimal) 9.99
                },
                 new Product
                {
                    ProductID = 6,
                    Name = "Product 6",
                    Price = (decimal) 99.00
                },
                new Product
                {
                    ProductID = 7,
                    Name = "Product 7",
                    Price = (decimal) 19.00
                },
                new Product
                {
                    ProductID = 8,
                    Name = "Product Of The Month",
                    Price = (decimal) 9.45
                },
                new Product
                {
                    ProductID = 9,
                    Name = "Product 9",
                    Price = (decimal) 23.00
                },
                new Product
                {
                    ProductID = 10,
                    Name = "Product 10",
                    Price = (decimal) 999.99
                }
            };
            return products;
        }

        public static Product GetProduct(string slug)
        {
            List<Product> products = DataBase.GetProducts();
            foreach(Product p in products)
            {
                if (p.Slug == slug)
                {
                    return p;
                }
            }
            return null;
        }
    }
}