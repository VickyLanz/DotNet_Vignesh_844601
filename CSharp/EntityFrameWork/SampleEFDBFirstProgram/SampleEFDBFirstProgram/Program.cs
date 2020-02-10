using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEFDBFirstProgram
{
    class Program
    {
       
        static void Main(string[] args)
        {
            EmployeeEFDBEntities context = new EmployeeEFDBEntities();

            var employee = new Employee()
            {
                EmpID = 1,
                Name = "Vicky lanz",
                Salary = 35000,
                SSN = 23454,
                DepID = 3
            };
            var employee1 = new Employee()
            {
                EmpID = 2,
                Name = "John Snow",
                Salary = 35000,
                SSN = 23452,
                DepID = 2
            };
            var employee2 = new Employee()
            {
                EmpID = 3,
                Name = "Arya Stark",
                Salary = 35000,
                SSN = 234454,
                DepID = 1
            };
            context.Employees.Add(employee1);
            context.Employees.Add(employee2);
            context.SaveChanges();

            LinqToEntity();
            ModifyEmployee();
            delete();


        }
        public static void LinqToEntity()
        {
            EmployeeEFDBEntities context = new EmployeeEFDBEntities();
            var employees = context.Employees;
            var emplist=from emp in employees
                        orderby emp.Salary
                        select emp;
            foreach(var emp in emplist)
            {
                Console.WriteLine("EmpID :{0},Name:{1},Salary :{2},SSN :{3}", emp.EmpID, emp.Name, emp.Salary, emp.SSN);
            }
        }
        public static void ModifyEmployee()
        {
            EmployeeEFDBEntities context = new EmployeeEFDBEntities();

            var employe = context.Employees;

            var emlist = from emp in employe
                          orderby emp.Salary
                          select emp;
            foreach(var em in emlist)
            {
                if(em.EmpID == 1)
                {
                    em.Name = "Mathew Mcdonald";
                }
               
            }
            context.SaveChanges();
        }
        public static void delete()
        {
            EmployeeEFDBEntities context = new EmployeeEFDBEntities();
            var employee = new Employee() { EmpID = 4 };
            context.Employees.Attach(employee);
            context.Employees.Remove(employee);
            context.SaveChanges();


        }
    }
}
