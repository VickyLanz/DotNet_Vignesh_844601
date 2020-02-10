using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 10;
            b = 5;
            var pro = Multiply(a, b);
            for (int i=1;i<=5;i++)
            {
                var result = 85 + i;
                Console.WriteLine(result);
            }
            Console.WriteLine(pro);
        }
        public static double Multiply(int a,int b)
        {
            var prod = a * b;
            return prod;
        }
    }
}
