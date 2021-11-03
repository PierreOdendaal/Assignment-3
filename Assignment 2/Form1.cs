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
    public partial class frmRegistration : Form
    {
        List<Users> userlist = new List<Users>();
        frmLoginForm login = new frmLoginForm(); 
        Filehandler fh = new Filehandler();
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void lblLoginForm_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPassword.Text != "" && txtConfirmPass.Text == txtPassword.Text)
            {
                string name = txtUsername.Text;
                string password = txtPassword.Text;

                Users NewUser = new Users(name, password);

                userlist.Add(NewUser);
                fh.Writer(userlist);

                login.Show();
                this.Hide();
            }
            else
            {
                if (txtConfirmPass.Text != txtPassword.Text)
                {
                    MessageBox.Show("Passwords do not match");

                    txtConfirmPass.Clear();
                }
                else
                {
                    MessageBox.Show("Please fill in all the required fields");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
