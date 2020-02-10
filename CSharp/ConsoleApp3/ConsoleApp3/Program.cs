using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = 100;
            int a = 10;
            obj = a;
            int k = 10, l = 19;
            int b = (int)obj;
            Console.WriteLine("value of k ={0} and l ={1} before function call\n", k, l);
            Console.WriteLine("value of a ={0} and b ={1} before function call\n", a, b);
            double d = sum(ref a ,ref b);
            double f = sum1(k, l);
            Console.WriteLine("The value of k and l after function call is k={0} l={1}", k, l);
            Console.WriteLine("The value of a and b after function call is a={0} b={1}", a, b);
        }
        public static double sum(ref int i, ref int j)
        {
            double c = i + j;
            i += 7;
            j += 5;
            return c;
        }
        public static double sum1(int i, int j)
        {
            double c = i + j;
            i += 7;
            j += 5;
            return c;
        }
    }
}
