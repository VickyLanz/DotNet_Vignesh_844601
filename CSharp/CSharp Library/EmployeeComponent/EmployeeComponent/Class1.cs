using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeComponent
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int DeptId { get; set; }
        public double GetSalary(int nds,double spd)
        {
            var salary = nds * spd;
            return salary;
        }
        public double GetIncent(double salary)
        {
            double incent = 0.5 * salary;
            return incent;
        }
        public string ShowData()
        {
            return string.Format("EmpId:{0},EmpName:{1},DeptId:{2}", EmployeeId, EmployeeName, DeptId);
        }
    }
}
