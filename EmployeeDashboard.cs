using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Shop_Management__System
{
    public partial class EmployeeDashboard : Form
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
        public EmployeeDashboard()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnPlaceOrder.Height;
            pnlNav.Top = btnPlaceOrder.Top;
            pnlNav.Left = btnPlaceOrder.Left;


            lblTitle.Text = "PLACE ORDER";
            this.pnlFormLoader.Controls.Clear();
            PlaceOrder FrmEmployeeDashboard_vrb = new PlaceOrder() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmEmployeeDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmEmployeeDashboard_vrb);
            FrmEmployeeDashboard_vrb.Show();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnPlaceOrder.Height;
            pnlNav.Top = btnPlaceOrder.Top;
            pnlNav.Left = btnPlaceOrder.Left;


            lblTitle.Text = "PLACE ORDER";
            this.pnlFormLoader.Controls.Clear();
            PlaceOrder FrmEmployeeDashboard_vrb = new PlaceOrder() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmEmployeeDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmEmployeeDashboard_vrb);
            FrmEmployeeDashboard_vrb.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCustomer.Height;
            pnlNav.Top = btnCustomer.Top;
            pnlNav.Left = btnCustomer.Left;

            lblTitle.Text = "CUSTOMERS";
            this.pnlFormLoader.Controls.Clear();
            Customer FrmDashboard_vrb = new Customer() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmDashboard_vrb);
            FrmDashboard_vrb.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnLogout.Height;
            pnlNav.Top = btnLogout.Top;
            pnlNav.Left = btnLogout.Left;

            this.Close();
            login ob = new login();
            ob.Show();
            MessageBox.Show("logout Succesfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnViewOrder.Height;
            pnlNav.Top = btnViewOrder.Top;
            pnlNav.Left = btnViewOrder.Left;

            lblTitle.Text = "VIEW ORDER";
            this.pnlFormLoader.Controls.Clear();
            viewOrder FrmDashboard_vrb = new viewOrder() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmDashboard_vrb);
            FrmDashboard_vrb.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAbout.Height;
            pnlNav.Top = btnAbout.Top;
            pnlNav.Left = btnAbout.Left;

            lblTitle.Text = "ABOUT";
            this.pnlFormLoader.Controls.Clear();
            about FrmDashboard_vrb = new about() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmDashboard_vrb);
            FrmDashboard_vrb.Show();
        }
    }
}
