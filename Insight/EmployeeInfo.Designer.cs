namespace Insight
{
    partial class EmployeeInfo
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.empName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.empAddress = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.empPhone = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.empEmail = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.assignedWOs = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.assignedWOs)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(74, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee:";
            // 
            // empName
            // 
            this.empName.AutoSize = true;
            this.empName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empName.Location = new System.Drawing.Point(12, 44);
            this.empName.Name = "empName";
            this.empName.Size = new System.Drawing.Size(0, 20);
            this.empName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Address:";
            // 
            // empAddress
            // 
            this.empAddress.AutoSize = true;
            this.empAddress.Location = new System.Drawing.Point(67, 76);
            this.empAddress.Name = "empAddress";
            this.empAddress.Size = new System.Drawing.Size(0, 13);
            this.empAddress.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone:";
            // 
            // empPhone
            // 
            this.empPhone.AutoSize = true;
            this.empPhone.Location = new System.Drawing.Point(67, 134);
            this.empPhone.Name = "empPhone";
            this.empPhone.Size = new System.Drawing.Size(0, 13);
            this.empPhone.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email:";
            // 
            // empEmail
            // 
            this.empEmail.AutoSize = true;
            this.empEmail.Location = new System.Drawing.Point(67, 199);
            this.empEmail.Name = "empEmail";
            this.empEmail.Size = new System.Drawing.Size(0, 13);
            this.empEmail.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Assigned Work Orders:";
            // 
            // assignedWOs
            // 
            this.assignedWOs.AllowUserToAddRows = false;
            this.assignedWOs.AllowUserToDeleteRows = false;
            this.assignedWOs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assignedWOs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Customer,
            this.Title});
            this.assignedWOs.Location = new System.Drawing.Point(239, 31);
            this.assignedWOs.Name = "assignedWOs";
            this.assignedWOs.ReadOnly = true;
            this.assignedWOs.RowHeadersVisible = false;
            this.assignedWOs.Size = new System.Drawing.Size(329, 190);
            this.assignedWOs.TabIndex = 10;
            this.assignedWOs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.assignedWOs_CellContentClick);
            // 
            // ID
            // 
            this.ID.FillWeight = 75F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 40;
            // 
            // Customer
            // 
            this.Customer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Customer.FillWeight = 50F;
            this.Customer.HeaderText = "Customer";
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // EmployeeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 233);
            this.Controls.Add(this.assignedWOs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.empEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.empPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.empAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.empName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "EmployeeInfo";
            this.Text = "Insight - Employee Information";
            this.Load += new System.EventHandler(this.EmployeeInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assignedWOs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label empName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label empAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label empPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label empEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView assignedWOs;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
    }
}