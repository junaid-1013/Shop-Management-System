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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
            setCustId();
        }

        public string constring = "Data Source=JUNAID\\SQLEXPRESS;Initial Catalog=DBProject;Integrated Security=True";

        public void disp_data()
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string q = "SELECT * FROM CUSTOMER";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            Customer_view.DataSource = dt;
            con.Close();
        }

        public void setCustId()
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string q = "Select  MAX(RIGHT(CUST_ID, 3)) AS ExtractString FROM CUSTOMER ";
            SqlCommand cmd = new SqlCommand(q, con);
            string result = (string)cmd.ExecuteScalar();
            txthidden.Text = result.ToString();


            if (txthidden.Text == "")
            {
                txthidden.Text = "000";
            }
            int i = Convert.ToInt32(txthidden.Text);
            i++;
            txthidden.Text = i.ToString();

            string oId = "C" + String.Format("{00:000}", i);
            txtCust_Id.Text = oId;
        }

        private void btnAdd_Cust_Click(object sender, EventArgs e)
        {
            if (txtCust_Id.Text == "" || txtCust_Name.Text == "" || txtCust_City.Text == "" || txtCust_RegDate.Text == "" || txtCust_Contact.Text == "" )
            {
                MessageBox.Show("Information Missing", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                string q1 = "Select Count(*) from CUSTOMER where CUST_ID = '" + txtCust_Id.Text + "'";
                SqlCommand cmd1 = new SqlCommand(q1, con);
                int count = 0;
                count = Convert.ToInt32(cmd1.ExecuteScalar());
                if (count == 0)
                {
                    string q = "INSERT INTO CUSTOMER(CUST_ID,CUST_Name,CUST_RegDate,CUST_City,CUST_Contact) VALUES('" + txtCust_Id.Text.ToString() + "','" + txtCust_Name.Text.ToString() + "','" + txtCust_RegDate.Text.ToString() + "','" + txtCust_City.Text.ToString() + "','" + txtCust_Contact.Text.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    disp_data();
                    MessageBox.Show("Data Added Succesfully...!");
                    txtCust_Id.Text = "";
                    txtCust_Name.Text = "";
                    txtCust_RegDate.Text = "";
                    txtCust_City.Text = "";
                    txtCust_Contact.Text = "";
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Record already exist with that ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
            }

            setCustId();
        }

        private void btnSearch_Cust_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string q1 = "Select Count(*) from CUSTOMER where CUST_ID = '" + txtCust_Id.Text + "'";
            SqlCommand cmd1 = new SqlCommand(q1, con);
            int count = 0;
            count = Convert.ToInt32(cmd1.ExecuteScalar());
            if (count == 1)
            {
                string q = "SELECT * FROM CUSTOMER WHERE CUST_ID = ('" + txtCust_Id.Text.ToString() + "')";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                Customer_view.DataSource = dt;
                txtCust_Id.Text = "";
                txtCust_Name.Text = "";
                txtCust_RegDate.Text = "";
                txtCust_City.Text = "";
                txtCust_Contact.Text = "";
                con.Close();
            }
            else
            {
                MessageBox.Show("No Record found against that ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }

            setCustId();
        }

        private void btnUpdate_Cust_Click(object sender, EventArgs e)
        {
            if (txtCust_Id.Text == "" || txtCust_Name.Text == "" || txtCust_City.Text == "" || txtCust_RegDate.Text == "" || txtCust_Contact.Text == "")
            {
                MessageBox.Show("Information Missing", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                string q1 = "Select Count(*) from CUSTOMER where CUST_ID = '" + txtCust_Id.Text + "'";
                SqlCommand cmd1 = new SqlCommand(q1, con);
                int count = 0;
                count = Convert.ToInt32(cmd1.ExecuteScalar());
                if (count == 1)
                {
                    string q = "UPDATE CUSTOMER SET CUST_Name='" + txtCust_Name.Text.ToString() + "',CUST_RegDate='" + txtCust_RegDate.Text.ToString() + "',CUST_City='" + txtCust_City.Text.ToString() + "',CUST_Contact='" + txtCust_Contact.Text.ToString() + "' where CUST_ID ='" + txtCust_Id.Text.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    disp_data();
                    MessageBox.Show("Update Succesfully...!");
                    txtCust_Id.Text = "";
                    txtCust_Name.Text = "";
                    txtCust_RegDate.Text = "";
                    txtCust_City.Text = "";
                    txtCust_Contact.Text = "";
                    con.Close();
                }
                else
                {
                    MessageBox.Show("No Record found against that ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
            }

            setCustId();
        }

        private void btnDelete_Cust_Click(object sender, EventArgs e)
        {
            
            if (txtCust_Id.Text == "")
            {
                MessageBox.Show("Information Missing Please provide only Customer Id", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                string q3 = "Select Count(*) from Orders where CUST_ID = '" + txtCust_Id.Text + "'";
                SqlCommand cmd2 = new SqlCommand(q3, con);
                int count2 = 0;
                count2 = Convert.ToInt32(cmd2.ExecuteScalar());
                if (count2 >= 1)
                {
                    MessageBox.Show("This operation cannot be performed beacause order detail table needs to strore data of this customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string q1 = "Select Count(*) from CUSTOMER where CUST_ID = '" + txtCust_Id.Text + "'";
                    SqlCommand cmd1 = new SqlCommand(q1, con);
                    int count = 0;
                    count = Convert.ToInt32(cmd1.ExecuteScalar());
                    if (count == 1)
                    {
                        string q = "DELETE FROM CUSTOMER WHERE CUST_ID = ('" + txtCust_Id.Text.ToString() + "')";
                        SqlCommand cmd = new SqlCommand(q, con);
                        cmd.ExecuteNonQuery();
                        disp_data();
                        MessageBox.Show("Deleted Succesfully...!");
                        txtCust_Id.Text = "";
                        txtCust_Name.Text = "";
                        txtCust_RegDate.Text = "";
                        txtCust_City.Text = "";
                        txtCust_Contact.Text = "";
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("No Record found against that ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                    }
                }
            }

            setCustId();
        }


        private void Customer_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            disp_data();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBProjectDataSet1.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.dBProjectDataSet1.CUSTOMER);

        }

        private void txtCust_Contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
