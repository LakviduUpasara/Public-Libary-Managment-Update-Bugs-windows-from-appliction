namespace Public_Libary_managment_System
{
    partial class DashBord
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


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserManagmentbtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LabrianManagment = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.DataGriedVewBookDeatail = new System.Windows.Forms.DataGridView();
            this.Retrunbookbtn = new System.Windows.Forms.Button();
            this.Refeshbtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Label();
            this.Upmanagmentlbl = new System.Windows.Forms.Label();
            this.UserNamelbl = new System.Windows.Forms.Label();
            this.userrolelbl = new System.Windows.Forms.Label();
            this.todaylbl = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textsearxh = new System.Windows.Forms.TextBox();
            this.bacggroundpic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGriedVewBookDeatail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bacggroundpic)).BeginInit();
            this.SuspendLayout();
            // 
            // UserManagmentbtn
            // 
            this.UserManagmentbtn.Location = new System.Drawing.Point(468, 155);
            this.UserManagmentbtn.Name = "UserManagmentbtn";
            this.UserManagmentbtn.Size = new System.Drawing.Size(225, 92);
            this.UserManagmentbtn.TabIndex = 0;
            this.UserManagmentbtn.Text = "User Managment";
            this.UserManagmentbtn.UseVisualStyleBackColor = true;
            this.UserManagmentbtn.Click += new System.EventHandler(this.UserManagmentbtn_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.Location = new System.Drawing.Point(29, 648);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 100);
            this.button2.TabIndex = 0;
            this.button2.Text = "Book Managment";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LabrianManagment
            // 
            this.LabrianManagment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabrianManagment.Location = new System.Drawing.Point(1034, 158);
            this.LabrianManagment.Name = "LabrianManagment";
            this.LabrianManagment.Size = new System.Drawing.Size(234, 92);
            this.LabrianManagment.TabIndex = 0;
            this.LabrianManagment.Text = "Attendence";
            this.LabrianManagment.UseVisualStyleBackColor = true;
            this.LabrianManagment.Click += new System.EventHandler(this.LabrianManagment_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button3.Location = new System.Drawing.Point(29, 275);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(236, 103);
            this.button3.TabIndex = 0;
            this.button3.Text = "Reader Mangment";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button5.Location = new System.Drawing.Point(29, 396);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(236, 100);
            this.button5.TabIndex = 39;
            this.button5.Text = "Author Managment";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button6.Location = new System.Drawing.Point(29, 522);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(236, 100);
            this.button6.TabIndex = 39;
            this.button6.Text = "Publisher Managment";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button4.Location = new System.Drawing.Point(28, 764);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(236, 100);
            this.button4.TabIndex = 0;
            this.button4.Text = "Issue Book";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // DataGriedVewBookDeatail
            // 
            this.DataGriedVewBookDeatail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGriedVewBookDeatail.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DataGriedVewBookDeatail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGriedVewBookDeatail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGriedVewBookDeatail.Location = new System.Drawing.Point(334, 384);
            this.DataGriedVewBookDeatail.Name = "DataGriedVewBookDeatail";
            this.DataGriedVewBookDeatail.RowHeadersWidth = 62;
            this.DataGriedVewBookDeatail.RowTemplate.Height = 28;
            this.DataGriedVewBookDeatail.Size = new System.Drawing.Size(1414, 636);
            this.DataGriedVewBookDeatail.TabIndex = 40;
            // 
            // Retrunbookbtn
            // 
            this.Retrunbookbtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Retrunbookbtn.Location = new System.Drawing.Point(29, 904);
            this.Retrunbookbtn.Name = "Retrunbookbtn";
            this.Retrunbookbtn.Size = new System.Drawing.Size(236, 102);
            this.Retrunbookbtn.TabIndex = 0;
            this.Retrunbookbtn.Text = "Retun Book";
            this.Retrunbookbtn.UseVisualStyleBackColor = true;
            this.Retrunbookbtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // Refeshbtn
            // 
            this.Refeshbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Refeshbtn.Location = new System.Drawing.Point(1610, 312);
            this.Refeshbtn.Name = "Refeshbtn";
            this.Refeshbtn.Size = new System.Drawing.Size(140, 46);
            this.Refeshbtn.TabIndex = 42;
            this.Refeshbtn.Text = "Refesh";
            this.Refeshbtn.UseVisualStyleBackColor = true;
            this.Refeshbtn.Click += new System.EventHandler(this.Refeshbtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBtn.Location = new System.Drawing.Point(1432, 312);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(146, 46);
            this.SearchBtn.TabIndex = 43;
            this.SearchBtn.Text = "Search ";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // LogOut
            // 
            this.LogOut.AutoSize = true;
            this.LogOut.BackColor = System.Drawing.Color.LightPink;
            this.LogOut.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.Location = new System.Drawing.Point(147, 151);
            this.LogOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(118, 32);
            this.LogOut.TabIndex = 45;
            this.LogOut.Text = "Log Out";
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // Upmanagmentlbl
            // 
            this.Upmanagmentlbl.AutoSize = true;
            this.Upmanagmentlbl.BackColor = System.Drawing.Color.White;
            this.Upmanagmentlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Upmanagmentlbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upmanagmentlbl.Location = new System.Drawing.Point(56, 185);
            this.Upmanagmentlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Upmanagmentlbl.Name = "Upmanagmentlbl";
            this.Upmanagmentlbl.Size = new System.Drawing.Size(205, 34);
            this.Upmanagmentlbl.TabIndex = 45;
            this.Upmanagmentlbl.Text = "Manage Profile";
            this.Upmanagmentlbl.Click += new System.EventHandler(this.Upmanagmentlbl_Click);
            // 
            // UserNamelbl
            // 
            this.UserNamelbl.AutoSize = true;
            this.UserNamelbl.BackColor = System.Drawing.Color.White;
            this.UserNamelbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNamelbl.Location = new System.Drawing.Point(272, 75);
            this.UserNamelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserNamelbl.Name = "UserNamelbl";
            this.UserNamelbl.Size = new System.Drawing.Size(149, 32);
            this.UserNamelbl.TabIndex = 45;
            this.UserNamelbl.Text = "User Name";
            // 
            // userrolelbl
            // 
            this.userrolelbl.AutoSize = true;
            this.userrolelbl.BackColor = System.Drawing.Color.White;
            this.userrolelbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userrolelbl.Location = new System.Drawing.Point(272, 14);
            this.userrolelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userrolelbl.Name = "userrolelbl";
            this.userrolelbl.Size = new System.Drawing.Size(133, 32);
            this.userrolelbl.TabIndex = 45;
            this.userrolelbl.Text = "User Role";
            // 
            // todaylbl
            // 
            this.todaylbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.todaylbl.AutoSize = true;
            this.todaylbl.BackColor = System.Drawing.Color.White;
            this.todaylbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.todaylbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todaylbl.Location = new System.Drawing.Point(1533, 94);
            this.todaylbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.todaylbl.Name = "todaylbl";
            this.todaylbl.Size = new System.Drawing.Size(74, 34);
            this.todaylbl.TabIndex = 45;
            this.todaylbl.Text = "Date";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(3, 1);
            this.monthCalendar1.Location = new System.Drawing.Point(441, 14);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 47;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.Image = global::Public_Libary_managment_System.Properties.Resources.th__4_;
            this.pictureBox3.Location = new System.Drawing.Point(1083, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 132);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Public_Libary_managment_System.Properties.Resources.th__5_;
            this.pictureBox2.Location = new System.Drawing.Point(502, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(158, 132);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Public_Libary_managment_System.Properties.Resources.th__2_;
            this.pictureBox1.Location = new System.Drawing.Point(16, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textsearxh
            // 
            this.textsearxh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textsearxh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textsearxh.Location = new System.Drawing.Point(334, 318);
            this.textsearxh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textsearxh.Name = "textsearxh";
            this.textsearxh.Size = new System.Drawing.Size(1063, 35);
            this.textsearxh.TabIndex = 48;
            // 
            // bacggroundpic
            // 
            this.bacggroundpic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bacggroundpic.Image = global::Public_Libary_managment_System.Properties.Resources._0Wonwb;
            this.bacggroundpic.Location = new System.Drawing.Point(0, 0);
            this.bacggroundpic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bacggroundpic.Name = "bacggroundpic";
            this.bacggroundpic.Size = new System.Drawing.Size(1764, 1246);
            this.bacggroundpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bacggroundpic.TabIndex = 49;
            this.bacggroundpic.TabStop = false;
            // 
            // DashBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1766, 1050);
            this.Controls.Add(this.textsearxh);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.todaylbl);
            this.Controls.Add(this.userrolelbl);
            this.Controls.Add(this.UserNamelbl);
            this.Controls.Add(this.Upmanagmentlbl);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.Refeshbtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.DataGriedVewBookDeatail);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LabrianManagment);
            this.Controls.Add(this.Retrunbookbtn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.UserManagmentbtn);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.bacggroundpic);
            this.Name = "DashBord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBord";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DashBord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGriedVewBookDeatail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bacggroundpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        private System.Windows.Forms.Button UserManagmentbtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button LabrianManagment;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView DataGriedVewBookDeatail;
        private System.Windows.Forms.Button Retrunbookbtn;
        private System.Windows.Forms.Button Refeshbtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label LogOut;
        private System.Windows.Forms.Label Upmanagmentlbl;
        private System.Windows.Forms.Label UserNamelbl;
        private System.Windows.Forms.Label userrolelbl;
        private System.Windows.Forms.Label todaylbl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox textsearxh;
        private System.Windows.Forms.PictureBox bacggroundpic;
    }
}