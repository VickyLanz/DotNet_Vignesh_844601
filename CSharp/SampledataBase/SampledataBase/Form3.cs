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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        SqlDataReader dr;
        string conString, qryString;

        private void label1_Click(object sender, EventArgs e)  { }

        private void cmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            qryString = "Select UnitPrice from Products where ProductName='" + cmbBox.Text + "'";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            sqlCon.Open();
            prodPrice.Text = "Price :" + sqlCmd.ExecuteScalar().ToString();
            sqlCon.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            qryString = "update Products Set UnitPrice=" + Convert.ToString(cmbPrice.Text) + " where ProductName='" + cmbBox.Text + "'";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            sqlCon.Open();
            sqlCmd.ExecuteNonQuery();
            MessageBox.Show("Product Updated ", "New Product Price");
            sqlCon.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            conString = "Data Source=BLT10141\\SQLEXPRESS2017; Initial Catalog=Northwind;Integrated Security=True;";
            sqlCon = new SqlConnection(conString);
            sqlCon.Open();
            qryString = "Select ProductName from Products";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            dr = sqlCmd.ExecuteReader();
            while (dr.Read())
            {
                cmbBox.Items.Add(dr["ProductName"]);
            }
            dr.Close();
            sqlCon.Close();
            cmbBox.Text = "All Products";
        }

    }
}
