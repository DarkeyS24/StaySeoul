namespace StaySeoul.Classes.Views
{
    partial class ManagementFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementFrame));
            this.travelerControl = new System.Windows.Forms.TabControl();
            this.travelerPage = new System.Windows.Forms.TabPage();
            this.travelerTable = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.travelerSearchTxt = new System.Windows.Forms.TextBox();
            this.ownerPage = new System.Windows.Forms.TabPage();
            this.employeeTable = new System.Windows.Forms.DataGridView();
            this.addBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.itemLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.travelerControl.SuspendLayout();
            this.travelerPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.travelerTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.ownerPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // travelerControl
            // 
            this.travelerControl.Controls.Add(this.travelerPage);
            this.travelerControl.Controls.Add(this.ownerPage);
            this.travelerControl.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.travelerControl.Location = new System.Drawing.Point(9, 285);
            this.travelerControl.Name = "travelerControl";
            this.travelerControl.SelectedIndex = 0;
            this.travelerControl.Size = new System.Drawing.Size(955, 401);
            this.travelerControl.TabIndex = 6;
            this.travelerControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.travelerControl_Selecting);
            // 
            // travelerPage
            // 
            this.travelerPage.BackColor = System.Drawing.Color.White;
            this.travelerPage.Controls.Add(this.travelerTable);
            this.travelerPage.Controls.Add(this.pictureBox2);
            this.travelerPage.Controls.Add(this.travelerSearchTxt);
            this.travelerPage.Location = new System.Drawing.Point(4, 42);
            this.travelerPage.Name = "travelerPage";
            this.travelerPage.Padding = new System.Windows.Forms.Padding(3);
            this.travelerPage.Size = new System.Drawing.Size(947, 355);
            this.travelerPage.TabIndex = 0;
            this.travelerPage.Text = "I\'m Traveler";
            // 
            // travelerTable
            // 
            this.travelerTable.AllowUserToAddRows = false;
            this.travelerTable.AllowUserToDeleteRows = false;
            this.travelerTable.AllowUserToResizeRows = false;
            this.travelerTable.BackgroundColor = System.Drawing.Color.White;
            this.travelerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.travelerTable.Location = new System.Drawing.Point(17, 70);
            this.travelerTable.Name = "travelerTable";
            this.travelerTable.RowHeadersWidth = 51;
            this.travelerTable.RowTemplate.Height = 24;
            this.travelerTable.Size = new System.Drawing.Size(912, 268);
            this.travelerTable.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(17, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 40);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // travelerSearchTxt
            // 
            this.travelerSearchTxt.Location = new System.Drawing.Point(63, 17);
            this.travelerSearchTxt.Name = "travelerSearchTxt";
            this.travelerSearchTxt.Size = new System.Drawing.Size(555, 40);
            this.travelerSearchTxt.TabIndex = 0;
            // 
            // ownerPage
            // 
            this.ownerPage.Controls.Add(this.button1);
            this.ownerPage.Controls.Add(this.employeeTable);
            this.ownerPage.Controls.Add(this.addBtn);
            this.ownerPage.Location = new System.Drawing.Point(4, 42);
            this.ownerPage.Name = "ownerPage";
            this.ownerPage.Padding = new System.Windows.Forms.Padding(3);
            this.ownerPage.Size = new System.Drawing.Size(947, 355);
            this.ownerPage.TabIndex = 1;
            this.ownerPage.Text = "I\'m Owner / Manager";
            this.ownerPage.UseVisualStyleBackColor = true;
            // 
            // employeeTable
            // 
            this.employeeTable.AllowUserToAddRows = false;
            this.employeeTable.AllowUserToDeleteRows = false;
            this.employeeTable.AllowUserToResizeRows = false;
            this.employeeTable.BackgroundColor = System.Drawing.Color.White;
            this.employeeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeTable.Location = new System.Drawing.Point(17, 78);
            this.employeeTable.Name = "employeeTable";
            this.employeeTable.RowHeadersWidth = 51;
            this.employeeTable.RowTemplate.Height = 24;
            this.employeeTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeTable.Size = new System.Drawing.Size(912, 261);
            this.employeeTable.TabIndex = 14;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.White;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Image = ((System.Drawing.Image)(resources.GetObject("addBtn.Image")));
            this.addBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.addBtn.Location = new System.Drawing.Point(19, 16);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(218, 50);
            this.addBtn.TabIndex = 13;
            this.addBtn.Text = "Add listing";
            this.addBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addBtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 41);
            this.panel1.TabIndex = 7;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown_1);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove_1);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seoul Stay - Management";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.panel2.Controls.Add(this.itemLbl);
            this.panel2.Location = new System.Drawing.Point(0, 693);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(993, 41);
            this.panel2.TabIndex = 8;
            // 
            // itemLbl
            // 
            this.itemLbl.AutoSize = true;
            this.itemLbl.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLbl.ForeColor = System.Drawing.Color.White;
            this.itemLbl.Location = new System.Drawing.Point(3, 3);
            this.itemLbl.Name = "itemLbl";
            this.itemLbl.Size = new System.Drawing.Size(175, 35);
            this.itemLbl.TabIndex = 0;
            this.itemLbl.Text = "3 items found";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(234, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(506, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.White;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(815, 270);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(145, 50);
            this.exitBtn.TabIndex = 10;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackColor = System.Drawing.Color.White;
            this.logOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutBtn.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.Location = new System.Drawing.Point(624, 270);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(168, 50);
            this.logOutBtn.TabIndex = 11;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(766, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 50);
            this.button1.TabIndex = 15;
            this.button1.Text = "Edit details";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ManagementFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(976, 734);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.travelerControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagementFrame";
            this.Text = "ManagementFrame";
            this.travelerControl.ResumeLayout(false);
            this.travelerPage.ResumeLayout(false);
            this.travelerPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.travelerTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ownerPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl travelerControl;
        private System.Windows.Forms.TabPage travelerPage;
        private System.Windows.Forms.TabPage ownerPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Label itemLbl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox travelerSearchTxt;
        private System.Windows.Forms.DataGridView travelerTable;
        private System.Windows.Forms.DataGridView employeeTable;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button button1;
    }
}