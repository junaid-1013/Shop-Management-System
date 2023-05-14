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
    public partial class PlaceOrder : Form
    {
        public PlaceOrder()
        {
            InitializeComponent();
            fillBoxSelectCustomer();
            fillBoxSelectItem();
            setOrderId();

            txtCustID.Text = "";
            txtItem_Name.Text = "";
            txtItem_UPrice.Text = "";
            txtCust_City.Text = "";
            txtCust_Contact.Text = "";
            txtTotal.Text = "";

        }
        int qty, gTotal = 0, amount;

        public string constring = "Data Source=JUNAID\\SQLEXPRESS;Initial Catalog=DBProject;Integrated Security=True";

        void fillBoxSelectCustomer()
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string q = "Select CUST_ID,CUST_Name from CUSTOMER";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable selectCustomer = new DataTable();
            da.Fill(selectCustomer);
            boxSelectCustomer.DataSource = selectCustomer;
            boxSelectCustomer.DisplayMember = "CUST_Name";
            boxSelectCustomer.ValueMember = "CUST_ID";
        }
        void fillBoxSelectItem()
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string q = "Select ITEM_ID from ITEM";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable selectItem = new DataTable();
            da.Fill(selectItem);
            boxSelectItem.DataSource = selectItem;
            boxSelectItem.DisplayMember = "ITEM_ID";
            boxSelectItem.ValueMember = "ITEM_ID";
        }

        private void btnSearch_Cust_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string q = "Select * from CUSTOMER where CUST_Name= '"+boxSelectCustomer.Text+"'";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            SqlDataAdapter sda1 = new SqlDataAdapter(q, constring);
            DataTable dtl1 = new DataTable();
            sda1.Fill(dtl1);
            if (dtl1.Rows.Count == 1)
            {
                while (dr.Read())
                {
                    String conta = (string)dr["CUST_Contact"].ToString();
                    txtCust_Contact.Text = conta;

                    String city = (string)dr["CUST_City"].ToString();
                    txtCust_City.Text = city;

                    String cID = (string)dr["CUST_ID"].ToString();
                    txtCustID.Text = cID;
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Data Not Found");
            }
           
        }

        private void btnSearch_item_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string q = "Select * from ITEM where ITEM_ID= '" + boxSelectItem.Text + "'";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                String iName = (string)dr["ITEM_Name"].ToString();
                txtItem_Name.Text = iName;

                String iUPrice = (string)dr["ITEM_RetailUnitPrice"].ToString();
                txtItem_UPrice.Text = iUPrice;
            }
            con.Close();
        }

        private void PlaceOrder_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        public void setOrderId()
        {

            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string q = "Select  MAX(RIGHT(Order_id, 3)) AS ExtractString FROM ORDERS " ;
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

            string oId = "K" + String.Format("{00:000}", i);
            txtOrder_Id.Text=oId;
         }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblOrderTime.Text = DateTime.Now.ToLongTimeString();
            lblOrderDate.Text = DateTime.Now.ToShortDateString();
        }

        private void txtOrder_Id_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string q = "Select * from ITEM where ITEM_ID= '" + boxSelectItem.Text + "'";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                String iName = (string)dr["ITEM_Name"].ToString();
                txtItem_Name.Text = iName;

                String iUPrice = (string)dr["ITEM_RetailUnitPrice"].ToString();
                txtItem_UPrice.Text = iUPrice;
            }
            con.Close();
        }
        private void txtDropQty_ValueChanged_1(object sender, EventArgs e)
        {

            if (txtItem_Name.Text == "" || txtItem_UPrice.Text == "")
            {
                MessageBox.Show("Missing Information", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txtDropQty.Value >= 0)
                {
                    Int64 quan = Int64.Parse(txtDropQty.Value.ToString());
                    Int64 price = Int64.Parse(txtItem_UPrice.Text);
                    txtTotal.Text = (quan * price).ToString();
                }
                else
                {
                    MessageBox.Show("Minimum Quantity needs to be 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Order_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public void getGrandTotal()
        {
            gTotal = 0;
            for (int i = 0; i<Order_view.Rows.Count; i++)
            {
                gTotal = gTotal + Convert.ToInt32(Order_view.Rows[i].Cells[4].Value);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                Order_view.Rows.RemoveAt(this.Order_view.SelectedRows[0].Index);

            }
            catch { }
            getGrandTotal();
            txtGrandTotal.Text = "Rs. " + gTotal;
        }
        private void UpdateStock()
        {
            try
            {
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                string q = "EXEC Update_Qty '" + txtDropQty.Text + "','" + boxSelectItem.Text + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnAddToCart_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select ITEM_QTY from ITEM where ITEM_ID = '"+boxSelectItem.Text+"'",conn);
            int Stock = (int)cmd.ExecuteScalar();
            conn.Close();

            if (txtTotal.Text != "0" && txtTotal.Text != "")
            {
                if (txtDropQty.Value >= 1)
                {
                    if (Convert.ToInt32(txtDropQty.Text) <= Stock)
                    {
                        if (txtItem_Name.Text != "" && txtItem_UPrice.Text != "" && txtCustID.Text!="" && txtCust_City.Text != "" && txtCust_Contact.Text != "")
                        {
                            int  check=0;

                            for (int i = 0; i < Order_view.Rows.Count; i++) 
                            {
                                if (boxSelectItem.Text == Order_view.Rows[i].Cells[0].Value)
                                {
                                    Int32 newqty = Convert.ToInt32(txtDropQty.Value) + Convert.ToInt32(Order_view.Rows [i].Cells[3].Value);
                                    Int32 newtotal = Convert.ToInt32(txtTotal.Text) + Convert.ToInt32(Order_view.Rows[i].Cells[4].Value);

                                    DataGridViewRow newdata = Order_view.Rows[i];
                                    newdata.Cells[0].Value = boxSelectItem.Text;
                                    newdata.Cells[1].Value = txtItem_Name.Text;
                                    newdata.Cells[2].Value = txtItem_UPrice.Text;
                                    newdata.Cells[3].Value = newqty;
                                    newdata.Cells[4].Value = newtotal;
                                    check = 1;
                                }
                                
                            }

                            if (check == 0)
                            {
                                int n = Order_view.Rows.Add();
                                Order_view.Rows[n].Cells[0].Value = boxSelectItem.Text;
                                Order_view.Rows[n].Cells[1].Value = txtItem_Name.Text;
                                Order_view.Rows[n].Cells[2].Value = txtItem_UPrice.Text;
                                Order_view.Rows[n].Cells[3].Value = txtDropQty.Text;
                                Order_view.Rows[n].Cells[4].Value = txtTotal.Text;
                            }
                            getGrandTotal();
                            txtGrandTotal.Text = "Rs. " + gTotal;

                            UpdateStock();
                            txtItem_Name.Text = "";
                            txtItem_UPrice.Text = "";
                            txtTotal.Text = "";
                            txtDropQty.ResetText();

                        }
                        else
                        {
                            MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Not Enough In the Stock", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Minimum Quantity needs to be 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Minimum Quantity needs to be 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

            if (gTotal == 0 || txtCustID.Text == "" || txtCust_City.Text == "" || txtCust_Contact.Text == "")
            {
                MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                getGrandTotal();

                SqlConnection con = new SqlConnection(constring);
                con.Open();
                string q = "EXEC PLACE_ORDER '" + txtOrder_Id.Text + "','" + lblOrderDate.Text + "','" + lblOrderTime.Text + "','" + txtCustID.Text + "','" + gTotal + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();

                for (int i = 0; i < Order_view.Rows.Count - 1; i++)
                {
                    string q1 = "Insert into ORDER_DETAILS(ORDER_ID, ITEM_ID, ORDER_QTY, Total_Price) values ('" + txtOrder_Id.Text.ToString() + "','" + Order_view.Rows[i].Cells[0].Value + "','" + Order_view.Rows[i].Cells[3].Value + "','" + Order_view.Rows[i].Cells[4].Value + "')";
                    SqlCommand cmd1 = new SqlCommand(q1, con);
                    cmd1.ExecuteNonQuery();
                }
                Order_view.Rows.Clear();

                con.Close();
                setOrderId();

                txtCustID.Text = "";
                txtItem_Name.Text = "";
                txtItem_UPrice.Text = "";
                txtCust_City.Text = "";
                txtCust_Contact.Text = "";
                txtTotal.Text = "";
            }
        }
    }
}
