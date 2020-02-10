using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Addition a = new Addition();
            a.add(4, 5);
            a.add(10, 20, 15.7f);
            a.add(12, 13.5f, 16.675f);
            Multiplication m = new Multiplication();
            m.Product(3, 4, 5);
        }
    }
    public class Addition
    {
        public void add(int a, int b)
        {
            var r1 = (a * b);
            Console.WriteLine("The Product of Two Number is {0}", r1);
        }
        public void add(int a, int b,float c)
        {
            var r1 = ( a * b * c );
            Console.WriteLine("The Product of Three Number is {0}", r1);
        }
        public void add(int a, float b,float c)
        {
            var r1 = (a * b * c);
            Console.WriteLine("The Product of Three Number is {0}",r1);
        }
        public  void Product(int a,int b,int c)
        {
            var r1 = (a * b * c);
            Console.WriteLine("The Product of three Number is= {0}",r1);

        }
    }
    public class Multiplication :Addition
    {
       new public  void Product(int a,int b,int c)
        {
            var r1 = (a * b * c);
            var r2 = (a + b + c) / 3;
            Console.WriteLine("The product and average of three number are {0} and {1}",r1,r2);
        }
    }
}
