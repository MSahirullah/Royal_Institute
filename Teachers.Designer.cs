
namespace Royal_Institute
{
    partial class Teachers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teachers));
            this.FileMenu = new System.Windows.Forms.MenuStrip();
            this.fileFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.closeFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsFeeFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherPaymentsFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.tSubCombo = new System.Windows.Forms.ComboBox();
            this.tClassesCombo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tSearchTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tEmailTxt = new System.Windows.Forms.TextBox();
            this.tAddressTxt = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tNumberTxt = new System.Windows.Forms.TextBox();
            this.tLNametxt = new System.Windows.Forms.TextBox();
            this.tFNameTxt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tIdTxt = new System.Windows.Forms.TextBox();
            this.TeacherDataGrid = new System.Windows.Forms.DataGridView();
            this.FileMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherDataGrid)).BeginInit();
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
            this.FileMenu.TabIndex = 102;
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
            this.studentsFeeFileMenu,
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
            // studentsFeeFileMenu
            // 
            this.studentsFeeFileMenu.Name = "studentsFeeFileMenu";
            this.studentsFeeFileMenu.Size = new System.Drawing.Size(211, 26);
            this.studentsFeeFileMenu.Text = "Student Fees";
            this.studentsFeeFileMenu.Click += new System.EventHandler(this.studentsFeeFileMenu_Click);
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
            this.panel1.Controls.Add(this.btnClearAll);
            this.panel1.Controls.Add(this.tSubCombo);
            this.panel1.Controls.Add(this.tClassesCombo);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.tEmailTxt);
            this.panel1.Controls.Add(this.tAddressTxt);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.tNumberTxt);
            this.panel1.Controls.Add(this.tLNametxt);
            this.panel1.Controls.Add(this.tFNameTxt);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.tIdTxt);
            this.panel1.Location = new System.Drawing.Point(12, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1515, 256);
            this.panel1.TabIndex = 103;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(1341, 196);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(155, 35);
            this.btnClearAll.TabIndex = 14;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // tSubCombo
            // 
            this.tSubCombo.AutoCompleteCustomSource.AddRange(new string[] {
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
            this.tSubCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tSubCombo.BackColor = System.Drawing.SystemColors.Menu;
            this.tSubCombo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tSubCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSubCombo.ItemHeight = 20;
            this.tSubCombo.Items.AddRange(new object[] {
            "Arts",
            "Agri Science",
            "B. S. & Accounts",
            "Biology",
            "Chemistry",
            "Civics and Governance",
            "Commerce",
            "Combine Maths",
            "Dance",
            "Drama",
            "Design Technology",
            "Economics",
            "English",
            "ET",
            "French",
            "Geography",
            "H. P. Education",
            "Home Science",
            "History",
            "ICT",
            "Logic",
            "Maths",
            "Music",
            "Religion",
            "Physics",
            "Political Science",
            "Science",
            "SFT",
            "Sinhala",
            "Tamil"});
            this.tSubCombo.Location = new System.Drawing.Point(653, 84);
            this.tSubCombo.Name = "tSubCombo";
            this.tSubCombo.Size = new System.Drawing.Size(247, 28);
            this.tSubCombo.TabIndex = 6;
            this.tSubCombo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.teachSub_KeyPress);
            // 
            // tClassesCombo
            // 
            this.tClassesCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tClassesCombo.BackColor = System.Drawing.SystemColors.Menu;
            this.tClassesCombo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tClassesCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tClassesCombo.ItemHeight = 20;
            this.tClassesCombo.Items.AddRange(new object[] {
            "6-9",
            "10-11",
            "12-13"});
            this.tClassesCombo.Location = new System.Drawing.Point(653, 32);
            this.tClassesCombo.Name = "tClassesCombo";
            this.tClassesCombo.Size = new System.Drawing.Size(247, 28);
            this.tClassesCombo.TabIndex = 5;
            this.tClassesCombo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.teachClass_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.tSearchTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1130, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Teachers";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(247, 94);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(102, 35);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tSearchTxt
            // 
            this.tSearchTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSearchTxt.Location = new System.Drawing.Point(133, 37);
            this.tSearchTxt.Margin = new System.Windows.Forms.Padding(5);
            this.tSearchTxt.MaxLength = 5;
            this.tSearchTxt.Multiline = true;
            this.tSearchTxt.Name = "tSearchTxt";
            this.tSearchTxt.Size = new System.Drawing.Size(216, 34);
            this.tSearchTxt.TabIndex = 12;
            this.tSearchTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tSearchTxt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher ID : ";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(940, 176);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 43);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(940, 102);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(134, 43);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(940, 29);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 43);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tEmailTxt
            // 
            this.tEmailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tEmailTxt.Location = new System.Drawing.Point(652, 184);
            this.tEmailTxt.Margin = new System.Windows.Forms.Padding(5);
            this.tEmailTxt.MaxLength = 50;
            this.tEmailTxt.Multiline = true;
            this.tEmailTxt.Name = "tEmailTxt";
            this.tEmailTxt.Size = new System.Drawing.Size(248, 34);
            this.tEmailTxt.TabIndex = 8;
            this.tEmailTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkEnter_KeyPress);
            // 
            // tAddressTxt
            // 
            this.tAddressTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tAddressTxt.Location = new System.Drawing.Point(652, 132);
            this.tAddressTxt.Margin = new System.Windows.Forms.Padding(5);
            this.tAddressTxt.MaxLength = 50;
            this.tAddressTxt.Multiline = true;
            this.tAddressTxt.Name = "tAddressTxt";
            this.tAddressTxt.Size = new System.Drawing.Size(248, 34);
            this.tAddressTxt.TabIndex = 7;
            this.tAddressTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkEnter_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(469, 190);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(118, 20);
            this.label17.TabIndex = 18;
            this.label17.Text = "Email Address";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(469, 138);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 20);
            this.label18.TabIndex = 19;
            this.label18.Text = "Address";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(630, 190);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(14, 20);
            this.label19.TabIndex = 20;
            this.label19.Text = ":";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(469, 87);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(138, 20);
            this.label20.TabIndex = 21;
            this.label20.Text = "Teaching Subject";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.White;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(630, 138);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(14, 20);
            this.label21.TabIndex = 22;
            this.label21.Text = ":";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.White;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(469, 34);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(137, 20);
            this.label22.TabIndex = 23;
            this.label22.Text = "Teaching Grades";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.White;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(630, 87);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(14, 20);
            this.label23.TabIndex = 24;
            this.label23.Text = ":";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.White;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(630, 34);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(14, 20);
            this.label24.TabIndex = 25;
            this.label24.Text = ":";
            // 
            // tNumberTxt
            // 
            this.tNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNumberTxt.Location = new System.Drawing.Point(183, 183);
            this.tNumberTxt.Margin = new System.Windows.Forms.Padding(5);
            this.tNumberTxt.MaxLength = 10;
            this.tNumberTxt.Multiline = true;
            this.tNumberTxt.Name = "tNumberTxt";
            this.tNumberTxt.Size = new System.Drawing.Size(248, 34);
            this.tNumberTxt.TabIndex = 4;
            this.tNumberTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cnumber_KeyPress);
            // 
            // tLNametxt
            // 
            this.tLNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tLNametxt.Location = new System.Drawing.Point(183, 133);
            this.tLNametxt.Margin = new System.Windows.Forms.Padding(5);
            this.tLNametxt.MaxLength = 50;
            this.tLNametxt.Multiline = true;
            this.tLNametxt.Name = "tLNametxt";
            this.tLNametxt.Size = new System.Drawing.Size(248, 34);
            this.tLNametxt.TabIndex = 3;
            this.tLNametxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lname_KeyPress);
            // 
            // tFNameTxt
            // 
            this.tFNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tFNameTxt.Location = new System.Drawing.Point(183, 82);
            this.tFNameTxt.Margin = new System.Windows.Forms.Padding(5);
            this.tFNameTxt.MaxLength = 50;
            this.tFNameTxt.Multiline = true;
            this.tFNameTxt.Name = "tFNameTxt";
            this.tFNameTxt.Size = new System.Drawing.Size(248, 34);
            this.tFNameTxt.TabIndex = 2;
            this.tFNameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fname_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(16, 190);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(131, 20);
            this.label16.TabIndex = 12;
            this.label16.Text = "Contact Number";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(16, 137);
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
            this.label4.Location = new System.Drawing.Point(161, 189);
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
            this.label14.Location = new System.Drawing.Point(16, 87);
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
            this.label3.Location = new System.Drawing.Point(161, 138);
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
            this.label9.Location = new System.Drawing.Point(16, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Teacher ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 87);
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
            this.label10.Location = new System.Drawing.Point(161, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = ":";
            // 
            // tIdTxt
            // 
            this.tIdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tIdTxt.Location = new System.Drawing.Point(183, 30);
            this.tIdTxt.Margin = new System.Windows.Forms.Padding(5);
            this.tIdTxt.MaxLength = 5;
            this.tIdTxt.Multiline = true;
            this.tIdTxt.Name = "tIdTxt";
            this.tIdTxt.Size = new System.Drawing.Size(248, 34);
            this.tIdTxt.TabIndex = 1;
            this.tIdTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_KeyPress);
            // 
            // TeacherDataGrid
            // 
            this.TeacherDataGrid.AllowUserToAddRows = false;
            this.TeacherDataGrid.AllowUserToDeleteRows = false;
            this.TeacherDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TeacherDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeacherDataGrid.Location = new System.Drawing.Point(12, 313);
            this.TeacherDataGrid.Name = "TeacherDataGrid";
            this.TeacherDataGrid.ReadOnly = true;
            this.TeacherDataGrid.RowHeadersWidth = 51;
            this.TeacherDataGrid.RowTemplate.Height = 24;
            this.TeacherDataGrid.Size = new System.Drawing.Size(1515, 510);
            this.TeacherDataGrid.TabIndex = 104;
            this.TeacherDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TeacherDataGrid_CellClick);
            // 
            // Teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1539, 836);
            this.Controls.Add(this.TeacherDataGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FileMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Teachers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teachers | Royal Educational Institute";
            this.Load += new System.EventHandler(this.Teachers_Load);
            this.FileMenu.ResumeLayout(false);
            this.FileMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherDataGrid)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem studentsFeeFileMenu;
        private System.Windows.Forms.ToolStripMenuItem teacherPaymentsFileMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.ComboBox tSubCombo;
        private System.Windows.Forms.ComboBox tClassesCombo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tSearchTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tEmailTxt;
        private System.Windows.Forms.TextBox tAddressTxt;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox tNumberTxt;
        private System.Windows.Forms.TextBox tLNametxt;
        private System.Windows.Forms.TextBox tFNameTxt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tIdTxt;
        private System.Windows.Forms.DataGridView TeacherDataGrid;
    }
}