using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisam
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            double s1 = emp.GetSalary(30, 901.15f);
            double s2 = emp.GetSalary(10, 901.15f, 1000);
            double s3 = emp.GetSalary(25.5f, 901.15f);
            Console.WriteLine("First Method salary={0}", s1);
            Console.WriteLine("Second Method salary={0}", s2);
            Console.WriteLine("third Method salary={0}", s3);
            Manager m = new Manager();
           double ts= m.GetPerks(25000, 1500);
            Console.WriteLine("The overriding function output is{0}", ts);

        }
    }
    public class Employee
    {
        public double GetSalary(int nds,float spd)
        {
            double salary = nds * spd;
            return salary;
        }
        public double GetSalary(int nds,float spd,float incent)
        {
            double salary = (nds * spd) + incent;
            return salary;
        }
        public double GetSalary(float nds, float spd)
        {
            double salary = nds * spd;
            return salary;
        }
        public virtual double GetPerks(float salary,float perks)
        {
            double ts = salary + perks;
            return ts;

        }
    }
    public class Manager:Employee
    {
        public override double GetPerks(float salary, float perks)
        {
            //return base.GetPerks(salary, perks)*1.10;
            double ts = 1.10 * (salary + perks);
            return ts;
        }
    }
}
