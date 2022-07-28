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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Royal_Institute\RoyalDatabase.mdf;Integrated Security=True");

        private void MainMenu_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand comm = new SqlCommand("SELECT COUNT(*) FROM Teachers", con);
                Int32 teachCount = (Int32)comm.ExecuteScalar();

                SqlCommand comm2 = new SqlCommand("SELECT COUNT(*) FROM Students", con);
                Int32 stuCount = (Int32)comm2.ExecuteScalar();

                totTeachTxt.Text = teachCount.ToString();
                totStuTxt.Text = stuCount.ToString();
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

        private void btnStu_Click(object sender, EventArgs e)
        {
            Students stu = new Students();
            stu.Show();
            this.Hide();
        }

        private void btnTeach_Click(object sender, EventArgs e)
        {
            Teachers teach = new Teachers();
            teach.Show();
            this.Hide();
        }

        private void btnStuFees_Click(object sender, EventArgs e)
        {
            StudentFees stuF = new StudentFees();
            stuF.Show();
            this.Hide();
        }

        private void btnTeachPayment_Click(object sender, EventArgs e)
        {
            TeacherPayments TeachP = new TeacherPayments();
            TeachP.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
