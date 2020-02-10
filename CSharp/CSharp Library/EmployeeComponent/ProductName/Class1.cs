using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductName
{
    public class Product
    {
      public  int prodId { get; set; }
      public   string prodName { get; set; }
      public  double prodPrice { get; set; }
      public void ShowInfo()
        {
            Console.WriteLine("The Product Id={0},Product Name={1},Product Prize={2}", prodId, prodName, prodPrice);
        }
        

    }
}
