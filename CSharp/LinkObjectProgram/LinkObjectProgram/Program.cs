using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkObjectProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Teacher> Teachers = new List<Teacher>()
            // { new Teacher{ID=1,FirstName="Vicky",LastName="Ricky",City="Vellore"},
            //new Teacher{ID=2,FirstName="Thiru",LastName="Malai",City="Thirupatur"},
            //new Teacher{ID=3,FirstName="Kio",LastName="Chan",City="Nellore"},
            //new Teacher{ID=4,FirstName="Maddy",LastName="Madan",City="Natrampalli"}};
            //List<Student> Students = new List<Student>()
            //{
            //    new Student {ID=01,FirstName="Rozer",LastName="Vicky",City="Pudupet"},
            //    new Student {ID=02,FirstName="Mohan",LastName="Krishnan",City="Gumidipondi"},
            //    new Student {ID=03,FirstName="sannvika",LastName="shankar",City="Banglore"},
            //    new Student {ID=04,FirstName="Priya",LastName="Shankar",City="Vellore"},
            //};
            //var people = (from teacher in Teachers
            //              where teacher.City == "Vellore"
            //              select teacher.LastName).Concat(from student in Students
            //                                               where student.City =="Vellore"
            //                                               select student.LastName);
            //foreach (var n in people)
            //{
            //    Console.WriteLine("People in the city vellore are ;{0}", n);
            //}
            List<Employee> e = new List<Employee>();
            e.Add(new Employee() { empname = "Vicky", empid = 01 });
            e.Add(new Employee() { empname = "ricky", empid = 02 });
            e.Add(new Employee() { empname = "malai", empid = 03 });
            e.Add(new Employee() { empname = "kio", empid = 04 });
            List<Product> objpro = new List<Product>();
            objpro.Add(new Product() { ProductId = 01, Productname = "Badam drink" });
            objpro.Add(new Product() { ProductId = 02, Productname = "Lemon tea" });
            objpro.Add(new Product() { ProductId = 03, Productname = "Orange drink" });
            var pro = from p in objpro
                      where p.Productname.Contains("drink")
                      select p;
            foreach (var prod in pro)
            {
                Console.WriteLine("ProductId={0}  ProductName={1}", prod.ProductId, prod.Productname);
            }
            var em = from e1 in e
                     where e1.empname.Contains("o")
                     select e1;
            foreach (var e2 in em)
            {
                Console.WriteLine("{0} {1}", e2.empname, e2.empid);
            }
            string[] employees = new string[6] { "Vicky", "Ricky", "Malai", "Yogesh", "Kio Chan", "Maddy" };

            var knownEmpls = from emp in employees
                             where emp.StartsWith("V")
                             select emp;
            int[] marks = new int[6] { 98, 86, 80, 94, 93, 68 };
            var highMarks = from m in marks
                            where m > 90
                            select m;
            var marksinOrder = from m in marks
                               orderby m descending
                               select m;
            var a1 = marks.OrderByDescending(m => m);
            foreach (var m in a1)
            {
                Console.WriteLine("The orderrrrr Marks descendng :{0}", m);
            }
            foreach (var m in marksinOrder)
            {
                Console.WriteLine("The marks in order :{0}", m);
            }


            foreach (string emp in knownEmpls)
            {
                Console.WriteLine("Employee Name Starts with v :{0}", emp);
            }
            var someEmpls = employees.Where(s => s.Contains("i"));
            foreach (string emp in someEmpls)
            {
                Console.WriteLine("Employee Name Starts with i :{0}", emp);
            }
            List<string> fruits = new List<string>() { "Grapes",
                                                     "Pineapple",
                                                     "Custard Apple",
                                                     "Banana",
                                                     "Watermelon",
                                                     "Papaya"};
            var fruitswithP = from fruit in fruits
                              where fruit.Contains("p")
                              select fruit;
            var largerName = from fruit in fruits
                             where fruit.Length > 6
                             select fruit;
            foreach (string f in largerName)
            {
                Console.WriteLine("Fruit name Which has more than 6 characters :{0}", f);
            }
            //using method syntax
            var fname = fruits.Where(f => f.Length > 6);
            foreach (string f in fname)
            {
                Console.WriteLine("Fruit name Which has more than 6 characters :{0}", f);
            }
        }
    }
    class Employee
    {
        //string[] empname = new string[] { "vicky", "ricky", "malai", "kio chan", "master" };
        //int[] empid = new int[] { 1, 2, 3, 4, 5 };
        public string empname { get; set; }
        public int empid { get; set; }

    }
    class Product
    {
        public string Productname { get; set; }
        public int ProductId { get; set; }
    }
    //class Teacher
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public string City { get; set; }
    //    public int ID { get; set; }

    //}
    //class Student
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public string City { get; set; }
    //    public int ID { get; set; }
    //}
}
