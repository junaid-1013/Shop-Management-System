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
    public partial class supplier : Form
    {
        public supplier()
        {
            InitializeComponent();
            setSuppId();
        }

        public string constring = "Data Source=JUNAID\\SQLEXPRESS;Initial Catalog=DBProject;Integrated Security=True";

        public void disp_data()
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string q = "SELECT * FROM SUPPLIER";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            Supplier_view.DataSource = dt;
            con.Close();


        }
        public void setSuppId()
        {

            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string q = "Select  MAX(RIGHT(SUPP_ID, 3)) AS ExtractString FROM SUPPLIER ";
            SqlCommand cmd = new SqlCommand(q, con);
            string result = (string)cmd.ExecuteScalar();
            label1.Text = result.ToString();


            if (label1.Text == "")
            {
                label1.Text = "000";
            }
            int i = Convert.ToInt32(label1.Text);
            i++;
            label1.Text = i.ToString();

            string oId = "S" + String.Format("{00:000}", i);
            txtSupp_Id.Text = oId;
        }

        private void supplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBProjectDataSet3.SUPPLIER' table. You can move, or remove it, as needed.
            this.sUPPLIERTableAdapter.Fill(this.dBProjectDataSet3.SUPPLIER);

        }

        private void btnAdd_Supp_Click(object sender, EventArgs e)
        {
            if (txtSupp_Id.Text == "" || txtSupp_Name.Text == "" || txtSupp_Address.Text == "" || txtSupp_Email.Text == "" || txtSupp_Phone.Text == "")
            {
                MessageBox.Show("Information Missing", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                string q1 = "Select Count(*) from SUPPLIER where SUPP_ID = '" + txtSupp_Id.Text + "'";
                SqlCommand cmd1 = new SqlCommand(q1, con);
                int count = 0;
                count = Convert.ToInt32(cmd1.ExecuteScalar());
                if (count == 0)
                {
                    string q = "INSERT INTO SUPPLIER(SUPP_ID,SUPP_Name,SUPP_Address,SUPP_Phone,SUPP_Email) VALUES('" + txtSupp_Id.Text.ToString() + "','" + txtSupp_Name.Text.ToString() + "','" + txtSupp_Address.Text.ToString() + "','" + txtSupp_Phone.Text.ToString() + "','" + txtSupp_Email.Text.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    disp_data();
                    MessageBox.Show("Data Added Succesfully...!");
                    txtSupp_Id.Text = "";
                    txtSupp_Name.Text = "";
                    txtSupp_Address.Text = "";
                    txtSupp_Phone.Text = "";
                    txtSupp_Email.Text = "";
                    con.Close();
                    setSuppId();
                }
                else
                {
                    MessageBox.Show("Record already exist with that ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
                disp_data();
            }
        }

        private void btnSearch_Supp_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string q1 = "Select Count(*) from SUPPLIER where SUPP_ID = '" + txtSupp_Id.Text + "'";
            SqlCommand cmd1 = new SqlCommand(q1, con);
            int count = 0;
            count = Convert.ToInt32(cmd1.ExecuteScalar());
            if (count == 1)
            {
                string q = "SELECT * FROM SUPPLIER WHERE SUPP_ID = ('" + txtSupp_Id.Text.ToString() + "')";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                Supplier_view.DataSource = dt;
                txtSupp_Id.Text = "";
                txtSupp_Name.Text = "";
                txtSupp_Address.Text = "";
                txtSupp_Phone.Text = "";
                txtSupp_Email.Text = "";
                con.Close();
                setSuppId();
            }
            else
            {
                MessageBox.Show("No Record found against that ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }

        }

        private void btnUpdate_Supp_Click(object sender, EventArgs e)
        {
            if (txtSupp_Id.Text == "" || txtSupp_Name.Text == "" || txtSupp_Address.Text == "" || txtSupp_Email.Text == "" || txtSupp_Phone.Text == "")
            {
                MessageBox.Show("Information Missing", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                string q1 = "Select Count(*) from SUPPLIER where SUPP_ID = '" + txtSupp_Id.Text + "'";
                SqlCommand cmd1 = new SqlCommand(q1, con);
                int count = 0;
                count = Convert.ToInt32(cmd1.ExecuteScalar());
                if (count == 1)
                {
                    string q = "UPDATE SUPPLIER SET SUPP_Name='" + txtSupp_Name.Text.ToString() + "',SUPP_Address='" + txtSupp_Address.Text.ToString() + "',SUPP_Phone='" + txtSupp_Phone.Text.ToString() + "',SUPP_Email='" + txtSupp_Email.Text.ToString() + "' where SUPP_ID ='" + txtSupp_Id.Text.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update Succesfully...!");
                    txtSupp_Id.Text = "";
                    txtSupp_Name.Text = "";
                    txtSupp_Address.Text = "";
                    txtSupp_Phone.Text = "";
                    txtSupp_Email.Text = "";
                    con.Close();
                    setSuppId();
                }
                else
                {
                    MessageBox.Show("No Record found against that ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
                disp_data();
            }
        }

        private void btnDelete_Supp_Click(object sender, EventArgs e)
        {
            if (txtSupp_Id.Text == "")
            {
                MessageBox.Show("Information Missing Please provide only Supplier Id", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                string q1 = "Select Count(*) from SUPPLIER where SUPP_ID = '" + txtSupp_Id.Text + "'";
                SqlCommand cmd1 = new SqlCommand(q1, con);
                int count = 0;
                count = Convert.ToInt32(cmd1.ExecuteScalar());
                if (count == 1)
                {

                    string q = "DELETE FROM SUPPLIER WHERE SUPP_ID = ('" + txtSupp_Id.Text.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted Succesfully...!");
                    txtSupp_Id.Text = "";
                    txtSupp_Name.Text = "";
                    txtSupp_Address.Text = "";
                    txtSupp_Phone.Text = "";
                    txtSupp_Email.Text = "";
                    con.Close();
                    setSuppId();
                }
                else
                {
                    MessageBox.Show("No Record found against that ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
                disp_data();
            }
        }

        private void Supplier_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            disp_data();
        }
    }
}
