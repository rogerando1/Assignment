namespace Problem1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Add = new System.Windows.Forms.Button();
            this.StudentIDTxtbx = new System.Windows.Forms.TextBox();
            this.FirstNameTxtbx = new System.Windows.Forms.TextBox();
            this.LastNameTxtbx = new System.Windows.Forms.TextBox();
            this.AgeTxtbx = new System.Windows.Forms.TextBox();
            this.AddressTxtbx = new System.Windows.Forms.TextBox();
            this.studentlist = new System.Windows.Forms.DataGridView();
            this.studentid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusCodeTxtbx = new System.Windows.Forms.ComboBox();
            this.GenderTxtbx = new System.Windows.Forms.ComboBox();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.StatusSort = new System.Windows.Forms.ComboBox();
            this.searchData = new System.Windows.Forms.TextBox();
            this.searchBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentlist)).BeginInit();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(35, 581);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(97, 45);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // StudentIDTxtbx
            // 
            this.StudentIDTxtbx.BackColor = System.Drawing.SystemColors.Window;
            this.StudentIDTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StudentIDTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentIDTxtbx.Location = new System.Drawing.Point(37, 208);
            this.StudentIDTxtbx.Multiline = true;
            this.StudentIDTxtbx.Name = "StudentIDTxtbx";
            this.StudentIDTxtbx.ReadOnly = true;
            this.StudentIDTxtbx.Size = new System.Drawing.Size(184, 20);
            this.StudentIDTxtbx.TabIndex = 1;
            // 
            // FirstNameTxtbx
            // 
            this.FirstNameTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FirstNameTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FirstNameTxtbx.Location = new System.Drawing.Point(37, 303);
            this.FirstNameTxtbx.Multiline = true;
            this.FirstNameTxtbx.Name = "FirstNameTxtbx";
            this.FirstNameTxtbx.Size = new System.Drawing.Size(184, 20);
            this.FirstNameTxtbx.TabIndex = 2;
            // 
            // LastNameTxtbx
            // 
            this.LastNameTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastNameTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LastNameTxtbx.Location = new System.Drawing.Point(272, 304);
            this.LastNameTxtbx.Multiline = true;
            this.LastNameTxtbx.Name = "LastNameTxtbx";
            this.LastNameTxtbx.Size = new System.Drawing.Size(176, 20);
            this.LastNameTxtbx.TabIndex = 3;
            // 
            // AgeTxtbx
            // 
            this.AgeTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AgeTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AgeTxtbx.Location = new System.Drawing.Point(39, 401);
            this.AgeTxtbx.Multiline = true;
            this.AgeTxtbx.Name = "AgeTxtbx";
            this.AgeTxtbx.Size = new System.Drawing.Size(182, 20);
            this.AgeTxtbx.TabIndex = 4;
            // 
            // AddressTxtbx
            // 
            this.AddressTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddressTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AddressTxtbx.Location = new System.Drawing.Point(41, 498);
            this.AddressTxtbx.Multiline = true;
            this.AddressTxtbx.Name = "AddressTxtbx";
            this.AddressTxtbx.Size = new System.Drawing.Size(407, 20);
            this.AddressTxtbx.TabIndex = 7;
            // 
            // studentlist
            // 
            this.studentlist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.studentlist.ColumnHeadersHeight = 30;
            this.studentlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.studentlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentid,
            this.firstname,
            this.lastname,
            this.age,
            this.address,
            this.gender,
            this.statusid});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentlist.DefaultCellStyle = dataGridViewCellStyle2;
            this.studentlist.Location = new System.Drawing.Point(507, 162);
            this.studentlist.Name = "studentlist";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentlist.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.studentlist.RowHeadersVisible = false;
            this.studentlist.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.studentlist.Size = new System.Drawing.Size(784, 512);
            this.studentlist.TabIndex = 8;
            this.studentlist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentlist_CellClick);
            // 
            // studentid
            // 
            this.studentid.DataPropertyName = "StudentID";
            this.studentid.HeaderText = "Student ID";
            this.studentid.Name = "studentid";
            // 
            // firstname
            // 
            this.firstname.DataPropertyName = "Firstname";
            this.firstname.HeaderText = "First Name";
            this.firstname.Name = "firstname";
            // 
            // lastname
            // 
            this.lastname.DataPropertyName = "Lastname";
            this.lastname.HeaderText = "Last Name";
            this.lastname.Name = "lastname";
            // 
            // age
            // 
            this.age.DataPropertyName = "Age";
            this.age.HeaderText = "Age";
            this.age.Name = "age";
            this.age.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.age.Width = 50;
            // 
            // address
            // 
            this.address.DataPropertyName = "Address";
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.Width = 250;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "Gender";
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.Width = 80;
            // 
            // statusid
            // 
            this.statusid.DataPropertyName = "StatusCode";
            this.statusid.HeaderText = "Status";
            this.statusid.Name = "statusid";
            // 
            // StatusCodeTxtbx
            // 
            this.StatusCodeTxtbx.BackColor = System.Drawing.Color.White;
            this.StatusCodeTxtbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatusCodeTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.StatusCodeTxtbx.ForeColor = System.Drawing.Color.Black;
            this.StatusCodeTxtbx.FormattingEnabled = true;
            this.StatusCodeTxtbx.Items.AddRange(new object[] {
            "Enrolled",
            "Graduated",
            "Expelled",
            "Transfer"});
            this.StatusCodeTxtbx.Location = new System.Drawing.Point(272, 203);
            this.StatusCodeTxtbx.Name = "StatusCodeTxtbx";
            this.StatusCodeTxtbx.Size = new System.Drawing.Size(176, 28);
            this.StatusCodeTxtbx.TabIndex = 9;
            this.StatusCodeTxtbx.SelectedIndexChanged += new System.EventHandler(this.StatusID_SelectedIndexChanged);
            // 
            // GenderTxtbx
            // 
            this.GenderTxtbx.BackColor = System.Drawing.Color.White;
            this.GenderTxtbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenderTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.GenderTxtbx.ForeColor = System.Drawing.Color.Black;
            this.GenderTxtbx.FormattingEnabled = true;
            this.GenderTxtbx.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderTxtbx.Location = new System.Drawing.Point(272, 396);
            this.GenderTxtbx.Name = "GenderTxtbx";
            this.GenderTxtbx.Size = new System.Drawing.Size(176, 28);
            this.GenderTxtbx.TabIndex = 10;
            // 
            // Update
            // 
            this.Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Update.FlatAppearance.BorderSize = 0;
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Location = new System.Drawing.Point(146, 581);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(97, 45);
            this.Update.TabIndex = 11;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete.FlatAppearance.BorderSize = 0;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Delete.Location = new System.Drawing.Point(252, 581);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(97, 45);
            this.Delete.TabIndex = 12;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Clear
            // 
            this.Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear.FlatAppearance.BorderSize = 0;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Clear.Location = new System.Drawing.Point(362, 581);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(97, 45);
            this.Clear.TabIndex = 13;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // StatusSort
            // 
            this.StatusSort.BackColor = System.Drawing.Color.White;
            this.StatusSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatusSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.StatusSort.ForeColor = System.Drawing.Color.Black;
            this.StatusSort.FormattingEnabled = true;
            this.StatusSort.Location = new System.Drawing.Point(507, 96);
            this.StatusSort.Name = "StatusSort";
            this.StatusSort.Size = new System.Drawing.Size(239, 28);
            this.StatusSort.TabIndex = 14;
            this.StatusSort.SelectedIndexChanged += new System.EventHandler(this.StatusSort_SelectedIndexChanged);
            // 
            // searchData
            // 
            this.searchData.BackColor = System.Drawing.SystemColors.Window;
            this.searchData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchData.Location = new System.Drawing.Point(794, 99);
            this.searchData.Multiline = true;
            this.searchData.Name = "searchData";
            this.searchData.Size = new System.Drawing.Size(380, 20);
            this.searchData.TabIndex = 15;
            this.searchData.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // searchBTN
            // 
            this.searchBTN.BackColor = System.Drawing.Color.White;
            this.searchBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBTN.FlatAppearance.BorderSize = 0;
            this.searchBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBTN.Location = new System.Drawing.Point(1180, 88);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(75, 42);
            this.searchBTN.TabIndex = 16;
            this.searchBTN.Text = "Search";
            this.searchBTN.UseVisualStyleBackColor = false;
            this.searchBTN.Click += new System.EventHandler(this.searchBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Problem1.Properties.Resources.UI;
            this.ClientSize = new System.Drawing.Size(1303, 726);
            this.Controls.Add(this.searchBTN);
            this.Controls.Add(this.searchData);
            this.Controls.Add(this.StatusSort);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.GenderTxtbx);
            this.Controls.Add(this.StatusCodeTxtbx);
            this.Controls.Add(this.studentlist);
            this.Controls.Add(this.AddressTxtbx);
            this.Controls.Add(this.AgeTxtbx);
            this.Controls.Add(this.LastNameTxtbx);
            this.Controls.Add(this.FirstNameTxtbx);
            this.Controls.Add(this.StudentIDTxtbx);
            this.Controls.Add(this.Add);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox StudentIDTxtbx;
        private System.Windows.Forms.TextBox FirstNameTxtbx;
        private System.Windows.Forms.TextBox LastNameTxtbx;
        private System.Windows.Forms.TextBox AgeTxtbx;
        private System.Windows.Forms.TextBox AddressTxtbx;
        private System.Windows.Forms.DataGridView studentlist;
        private System.Windows.Forms.ComboBox StatusCodeTxtbx;
        private System.Windows.Forms.ComboBox GenderTxtbx;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentid;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusid;
        private System.Windows.Forms.ComboBox StatusSort;
        private System.Windows.Forms.TextBox searchData;
        private System.Windows.Forms.Button searchBTN;
    }
}

