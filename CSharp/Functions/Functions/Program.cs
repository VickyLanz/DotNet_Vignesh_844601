using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Person
    {
        public string Name
        { get; set; }// property

    }

     class Program
    {
        enum Department
        {
            physics =10,
            chemistry=12,
            biology=14
        };
        public static void Main(string[] args)
        {
            Person myObj = new Person();
            myObj.Name = "Liam";
            Console.WriteLine(myObj.Name);
            Console.WriteLine("Department id of Physics is: {0}",(int) Department.physics);
        }
    }
}
