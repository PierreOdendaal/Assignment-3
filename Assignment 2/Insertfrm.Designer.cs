
namespace Assignment_2
{
    partial class Insertfrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Insertfrm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.genderbox = new System.Windows.Forms.ComboBox();
            this.DOBtxt = new System.Windows.Forms.DateTimePicker();
            this.StudentAddbtn = new System.Windows.Forms.Button();
            this.Codetxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Phonetxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.surnametxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.IDtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Uploadbtn = new System.Windows.Forms.Button();
            this.Pictureholder = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ListViewForStudent = new System.Windows.Forms.ListView();
            this.IDsd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Namesd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Surnamesd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DOBsd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gendersd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phonesd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Addresssd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Codesd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ListViewForModules = new System.Windows.Forms.ListView();
            this.codemi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.namemi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.des = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resourcemi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.descriptiontxt = new System.Windows.Forms.RichTextBox();
            this.ModuleAddbtn = new System.Windows.Forms.Button();
            this.Linkstxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.MoNametxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.MoCodetxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pictureholder)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.genderbox);
            this.groupBox1.Controls.Add(this.DOBtxt);
            this.groupBox1.Controls.Add(this.StudentAddbtn);
            this.groupBox1.Controls.Add(this.Codetxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.addresstxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Phonetxt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.surnametxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Nametxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.IDtxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Uploadbtn);
            this.groupBox1.Controls.Add(this.Pictureholder);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 531);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Info";
            // 
            // genderbox
            // 
            this.genderbox.FormattingEnabled = true;
            this.genderbox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderbox.Location = new System.Drawing.Point(229, 254);
            this.genderbox.Name = "genderbox";
            this.genderbox.Size = new System.Drawing.Size(160, 25);
            this.genderbox.TabIndex = 4;
            // 
            // DOBtxt
            // 
            this.DOBtxt.CustomFormat = "yyyy/mm/dd";
            this.DOBtxt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DOBtxt.Location = new System.Drawing.Point(15, 423);
            this.DOBtxt.Name = "DOBtxt";
            this.DOBtxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DOBtxt.Size = new System.Drawing.Size(155, 23);
            this.DOBtxt.TabIndex = 4;
            // 
            // StudentAddbtn
            // 
            this.StudentAddbtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentAddbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StudentAddbtn.Location = new System.Drawing.Point(130, 489);
            this.StudentAddbtn.Name = "StudentAddbtn";
            this.StudentAddbtn.Size = new System.Drawing.Size(120, 31);
            this.StudentAddbtn.TabIndex = 14;
            this.StudentAddbtn.Text = "Add Student";
            this.StudentAddbtn.UseVisualStyleBackColor = true;
            this.StudentAddbtn.Click += new System.EventHandler(this.StudentAddbtn_Click);
            // 
            // Codetxt
            // 
            this.Codetxt.Font = new System.Drawing.Font("Arial", 11F);
            this.Codetxt.Location = new System.Drawing.Point(229, 425);
            this.Codetxt.Multiline = true;
            this.Codetxt.Name = "Codetxt";
            this.Codetxt.Size = new System.Drawing.Size(160, 20);
            this.Codetxt.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11F);
            this.label5.Location = new System.Drawing.Point(226, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Module Code";
            // 
            // addresstxt
            // 
            this.addresstxt.Font = new System.Drawing.Font("Arial", 11F);
            this.addresstxt.Location = new System.Drawing.Point(229, 364);
            this.addresstxt.Multiline = true;
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(160, 25);
            this.addresstxt.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11F);
            this.label6.Location = new System.Drawing.Point(226, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Address";
            // 
            // Phonetxt
            // 
            this.Phonetxt.Font = new System.Drawing.Font("Arial", 11F);
            this.Phonetxt.Location = new System.Drawing.Point(229, 311);
            this.Phonetxt.MaxLength = 13;
            this.Phonetxt.Multiline = true;
            this.Phonetxt.Name = "Phonetxt";
            this.Phonetxt.Size = new System.Drawing.Size(160, 25);
            this.Phonetxt.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11F);
            this.label7.Location = new System.Drawing.Point(226, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Phone No.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11F);
            this.label8.Location = new System.Drawing.Point(226, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F);
            this.label3.Location = new System.Drawing.Point(12, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Date Of Birth";
            // 
            // surnametxt
            // 
            this.surnametxt.Font = new System.Drawing.Font("Arial", 11F);
            this.surnametxt.Location = new System.Drawing.Point(15, 364);
            this.surnametxt.Multiline = true;
            this.surnametxt.Name = "surnametxt";
            this.surnametxt.Size = new System.Drawing.Size(155, 25);
            this.surnametxt.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11F);
            this.label4.Location = new System.Drawing.Point(12, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Surname";
            // 
            // Nametxt
            // 
            this.Nametxt.Font = new System.Drawing.Font("Arial", 11F);
            this.Nametxt.Location = new System.Drawing.Point(15, 311);
            this.Nametxt.Multiline = true;
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(155, 25);
            this.Nametxt.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F);
            this.label1.Location = new System.Drawing.Point(12, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Name";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(125, 560);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 28);
            this.button2.TabIndex = 18;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // IDtxt
            // 
            this.IDtxt.Font = new System.Drawing.Font("Arial", 11F);
            this.IDtxt.Location = new System.Drawing.Point(12, 255);
            this.IDtxt.Multiline = true;
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.Size = new System.Drawing.Size(158, 24);
            this.IDtxt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11F);
            this.label2.Location = new System.Drawing.Point(12, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID";
            // 
            // Uploadbtn
            // 
            this.Uploadbtn.BackColor = System.Drawing.Color.Black;
            this.Uploadbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Uploadbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Uploadbtn.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uploadbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Uploadbtn.Location = new System.Drawing.Point(114, 182);
            this.Uploadbtn.Name = "Uploadbtn";
            this.Uploadbtn.Size = new System.Drawing.Size(153, 28);
            this.Uploadbtn.TabIndex = 1;
            this.Uploadbtn.Text = "Upload";
            this.Uploadbtn.UseVisualStyleBackColor = false;
            this.Uploadbtn.Click += new System.EventHandler(this.Uploadbtn_Click);
            // 
            // Pictureholder
            // 
            this.Pictureholder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Pictureholder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pictureholder.BackgroundImage")));
            this.Pictureholder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pictureholder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pictureholder.ErrorImage = null;
            this.Pictureholder.ImageLocation = "";
            this.Pictureholder.InitialImage = null;
            this.Pictureholder.Location = new System.Drawing.Point(114, 22);
            this.Pictureholder.Name = "Pictureholder";
            this.Pictureholder.Size = new System.Drawing.Size(153, 152);
            this.Pictureholder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pictureholder.TabIndex = 0;
            this.Pictureholder.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ListViewForStudent);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(438, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 172);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student Details";
            // 
            // ListViewForStudent
            // 
            this.ListViewForStudent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDsd,
            this.Namesd,
            this.Surnamesd,
            this.DOBsd,
            this.Gendersd,
            this.Phonesd,
            this.Addresssd,
            this.Codesd});
            this.ListViewForStudent.FullRowSelect = true;
            this.ListViewForStudent.HideSelection = false;
            this.ListViewForStudent.Location = new System.Drawing.Point(6, 33);
            this.ListViewForStudent.Name = "ListViewForStudent";
            this.ListViewForStudent.Size = new System.Drawing.Size(452, 134);
            this.ListViewForStudent.TabIndex = 0;
            this.ListViewForStudent.UseCompatibleStateImageBehavior = false;
            this.ListViewForStudent.View = System.Windows.Forms.View.Details;
            this.ListViewForStudent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListViewForStudent_MouseClick);
            // 
            // IDsd
            // 
            this.IDsd.Text = "Student ID";
            this.IDsd.Width = 70;
            // 
            // Namesd
            // 
            this.Namesd.Text = "Name";
            this.Namesd.Width = 100;
            // 
            // Surnamesd
            // 
            this.Surnamesd.Text = "Surname";
            this.Surnamesd.Width = 100;
            // 
            // DOBsd
            // 
            this.DOBsd.Text = "Date";
            this.DOBsd.Width = 100;
            // 
            // Gendersd
            // 
            this.Gendersd.Text = "Gender";
            this.Gendersd.Width = 100;
            // 
            // Phonesd
            // 
            this.Phonesd.Text = "Phone No.";
            this.Phonesd.Width = 100;
            // 
            // Addresssd
            // 
            this.Addresssd.Text = "Address";
            this.Addresssd.Width = 130;
            // 
            // Codesd
            // 
            this.Codesd.Text = "Module Code";
            this.Codesd.Width = 100;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ListViewForModules);
            this.groupBox3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(437, 350);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(464, 171);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Modules Details";
            // 
            // ListViewForModules
            // 
            this.ListViewForModules.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codemi,
            this.namemi,
            this.des,
            this.resourcemi});
            this.ListViewForModules.FullRowSelect = true;
            this.ListViewForModules.HideSelection = false;
            this.ListViewForModules.Location = new System.Drawing.Point(6, 31);
            this.ListViewForModules.Name = "ListViewForModules";
            this.ListViewForModules.Size = new System.Drawing.Size(452, 134);
            this.ListViewForModules.TabIndex = 1;
            this.ListViewForModules.UseCompatibleStateImageBehavior = false;
            this.ListViewForModules.View = System.Windows.Forms.View.Details;
            this.ListViewForModules.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListViewForModules_MouseClick);
            // 
            // codemi
            // 
            this.codemi.Text = "Module Code";
            this.codemi.Width = 105;
            // 
            // namemi
            // 
            this.namemi.Text = "Name ";
            this.namemi.Width = 107;
            // 
            // des
            // 
            this.des.Text = "Description ";
            this.des.Width = 115;
            // 
            // resourcemi
            // 
            this.resourcemi.Text = "Resources";
            this.resourcemi.Width = 105;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.descriptiontxt);
            this.groupBox4.Controls.Add(this.ModuleAddbtn);
            this.groupBox4.Controls.Add(this.Linkstxt);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.MoNametxt);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.MoCodetxt);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(919, 53);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(247, 531);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Module Info";
            // 
            // descriptiontxt
            // 
            this.descriptiontxt.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptiontxt.Location = new System.Drawing.Point(38, 309);
            this.descriptiontxt.Name = "descriptiontxt";
            this.descriptiontxt.Size = new System.Drawing.Size(174, 75);
            this.descriptiontxt.TabIndex = 14;
            this.descriptiontxt.Text = "";
            // 
            // ModuleAddbtn
            // 
            this.ModuleAddbtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.ModuleAddbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ModuleAddbtn.Location = new System.Drawing.Point(67, 489);
            this.ModuleAddbtn.Name = "ModuleAddbtn";
            this.ModuleAddbtn.Size = new System.Drawing.Size(120, 31);
            this.ModuleAddbtn.TabIndex = 5;
            this.ModuleAddbtn.Text = "New Module";
            this.ModuleAddbtn.UseMnemonic = false;
            this.ModuleAddbtn.UseVisualStyleBackColor = true;
            this.ModuleAddbtn.Click += new System.EventHandler(this.ModuleAddbtn_Click);
            // 
            // Linkstxt
            // 
            this.Linkstxt.AllowDrop = true;
            this.Linkstxt.Location = new System.Drawing.Point(40, 425);
            this.Linkstxt.Multiline = true;
            this.Linkstxt.Name = "Linkstxt";
            this.Linkstxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Linkstxt.Size = new System.Drawing.Size(175, 26);
            this.Linkstxt.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 398);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "Additional resources";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 273);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Description";
            // 
            // MoNametxt
            // 
            this.MoNametxt.Location = new System.Drawing.Point(38, 215);
            this.MoNametxt.Multiline = true;
            this.MoNametxt.Name = "MoNametxt";
            this.MoNametxt.Size = new System.Drawing.Size(175, 27);
            this.MoNametxt.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Name";
            // 
            // MoCodetxt
            // 
            this.MoCodetxt.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoCodetxt.Location = new System.Drawing.Point(38, 122);
            this.MoCodetxt.Multiline = true;
            this.MoCodetxt.Name = "MoCodetxt";
            this.MoCodetxt.Size = new System.Drawing.Size(175, 26);
            this.MoCodetxt.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Module Code";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Insertfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1188, 595);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Insertfrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.exitform);
            this.Load += new System.EventHandler(this.Insert_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pictureholder)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox IDtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Uploadbtn;
        private System.Windows.Forms.PictureBox Pictureholder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox surnametxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button StudentAddbtn;
        private System.Windows.Forms.TextBox Codetxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addresstxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Phonetxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView ListViewForStudent;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView ListViewForModules;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button ModuleAddbtn;
        private System.Windows.Forms.TextBox Linkstxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox MoNametxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox MoCodetxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox genderbox;
        private System.Windows.Forms.DateTimePicker DOBtxt;
        private System.Windows.Forms.RichTextBox descriptiontxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader IDsd;
        private System.Windows.Forms.ColumnHeader Namesd;
        private System.Windows.Forms.ColumnHeader Surnamesd;
        private System.Windows.Forms.ColumnHeader Gendersd;
        private System.Windows.Forms.ColumnHeader Phonesd;
        private System.Windows.Forms.ColumnHeader Addresssd;
        private System.Windows.Forms.ColumnHeader Codesd;
        private System.Windows.Forms.ColumnHeader codemi;
        private System.Windows.Forms.ColumnHeader namemi;
        private System.Windows.Forms.ColumnHeader des;
        private System.Windows.Forms.ColumnHeader resourcemi;
        private System.Windows.Forms.ColumnHeader DOBsd;
    }
}