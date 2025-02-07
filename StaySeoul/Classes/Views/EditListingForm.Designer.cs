namespace StaySeoul.Classes.Views
{
    partial class EditListingForm
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
            this.managementTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.areaCb = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.maxNumber = new System.Windows.Forms.NumericUpDown();
            this.minNumber = new System.Windows.Forms.NumericUpDown();
            this.rulesTxt = new System.Windows.Forms.RichTextBox();
            this.descTxt = new System.Windows.Forms.RichTextBox();
            this.exactAddressTxt = new System.Windows.Forms.RichTextBox();
            this.approximateAddressTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bathroomsNumber = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.bedroomsNumber = new System.Windows.Forms.NumericUpDown();
            this.bedsNumber = new System.Windows.Forms.NumericUpDown();
            this.capaciyNumber = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serviceTypeCb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkList = new System.Windows.Forms.CheckedListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.AttractionDistanceTable = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.managementTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bathroomsNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedroomsNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedsNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capaciyNumber)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttractionDistanceTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 41);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seoul Stay - Add/ Edit Listing";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.panel2.Location = new System.Drawing.Point(0, 693);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(977, 41);
            this.panel2.TabIndex = 4;
            // 
            // managementTab
            // 
            this.managementTab.Controls.Add(this.tabPage1);
            this.managementTab.Controls.Add(this.tabPage2);
            this.managementTab.Controls.Add(this.tabPage3);
            this.managementTab.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managementTab.Location = new System.Drawing.Point(12, 60);
            this.managementTab.Name = "managementTab";
            this.managementTab.SelectedIndex = 0;
            this.managementTab.Size = new System.Drawing.Size(952, 576);
            this.managementTab.TabIndex = 5;
            this.managementTab.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.managementTab_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.areaCb);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.maxNumber);
            this.tabPage1.Controls.Add(this.minNumber);
            this.tabPage1.Controls.Add(this.rulesTxt);
            this.tabPage1.Controls.Add(this.descTxt);
            this.tabPage1.Controls.Add(this.exactAddressTxt);
            this.tabPage1.Controls.Add(this.approximateAddressTxt);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.bathroomsNumber);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.bedroomsNumber);
            this.tabPage1.Controls.Add(this.bedsNumber);
            this.tabPage1.Controls.Add(this.capaciyNumber);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.titleTxt);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.serviceTypeCb);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 42);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(944, 530);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listing Details";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(433, 130);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 28);
            this.label17.TabIndex = 26;
            this.label17.Text = "Area:";
            // 
            // areaCb
            // 
            this.areaCb.FormattingEnabled = true;
            this.areaCb.Location = new System.Drawing.Point(532, 126);
            this.areaCb.Name = "areaCb";
            this.areaCb.Size = new System.Drawing.Size(343, 36);
            this.areaCb.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(545, 486);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 28);
            this.label14.TabIndex = 24;
            this.label14.Text = "Maximum:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(325, 486);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 28);
            this.label13.TabIndex = 23;
            this.label13.Text = "Minimum:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 486);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(264, 28);
            this.label12.TabIndex = 22;
            this.label12.Text = "Reservation Time (Nights):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 408);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 28);
            this.label11.TabIndex = 21;
            this.label11.Text = "Host Rules:";
            // 
            // maxNumber
            // 
            this.maxNumber.Location = new System.Drawing.Point(673, 483);
            this.maxNumber.Name = "maxNumber";
            this.maxNumber.Size = new System.Drawing.Size(73, 36);
            this.maxNumber.TabIndex = 20;
            // 
            // minNumber
            // 
            this.minNumber.Location = new System.Drawing.Point(448, 482);
            this.minNumber.Name = "minNumber";
            this.minNumber.Size = new System.Drawing.Size(73, 36);
            this.minNumber.TabIndex = 19;
            // 
            // rulesTxt
            // 
            this.rulesTxt.Location = new System.Drawing.Point(267, 405);
            this.rulesTxt.Name = "rulesTxt";
            this.rulesTxt.Size = new System.Drawing.Size(644, 66);
            this.rulesTxt.TabIndex = 18;
            this.rulesTxt.Text = "";
            // 
            // descTxt
            // 
            this.descTxt.Location = new System.Drawing.Point(267, 329);
            this.descTxt.Name = "descTxt";
            this.descTxt.Size = new System.Drawing.Size(644, 66);
            this.descTxt.TabIndex = 17;
            this.descTxt.Text = "";
            // 
            // exactAddressTxt
            // 
            this.exactAddressTxt.Location = new System.Drawing.Point(267, 253);
            this.exactAddressTxt.Name = "exactAddressTxt";
            this.exactAddressTxt.Size = new System.Drawing.Size(644, 66);
            this.exactAddressTxt.TabIndex = 16;
            this.exactAddressTxt.Text = "";
            // 
            // approximateAddressTxt
            // 
            this.approximateAddressTxt.Location = new System.Drawing.Point(267, 197);
            this.approximateAddressTxt.Name = "approximateAddressTxt";
            this.approximateAddressTxt.Size = new System.Drawing.Size(644, 36);
            this.approximateAddressTxt.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 336);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 28);
            this.label10.TabIndex = 14;
            this.label10.Text = "Description:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 28);
            this.label9.TabIndex = 13;
            this.label9.Text = "Exact Address:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(224, 28);
            this.label8.TabIndex = 12;
            this.label8.Text = "Approximate Address:";
            // 
            // bathroomsNumber
            // 
            this.bathroomsNumber.Location = new System.Drawing.Point(276, 126);
            this.bathroomsNumber.Name = "bathroomsNumber";
            this.bathroomsNumber.Size = new System.Drawing.Size(61, 36);
            this.bathroomsNumber.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 28);
            this.label7.TabIndex = 10;
            this.label7.Text = "Number of Bathrooms:";
            // 
            // bedroomsNumber
            // 
            this.bedroomsNumber.Location = new System.Drawing.Point(804, 77);
            this.bedroomsNumber.Name = "bedroomsNumber";
            this.bedroomsNumber.Size = new System.Drawing.Size(73, 36);
            this.bedroomsNumber.TabIndex = 9;
            // 
            // bedsNumber
            // 
            this.bedsNumber.Location = new System.Drawing.Point(450, 77);
            this.bedsNumber.Name = "bedsNumber";
            this.bedsNumber.Size = new System.Drawing.Size(73, 36);
            this.bedsNumber.TabIndex = 7;
            // 
            // capaciyNumber
            // 
            this.capaciyNumber.Location = new System.Drawing.Point(132, 77);
            this.capaciyNumber.Name = "capaciyNumber";
            this.capaciyNumber.Size = new System.Drawing.Size(73, 36);
            this.capaciyNumber.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Capacity:";
            // 
            // titleTxt
            // 
            this.titleTxt.Location = new System.Drawing.Point(567, 18);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(344, 36);
            this.titleTxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(486, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type:";
            // 
            // serviceTypeCb
            // 
            this.serviceTypeCb.FormattingEnabled = true;
            this.serviceTypeCb.Location = new System.Drawing.Point(101, 17);
            this.serviceTypeCb.Name = "serviceTypeCb";
            this.serviceTypeCb.Size = new System.Drawing.Size(343, 36);
            this.serviceTypeCb.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(255, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Number of Beds:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(554, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 28);
            this.label6.TabIndex = 8;
            this.label6.Text = "Number of Bedrooms:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkList);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Location = new System.Drawing.Point(4, 42);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(944, 530);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Amenities";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkList
            // 
            this.checkList.FormattingEnabled = true;
            this.checkList.Location = new System.Drawing.Point(24, 68);
            this.checkList.Name = "checkList";
            this.checkList.Size = new System.Drawing.Size(538, 424);
            this.checkList.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(18, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(282, 28);
            this.label15.TabIndex = 0;
            this.label15.Text = "Choose Available Amenities:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.AttractionDistanceTable);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Location = new System.Drawing.Point(4, 42);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(944, 530);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Distance to Attraction";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // AttractionDistanceTable
            // 
            this.AttractionDistanceTable.AllowUserToResizeRows = false;
            this.AttractionDistanceTable.BackgroundColor = System.Drawing.Color.White;
            this.AttractionDistanceTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AttractionDistanceTable.Location = new System.Drawing.Point(15, 68);
            this.AttractionDistanceTable.Name = "AttractionDistanceTable";
            this.AttractionDistanceTable.RowHeadersWidth = 51;
            this.AttractionDistanceTable.RowTemplate.Height = 24;
            this.AttractionDistanceTable.Size = new System.Drawing.Size(914, 448);
            this.AttractionDistanceTable.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(20, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(830, 28);
            this.label16.TabIndex = 0;
            this.label16.Text = "Specify the distance from each close by attraction and the time it takes to get t" +
    "o them:";
            // 
            // saveBtn
            // 
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(762, 641);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(184, 45);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.saveBtn_MouseClick);
            // 
            // nextBtn
            // 
            this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBtn.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.Location = new System.Drawing.Point(623, 641);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(123, 45);
            this.nextBtn.TabIndex = 7;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(762, 641);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(184, 45);
            this.closeBtn.TabIndex = 8;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(762, 641);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(184, 45);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // EditListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(976, 734);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.managementTab);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.saveBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditListingForm";
            this.Text = "EditListingForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.managementTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bathroomsNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedroomsNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedsNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capaciyNumber)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttractionDistanceTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl managementTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ComboBox serviceTypeCb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown bathroomsNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown bedroomsNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown bedsNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown capaciyNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox exactAddressTxt;
        private System.Windows.Forms.TextBox approximateAddressTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown maxNumber;
        private System.Windows.Forms.NumericUpDown minNumber;
        private System.Windows.Forms.RichTextBox rulesTxt;
        private System.Windows.Forms.RichTextBox descTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckedListBox checkList;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView AttractionDistanceTable;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox areaCb;
    }
}