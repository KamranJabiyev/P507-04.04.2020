namespace WinformSql
{
    partial class Form1
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
            this.lblStuName = new System.Windows.Forms.Label();
            this.cmbAllStu = new System.Windows.Forms.ComboBox();
            this.btnShowAllStu = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.btnCreateStu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStuName
            // 
            this.lblStuName.AutoSize = true;
            this.lblStuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStuName.Location = new System.Drawing.Point(44, 40);
            this.lblStuName.Name = "lblStuName";
            this.lblStuName.Size = new System.Drawing.Size(0, 29);
            this.lblStuName.TabIndex = 0;
            // 
            // cmbAllStu
            // 
            this.cmbAllStu.FormattingEnabled = true;
            this.cmbAllStu.Location = new System.Drawing.Point(498, 60);
            this.cmbAllStu.Name = "cmbAllStu";
            this.cmbAllStu.Size = new System.Drawing.Size(121, 28);
            this.cmbAllStu.TabIndex = 1;
            // 
            // btnShowAllStu
            // 
            this.btnShowAllStu.Location = new System.Drawing.Point(498, 164);
            this.btnShowAllStu.Name = "btnShowAllStu";
            this.btnShowAllStu.Size = new System.Drawing.Size(121, 59);
            this.btnShowAllStu.TabIndex = 2;
            this.btnShowAllStu.Text = "Show All Student";
            this.btnShowAllStu.UseVisualStyleBackColor = true;
            this.btnShowAllStu.Click += new System.EventHandler(this.btnShowAllStu_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(129, 203);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(154, 26);
            this.txtName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Surname:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(129, 258);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(154, 26);
            this.txtSurname.TabIndex = 5;
            // 
            // btnCreateStu
            // 
            this.btnCreateStu.Location = new System.Drawing.Point(129, 335);
            this.btnCreateStu.Name = "btnCreateStu";
            this.btnCreateStu.Size = new System.Drawing.Size(154, 35);
            this.btnCreateStu.TabIndex = 7;
            this.btnCreateStu.Text = "Create";
            this.btnCreateStu.UseVisualStyleBackColor = true;
            this.btnCreateStu.Click += new System.EventHandler(this.btnCreateStu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreateStu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnShowAllStu);
            this.Controls.Add(this.cmbAllStu);
            this.Controls.Add(this.lblStuName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStuName;
        private System.Windows.Forms.ComboBox cmbAllStu;
        private System.Windows.Forms.Button btnShowAllStu;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Button btnCreateStu;
    }
}

