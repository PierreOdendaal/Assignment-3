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
using System.Data.SqlClient;

namespace Assignment_2
{
    public partial class Insertfrm : Form
    {
        Datahandler datahandler = new Datahandler();
        private byte[] Imagebytes;

        public Insertfrm()
        {
            InitializeComponent();
        }

        private void Insert_Load(object sender, EventArgs e)
        {

        }

        private void ConvertImagetoBytes(string filelocation)
        {


            try
            {
                Image image = Image.FromFile(filelocation);

                MemoryStream memory = new MemoryStream();

                image.Save(memory, System.Drawing.Imaging.ImageFormat.Png);

                Imagebytes = memory.ToArray();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

            

        }

        
        private void Uploadbtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    ConvertImagetoBytes(Pictureholder.ImageLocation = openFile.FileName);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void DisplayModuleAdded(Module module)
        {
            ListViewItem MeachRow = new ListViewItem(module.Code.ToString());

            MeachRow.SubItems.Add(module.Name);
            MeachRow.SubItems.Add(module.Description);
            MeachRow.SubItems.Add(module.Resources);

            ListViewForModules.Items.Add(MeachRow);
        }

        private void DisplayStudentAdded(Student student)
        {
            ListViewItem eachRow = new ListViewItem(student.Id.ToString());

            eachRow.SubItems.Add(student.Name);
            eachRow.SubItems.Add(student.Surname);
            eachRow.SubItems.Add(student.Dob.ToString("d"));
            eachRow.SubItems.Add(student.Gender);
            eachRow.SubItems.Add(student.PhoneNo.ToString());
            eachRow.SubItems.Add(student.Address);
            eachRow.SubItems.Add(student.Code.ToString());

            ListViewForStudent.Items.Add(eachRow);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Homefrm form1 = new Homefrm();
            this.Hide();
            form1.Show();
        }

        private void StudentAddbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(IDtxt.Text) || string.IsNullOrWhiteSpace(Nametxt.Text) || string.IsNullOrWhiteSpace(surnametxt.Text) || string.IsNullOrWhiteSpace(Codetxt.Text) ||
                string.IsNullOrWhiteSpace(DOBtxt.Value.ToString()) || string.IsNullOrWhiteSpace(genderbox.Text) || string.IsNullOrWhiteSpace(Phonetxt.Text) || string.IsNullOrWhiteSpace(addresstxt.Text) ||
                Pictureholder.Image == null
                )
                {
                    throw new NotAllFieldsAreFilled("Please fill in all the fields");
                }
                else
                {
                    Student student = new Student(Convert.ToInt32(IDtxt.Text),Nametxt.Text,surnametxt.Text,DOBtxt.Value,genderbox.SelectedItem.ToString(),Convert.ToInt64(Phonetxt.Text),Imagebytes,addresstxt.Text,Convert.ToInt32(Codetxt.Text));
                    
                    datahandler.InsertStudent(student);
                    DisplayStudentAdded(student);
                }
            }
            catch (NotAllFieldsAreFilled er)
            {
                MessageBox.Show(er.Message);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

        }

        private void exitform(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void ModuleAddbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(MoCodetxt.Text) || string.IsNullOrWhiteSpace(MoNametxt.Text) || string.IsNullOrWhiteSpace(descriptiontxt.Text) || string.IsNullOrWhiteSpace(Linkstxt.Text))
                {
                    throw new NotAllFieldsAreFilled("Please fill-in all the fields");
                }
                else
                {
                    Module module = new Module(Convert.ToInt32(MoCodetxt.Text),MoNametxt.Text,descriptiontxt.Text,Linkstxt.Text);
                    datahandler.InsertModule(module);
                    DisplayModuleAdded(module);
                }
            }
            catch (NotAllFieldsAreFilled er)
            {
                MessageBox.Show(er.Message);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }



        }

        private void ListViewForStudent_MouseClick(object sender, MouseEventArgs e)
        {
            IDtxt.Text = ListViewForStudent.SelectedItems[0].SubItems[0].Text;
            Nametxt.Text = ListViewForStudent.SelectedItems[0].SubItems[1].Text;
            surnametxt.Text = ListViewForStudent.SelectedItems[0].SubItems[2].Text;
            DOBtxt.Value = Convert.ToDateTime(ListViewForStudent.SelectedItems[0].SubItems[3].Text);
            genderbox.SelectedItem = ListViewForStudent.SelectedItems[0].SubItems[4].Text;
            Phonetxt.Text = ListViewForStudent.SelectedItems[0].SubItems[5].Text;
            addresstxt.Text = ListViewForStudent.SelectedItems[0].SubItems[6].Text;
            Codetxt.Text = ListViewForStudent.SelectedItems[0].SubItems[7].Text;
        }

        private void ListViewForModules_MouseClick(object sender, MouseEventArgs e)
        {
            MoCodetxt.Text = ListViewForModules.SelectedItems[0].SubItems[0].Text;
            MoNametxt.Text = ListViewForModules.SelectedItems[0].SubItems[1].Text;
            descriptiontxt.Text = ListViewForModules.SelectedItems[0].SubItems[2].Text;
            Linkstxt.Text = ListViewForModules.SelectedItems[0].SubItems[3].Text;
        }


    }
}
