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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        SqlDataReader dr,d;
        string conString, qryString;

        private void cmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lBox.Items.Clear();
            qryString = "select ContactName from Customers where Country='" + cmbBox.Text + "'";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            sqlCon.Open();
            d = sqlCmd.ExecuteReader();
            while (d.Read())
            {
                lBox.Items.Add(d["ContactName"]);

            }
           // lBox.ResetText();
            //lBox.Items.Clear();

            sqlCon.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conString = "data source=BLT10141\\SQLEXPRESS2017;" +
                "Initial Catalog=Northwind;Integrated Security=True;";
            sqlCon = new SqlConnection(conString);
            sqlCon.Open();
            qryString = "Select distinct Country from Customers";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            dr = sqlCmd.ExecuteReader();
            while (dr.Read())
            {
                cmbBox.Items.Add(dr["Country"]);
            }
            dr.Close();
            sqlCon.Close();
        }

    }
}
