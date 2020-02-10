using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Thread t = Thread.CurrentThread;
            t.Name = "Sub thread";
            Console.WriteLine("{0} is running now {1}", t.Name,t.ManagedThreadId);
            Thread T1 = new Thread(Method1);
            Thread T2 = new Thread(Method2);
            Thread T3 = new Thread(Method3);          
            Thread T4 = new Thread(Program.Test);
            Thread Tarea = new Thread(new ThreadStart(Rectangle));
            Thread t5 = new Thread(Program.Rectangle);
            t5.Start();            
        }
        public static void Method1()
        {
            for (int i=0;i<=10;i++)
            {
                Console.WriteLine("Method1:{0}", i);
            }
        }
        public static void Method2()
        {
            for (int i = 0; i <= 10; i++)
            {
                if (i == 5)
                {
                    Thread.Sleep(5000);
                }
                Console.WriteLine("Method2:{0}", i);
            }
        }
        public static void Method3()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Method3:{0}", i);
            }
        }
        public static void Test(object maths)
        {
            int j = Convert.ToInt32(maths);
            for (int i = 1; i<j; i++)
            {
                Console.WriteLine("Test :{0}",i);
            }
        }
        public static void Rectangle()
        {
            Console.WriteLine("Enter the Length of The Rectangle");
            var l = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Breadth of The Rectangle");
            var b = double.Parse(Console.ReadLine());
            Console.WriteLine("Area of rectangle ={0}",(l*b));

        }
    }
}
