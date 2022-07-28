
namespace Royal_Institute
{
    partial class TeacherPayments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherPayments));
            this.FileMenu = new System.Windows.Forms.MenuStrip();
            this.fileFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.closeFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.teachersFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsFeeFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pMonthCmb = new System.Windows.Forms.DateTimePicker();
            this.label29 = new System.Windows.Forms.Label();
            this.idlabel = new System.Windows.Forms.Label();
            this.PaymentPanel = new System.Windows.Forms.Panel();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.InstitutePTxt = new System.Windows.Forms.TextBox();
            this.TeacherPTxt = new System.Windows.Forms.TextBox();
            this.TotalPTxt = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pSubjectTxt = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGetID = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.pIPPCmb = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pSearchTxt = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.pCardAmountTxt = new System.Windows.Forms.TextBox();
            this.pFeeTxt = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.pLNametxt = new System.Windows.Forms.TextBox();
            this.pFNameTxt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pIDTxt = new System.Windows.Forms.TextBox();
            this.TeachersGrid = new System.Windows.Forms.DataGridView();
            this.PaymentsGrid = new System.Windows.Forms.DataGridView();
            this.FileMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PaymentPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersGrid)).BeginInit();
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
            this.FileMenu.TabIndex = 104;
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
            this.studentsFeeFileMenu});
            this.menuFileMenu.ForeColor = System.Drawing.Color.White;
            this.menuFileMenu.Name = "menuFileMenu";
            this.menuFileMenu.Size = new System.Drawing.Size(60, 24);
            this.menuFileMenu.Text = "Menu";
            // 
            // studentsFileMenu
            // 
            this.studentsFileMenu.Name = "studentsFileMenu";
            this.studentsFileMenu.Size = new System.Drawing.Size(176, 26);
            this.studentsFileMenu.Text = "Students";
            this.studentsFileMenu.Click += new System.EventHandler(this.studentsFileMenu_Click);
            // 
            // teachersFileMenu
            // 
            this.teachersFileMenu.Name = "teachersFileMenu";
            this.teachersFileMenu.Size = new System.Drawing.Size(176, 26);
            this.teachersFileMenu.Text = "Teachers";
            this.teachersFileMenu.Click += new System.EventHandler(this.teachersFileMenu_Click);
            // 
            // studentsFeeFileMenu
            // 
            this.studentsFeeFileMenu.Name = "studentsFeeFileMenu";
            this.studentsFeeFileMenu.Size = new System.Drawing.Size(176, 26);
            this.studentsFeeFileMenu.Text = "Student Fees";
            this.studentsFeeFileMenu.Click += new System.EventHandler(this.studentsFeeFileMenu_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pMonthCmb);
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.idlabel);
            this.panel1.Controls.Add(this.PaymentPanel);
            this.panel1.Controls.Add(this.pSubjectTxt);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnGetID);
            this.panel1.Controls.Add(this.btnClearAll);
            this.panel1.Controls.Add(this.pIPPCmb);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnPay);
            this.panel1.Controls.Add(this.pCardAmountTxt);
            this.panel1.Controls.Add(this.pFeeTxt);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.pLNametxt);
            this.panel1.Controls.Add(this.pFNameTxt);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.pIDTxt);
            this.panel1.Location = new System.Drawing.Point(12, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1515, 264);
            this.panel1.TabIndex = 105;
            // 
            // pMonthCmb
            // 
            this.pMonthCmb.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pMonthCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pMonthCmb.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pMonthCmb.Location = new System.Drawing.Point(669, 31);
            this.pMonthCmb.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.pMonthCmb.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.pMonthCmb.Name = "pMonthCmb";
            this.pMonthCmb.Size = new System.Drawing.Size(193, 27);
            this.pMonthCmb.TabIndex = 3;
            this.pMonthCmb.Value = new System.DateTime(2021, 8, 10, 0, 0, 0, 0);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.White;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(831, 152);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(31, 20);
            this.label29.TabIndex = 105;
            this.label29.Text = ".00";
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.BackColor = System.Drawing.Color.Transparent;
            this.idlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlabel.ForeColor = System.Drawing.Color.Transparent;
            this.idlabel.Location = new System.Drawing.Point(490, 124);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(138, 20);
            this.idlabel.TabIndex = 104;
            this.idlabel.Text = "Fee (per studnet)";
            this.idlabel.Visible = false;
            // 
            // PaymentPanel
            // 
            this.PaymentPanel.BackColor = System.Drawing.SystemColors.Menu;
            this.PaymentPanel.Controls.Add(this.label28);
            this.PaymentPanel.Controls.Add(this.label27);
            this.PaymentPanel.Controls.Add(this.label7);
            this.PaymentPanel.Controls.Add(this.btnPrint);
            this.PaymentPanel.Controls.Add(this.InstitutePTxt);
            this.PaymentPanel.Controls.Add(this.TeacherPTxt);
            this.PaymentPanel.Controls.Add(this.TotalPTxt);
            this.PaymentPanel.Controls.Add(this.label26);
            this.PaymentPanel.Controls.Add(this.label12);
            this.PaymentPanel.Controls.Add(this.label25);
            this.PaymentPanel.Controls.Add(this.label11);
            this.PaymentPanel.Controls.Add(this.label13);
            this.PaymentPanel.Controls.Add(this.label8);
            this.PaymentPanel.Location = new System.Drawing.Point(1072, 113);
            this.PaymentPanel.Name = "PaymentPanel";
            this.PaymentPanel.Size = new System.Drawing.Size(428, 128);
            this.PaymentPanel.TabIndex = 103;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.SystemColors.Menu;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(160, 87);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(31, 18);
            this.label28.TabIndex = 104;
            this.label28.Text = "Rs.";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.SystemColors.Menu;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(160, 52);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(31, 18);
            this.label27.TabIndex = 104;
            this.label27.Text = "Rs.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Menu;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(160, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 18);
            this.label7.TabIndex = 104;
            this.label7.Text = "Rs.";
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(350, 80);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(67, 36);
            this.btnPrint.TabIndex = 13;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // InstitutePTxt
            // 
            this.InstitutePTxt.BackColor = System.Drawing.SystemColors.Control;
            this.InstitutePTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstitutePTxt.Location = new System.Drawing.Point(206, 81);
            this.InstitutePTxt.Margin = new System.Windows.Forms.Padding(5);
            this.InstitutePTxt.MaxLength = 50;
            this.InstitutePTxt.Multiline = true;
            this.InstitutePTxt.Name = "InstitutePTxt";
            this.InstitutePTxt.ReadOnly = true;
            this.InstitutePTxt.Size = new System.Drawing.Size(136, 28);
            this.InstitutePTxt.TabIndex = 104;
            // 
            // TeacherPTxt
            // 
            this.TeacherPTxt.BackColor = System.Drawing.SystemColors.Control;
            this.TeacherPTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherPTxt.Location = new System.Drawing.Point(206, 46);
            this.TeacherPTxt.Margin = new System.Windows.Forms.Padding(5);
            this.TeacherPTxt.MaxLength = 50;
            this.TeacherPTxt.Multiline = true;
            this.TeacherPTxt.Name = "TeacherPTxt";
            this.TeacherPTxt.ReadOnly = true;
            this.TeacherPTxt.Size = new System.Drawing.Size(211, 28);
            this.TeacherPTxt.TabIndex = 104;
            // 
            // TotalPTxt
            // 
            this.TotalPTxt.BackColor = System.Drawing.SystemColors.Control;
            this.TotalPTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPTxt.Location = new System.Drawing.Point(206, 10);
            this.TotalPTxt.Margin = new System.Windows.Forms.Padding(5);
            this.TotalPTxt.MaxLength = 50;
            this.TotalPTxt.Multiline = true;
            this.TotalPTxt.Name = "TotalPTxt";
            this.TotalPTxt.ReadOnly = true;
            this.TotalPTxt.Size = new System.Drawing.Size(211, 30);
            this.TotalPTxt.TabIndex = 104;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.SystemColors.Menu;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(188, 83);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(15, 20);
            this.label26.TabIndex = 106;
            this.label26.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Menu;
            this.label12.Font = new System.Drawing.Font("Mangal", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 27);
            this.label12.TabIndex = 106;
            this.label12.Text = "Institute Payment";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.SystemColors.Menu;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(188, 48);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(15, 20);
            this.label25.TabIndex = 105;
            this.label25.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Menu;
            this.label11.Font = new System.Drawing.Font("Mangal", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 27);
            this.label11.TabIndex = 105;
            this.label11.Text = "Teacher Payment";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Menu;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(188, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 20);
            this.label13.TabIndex = 104;
            this.label13.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Menu;
            this.label8.Font = new System.Drawing.Font("Mangal", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 27);
            this.label8.TabIndex = 104;
            this.label8.Text = "Total Payment";
            // 
            // pSubjectTxt
            // 
            this.pSubjectTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pSubjectTxt.Location = new System.Drawing.Point(183, 204);
            this.pSubjectTxt.Margin = new System.Windows.Forms.Padding(5);
            this.pSubjectTxt.MaxLength = 50;
            this.pSubjectTxt.Multiline = true;
            this.pSubjectTxt.Name = "pSubjectTxt";
            this.pSubjectTxt.ReadOnly = true;
            this.pSubjectTxt.Size = new System.Drawing.Size(231, 34);
            this.pSubjectTxt.TabIndex = 30;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(645, 212);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(14, 20);
            this.label19.TabIndex = 20;
            this.label19.Text = ":";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.White;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(645, 151);
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
            this.label6.Location = new System.Drawing.Point(622, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Rs.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(838, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "%";
            // 
            // btnGetID
            // 
            this.btnGetID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetID.Location = new System.Drawing.Point(331, 27);
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
            this.btnClearAll.Location = new System.Drawing.Point(902, 205);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(123, 35);
            this.btnClearAll.TabIndex = 10;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // pIPPCmb
            // 
            this.pIPPCmb.AutoCompleteCustomSource.AddRange(new string[] {
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
            this.pIPPCmb.BackColor = System.Drawing.SystemColors.Menu;
            this.pIPPCmb.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.pIPPCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pIPPCmb.ItemHeight = 20;
            this.pIPPCmb.Items.AddRange(new object[] {
            "8",
            "10",
            "15",
            "20",
            "25"});
            this.pIPPCmb.Location = new System.Drawing.Point(669, 89);
            this.pIPPCmb.MaxLength = 2;
            this.pIPPCmb.Name = "pIPPCmb";
            this.pIPPCmb.Size = new System.Drawing.Size(160, 28);
            this.pIPPCmb.TabIndex = 4;
            this.pIPPCmb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pIPPCmb_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pSearchTxt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1072, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Payments";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(336, 26);
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
            this.label1.Location = new System.Drawing.Point(10, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher ID :";
            // 
            // pSearchTxt
            // 
            this.pSearchTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pSearchTxt.Location = new System.Drawing.Point(128, 27);
            this.pSearchTxt.Margin = new System.Windows.Forms.Padding(5);
            this.pSearchTxt.MaxLength = 5;
            this.pSearchTxt.Multiline = true;
            this.pSearchTxt.Name = "pSearchTxt";
            this.pSearchTxt.Size = new System.Drawing.Size(200, 33);
            this.pSearchTxt.TabIndex = 11;
            this.pSearchTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pSearchTxt_KeyPress);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(902, 146);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 38);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(902, 87);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(123, 38);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(902, 27);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(123, 38);
            this.btnPay.TabIndex = 7;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // pCardAmountTxt
            // 
            this.pCardAmountTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pCardAmountTxt.Location = new System.Drawing.Point(668, 205);
            this.pCardAmountTxt.Margin = new System.Windows.Forms.Padding(5);
            this.pCardAmountTxt.MaxLength = 12;
            this.pCardAmountTxt.Multiline = true;
            this.pCardAmountTxt.Name = "pCardAmountTxt";
            this.pCardAmountTxt.Size = new System.Drawing.Size(194, 34);
            this.pCardAmountTxt.TabIndex = 6;
            this.pCardAmountTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pCardAmountTxt_KeyPress);
            // 
            // pFeeTxt
            // 
            this.pFeeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pFeeTxt.Location = new System.Drawing.Point(669, 145);
            this.pFeeTxt.Margin = new System.Windows.Forms.Padding(5);
            this.pFeeTxt.MaxLength = 12;
            this.pFeeTxt.Multiline = true;
            this.pFeeTxt.Name = "pFeeTxt";
            this.pFeeTxt.Size = new System.Drawing.Size(160, 34);
            this.pFeeTxt.TabIndex = 5;
            this.pFeeTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pFeeTxt_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(453, 209);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(117, 20);
            this.label17.TabIndex = 18;
            this.label17.Text = "Num. of Cards";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(453, 151);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(138, 20);
            this.label18.TabIndex = 19;
            this.label18.Text = "Fee (per studnet)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(453, 92);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 20);
            this.label20.TabIndex = 21;
            this.label20.Text = "I. P. P";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.White;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(453, 32);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(162, 20);
            this.label22.TabIndex = 23;
            this.label22.Text = "Payment MM / YYYY";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.White;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(645, 92);
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
            this.label24.Location = new System.Drawing.Point(645, 32);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(14, 20);
            this.label24.TabIndex = 25;
            this.label24.Text = ":";
            // 
            // pLNametxt
            // 
            this.pLNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pLNametxt.Location = new System.Drawing.Point(183, 146);
            this.pLNametxt.Margin = new System.Windows.Forms.Padding(5);
            this.pLNametxt.MaxLength = 50;
            this.pLNametxt.Multiline = true;
            this.pLNametxt.Name = "pLNametxt";
            this.pLNametxt.ReadOnly = true;
            this.pLNametxt.Size = new System.Drawing.Size(231, 34);
            this.pLNametxt.TabIndex = 100;
            // 
            // pFNameTxt
            // 
            this.pFNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pFNameTxt.Location = new System.Drawing.Point(183, 87);
            this.pFNameTxt.Margin = new System.Windows.Forms.Padding(5);
            this.pFNameTxt.MaxLength = 50;
            this.pFNameTxt.Multiline = true;
            this.pFNameTxt.Name = "pFNameTxt";
            this.pFNameTxt.ReadOnly = true;
            this.pFNameTxt.Size = new System.Drawing.Size(231, 34);
            this.pFNameTxt.TabIndex = 100;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(16, 204);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 20);
            this.label16.TabIndex = 12;
            this.label16.Text = "Subject";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(16, 146);
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
            this.label4.Location = new System.Drawing.Point(161, 209);
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
            this.label3.Location = new System.Drawing.Point(161, 151);
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
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Teacher ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 92);
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
            // pIDTxt
            // 
            this.pIDTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pIDTxt.Location = new System.Drawing.Point(187, 28);
            this.pIDTxt.Margin = new System.Windows.Forms.Padding(5);
            this.pIDTxt.MaxLength = 5;
            this.pIDTxt.Multiline = true;
            this.pIDTxt.Name = "pIDTxt";
            this.pIDTxt.Size = new System.Drawing.Size(136, 34);
            this.pIDTxt.TabIndex = 1;
            this.pIDTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pIDTxt_KeyPress);
            // 
            // TeachersGrid
            // 
            this.TeachersGrid.AllowUserToAddRows = false;
            this.TeachersGrid.AllowUserToDeleteRows = false;
            this.TeachersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TeachersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeachersGrid.Location = new System.Drawing.Point(12, 319);
            this.TeachersGrid.Name = "TeachersGrid";
            this.TeachersGrid.ReadOnly = true;
            this.TeachersGrid.RowHeadersWidth = 51;
            this.TeachersGrid.RowTemplate.Height = 24;
            this.TeachersGrid.Size = new System.Drawing.Size(544, 505);
            this.TeachersGrid.TabIndex = 106;
            this.TeachersGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TeachersGrid_CellClick);
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
            this.PaymentsGrid.TabIndex = 107;
            this.PaymentsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PaymentsGrid_CellClick);
            // 
            // TeacherPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1539, 836);
            this.Controls.Add(this.TeachersGrid);
            this.Controls.Add(this.PaymentsGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FileMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TeacherPayments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher Payments | Royal Educational Institute";
            this.Load += new System.EventHandler(this.TeacherPayments_Load);
            this.FileMenu.ResumeLayout(false);
            this.FileMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PaymentPanel.ResumeLayout(false);
            this.PaymentPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersGrid)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem studentsFeeFileMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker pMonthCmb;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.Panel PaymentPanel;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox InstitutePTxt;
        private System.Windows.Forms.TextBox TeacherPTxt;
        private System.Windows.Forms.TextBox TotalPTxt;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox pSubjectTxt;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGetID;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.ComboBox pIPPCmb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pSearchTxt;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox pCardAmountTxt;
        private System.Windows.Forms.TextBox pFeeTxt;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox pLNametxt;
        private System.Windows.Forms.TextBox pFNameTxt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox pIDTxt;
        private System.Windows.Forms.DataGridView TeachersGrid;
        private System.Windows.Forms.DataGridView PaymentsGrid;
    }
}