namespace Shop_Management__System
{
    partial class supplier
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
            this.Supplier_view = new System.Windows.Forms.DataGridView();
            this.sUPPIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUPPNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUPPAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUPPPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUPPEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUPPLIERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBProjectDataSet3 = new Shop_Management__System.DBProjectDataSet3();
            this.btnDelete_Supp = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate_Supp = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch_Supp = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd_Supp = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSupp_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSupp_Email = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSupp_Phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEm_Pw = new System.Windows.Forms.Label();
            this.txtEm_Login = new System.Windows.Forms.Label();
            this.txtSupp_Address = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEm_Addr = new System.Windows.Forms.Label();
            this.txtSupp_Id = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sUPPLIERTableAdapter = new Shop_Management__System.DBProjectDataSet3TableAdapters.SUPPLIERTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Supplier_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProjectDataSet3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Supplier_view
            // 
            this.Supplier_view.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Supplier_view.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Supplier_view.AutoGenerateColumns = false;
            this.Supplier_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Supplier_view.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Supplier_view.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Supplier_view.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Supplier_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Supplier_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Supplier_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sUPPIDDataGridViewTextBoxColumn,
            this.sUPPNameDataGridViewTextBoxColumn,
            this.sUPPAddressDataGridViewTextBoxColumn,
            this.sUPPPhoneDataGridViewTextBoxColumn,
            this.sUPPEmailDataGridViewTextBoxColumn});
            this.Supplier_view.DataSource = this.sUPPLIERBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Supplier_view.DefaultCellStyle = dataGridViewCellStyle3;
            this.Supplier_view.EnableHeadersVisualStyles = false;
            this.Supplier_view.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Supplier_view.Location = new System.Drawing.Point(12, 290);
            this.Supplier_view.Name = "Supplier_view";
            this.Supplier_view.Size = new System.Drawing.Size(648, 246);
            this.Supplier_view.TabIndex = 27;
            this.Supplier_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Supplier_view_CellContentClick);
            // 
            // sUPPIDDataGridViewTextBoxColumn
            // 
            this.sUPPIDDataGridViewTextBoxColumn.DataPropertyName = "SUPP_ID";
            this.sUPPIDDataGridViewTextBoxColumn.HeaderText = "SUPP_ID";
            this.sUPPIDDataGridViewTextBoxColumn.Name = "sUPPIDDataGridViewTextBoxColumn";
            // 
            // sUPPNameDataGridViewTextBoxColumn
            // 
            this.sUPPNameDataGridViewTextBoxColumn.DataPropertyName = "SUPP_Name";
            this.sUPPNameDataGridViewTextBoxColumn.HeaderText = "SUPP_Name";
            this.sUPPNameDataGridViewTextBoxColumn.Name = "sUPPNameDataGridViewTextBoxColumn";
            // 
            // sUPPAddressDataGridViewTextBoxColumn
            // 
            this.sUPPAddressDataGridViewTextBoxColumn.DataPropertyName = "SUPP_Address";
            this.sUPPAddressDataGridViewTextBoxColumn.HeaderText = "SUPP_Address";
            this.sUPPAddressDataGridViewTextBoxColumn.Name = "sUPPAddressDataGridViewTextBoxColumn";
            // 
            // sUPPPhoneDataGridViewTextBoxColumn
            // 
            this.sUPPPhoneDataGridViewTextBoxColumn.DataPropertyName = "SUPP_Phone";
            this.sUPPPhoneDataGridViewTextBoxColumn.HeaderText = "SUPP_Phone";
            this.sUPPPhoneDataGridViewTextBoxColumn.Name = "sUPPPhoneDataGridViewTextBoxColumn";
            // 
            // sUPPEmailDataGridViewTextBoxColumn
            // 
            this.sUPPEmailDataGridViewTextBoxColumn.DataPropertyName = "SUPP_Email";
            this.sUPPEmailDataGridViewTextBoxColumn.HeaderText = "SUPP_Email";
            this.sUPPEmailDataGridViewTextBoxColumn.Name = "sUPPEmailDataGridViewTextBoxColumn";
            // 
            // sUPPLIERBindingSource
            // 
            this.sUPPLIERBindingSource.DataMember = "SUPPLIER";
            this.sUPPLIERBindingSource.DataSource = this.dBProjectDataSet3;
            // 
            // dBProjectDataSet3
            // 
            this.dBProjectDataSet3.DataSetName = "DBProjectDataSet3";
            this.dBProjectDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDelete_Supp
            // 
            this.btnDelete_Supp.AutoRoundedCorners = true;
            this.btnDelete_Supp.BorderColor = System.Drawing.Color.Transparent;
            this.btnDelete_Supp.BorderRadius = 20;
            this.btnDelete_Supp.CheckedState.Parent = this.btnDelete_Supp;
            this.btnDelete_Supp.CustomImages.Parent = this.btnDelete_Supp;
            this.btnDelete_Supp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete_Supp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete_Supp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete_Supp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete_Supp.DisabledState.Parent = this.btnDelete_Supp;
            this.btnDelete_Supp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btnDelete_Supp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete_Supp.ForeColor = System.Drawing.Color.White;
            this.btnDelete_Supp.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnDelete_Supp.HoverState.Parent = this.btnDelete_Supp;
            this.btnDelete_Supp.Location = new System.Drawing.Point(500, 225);
            this.btnDelete_Supp.Name = "btnDelete_Supp";
            this.btnDelete_Supp.ShadowDecoration.Parent = this.btnDelete_Supp;
            this.btnDelete_Supp.Size = new System.Drawing.Size(160, 42);
            this.btnDelete_Supp.TabIndex = 26;
            this.btnDelete_Supp.Text = "Delete";
            this.btnDelete_Supp.Click += new System.EventHandler(this.btnDelete_Supp_Click);
            // 
            // btnUpdate_Supp
            // 
            this.btnUpdate_Supp.AutoRoundedCorners = true;
            this.btnUpdate_Supp.BorderColor = System.Drawing.Color.Transparent;
            this.btnUpdate_Supp.BorderRadius = 20;
            this.btnUpdate_Supp.CheckedState.Parent = this.btnUpdate_Supp;
            this.btnUpdate_Supp.CustomImages.Parent = this.btnUpdate_Supp;
            this.btnUpdate_Supp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate_Supp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate_Supp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate_Supp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate_Supp.DisabledState.Parent = this.btnUpdate_Supp;
            this.btnUpdate_Supp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btnUpdate_Supp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnUpdate_Supp.ForeColor = System.Drawing.Color.White;
            this.btnUpdate_Supp.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnUpdate_Supp.HoverState.Parent = this.btnUpdate_Supp;
            this.btnUpdate_Supp.Location = new System.Drawing.Point(500, 154);
            this.btnUpdate_Supp.Name = "btnUpdate_Supp";
            this.btnUpdate_Supp.ShadowDecoration.Parent = this.btnUpdate_Supp;
            this.btnUpdate_Supp.Size = new System.Drawing.Size(160, 42);
            this.btnUpdate_Supp.TabIndex = 25;
            this.btnUpdate_Supp.Text = "Update";
            this.btnUpdate_Supp.Click += new System.EventHandler(this.btnUpdate_Supp_Click);
            // 
            // btnSearch_Supp
            // 
            this.btnSearch_Supp.AutoRoundedCorners = true;
            this.btnSearch_Supp.BorderColor = System.Drawing.Color.Transparent;
            this.btnSearch_Supp.BorderRadius = 20;
            this.btnSearch_Supp.CheckedState.Parent = this.btnSearch_Supp;
            this.btnSearch_Supp.CustomImages.Parent = this.btnSearch_Supp;
            this.btnSearch_Supp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch_Supp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch_Supp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch_Supp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch_Supp.DisabledState.Parent = this.btnSearch_Supp;
            this.btnSearch_Supp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btnSearch_Supp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSearch_Supp.ForeColor = System.Drawing.Color.White;
            this.btnSearch_Supp.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSearch_Supp.HoverState.Parent = this.btnSearch_Supp;
            this.btnSearch_Supp.Location = new System.Drawing.Point(500, 88);
            this.btnSearch_Supp.Name = "btnSearch_Supp";
            this.btnSearch_Supp.ShadowDecoration.Parent = this.btnSearch_Supp;
            this.btnSearch_Supp.Size = new System.Drawing.Size(160, 42);
            this.btnSearch_Supp.TabIndex = 24;
            this.btnSearch_Supp.Text = "Search";
            this.btnSearch_Supp.Click += new System.EventHandler(this.btnSearch_Supp_Click);
            // 
            // btnAdd_Supp
            // 
            this.btnAdd_Supp.AutoRoundedCorners = true;
            this.btnAdd_Supp.BorderColor = System.Drawing.Color.Transparent;
            this.btnAdd_Supp.BorderRadius = 20;
            this.btnAdd_Supp.CheckedState.Parent = this.btnAdd_Supp;
            this.btnAdd_Supp.CustomImages.Parent = this.btnAdd_Supp;
            this.btnAdd_Supp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd_Supp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd_Supp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd_Supp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd_Supp.DisabledState.Parent = this.btnAdd_Supp;
            this.btnAdd_Supp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btnAdd_Supp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAdd_Supp.ForeColor = System.Drawing.Color.White;
            this.btnAdd_Supp.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAdd_Supp.HoverState.Parent = this.btnAdd_Supp;
            this.btnAdd_Supp.Location = new System.Drawing.Point(500, 22);
            this.btnAdd_Supp.Name = "btnAdd_Supp";
            this.btnAdd_Supp.ShadowDecoration.Parent = this.btnAdd_Supp;
            this.btnAdd_Supp.Size = new System.Drawing.Size(160, 42);
            this.btnAdd_Supp.TabIndex = 23;
            this.btnAdd_Supp.Text = "Add";
            this.btnAdd_Supp.Click += new System.EventHandler(this.btnAdd_Supp_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.txtSupp_Name);
            this.panel1.Controls.Add(this.txtSupp_Email);
            this.panel1.Controls.Add(this.txtSupp_Phone);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtEm_Pw);
            this.panel1.Controls.Add(this.txtEm_Login);
            this.panel1.Controls.Add(this.txtSupp_Address);
            this.panel1.Controls.Add(this.txtEm_Addr);
            this.panel1.Controls.Add(this.txtSupp_Id);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 263);
            this.panel1.TabIndex = 22;
            // 
            // txtSupp_Name
            // 
            this.txtSupp_Name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtSupp_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupp_Name.DefaultText = "";
            this.txtSupp_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSupp_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSupp_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupp_Name.DisabledState.Parent = this.txtSupp_Name;
            this.txtSupp_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupp_Name.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtSupp_Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSupp_Name.FocusedState.Parent = this.txtSupp_Name;
            this.txtSupp_Name.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSupp_Name.ForeColor = System.Drawing.Color.Transparent;
            this.txtSupp_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSupp_Name.HoverState.Parent = this.txtSupp_Name;
            this.txtSupp_Name.Location = new System.Drawing.Point(244, 30);
            this.txtSupp_Name.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupp_Name.Name = "txtSupp_Name";
            this.txtSupp_Name.PasswordChar = '\0';
            this.txtSupp_Name.PlaceholderText = "";
            this.txtSupp_Name.SelectedText = "";
            this.txtSupp_Name.ShadowDecoration.Parent = this.txtSupp_Name;
            this.txtSupp_Name.Size = new System.Drawing.Size(211, 23);
            this.txtSupp_Name.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSupp_Name.TabIndex = 12;
            // 
            // txtSupp_Email
            // 
            this.txtSupp_Email.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtSupp_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupp_Email.DefaultText = "";
            this.txtSupp_Email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSupp_Email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSupp_Email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupp_Email.DisabledState.Parent = this.txtSupp_Email;
            this.txtSupp_Email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupp_Email.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtSupp_Email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSupp_Email.FocusedState.Parent = this.txtSupp_Email;
            this.txtSupp_Email.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSupp_Email.ForeColor = System.Drawing.Color.Transparent;
            this.txtSupp_Email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSupp_Email.HoverState.Parent = this.txtSupp_Email;
            this.txtSupp_Email.Location = new System.Drawing.Point(244, 128);
            this.txtSupp_Email.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupp_Email.Name = "txtSupp_Email";
            this.txtSupp_Email.PasswordChar = '\0';
            this.txtSupp_Email.PlaceholderText = "";
            this.txtSupp_Email.SelectedText = "";
            this.txtSupp_Email.ShadowDecoration.Parent = this.txtSupp_Email;
            this.txtSupp_Email.Size = new System.Drawing.Size(211, 23);
            this.txtSupp_Email.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSupp_Email.TabIndex = 12;
            // 
            // txtSupp_Phone
            // 
            this.txtSupp_Phone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtSupp_Phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupp_Phone.DefaultText = "";
            this.txtSupp_Phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSupp_Phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSupp_Phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupp_Phone.DisabledState.Parent = this.txtSupp_Phone;
            this.txtSupp_Phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupp_Phone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtSupp_Phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSupp_Phone.FocusedState.Parent = this.txtSupp_Phone;
            this.txtSupp_Phone.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSupp_Phone.ForeColor = System.Drawing.Color.Transparent;
            this.txtSupp_Phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSupp_Phone.HoverState.Parent = this.txtSupp_Phone;
            this.txtSupp_Phone.Location = new System.Drawing.Point(4, 213);
            this.txtSupp_Phone.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupp_Phone.Name = "txtSupp_Phone";
            this.txtSupp_Phone.PasswordChar = '\0';
            this.txtSupp_Phone.PlaceholderText = "";
            this.txtSupp_Phone.SelectedText = "";
            this.txtSupp_Phone.ShadowDecoration.Parent = this.txtSupp_Phone;
            this.txtSupp_Phone.Size = new System.Drawing.Size(194, 23);
            this.txtSupp_Phone.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSupp_Phone.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(241, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Supplier Name";
            // 
            // txtEm_Pw
            // 
            this.txtEm_Pw.AutoSize = true;
            this.txtEm_Pw.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEm_Pw.ForeColor = System.Drawing.Color.White;
            this.txtEm_Pw.Location = new System.Drawing.Point(241, 108);
            this.txtEm_Pw.Name = "txtEm_Pw";
            this.txtEm_Pw.Size = new System.Drawing.Size(101, 16);
            this.txtEm_Pw.TabIndex = 11;
            this.txtEm_Pw.Text = "Supplier Email";
            // 
            // txtEm_Login
            // 
            this.txtEm_Login.AutoSize = true;
            this.txtEm_Login.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEm_Login.ForeColor = System.Drawing.Color.White;
            this.txtEm_Login.Location = new System.Drawing.Point(1, 193);
            this.txtEm_Login.Name = "txtEm_Login";
            this.txtEm_Login.Size = new System.Drawing.Size(104, 16);
            this.txtEm_Login.TabIndex = 11;
            this.txtEm_Login.Text = "Supplier Phone";
            // 
            // txtSupp_Address
            // 
            this.txtSupp_Address.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtSupp_Address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupp_Address.DefaultText = "";
            this.txtSupp_Address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSupp_Address.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSupp_Address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupp_Address.DisabledState.Parent = this.txtSupp_Address;
            this.txtSupp_Address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupp_Address.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtSupp_Address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSupp_Address.FocusedState.Parent = this.txtSupp_Address;
            this.txtSupp_Address.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSupp_Address.ForeColor = System.Drawing.Color.Transparent;
            this.txtSupp_Address.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSupp_Address.HoverState.Parent = this.txtSupp_Address;
            this.txtSupp_Address.Location = new System.Drawing.Point(6, 128);
            this.txtSupp_Address.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupp_Address.Name = "txtSupp_Address";
            this.txtSupp_Address.PasswordChar = '\0';
            this.txtSupp_Address.PlaceholderText = "";
            this.txtSupp_Address.SelectedText = "";
            this.txtSupp_Address.ShadowDecoration.Parent = this.txtSupp_Address;
            this.txtSupp_Address.Size = new System.Drawing.Size(194, 23);
            this.txtSupp_Address.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSupp_Address.TabIndex = 12;
            // 
            // txtEm_Addr
            // 
            this.txtEm_Addr.AutoSize = true;
            this.txtEm_Addr.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEm_Addr.ForeColor = System.Drawing.Color.White;
            this.txtEm_Addr.Location = new System.Drawing.Point(3, 108);
            this.txtEm_Addr.Name = "txtEm_Addr";
            this.txtEm_Addr.Size = new System.Drawing.Size(118, 16);
            this.txtEm_Addr.TabIndex = 11;
            this.txtEm_Addr.Text = "Supplier Address";
            // 
            // txtSupp_Id
            // 
            this.txtSupp_Id.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtSupp_Id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupp_Id.DefaultText = "";
            this.txtSupp_Id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSupp_Id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSupp_Id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupp_Id.DisabledState.Parent = this.txtSupp_Id;
            this.txtSupp_Id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupp_Id.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtSupp_Id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSupp_Id.FocusedState.Parent = this.txtSupp_Id;
            this.txtSupp_Id.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSupp_Id.ForeColor = System.Drawing.Color.Transparent;
            this.txtSupp_Id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSupp_Id.HoverState.Parent = this.txtSupp_Id;
            this.txtSupp_Id.Location = new System.Drawing.Point(6, 30);
            this.txtSupp_Id.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupp_Id.Name = "txtSupp_Id";
            this.txtSupp_Id.PasswordChar = '\0';
            this.txtSupp_Id.PlaceholderText = "";
            this.txtSupp_Id.SelectedText = "";
            this.txtSupp_Id.ShadowDecoration.Parent = this.txtSupp_Id;
            this.txtSupp_Id.Size = new System.Drawing.Size(194, 23);
            this.txtSupp_Id.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSupp_Id.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Supplier ID";
            // 
            // sUPPLIERTableAdapter
            // 
            this.sUPPLIERTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.label1.Location = new System.Drawing.Point(524, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "label1";
            // 
            // supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(672, 548);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Supplier_view);
            this.Controls.Add(this.btnDelete_Supp);
            this.Controls.Add(this.btnUpdate_Supp);
            this.Controls.Add(this.btnSearch_Supp);
            this.Controls.Add(this.btnAdd_Supp);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "supplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "supplier";
            this.Load += new System.EventHandler(this.supplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Supplier_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProjectDataSet3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Supplier_view;
        private Guna.UI2.WinForms.Guna2Button btnDelete_Supp;
        private Guna.UI2.WinForms.Guna2Button btnUpdate_Supp;
        private Guna.UI2.WinForms.Guna2Button btnSearch_Supp;
        private Guna.UI2.WinForms.Guna2Button btnAdd_Supp;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtSupp_Name;
        private Guna.UI2.WinForms.Guna2TextBox txtSupp_Email;
        private Guna.UI2.WinForms.Guna2TextBox txtSupp_Phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtEm_Pw;
        private System.Windows.Forms.Label txtEm_Login;
        private Guna.UI2.WinForms.Guna2TextBox txtSupp_Address;
        private System.Windows.Forms.Label txtEm_Addr;
        private Guna.UI2.WinForms.Guna2TextBox txtSupp_Id;
        private System.Windows.Forms.Label label2;
        private DBProjectDataSet3 dBProjectDataSet3;
        private System.Windows.Forms.BindingSource sUPPLIERBindingSource;
        private DBProjectDataSet3TableAdapters.SUPPLIERTableAdapter sUPPLIERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUPPIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUPPNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUPPAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUPPPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUPPEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}