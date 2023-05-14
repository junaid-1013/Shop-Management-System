using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Management__System
{
    public partial class viewOrder : Form
    {
        public viewOrder()
        {
            InitializeComponent();
        }

        private void viewOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBProjectDataSet5.ORDER_DETAILS' table. You can move, or remove it, as needed.
            this.oRDER_DETAILSTableAdapter.Fill(this.dBProjectDataSet5.ORDER_DETAILS);
            // TODO: This line of code loads data into the 'dBProjectDataSet4.ORDERS' table. You can move, or remove it, as needed.
            this.oRDERSTableAdapter.Fill(this.dBProjectDataSet4.ORDERS);

        }
    }
}
