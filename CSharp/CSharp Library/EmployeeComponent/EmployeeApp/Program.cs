using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeComponent;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee() { EmployeeId = 106, EmployeeName = "Vicky", DeptId = 107 };
            var c = emp.ShowData();
            Console.WriteLine(c);
        }
       
    }
}
