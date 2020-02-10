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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        string conString, qryString;
        DataSet ds;

        private void cmbCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            qryString = "Select * from Customers where Country='" + cmbCountries.Text + "'";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            da = new SqlDataAdapter(sqlCmd);
            ds.Clear();
            da.Fill(ds, "CustomerInfo");
            gridviewCustomersAndOrders.DataSource = ds;
            gridviewCustomersAndOrders.DataMember = "CustomerInfo";
        }

        private void btnCustomersAndOrders_Click(object sender, EventArgs e)
        {
            qryString = "select c.CustomerID,c.CompanyName,c.ContactName,c.Address,c.Country,o.OrderId,o.OrderDate,o.ShippedDate from Customers c JOIN Orders o ON o.CustomerId=c.CustomerId";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            da = new SqlDataAdapter(sqlCmd);
            ds.Clear();
            da.Fill(ds, "Join");
            gridviewCustomersAndOrders.DataSource = ds;
            gridviewCustomersAndOrders.DataMember = "Join";
        }

        private void btnProdCategories_Click(object sender, EventArgs e)
        {
            qryString = "select p.ProductID,p.ProductName,p.UnitPrice,p.QuantityPerUnit,c.CategoryID,c.CategoryName from Products p JOIN Categories c ON p.ProductID=c.CategoryID";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            da = new SqlDataAdapter(sqlCmd);
            ds.Clear();
            da.Fill(ds, "Join");
            gridviewCustomersAndOrders.DataSource = ds;
            gridviewCustomersAndOrders.DataMember = "Join";
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            qryString = "select count(OrderID) from Orders";
            sqlCon.Open();
            sqlCmd = new SqlCommand(qryString, sqlCon);
             var d=sqlCmd.ExecuteScalar().ToString();
            MessageBox.Show(d, "Total Order");
            sqlCon.Close();
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            qryString = "Select ProductID,ProductName,UnitPrice,QuantityPerUnit,CategoryID from Products";  
            using (sqlCon = new SqlConnection(conString))
            {
                sqlCmd = new SqlCommand(qryString, sqlCon);
                da = new SqlDataAdapter(sqlCmd);
                ds.Clear();
                da.Fill(ds, "ProductsInfo");
                DataTable dt = ds.Tables["ProductsInfo"];
                var products = from product in dt.AsEnumerable()
                               where product.Field<decimal>("UnitPrice") >= 50
                               select new
                               {
                                   ProdID = product["ProductID"],
                                   ProductName = product["ProductName"],
                                   Price = product["UnitPrice"],
                                   Quantity = product["QuantityPerUnit"]
                               };
                foreach(var product in products)
                {
                    MessageBox.Show("ProductID= " + product.ProdID + " Name= " + product.ProductName + " Price =" + product.Price + "Quantity= " + product.Quantity, "Products with Price <50.00");
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conString = "Data Source=BLT10141\\SQLEXPRESS2017; Initial Catalog=Northwind;Integrated Security=True;";
            sqlCon = new SqlConnection(conString);
            qryString = "Select Country from Customers";
            sqlCon.Open();
            ds = new DataSet();
            
            sqlCmd = new SqlCommand(qryString, sqlCon);
            //da = new SqlDataAdapter(sqlCmd);
            dr = sqlCmd.ExecuteReader();
            while(dr.Read())
            {
                cmbCountries.Items.Add(dr["Country"]);
             }
            dr.Close();
            sqlCon.Close();

        }
    }
}
