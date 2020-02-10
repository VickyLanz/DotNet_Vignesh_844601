using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductName;
namespace ProductApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Product prod = new Product() { prodId = 01, prodName = "Vennu", prodPrice = 50000 };
            prod.ShowInfo();
        }
    }
}
