using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment_2
{
    public partial class frmLoginForm : Form
    {
        List<Users> userlist = new List<Users>();
        public frmLoginForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)//Create An Account
        {
            frmRegistration register = new frmRegistration();
            register.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)//Login
        {
            string Name = txtUsername.Text;
            string Password = txtPassword.Text;
            List<Users> userobj = new List<Users>();
            Users user = new Users();
            userobj = user.PopulateUsers();
            bool isValid = false;
            foreach (Users userInstance in userobj)
            {
                if (userInstance.Name == Name && userInstance.Password == Password)
                {
                    isValid = true;
                }
            }
            if (isValid)
            {
                Homefrm home = new Homefrm();
                home.username ="Sign Out " + Name;
                this.Hide();
                home.Show();
            }
            else
            {
                DialogResult dr = MessageBox.Show("Invalid Username and Password");
                if (dr == DialogResult.Retry)
                {
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void lblForgotPass_Click(object sender, EventArgs e)
        {
            frmPassword passw = new frmPassword();
            passw.Show();
            this.Hide();
        }
    }
}
