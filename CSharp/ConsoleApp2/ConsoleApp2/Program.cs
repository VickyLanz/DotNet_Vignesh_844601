using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[6] { 6, 5, 4, 3, 2, 1 };
           
            Array.Reverse(a);
           /* int[,] b = new int[3,3] { { 10, 11, 12 }, { 13, 14, 15 }, { 16, 17, 18 } };
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.Write(b[i,j] + "\t");
                }
                Console.WriteLine();
            }*/
            foreach(int i in a)
            {
                Console.WriteLine(i);
            }
            //var ag = avg(a);
            //Console.WriteLine("The average the array is {0}",ag);
        }
        public static double avg(int[] a)
        {
           double b = a.Sum();
            double l = a.Length;
            // Console.WriteLine(b);
            return b/l;
        }
    }
}
