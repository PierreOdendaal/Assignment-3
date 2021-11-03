using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class frmPassword : Form
    {
        public frmPassword()
        {
            InitializeComponent();
        }

        private void frmPassword_Load(object sender, EventArgs e)
        {
            lblPassword.Hide();
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            string Name = txtUsernamecheck.Text;
            List<Users> userobj = new List<Users>();
            Users user = new Users();
            userobj = user.PopulateUsers();
            bool isValid = false;
            foreach (Users userInstance in userobj)
            {
                if (userInstance.Name == Name && txtAlphabet.Text == "abcdefg" && txtPicture.Text == "AbCxYZ1" && txtSeventy.Text == "seventy")
                {
                    isValid = true;
                    lblPassword.Show();
                    lblPassword.Text = userInstance.Password;
                    break;
                }
            }
            if (isValid)
            {

            }
            else
            {
                DialogResult dr = MessageBox.Show("Username does not exist");
                if (dr == DialogResult.Retry)
                {
                    txtUsernamecheck.Clear();
                    txtUsernamecheck.Focus();
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)//Login form
        {
            frmLoginForm login = new frmLoginForm();
            login.Show();
            this.Hide();
        }

        private void lblCreateAccount_Click(object sender, EventArgs e)
        {
            frmRegistration register = new frmRegistration();
            register.Show();
            this.Hide();
        }
    }
}
