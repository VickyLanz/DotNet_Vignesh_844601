using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankComponent
{
    public class Savings
    {
        public double t,t1;
        public double GetSimpleInterest(double principle,double days,double interest)
        {
            var simpleInterest = (principle * days * interest) / 100;
            t = simpleInterest;
            return simpleInterest;
        }
        public void Balance(double salary)
        {
            var totalbal = salary + t;
            t1 = totalbal;
            
        }
        public double GetBalance()
        {
            return t1;
        }
    }
}
