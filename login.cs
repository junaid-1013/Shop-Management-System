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
using System.Runtime.InteropServices;

namespace Shop_Management__System
{
    public partial class login : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
    );
        public login()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        public string constring = "Data Source=JUNAID\\SQLEXPRESS;Initial Catalog=DBProject;Integrated Security=True";

        private void Sign_In(object sender, EventArgs e)
        {
            string query = "Select * from ADMIN where AD_NAME = '"+txtName.Text.Trim()+"' and AD_PW = '"+txtPass.Text.Trim()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, constring);
            DataTable dtl = new DataTable();
            sda.Fill(dtl);

            string query1 = "Select * from EMPLOYEE where EMP_Login = '" + txtName.Text.Trim() + "' and EMP_Password = '" + txtPass.Text.Trim() + "'";
            SqlDataAdapter sda1 = new SqlDataAdapter(query1, constring);
            DataTable dtl1 = new DataTable();
            sda1.Fill(dtl1);

            if (dtl.Rows.Count == 1)
            {
                MessageBox.Show("Login Succesfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dashboard ob = new dashboard();
                this.Hide();
                ob.Show();
            }

            else if (dtl1.Rows.Count == 1)
            {
                MessageBox.Show("Login Succesfull","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EmployeeDashboard ob = new EmployeeDashboard();
                this.Hide();
                ob.Show();
            }


            else
            {
                MessageBox.Show("Wrong Credentials","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void Close(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Password(object sender, EventArgs e)
        {

        }

        private void UserName(object sender, EventArgs e)
        {

        }
    }
}
