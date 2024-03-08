namespace Public_Libary_managment_System
{
    partial class ReturnBook
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
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.AuthorManagmntbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.issuId = new System.Windows.Forms.TextBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.SumitBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBookID = new System.Windows.Forms.TextBox();
            this.texttday = new System.Windows.Forms.TextBox();
            this.Backbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textfines = new System.Windows.Forms.TextBox();
            this.textTotalDays = new System.Windows.Forms.TextBox();
            this.nextbtn = new System.Windows.Forms.Button();
            this.countbdisplaytext = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textReaderid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(754, 72);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(166, 58);
            this.button5.TabIndex = 75;
            this.button5.Text = "Book Issue";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(573, 72);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 58);
            this.button4.TabIndex = 76;
            this.button4.Text = "Reader managment";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // AuthorManagmntbtn
            // 
            this.AuthorManagmntbtn.Location = new System.Drawing.Point(226, 72);
            this.AuthorManagmntbtn.Name = "AuthorManagmntbtn";
            this.AuthorManagmntbtn.Size = new System.Drawing.Size(166, 58);
            this.AuthorManagmntbtn.TabIndex = 78;
            this.AuthorManagmntbtn.Text = "Author Managment";
            this.AuthorManagmntbtn.UseVisualStyleBackColor = true;
            this.AuthorManagmntbtn.Click += new System.EventHandler(this.AuthorManagmntbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(766, 169);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(806, 645);
            this.dataGridView1.TabIndex = 74;
            // 
            // issuId
            // 
            this.issuId.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuId.Location = new System.Drawing.Point(236, 17);
            this.issuId.Name = "issuId";
            this.issuId.Size = new System.Drawing.Size(414, 35);
            this.issuId.TabIndex = 3;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(334, 320);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(134, 43);
            this.ClearBtn.TabIndex = 4;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // SumitBtn
            // 
            this.SumitBtn.Location = new System.Drawing.Point(502, 320);
            this.SumitBtn.Name = "SumitBtn";
            this.SumitBtn.Size = new System.Drawing.Size(134, 43);
            this.SumitBtn.TabIndex = 4;
            this.SumitBtn.Text = "Submit";
            this.SumitBtn.UseVisualStyleBackColor = true;
            this.SumitBtn.Click += new System.EventHandler(this.SumitBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 27);
            this.label6.TabIndex = 2;
            this.label6.Text = "Issue Id";
            // 
            // textBookID
            // 
            this.textBookID.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBookID.Location = new System.Drawing.Point(236, 85);
            this.textBookID.Name = "textBookID";
            this.textBookID.Size = new System.Drawing.Size(414, 35);
            this.textBookID.TabIndex = 3;
            // 
            // texttday
            // 
            this.texttday.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.texttday.Font = new System.Drawing.Font("Californian FB", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texttday.Location = new System.Drawing.Point(966, 17);
            this.texttday.Name = "texttday";
            this.texttday.Size = new System.Drawing.Size(584, 40);
            this.texttday.TabIndex = 73;
            // 
            // Backbtn
            // 
            this.Backbtn.Location = new System.Drawing.Point(58, 72);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(134, 43);
            this.Backbtn.TabIndex = 70;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = true;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Book ID ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(399, 72);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 58);
            this.button3.TabIndex = 77;
            this.button3.Text = "Book Managment";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.issuId);
            this.panel1.Controls.Add(this.ClearBtn);
            this.panel1.Controls.Add(this.SumitBtn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textfines);
            this.panel1.Controls.Add(this.textTotalDays);
            this.panel1.Controls.Add(this.textBookID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(50, 369);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 386);
            this.panel1.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Californian FB", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fines";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Californian FB", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total Days";
            // 
            // textfines
            // 
            this.textfines.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textfines.Location = new System.Drawing.Point(232, 209);
            this.textfines.Name = "textfines";
            this.textfines.Size = new System.Drawing.Size(284, 35);
            this.textfines.TabIndex = 3;
            this.textfines.TextChanged += new System.EventHandler(this.textfines_TextChanged);
            // 
            // textTotalDays
            // 
            this.textTotalDays.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTotalDays.Location = new System.Drawing.Point(232, 148);
            this.textTotalDays.Name = "textTotalDays";
            this.textTotalDays.Size = new System.Drawing.Size(284, 35);
            this.textTotalDays.TabIndex = 3;
            // 
            // nextbtn
            // 
            this.nextbtn.Location = new System.Drawing.Point(552, 308);
            this.nextbtn.Name = "nextbtn";
            this.nextbtn.Size = new System.Drawing.Size(134, 43);
            this.nextbtn.TabIndex = 71;
            this.nextbtn.Text = "Next";
            this.nextbtn.UseVisualStyleBackColor = true;
            this.nextbtn.Click += new System.EventHandler(this.nextbtn_Click);
            // 
            // countbdisplaytext
            // 
            this.countbdisplaytext.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countbdisplaytext.Location = new System.Drawing.Point(226, 255);
            this.countbdisplaytext.Name = "countbdisplaytext";
            this.countbdisplaytext.Size = new System.Drawing.Size(462, 35);
            this.countbdisplaytext.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 27);
            this.label5.TabIndex = 66;
            this.label5.Text = "Avalible Book";
            // 
            // textReaderid
            // 
            this.textReaderid.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textReaderid.Location = new System.Drawing.Point(226, 202);
            this.textReaderid.Name = "textReaderid";
            this.textReaderid.Size = new System.Drawing.Size(462, 35);
            this.textReaderid.TabIndex = 69;
            this.textReaderid.TextChanged += new System.EventHandler(this.textReaderid_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 27);
            this.label3.TabIndex = 67;
            this.label3.Text = "Reader Id";
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1587, 829);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.AuthorManagmntbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.texttday);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nextbtn);
            this.Controls.Add(this.countbdisplaytext);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textReaderid);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReturnBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReturnBook";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReturnBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button AuthorManagmntbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox issuId;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button SumitBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBookID;
        private System.Windows.Forms.TextBox texttday;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button nextbtn;
        private System.Windows.Forms.TextBox countbdisplaytext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textReaderid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textTotalDays;
        private System.Windows.Forms.TextBox textfines;
    }
}