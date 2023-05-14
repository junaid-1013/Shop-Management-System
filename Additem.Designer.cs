namespace Shop_Management__System
{
    partial class Additem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDelete_Item = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate_Item = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch_Item = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd_Item = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtItem_Quantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtItem_BatchDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtItem_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSupp_ID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBatch_ID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtItem_Retail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEm_Pw = new System.Windows.Forms.Label();
            this.txtEm_Login = new System.Windows.Forms.Label();
            this.txtItem_PurchaseUnitPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label = new System.Windows.Forms.Label();
            this.txtItem_Id = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Item_view = new System.Windows.Forms.DataGridView();
            this.iTEMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUPPIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMPurchaseUnitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMRetailUnitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMBatchIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMBatchDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBProjectDataSet2 = new Shop_Management__System.DBProjectDataSet2();
            this.iTEMTableAdapter = new Shop_Management__System.DBProjectDataSet2TableAdapters.ITEMTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Item_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProjectDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete_Item
            // 
            this.btnDelete_Item.AutoRoundedCorners = true;
            this.btnDelete_Item.BorderColor = System.Drawing.Color.Transparent;
            this.btnDelete_Item.BorderRadius = 20;
            this.btnDelete_Item.CheckedState.Parent = this.btnDelete_Item;
            this.btnDelete_Item.CustomImages.Parent = this.btnDelete_Item;
            this.btnDelete_Item.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete_Item.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete_Item.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete_Item.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete_Item.DisabledState.Parent = this.btnDelete_Item;
            this.btnDelete_Item.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btnDelete_Item.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete_Item.ForeColor = System.Drawing.Color.White;
            this.btnDelete_Item.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnDelete_Item.HoverState.Parent = this.btnDelete_Item;
            this.btnDelete_Item.Location = new System.Drawing.Point(500, 225);
            this.btnDelete_Item.Name = "btnDelete_Item";
            this.btnDelete_Item.ShadowDecoration.Parent = this.btnDelete_Item;
            this.btnDelete_Item.Size = new System.Drawing.Size(160, 42);
            this.btnDelete_Item.TabIndex = 26;
            this.btnDelete_Item.Text = "Delete";
            this.btnDelete_Item.Click += new System.EventHandler(this.btnDelete_Item_Click);
            // 
            // btnUpdate_Item
            // 
            this.btnUpdate_Item.AutoRoundedCorners = true;
            this.btnUpdate_Item.BorderColor = System.Drawing.Color.Transparent;
            this.btnUpdate_Item.BorderRadius = 20;
            this.btnUpdate_Item.CheckedState.Parent = this.btnUpdate_Item;
            this.btnUpdate_Item.CustomImages.Parent = this.btnUpdate_Item;
            this.btnUpdate_Item.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate_Item.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate_Item.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate_Item.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate_Item.DisabledState.Parent = this.btnUpdate_Item;
            this.btnUpdate_Item.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btnUpdate_Item.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnUpdate_Item.ForeColor = System.Drawing.Color.White;
            this.btnUpdate_Item.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnUpdate_Item.HoverState.Parent = this.btnUpdate_Item;
            this.btnUpdate_Item.Location = new System.Drawing.Point(500, 154);
            this.btnUpdate_Item.Name = "btnUpdate_Item";
            this.btnUpdate_Item.ShadowDecoration.Parent = this.btnUpdate_Item;
            this.btnUpdate_Item.Size = new System.Drawing.Size(160, 42);
            this.btnUpdate_Item.TabIndex = 25;
            this.btnUpdate_Item.Text = "Update";
            this.btnUpdate_Item.Click += new System.EventHandler(this.btnUpdate_Item_Click);
            // 
            // btnSearch_Item
            // 
            this.btnSearch_Item.AutoRoundedCorners = true;
            this.btnSearch_Item.BorderColor = System.Drawing.Color.Transparent;
            this.btnSearch_Item.BorderRadius = 20;
            this.btnSearch_Item.CheckedState.Parent = this.btnSearch_Item;
            this.btnSearch_Item.CustomImages.Parent = this.btnSearch_Item;
            this.btnSearch_Item.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch_Item.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch_Item.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch_Item.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch_Item.DisabledState.Parent = this.btnSearch_Item;
            this.btnSearch_Item.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btnSearch_Item.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSearch_Item.ForeColor = System.Drawing.Color.White;
            this.btnSearch_Item.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSearch_Item.HoverState.Parent = this.btnSearch_Item;
            this.btnSearch_Item.Location = new System.Drawing.Point(500, 88);
            this.btnSearch_Item.Name = "btnSearch_Item";
            this.btnSearch_Item.ShadowDecoration.Parent = this.btnSearch_Item;
            this.btnSearch_Item.Size = new System.Drawing.Size(160, 42);
            this.btnSearch_Item.TabIndex = 24;
            this.btnSearch_Item.Text = "Search";
            this.btnSearch_Item.Click += new System.EventHandler(this.btnSearch_Item_Click);
            // 
            // btnAdd_Item
            // 
            this.btnAdd_Item.AutoRoundedCorners = true;
            this.btnAdd_Item.BorderColor = System.Drawing.Color.Transparent;
            this.btnAdd_Item.BorderRadius = 20;
            this.btnAdd_Item.CheckedState.Parent = this.btnAdd_Item;
            this.btnAdd_Item.CustomImages.Parent = this.btnAdd_Item;
            this.btnAdd_Item.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd_Item.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd_Item.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd_Item.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd_Item.DisabledState.Parent = this.btnAdd_Item;
            this.btnAdd_Item.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btnAdd_Item.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAdd_Item.ForeColor = System.Drawing.Color.White;
            this.btnAdd_Item.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAdd_Item.HoverState.Parent = this.btnAdd_Item;
            this.btnAdd_Item.Location = new System.Drawing.Point(500, 22);
            this.btnAdd_Item.Name = "btnAdd_Item";
            this.btnAdd_Item.ShadowDecoration.Parent = this.btnAdd_Item;
            this.btnAdd_Item.Size = new System.Drawing.Size(160, 42);
            this.btnAdd_Item.TabIndex = 23;
            this.btnAdd_Item.Text = "Add";
            this.btnAdd_Item.Click += new System.EventHandler(this.btnAdd_Item_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.txtItem_Quantity);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtItem_BatchDate);
            this.panel1.Controls.Add(this.txtItem_Name);
            this.panel1.Controls.Add(this.txtSupp_ID);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtBatch_ID);
            this.panel1.Controls.Add(this.txtItem_Retail);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtEm_Pw);
            this.panel1.Controls.Add(this.txtEm_Login);
            this.panel1.Controls.Add(this.txtItem_PurchaseUnitPrice);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.txtItem_Id);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 263);
            this.panel1.TabIndex = 22;
            // 
            // txtItem_Quantity
            // 
            this.txtItem_Quantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtItem_Quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItem_Quantity.DefaultText = "";
            this.txtItem_Quantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtItem_Quantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtItem_Quantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItem_Quantity.DisabledState.Parent = this.txtItem_Quantity;
            this.txtItem_Quantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItem_Quantity.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtItem_Quantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtItem_Quantity.FocusedState.Parent = this.txtItem_Quantity;
            this.txtItem_Quantity.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtItem_Quantity.ForeColor = System.Drawing.Color.Transparent;
            this.txtItem_Quantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtItem_Quantity.HoverState.Parent = this.txtItem_Quantity;
            this.txtItem_Quantity.Location = new System.Drawing.Point(244, 176);
            this.txtItem_Quantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtItem_Quantity.Name = "txtItem_Quantity";
            this.txtItem_Quantity.PasswordChar = '\0';
            this.txtItem_Quantity.PlaceholderText = "";
            this.txtItem_Quantity.SelectedText = "";
            this.txtItem_Quantity.ShadowDecoration.Parent = this.txtItem_Quantity;
            this.txtItem_Quantity.Size = new System.Drawing.Size(194, 23);
            this.txtItem_Quantity.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtItem_Quantity.TabIndex = 15;
            this.txtItem_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItem_Quantity_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(241, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Quantity ";
            // 
            // txtItem_BatchDate
            // 
            this.txtItem_BatchDate.Animated = true;
            this.txtItem_BatchDate.AutoRoundedCorners = true;
            this.txtItem_BatchDate.BackColor = System.Drawing.Color.Transparent;
            this.txtItem_BatchDate.BorderColor = System.Drawing.Color.White;
            this.txtItem_BatchDate.BorderRadius = 17;
            this.txtItem_BatchDate.Checked = true;
            this.txtItem_BatchDate.CheckedState.Parent = this.txtItem_BatchDate;
            this.txtItem_BatchDate.CustomFormat = "yyyy-MM-dd";
            this.txtItem_BatchDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtItem_BatchDate.Font = new System.Drawing.Font("Cambria Math", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtItem_BatchDate.ForeColor = System.Drawing.Color.White;
            this.txtItem_BatchDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtItem_BatchDate.HoverState.Parent = this.txtItem_BatchDate;
            this.txtItem_BatchDate.IndicateFocus = true;
            this.txtItem_BatchDate.Location = new System.Drawing.Point(244, 105);
            this.txtItem_BatchDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtItem_BatchDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtItem_BatchDate.Name = "txtItem_BatchDate";
            this.txtItem_BatchDate.ShadowDecoration.Parent = this.txtItem_BatchDate;
            this.txtItem_BatchDate.Size = new System.Drawing.Size(168, 36);
            this.txtItem_BatchDate.TabIndex = 13;
            this.txtItem_BatchDate.UseTransparentBackground = true;
            this.txtItem_BatchDate.Value = new System.DateTime(2021, 12, 14, 0, 0, 0, 0);
            // 
            // txtItem_Name
            // 
            this.txtItem_Name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtItem_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItem_Name.DefaultText = "";
            this.txtItem_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtItem_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtItem_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItem_Name.DisabledState.Parent = this.txtItem_Name;
            this.txtItem_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItem_Name.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtItem_Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtItem_Name.FocusedState.Parent = this.txtItem_Name;
            this.txtItem_Name.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtItem_Name.ForeColor = System.Drawing.Color.Transparent;
            this.txtItem_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtItem_Name.HoverState.Parent = this.txtItem_Name;
            this.txtItem_Name.Location = new System.Drawing.Point(244, 30);
            this.txtItem_Name.Margin = new System.Windows.Forms.Padding(4);
            this.txtItem_Name.Name = "txtItem_Name";
            this.txtItem_Name.PasswordChar = '\0';
            this.txtItem_Name.PlaceholderText = "";
            this.txtItem_Name.SelectedText = "";
            this.txtItem_Name.ShadowDecoration.Parent = this.txtItem_Name;
            this.txtItem_Name.Size = new System.Drawing.Size(211, 23);
            this.txtItem_Name.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtItem_Name.TabIndex = 12;
            // 
            // txtSupp_ID
            // 
            this.txtSupp_ID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtSupp_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupp_ID.DefaultText = "";
            this.txtSupp_ID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSupp_ID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSupp_ID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupp_ID.DisabledState.Parent = this.txtSupp_ID;
            this.txtSupp_ID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupp_ID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtSupp_ID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSupp_ID.FocusedState.Parent = this.txtSupp_ID;
            this.txtSupp_ID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSupp_ID.ForeColor = System.Drawing.Color.Transparent;
            this.txtSupp_ID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSupp_ID.HoverState.Parent = this.txtSupp_ID;
            this.txtSupp_ID.Location = new System.Drawing.Point(244, 232);
            this.txtSupp_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupp_ID.Name = "txtSupp_ID";
            this.txtSupp_ID.PasswordChar = '\0';
            this.txtSupp_ID.PlaceholderText = "";
            this.txtSupp_ID.SelectedText = "";
            this.txtSupp_ID.ShadowDecoration.Parent = this.txtSupp_ID;
            this.txtSupp_ID.Size = new System.Drawing.Size(211, 23);
            this.txtSupp_ID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSupp_ID.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(241, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Batch Date";
            // 
            // txtBatch_ID
            // 
            this.txtBatch_ID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtBatch_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBatch_ID.DefaultText = "";
            this.txtBatch_ID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBatch_ID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBatch_ID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBatch_ID.DisabledState.Parent = this.txtBatch_ID;
            this.txtBatch_ID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBatch_ID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtBatch_ID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBatch_ID.FocusedState.Parent = this.txtBatch_ID;
            this.txtBatch_ID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBatch_ID.ForeColor = System.Drawing.Color.Transparent;
            this.txtBatch_ID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBatch_ID.HoverState.Parent = this.txtBatch_ID;
            this.txtBatch_ID.Location = new System.Drawing.Point(6, 232);
            this.txtBatch_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txtBatch_ID.Name = "txtBatch_ID";
            this.txtBatch_ID.PasswordChar = '\0';
            this.txtBatch_ID.PlaceholderText = "";
            this.txtBatch_ID.SelectedText = "";
            this.txtBatch_ID.ShadowDecoration.Parent = this.txtBatch_ID;
            this.txtBatch_ID.Size = new System.Drawing.Size(194, 23);
            this.txtBatch_ID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtBatch_ID.TabIndex = 12;
            // 
            // txtItem_Retail
            // 
            this.txtItem_Retail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtItem_Retail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItem_Retail.DefaultText = "";
            this.txtItem_Retail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtItem_Retail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtItem_Retail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItem_Retail.DisabledState.Parent = this.txtItem_Retail;
            this.txtItem_Retail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItem_Retail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtItem_Retail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtItem_Retail.FocusedState.Parent = this.txtItem_Retail;
            this.txtItem_Retail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtItem_Retail.ForeColor = System.Drawing.Color.Transparent;
            this.txtItem_Retail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtItem_Retail.HoverState.Parent = this.txtItem_Retail;
            this.txtItem_Retail.Location = new System.Drawing.Point(6, 176);
            this.txtItem_Retail.Margin = new System.Windows.Forms.Padding(4);
            this.txtItem_Retail.Name = "txtItem_Retail";
            this.txtItem_Retail.PasswordChar = '\0';
            this.txtItem_Retail.PlaceholderText = "";
            this.txtItem_Retail.SelectedText = "";
            this.txtItem_Retail.ShadowDecoration.Parent = this.txtItem_Retail;
            this.txtItem_Retail.Size = new System.Drawing.Size(194, 23);
            this.txtItem_Retail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtItem_Retail.TabIndex = 12;
            this.txtItem_Retail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItem_Retail_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(241, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Item Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Batch ID";
            // 
            // txtEm_Pw
            // 
            this.txtEm_Pw.AutoSize = true;
            this.txtEm_Pw.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEm_Pw.ForeColor = System.Drawing.Color.White;
            this.txtEm_Pw.Location = new System.Drawing.Point(241, 212);
            this.txtEm_Pw.Name = "txtEm_Pw";
            this.txtEm_Pw.Size = new System.Drawing.Size(78, 16);
            this.txtEm_Pw.TabIndex = 11;
            this.txtEm_Pw.Text = "Supplier ID";
            // 
            // txtEm_Login
            // 
            this.txtEm_Login.AutoSize = true;
            this.txtEm_Login.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEm_Login.ForeColor = System.Drawing.Color.White;
            this.txtEm_Login.Location = new System.Drawing.Point(3, 156);
            this.txtEm_Login.Name = "txtEm_Login";
            this.txtEm_Login.Size = new System.Drawing.Size(108, 16);
            this.txtEm_Login.TabIndex = 11;
            this.txtEm_Login.Text = "Retial Unit Price";
            // 
            // txtItem_PurchaseUnitPrice
            // 
            this.txtItem_PurchaseUnitPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtItem_PurchaseUnitPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItem_PurchaseUnitPrice.DefaultText = "";
            this.txtItem_PurchaseUnitPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtItem_PurchaseUnitPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtItem_PurchaseUnitPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItem_PurchaseUnitPrice.DisabledState.Parent = this.txtItem_PurchaseUnitPrice;
            this.txtItem_PurchaseUnitPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItem_PurchaseUnitPrice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtItem_PurchaseUnitPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtItem_PurchaseUnitPrice.FocusedState.Parent = this.txtItem_PurchaseUnitPrice;
            this.txtItem_PurchaseUnitPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtItem_PurchaseUnitPrice.ForeColor = System.Drawing.Color.Transparent;
            this.txtItem_PurchaseUnitPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtItem_PurchaseUnitPrice.HoverState.Parent = this.txtItem_PurchaseUnitPrice;
            this.txtItem_PurchaseUnitPrice.Location = new System.Drawing.Point(6, 105);
            this.txtItem_PurchaseUnitPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtItem_PurchaseUnitPrice.Name = "txtItem_PurchaseUnitPrice";
            this.txtItem_PurchaseUnitPrice.PasswordChar = '\0';
            this.txtItem_PurchaseUnitPrice.PlaceholderText = "";
            this.txtItem_PurchaseUnitPrice.SelectedText = "";
            this.txtItem_PurchaseUnitPrice.ShadowDecoration.Parent = this.txtItem_PurchaseUnitPrice;
            this.txtItem_PurchaseUnitPrice.Size = new System.Drawing.Size(194, 23);
            this.txtItem_PurchaseUnitPrice.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtItem_PurchaseUnitPrice.TabIndex = 12;
            this.txtItem_PurchaseUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItem_PurchaseUnitPrice_KeyPress);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(3, 85);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(130, 16);
            this.label.TabIndex = 11;
            this.label.Text = "Purchase Unit Price";
            // 
            // txtItem_Id
            // 
            this.txtItem_Id.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtItem_Id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItem_Id.DefaultText = "";
            this.txtItem_Id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtItem_Id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtItem_Id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItem_Id.DisabledState.Parent = this.txtItem_Id;
            this.txtItem_Id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItem_Id.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtItem_Id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtItem_Id.FocusedState.Parent = this.txtItem_Id;
            this.txtItem_Id.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtItem_Id.ForeColor = System.Drawing.Color.Transparent;
            this.txtItem_Id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtItem_Id.HoverState.Parent = this.txtItem_Id;
            this.txtItem_Id.Location = new System.Drawing.Point(6, 30);
            this.txtItem_Id.Margin = new System.Windows.Forms.Padding(4);
            this.txtItem_Id.Name = "txtItem_Id";
            this.txtItem_Id.PasswordChar = '\0';
            this.txtItem_Id.PlaceholderText = "";
            this.txtItem_Id.SelectedText = "";
            this.txtItem_Id.ShadowDecoration.Parent = this.txtItem_Id;
            this.txtItem_Id.Size = new System.Drawing.Size(194, 23);
            this.txtItem_Id.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtItem_Id.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Item ID";
            // 
            // Item_view
            // 
            this.Item_view.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.Item_view.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.Item_view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Item_view.AutoGenerateColumns = false;
            this.Item_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.Item_view.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Item_view.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Item_view.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Item_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.Item_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Item_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iTEMIDDataGridViewTextBoxColumn,
            this.sUPPIDDataGridViewTextBoxColumn,
            this.iTEMNameDataGridViewTextBoxColumn,
            this.iTEMPurchaseUnitPriceDataGridViewTextBoxColumn,
            this.iTEMRetailUnitPriceDataGridViewTextBoxColumn,
            this.iTEMQtyDataGridViewTextBoxColumn,
            this.iTEMBatchIDDataGridViewTextBoxColumn,
            this.iTEMBatchDateDataGridViewTextBoxColumn});
            this.Item_view.DataSource = this.iTEMBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Item_view.DefaultCellStyle = dataGridViewCellStyle9;
            this.Item_view.EnableHeadersVisualStyles = false;
            this.Item_view.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Item_view.Location = new System.Drawing.Point(12, 290);
            this.Item_view.Name = "Item_view";
            this.Item_view.Size = new System.Drawing.Size(648, 246);
            this.Item_view.TabIndex = 27;
            this.Item_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Item_view_CellContentClick);
            // 
            // iTEMIDDataGridViewTextBoxColumn
            // 
            this.iTEMIDDataGridViewTextBoxColumn.DataPropertyName = "ITEM_ID";
            this.iTEMIDDataGridViewTextBoxColumn.HeaderText = "ITEM_ID";
            this.iTEMIDDataGridViewTextBoxColumn.Name = "iTEMIDDataGridViewTextBoxColumn";
            this.iTEMIDDataGridViewTextBoxColumn.Width = 81;
            // 
            // sUPPIDDataGridViewTextBoxColumn
            // 
            this.sUPPIDDataGridViewTextBoxColumn.DataPropertyName = "SUPP_ID";
            this.sUPPIDDataGridViewTextBoxColumn.HeaderText = "SUPP_ID";
            this.sUPPIDDataGridViewTextBoxColumn.Name = "sUPPIDDataGridViewTextBoxColumn";
            this.sUPPIDDataGridViewTextBoxColumn.Width = 81;
            // 
            // iTEMNameDataGridViewTextBoxColumn
            // 
            this.iTEMNameDataGridViewTextBoxColumn.DataPropertyName = "ITEM_Name";
            this.iTEMNameDataGridViewTextBoxColumn.HeaderText = "ITEM_Name";
            this.iTEMNameDataGridViewTextBoxColumn.Name = "iTEMNameDataGridViewTextBoxColumn";
            this.iTEMNameDataGridViewTextBoxColumn.Width = 107;
            // 
            // iTEMPurchaseUnitPriceDataGridViewTextBoxColumn
            // 
            this.iTEMPurchaseUnitPriceDataGridViewTextBoxColumn.DataPropertyName = "ITEM_PurchaseUnitPrice";
            this.iTEMPurchaseUnitPriceDataGridViewTextBoxColumn.HeaderText = "ITEM_PurchaseUnitPrice";
            this.iTEMPurchaseUnitPriceDataGridViewTextBoxColumn.Name = "iTEMPurchaseUnitPriceDataGridViewTextBoxColumn";
            this.iTEMPurchaseUnitPriceDataGridViewTextBoxColumn.Width = 183;
            // 
            // iTEMRetailUnitPriceDataGridViewTextBoxColumn
            // 
            this.iTEMRetailUnitPriceDataGridViewTextBoxColumn.DataPropertyName = "ITEM_RetailUnitPrice";
            this.iTEMRetailUnitPriceDataGridViewTextBoxColumn.HeaderText = "ITEM_RetailUnitPrice";
            this.iTEMRetailUnitPriceDataGridViewTextBoxColumn.Name = "iTEMRetailUnitPriceDataGridViewTextBoxColumn";
            this.iTEMRetailUnitPriceDataGridViewTextBoxColumn.Width = 161;
            // 
            // iTEMQtyDataGridViewTextBoxColumn
            // 
            this.iTEMQtyDataGridViewTextBoxColumn.DataPropertyName = "ITEM_Qty";
            this.iTEMQtyDataGridViewTextBoxColumn.HeaderText = "ITEM_Qty";
            this.iTEMQtyDataGridViewTextBoxColumn.Name = "iTEMQtyDataGridViewTextBoxColumn";
            this.iTEMQtyDataGridViewTextBoxColumn.Width = 91;
            // 
            // iTEMBatchIDDataGridViewTextBoxColumn
            // 
            this.iTEMBatchIDDataGridViewTextBoxColumn.DataPropertyName = "ITEM_BatchID";
            this.iTEMBatchIDDataGridViewTextBoxColumn.HeaderText = "ITEM_BatchID";
            this.iTEMBatchIDDataGridViewTextBoxColumn.Name = "iTEMBatchIDDataGridViewTextBoxColumn";
            this.iTEMBatchIDDataGridViewTextBoxColumn.Width = 118;
            // 
            // iTEMBatchDateDataGridViewTextBoxColumn
            // 
            this.iTEMBatchDateDataGridViewTextBoxColumn.DataPropertyName = "ITEM_BatchDate";
            this.iTEMBatchDateDataGridViewTextBoxColumn.HeaderText = "ITEM_BatchDate";
            this.iTEMBatchDateDataGridViewTextBoxColumn.Name = "iTEMBatchDateDataGridViewTextBoxColumn";
            this.iTEMBatchDateDataGridViewTextBoxColumn.Width = 135;
            // 
            // iTEMBindingSource
            // 
            this.iTEMBindingSource.DataMember = "ITEM";
            this.iTEMBindingSource.DataSource = this.dBProjectDataSet2;
            // 
            // dBProjectDataSet2
            // 
            this.dBProjectDataSet2.DataSetName = "DBProjectDataSet2";
            this.dBProjectDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iTEMTableAdapter
            // 
            this.iTEMTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.label4.Location = new System.Drawing.Point(500, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "label4";
            // 
            // Additem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(672, 548);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Item_view);
            this.Controls.Add(this.btnDelete_Item);
            this.Controls.Add(this.btnUpdate_Item);
            this.Controls.Add(this.btnSearch_Item);
            this.Controls.Add(this.btnAdd_Item);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Additem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Additem";
            this.Load += new System.EventHandler(this.Additem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Item_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProjectDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnDelete_Item;
        private Guna.UI2.WinForms.Guna2Button btnUpdate_Item;
        private Guna.UI2.WinForms.Guna2Button btnSearch_Item;
        private Guna.UI2.WinForms.Guna2Button btnAdd_Item;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtItem_BatchDate;
        private Guna.UI2.WinForms.Guna2TextBox txtItem_Name;
        private Guna.UI2.WinForms.Guna2TextBox txtSupp_ID;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtBatch_ID;
        private Guna.UI2.WinForms.Guna2TextBox txtItem_Retail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtEm_Pw;
        private System.Windows.Forms.Label txtEm_Login;
        private Guna.UI2.WinForms.Guna2TextBox txtItem_PurchaseUnitPrice;
        private System.Windows.Forms.Label label;
        private Guna.UI2.WinForms.Guna2TextBox txtItem_Id;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtItem_Quantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Item_view;
        private DBProjectDataSet2 dBProjectDataSet2;
        private System.Windows.Forms.BindingSource iTEMBindingSource;
        private DBProjectDataSet2TableAdapters.ITEMTableAdapter iTEMTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUPPIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMPurchaseUnitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMRetailUnitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMBatchIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMBatchDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
    }
}