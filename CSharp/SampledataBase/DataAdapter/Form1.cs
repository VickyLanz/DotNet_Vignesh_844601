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

namespace DataAdapter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        SqlDataAdapter da;
        string conString, qryString;
        DataSet ds;
        private void btnProducts_Click(object sender, EventArgs e)
        {
            
            qryString = "Select ProductID,ProductName,UnitPrice,QuantityPerUnit,CategoryID from Products";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            da = new SqlDataAdapter(sqlCmd);            
            ds.Clear();
            da.Fill(ds, "ProductsInfo");
            gvProducts.DataSource = ds;
            gvProducts.DataMember = "ProductsInfo";
        }
        private void btnCategories_Click(object sender, EventArgs e)
        {
            qryString = "Select * from Categories";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            da = new SqlDataAdapter(sqlCmd);
            ds.Clear();
            da.Fill(ds, "CategoriesInfo");
            gvProducts.DataSource = ds;
            gvProducts.DataMember = "CategoriesInfo";
         
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            conString = "Data Source=BLT10141\\SQLEXPRESS2017; Initial Catalog=Northwind;Integrated Security=True;";
            sqlCon = new SqlConnection(conString);
            ds = new DataSet();
        }
    }
}
