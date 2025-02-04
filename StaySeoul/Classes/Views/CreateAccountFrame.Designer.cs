using System.Windows.Forms;

namespace StaySeoul.Classes.Views
{
    partial class CreateAccountFrame
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.termLink = new System.Windows.Forms.LinkLabel();
            this.termCb = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataPicker = new System.Windows.Forms.DateTimePicker();
            this.familyNumber = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.femaleRb = new System.Windows.Forms.RadioButton();
            this.maleRb = new System.Windows.Forms.RadioButton();
            this.rePswdTxt = new System.Windows.Forms.TextBox();
            this.pswdTxt = new System.Windows.Forms.TextBox();
            this.fullNameTxt = new System.Windows.Forms.TextBox();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.returnBtn = new System.Windows.Forms.Button();
            this.saveLoginBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.familyNumber)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 41);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seoul Stay - Create Account";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.panel2.Location = new System.Drawing.Point(0, 693);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 41);
            this.panel2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.termLink);
            this.groupBox1.Controls.Add(this.termCb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dataPicker);
            this.groupBox1.Controls.Add(this.familyNumber);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.rePswdTxt);
            this.groupBox1.Controls.Add(this.pswdTxt);
            this.groupBox1.Controls.Add(this.fullNameTxt);
            this.groupBox1.Controls.Add(this.userTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(932, 542);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your information";
            // 
            // termLink
            // 
            this.termLink.AutoSize = true;
            this.termLink.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termLink.Location = new System.Drawing.Point(464, 475);
            this.termLink.Name = "termLink";
            this.termLink.Size = new System.Drawing.Size(239, 24);
            this.termLink.TabIndex = 16;
            this.termLink.TabStop = true;
            this.termLink.Text = "View Terms and Conditions";
            // 
            // termCb
            // 
            this.termCb.AutoSize = true;
            this.termCb.Location = new System.Drawing.Point(12, 469);
            this.termCb.Name = "termCb";
            this.termCb.Size = new System.Drawing.Size(449, 39);
            this.termCb.TabIndex = 15;
            this.termCb.Text = "I agree to the terms and conditions.";
            this.termCb.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 35);
            this.label2.TabIndex = 9;
            this.label2.Text = "Username:";
            // 
            // dataPicker
            // 
            this.dataPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataPicker.Location = new System.Drawing.Point(150, 280);
            this.dataPicker.Name = "dataPicker";
            this.dataPicker.Size = new System.Drawing.Size(196, 40);
            this.dataPicker.TabIndex = 8;
            this.dataPicker.Value = new System.DateTime(2005, 12, 19, 0, 0, 0, 0);
            // 
            // familyNumber
            // 
            this.familyNumber.Location = new System.Drawing.Point(827, 181);
            this.familyNumber.Name = "familyNumber";
            this.familyNumber.Size = new System.Drawing.Size(76, 40);
            this.familyNumber.TabIndex = 7;
            this.familyNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.femaleRb);
            this.groupBox2.Controls.Add(this.maleRb);
            this.groupBox2.Location = new System.Drawing.Point(476, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 82);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // femaleRb
            // 
            this.femaleRb.AutoSize = true;
            this.femaleRb.Location = new System.Drawing.Point(169, 28);
            this.femaleRb.Name = "femaleRb";
            this.femaleRb.Size = new System.Drawing.Size(121, 39);
            this.femaleRb.TabIndex = 1;
            this.femaleRb.TabStop = true;
            this.femaleRb.Text = "Female";
            this.femaleRb.UseVisualStyleBackColor = true;
            // 
            // maleRb
            // 
            this.maleRb.AutoSize = true;
            this.maleRb.Location = new System.Drawing.Point(15, 28);
            this.maleRb.Name = "maleRb";
            this.maleRb.Size = new System.Drawing.Size(95, 39);
            this.maleRb.TabIndex = 0;
            this.maleRb.TabStop = true;
            this.maleRb.Text = "Male";
            this.maleRb.UseVisualStyleBackColor = true;
            // 
            // rePswdTxt
            // 
            this.rePswdTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rePswdTxt.Location = new System.Drawing.Point(654, 376);
            this.rePswdTxt.Name = "rePswdTxt";
            this.rePswdTxt.Size = new System.Drawing.Size(249, 40);
            this.rePswdTxt.TabIndex = 5;
            // 
            // pswdTxt
            // 
            this.pswdTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pswdTxt.Location = new System.Drawing.Point(155, 376);
            this.pswdTxt.Name = "pswdTxt";
            this.pswdTxt.Size = new System.Drawing.Size(249, 40);
            this.pswdTxt.TabIndex = 4;
            // 
            // fullNameTxt
            // 
            this.fullNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullNameTxt.Location = new System.Drawing.Point(150, 181);
            this.fullNameTxt.Name = "fullNameTxt";
            this.fullNameTxt.Size = new System.Drawing.Size(249, 40);
            this.fullNameTxt.TabIndex = 2;
            // 
            // userTxt
            // 
            this.userTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userTxt.Location = new System.Drawing.Point(155, 83);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(249, 40);
            this.userTxt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 35);
            this.label3.TabIndex = 10;
            this.label3.Text = "Full name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 35);
            this.label4.TabIndex = 11;
            this.label4.Text = "Birthday:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 35);
            this.label5.TabIndex = 12;
            this.label5.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(419, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 35);
            this.label6.TabIndex = 13;
            this.label6.Text = "Retype password:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(455, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(343, 35);
            this.label7.TabIndex = 14;
            this.label7.Text = "Number of family members:";
            // 
            // returnBtn
            // 
            this.returnBtn.BackColor = System.Drawing.Color.White;
            this.returnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBtn.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.returnBtn.Location = new System.Drawing.Point(688, 629);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(258, 44);
            this.returnBtn.TabIndex = 11;
            this.returnBtn.Text = "Return login form";
            this.returnBtn.UseVisualStyleBackColor = false;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // saveLoginBtn
            // 
            this.saveLoginBtn.BackColor = System.Drawing.Color.White;
            this.saveLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveLoginBtn.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveLoginBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.saveLoginBtn.Location = new System.Drawing.Point(407, 629);
            this.saveLoginBtn.Name = "saveLoginBtn";
            this.saveLoginBtn.Size = new System.Drawing.Size(258, 44);
            this.saveLoginBtn.TabIndex = 12;
            this.saveLoginBtn.Text = "Register and login";
            this.saveLoginBtn.UseVisualStyleBackColor = false;
            this.saveLoginBtn.Click += new System.EventHandler(this.saveLoginBtn_Click);
            // 
            // CreateAccountFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(976, 734);
            this.Controls.Add(this.saveLoginBtn);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateAccountFrame";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.familyNumber)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox rePswdTxt;
        private System.Windows.Forms.TextBox pswdTxt;
        private System.Windows.Forms.TextBox fullNameTxt;
        private System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.DateTimePicker dataPicker;
        private System.Windows.Forms.NumericUpDown familyNumber;
        private System.Windows.Forms.RadioButton femaleRb;
        private System.Windows.Forms.RadioButton maleRb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel termLink;
        private System.Windows.Forms.CheckBox termCb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Button saveLoginBtn;
    }
}