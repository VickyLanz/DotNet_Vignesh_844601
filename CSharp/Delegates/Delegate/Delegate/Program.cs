using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        public delegate double SalDelegate(int ds, float  sd);
        static void Main(string[] args)
        {
            Program p = new Program();
            SalDelegate m = new SalDelegate(GetSalary);
            //var sal = m.Invoke(30, 1000);
           // Console.WriteLine("{0}", sal);
            m +=Incent;
            // var s = m.Invoke(30,1000);
            // Console.WriteLine("{0}", s);
            m += GetSalary;
            var s1 = m.Invoke(30, 890.45f);
            Console.WriteLine("{0}", s1);
        }
        public static double  GetSalary(int nds, float  spd)
            {
        var s=(nds*spd);
        return s;
        }
        public static double  Incent(int nds,float spd)
        {
            var incent = (nds * spd) * 0.1;
            return incent;
        }

    }
}
