
namespace Royal_Institute
{
    partial class Students
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            this.FileMenu = new System.Windows.Forms.MenuStrip();
            this.fileFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.closeFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.teachersFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsFeeFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherPaymentsFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SSelectedSubTxt = new System.Windows.Forms.TextBox();
            this.SGenRadio2 = new System.Windows.Forms.RadioButton();
            this.SGenRadio = new System.Windows.Forms.RadioButton();
            this.btnSelectSub = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.sGradeCmb = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.search = new System.Windows.Forms.Button();
            this.sSearchTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.sEmailTxt = new System.Windows.Forms.TextBox();
            this.sContactTxt = new System.Windows.Forms.TextBox();
            this.sAddressTxt = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.sGNameTxt = new System.Windows.Forms.TextBox();
            this.sLNameTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sFNameTxt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.sIDTxt = new System.Windows.Forms.TextBox();
            this.StudentGrid = new System.Windows.Forms.DataGridView();
            this.subjectPanel = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.selectSub = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SsubjectsList = new System.Windows.Forms.ListBox();
            this.FileMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGrid)).BeginInit();
            this.subjectPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.FileMenu.TabIndex = 103;
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
            this.teachersFileMenu,
            this.studentsFeeFileMenu,
            this.teacherPaymentsFileMenu});
            this.menuFileMenu.ForeColor = System.Drawing.Color.White;
            this.menuFileMenu.Name = "menuFileMenu";
            this.menuFileMenu.Size = new System.Drawing.Size(60, 24);
            this.menuFileMenu.Text = "Menu";
            // 
            // teachersFileMenu
            // 
            this.teachersFileMenu.Name = "teachersFileMenu";
            this.teachersFileMenu.Size = new System.Drawing.Size(211, 26);
            this.teachersFileMenu.Text = "Teachers";
            this.teachersFileMenu.Click += new System.EventHandler(this.teachersFileMenu_Click);
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
            this.panel1.Controls.Add(this.SSelectedSubTxt);
            this.panel1.Controls.Add(this.SGenRadio2);
            this.panel1.Controls.Add(this.SGenRadio);
            this.panel1.Controls.Add(this.btnSelectSub);
            this.panel1.Controls.Add(this.btnClearAll);
            this.panel1.Controls.Add(this.sGradeCmb);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.sEmailTxt);
            this.panel1.Controls.Add(this.sContactTxt);
            this.panel1.Controls.Add(this.sAddressTxt);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.sGNameTxt);
            this.panel1.Controls.Add(this.sLNameTxt);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.sFNameTxt);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.sIDTxt);
            this.panel1.Location = new System.Drawing.Point(12, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1514, 294);
            this.panel1.TabIndex = 104;
            // 
            // SSelectedSubTxt
            // 
            this.SSelectedSubTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSelectedSubTxt.Location = new System.Drawing.Point(652, 78);
            this.SSelectedSubTxt.Margin = new System.Windows.Forms.Padding(5);
            this.SSelectedSubTxt.MaxLength = 50;
            this.SSelectedSubTxt.Multiline = true;
            this.SSelectedSubTxt.Name = "SSelectedSubTxt";
            this.SSelectedSubTxt.ReadOnly = true;
            this.SSelectedSubTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SSelectedSubTxt.Size = new System.Drawing.Size(165, 34);
            this.SSelectedSubTxt.TabIndex = 28;
            // 
            // SGenRadio2
            // 
            this.SGenRadio2.AutoSize = true;
            this.SGenRadio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SGenRadio2.Location = new System.Drawing.Point(285, 235);
            this.SGenRadio2.Name = "SGenRadio2";
            this.SGenRadio2.Size = new System.Drawing.Size(85, 24);
            this.SGenRadio2.TabIndex = 6;
            this.SGenRadio2.TabStop = true;
            this.SGenRadio2.Text = "Female";
            this.SGenRadio2.UseVisualStyleBackColor = true;
            // 
            // SGenRadio
            // 
            this.SGenRadio.AutoSize = true;
            this.SGenRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SGenRadio.Location = new System.Drawing.Point(186, 235);
            this.SGenRadio.Name = "SGenRadio";
            this.SGenRadio.Size = new System.Drawing.Size(66, 24);
            this.SGenRadio.TabIndex = 5;
            this.SGenRadio.TabStop = true;
            this.SGenRadio.Text = "Male";
            this.SGenRadio.UseVisualStyleBackColor = true;
            // 
            // btnSelectSub
            // 
            this.btnSelectSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectSub.Location = new System.Drawing.Point(820, 76);
            this.btnSelectSub.Name = "btnSelectSub";
            this.btnSelectSub.Size = new System.Drawing.Size(80, 37);
            this.btnSelectSub.TabIndex = 8;
            this.btnSelectSub.Text = "Select";
            this.btnSelectSub.UseVisualStyleBackColor = true;
            this.btnSelectSub.Click += new System.EventHandler(this.btnSelectSub_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(940, 230);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(134, 37);
            this.btnClearAll.TabIndex = 15;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // sGradeCmb
            // 
            this.sGradeCmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.sGradeCmb.BackColor = System.Drawing.SystemColors.Menu;
            this.sGradeCmb.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sGradeCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sGradeCmb.ItemHeight = 20;
            this.sGradeCmb.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12-Bio",
            "12-Maths",
            "12-Arts",
            "12-Commerce",
            "12-Technology",
            "13-Bio",
            "13-Maths",
            "13-Arts",
            "13-Commerce",
            "13-Technology"});
            this.sGradeCmb.Location = new System.Drawing.Point(653, 29);
            this.sGradeCmb.Name = "sGradeCmb";
            this.sGradeCmb.Size = new System.Drawing.Size(247, 28);
            this.sGradeCmb.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Controls.Add(this.sSearchTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1130, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 241);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Students ";
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(213, 137);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(132, 40);
            this.search.TabIndex = 17;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // sSearchTxt
            // 
            this.sSearchTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sSearchTxt.Location = new System.Drawing.Point(146, 66);
            this.sSearchTxt.Margin = new System.Windows.Forms.Padding(5);
            this.sSearchTxt.MaxLength = 5;
            this.sSearchTxt.Multiline = true;
            this.sSearchTxt.Name = "sSearchTxt";
            this.sSearchTxt.Size = new System.Drawing.Size(199, 34);
            this.sSearchTxt.TabIndex = 16;
            this.sSearchTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sSearchTxt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Index : ";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(940, 162);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 43);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(940, 94);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(134, 43);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(940, 26);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 43);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // sEmailTxt
            // 
            this.sEmailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sEmailTxt.Location = new System.Drawing.Point(652, 232);
            this.sEmailTxt.Margin = new System.Windows.Forms.Padding(5);
            this.sEmailTxt.MaxLength = 50;
            this.sEmailTxt.Multiline = true;
            this.sEmailTxt.Name = "sEmailTxt";
            this.sEmailTxt.Size = new System.Drawing.Size(248, 34);
            this.sEmailTxt.TabIndex = 11;
            this.sEmailTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkEnter_KeyPress);
            // 
            // sContactTxt
            // 
            this.sContactTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sContactTxt.Location = new System.Drawing.Point(652, 180);
            this.sContactTxt.Margin = new System.Windows.Forms.Padding(5);
            this.sContactTxt.MaxLength = 10;
            this.sContactTxt.Multiline = true;
            this.sContactTxt.Name = "sContactTxt";
            this.sContactTxt.Size = new System.Drawing.Size(248, 34);
            this.sContactTxt.TabIndex = 10;
            this.sContactTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sContactTxt_KeyPress);
            // 
            // sAddressTxt
            // 
            this.sAddressTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sAddressTxt.Location = new System.Drawing.Point(652, 129);
            this.sAddressTxt.Margin = new System.Windows.Forms.Padding(5);
            this.sAddressTxt.MaxLength = 50;
            this.sAddressTxt.Multiline = true;
            this.sAddressTxt.Name = "sAddressTxt";
            this.sAddressTxt.Size = new System.Drawing.Size(248, 34);
            this.sAddressTxt.TabIndex = 9;
            this.sAddressTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkEnter_KeyPress);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.White;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(469, 235);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(118, 20);
            this.label25.TabIndex = 18;
            this.label25.Text = "Email Address";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(469, 185);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 20);
            this.label13.TabIndex = 19;
            this.label13.Text = "Contact";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(469, 134);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 20);
            this.label18.TabIndex = 19;
            this.label18.Text = "Address";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(630, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = ":";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(469, 85);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(74, 20);
            this.label20.TabIndex = 21;
            this.label20.Text = "Subjects";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(630, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = ":";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.White;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(630, 136);
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
            this.label22.Location = new System.Drawing.Point(469, 32);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(55, 20);
            this.label22.TabIndex = 23;
            this.label22.Text = "Grade";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.White;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(630, 84);
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
            this.label24.Location = new System.Drawing.Point(630, 33);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(14, 20);
            this.label24.TabIndex = 25;
            this.label24.Text = ":";
            // 
            // sGNameTxt
            // 
            this.sGNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sGNameTxt.Location = new System.Drawing.Point(183, 181);
            this.sGNameTxt.Margin = new System.Windows.Forms.Padding(5);
            this.sGNameTxt.MaxLength = 50;
            this.sGNameTxt.Multiline = true;
            this.sGNameTxt.Name = "sGNameTxt";
            this.sGNameTxt.Size = new System.Drawing.Size(248, 34);
            this.sGNameTxt.TabIndex = 4;
            this.sGNameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sGNameTxt_KeyPress);
            // 
            // sLNameTxt
            // 
            this.sLNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sLNameTxt.Location = new System.Drawing.Point(183, 130);
            this.sLNameTxt.Margin = new System.Windows.Forms.Padding(5);
            this.sLNameTxt.MaxLength = 50;
            this.sLNameTxt.Multiline = true;
            this.sLNameTxt.Name = "sLNameTxt";
            this.sLNameTxt.Size = new System.Drawing.Size(248, 34);
            this.sLNameTxt.TabIndex = 3;
            this.sLNameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sLNameTxt_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Gender";
            // 
            // sFNameTxt
            // 
            this.sFNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sFNameTxt.Location = new System.Drawing.Point(183, 79);
            this.sFNameTxt.Margin = new System.Windows.Forms.Padding(5);
            this.sFNameTxt.MaxLength = 50;
            this.sFNameTxt.Multiline = true;
            this.sFNameTxt.Name = "sFNameTxt";
            this.sFNameTxt.Size = new System.Drawing.Size(248, 34);
            this.sFNameTxt.TabIndex = 2;
            this.sFNameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sFNameTxt_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(16, 185);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(126, 20);
            this.label16.TabIndex = 12;
            this.label16.Text = "Guardian Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(161, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = ":";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(16, 135);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 20);
            this.label15.TabIndex = 12;
            this.label15.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(161, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = ":";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 85);
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
            this.label3.Location = new System.Drawing.Point(161, 135);
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
            this.label9.Location = new System.Drawing.Point(16, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Index";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 84);
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
            this.label10.Location = new System.Drawing.Point(161, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = ":";
            // 
            // sIDTxt
            // 
            this.sIDTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sIDTxt.Location = new System.Drawing.Point(183, 27);
            this.sIDTxt.Margin = new System.Windows.Forms.Padding(5);
            this.sIDTxt.MaxLength = 5;
            this.sIDTxt.Multiline = true;
            this.sIDTxt.Name = "sIDTxt";
            this.sIDTxt.Size = new System.Drawing.Size(248, 34);
            this.sIDTxt.TabIndex = 1;
            this.sIDTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sIDTxt_KeyPress);
            // 
            // StudentGrid
            // 
            this.StudentGrid.AllowUserToAddRows = false;
            this.StudentGrid.AllowUserToDeleteRows = false;
            this.StudentGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentGrid.Location = new System.Drawing.Point(11, 349);
            this.StudentGrid.Name = "StudentGrid";
            this.StudentGrid.ReadOnly = true;
            this.StudentGrid.RowHeadersWidth = 51;
            this.StudentGrid.RowTemplate.Height = 24;
            this.StudentGrid.Size = new System.Drawing.Size(1515, 475);
            this.StudentGrid.TabIndex = 105;
            this.StudentGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentGrid_CellClick);
            // 
            // subjectPanel
            // 
            this.subjectPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.subjectPanel.Controls.Add(this.btnClear);
            this.subjectPanel.Controls.Add(this.btnCancel);
            this.subjectPanel.Controls.Add(this.btnDone);
            this.subjectPanel.Controls.Add(this.groupBox2);
            this.subjectPanel.Location = new System.Drawing.Point(1091, 51);
            this.subjectPanel.Name = "subjectPanel";
            this.subjectPanel.Size = new System.Drawing.Size(431, 767);
            this.subjectPanel.TabIndex = 109;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(233, 721);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 32);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(138, 721);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 32);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(328, 721);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(89, 32);
            this.btnDone.TabIndex = 9;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.selectSub);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.SsubjectsList);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 685);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Subjects";
            // 
            // selectSub
            // 
            this.selectSub.Location = new System.Drawing.Point(117, 32);
            this.selectSub.Multiline = true;
            this.selectSub.Name = "selectSub";
            this.selectSub.ReadOnly = true;
            this.selectSub.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.selectSub.Size = new System.Drawing.Size(269, 73);
            this.selectSub.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Subjects  : ";
            // 
            // SsubjectsList
            // 
            this.SsubjectsList.FormattingEnabled = true;
            this.SsubjectsList.ItemHeight = 18;
            this.SsubjectsList.Items.AddRange(new object[] {
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
            this.SsubjectsList.Location = new System.Drawing.Point(20, 124);
            this.SsubjectsList.Name = "SsubjectsList";
            this.SsubjectsList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.SsubjectsList.Size = new System.Drawing.Size(366, 544);
            this.SsubjectsList.TabIndex = 0;
            this.SsubjectsList.SelectedIndexChanged += new System.EventHandler(this.SsubjectsList_SelectedIndexChanged);
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1539, 836);
            this.Controls.Add(this.subjectPanel);
            this.Controls.Add(this.StudentGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FileMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Students";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students  | Royal Educational Institute";
            this.Load += new System.EventHandler(this.Students_Load);
            this.FileMenu.ResumeLayout(false);
            this.FileMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGrid)).EndInit();
            this.subjectPanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem teachersFileMenu;
        private System.Windows.Forms.ToolStripMenuItem studentsFeeFileMenu;
        private System.Windows.Forms.ToolStripMenuItem teacherPaymentsFileMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox SSelectedSubTxt;
        private System.Windows.Forms.RadioButton SGenRadio2;
        private System.Windows.Forms.RadioButton SGenRadio;
        private System.Windows.Forms.Button btnSelectSub;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.ComboBox sGradeCmb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox sSearchTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox sEmailTxt;
        private System.Windows.Forms.TextBox sContactTxt;
        private System.Windows.Forms.TextBox sAddressTxt;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox sGNameTxt;
        private System.Windows.Forms.TextBox sLNameTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox sFNameTxt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox sIDTxt;
        private System.Windows.Forms.DataGridView StudentGrid;
        private System.Windows.Forms.Panel subjectPanel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox selectSub;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox SsubjectsList;
    }
}