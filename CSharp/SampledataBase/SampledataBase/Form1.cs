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

namespace SampledataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        SqlDataReader dr;
        string conString, qryString;

        private void Form1_Load(object sender, EventArgs e)
        {
            conString = "data source=BLT10141\\SQLEXPRESS2017;" +
                "Initial Catalog=Northwind;Integrated Security=True;";
            sqlCon = new SqlConnection(conString);
            sqlCon.Open();
            qryString = "Select ProductName from Products";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            dr = sqlCmd.ExecuteReader();
            while (dr.Read())
            {
                cmbProducts.Items.Add(dr["ProductName"]);
            }
            dr.Close();
            sqlCon.Close();
            cmbProducts.Text = "All Products";
        }

        private void lsbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            sqlCon.Open();
            qryString = "Select ProductName from Products";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            dr = sqlCmd.ExecuteReader();
            while (dr.Read())
            {
                lsbProducts.Items.Add(dr["ProductName"]);
            }
            dr.Close();
            sqlCon.Close();
           
        }
        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            qryString = "Select UnitPrice from Products where ProductName='" + cmbProducts.Text + "'";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            sqlCon.Open();
            lblPrice.Text = "Unit Price" + sqlCmd.ExecuteScalar().ToString();
            sqlCon.Close();
        }
    }
}
