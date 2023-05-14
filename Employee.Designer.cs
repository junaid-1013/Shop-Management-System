namespace Shop_Management__System
{
    partial class Employee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSalary = new Guna.UI2.WinForms.Guna2TextBox();
            this.Em_birth = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtEm_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.em_Pw = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.em_login = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEm_Pw = new System.Windows.Forms.Label();
            this.txtEm_Login = new System.Windows.Forms.Label();
            this.txtEm_Add = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEm_Addr = new System.Windows.Forms.Label();
            this.txtEm_Id = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdd_em = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch_em = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate_em = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete_em = new Guna.UI2.WinForms.Guna2Button();
            this.Employee_view = new System.Windows.Forms.DataGridView();
            this.eMPIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPBirthDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPLoginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBProjectDataSet = new Shop_Management__System.DBProjectDataSet();
            this.eMPLOYEETableAdapter = new Shop_Management__System.DBProjectDataSetTableAdapters.EMPLOYEETableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Employee_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProjectDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Employee ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.txtSalary);
            this.panel1.Controls.Add(this.Em_birth);
            this.panel1.Controls.Add(this.txtEm_Name);
            this.panel1.Controls.Add(this.em_Pw);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.em_login);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtEm_Pw);
            this.panel1.Controls.Add(this.txtEm_Login);
            this.panel1.Controls.Add(this.txtEm_Add);
            this.panel1.Controls.Add(this.txtEm_Addr);
            this.panel1.Controls.Add(this.txtEm_Id);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 263);
            this.panel1.TabIndex = 15;
            // 
            // txtSalary
            // 
            this.txtSalary.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtSalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSalary.DefaultText = "";
            this.txtSalary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSalary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSalary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSalary.DisabledState.Parent = this.txtSalary;
            this.txtSalary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSalary.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtSalary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSalary.FocusedState.Parent = this.txtSalary;
            this.txtSalary.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSalary.ForeColor = System.Drawing.Color.Transparent;
            this.txtSalary.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSalary.HoverState.Parent = this.txtSalary;
            this.txtSalary.Location = new System.Drawing.Point(6, 232);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.PasswordChar = '\0';
            this.txtSalary.PlaceholderText = "";
            this.txtSalary.SelectedText = "";
            this.txtSalary.ShadowDecoration.Parent = this.txtSalary;
            this.txtSalary.Size = new System.Drawing.Size(194, 23);
            this.txtSalary.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSalary.TabIndex = 14;
            this.txtSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalary_KeyPress_1);
            // 
            // Em_birth
            // 
            this.Em_birth.Animated = true;
            this.Em_birth.AutoRoundedCorners = true;
            this.Em_birth.BackColor = System.Drawing.Color.Transparent;
            this.Em_birth.BorderColor = System.Drawing.Color.White;
            this.Em_birth.BorderRadius = 17;
            this.Em_birth.Checked = true;
            this.Em_birth.CheckedState.Parent = this.Em_birth;
            this.Em_birth.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Em_birth.CustomFormat = "yyyy-MM-dd";
            this.Em_birth.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Em_birth.Font = new System.Drawing.Font("Cambria Math", 9.75F, System.Drawing.FontStyle.Bold);
            this.Em_birth.ForeColor = System.Drawing.Color.White;
            this.Em_birth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Em_birth.HoverState.Parent = this.Em_birth;
            this.Em_birth.IndicateFocus = true;
            this.Em_birth.Location = new System.Drawing.Point(244, 105);
            this.Em_birth.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.Em_birth.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.Em_birth.Name = "Em_birth";
            this.Em_birth.ShadowDecoration.Parent = this.Em_birth;
            this.Em_birth.Size = new System.Drawing.Size(168, 36);
            this.Em_birth.TabIndex = 13;
            this.Em_birth.UseTransparentBackground = true;
            this.Em_birth.Value = new System.DateTime(2021, 12, 14, 0, 0, 0, 0);
            // 
            // txtEm_Name
            // 
            this.txtEm_Name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtEm_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEm_Name.DefaultText = "";
            this.txtEm_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEm_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEm_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEm_Name.DisabledState.Parent = this.txtEm_Name;
            this.txtEm_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEm_Name.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtEm_Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEm_Name.FocusedState.Parent = this.txtEm_Name;
            this.txtEm_Name.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEm_Name.ForeColor = System.Drawing.Color.Transparent;
            this.txtEm_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEm_Name.HoverState.Parent = this.txtEm_Name;
            this.txtEm_Name.Location = new System.Drawing.Point(244, 30);
            this.txtEm_Name.Margin = new System.Windows.Forms.Padding(4);
            this.txtEm_Name.Name = "txtEm_Name";
            this.txtEm_Name.PasswordChar = '\0';
            this.txtEm_Name.PlaceholderText = "";
            this.txtEm_Name.SelectedText = "";
            this.txtEm_Name.ShadowDecoration.Parent = this.txtEm_Name;
            this.txtEm_Name.Size = new System.Drawing.Size(211, 23);
            this.txtEm_Name.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtEm_Name.TabIndex = 12;
            // 
            // em_Pw
            // 
            this.em_Pw.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.em_Pw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.em_Pw.DefaultText = "";
            this.em_Pw.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.em_Pw.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.em_Pw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.em_Pw.DisabledState.Parent = this.em_Pw;
            this.em_Pw.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.em_Pw.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.em_Pw.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.em_Pw.FocusedState.Parent = this.em_Pw;
            this.em_Pw.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.em_Pw.ForeColor = System.Drawing.Color.Transparent;
            this.em_Pw.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.em_Pw.HoverState.Parent = this.em_Pw;
            this.em_Pw.Location = new System.Drawing.Point(244, 176);
            this.em_Pw.Margin = new System.Windows.Forms.Padding(4);
            this.em_Pw.Name = "em_Pw";
            this.em_Pw.PasswordChar = '\0';
            this.em_Pw.PlaceholderText = "";
            this.em_Pw.SelectedText = "";
            this.em_Pw.ShadowDecoration.Parent = this.em_Pw;
            this.em_Pw.Size = new System.Drawing.Size(211, 23);
            this.em_Pw.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.em_Pw.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(241, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Birth Day";
            // 
            // em_login
            // 
            this.em_login.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.em_login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.em_login.DefaultText = "";
            this.em_login.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.em_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.em_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.em_login.DisabledState.Parent = this.em_login;
            this.em_login.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.em_login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.em_login.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.em_login.FocusedState.Parent = this.em_login;
            this.em_login.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.em_login.ForeColor = System.Drawing.Color.Transparent;
            this.em_login.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.em_login.HoverState.Parent = this.em_login;
            this.em_login.Location = new System.Drawing.Point(6, 176);
            this.em_login.Margin = new System.Windows.Forms.Padding(4);
            this.em_login.Name = "em_login";
            this.em_login.PasswordChar = '\0';
            this.em_login.PlaceholderText = "";
            this.em_login.SelectedText = "";
            this.em_login.ShadowDecoration.Parent = this.em_login;
            this.em_login.Size = new System.Drawing.Size(194, 23);
            this.em_login.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.em_login.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(241, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Employee Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Salary";
            // 
            // txtEm_Pw
            // 
            this.txtEm_Pw.AutoSize = true;
            this.txtEm_Pw.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEm_Pw.ForeColor = System.Drawing.Color.White;
            this.txtEm_Pw.Location = new System.Drawing.Point(241, 156);
            this.txtEm_Pw.Name = "txtEm_Pw";
            this.txtEm_Pw.Size = new System.Drawing.Size(67, 16);
            this.txtEm_Pw.TabIndex = 11;
            this.txtEm_Pw.Text = "Password";
            // 
            // txtEm_Login
            // 
            this.txtEm_Login.AutoSize = true;
            this.txtEm_Login.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEm_Login.ForeColor = System.Drawing.Color.White;
            this.txtEm_Login.Location = new System.Drawing.Point(3, 156);
            this.txtEm_Login.Name = "txtEm_Login";
            this.txtEm_Login.Size = new System.Drawing.Size(42, 16);
            this.txtEm_Login.TabIndex = 11;
            this.txtEm_Login.Text = "Login";
            // 
            // txtEm_Add
            // 
            this.txtEm_Add.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtEm_Add.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEm_Add.DefaultText = "";
            this.txtEm_Add.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEm_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEm_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEm_Add.DisabledState.Parent = this.txtEm_Add;
            this.txtEm_Add.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEm_Add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtEm_Add.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEm_Add.FocusedState.Parent = this.txtEm_Add;
            this.txtEm_Add.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEm_Add.ForeColor = System.Drawing.Color.Transparent;
            this.txtEm_Add.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEm_Add.HoverState.Parent = this.txtEm_Add;
            this.txtEm_Add.Location = new System.Drawing.Point(6, 105);
            this.txtEm_Add.Margin = new System.Windows.Forms.Padding(4);
            this.txtEm_Add.Name = "txtEm_Add";
            this.txtEm_Add.PasswordChar = '\0';
            this.txtEm_Add.PlaceholderText = "";
            this.txtEm_Add.SelectedText = "";
            this.txtEm_Add.ShadowDecoration.Parent = this.txtEm_Add;
            this.txtEm_Add.Size = new System.Drawing.Size(194, 23);
            this.txtEm_Add.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtEm_Add.TabIndex = 12;
            // 
            // txtEm_Addr
            // 
            this.txtEm_Addr.AutoSize = true;
            this.txtEm_Addr.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEm_Addr.ForeColor = System.Drawing.Color.White;
            this.txtEm_Addr.Location = new System.Drawing.Point(3, 85);
            this.txtEm_Addr.Name = "txtEm_Addr";
            this.txtEm_Addr.Size = new System.Drawing.Size(33, 16);
            this.txtEm_Addr.TabIndex = 11;
            this.txtEm_Addr.Text = "City";
            // 
            // txtEm_Id
            // 
            this.txtEm_Id.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtEm_Id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEm_Id.DefaultText = "";
            this.txtEm_Id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEm_Id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEm_Id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEm_Id.DisabledState.Parent = this.txtEm_Id;
            this.txtEm_Id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEm_Id.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtEm_Id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEm_Id.FocusedState.Parent = this.txtEm_Id;
            this.txtEm_Id.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEm_Id.ForeColor = System.Drawing.Color.Transparent;
            this.txtEm_Id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEm_Id.HoverState.Parent = this.txtEm_Id;
            this.txtEm_Id.Location = new System.Drawing.Point(6, 30);
            this.txtEm_Id.Margin = new System.Windows.Forms.Padding(4);
            this.txtEm_Id.Name = "txtEm_Id";
            this.txtEm_Id.PasswordChar = '\0';
            this.txtEm_Id.PlaceholderText = "";
            this.txtEm_Id.SelectedText = "";
            this.txtEm_Id.ShadowDecoration.Parent = this.txtEm_Id;
            this.txtEm_Id.Size = new System.Drawing.Size(194, 23);
            this.txtEm_Id.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtEm_Id.TabIndex = 12;
            // 
            // btnAdd_em
            // 
            this.btnAdd_em.AutoRoundedCorners = true;
            this.btnAdd_em.BorderColor = System.Drawing.Color.Transparent;
            this.btnAdd_em.BorderRadius = 20;
            this.btnAdd_em.CheckedState.Parent = this.btnAdd_em;
            this.btnAdd_em.CustomImages.Parent = this.btnAdd_em;
            this.btnAdd_em.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd_em.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd_em.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd_em.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd_em.DisabledState.Parent = this.btnAdd_em;
            this.btnAdd_em.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btnAdd_em.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAdd_em.ForeColor = System.Drawing.Color.White;
            this.btnAdd_em.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAdd_em.HoverState.Parent = this.btnAdd_em;
            this.btnAdd_em.Location = new System.Drawing.Point(500, 22);
            this.btnAdd_em.Name = "btnAdd_em";
            this.btnAdd_em.ShadowDecoration.Parent = this.btnAdd_em;
            this.btnAdd_em.Size = new System.Drawing.Size(160, 42);
            this.btnAdd_em.TabIndex = 16;
            this.btnAdd_em.Text = "Add";
            this.btnAdd_em.Click += new System.EventHandler(this.btnAdd_em_Click);
            // 
            // btnSearch_em
            // 
            this.btnSearch_em.AutoRoundedCorners = true;
            this.btnSearch_em.BorderColor = System.Drawing.Color.Transparent;
            this.btnSearch_em.BorderRadius = 20;
            this.btnSearch_em.CheckedState.Parent = this.btnSearch_em;
            this.btnSearch_em.CustomImages.Parent = this.btnSearch_em;
            this.btnSearch_em.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch_em.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch_em.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch_em.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch_em.DisabledState.Parent = this.btnSearch_em;
            this.btnSearch_em.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btnSearch_em.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSearch_em.ForeColor = System.Drawing.Color.White;
            this.btnSearch_em.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSearch_em.HoverState.Parent = this.btnSearch_em;
            this.btnSearch_em.Location = new System.Drawing.Point(500, 88);
            this.btnSearch_em.Name = "btnSearch_em";
            this.btnSearch_em.ShadowDecoration.Parent = this.btnSearch_em;
            this.btnSearch_em.Size = new System.Drawing.Size(160, 42);
            this.btnSearch_em.TabIndex = 18;
            this.btnSearch_em.Text = "Search";
            this.btnSearch_em.Click += new System.EventHandler(this.btnSearch_em_Click);
            // 
            // btnUpdate_em
            // 
            this.btnUpdate_em.AutoRoundedCorners = true;
            this.btnUpdate_em.BorderColor = System.Drawing.Color.Transparent;
            this.btnUpdate_em.BorderRadius = 20;
            this.btnUpdate_em.CheckedState.Parent = this.btnUpdate_em;
            this.btnUpdate_em.CustomImages.Parent = this.btnUpdate_em;
            this.btnUpdate_em.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate_em.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate_em.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate_em.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate_em.DisabledState.Parent = this.btnUpdate_em;
            this.btnUpdate_em.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btnUpdate_em.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnUpdate_em.ForeColor = System.Drawing.Color.White;
            this.btnUpdate_em.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnUpdate_em.HoverState.Parent = this.btnUpdate_em;
            this.btnUpdate_em.Location = new System.Drawing.Point(500, 154);
            this.btnUpdate_em.Name = "btnUpdate_em";
            this.btnUpdate_em.ShadowDecoration.Parent = this.btnUpdate_em;
            this.btnUpdate_em.Size = new System.Drawing.Size(160, 42);
            this.btnUpdate_em.TabIndex = 19;
            this.btnUpdate_em.Text = "Update";
            this.btnUpdate_em.Click += new System.EventHandler(this.btnUpdate_em_Click);
            // 
            // btnDelete_em
            // 
            this.btnDelete_em.AutoRoundedCorners = true;
            this.btnDelete_em.BorderColor = System.Drawing.Color.Transparent;
            this.btnDelete_em.BorderRadius = 20;
            this.btnDelete_em.CheckedState.Parent = this.btnDelete_em;
            this.btnDelete_em.CustomImages.Parent = this.btnDelete_em;
            this.btnDelete_em.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete_em.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete_em.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete_em.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete_em.DisabledState.Parent = this.btnDelete_em;
            this.btnDelete_em.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btnDelete_em.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete_em.ForeColor = System.Drawing.Color.White;
            this.btnDelete_em.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnDelete_em.HoverState.Parent = this.btnDelete_em;
            this.btnDelete_em.Location = new System.Drawing.Point(500, 225);
            this.btnDelete_em.Name = "btnDelete_em";
            this.btnDelete_em.ShadowDecoration.Parent = this.btnDelete_em;
            this.btnDelete_em.Size = new System.Drawing.Size(160, 42);
            this.btnDelete_em.TabIndex = 20;
            this.btnDelete_em.Text = "Delete";
            this.btnDelete_em.Click += new System.EventHandler(this.btnDelete_em_Click);
            // 
            // Employee_view
            // 
            this.Employee_view.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.Employee_view.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Employee_view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Employee_view.AutoGenerateColumns = false;
            this.Employee_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.Employee_view.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Employee_view.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Employee_view.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Employee_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Employee_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Employee_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eMPIDDataGridViewTextBoxColumn,
            this.eMPNameDataGridViewTextBoxColumn,
            this.eMPBirthDayDataGridViewTextBoxColumn,
            this.eMPCityDataGridViewTextBoxColumn,
            this.eMPLoginDataGridViewTextBoxColumn,
            this.eMPPasswordDataGridViewTextBoxColumn,
            this.eMPSalaryDataGridViewTextBoxColumn});
            this.Employee_view.DataSource = this.eMPLOYEEBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Employee_view.DefaultCellStyle = dataGridViewCellStyle6;
            this.Employee_view.EnableHeadersVisualStyles = false;
            this.Employee_view.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Employee_view.Location = new System.Drawing.Point(12, 290);
            this.Employee_view.Name = "Employee_view";
            this.Employee_view.Size = new System.Drawing.Size(648, 246);
            this.Employee_view.TabIndex = 21;
            this.Employee_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Employee_view_CellContentClick);
            // 
            // eMPIDDataGridViewTextBoxColumn
            // 
            this.eMPIDDataGridViewTextBoxColumn.DataPropertyName = "EMP_ID";
            this.eMPIDDataGridViewTextBoxColumn.FillWeight = 115.3213F;
            this.eMPIDDataGridViewTextBoxColumn.HeaderText = "EMP_ID";
            this.eMPIDDataGridViewTextBoxColumn.Name = "eMPIDDataGridViewTextBoxColumn";
            this.eMPIDDataGridViewTextBoxColumn.Width = 78;
            // 
            // eMPNameDataGridViewTextBoxColumn
            // 
            this.eMPNameDataGridViewTextBoxColumn.DataPropertyName = "EMP_Name";
            this.eMPNameDataGridViewTextBoxColumn.FillWeight = 108.6985F;
            this.eMPNameDataGridViewTextBoxColumn.HeaderText = "EMP_Name";
            this.eMPNameDataGridViewTextBoxColumn.Name = "eMPNameDataGridViewTextBoxColumn";
            this.eMPNameDataGridViewTextBoxColumn.Width = 104;
            // 
            // eMPBirthDayDataGridViewTextBoxColumn
            // 
            this.eMPBirthDayDataGridViewTextBoxColumn.DataPropertyName = "EMP_BirthDay";
            this.eMPBirthDayDataGridViewTextBoxColumn.FillWeight = 103.0188F;
            this.eMPBirthDayDataGridViewTextBoxColumn.HeaderText = "EMP_BirthDay";
            this.eMPBirthDayDataGridViewTextBoxColumn.Name = "eMPBirthDayDataGridViewTextBoxColumn";
            this.eMPBirthDayDataGridViewTextBoxColumn.Width = 120;
            // 
            // eMPCityDataGridViewTextBoxColumn
            // 
            this.eMPCityDataGridViewTextBoxColumn.DataPropertyName = "EMP_City";
            this.eMPCityDataGridViewTextBoxColumn.FillWeight = 98.4324F;
            this.eMPCityDataGridViewTextBoxColumn.HeaderText = "EMP_City";
            this.eMPCityDataGridViewTextBoxColumn.Name = "eMPCityDataGridViewTextBoxColumn";
            this.eMPCityDataGridViewTextBoxColumn.Width = 91;
            // 
            // eMPLoginDataGridViewTextBoxColumn
            // 
            this.eMPLoginDataGridViewTextBoxColumn.DataPropertyName = "EMP_Login";
            this.eMPLoginDataGridViewTextBoxColumn.FillWeight = 94.59435F;
            this.eMPLoginDataGridViewTextBoxColumn.HeaderText = "EMP_Login";
            this.eMPLoginDataGridViewTextBoxColumn.Name = "eMPLoginDataGridViewTextBoxColumn";
            // 
            // eMPPasswordDataGridViewTextBoxColumn
            // 
            this.eMPPasswordDataGridViewTextBoxColumn.DataPropertyName = "EMP_Password";
            this.eMPPasswordDataGridViewTextBoxColumn.FillWeight = 91.38241F;
            this.eMPPasswordDataGridViewTextBoxColumn.HeaderText = "EMP_Password";
            this.eMPPasswordDataGridViewTextBoxColumn.Name = "eMPPasswordDataGridViewTextBoxColumn";
            this.eMPPasswordDataGridViewTextBoxColumn.Width = 125;
            // 
            // eMPSalaryDataGridViewTextBoxColumn
            // 
            this.eMPSalaryDataGridViewTextBoxColumn.DataPropertyName = "EMP_Salary";
            this.eMPSalaryDataGridViewTextBoxColumn.FillWeight = 88.55223F;
            this.eMPSalaryDataGridViewTextBoxColumn.HeaderText = "EMP_Salary";
            this.eMPSalaryDataGridViewTextBoxColumn.Name = "eMPSalaryDataGridViewTextBoxColumn";
            this.eMPSalaryDataGridViewTextBoxColumn.Width = 107;
            // 
            // eMPLOYEEBindingSource
            // 
            this.eMPLOYEEBindingSource.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource.DataSource = this.dBProjectDataSet;
            // 
            // dBProjectDataSet
            // 
            this.dBProjectDataSet.DataSetName = "DBProjectDataSet";
            this.dBProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eMPLOYEETableAdapter
            // 
            this.eMPLOYEETableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.label3.Location = new System.Drawing.Point(510, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "label3";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(672, 548);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Employee_view);
            this.Controls.Add(this.btnDelete_em);
            this.Controls.Add(this.btnUpdate_em);
            this.Controls.Add(this.btnSearch_em);
            this.Controls.Add(this.btnAdd_em);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Employee_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProjectDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtEm_Id;
        private Guna.UI2.WinForms.Guna2DateTimePicker Em_birth;
        private Guna.UI2.WinForms.Guna2TextBox txtEm_Name;
        private Guna.UI2.WinForms.Guna2TextBox em_Pw;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox em_login;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtEm_Pw;
        private System.Windows.Forms.Label txtEm_Login;
        private Guna.UI2.WinForms.Guna2TextBox txtEm_Add;
        private System.Windows.Forms.Label txtEm_Addr;
        private Guna.UI2.WinForms.Guna2Button btnAdd_em;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnSearch_em;
        private Guna.UI2.WinForms.Guna2Button btnUpdate_em;
        private Guna.UI2.WinForms.Guna2Button btnDelete_em;
        private System.Windows.Forms.DataGridView Employee_view;
        private DBProjectDataSet dBProjectDataSet;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource;
        private DBProjectDataSetTableAdapters.EMPLOYEETableAdapter eMPLOYEETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPBirthDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPLoginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtSalary;
    }
}