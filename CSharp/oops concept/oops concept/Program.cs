using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_concept
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Employee emp1 = new Employee(1,"vignesh");
            Employee emp2 = new Employee(2,"Thirumalai",32,"admin");
            emp2.ShowData();
            Product prd = new Product() { ProdId = 1, ProductName = "Chicken Briyani", ProductPrice = 201.00, Quantity = "500ml" };
            prd.show();
        }
    }
    public class Employee
    {
        int empid;
        string empname;
        short deptid;
        string deptname;
        public Employee()
        {

        }
        public Employee(int eid,string ename)
        {
            empid = eid;
            empname = ename;
        }
        public Employee(int eid ,string ename,short did,string dname)
        {
            empid = eid;
            empname = ename;
            deptid = did;
            deptname = dname;
        }
        public void ShowData()
        {
            Console.WriteLine("Employee id={0}", empid);
            Console.WriteLine("Employee name={0}", empname);
            Console.WriteLine("Department Id={0}", deptid);
            Console.WriteLine("Department name={0}",deptname);
        }
    }
    public class Product
    {
        //int pid;
        public int ProdId
        {
            get ; 
            set ; 
        }
        public string ProductName
        {
            get;
            set;
        }
        public double ProductPrice
        {
            get;
            set;
        }
        public string Quantity
        {
            get;
            set;
        }
        public void show()
        {
            Console.WriteLine("ProductId={0}, Product Name={1} Product Price={2} , Product Quantity={3}", ProdId, ProductName, ProductPrice, Quantity);
        }
    }
}
