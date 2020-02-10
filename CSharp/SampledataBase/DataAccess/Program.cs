using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlcon;
            SqlCommand sqlCmd;
            SqlDataReader dr;
            string qryString,conString;
            conString = "Data Source=BLT10141\\SQLEXPRESS2017; Initial Catalog=Northwind;Integrated Security=True;";
            sqlcon = new SqlConnection(conString);
            sqlcon.Open();
            qryString = "Select * from Products";
            sqlCmd = new SqlCommand(qryString, sqlcon);
            dr = sqlCmd.ExecuteReader();           
            while(dr.Read())
            {
                Console.WriteLine("Product name :{0}", dr["ProductName"]);
            }
            dr.Close();
            sqlcon.Close();


        }
    }
}
