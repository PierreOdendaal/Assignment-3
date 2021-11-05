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
    public partial class Updatefrm : Form
    {
        Datahandler datahandler = new Datahandler();

        public Updatefrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtSurname.Text))
                {
                    throw new Exception("Please fill in all the fields");
                }
                else
                { 
                    int id = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
                    datahandler.Update(id,txtName.Text,txtSurname.Text);
                    MessageBox.Show("Suucesfully Updated!!!");
                    Updatefrm_Load(sender, e);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void Updatefrm_Load(object sender, EventArgs e)
        {
          dataGridView1.DataSource=  datahandler.ReadView();
            for (int i = 3; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].Visible = false;
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtName.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                txtSurname.Text = dataGridView1[2, e.RowIndex].Value.ToString();


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
