using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JoinGroupJoin
{
    class Product
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
    }
    class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product{Name ="Jelly", CategoryId = 0},
                new Product{Name = "Cookies",CategoryId = 0},
                new Product{Name = "IceCream",CategoryId = 0},
                new Product{Name = "Doll",CategoryId = 1},
                new Product{Name = "Robot",CategoryId = 1},
                new Product{Name = "TeaSet",CategoryId = 2},
                new Product{Name = "AirFryer"}
            };
            List<Category> catrgories = new List<Category>
            {
                new Category{Id = 0, CategoryName="Food"},
                new Category{Id = 1, CategoryName="Stationary"},
                new Category{Id = 2, CategoryName="DiningWare"}
            };
            Console.WriteLine("-----join-----");
            var g_query = from product in products
                          join category in catrgories on product.CategoryId equals category.Id
                          select new { product.Name, category.CategoryName };
            foreach (var item in g_query)
            {
                Console.WriteLine($"{item.Name} - {item.CategoryName}");
            }

            Console.WriteLine("-----GroupJoin-----");
            var ProductsGroups = from category in catrgories
                                 join product in products on category.Id equals product.CategoryId into productGroup
                                 select productGroup;

            foreach(IEnumerable<Product> productGroup in ProductsGroups)
            {
                Console.WriteLine("Group");
                foreach(Product product in productGroup)
                {
                    Console.WriteLine($"{product.Name,10}");
                }    
            }
        }
    }
}
