using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductDBContext context = new ProductDBContext();
            var product = context.Products;

            var categories = context.Categories;

            //var cat1 = categories.Add(new Category() { Id = 1, Name = "Beverages" });

            //var cat3 = categories.Add(new Category() { Name = "Condiments"});

            //var product1 = product.Add(new Product()
            //{
            //    PRoductID = 01,
            //    Name = "Vicky_Lanz",
            //    Price = 1208,
            //    Quantity = "500ml",
            //    CategoryID = 31
            //});
            //var product2 = product.Add(new Product()
            //{
            //    PRoductID = 02,
            //    Name = "John_Snow",
            //    Price = 1209,
            //    Quantity = "800ml",
            //    CategoryID = 33
            //});
            //var product3 = product.Add(new Product()
            //{
            //    PRoductID = 03,
            //    Name = "Arya_Stark",
            //    Price = 1243,
            //    Quantity = "50ml",
            //    CategoryID = 34
            //});
            //var product4 = product.Add(new Product()
            //{
            //    PRoductID = 04,
            //    Name = "Sansa_Stark",
            //    Price = 128,
            //    Quantity = "560ml",
            //    CategoryID = 35
            //});

            context.SaveChanges();

            LinqToEntity();

            Console.ReadKey();
        }

        public static void LinqToEntity()
        {
            ProductDBContext context = new ProductDBContext();
            var Products = from product in context.Products
                           where product.Price > 1210
                           select product;

            foreach(var product in Products)
            {
                Console.WriteLine("ProductID: {0}, Name: {1}, Price: {2}, Quantity: {3}", product.PRoductID, product.Name, product.Price, product.Quantity);
            }
        }
    }
    public class ProductDBContext : DbContext
    {
        public ProductDBContext() : base("name=ProductsDBContext")
        { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
    public class Product
    {
        public int PRoductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Quantity { get; set; }
        public int CategoryID { get; set; }
    }
        public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
