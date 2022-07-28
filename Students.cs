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
    public partial class Students : Form
    {
        public Students()
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

        private void teacherPaymentsFileMenu_Click(object sender, EventArgs e)
        {
            TeacherPayments TeachP = new TeacherPayments();
            TeachP.Show();
            this.Hide();
        }

        public void checkEnter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
            }
        }

        void sFNameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back) || e.KeyChar == 13;
        }

        void sLNameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back) || e.KeyChar == 13;
        }

        void sGNameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || string.IsNullOrWhiteSpace(e.KeyChar.ToString()) || e.KeyChar == '.') || e.KeyChar == 13;
        }

        void sIDTxt_KeyPress(object sender, KeyPressEventArgs e)
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

        void sContactTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || e.KeyChar == 13)
            {
                e.Handled = true;
            }
        }

        private void Students_Load(object sender, EventArgs e)
        {
            subjectPanel.Hide();
            try
            {
                this.ActiveControl = sIDTxt;
                con.Open();

                string q = "SELECT ID as 'Index', FirstName as 'First Name', LastName as 'Last Name', GuardianName as 'Guardian Name', Gender, Grade, Subjects, Address, Contact, Email FROM Students ORDER BY ID DESC";
                SqlDataAdapter ada = new SqlDataAdapter(q, con);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                StudentGrid.DataSource = dt;

                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Something went worng. Please try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelectSub_Click(object sender, EventArgs e)
        {
            subjectPanel.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            SSelectedSubTxt.Text = "";
            SsubjectsList.SelectedIndex = -1;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            string temp = selectSub.Text;
            if(temp != "") { 
                SSelectedSubTxt.Text = temp.Substring(0, temp.Length - 1);
            }
            subjectPanel.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            subjectPanel.Hide();
        }

        private void SsubjectsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SsubjectsList.SelectedItems.Count <= 5)
            {
                selectSub.Text = "";
                foreach (var item in SsubjectsList.SelectedItems)
                {
                    selectSub.Text += item.ToString() + ",";
                }
            }
            else
            {
                MessageBox.Show("You have selected more than 5 subjects.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                selectSub.Text = "";
                SsubjectsList.SelectedIndex = -1;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                subjectPanel.Hide();
                string id = sIDTxt.Text;

                con.Open();

                string q = "SELECT * FROM Students WHERE ID = '" + id + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataReader r = cmd.ExecuteReader();

                if (r.HasRows)
                {
                    MessageBox.Show("The Student Index already exists.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    r.Close();
                }
                else
                {
                    r.Close();
                    string fName = sFNameTxt.Text;
                    string lName = sLNameTxt.Text;
                    string gName = sGNameTxt.Text;

                    string gender = "";
                    if (SGenRadio.Checked) { gender = "Male"; }
                    else { gender = "Female"; }

                    string grade = sGradeCmb.Text;
                    string subjects = SSelectedSubTxt.Text;
                    string address = sAddressTxt.Text;
                    string email = sEmailTxt.Text;
                    if (email == "") { email = "-"; }
                    string phone = sContactTxt.Text;

                    if (id == "" || fName == "" || lName == "" || gName == "" || gender == "" || address == "" || phone == "" || grade == "" || subjects == "")
                    {
                        MessageBox.Show("Please fill out all the information.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string inQ = "INSERT INTO Students VALUES('" + id + "','" + fName + "'," +"'" + lName + "','" + gName + "','" + gender + "','" + grade + "'," +"'" + subjects + "','" + address + "','" + phone + "','" + email + "')";
                        SqlCommand cmmd = new SqlCommand(inQ, con);
                        cmmd.ExecuteNonQuery();
                        MessageBox.Show("Saved successfully!", "Done!", MessageBoxButtons.OK);

                        SqlDataAdapter ada = new SqlDataAdapter("SELECT ID as 'Index', FirstName as 'First Name', LastName as 'Last Name', GuardianName as 'Guardian Name', Gender, Grade, Subjects, Address, Contact, Email FROM Students ORDER BY ID DESC", con);
                        DataTable dt = new DataTable();
                        ada.Fill(dt);
                        StudentGrid.DataSource = dt;

                        ClearAll();
                        sSearchTxt.Text = "";
                    }
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
        
        public void ClearAll()
        {
            subjectPanel.Hide();
            sIDTxt.Text = "";
            sIDTxt.Enabled = true;
            sIDTxt.Focus();
            sFNameTxt.Text = "";
            sLNameTxt.Text = "";
            sGNameTxt.Text = "";
            SGenRadio.Checked = false;
            SGenRadio2.Checked = false;
            sGradeCmb.Text = "";
            SSelectedSubTxt.Text = "";
            SsubjectsList.SelectedIndex = -1;
            sAddressTxt.Text = "";
            sContactTxt.Text = "";
            sEmailTxt.Text = "";
        }
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ClearAll();
            sSearchTxt.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                subjectPanel.Hide();
                con.Open();

                string id = sIDTxt.Text;
                string fName = sFNameTxt.Text;
                string lName = sLNameTxt.Text;
                string gName = sGNameTxt.Text;

                string gender = "";
                if (SGenRadio.Checked) { gender = "Male"; }
                else { gender = "Female"; }

                string grade = sGradeCmb.Text;
                string subjects = SSelectedSubTxt.Text;
                string address = sAddressTxt.Text;
                string email = sEmailTxt.Text;
                if (email == "") { email = "-"; }
                string phone = sContactTxt.Text;

                string q = "SELECT * FROM Students WHERE ID = '" + id + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataReader r = cmd.ExecuteReader();

                if (!r.HasRows)
                {
                    MessageBox.Show("Please select a Student to update.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    r.Close();
                }
                else if (id == "" || fName == "" || lName == "" || gName == "" || gender == "" || address == "" || phone == "" || grade == "" || subjects == "")
                {
                    r.Close();
                    MessageBox.Show("Please fill out all the information.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    r.Close();
                    string inQ = "UPDATE Students set  FirstName =  '" + fName + "', LastName = '" + lName + "', GuardianName = '" + gName + "', Gender = '" + gender + "', Grade = '" + grade + "', Subjects = '" + subjects + "', Email ='" + email + "', Address ='" + address + "', Contact ='" + phone + "' WHERE ID = '" + id + "'";

                    SqlCommand cmmd = new SqlCommand(inQ, con);
                    cmmd.ExecuteNonQuery();
                    MessageBox.Show("Updated successfully!", "Done!", MessageBoxButtons.OK);

                    SqlDataAdapter ada = new SqlDataAdapter("SELECT ID as 'Index', FirstName as 'First Name', LastName as 'Last Name', GuardianName as 'Guardian Name', Gender, Grade, Subjects, Address, Contact, Email FROM Students ORDER BY ID DESC", con);
                    DataTable dt = new DataTable();
                    ada.Fill(dt);
                    StudentGrid.DataSource = dt;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                subjectPanel.Hide();
                string id = sIDTxt.Text;

                string q = "SELECT * FROM Students WHERE ID = '" + id + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataReader r = cmd.ExecuteReader();

                if (!r.HasRows)
                {
                    MessageBox.Show("Please select a Student to delete.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    r.Close();
                }
                else
                {
                    r.Close();
                    var confirmResult = MessageBox.Show("Are you sure to delete this Student?", "Confirm Delete!", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        string inQ = "DELETE from Students WHERE ID = '" + id + "'";

                        SqlCommand cmmd = new SqlCommand(inQ, con);
                        cmmd.ExecuteNonQuery();
                        MessageBox.Show("Deleted successfully!", "Done!", MessageBoxButtons.OK);

                        SqlDataAdapter ada = new SqlDataAdapter("SELECT ID as 'Index', FirstName as 'First Name', LastName as 'Last Name', GuardianName as 'Guardian Name', Gender, Grade, Subjects, Address, Contact, Email FROM Students ORDER BY ID DESC", con);
                        DataTable dt = new DataTable();
                        ada.Fill(dt);
                        StudentGrid.DataSource = dt;

                        ClearAll();
                        sSearchTxt.Text = "";
                    }
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
       
        private void StudentGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                subjectPanel.Hide();
                int index = e.RowIndex;
                if (index != -1)
                {
                    DataGridViewRow selectedRow = StudentGrid.Rows[index];

                    sIDTxt.Text = selectedRow.Cells[0].Value.ToString();
                    sIDTxt.Enabled = false;

                    sFNameTxt.Text = selectedRow.Cells[1].Value.ToString();
                    sLNameTxt.Text = selectedRow.Cells[2].Value.ToString();
                    sGNameTxt.Text = selectedRow.Cells[3].Value.ToString();

                    if (selectedRow.Cells[4].Value.ToString() == "Male")
                    {
                        SGenRadio.Checked = true;
                    }
                    else
                    {
                        SGenRadio2.Checked = true;
                    }
                    sGradeCmb.Text = selectedRow.Cells[5].Value.ToString();
                    SSelectedSubTxt.Text = selectedRow.Cells[6].Value.ToString();

                    selectSub.Text = selectedRow.Cells[6].Value.ToString();
                    sAddressTxt.Text = selectedRow.Cells[7].Value.ToString();
                    sContactTxt.Text = selectedRow.Cells[8].Value.ToString();
                    sEmailTxt.Text = selectedRow.Cells[9].Value.ToString();

                    var t = selectedRow.Cells[6].Value.ToString();
                    int Subindex;
                    SsubjectsList.SelectedIndex = -1;

                    string[] subjectList = t.Split(',');
                    foreach (string subject in subjectList)
                    {
                        Subindex = SsubjectsList.FindString(subject);
                        if (Subindex != -1)
                        {
                            SsubjectsList.SetSelected(Subindex, true);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went worng. Please try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string id = sSearchTxt.Text;

                string q = "SELECT * FROM Students WHERE ID = '" + id + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataReader r = cmd.ExecuteReader();

                if (r.HasRows)
                {
                    int x = 0;
                    while (r.Read())
                    {
                        if (x == 0)
                        {
                            sIDTxt.Text = r[0].ToString();
                            sIDTxt.Enabled = false;

                            sFNameTxt.Text = r[1].ToString();
                            sLNameTxt.Text = r[2].ToString();
                            sGNameTxt.Text = r[3].ToString();

                            if (r[4].ToString() == "Male")
                            {
                                SGenRadio.Checked = true;
                            }
                            else
                            {
                                SGenRadio2.Checked = true;
                            }
                            sGradeCmb.Text = r[5].ToString();
                            SSelectedSubTxt.Text = r[6].ToString();

                            selectSub.Text = r[6].ToString();
                            sAddressTxt.Text = r[7].ToString();
                            sContactTxt.Text = r[8].ToString();
                            sEmailTxt.Text = r[9].ToString();

                            var t = r[6].ToString();
                            int Subindex;
                            SsubjectsList.SelectedIndex = -1;

                            string[] subjectList = t.Split(',');
                            foreach (string subject in subjectList)
                            {
                                Subindex = SsubjectsList.FindString(subject);
                                if (Subindex != -1)
                                {
                                    SsubjectsList.SetSelected(Subindex, true);
                                }
                            }
                        }
                        x++;
                    }
                    r.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Student Index!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearAll();
                    sSearchTxt.Focus();
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
