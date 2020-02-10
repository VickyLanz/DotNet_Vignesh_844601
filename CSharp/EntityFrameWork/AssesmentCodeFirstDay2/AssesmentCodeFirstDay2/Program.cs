using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace AssesmentCodeFirstDay2
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentDb stu = new StudentDb();
            //var add = stu.Students;
            //var add1 = add.Add(new Student() { ID = 10, Name = "Vignesh", DeptID = 106 });
            //var add2 = add.Add(new Student() { ID = 11, Name = "John Snow", DeptID = 105 });
            //var add3 = add.Add(new Student() { ID = 12, Name = "Arya Stark", DeptID = 107 });
            //var add4 = add.Add(new Student() { Name = "Ra's Al Ghu", DeptID = 106 });
            //var add5 = add.Add(new Student() { Name = "Theon Grejoy", DeptID = 108 });
            //var dep = stu.Departments;
            //var dep1 = dep.Add(new Department() { ID = 105, DeptName = "ECE" });
            //var dep2 = dep.Add(new Department() { ID = 106, DeptName = "EEE" });
            //var dep3 = dep.Add(new Department() { ID = 107, DeptName = "CSE" });
            //var dep4 = dep.Add(new Department() { ID = 108, DeptName = "MECH" });
            stu.SaveChanges();
        }
    }
    public class StudentDb : DbContext
    {
        public StudentDb() :base ("name =StudentDb")
        { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int DeptID { get; set; }
       
    }
    public class Department
    {
        public int ID { get; set; }
        public string DeptName { get; set; }
    }
}
