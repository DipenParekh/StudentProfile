namespace WindowsFormsApp2
{
    partial class StudentDetails
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
            this.studentDetailsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDetailsDataSet = new WindowsFormsApp2.StudentDetailsDataSet();
            this.dgStudent = new System.Windows.Forms.DataGridView();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // studentDetailsDataSetBindingSource
            // 
            this.studentDetailsDataSetBindingSource.DataSource = this.studentDetailsDataSet;
            this.studentDetailsDataSetBindingSource.Position = 0;
            // 
            // studentDetailsDataSet
            // 
            this.studentDetailsDataSet.DataSetName = "StudentDetailsDataSet";
            this.studentDetailsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgStudent
            // 
            this.dgStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStudent.Location = new System.Drawing.Point(108, 213);
            this.dgStudent.Name = "dgStudent";
            this.dgStudent.RowHeadersWidth = 51;
            this.dgStudent.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgStudent.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgStudent.RowTemplate.Height = 24;
            this.dgStudent.Size = new System.Drawing.Size(525, 57);
            this.dgStudent.TabIndex = 1;
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Location = new System.Drawing.Point(321, 106);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(0, 16);
            this.usernamelabel.TabIndex = 2;
            this.usernamelabel.Visible = false;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(366, 171);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(0, 16);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label9.Location = new System.Drawing.Point(561, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "GEORGIAN COLLEGE";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(712, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.dgStudent);
            this.Name = "StudentDetails";
            this.Text = "StudentDetails";
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource studentDetailsDataSetBindingSource;
        private StudentDetailsDataSet studentDetailsDataSet;
        private System.Windows.Forms.DataGridView dgStudent;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}