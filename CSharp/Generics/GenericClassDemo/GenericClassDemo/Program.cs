using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GenericClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
          
            List<Employee> Employees = new List<Employee>();
            Employees.Add(new Employee() { Emid = 01, Empname = "vicky", Deptid = 106 });
            Employees.Add(new Employee() { Emid = 02, Empname = "ricky", Deptid = 107 });
            Employees.Add(new Employee() { Emid = 03, Empname = "vicky", Deptid = 108 });

            foreach (var em in Employees)
            {
                Console.WriteLine("Employee Id={0},Name={1},Department={2}", em.Emid, em.Empname, em.Deptid);
            }           
            int a = 10, b = 20;
            Swap<int>(ref a, ref b);
            Console.WriteLine("After swaping a={0} b={1}", a, b);
            string a1 = "Vicky", b1 = "lanz";
            Swap<string>(ref a1, ref b1);
            Console.WriteLine("After swaping string a={0},b={1}", a1, b1);
            void Swap<T>(ref T d, ref T e )
            {
                T c;
                c = d;
                d = e;
                e = c;
            }
        }
    }
   class Employee
        {
            public int Emid
            {
                get;
                set;
            }
            public String Empname
            {
                get;
                set;

            }
            public int Deptid
            {
                get;
                set;
            }
            

        }
    
}
