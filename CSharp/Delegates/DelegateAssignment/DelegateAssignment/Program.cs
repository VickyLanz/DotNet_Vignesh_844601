using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAssignment
{
    class Program
    {
        public delegate void Math(double a, double b);
        public delegate void PrintHandler();
        public event PrintHandler Print;
        public void OnPrint()
        {
            Console.WriteLine("Printing is done");
        }
        public void Show()
        {
            Console.Write("Inside show mahtod");
            Print();
        }
        static void Main(string[] args)
        {
            Math m = new Math(Add);          
            m = new Math(Sub);         
            m += Mul;
            m += Div;
            m.Invoke(950 , 95);
            Program objP = new Program();
            objP.Print += new PrintHandler(objP.OnPrint);
            objP.Show();
        }
        public static void Add(double a, double b)
        {
            var s = a + b;
            Console.WriteLine("The Addition of {0} and {1} is {2}\n", a, b, s);
        }
        public static void Sub(double a,double b)
        {
            var s = a - b;
            Console.WriteLine("The Subtraction of {0} and {1} is {2}\n", a, b, s);
        }
        public static void Mul(double a, double b)
        {
            var s = a*b;
            Console.WriteLine("The Multiplication of {0} and {1} is {2}\n", a, b, s);
        }
        public static void Div(double a, double b)
        {
            var s = a / b;
            Console.WriteLine("The Division of {0} and {1} is {2}\n", a, b, s);
        }

    }
}

