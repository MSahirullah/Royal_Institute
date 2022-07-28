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
    public partial class TeacherPayments : Form
    {
        public TeacherPayments()
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

        private void studentsFeeFileMenu_Click(object sender, EventArgs e)
        {
            StudentFees StuF = new StudentFees();
            StuF.Show();
            this.Hide();
        }

        void pIDTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || e.KeyChar == 13)
            {
                e.Handled = true;
            }
        }

        void pIPPCmb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || e.KeyChar == 13)
            {
                e.Handled = true;
            }
        }

        void pFeeTxt_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == '.' || !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || e.KeyChar == 13)
            {
                e.Handled = true;
            }
        }
        void pCardAmountTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || e.KeyChar == 13)
            {
                e.Handled = true;
            }
        }

        void pSearchTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || e.KeyChar == 13)
            {
                e.Handled = true;
            }
        }

        public void SetMyCustomFormat()
        {
            pMonthCmb.MaxDate = DateTime.Today;
            pMonthCmb.Format = DateTimePickerFormat.Custom;
            pMonthCmb.CustomFormat = "MM/yyyy";
        }

        private void TeacherPayments_Load(object sender, EventArgs e)
        {
            try
            {
                this.ActiveControl = pIDTxt;
                con.Open();
                SetMyCustomFormat();

                string q = "SELECT ID, FirstName as 'First Name', LastName 'Last Name', TeachingClasses as 'Grades', TeachingSubject as 'Subject' FROM Teachers ORDER BY ID ASC";
                SqlDataAdapter ada = new SqlDataAdapter(q, con);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                TeachersGrid.DataSource = dt;

                string q2 = "SELECT Id, TeacherID as 'Teacher ID', PaymentMonth as 'Month/ Year', Subject, IPP, Fee, NumOfCards as 'Num._of Cards', TeacherPayment as 'Teacher Payment', InstitutePayment as 'Institute Payment', TotalPayment as 'Total Payment', Date FROM TeacherPayments ORDER BY Id DESC";
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

        private void TeachersGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IList<string> SubList = new List<string>();

                int index = e.RowIndex;
                if (index > -1)
                {
                    DataGridViewRow selectedRow = TeachersGrid.Rows[index];

                    ClearAll();
                    pSearchTxt.Text = "";

                    pIDTxt.Text = selectedRow.Cells[0].Value.ToString();

                    string teachId = pIDTxt.Text;

                    con.Open();

                    string q = "SELECT * FROM Teachers WHERE ID = '" + teachId + "'";
                    SqlCommand cmd = new SqlCommand(q, con);
                    SqlDataReader r = cmd.ExecuteReader();

                    if (r.HasRows)
                    {
                        int x = 0;
                        while (r.Read())
                        {
                            if (x == 0)
                            {
                                pIDTxt.Text = r[0].ToString();
                                pIDTxt.Enabled = false;
                                pFNameTxt.Text = r[1].ToString();
                                pLNametxt.Text = r[2].ToString();
                                pSubjectTxt.Text = r[4].ToString();
                            }
                            x++;
                        }
                        r.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Teacher Index!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearAll();
                        pSearchTxt.Text = "";
                    }

                pFNameTxt.Text = selectedRow.Cells[1].Value.ToString();
                pLNametxt.Text = selectedRow.Cells[2].Value.ToString();
                pSubjectTxt.Text = selectedRow.Cells[4].Value.ToString();
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

        private void PaymentsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                if (index != -1)
                {
                    DataGridViewRow selectedRow = PaymentsGrid.Rows[index];
                    con.Open();

                    string q = "SELECT * FROM Teachers WHERE ID = '" + selectedRow.Cells[1].Value.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(q, con);
                    SqlDataReader r = cmd.ExecuteReader();

                    if (r.HasRows)
                    {
                        int x = 0;
                        while (r.Read())
                        {
                            if (x == 0)
                            {
                                pIDTxt.Text = r[0].ToString();
                                pIDTxt.Enabled = false;
                                pFNameTxt.Text = r[1].ToString();
                                pLNametxt.Text = r[2].ToString();
                                pSubjectTxt.Text = r[4].ToString();
                            }
                            x++;
                        }
                    }
                    r.Close();
                    con.Close();

                    pMonthCmb.Text = selectedRow.Cells[2].Value.ToString();
                    pIPPCmb.Text = selectedRow.Cells[4].Value.ToString().Substring(0, selectedRow.Cells[4].Value.ToString().Length - 1);
                    pFeeTxt.Text = selectedRow.Cells[5].Value.ToString();
                    pCardAmountTxt.Text = selectedRow.Cells[6].Value.ToString();
                    TotalPTxt.Text = selectedRow.Cells[9].Value.ToString();
                    TeacherPTxt.Text = selectedRow.Cells[7].Value.ToString();
                    InstitutePTxt.Text = selectedRow.Cells[8].Value.ToString();
                    idlabel.Text = selectedRow.Cells[0].Value.ToString();
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
                string teachId = pIDTxt.Text;

                con.Open();

                string q = "SELECT * FROM Teachers WHERE ID = '" + teachId + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataReader r = cmd.ExecuteReader();

                if (r.HasRows)
                {
                    int x = 0;
                    while (r.Read())
                    {

                        if (x == 0)
                        {
                            pIDTxt.Text = r[0].ToString();
                            pIDTxt.Enabled = false;
                            pFNameTxt.Text = r[1].ToString();
                            pLNametxt.Text = r[2].ToString();
                            pSubjectTxt.Text = r[4].ToString();
                        }
                        x = x + 1;
                    }
                    r.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Teacher Index!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearAll();
                    pSearchTxt.Text = "";
                    pIDTxt.Text = teachId;
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

        public void ClearAll()
        {
            pIDTxt.Text = "";
            pIDTxt.Enabled = true;
            pIDTxt.Focus();
            pFNameTxt.Text = "";
            pLNametxt.Text = "";
            pSubjectTxt.Text = "";
            pFeeTxt.Text = "";
            pMonthCmb.Text = DateTime.Today.ToString();
            pIPPCmb.Text = "";
            pCardAmountTxt.Text = "";
            TotalPTxt.Text = "";
            TeacherPTxt.Text = "";
            InstitutePTxt.Text = "";
            idlabel.Text = "";
        }
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ClearAll();
            pSearchTxt.Text = "";
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                string teachId = pIDTxt.Text;
                string month = pMonthCmb.Text;
                string subject = pSubjectTxt.Text;
                string IPP = pIPPCmb.Text;
                if (IPP == "")
                {
                    IPP = "0";
                }
                string Fee = pFeeTxt.Text;
                string CardAmount = pCardAmountTxt.Text;

                DateTime date = DateTime.Now;

                con.Open();

                string q = "SELECT * FROM TeacherPayments WHERE TeacherID = '" + teachId + "' and PaymentMonth = '" + month + "' and Subject = '" + subject + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataReader r = cmd.ExecuteReader();

                if (r.HasRows)
                {
                    MessageBox.Show("The Teacher payment already paid.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    r.Close();
                }
                else
                {
                    r.Close();


                    if (teachId == "" || month == "" || subject == "" || IPP == "" || Fee == "" || CardAmount == "" || int.Parse(CardAmount) < 1 || int.Parse(Fee) < 1)
                    {
                        MessageBox.Show("Please fill out all the information.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        float TotalPayment = 0;
                        float TeacherPayment = 0;
                        float InstitutePayment = 0;

                        float IPPcal = float.Parse(IPP);
                        float Feecal = float.Parse(Fee);
                        int CardAmountcal = int.Parse(CardAmount);

                        TotalPayment = Feecal * CardAmountcal;
                        InstitutePayment = (TotalPayment * IPPcal) / 100;
                        TeacherPayment = TotalPayment - InstitutePayment;

                        IPP += "%";

                        int s1 = (int)Math.Round(TotalPayment);
                        string t1 = s1.ToString() + ".00";

                        int s2 = (int)Math.Round(TeacherPayment);
                        string t2 = s2.ToString() + ".00";

                        int s3 = (int)Math.Round(InstitutePayment);
                        string t3 = s3.ToString() + ".00";

                        string inQ = "INSERT INTO TeacherPayments(TeacherID, PaymentMonth, Subject, IPP, Fee, NumOfCards, TeacherPayment, InstitutePayment, TotalPayment, Date) VALUES('" + teachId + "','" + month + "','" + subject + "','" + IPP+ "','" + Feecal + "','" + CardAmountcal + "','" + t2 + "','" + t3 + "','" + t1 + "','" + date + "')";
                        SqlCommand cmmd = new SqlCommand(inQ, con);
                        cmmd.ExecuteNonQuery();
                        MessageBox.Show("Saved successfully!", "Done!", MessageBoxButtons.OK);

                        SqlDataAdapter ada = new SqlDataAdapter("SELECT ID, TeacherID as 'Teacher ID', PaymentMonth as 'Month/ Year', Subject, IPP, Fee, NumOfCards as 'Num._of Cards', TeacherPayment as 'Teacher Payment', InstitutePayment as 'Institute Payment', TotalPayment as 'Total Payment', Date FROM TeacherPayments ORDER BY ID DESC", con);
                        DataTable dt = new DataTable();
                        ada.Fill(dt);
                        PaymentsGrid.DataSource = dt;

                        pSearchTxt.Text = "";

                        TotalPTxt.Text = t1;
                        TeacherPTxt.Text = t2;
                        InstitutePTxt.Text = t3;

                        string q2 = "SELECT * FROM TeacherPayments WHERE TeacherID = '" + teachId + "' and PaymentMonth = '" + month + "' and Subject = '" + subject + "'";
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string id = idlabel.Text;

                DateTime date = DateTime.Now;

                string q = "SELECT * FROM TeacherPayments WHERE ID = '" + id + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataReader r = cmd.ExecuteReader();

                if (!r.HasRows)
                {
                    MessageBox.Show("Please select a Payment to update.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    r.Close();
                }
                else
                {
                    string teachId = pIDTxt.Text;
                    string month = pMonthCmb.Text;
                    string subject = pSubjectTxt.Text;
                    string IPP = pIPPCmb.Text;
                    string Fee = pFeeTxt.Text;
                    string CardAmount = pCardAmountTxt.Text;

                    if (id == "" || teachId == "" || month == "" || subject == "" || IPP == "" || Fee == "" || CardAmount == "" || int.Parse(CardAmount) < 1 || int.Parse(Fee) < 1)
                    {
                        MessageBox.Show("Please fill out all the information", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        r.Close();
                    }
                    else
                    {
                        r.Close();
                        float TotalPayment = 0;
                        float TeacherPayment = 0;
                        float InstitutePayment = 0;

                        float IPPcal = float.Parse(IPP);
                        float Feecal = float.Parse(Fee);
                        int CardAmountcal = int.Parse(CardAmount);

                        TotalPayment = Feecal * CardAmountcal;
                        InstitutePayment = (TotalPayment * IPPcal) / 100;
                        TeacherPayment = TotalPayment - InstitutePayment;

                        IPP += "%";

                        int s1 = (int)Math.Round(TotalPayment);
                        string t1 = s1.ToString() + ".00";

                        int s2 = (int)Math.Round(TeacherPayment);
                        string t2 = s2.ToString() + ".00";

                        int s3 = (int)Math.Round(InstitutePayment);
                        string t3 = s3.ToString() + ".00";

                        string inQ = "UPDATE TeacherPayments set PaymentMonth = '" + month + "', Subject = '" + subject + "', IPP = '" + IPP + "', Fee = '" + Feecal + "', NumOfCards = '" + CardAmountcal + "', TeacherPayment ='" + t2 + "', InstitutePayment ='" + t3 + "', TotalPayment ='" + t1 + "', Date ='" + date + "' WHERE ID = '" + id + "'";

                        SqlCommand cmmd = new SqlCommand(inQ, con);
                        cmmd.ExecuteNonQuery();
                        MessageBox.Show("Updated successfully!", "Done!", MessageBoxButtons.OK);

                        SqlDataAdapter ada = new SqlDataAdapter("SELECT ID, TeacherID as 'Teacher ID', PaymentMonth as 'Month/ Year', Subject, IPP, Fee, NumOfCards as 'Num._of Cards', TeacherPayment as 'Teacher Payment', InstitutePayment as 'Institute Payment', TotalPayment as 'Total Payment', Date FROM TeacherPayments ORDER BY ID DESC", con);
                        DataTable dt = new DataTable();
                        ada.Fill(dt);
                        PaymentsGrid.DataSource = dt;

                        pSearchTxt.Text = "";
                        TotalPTxt.Text = t1;
                        TeacherPTxt.Text = t2;
                        InstitutePTxt.Text = t3;
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

                string q = "SELECT * FROM TeacherPayments WHERE ID = '" + id + "'";
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
                        string inQ = "DELETE from TeacherPayments WHERE ID = '" + id + "'";

                        SqlCommand cmmd = new SqlCommand(inQ, con);
                        cmmd.ExecuteNonQuery();
                        MessageBox.Show("Deleted successfully!", "Done!", MessageBoxButtons.OK);

                        SqlDataAdapter ada = new SqlDataAdapter("SELECT ID, TeacherID as 'Teacher ID', PaymentMonth as 'Month/ Year', Subject, IPP, Fee, NumOfCards as 'Num._of Cards', TeacherPayment as 'Teacher Payment', InstitutePayment as 'Institute Payment', TotalPayment as 'Total Payment', Date FROM TeacherPayments ORDER BY ID DESC", con);
                        DataTable dt = new DataTable();
                        ada.Fill(dt);
                        PaymentsGrid.DataSource = dt;

                        ClearAll();
                        pSearchTxt.Text = "";
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

                string teachId = pSearchTxt.Text;

                string q2 = "SELECT ID, TeacherID as 'Teacher ID', PaymentMonth as 'Month/ Year', Subject, IPP, Fee, NumOfCards as 'Num._of Cards', TeacherPayment as 'Teacher Payment', InstitutePayment as 'Institute Payment', TotalPayment as 'Total Payment', Date FROM TeacherPayments WHERE TeacherID = '"+ teachId + "' ORDER BY ID DESC";
                SqlDataAdapter ada2 = new SqlDataAdapter(q2, con);
                DataTable dt2 = new DataTable();

                int results = ada2.Fill(dt2);

                if (results == 0)
                {
                    MessageBox.Show("Invalid Teacher ID!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string totalP = TotalPTxt.Text;
                string teacherP = TeacherPTxt.Text;
                string instututeP = InstitutePTxt.Text;
                string grade = "";
                string id = idlabel.Text;

                string teachId = pIDTxt.Text;

                string q = "SELECT TeachingClasses FROM Teachers WHERE ID = '" + teachId + "'";
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

                if ((totalP != "") && (teacherP != "") && (instututeP != "") && (grade != "") && (id != ""))
                {
                    PrintTeacherPaymentReport printL = new PrintTeacherPaymentReport();

                    string q2 = "SELECT * FROM TeacherPayments WHERE ID = '" + id + "'";
                    SqlCommand cmd2 = new SqlCommand(q2, con);
                    SqlDataReader r2 = cmd2.ExecuteReader();

                    if (r2.HasRows)
                    {
                        int x = 0;
                        while (r2.Read())
                        {
                            if (x == 0)
                            {
                                printL.PTPName.Text = pFNameTxt.Text + " " + pLNametxt.Text;
                                printL.PLPSubject.Text = r2[3].ToString();
                                printL.PLPGrade.Text = grade;
                                printL.PLPID.Text = id + "/" + teachId;
                                printL.PLPMonth.Text = r2[2].ToString();
                                printL.PLPIPP.Text = r2[4].ToString();
                                printL.PLPFee.Text = "Rs. " + r2[5].ToString() + ".00";
                                printL.PLPCardAmount.Text = r2[6].ToString();
                                printL.PLPDate.Text = r2[10].ToString();
                                printL.PLPTeachPayment.Text = "Rs. " + r2[7].ToString();
                                printL.PLPInstitutePayment.Text = "Rs. " + r2[8].ToString();
                                printL.PLPTotPayment.Text = "Rs. " + r2[9].ToString();
                            }
                            x++;
                        }
                        r2.Close();
                    }
                    printL.Show();
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
    }
}
