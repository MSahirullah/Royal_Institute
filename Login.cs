using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Royal_Institute
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtuser.Text == "" && txtpass.Text == "")
                {
                    MainMenu main = new MainMenu();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password, Please Enter Correct Username or Password", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    txtpass.Text = "";
                    txtuser.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Username or Password, Please Enter Correct Username or Password", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                txtpass.Text = "";
                txtuser.Text = "";
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtuser;
        }

        public void checkEnter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
            }
        }
    }
}
