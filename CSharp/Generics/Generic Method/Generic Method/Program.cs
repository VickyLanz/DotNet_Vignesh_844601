using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Method
{
    class Program
    {
        static void Main(string[] args)
        {
         void  Add<T>(ref T c,ref T d)
            {

                dynamic e = c;
                dynamic f = d;
                dynamic s = e + f;                
                Console.WriteLine("The addition of two numbers {0} and {1} is {2}", e, f,s);

            }
            Console.WriteLine("Enter the Datatype that you are going to enter");
            Console.WriteLine("1.Int 2.String 3.Double 4.Float");
            int opt = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the First value :");
            if (opt == 1 || opt==3 || opt==4)
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Second value :");
                double b = double.Parse(Console.ReadLine());
                Add<double>(ref a, ref b);
            }
            else
            {
                string a = Console.ReadLine();
                Console.WriteLine("Enter the Second value :");
                string b = Console.ReadLine();
                Add<String>(ref a, ref b);
            }
  
        }
    }
}
