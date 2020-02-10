using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPriorityApp
{
    class Program
    {
        public static long count1=0, count2=0;
      static void Main(string[] args)
        {
         Thread T1 = new Thread(IncrementCount1);
            Thread T2 = new Thread(IncrementCount2);
            Console.WriteLine("Main Thread has started");
            T1.Start();
            T2.Start();
            T1.Priority = ThreadPriority.Lowest;
            T2.Priority = ThreadPriority.AboveNormal;
            T1.Abort();
            T2.Abort();
            T1.Join();
            T2.Join();           
            Console.WriteLine("Count1 :{0}", count1);
            Console.WriteLine("Count2 :{0}", count2);
            Console.WriteLine("Main Thread had Ended");
        }
        public static void IncrementCount1()
        {
            while(true)
            {
                count1 += 1;
               
            }
            Console.WriteLine("Count1 :{0}", count1);
        }
        public static void IncrementCount2()
        {
            while (true)
            {
                count2 += 1;
                 
            }
            Console.WriteLine("Count1 :{0}", count2);


        }
    }
}
