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
    public partial class frmSearch : Form
    {
        Datahandler datahandler = new Datahandler();

        public frmSearch()
        {
            InitializeComponent();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            label2.Hide();
            textBox1.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label2.Text = "Insert Number:";
                label2.Show();
                textBox1.Show();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                label2.Text = "Insert Name:";
                label2.Show();
                textBox1.Show();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                label2.Text = "Insert Surname:";
                label2.Show();
                textBox1.Show();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                label2.Text = "Module:";
                label2.Show();
                textBox1.Show();
            }
            else
            {
                MessageBox.Show("Please select a value");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    throw new Exception("Please fill in all the fields");
                }
                else
                {
                   DataTable data = datahandler.SearchStudent(comboBox1.SelectedItem.ToString(),textBox1.Text);

                    dataGridView1.DataSource = data;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            Homefrm homepage = new Homefrm();
            homepage.Show();
            this.Hide();
        }
    }
}
