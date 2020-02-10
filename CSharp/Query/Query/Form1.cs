using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Query
{
    public partial class Form1 : Form
    {
        string conString, qryString;
        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbcountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            conString = "Data Source=BLT10141\\SQLEXPRESS2017;Initial Catalog=Northwind;Integrated Security=True";
            sqlCon = new SqlConnection(conString);

            sqlCmd = new SqlCommand();
            sqlCmd.CommandText  = "GetCustomersByCountry";
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Connection = sqlCon;

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@country";
            param.DbType = DbType.String ;
            param.Value = cmbcountry.Text;

            sqlCmd.Parameters.Add(param);
            da = new SqlDataAdapter(sqlCmd);
            ds.Clear();
            da.Fill(ds, "CustomersByCountry");

            gridview.DataSource = ds;
            gridview.DataMember = "CustomersByCountry";


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conString = "Data Source=BLT10141\\SQLEXPRESS2017;Initial Catalog=Northwind;Integrated Security=True";
            sqlCon = new SqlConnection(conString);
            ds = new DataSet();
            sqlCon.Open();
            qryString = "Select Distinct Country from Customers";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            dr = sqlCmd.ExecuteReader(); 
            while(dr.Read())
            {
                cmbcountry.Items.Add(dr["Country"]);
            }
            dr.Close();
            sqlCon.Close();
        }
    }
}
