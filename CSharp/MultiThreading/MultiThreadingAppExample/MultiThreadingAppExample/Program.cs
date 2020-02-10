using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingAppExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch s1 = new Stopwatch();
            Stopwatch s2 = new Stopwatch();
            Thread t1 = new Thread(IncermentCount1);
            Thread t2 = new Thread(IncermentCount2);

            s1.Start();
            IncermentCount1();
            IncermentCount2();
            s1.Stop();
            Console.WriteLine("Total Time Elapsed in a single Iteration is :{0}", s1.ElapsedMilliseconds);
            s2.Start();
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
            s2.Stop();
            Console.WriteLine("Total Time Elapsed in a Multi Threading is :{0}", s2.ElapsedMilliseconds);
        }

         public static void IncermentCount1()
            {
                long Count1 = 0;
                for (int i=1;i<1000000000;i++)
                {
                    Count1 += 1;

                }
                Console.WriteLine(Count1);
            }
         public static void IncermentCount2()
            {
                long Count2 = 0;
                for(int i=1;i< 1000000000; i++)
                {
                    Count2 += 1;

                }
                Console.WriteLine(Count2);
            }
    }
}

        

