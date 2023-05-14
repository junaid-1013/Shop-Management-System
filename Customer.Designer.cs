namespace Shop_Management__System
{
    partial class Customer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dBProjectDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBProjectDataSet = new Shop_Management__System.DBProjectDataSet();
            this.btnDelete_Cust = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate_Cust = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch_Cust = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd_Cust = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCust_RegDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtCust_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCust_Contact = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEm_Login = new System.Windows.Forms.Label();
            this.txtCust_City = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEm_Addr = new System.Windows.Forms.Label();
            this.txtCust_Id = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Customer_view = new System.Windows.Forms.DataGridView();
            this.cUSTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTRegDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBProjectDataSet1 = new Shop_Management__System.DBProjectDataSet1();
            this.cUSTOMERTableAdapter = new Shop_Management__System.DBProjectDataSet1TableAdapters.CUSTOMERTableAdapter();
            this.txthidden = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBProjectDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProjectDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Customer_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProjectDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dBProjectDataSetBindingSource
            // 
            this.dBProjectDataSetBindingSource.DataSource = this.dBProjectDataSet;
            this.dBProjectDataSetBindingSource.Position = 0;
            // 
            // dBProjectDataSet
            // 
            this.dBProjectDataSet.DataSetName = "DBProjectDataSet";
            this.dBProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDelete_Cust
            // 
            this.btnDelete_Cust.AutoRoundedCorners = true;
            this.btnDelete_Cust.BorderColor = System.Drawing.Color.Transparent;
            this.btnDelete_Cust.BorderRadius = 20;
            this.btnDelete_Cust.CheckedState.Parent = this.btnDelete_Cust;
            this.btnDelete_Cust.CustomImages.Parent = this.btnDelete_Cust;
            this.btnDelete_Cust.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete_Cust.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete_Cust.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete_Cust.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete_Cust.DisabledState.Parent = this.btnDelete_Cust;
            this.btnDelete_Cust.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btnDelete_Cust.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete_Cust.ForeColor = System.Drawing.Color.White;
            this.btnDelete_Cust.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnDelete_Cust.HoverState.Parent = this.btnDelete_Cust;
            this.btnDelete_Cust.Location = new System.Drawing.Point(500, 225);
            this.btnDelete_Cust.Name = "btnDelete_Cust";
            this.btnDelete_Cust.ShadowDecoration.Parent = this.btnDelete_Cust;
            this.btnDelete_Cust.Size = new System.Drawing.Size(160, 42);
            this.btnDelete_Cust.TabIndex = 26;
            this.btnDelete_Cust.Text = "Delete";
            this.btnDelete_Cust.Click += new System.EventHandler(this.btnDelete_Cust_Click);
            // 
            // btnUpdate_Cust
            // 
            this.btnUpdate_Cust.AutoRoundedCorners = true;
            this.btnUpdate_Cust.BorderColor = System.Drawing.Color.Transparent;
            this.btnUpdate_Cust.BorderRadius = 20;
            this.btnUpdate_Cust.CheckedState.Parent = this.btnUpdate_Cust;
            this.btnUpdate_Cust.CustomImages.Parent = this.btnUpdate_Cust;
            this.btnUpdate_Cust.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate_Cust.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate_Cust.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate_Cust.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate_Cust.DisabledState.Parent = this.btnUpdate_Cust;
            this.btnUpdate_Cust.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btnUpdate_Cust.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnUpdate_Cust.ForeColor = System.Drawing.Color.White;
            this.btnUpdate_Cust.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnUpdate_Cust.HoverState.Parent = this.btnUpdate_Cust;
            this.btnUpdate_Cust.Location = new System.Drawing.Point(500, 154);
            this.btnUpdate_Cust.Name = "btnUpdate_Cust";
            this.btnUpdate_Cust.ShadowDecoration.Parent = this.btnUpdate_Cust;
            this.btnUpdate_Cust.Size = new System.Drawing.Size(160, 42);
            this.btnUpdate_Cust.TabIndex = 25;
            this.btnUpdate_Cust.Text = "Update";
            this.btnUpdate_Cust.Click += new System.EventHandler(this.btnUpdate_Cust_Click);
            // 
            // btnSearch_Cust
            // 
            this.btnSearch_Cust.AutoRoundedCorners = true;
            this.btnSearch_Cust.BorderColor = System.Drawing.Color.Transparent;
            this.btnSearch_Cust.BorderRadius = 20;
            this.btnSearch_Cust.CheckedState.Parent = this.btnSearch_Cust;
            this.btnSearch_Cust.CustomImages.Parent = this.btnSearch_Cust;
            this.btnSearch_Cust.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch_Cust.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch_Cust.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch_Cust.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch_Cust.DisabledState.Parent = this.btnSearch_Cust;
            this.btnSearch_Cust.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btnSearch_Cust.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSearch_Cust.ForeColor = System.Drawing.Color.White;
            this.btnSearch_Cust.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSearch_Cust.HoverState.Parent = this.btnSearch_Cust;
            this.btnSearch_Cust.Location = new System.Drawing.Point(500, 88);
            this.btnSearch_Cust.Name = "btnSearch_Cust";
            this.btnSearch_Cust.ShadowDecoration.Parent = this.btnSearch_Cust;
            this.btnSearch_Cust.Size = new System.Drawing.Size(160, 42);
            this.btnSearch_Cust.TabIndex = 24;
            this.btnSearch_Cust.Text = "Search";
            this.btnSearch_Cust.Click += new System.EventHandler(this.btnSearch_Cust_Click);
            // 
            // btnAdd_Cust
            // 
            this.btnAdd_Cust.AutoRoundedCorners = true;
            this.btnAdd_Cust.BorderColor = System.Drawing.Color.Transparent;
            this.btnAdd_Cust.BorderRadius = 20;
            this.btnAdd_Cust.CheckedState.Parent = this.btnAdd_Cust;
            this.btnAdd_Cust.CustomImages.Parent = this.btnAdd_Cust;
            this.btnAdd_Cust.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd_Cust.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd_Cust.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd_Cust.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd_Cust.DisabledState.Parent = this.btnAdd_Cust;
            this.btnAdd_Cust.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btnAdd_Cust.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAdd_Cust.ForeColor = System.Drawing.Color.White;
            this.btnAdd_Cust.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAdd_Cust.HoverState.Parent = this.btnAdd_Cust;
            this.btnAdd_Cust.Location = new System.Drawing.Point(500, 22);
            this.btnAdd_Cust.Name = "btnAdd_Cust";
            this.btnAdd_Cust.ShadowDecoration.Parent = this.btnAdd_Cust;
            this.btnAdd_Cust.Size = new System.Drawing.Size(160, 42);
            this.btnAdd_Cust.TabIndex = 23;
            this.btnAdd_Cust.Text = "Add";
            this.btnAdd_Cust.Click += new System.EventHandler(this.btnAdd_Cust_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.txtCust_RegDate);
            this.panel1.Controls.Add(this.txtCust_Name);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtCust_Contact);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtEm_Login);
            this.panel1.Controls.Add(this.txtCust_City);
            this.panel1.Controls.Add(this.txtEm_Addr);
            this.panel1.Controls.Add(this.txtCust_Id);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 263);
            this.panel1.TabIndex = 22;
            // 
            // txtCust_RegDate
            // 
            this.txtCust_RegDate.Animated = true;
            this.txtCust_RegDate.AutoRoundedCorners = true;
            this.txtCust_RegDate.BackColor = System.Drawing.Color.Transparent;
            this.txtCust_RegDate.BorderColor = System.Drawing.Color.White;
            this.txtCust_RegDate.BorderRadius = 17;
            this.txtCust_RegDate.Checked = true;
            this.txtCust_RegDate.CheckedState.Parent = this.txtCust_RegDate;
            this.txtCust_RegDate.CustomFormat = "yyyy-MM-dd";
            this.txtCust_RegDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtCust_RegDate.Font = new System.Drawing.Font("Cambria Math", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtCust_RegDate.ForeColor = System.Drawing.Color.White;
            this.txtCust_RegDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtCust_RegDate.HoverState.Parent = this.txtCust_RegDate;
            this.txtCust_RegDate.IndicateFocus = true;
            this.txtCust_RegDate.Location = new System.Drawing.Point(244, 125);
            this.txtCust_RegDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtCust_RegDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtCust_RegDate.Name = "txtCust_RegDate";
            this.txtCust_RegDate.ShadowDecoration.Parent = this.txtCust_RegDate;
            this.txtCust_RegDate.Size = new System.Drawing.Size(168, 36);
            this.txtCust_RegDate.TabIndex = 13;
            this.txtCust_RegDate.UseTransparentBackground = true;
            this.txtCust_RegDate.Value = new System.DateTime(2021, 12, 14, 0, 0, 0, 0);
            // 
            // txtCust_Name
            // 
            this.txtCust_Name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtCust_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCust_Name.DefaultText = "";
            this.txtCust_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCust_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCust_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCust_Name.DisabledState.Parent = this.txtCust_Name;
            this.txtCust_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCust_Name.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtCust_Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCust_Name.FocusedState.Parent = this.txtCust_Name;
            this.txtCust_Name.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCust_Name.ForeColor = System.Drawing.Color.Transparent;
            this.txtCust_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCust_Name.HoverState.Parent = this.txtCust_Name;
            this.txtCust_Name.Location = new System.Drawing.Point(244, 30);
            this.txtCust_Name.Margin = new System.Windows.Forms.Padding(4);
            this.txtCust_Name.Name = "txtCust_Name";
            this.txtCust_Name.PasswordChar = '\0';
            this.txtCust_Name.PlaceholderText = "";
            this.txtCust_Name.SelectedText = "";
            this.txtCust_Name.ShadowDecoration.Parent = this.txtCust_Name;
            this.txtCust_Name.Size = new System.Drawing.Size(211, 23);
            this.txtCust_Name.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtCust_Name.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(241, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Registration Date";
            // 
            // txtCust_Contact
            // 
            this.txtCust_Contact.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtCust_Contact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCust_Contact.DefaultText = "";
            this.txtCust_Contact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCust_Contact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCust_Contact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCust_Contact.DisabledState.Parent = this.txtCust_Contact;
            this.txtCust_Contact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCust_Contact.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtCust_Contact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCust_Contact.FocusedState.Parent = this.txtCust_Contact;
            this.txtCust_Contact.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCust_Contact.ForeColor = System.Drawing.Color.Transparent;
            this.txtCust_Contact.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCust_Contact.HoverState.Parent = this.txtCust_Contact;
            this.txtCust_Contact.Location = new System.Drawing.Point(6, 218);
            this.txtCust_Contact.Margin = new System.Windows.Forms.Padding(4);
            this.txtCust_Contact.Name = "txtCust_Contact";
            this.txtCust_Contact.PasswordChar = '\0';
            this.txtCust_Contact.PlaceholderText = "";
            this.txtCust_Contact.SelectedText = "";
            this.txtCust_Contact.ShadowDecoration.Parent = this.txtCust_Contact;
            this.txtCust_Contact.Size = new System.Drawing.Size(194, 23);
            this.txtCust_Contact.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtCust_Contact.TabIndex = 12;
            this.txtCust_Contact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCust_Contact_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(241, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Customer Name";
            // 
            // txtEm_Login
            // 
            this.txtEm_Login.AutoSize = true;
            this.txtEm_Login.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEm_Login.ForeColor = System.Drawing.Color.White;
            this.txtEm_Login.Location = new System.Drawing.Point(3, 198);
            this.txtEm_Login.Name = "txtEm_Login";
            this.txtEm_Login.Size = new System.Drawing.Size(102, 16);
            this.txtEm_Login.TabIndex = 11;
            this.txtEm_Login.Text = "Phone Number";
            // 
            // txtCust_City
            // 
            this.txtCust_City.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtCust_City.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCust_City.DefaultText = "";
            this.txtCust_City.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCust_City.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCust_City.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCust_City.DisabledState.Parent = this.txtCust_City;
            this.txtCust_City.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCust_City.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtCust_City.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCust_City.FocusedState.Parent = this.txtCust_City;
            this.txtCust_City.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCust_City.ForeColor = System.Drawing.Color.Transparent;
            this.txtCust_City.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCust_City.HoverState.Parent = this.txtCust_City;
            this.txtCust_City.Location = new System.Drawing.Point(6, 125);
            this.txtCust_City.Margin = new System.Windows.Forms.Padding(4);
            this.txtCust_City.Name = "txtCust_City";
            this.txtCust_City.PasswordChar = '\0';
            this.txtCust_City.PlaceholderText = "";
            this.txtCust_City.SelectedText = "";
            this.txtCust_City.ShadowDecoration.Parent = this.txtCust_City;
            this.txtCust_City.Size = new System.Drawing.Size(194, 23);
            this.txtCust_City.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtCust_City.TabIndex = 12;
            // 
            // txtEm_Addr
            // 
            this.txtEm_Addr.AutoSize = true;
            this.txtEm_Addr.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEm_Addr.ForeColor = System.Drawing.Color.White;
            this.txtEm_Addr.Location = new System.Drawing.Point(3, 105);
            this.txtEm_Addr.Name = "txtEm_Addr";
            this.txtEm_Addr.Size = new System.Drawing.Size(33, 16);
            this.txtEm_Addr.TabIndex = 11;
            this.txtEm_Addr.Text = "City";
            // 
            // txtCust_Id
            // 
            this.txtCust_Id.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtCust_Id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCust_Id.DefaultText = "";
            this.txtCust_Id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCust_Id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCust_Id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCust_Id.DisabledState.Parent = this.txtCust_Id;
            this.txtCust_Id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCust_Id.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtCust_Id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCust_Id.FocusedState.Parent = this.txtCust_Id;
            this.txtCust_Id.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCust_Id.ForeColor = System.Drawing.Color.Transparent;
            this.txtCust_Id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCust_Id.HoverState.Parent = this.txtCust_Id;
            this.txtCust_Id.Location = new System.Drawing.Point(6, 30);
            this.txtCust_Id.Margin = new System.Windows.Forms.Padding(4);
            this.txtCust_Id.Name = "txtCust_Id";
            this.txtCust_Id.PasswordChar = '\0';
            this.txtCust_Id.PlaceholderText = "";
            this.txtCust_Id.SelectedText = "";
            this.txtCust_Id.ShadowDecoration.Parent = this.txtCust_Id;
            this.txtCust_Id.Size = new System.Drawing.Size(194, 23);
            this.txtCust_Id.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtCust_Id.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Customer ID";
            // 
            // Customer_view
            // 
            this.Customer_view.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Customer_view.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Customer_view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Customer_view.AutoGenerateColumns = false;
            this.Customer_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Customer_view.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Customer_view.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Customer_view.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Customer_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Customer_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Customer_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cUSTIDDataGridViewTextBoxColumn,
            this.cUSTNameDataGridViewTextBoxColumn,
            this.cUSTRegDateDataGridViewTextBoxColumn,
            this.cUSTCityDataGridViewTextBoxColumn,
            this.cUSTContactDataGridViewTextBoxColumn});
            this.Customer_view.DataSource = this.cUSTOMERBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Customer_view.DefaultCellStyle = dataGridViewCellStyle3;
            this.Customer_view.EnableHeadersVisualStyles = false;
            this.Customer_view.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Customer_view.Location = new System.Drawing.Point(12, 290);
            this.Customer_view.Name = "Customer_view";
            this.Customer_view.Size = new System.Drawing.Size(648, 246);
            this.Customer_view.TabIndex = 27;
            this.Customer_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Customer_view_CellContentClick);
            // 
            // cUSTIDDataGridViewTextBoxColumn
            // 
            this.cUSTIDDataGridViewTextBoxColumn.DataPropertyName = "CUST_ID";
            this.cUSTIDDataGridViewTextBoxColumn.HeaderText = "CUST_ID";
            this.cUSTIDDataGridViewTextBoxColumn.Name = "cUSTIDDataGridViewTextBoxColumn";
            // 
            // cUSTNameDataGridViewTextBoxColumn
            // 
            this.cUSTNameDataGridViewTextBoxColumn.DataPropertyName = "CUST_Name";
            this.cUSTNameDataGridViewTextBoxColumn.HeaderText = "CUST_Name";
            this.cUSTNameDataGridViewTextBoxColumn.Name = "cUSTNameDataGridViewTextBoxColumn";
            // 
            // cUSTRegDateDataGridViewTextBoxColumn
            // 
            this.cUSTRegDateDataGridViewTextBoxColumn.DataPropertyName = "CUST_RegDate";
            this.cUSTRegDateDataGridViewTextBoxColumn.HeaderText = "CUST_RegDate";
            this.cUSTRegDateDataGridViewTextBoxColumn.Name = "cUSTRegDateDataGridViewTextBoxColumn";
            // 
            // cUSTCityDataGridViewTextBoxColumn
            // 
            this.cUSTCityDataGridViewTextBoxColumn.DataPropertyName = "CUST_City";
            this.cUSTCityDataGridViewTextBoxColumn.HeaderText = "CUST_City";
            this.cUSTCityDataGridViewTextBoxColumn.Name = "cUSTCityDataGridViewTextBoxColumn";
            // 
            // cUSTContactDataGridViewTextBoxColumn
            // 
            this.cUSTContactDataGridViewTextBoxColumn.DataPropertyName = "CUST_Contact";
            this.cUSTContactDataGridViewTextBoxColumn.HeaderText = "CUST_Contact";
            this.cUSTContactDataGridViewTextBoxColumn.Name = "cUSTContactDataGridViewTextBoxColumn";
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.dBProjectDataSet1;
            // 
            // dBProjectDataSet1
            // 
            this.dBProjectDataSet1.DataSetName = "DBProjectDataSet1";
            this.dBProjectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // txthidden
            // 
            this.txthidden.AutoSize = true;
            this.txthidden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txthidden.Location = new System.Drawing.Point(500, 3);
            this.txthidden.Name = "txthidden";
            this.txthidden.Size = new System.Drawing.Size(35, 13);
            this.txthidden.TabIndex = 28;
            this.txthidden.Text = "label1";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(672, 548);
            this.Controls.Add(this.txthidden);
            this.Controls.Add(this.Customer_view);
            this.Controls.Add(this.btnDelete_Cust);
            this.Controls.Add(this.btnUpdate_Cust);
            this.Controls.Add(this.btnSearch_Cust);
            this.Controls.Add(this.btnAdd_Cust);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBProjectDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProjectDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Customer_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProjectDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnDelete_Cust;
        private Guna.UI2.WinForms.Guna2Button btnUpdate_Cust;
        private Guna.UI2.WinForms.Guna2Button btnSearch_Cust;
        private Guna.UI2.WinForms.Guna2Button btnAdd_Cust;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtCust_RegDate;
        private Guna.UI2.WinForms.Guna2TextBox txtCust_Name;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtCust_Contact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtEm_Login;
        private Guna.UI2.WinForms.Guna2TextBox txtCust_City;
        private System.Windows.Forms.Label txtEm_Addr;
        private Guna.UI2.WinForms.Guna2TextBox txtCust_Id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource dBProjectDataSetBindingSource;
        private DBProjectDataSet dBProjectDataSet;
        private System.Windows.Forms.DataGridView Customer_view;
        private DBProjectDataSet1 dBProjectDataSet1;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private DBProjectDataSet1TableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTRegDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label txthidden;
    }
}