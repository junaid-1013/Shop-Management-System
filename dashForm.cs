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

namespace Shop_Management__System
{
    public partial class dashForm : Form
    {

        public string constring = "Data Source=JUNAID\\SQLEXPRESS;Initial Catalog=DBProject;Integrated Security=True";

        public dashForm()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string q = "select count(CUST_ID) as general from CUSTOMER";
            SqlCommand cmd = new SqlCommand(q, con);
            Int32 rows_countC = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();

            totalCustomers.Text = rows_countC.ToString();

            string q1 = "select count(ORDER_ID) as general from ORDERS";
            SqlCommand cmd1 = new SqlCommand(q1, con);
            Int32 rows_countO = Convert.ToInt32(cmd1.ExecuteScalar());
            cmd1.Dispose();

            valuEOrder.Text = rows_countO.ToString();

            string q2 = "select sum(ORDER_QTY) as general from ORDER_DETAILS";
            SqlCommand cmd2 = new SqlCommand(q2, con);
            Int32 rows_countQ = Convert.ToInt32(cmd2.ExecuteScalar());
            cmd2.Dispose();

            valueSoldItems.Text = rows_countQ.ToString();

            string q3 = "select sum(BILL) as general from ORDERS";
            SqlCommand cmd3 = new SqlCommand(q3, con);
            Int32 rows_countS = Convert.ToInt32(cmd3.ExecuteScalar());
            cmd3.Dispose();

            Value_Sales.Text = rows_countS.ToString();

            string q4 = "select count(*) as general from ITEM where ITEM_Qty = 0";
            SqlCommand cmd4 = new SqlCommand(q4, con);
            Int32 rows_countSt = Convert.ToInt32(cmd4.ExecuteScalar());
            cmd3.Dispose();

            countOutOfStock.Text = rows_countSt.ToString();
            con.Close();

        }
    }
}
    

    

