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

namespace Royal_Institute
{
    public partial class StudentFees : Form
    {
        public StudentFees()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Royal_Institute\RoyalDatabase.mdf;Integrated Security=True");

        private void mainMenuFileMenu_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            this.Hide();
        }

        private void logoutFileMenu_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void closeFileMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void studentsFileMenu_Click(object sender, EventArgs e)
        {
            Students stu = new Students();
            stu.Show();
            this.Hide();
        }

        private void teachersFileMenu_Click(object sender, EventArgs e)
        {
            Teachers teach = new Teachers();
            teach.Show();
            this.Hide();
        }

        private void teacherPaymentsFileMenu_Click(object sender, EventArgs e)
        {
            TeacherPayments TeachP = new TeacherPayments();
            TeachP.Show();
            this.Hide();
        }

        void sIdTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || e.KeyChar == 13)
            {
                e.Handled = true;
            }
        }

        void sSearchTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || e.KeyChar == 13)
            {
                e.Handled = true;
            }
        }

        void sFeeTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || e.KeyChar == 13)
            {
                e.Handled = true;
            }
        }

        void sSubjectCmb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back) || e.KeyChar == 13;
        }

        private void StudentFees_Load(object sender, EventArgs e)
        {
            try
            {
                this.ActiveControl = sIdTxt;
                con.Open();
                SetMyCustomFormat();

                string q = "SELECT ID as 'Index', FirstName as 'First Name', LastName as 'Last Name', Grade, Subjects FROM Students ORDER BY ID ASC";
                SqlDataAdapter ada = new SqlDataAdapter(q, con);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                StudentGrid.DataSource = dt;

                string q2 = "SELECT ID, StudentID as 'Student ID', PaymentMonth as 'Month/ Year', Subject, Fee, Date  FROM StudentFees ORDER BY ID DESC";
                SqlDataAdapter ada2 = new SqlDataAdapter(q2, con);
                DataTable dt2 = new DataTable();
                ada2.Fill(dt2);
                PaymentsGrid.DataSource = dt2;

                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your inputs.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void SetMyCustomFormat()
        {
            sMonthCmb.MaxDate = DateTime.Today;
            sMonthCmb.Format = DateTimePickerFormat.Custom;
            sMonthCmb.CustomFormat = "MM/yyyy";
        }

        public void ClearAll()
        {
            sIdTxt.Text = "";
            sIdTxt.Enabled = true;
            sIdTxt.Focus();
            sFNameTxt.Text = "";
            sLNametxt.Text = "";
            sGradeTxt.Text = "";
            sSubjectCmb.Text = "";
            sMonthCmb.Text = DateTime.Today.ToString();
            sFeeTxt.Text = "";
            idlabel.Text = "";
        }
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ClearAll();
            sSearchTxt.Text = "";
        }

        private void PaymentsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                if (index != -1)
                {
                    DataGridViewRow selectedRow = PaymentsGrid.Rows[index];
                    con.Open();

                    string q = "SELECT * FROM Students WHERE ID = '" + selectedRow.Cells[1].Value.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(q, con);
                    SqlDataReader r = cmd.ExecuteReader();

                    IList<string> SubList = new List<string>();

                    if (r.HasRows)
                    {
                        int x = 0;
                        
                        while (r.Read())
                        {
                            if (x == 0)
                            {
                                sIdTxt.Text = r[0].ToString();
                                sIdTxt.Enabled = false;
                                sFNameTxt.Text = r[1].ToString();
                                sLNametxt.Text = r[2].ToString();
                                sGradeTxt.Text = r[5].ToString();

                                string[] subjectList = r[6].ToString().Split(',');
                                foreach (string subject in subjectList)
                                {
                                    SubList.Add(subject);
                                }
                                SubList = SubList.Distinct().ToList();

                                sSubjectCmb.DataSource = SubList;
                            }
                            x++;
                        }
                    }
                    r.Close();
                    con.Close();

                    sSubjectCmb.Text = selectedRow.Cells[3].Value.ToString();
                    sMonthCmb.Text = selectedRow.Cells[2].Value.ToString();
                    sFeeTxt.Text = selectedRow.Cells[4].Value.ToString();
                    idlabel.Text = selectedRow.Cells[0].Value.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your inputs.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StudentGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IList<string> SubList = new List<string>();

                int index = e.RowIndex;
                if (index > -1)
                {
                    DataGridViewRow selectedRow = StudentGrid.Rows[index];

                    ClearAll();
                    sSearchTxt.Text = "";

                    sIdTxt.Text = selectedRow.Cells[0].Value.ToString();

                    sFNameTxt.Text = selectedRow.Cells[1].Value.ToString();
                    sLNametxt.Text = selectedRow.Cells[2].Value.ToString();

                    sGradeTxt.Text = selectedRow.Cells[3].Value.ToString();

                    var t = selectedRow.Cells[4].Value.ToString();

                    sSubjectCmb.DataSource = SubList;

                    string[] subjectList = t.Split(',');
                    foreach (string subject in subjectList)
                    {
                        SubList.Add(subject);
                    }
                    SubList = SubList.Distinct().ToList();

                    sSubjectCmb.DataSource = SubList;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your inputs.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGetID_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string stuId = sIdTxt.Text;

                string q = "SELECT ID, FirstName, LastName, Grade, Subjects FROM Students WHERE ID = '" + stuId + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataReader r = cmd.ExecuteReader();

                if (r.HasRows)
                {
                    int x = 0;
                    while (r.Read())
                    {
                        IList<string> SubList = new List<string>();

                        if (x == 0)
                        {
                            sIdTxt.Text = r[0].ToString();
                            sFNameTxt.Text = r[1].ToString();
                            sLNametxt.Text = r[2].ToString();
                            sGradeTxt.Text = r[3].ToString();

                            var t = r[4].ToString();

                            sSubjectCmb.DataSource = SubList;

                            string[] subjectList = t.Split(',');
                            foreach (string subject in subjectList)
                            {
                                SubList.Add(subject);
                            }
                            SubList = SubList.Distinct().ToList();

                            sSubjectCmb.DataSource = SubList;
                        }
                        x++;
                    }
                    r.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Student Index!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearAll();
                    sSearchTxt.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your inputs.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                string stuId = sIdTxt.Text;
                string month = sMonthCmb.Text;
                string subject = sSubjectCmb.Text;
                string Fee = sFeeTxt.Text;

                DateTime date = DateTime.Now;

                con.Open();

                string q = "SELECT * FROM StudentFees WHERE StudentID = '" + stuId + "' and PaymentMonth = '" + month + "' and Subject = '" + subject + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataReader r = cmd.ExecuteReader();

                if (r.HasRows)
                {
                    MessageBox.Show("The Student fee already paid.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    r.Close();
                }
                else
                {
                    r.Close();

                    if (stuId == "" || month == "" || subject == "" || Fee == "" || int.Parse(Fee) < 1)
                    {
                        MessageBox.Show("Please fill out all the information.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string inQ = "INSERT INTO StudentFees(StudentID, PaymentMonth, Subject, Fee, Date) VALUES('" + stuId + "','" + month + "','" + subject + "','" + Fee + "','" + date + "')";
                        SqlCommand cmmd = new SqlCommand(inQ, con);
                        cmmd.ExecuteNonQuery();
                        MessageBox.Show("Saved successfully!", "Done!", MessageBoxButtons.OK);

                        SqlDataAdapter ada = new SqlDataAdapter("SELECT ID, StudentID as 'Student ID', PaymentMonth as 'Month/ Year', Subject, Fee, Date  FROM StudentFees ORDER BY ID DESC", con);
                        DataTable dt = new DataTable();
                        ada.Fill(dt);
                        PaymentsGrid.DataSource = dt;

                        sSearchTxt.Text = "";

                        string q2 = "SELECT * FROM StudentFees WHERE StudentID = '" + stuId + "' and PaymentMonth = '" + month + "' and Subject = '" + subject + "'";
                        SqlCommand cmd2 = new SqlCommand(q2, con);
                        SqlDataReader r2 = cmd2.ExecuteReader();

                        if (r2.HasRows)
                        {
                            int x = 0;
                            while (r2.Read())
                            {
                                if (x == 0)
                                {
                                    idlabel.Text = r2[0].ToString();
                                }
                                x++;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your inputs.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string id = idlabel.Text;
                string grade = "";

                string stuId = sIdTxt.Text;

                string q = "SELECT Grade FROM Students WHERE ID = '" + stuId + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataReader r = cmd.ExecuteReader();

                if (r.HasRows)
                {
                    int x = 0;
                    while (r.Read())
                    {
                        if (x == 0)
                        {
                            grade = r[0].ToString();
                        }
                        x++;
                    }
                    r.Close();
                }

                if ((grade != "") && (id != ""))
                {
                    PrintStudentFeeReceipt printS = new PrintStudentFeeReceipt();

                    string q2 = "SELECT * FROM StudentFees WHERE ID = '" + id + "'";
                    SqlCommand cmd2 = new SqlCommand(q2, con);
                    SqlDataReader r2 = cmd2.ExecuteReader();

                    if (r2.HasRows)
                    {
                        int x = 0;
                        while (r2.Read())
                        {
                            if (x == 0)
                            {
                                printS.SLPName.Text = sFNameTxt.Text + " " + sLNametxt.Text;
                                printS.SLPSubject.Text = r2[3].ToString();
                                printS.SLPGrade.Text = grade;
                                printS.SLPID.Text = id + "/" + stuId;
                                printS.SLPMonth.Text = r2[2].ToString();
                                printS.SLPFee.Text = "Rs. " + r2[4].ToString() + ".00";
                                printS.SLPDate.Text = r2[5].ToString();
                            }
                            x++;
                        }
                        r2.Close();
                    }
                    printS.Show();
                }
                else
                {
                    MessageBox.Show("Please select a payment to print.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went worng. Please try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string id = idlabel.Text;

                DateTime date = DateTime.Now;

                string q = "SELECT * FROM StudentFees WHERE ID = '" + id + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataReader r = cmd.ExecuteReader();

                if (!r.HasRows)
                {
                    MessageBox.Show("Please select a Payment to update.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    r.Close();
                }
                else
                {
                    string stuId = sIdTxt.Text;
                    string month = sMonthCmb.Text;
                    string subject = sSubjectCmb.Text;
                    string Fee = sFeeTxt.Text;

                    if (stuId == "" || month == "" || subject == "" || Fee == "" || int.Parse(Fee) < 1)
                    {
                        MessageBox.Show("Please fill out all the information", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        r.Close();
                    }
                    else
                    {
                        r.Close();

                        string inQ = "UPDATE StudentFees set PaymentMonth = '" + month + "', Subject = '" + subject + "', Fee = '" + Fee + "', Date ='" + date + "' WHERE ID = '" + id + "'";

                        SqlCommand cmmd = new SqlCommand(inQ, con);
                        cmmd.ExecuteNonQuery();
                        MessageBox.Show("Updated successfully!", "Done!", MessageBoxButtons.OK);

                        SqlDataAdapter ada = new SqlDataAdapter("SELECT ID, StudentID as 'Student ID', PaymentMonth as 'Month/ Year', Subject, Fee, Date  FROM StudentFees ORDER BY ID DESC", con);
                        DataTable dt = new DataTable();
                        ada.Fill(dt);
                        PaymentsGrid.DataSource = dt;

                        sSearchTxt.Text = "";
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your inputs.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string id = idlabel.Text;

                string q = "SELECT * FROM StudentFees WHERE ID = '" + id + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataReader r = cmd.ExecuteReader();

                if (!r.HasRows)
                {
                    MessageBox.Show("Please select a Payment to delete.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    r.Close();

                }
                else
                {
                    r.Close();
                    var confirmResult = MessageBox.Show("Are you sure to delete this Payment?", "Confirm Delete!", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        string inQ = "DELETE from StudentFees WHERE ID = '" + id + "'";

                        SqlCommand cmmd = new SqlCommand(inQ, con);
                        cmmd.ExecuteNonQuery();
                        MessageBox.Show("Deleted successfully!", "Done!", MessageBoxButtons.OK);

                        SqlDataAdapter ada = new SqlDataAdapter("SELECT ID, StudentID as 'Student ID', PaymentMonth as 'Month/ Year', Subject, Fee, Date FROM StudentFees ORDER BY ID DESC", con);
                        DataTable dt = new DataTable();
                        ada.Fill(dt);
                        PaymentsGrid.DataSource = dt;

                        ClearAll();
                        sSearchTxt.Text = "";
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your inputs.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                ClearAll();

                string stuId = sSearchTxt.Text;

                string q2 = "SELECT ID, StudentID as 'Student ID', PaymentMonth as 'Month/ Year', Subject, Fee, Date FROM StudentFees WHERE StudentID = '" + stuId + "' ORDER BY ID DESC";
                SqlDataAdapter ada2 = new SqlDataAdapter(q2, con);
                DataTable dt2 = new DataTable();

                int results = ada2.Fill(dt2);

                if (results == 0)
                {
                    MessageBox.Show("Invalid Student Index!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    PaymentsGrid.DataSource = dt2;
                }

                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your inputs.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
