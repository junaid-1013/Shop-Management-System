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
    public partial class dashboard : Form
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
        public dashboard()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;


            lblTitle.Text = "DASHBOARD";
            this.pnlFormLoader.Controls.Clear();
            dashForm FrmDashboard_vrb = new dashForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true  };
            FrmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmDashboard_vrb);
            FrmDashboard_vrb.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top= btnDashboard.Top;
            pnlNav.Left= btnDashboard.Left;

            lblTitle.Text = "DASHBOARD";
            this.pnlFormLoader.Controls.Clear();
            dashForm FrmDashboard_vrb = new dashForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmDashboard_vrb);
            FrmDashboard_vrb.Show();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnEmployee.Height;
            pnlNav.Top = btnEmployee.Top;
            pnlNav.Left = btnEmployee.Left;

            lblTitle.Text = "ADD EMPLOYEE";
            this.pnlFormLoader.Controls.Clear();
            Employee FrmDashboard_vrb = new Employee() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmDashboard_vrb);
            FrmDashboard_vrb.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnReports.Height;
            pnlNav.Top = btnReports.Top;
            pnlNav.Left = btnReports.Left;

            lblTitle.Text = "DATA HISTORY";
            this.pnlFormLoader.Controls.Clear();
            dataHistory FrmDashboard_vrb = new dataHistory() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmDashboard_vrb);
            FrmDashboard_vrb.Show();
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

        private void btnAdditem_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAdditem.Height;
            pnlNav.Top = btnAdditem.Top;
            pnlNav.Left = btnAdditem.Left;

            lblTitle.Text = "ADD ITEM";
            this.pnlFormLoader.Controls.Clear();
            Additem FrmDashboard_vrb = new Additem() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmDashboard_vrb);
            FrmDashboard_vrb.Show();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSupplier.Height;
            pnlNav.Top = btnSupplier.Top;
            pnlNav.Left = btnSupplier.Left;

            lblTitle.Text = "SUPPLIER";
            this.pnlFormLoader.Controls.Clear();
            supplier FrmDashboard_vrb = new supplier() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
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
    }
}
