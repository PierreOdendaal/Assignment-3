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
    public partial class frmDelete : Form
    {
        public frmDelete()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var Status= MessageBox.Show("Are you sure you would like to delete this student?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Status==DialogResult.Yes)
                {
                    Datahandler datahandler = new Datahandler();
                    datahandler.Delete(Convert.ToInt32(IDSelector.Value));
                    MessageBox.Show("Student was succesfully deleted");

                }
                else
                {
                    MessageBox.Show("Student not deleted");
                }

            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message);
            }
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            Homefrm homepage = new Homefrm();
            homepage.Show();
            this.Hide();

        }
    }
}
