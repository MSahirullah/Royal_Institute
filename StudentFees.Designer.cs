
namespace Royal_Institute
{
    partial class StudentFees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentFees));
            this.FileMenu = new System.Windows.Forms.MenuStrip();
            this.fileFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.closeFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.teachersFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherPaymentsFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sSubjectCmb = new System.Windows.Forms.ComboBox();
            this.sMonthCmb = new System.Windows.Forms.DateTimePicker();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.idlabel = new System.Windows.Forms.Label();
            this.sGradeTxt = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGetID = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sSearchTxt = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.sFeeTxt = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.sLNametxt = new System.Windows.Forms.TextBox();
            this.sFNameTxt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.sIdTxt = new System.Windows.Forms.TextBox();
            this.StudentGrid = new System.Windows.Forms.DataGridView();
            this.PaymentsGrid = new System.Windows.Forms.DataGridView();
            this.FileMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // FileMenu
            // 
            this.FileMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.FileMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.FileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileFileMenu,
            this.menuFileMenu});
            this.FileMenu.Location = new System.Drawing.Point(0, 0);
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(1539, 28);
            this.FileMenu.TabIndex = 105;
            this.FileMenu.Text = "menuStrip1";
            // 
            // fileFileMenu
            // 
            this.fileFileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuFileMenu,
            this.logoutFileMenu,
            this.closeFileMenu});
            this.fileFileMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileFileMenu.ForeColor = System.Drawing.Color.White;
            this.fileFileMenu.Name = "fileFileMenu";
            this.fileFileMenu.Size = new System.Drawing.Size(46, 24);
            this.fileFileMenu.Text = "File";
            // 
            // mainMenuFileMenu
            // 
            this.mainMenuFileMenu.Name = "mainMenuFileMenu";
            this.mainMenuFileMenu.Size = new System.Drawing.Size(166, 26);
            this.mainMenuFileMenu.Text = "Main Menu";
            this.mainMenuFileMenu.Click += new System.EventHandler(this.mainMenuFileMenu_Click);
            // 
            // logoutFileMenu
            // 
            this.logoutFileMenu.Name = "logoutFileMenu";
            this.logoutFileMenu.Size = new System.Drawing.Size(166, 26);
            this.logoutFileMenu.Text = "Logout";
            this.logoutFileMenu.Click += new System.EventHandler(this.logoutFileMenu_Click);
            // 
            // closeFileMenu
            // 
            this.closeFileMenu.Name = "closeFileMenu";
            this.closeFileMenu.Size = new System.Drawing.Size(166, 26);
            this.closeFileMenu.Text = "Close";
            this.closeFileMenu.Click += new System.EventHandler(this.closeFileMenu_Click);
            // 
            // menuFileMenu
            // 
            this.menuFileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsFileMenu,
            this.teachersFileMenu,
            this.teacherPaymentsFileMenu});
            this.menuFileMenu.ForeColor = System.Drawing.Color.White;
            this.menuFileMenu.Name = "menuFileMenu";
            this.menuFileMenu.Size = new System.Drawing.Size(60, 24);
            this.menuFileMenu.Text = "Menu";
            // 
            // studentsFileMenu
            // 
            this.studentsFileMenu.Name = "studentsFileMenu";
            this.studentsFileMenu.Size = new System.Drawing.Size(211, 26);
            this.studentsFileMenu.Text = "Students";
            this.studentsFileMenu.Click += new System.EventHandler(this.studentsFileMenu_Click);
            // 
            // teachersFileMenu
            // 
            this.teachersFileMenu.Name = "teachersFileMenu";
            this.teachersFileMenu.Size = new System.Drawing.Size(211, 26);
            this.teachersFileMenu.Text = "Teachers";
            this.teachersFileMenu.Click += new System.EventHandler(this.teachersFileMenu_Click);
            // 
            // teacherPaymentsFileMenu
            // 
            this.teacherPaymentsFileMenu.Name = "teacherPaymentsFileMenu";
            this.teacherPaymentsFileMenu.Size = new System.Drawing.Size(211, 26);
            this.teacherPaymentsFileMenu.Text = "Teacher Payments";
            this.teacherPaymentsFileMenu.Click += new System.EventHandler(this.teacherPaymentsFileMenu_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.sSubjectCmb);
            this.panel1.Controls.Add(this.sMonthCmb);
            this.panel1.Controls.Add(this.label30);
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.label31);
            this.panel1.Controls.Add(this.idlabel);
            this.panel1.Controls.Add(this.sGradeTxt);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnGetID);
            this.panel1.Controls.Add(this.btnClearAll);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnPay);
            this.panel1.Controls.Add(this.sFeeTxt);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.sLNametxt);
            this.panel1.Controls.Add(this.sFNameTxt);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.sIdTxt);
            this.panel1.Location = new System.Drawing.Point(12, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1515, 264);
            this.panel1.TabIndex = 106;
            // 
            // sSubjectCmb
            // 
            this.sSubjectCmb.AutoCompleteCustomSource.AddRange(new string[] {
            "Agri Science",
            "Arts",
            "Biology",
            "Business and Accounts",
            "Business Studies & Accounts",
            "Chemistry",
            "Civics and Governance",
            "Combine Maths",
            "Dance",
            "Design Technology",
            "Drama",
            "Economics",
            "English",
            "French",
            "Geography",
            "Health and Physical Education",
            "History",
            "Home Science",
            "ICT",
            "Logic",
            "maths",
            "Music",
            "None",
            "Physics",
            "Political Science",
            "Religion",
            "Science",
            "Sinhala",
            "Tamil"});
            this.sSubjectCmb.BackColor = System.Drawing.SystemColors.Menu;
            this.sSubjectCmb.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sSubjectCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sSubjectCmb.ItemHeight = 20;
            this.sSubjectCmb.Location = new System.Drawing.Point(720, 30);
            this.sSubjectCmb.MaxLength = 2;
            this.sSubjectCmb.Name = "sSubjectCmb";
            this.sSubjectCmb.Size = new System.Drawing.Size(264, 28);
            this.sSubjectCmb.TabIndex = 3;
            this.sSubjectCmb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sSubjectCmb_KeyPress);
            // 
            // sMonthCmb
            // 
            this.sMonthCmb.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sMonthCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sMonthCmb.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.sMonthCmb.Location = new System.Drawing.Point(719, 89);
            this.sMonthCmb.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.sMonthCmb.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.sMonthCmb.Name = "sMonthCmb";
            this.sMonthCmb.Size = new System.Drawing.Size(264, 27);
            this.sMonthCmb.TabIndex = 4;
            this.sMonthCmb.Value = new System.DateTime(2021, 8, 10, 0, 0, 0, 0);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.White;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(496, 90);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(162, 20);
            this.label30.TabIndex = 107;
            this.label30.Text = "Payment MM / YYYY";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.White;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(953, 150);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(31, 20);
            this.label29.TabIndex = 105;
            this.label29.Text = ".00";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.White;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(695, 90);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(14, 20);
            this.label31.TabIndex = 108;
            this.label31.Text = ":";
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.BackColor = System.Drawing.Color.Transparent;
            this.idlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlabel.ForeColor = System.Drawing.Color.Transparent;
            this.idlabel.Location = new System.Drawing.Point(532, 122);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(138, 20);
            this.idlabel.TabIndex = 104;
            this.idlabel.Text = "Fee (per studnet)";
            this.idlabel.Visible = false;
            // 
            // sGradeTxt
            // 
            this.sGradeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sGradeTxt.Location = new System.Drawing.Point(183, 201);
            this.sGradeTxt.Margin = new System.Windows.Forms.Padding(5);
            this.sGradeTxt.MaxLength = 50;
            this.sGradeTxt.Multiline = true;
            this.sGradeTxt.Name = "sGradeTxt";
            this.sGradeTxt.ReadOnly = true;
            this.sGradeTxt.Size = new System.Drawing.Size(262, 34);
            this.sGradeTxt.TabIndex = 100;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.White;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(696, 149);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(14, 20);
            this.label21.TabIndex = 22;
            this.label21.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(661, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Rs.";
            // 
            // btnGetID
            // 
            this.btnGetID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetID.Location = new System.Drawing.Point(362, 27);
            this.btnGetID.Name = "btnGetID";
            this.btnGetID.Size = new System.Drawing.Size(83, 37);
            this.btnGetID.TabIndex = 2;
            this.btnGetID.Text = "Search";
            this.btnGetID.UseVisualStyleBackColor = true;
            this.btnGetID.Click += new System.EventHandler(this.btnGetID_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(1385, 201);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(113, 38);
            this.btnClearAll.TabIndex = 10;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.sSearchTxt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1056, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Payments";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(345, 59);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 36);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Index :";
            // 
            // sSearchTxt
            // 
            this.sSearchTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sSearchTxt.Location = new System.Drawing.Point(156, 60);
            this.sSearchTxt.Margin = new System.Windows.Forms.Padding(5);
            this.sSearchTxt.MaxLength = 5;
            this.sSearchTxt.Multiline = true;
            this.sSearchTxt.Name = "sSearchTxt";
            this.sSearchTxt.Size = new System.Drawing.Size(180, 33);
            this.sSearchTxt.TabIndex = 11;
            this.sSearchTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sSearchTxt_KeyPress);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1218, 201);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 38);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(1051, 201);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 38);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(886, 201);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(125, 38);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(720, 201);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(125, 38);
            this.btnPay.TabIndex = 6;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // sFeeTxt
            // 
            this.sFeeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sFeeTxt.Location = new System.Drawing.Point(719, 143);
            this.sFeeTxt.Margin = new System.Windows.Forms.Padding(5);
            this.sFeeTxt.MaxLength = 12;
            this.sFeeTxt.Multiline = true;
            this.sFeeTxt.Name = "sFeeTxt";
            this.sFeeTxt.Size = new System.Drawing.Size(231, 34);
            this.sFeeTxt.TabIndex = 5;
            this.sFeeTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sFeeTxt_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(497, 149);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 20);
            this.label18.TabIndex = 19;
            this.label18.Text = "Fee";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.White;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(497, 32);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 20);
            this.label22.TabIndex = 23;
            this.label22.Text = "Subject";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.White;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(696, 32);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(14, 20);
            this.label24.TabIndex = 25;
            this.label24.Text = ":";
            // 
            // sLNametxt
            // 
            this.sLNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sLNametxt.Location = new System.Drawing.Point(183, 144);
            this.sLNametxt.Margin = new System.Windows.Forms.Padding(5);
            this.sLNametxt.MaxLength = 50;
            this.sLNametxt.Multiline = true;
            this.sLNametxt.Name = "sLNametxt";
            this.sLNametxt.ReadOnly = true;
            this.sLNametxt.Size = new System.Drawing.Size(262, 34);
            this.sLNametxt.TabIndex = 100;
            // 
            // sFNameTxt
            // 
            this.sFNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sFNameTxt.Location = new System.Drawing.Point(183, 86);
            this.sFNameTxt.Margin = new System.Windows.Forms.Padding(5);
            this.sFNameTxt.MaxLength = 50;
            this.sFNameTxt.Multiline = true;
            this.sFNameTxt.Name = "sFNameTxt";
            this.sFNameTxt.ReadOnly = true;
            this.sFNameTxt.Size = new System.Drawing.Size(262, 34);
            this.sFNameTxt.TabIndex = 100;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(16, 207);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 20);
            this.label16.TabIndex = 12;
            this.label16.Text = "Grade";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(16, 144);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 20);
            this.label15.TabIndex = 12;
            this.label15.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(161, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = ":";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 20);
            this.label14.TabIndex = 12;
            this.label14.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(161, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Student Index";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(161, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = ":";
            // 
            // sIdTxt
            // 
            this.sIdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sIdTxt.Location = new System.Drawing.Point(187, 28);
            this.sIdTxt.Margin = new System.Windows.Forms.Padding(5);
            this.sIdTxt.MaxLength = 5;
            this.sIdTxt.Multiline = true;
            this.sIdTxt.Name = "sIdTxt";
            this.sIdTxt.Size = new System.Drawing.Size(167, 34);
            this.sIdTxt.TabIndex = 1;
            this.sIdTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sIdTxt_KeyPress);
            // 
            // StudentGrid
            // 
            this.StudentGrid.AllowUserToAddRows = false;
            this.StudentGrid.AllowUserToDeleteRows = false;
            this.StudentGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentGrid.Location = new System.Drawing.Point(12, 319);
            this.StudentGrid.Name = "StudentGrid";
            this.StudentGrid.ReadOnly = true;
            this.StudentGrid.RowHeadersWidth = 51;
            this.StudentGrid.RowTemplate.Height = 24;
            this.StudentGrid.Size = new System.Drawing.Size(544, 505);
            this.StudentGrid.TabIndex = 107;
            this.StudentGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentGrid_CellClick);
            // 
            // PaymentsGrid
            // 
            this.PaymentsGrid.AllowUserToAddRows = false;
            this.PaymentsGrid.AllowUserToDeleteRows = false;
            this.PaymentsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PaymentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PaymentsGrid.Location = new System.Drawing.Point(566, 319);
            this.PaymentsGrid.Name = "PaymentsGrid";
            this.PaymentsGrid.ReadOnly = true;
            this.PaymentsGrid.RowHeadersWidth = 51;
            this.PaymentsGrid.RowTemplate.Height = 24;
            this.PaymentsGrid.Size = new System.Drawing.Size(961, 505);
            this.PaymentsGrid.TabIndex = 108;
            this.PaymentsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PaymentsGrid_CellClick);
            // 
            // StudentFees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1539, 836);
            this.Controls.Add(this.StudentGrid);
            this.Controls.Add(this.PaymentsGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FileMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentFees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Fees | Royal Educational Institute";
            this.Load += new System.EventHandler(this.StudentFees_Load);
            this.FileMenu.ResumeLayout(false);
            this.FileMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip FileMenu;
        private System.Windows.Forms.ToolStripMenuItem fileFileMenu;
        private System.Windows.Forms.ToolStripMenuItem mainMenuFileMenu;
        private System.Windows.Forms.ToolStripMenuItem logoutFileMenu;
        private System.Windows.Forms.ToolStripMenuItem closeFileMenu;
        private System.Windows.Forms.ToolStripMenuItem menuFileMenu;
        private System.Windows.Forms.ToolStripMenuItem studentsFileMenu;
        private System.Windows.Forms.ToolStripMenuItem teachersFileMenu;
        private System.Windows.Forms.ToolStripMenuItem teacherPaymentsFileMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox sSubjectCmb;
        private System.Windows.Forms.DateTimePicker sMonthCmb;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.TextBox sGradeTxt;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGetID;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sSearchTxt;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox sFeeTxt;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox sLNametxt;
        private System.Windows.Forms.TextBox sFNameTxt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox sIdTxt;
        private System.Windows.Forms.DataGridView StudentGrid;
        private System.Windows.Forms.DataGridView PaymentsGrid;
    }
}