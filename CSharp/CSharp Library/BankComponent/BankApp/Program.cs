using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankComponent;
namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Savings s = new Savings();
           var balance= s.GetSimpleInterest(15000, 25, 5.6);
            s.Balance(15000);
            var b = s.GetBalance();
            Console.WriteLine("The Total balance is {0}", b);
        }
    }
}
