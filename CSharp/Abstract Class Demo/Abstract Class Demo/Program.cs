using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            SBAccount sb = new SBAccount();
           double a= sb.GetSimpleInterest(1000, 2, 3);
            double r = sb.GetTotalAmount(1000, a);
            Console.WriteLine("The simple Interest is {0}", a);
            Console.WriteLine("The Total balance is {0}", r);
        }
    }
    public abstract class Banking
    {
        public abstract double GetSimpleInterest(double pr, int td, short rt);
        public abstract double GetTotalAmount(double bal, double si);
        public void Show()
        {
            Console.WriteLine("This is the Concrete Method in the abstract class");
        }
    }
    public class SBAccount : Banking
    {
        public override double GetSimpleInterest(double pr,int td,short rd)
        {
            double si = 5*((pr * td * rd) / 100);
            return si;
        }
        public override double GetTotalAmount(double bal, double si)
        {
            double tamount = bal + si;
            return tamount;
        }

    }
    public class CAccount : Banking
    {
        public override double GetSimpleInterest(double pr, int td, short rt)
        {
            double sic = 0.25*((pr * td * rt) / 100);
            return sic;
        }
        public override double GetTotalAmount(double bal, double si)
        {
            double tamount1 = bal + si;
            return tamount1;
        }

    }
}
