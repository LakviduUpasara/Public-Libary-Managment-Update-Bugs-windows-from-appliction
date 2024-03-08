namespace Public_Libary_managment_System
{
    partial class viewBookDeatail
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
            this.components = new System.ComponentModel.Container();
            this.pUBLIC_LIBRARY_MANAGMENT_SYSTEMDataSet = new Public_Libary_managment_System.PUBLIC_LIBRARY_MANAGMENT_SYSTEMDataSet();
            this.pUBLICLIBRARYMANAGMENTSYSTEMDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Backbtn = new System.Windows.Forms.Button();
            this.Viewbookbtn = new System.Windows.Forms.Button();
            this.EditBookbtn = new System.Windows.Forms.Button();
            this.Addbookbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pUBLIC_LIBRARY_MANAGMENT_SYSTEMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUBLICLIBRARYMANAGMENTSYSTEMDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pUBLIC_LIBRARY_MANAGMENT_SYSTEMDataSet
            // 
            this.pUBLIC_LIBRARY_MANAGMENT_SYSTEMDataSet.DataSetName = "PUBLIC_LIBRARY_MANAGMENT_SYSTEMDataSet";
            this.pUBLIC_LIBRARY_MANAGMENT_SYSTEMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pUBLICLIBRARYMANAGMENTSYSTEMDataSetBindingSource
            // 
            this.pUBLICLIBRARYMANAGMENTSYSTEMDataSetBindingSource.DataSource = this.pUBLIC_LIBRARY_MANAGMENT_SYSTEMDataSet;
            this.pUBLICLIBRARYMANAGMENTSYSTEMDataSetBindingSource.Position = 0;
            // 
            // Backbtn
            // 
            this.Backbtn.Location = new System.Drawing.Point(105, 36);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(161, 58);
            this.Backbtn.TabIndex = 38;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = true;
            // 
            // Viewbookbtn
            // 
            this.Viewbookbtn.Location = new System.Drawing.Point(712, 117);
            this.Viewbookbtn.Name = "Viewbookbtn";
            this.Viewbookbtn.Size = new System.Drawing.Size(161, 48);
            this.Viewbookbtn.TabIndex = 39;
            this.Viewbookbtn.Text = "View  Deatail";
            this.Viewbookbtn.UseVisualStyleBackColor = true;
            // 
            // EditBookbtn
            // 
            this.EditBookbtn.Location = new System.Drawing.Point(1079, 117);
            this.EditBookbtn.Name = "EditBookbtn";
            this.EditBookbtn.Size = new System.Drawing.Size(161, 48);
            this.EditBookbtn.TabIndex = 40;
            this.EditBookbtn.Text = "Edit Book";
            this.EditBookbtn.UseVisualStyleBackColor = true;
            // 
            // Addbookbtn
            // 
            this.Addbookbtn.Location = new System.Drawing.Point(895, 117);
            this.Addbookbtn.Name = "Addbookbtn";
            this.Addbookbtn.Size = new System.Drawing.Size(161, 48);
            this.Addbookbtn.TabIndex = 41;
            this.Addbookbtn.Text = "Add Book";
            this.Addbookbtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Californian FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(801, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 42);
            this.label1.TabIndex = 36;
            this.label1.Text = "View Book Deatail";
            // 
            // viewBookDeatail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1826, 1050);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.Viewbookbtn);
            this.Controls.Add(this.EditBookbtn);
            this.Controls.Add(this.Addbookbtn);
            this.Controls.Add(this.label1);
            this.Name = "viewBookDeatail";
            this.Text = "viewBookDeatail";
            this.Load += new System.EventHandler(this.viewBookDeatail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pUBLIC_LIBRARY_MANAGMENT_SYSTEMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUBLICLIBRARYMANAGMENTSYSTEMDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PUBLIC_LIBRARY_MANAGMENT_SYSTEMDataSet pUBLIC_LIBRARY_MANAGMENT_SYSTEMDataSet;
        private System.Windows.Forms.BindingSource pUBLICLIBRARYMANAGMENTSYSTEMDataSetBindingSource;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Button Viewbookbtn;
        private System.Windows.Forms.Button EditBookbtn;
        private System.Windows.Forms.Button Addbookbtn;
        private System.Windows.Forms.Label label1;
    }
}