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
    public partial class Teachers : Form
    {
        public Teachers()
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

        void fname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back) || e.KeyChar == 13;
        }
        void lname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back) || e.KeyChar == 13;
        }

        void teachClass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || e.KeyChar == 13)
            {
                e.Handled = true;
            }
        }
        void teachSub_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back) || e.KeyChar == 13;
        }

        void cnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || e.KeyChar == 13)
            {
                e.Handled = true;
            }
        }
        void id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || e.KeyChar == 13)
            {
                e.Handled = true;
            }
        }
        void tSearchTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || e.KeyChar == 13)
            {
                e.Handled = true;
            }
        }

        private void Teachers_Load(object sender, EventArgs e)
        {
            try
            {
                this.ActiveControl = tIdTxt;
                con.Open();

                string q = "SELECT ID as 'Teacher ID', FirstName as 'First Name', LastName as 'Last Name', TeachingClasses as 'Grades', TeachingSubject as 'Subject', Address, Contact, Email FROM Teachers ORDER BY ID DESC";
                SqlDataAdapter ada = new SqlDataAdapter(q, con);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                TeacherDataGrid.DataSource = dt;

                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Something went worng. Please try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ClearAll()
        {
            tIdTxt.Text = "";
            tIdTxt.Enabled = true;
            tIdTxt.Focus();
            tFNameTxt.Text = "";
            tLNametxt.Text = "";
            tClassesCombo.Text = "";
            tSubCombo.Text = "";
            tAddressTxt.Text = "";
            tEmailTxt.Text = "";
            tNumberTxt.Text = "";
        }
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ClearAll();
            tSearchTxt.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string id = tIdTxt.Text;                

                string q = "SELECT * FROM Teachers WHERE ID = '" + id + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataReader r = cmd.ExecuteReader();

                if (r.HasRows)
                {
                    MessageBox.Show("The Teacher ID already exists.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    r.Close();
                }
                else
                {
                    r.Close();
                    string fName = tFNameTxt.Text;
                    string lName = tLNametxt.Text;
                    string teachs = tSubCombo.Text;
                    string teachc = tClassesCombo.Text;
                    string address = tAddressTxt.Text;
                    string email = tEmailTxt.Text;
                    string phone = tNumberTxt.Text;

                    if (id == "" || fName == "" || lName == "" || teachc == "" || teachs == "" || address == "" || email == "" || phone == "")
                    {
                        MessageBox.Show("Please fill out all the information.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string inQ = "INSERT INTO Teachers VALUES('" + id + "','" + fName + "','" + lName + "','" + teachc + "','" + teachs + "','" + address + "','" + phone + "','" + email + "')";
                        SqlCommand cmmd = new SqlCommand(inQ, con);
                        cmmd.ExecuteNonQuery();
                        MessageBox.Show("Saved successfully!", "Done!", MessageBoxButtons.OK);

                        SqlDataAdapter ada = new SqlDataAdapter("SELECT ID as 'Teacher ID', FirstName as 'First Name', LastName as 'Last Name', TeachingClasses as 'Grades', TeachingSubject as 'Subject', Address, Contact, Email FROM Teachers ORDER BY ID DESC", con);
                        DataTable dt = new DataTable();
                        ada.Fill(dt);
                        TeacherDataGrid.DataSource = dt;

                        ClearAll();
                        tSearchTxt.Text = "";
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string id = tIdTxt.Text;
                string fName = tFNameTxt.Text;
                string lName = tLNametxt.Text;
                string teachs = tSubCombo.Text;
                string teachc = tClassesCombo.Text;
                string address = tAddressTxt.Text;
                string email = tEmailTxt.Text;
                string phone = tNumberTxt.Text;

                string q = "SELECT * FROM Teachers WHERE ID = '" + id + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataReader r = cmd.ExecuteReader();

                if (!r.HasRows)
                {
                    MessageBox.Show("Please select a Teacher to update.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    r.Close();
                }
                else if (id == "" || fName == "" || lName == "" || teachc == "" || teachs == "" || address == "" || email == "" || phone == "")
                {
                    r.Close();
                    MessageBox.Show("Please fill out all the information", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    r.Close();
                    string inQ = "UPDATE Teachers set  FirstName =  '" + fName + "', LastName = '" + lName + "', TeachingClasses = '" + teachc + "', TeachingSubject = '" + teachs + "', Address = '" + address + "', Contact = '" + phone + "', Email ='" + email +"' WHERE ID = '" + id + "'";

                    SqlCommand cmmd = new SqlCommand(inQ, con);
                    cmmd.ExecuteNonQuery();
                    MessageBox.Show("Updated successfully!", "Done!", MessageBoxButtons.OK);

                    SqlDataAdapter ada = new SqlDataAdapter("SELECT ID as 'Teacher ID', FirstName as 'First Name', LastName as 'Last Name', TeachingClasses as 'Grades', TeachingSubject as 'Subject', Address, Contact, Email FROM Teachers ORDER BY ID DESC", con);
                    DataTable dt = new DataTable();
                    ada.Fill(dt);
                    TeacherDataGrid.DataSource = dt;
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
                string id = tIdTxt.Text;

                string q = "SELECT * FROM Teachers WHERE ID = '" + id + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataReader r = cmd.ExecuteReader();

                if (!r.HasRows)
                {
                    MessageBox.Show("Please select a Teacher to delete.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    r.Close();
                }
                else
                {
                    r.Close();
                    var confirmResult = MessageBox.Show("Are you sure to delete this Teacher?", "Confirm Delete!", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        string inQ = "DELETE from Teachers WHERE ID = '" + id + "'";

                        SqlCommand cmmd = new SqlCommand(inQ, con);
                        cmmd.ExecuteNonQuery();
                        MessageBox.Show("Deleted successfully!", "Done!", MessageBoxButtons.OK);

                        SqlDataAdapter ada = new SqlDataAdapter("SELECT ID as 'Teacher ID', FirstName as 'First Name', LastName as 'Last Name',TeachingClasses as 'Grades', TeachingSubject as 'Subject', Address, Contact, Email FROM Teachers ORDER BY ID DESC", con);
                        DataTable dt = new DataTable();
                        ada.Fill(dt);
                        TeacherDataGrid.DataSource = dt;

                        ClearAll();
                        tSearchTxt.Text = "";
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string id = tSearchTxt.Text;

                string q = "SELECT * FROM Teachers WHERE ID = '" + id + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataReader r = cmd.ExecuteReader();

                if (r.HasRows)
                {
                    int x = 0;
                    while (r.Read())
                    {
                        if (x == 0)
                        {
                            tIdTxt.Text = r[0].ToString();
                            tIdTxt.Enabled = false;
                            tFNameTxt.Text = r[1].ToString();
                            tLNametxt.Text = r[2].ToString();
                            tClassesCombo.Text = r[3].ToString();
                            tSubCombo.Text = r[4].ToString();
                            tAddressTxt.Text = r[5].ToString();
                            tEmailTxt.Text = r[7].ToString();
                            tNumberTxt.Text = r[6].ToString();
                            tSearchTxt.Text = r[0].ToString();
                        }
                        x++;
                    }
                    r.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Teacher ID!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearAll();
                    tSearchTxt.Focus();
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

        private void TeacherDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                if (index != -1)
                {
                    DataGridViewRow selectedRow = TeacherDataGrid.Rows[index];

                    tIdTxt.Text = selectedRow.Cells[0].Value.ToString();
                    tIdTxt.Enabled = false;
                    tFNameTxt.Text = selectedRow.Cells[1].Value.ToString();
                    tLNametxt.Text = selectedRow.Cells[2].Value.ToString();

                    tClassesCombo.Text = selectedRow.Cells[3].Value.ToString();
                    tSubCombo.Text = selectedRow.Cells[4].Value.ToString();

                    tAddressTxt.Text = selectedRow.Cells[5].Value.ToString();
                    tEmailTxt.Text = selectedRow.Cells[7].Value.ToString();
                    tNumberTxt.Text = selectedRow.Cells[6].Value.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went worng. Please try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
