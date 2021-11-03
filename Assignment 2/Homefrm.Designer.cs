
namespace Assignment_2
{
    partial class Homefrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homefrm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FirstRbtn = new System.Windows.Forms.Button();
            this.NextRbtn = new System.Windows.Forms.Button();
            this.PreviousRbtn = new System.Windows.Forms.Button();
            this.LastRbtn = new System.Windows.Forms.Button();
            this.Sortbased = new System.Windows.Forms.ComboBox();
            this.Ascending = new System.Windows.Forms.Button();
            this.Descending = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(614, 222);
            this.dataGridView1.TabIndex = 0;
            // 
            // FirstRbtn
            // 
            this.FirstRbtn.Font = new System.Drawing.Font("Agency FB", 15F);
            this.FirstRbtn.Location = new System.Drawing.Point(48, 271);
            this.FirstRbtn.Name = "FirstRbtn";
            this.FirstRbtn.Size = new System.Drawing.Size(109, 34);
            this.FirstRbtn.TabIndex = 2;
            this.FirstRbtn.Text = "First Record";
            this.FirstRbtn.UseVisualStyleBackColor = true;
            this.FirstRbtn.Click += new System.EventHandler(this.FirstRbtn_Click);
            // 
            // NextRbtn
            // 
            this.NextRbtn.Font = new System.Drawing.Font("Agency FB", 15F);
            this.NextRbtn.Location = new System.Drawing.Point(197, 272);
            this.NextRbtn.Name = "NextRbtn";
            this.NextRbtn.Size = new System.Drawing.Size(115, 33);
            this.NextRbtn.TabIndex = 3;
            this.NextRbtn.Text = "Next Record";
            this.NextRbtn.UseVisualStyleBackColor = true;
            this.NextRbtn.Click += new System.EventHandler(this.NextRbtn_Click);
            // 
            // PreviousRbtn
            // 
            this.PreviousRbtn.Font = new System.Drawing.Font("Agency FB", 15F);
            this.PreviousRbtn.Location = new System.Drawing.Point(353, 272);
            this.PreviousRbtn.Name = "PreviousRbtn";
            this.PreviousRbtn.Size = new System.Drawing.Size(125, 33);
            this.PreviousRbtn.TabIndex = 4;
            this.PreviousRbtn.Text = "Previous Record";
            this.PreviousRbtn.UseVisualStyleBackColor = true;
            this.PreviousRbtn.Click += new System.EventHandler(this.PreviousRbtn_Click);
            // 
            // LastRbtn
            // 
            this.LastRbtn.Font = new System.Drawing.Font("Agency FB", 15F);
            this.LastRbtn.Location = new System.Drawing.Point(522, 271);
            this.LastRbtn.Name = "LastRbtn";
            this.LastRbtn.Size = new System.Drawing.Size(140, 33);
            this.LastRbtn.TabIndex = 5;
            this.LastRbtn.Text = "Last Record";
            this.LastRbtn.UseVisualStyleBackColor = true;
            this.LastRbtn.Click += new System.EventHandler(this.LastRbtn_Click);
            // 
            // Sortbased
            // 
            this.Sortbased.FormattingEnabled = true;
            this.Sortbased.Location = new System.Drawing.Point(925, 87);
            this.Sortbased.Name = "Sortbased";
            this.Sortbased.Size = new System.Drawing.Size(151, 21);
            this.Sortbased.TabIndex = 6;
            // 
            // Ascending
            // 
            this.Ascending.Location = new System.Drawing.Point(925, 190);
            this.Ascending.Name = "Ascending";
            this.Ascending.Size = new System.Drawing.Size(151, 23);
            this.Ascending.TabIndex = 7;
            this.Ascending.Text = "Ascending Order ";
            this.Ascending.UseVisualStyleBackColor = true;
            this.Ascending.Click += new System.EventHandler(this.Ascending_Click);
            // 
            // Descending
            // 
            this.Descending.Location = new System.Drawing.Point(925, 229);
            this.Descending.Name = "Descending";
            this.Descending.Size = new System.Drawing.Size(151, 23);
            this.Descending.TabIndex = 8;
            this.Descending.Text = "Descending Order";
            this.Descending.UseVisualStyleBackColor = true;
            this.Descending.Click += new System.EventHandler(this.Descending_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.flowLayoutPanel4);
            this.panel1.Controls.Add(this.flowLayoutPanel3);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Location = new System.Drawing.Point(48, 459);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 85);
            this.panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.label2.Location = new System.Drawing.Point(289, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 31);
            this.label2.TabIndex = 15;
            this.label2.Text = "Update Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.label3.Location = new System.Drawing.Point(539, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 31);
            this.label3.TabIndex = 16;
            this.label3.Text = "Delete Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.label4.Location = new System.Drawing.Point(807, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 31);
            this.label4.TabIndex = 17;
            this.label4.Text = "Search Details";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(13, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 72);
            this.panel2.TabIndex = 13;
            this.panel2.Click += new System.EventHandler(this.Insertform);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Add Details";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(766, 7);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(224, 72);
            this.flowLayoutPanel4.TabIndex = 12;
            this.flowLayoutPanel4.Click += new System.EventHandler(this.SearchNewForm);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(500, 7);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(224, 72);
            this.flowLayoutPanel3.TabIndex = 12;
            this.flowLayoutPanel3.Click += new System.EventHandler(this.DeleteNewForm);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(255, 7);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(224, 72);
            this.flowLayoutPanel2.TabIndex = 11;
            this.flowLayoutPanel2.Click += new System.EventHandler(this.UpdateNewForm);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(921, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sort By?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(697, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(13, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Homefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1173, 570);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Descending);
            this.Controls.Add(this.Ascending);
            this.Controls.Add(this.Sortbased);
            this.Controls.Add(this.LastRbtn);
            this.Controls.Add(this.PreviousRbtn);
            this.Controls.Add(this.NextRbtn);
            this.Controls.Add(this.FirstRbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Homefrm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClosingHomeForm);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button FirstRbtn;
        private System.Windows.Forms.Button NextRbtn;
        private System.Windows.Forms.Button PreviousRbtn;
        private System.Windows.Forms.Button LastRbtn;
        private System.Windows.Forms.ComboBox Sortbased;
        private System.Windows.Forms.Button Ascending;
        private System.Windows.Forms.Button Descending;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

