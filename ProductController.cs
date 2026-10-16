using System.Collections.Generic;
using System.Web.Mvc;
using ProductCatalog.Models;

namespace ProductCatalog.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            List<Product> products = new List<Product>()
            {
                new Product
                {
                    ProductId = 1,
                    ProductName = "Laptop",
                    Category = "Electronics",
                    Price = 55000,
                    Description = "High performance laptop"
                },
                new Product
                {
                    ProductId = 2,
                    ProductName = "Mobile Phone",
                    Category = "Electronics",
                    Price = 25000,
                    Description = "Latest smartphone"
                },
                new Product
                {
                    ProductId = 3,
                    ProductName = "Headphones",
                    Category = "Accessories",
                    Price = 2500,
                    Description = "Wireless headphones"
                },
                new Product
                {
                    ProductId = 4,
                    ProductName = "Keyboard",
                    Category = "Accessories",
                    Price = 1500,
                    Description = "USB mechanical keyboard"
                }
            };

            return View(products);
        }

        public ActionResult Details(int id)
        {
            Product product = new Product();

            if (id == 1)
            {
                product = new Product
                {
                    ProductId = 1,
                    ProductName = "Laptop",
                    Category = "Electronics",
                    Price = 55000,
                    Description = "High performance laptop"
                };
            }
            else if (id == 2)
            {
                product = new Product
                {
                    ProductId = 2,
                    ProductName = "Mobile Phone",
                    Category = "Electronics",
                    Price = 25000,
                    Description = "Latest smartphone"
                };
            }
            else if (id == 3)
            {
                product = new Product
                {
                    ProductId = 3,
                    ProductName = "Headphones",
                    Category = "Accessories",
                    Price = 2500,
                    Description = "Wireless headphones"
                };
            }
            else
            {
                product = new Product
                {
                    ProductId = 4,
                    ProductName = "Keyboard",
                    Category = "Accessories",
                    Price = 1500,
                    Description = "USB mechanical keyboard"
                };
            }

            return View(product);
        }
    }
}