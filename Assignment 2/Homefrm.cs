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
using System.IO;


namespace Assignment_2
{
    public partial class Homefrm : Form
    {
        Datahandler datahandler = new Datahandler();
        BindingSource source = new BindingSource();
        public string username;

        public Homefrm()
        {
            InitializeComponent();

        }


        private void Insertform(object sender, EventArgs e)
        {
            Insertfrm insert = new Insertfrm();

            this.Hide();
            insert.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label6.Text = username;

            LoadData();
        }

        private void LoadData()
        {
            source.DataSource = datahandler.ReadView();

            dataGridView1.DataSource = source;

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                Sortbased.Items.Add(dataGridView1.Columns[i].Name);
            }
        }

        private void loadpicture(int id)
        {
            byte[] img = datahandler.Picture_Loader(id);

            if (img != null)
            {
                MemoryStream memory = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(memory);
            }
            
        }

        private void FirstRbtn_Click(object sender, EventArgs e)
        {
            if (source.Count > 0)
            {
                source.MoveFirst();
                loadpicture(Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value));
            }
        }

        private void NextRbtn_Click(object sender, EventArgs e)
        {
            if (source.Count > 0)
            {
                source.MoveNext();
                loadpicture(Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value));
            }
                
           
        }

        private void PreviousRbtn_Click(object sender, EventArgs e)
        {
            if (source.Count > 0)
            {
                source.MovePrevious();
                loadpicture(Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value));
            }
        }

        private void LastRbtn_Click(object sender, EventArgs e)
        {
            if (source.Count > 0)
            {
                source.MoveLast();
                loadpicture(Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value));
            }
        }

        private void Ascending_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Sortbased.Text))
                {
                    throw new Exception("Please fill in all the fields");
                }
                else
                {
                    dataGridView1.Sort(dataGridView1.Columns[Sortbased.Text],ListSortDirection.Ascending);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void Descending_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Sortbased.Text))
                {
                    throw new Exception("Please fill in all the fields");
                }
                else
                {
                    dataGridView1.Sort(dataGridView1.Columns[Sortbased.Text], ListSortDirection.Descending);
                }
            }
            catch (Exception er) 
            {
                MessageBox.Show(er.Message);
            }
        }

        private void ClosingHomeForm(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void UpdateNewForm(object sender, EventArgs e)
        {
            // Crodia, you will connect your update form to this method 
            // So just call your form and it will automatically hide this form


            this.Hide();

        }

        private void DeleteNewForm(object sender, EventArgs e)
        {
            // Crodia, you will connect your delete form to this method 
            // So just call your form and it will automatically hide this form

            this.Hide();
        }

        private void SearchNewForm(object sender, EventArgs e)
        {
            frmSearch search = new frmSearch();
            this.Hide();
            search.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            frmLoginForm login = new frmLoginForm();
            this.Hide();
            login.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
