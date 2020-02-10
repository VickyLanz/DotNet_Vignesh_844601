using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityFrameCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public class ProductDBContext : DbContext
    {
        public ProductDBContext() : base("name=ProductsEFDBConnectionString")
        { }
        public DbSet<Product> Products { get; set; }
    }
    public class Product
    {
        public int PRoductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Quantity { get; set; }
        public int CategoryID { get; set; }
    }
}
