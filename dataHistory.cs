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
    public partial class dataHistory : Form
    {
        public dataHistory()
        {
            InitializeComponent();
        }
        public string constring = "Data Source=JUNAID\\SQLEXPRESS;Initial Catalog=DBProject;Integrated Security=True";

        private void boxSelectHistoryTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            if (boxSelectHistoryTable.Text == "Customer History Table")
            {
                string q = "SELECT * FROM Customer_History";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataHistory_view.DataSource = dt;
                con.Close();
            }
            else if (boxSelectHistoryTable.Text == "Employee History Table")
            {
                string q1 = "select * from Employee_History";
                SqlCommand cmd1 = new SqlCommand(q1, con);
                cmd1.ExecuteNonQuery();
                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                da1.Fill(dt1);
                dataHistory_view.DataSource = dt1;
                con.Close();
            }
            else if (boxSelectHistoryTable.Text == "Item History Table")
            {
                string q2 = "SELECT * FROM ITEM_History";
                SqlCommand cmd2 = new SqlCommand(q2, con);
                cmd2.ExecuteNonQuery();
                DataTable dt2 = new DataTable();
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                da2.Fill(dt2);
                dataHistory_view.DataSource = dt2;
                con.Close();
            }
            else if (boxSelectHistoryTable.Text == "Supplier History Table")
            {
                string q3 = "SELECT * FROM Supplier_History";
                SqlCommand cmd3 = new SqlCommand(q3, con);
                cmd3.ExecuteNonQuery();
                DataTable dt3 = new DataTable();
                SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
                da3.Fill(dt3);
                dataHistory_view.DataSource = dt3;
                con.Close();
            }
        }

        private void dataHistory_Load(object sender, EventArgs e)
        {
            
        }
    }
}
