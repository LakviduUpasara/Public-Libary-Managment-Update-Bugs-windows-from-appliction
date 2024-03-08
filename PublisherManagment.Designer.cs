namespace Public_Libary_managment_System
{
    partial class PublisherManagment
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
            this.AuthorManagmntbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textsearch = new System.Windows.Forms.TextBox();
            this.PublisherGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ConFrombtn = new Public_Libary_managment_System.DoubleClickButton();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textpublisherName = new System.Windows.Forms.TextBox();
            this.deletebtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textpublisherothername = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.TextpublisherId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Backbtn = new System.Windows.Forms.Button();
            this.DeletePublisher = new System.Windows.Forms.Button();
            this.Refeshbtn = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.editPublisher = new System.Windows.Forms.Button();
            this.textfill = new System.Windows.Forms.TextBox();
            this.AddPublisher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.RederManagmentbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PublisherGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AuthorManagmntbtn
            // 
            this.AuthorManagmntbtn.Location = new System.Drawing.Point(390, 557);
            this.AuthorManagmntbtn.Name = "AuthorManagmntbtn";
            this.AuthorManagmntbtn.Size = new System.Drawing.Size(166, 58);
            this.AuthorManagmntbtn.TabIndex = 61;
            this.AuthorManagmntbtn.Text = "Author Managment";
            this.AuthorManagmntbtn.UseVisualStyleBackColor = true;
            this.AuthorManagmntbtn.Click += new System.EventHandler(this.AuthorManagmntbtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1230, 568);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 35);
            this.button1.TabIndex = 49;
            this.button1.Text = "Fill Detail";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textsearch
            // 
            this.textsearch.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textsearch.Location = new System.Drawing.Point(400, 182);
            this.textsearch.Name = "textsearch";
            this.textsearch.Size = new System.Drawing.Size(526, 35);
            this.textsearch.TabIndex = 59;
            // 
            // PublisherGridView1
            // 
            this.PublisherGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.PublisherGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PublisherGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PublisherGridView1.Location = new System.Drawing.Point(400, 229);
            this.PublisherGridView1.Name = "PublisherGridView1";
            this.PublisherGridView1.RowHeadersWidth = 62;
            this.PublisherGridView1.RowTemplate.Height = 28;
            this.PublisherGridView1.Size = new System.Drawing.Size(768, 265);
            this.PublisherGridView1.TabIndex = 58;
            this.PublisherGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PublisherGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ConFrombtn);
            this.panel1.Controls.Add(this.Clearbtn);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.textpublisherName);
            this.panel1.Controls.Add(this.deletebtn);
            this.panel1.Controls.Add(this.Updatebtn);
            this.panel1.Controls.Add(this.Savebtn);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textpublisherothername);
            this.panel1.Controls.Add(this.panel12);
            this.panel1.Controls.Add(this.TextpublisherId);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(585, 614);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 298);
            this.panel1.TabIndex = 57;
            // 
            // ConFrombtn
            // 
            this.ConFrombtn.Location = new System.Drawing.Point(454, 206);
            this.ConFrombtn.Name = "ConFrombtn";
            this.ConFrombtn.Size = new System.Drawing.Size(160, 49);
            this.ConFrombtn.TabIndex = 47;
            this.ConFrombtn.Text = "Confrom";
            this.ConFrombtn.UseVisualStyleBackColor = true;
            // 
            // Clearbtn
            // 
            this.Clearbtn.Location = new System.Drawing.Point(646, 206);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(160, 48);
            this.Clearbtn.TabIndex = 11;
            this.Clearbtn.Text = "Clear Deatail";
            this.Clearbtn.UseVisualStyleBackColor = true;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(346, 137);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(458, 5);
            this.panel4.TabIndex = 44;
            // 
            // textpublisherName
            // 
            this.textpublisherName.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpublisherName.Location = new System.Drawing.Point(346, 98);
            this.textpublisherName.Name = "textpublisherName";
            this.textpublisherName.Size = new System.Drawing.Size(462, 35);
            this.textpublisherName.TabIndex = 41;
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(454, 205);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(160, 48);
            this.deletebtn.TabIndex = 11;
            this.deletebtn.Text = "Delete Deatail";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.Location = new System.Drawing.Point(454, 205);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(160, 48);
            this.Updatebtn.TabIndex = 11;
            this.Updatebtn.Text = "Update Deatail";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.Location = new System.Drawing.Point(454, 205);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(160, 48);
            this.Savebtn.TabIndex = 11;
            this.Savebtn.Text = "Save  Deatail";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(346, 188);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(458, 5);
            this.panel5.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Californian FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 33);
            this.label6.TabIndex = 0;
            this.label6.Text = "Publisher other Name";
            // 
            // textpublisherothername
            // 
            this.textpublisherothername.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpublisherothername.Location = new System.Drawing.Point(346, 148);
            this.textpublisherothername.Name = "textpublisherothername";
            this.textpublisherothername.Size = new System.Drawing.Size(462, 35);
            this.textpublisherothername.TabIndex = 42;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Black;
            this.panel12.Location = new System.Drawing.Point(346, 88);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(458, 5);
            this.panel12.TabIndex = 46;
            // 
            // TextpublisherId
            // 
            this.TextpublisherId.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextpublisherId.Location = new System.Drawing.Point(346, 48);
            this.TextpublisherId.Name = "TextpublisherId";
            this.TextpublisherId.Size = new System.Drawing.Size(462, 35);
            this.TextpublisherId.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Californian FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "Publisher Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Californian FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Publisher Id";
            // 
            // Backbtn
            // 
            this.Backbtn.Location = new System.Drawing.Point(370, 92);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(160, 58);
            this.Backbtn.TabIndex = 51;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = true;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // DeletePublisher
            // 
            this.DeletePublisher.Location = new System.Drawing.Point(1192, 418);
            this.DeletePublisher.Name = "DeletePublisher";
            this.DeletePublisher.Size = new System.Drawing.Size(160, 48);
            this.DeletePublisher.TabIndex = 52;
            this.DeletePublisher.Text = "Delete  Publisher";
            this.DeletePublisher.UseVisualStyleBackColor = true;
            this.DeletePublisher.Click += new System.EventHandler(this.DeletePublisher_Click);
            // 
            // Refeshbtn
            // 
            this.Refeshbtn.Location = new System.Drawing.Point(1088, 182);
            this.Refeshbtn.Name = "Refeshbtn";
            this.Refeshbtn.Size = new System.Drawing.Size(81, 35);
            this.Refeshbtn.TabIndex = 53;
            this.Refeshbtn.Text = "Refesh";
            this.Refeshbtn.UseVisualStyleBackColor = true;
            this.Refeshbtn.Click += new System.EventHandler(this.Refeshbtn_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(933, 182);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(148, 35);
            this.Search.TabIndex = 54;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // editPublisher
            // 
            this.editPublisher.Location = new System.Drawing.Point(1192, 315);
            this.editPublisher.Name = "editPublisher";
            this.editPublisher.Size = new System.Drawing.Size(160, 48);
            this.editPublisher.TabIndex = 55;
            this.editPublisher.Text = "Edit Publisher";
            this.editPublisher.UseVisualStyleBackColor = true;
            this.editPublisher.Click += new System.EventHandler(this.editPublisher_Click);
            // 
            // textfill
            // 
            this.textfill.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textfill.Location = new System.Drawing.Point(585, 568);
            this.textfill.Name = "textfill";
            this.textfill.Size = new System.Drawing.Size(598, 35);
            this.textfill.TabIndex = 60;
            this.textfill.Text = "Please Enter Publisher Id";
            this.textfill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textfill.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textfill_MouseClick);
            // 
            // AddPublisher
            // 
            this.AddPublisher.Location = new System.Drawing.Point(1192, 220);
            this.AddPublisher.Name = "AddPublisher";
            this.AddPublisher.Size = new System.Drawing.Size(160, 48);
            this.AddPublisher.TabIndex = 56;
            this.AddPublisher.Text = "Add  Publisher";
            this.AddPublisher.UseVisualStyleBackColor = true;
            this.AddPublisher.Click += new System.EventHandler(this.AddPublisher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Californian FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(698, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 42);
            this.label1.TabIndex = 50;
            this.label1.Text = "Publisher Managment";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(390, 642);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 58);
            this.button3.TabIndex = 61;
            this.button3.Text = "Book Managment";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(390, 795);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 58);
            this.button4.TabIndex = 61;
            this.button4.Text = "Book Issue";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(390, 871);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(166, 58);
            this.button5.TabIndex = 61;
            this.button5.Text = "Book Return";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // RederManagmentbtn
            // 
            this.RederManagmentbtn.Location = new System.Drawing.Point(390, 714);
            this.RederManagmentbtn.Name = "RederManagmentbtn";
            this.RederManagmentbtn.Size = new System.Drawing.Size(166, 58);
            this.RederManagmentbtn.TabIndex = 61;
            this.RederManagmentbtn.Text = "Reader Managment";
            this.RederManagmentbtn.UseVisualStyleBackColor = true;
            this.RederManagmentbtn.Click += new System.EventHandler(this.RederManagmentbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 20);
            this.label3.TabIndex = 62;
            this.label3.Text = "Publisher Management";
            // 
            // PublisherManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1786, 1050);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.RederManagmentbtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.AuthorManagmntbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textsearch);
            this.Controls.Add(this.PublisherGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.DeletePublisher);
            this.Controls.Add(this.Refeshbtn);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.editPublisher);
            this.Controls.Add(this.textfill);
            this.Controls.Add(this.AddPublisher);
            this.Controls.Add(this.label1);
            this.Name = "PublisherManagment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PublisherManagment";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.PublisherManagment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PublisherGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AuthorManagmntbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textsearch;
        private System.Windows.Forms.DataGridView PublisherGridView1;
        private System.Windows.Forms.Panel panel1;
        private DoubleClickButton ConFrombtn;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textpublisherName;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textpublisherothername;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox TextpublisherId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Button DeletePublisher;
        private System.Windows.Forms.Button Refeshbtn;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button editPublisher;
        private System.Windows.Forms.TextBox textfill;
        private System.Windows.Forms.Button AddPublisher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button RederManagmentbtn;
        private System.Windows.Forms.Label label3;
    }
}