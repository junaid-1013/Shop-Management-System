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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            setEmpId();
        }

        public string constring = "Data Source=JUNAID\\SQLEXPRESS;Initial Catalog=DBProject;Integrated Security=True";

        public void disp_data()
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string q = "SELECT * FROM EMPLOYEE";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            Employee_view.DataSource = dt;
            con.Close();


        }
        public void setEmpId()
        {

            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string q = "Select  MAX(RIGHT(EMP_ID, 3)) AS ExtractString FROM EMPLOYEE ";
            SqlCommand cmd = new SqlCommand(q, con);
            string result = (string)cmd.ExecuteScalar();
            label3.Text = result.ToString();


            if (label3.Text == "")
            {
                label3.Text = "000";
            }
            int i = Convert.ToInt32(label3.Text);
            i++;
            label3.Text = i.ToString();

            string oId = "E" + String.Format("{00:000}", i);
            txtEm_Id.Text = oId;
        }

        private void btnAdd_em_Click(object sender, EventArgs e)
        {
            if (txtEm_Add.Text == "" || txtEm_Id.Text == "" || txtEm_Login.Text == "" || txtEm_Name.Text == "" || txtEm_Pw.Text == "" || txtSalary.Text == "")
            {
                MessageBox.Show("Information Missing", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                string q1 = "Select Count(*) from EMPLOYEE where EMP_ID = '"+txtEm_Id.Text+"'";
                SqlCommand cmd = new SqlCommand(q1, con);
                int count = 0;
                count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 0)
                {
                    string q = "INSERT INTO EMPLOYEE(EMP_ID,EMP_Name,EMP_BirthDay,EMP_City,EMP_Login,EMP_Password,EMP_Salary) VALUES('" + txtEm_Id.Text.ToString() + "','" + txtEm_Name.Text.ToString() + "','" + Em_birth.Text.ToString() + "','" + txtEm_Add.Text.ToString() + "','" + em_login.Text.ToString() + "','" + em_Pw.Text.ToString() + "','" + txtSalary.Text.ToString() + "')";
                    SqlCommand cmd1 = new SqlCommand(q, con);
                    cmd1.ExecuteNonQuery();
                    disp_data();
                    MessageBox.Show("Data Added Succesfully...!");
                    txtEm_Id.Text = "";
                    txtEm_Name.Text = "";
                    Em_birth.Text = "";
                    txtEm_Add.Text = "";
                    em_login.Text = "";
                    em_Pw.Text = "";
                    txtSalary.Text = "";
                    con.Close();
                    setEmpId();
                }
                else
                {
                    MessageBox.Show("Record already exist with that ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
            }
        }

        private void btnSearch_em_Click(object sender, EventArgs e)
        {
        
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string q1 = "Select Count(*) from EMPLOYEE where EMP_ID = '" + txtEm_Id.Text + "'";
            SqlCommand cmd1 = new SqlCommand(q1, con);
            int count = 0;
            count = Convert.ToInt32(cmd1.ExecuteScalar());
            if (count == 1)
            {
                string q = "SELECT * FROM EMPLOYEE WHERE EMP_ID = ('" + txtEm_Id.Text.ToString() + "')";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                Employee_view.DataSource = dt;
                txtEm_Id.Text = "";
                txtEm_Name.Text = "";
                Em_birth.Text = "";
                txtEm_Add.Text = "";
                em_login.Text = "";
                em_Pw.Text = "";
                txtSalary.Text = "";
                con.Close();
                setEmpId();
            }
            else
            {
                MessageBox.Show("No Record found against that ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
            
        }

        private void btnUpdate_em_Click(object sender, EventArgs e)
        {
            if (txtEm_Add.Text == "" || txtEm_Id.Text == "" || txtEm_Login.Text == "" || txtEm_Name.Text == "" || txtEm_Pw.Text == "" || txtSalary.Text == "")
            {
                MessageBox.Show("Information Missing", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                string q1 = "Select Count(*) from EMPLOYEE where EMP_ID = '" + txtEm_Id.Text + "'";
                SqlCommand cmd1 = new SqlCommand(q1, con);
                int count = 0;
                count = Convert.ToInt32(cmd1.ExecuteScalar());
                if (count == 1)
                {
                    string q = "UPDATE EMPLOYEE SET EMP_Name='" + txtEm_Name.Text.ToString() + "',EMP_Birthday='" + Em_birth.Text.ToString() + "',EMP_City='" + txtEm_Add.Text.ToString() + "',EMP_Login='" + em_login.Text.ToString() + "',EMP_Password='" + em_Pw.Text.ToString() + "',EMP_Salary ='" + txtSalary.Text.ToString() + "' where EMP_ID ='" + txtEm_Id.Text.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    disp_data();
                    MessageBox.Show("Update Succesfully...!");
                    txtEm_Id.Text = "";
                    txtEm_Name.Text = "";
                    Em_birth.Text = "";
                    txtEm_Add.Text = "";
                    em_login.Text = "";
                    em_Pw.Text = "";
                    txtSalary.Text = "";
                    con.Close();
                    setEmpId();
                }
                else
                {
                    MessageBox.Show("No Record found against that ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
            }

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBProjectDataSet.EMPLOYEE' table. You can move, or remove it, as needed.
            this.eMPLOYEETableAdapter.Fill(this.dBProjectDataSet.EMPLOYEE);

        }

        private void Employee_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            disp_data();
        }

        private void btnDelete_em_Click(object sender, EventArgs e)
        {
            if (txtEm_Id.Text == "")
            {
                MessageBox.Show("Information Missing Please provide only Employee Id", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                string q1 = "Select Count(*) from EMPLOYEE where EMP_ID = '" + txtEm_Id.Text + "'";
                SqlCommand cmd1 = new SqlCommand(q1, con);
                int count = 0;
                count = Convert.ToInt32(cmd1.ExecuteScalar());
                if (count == 1)
                {
                    string q = "DELETE FROM EMPLOYEE WHERE EMP_ID = ('" + txtEm_Id.Text.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    disp_data();
                    MessageBox.Show("Deleted Succesfully...!");
                    txtEm_Id.Text = "";
                    txtEm_Name.Text = "";
                    Em_birth.Text = "";
                    txtEm_Add.Text = "";
                    em_login.Text = "";
                    em_Pw.Text = "";
                    txtSalary.Text = "";
                    con.Close();
                    setEmpId();
                }
                else
                {
                    MessageBox.Show("No Record found against that ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
            }
        }

        private void txtSalary_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
