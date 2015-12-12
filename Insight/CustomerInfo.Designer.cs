namespace Insight
{
    partial class CustomerInfo
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
            this.custEmail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.custPhone = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.custAddress = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.custName = new System.Windows.Forms.Label();
            this.openWOs = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Assigned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.openWOs)).BeginInit();
            this.SuspendLayout();
            // 
            // custEmail
            // 
            this.custEmail.AutoSize = true;
            this.custEmail.Location = new System.Drawing.Point(67, 199);
            this.custEmail.Name = "custEmail";
            this.custEmail.Size = new System.Drawing.Size(0, 13);
            this.custEmail.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Email:";
            // 
            // custPhone
            // 
            this.custPhone.AutoSize = true;
            this.custPhone.Location = new System.Drawing.Point(67, 134);
            this.custPhone.Name = "custPhone";
            this.custPhone.Size = new System.Drawing.Size(0, 13);
            this.custPhone.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Phone:";
            // 
            // custAddress
            // 
            this.custAddress.AutoSize = true;
            this.custAddress.Location = new System.Drawing.Point(67, 76);
            this.custAddress.Name = "custAddress";
            this.custAddress.Size = new System.Drawing.Size(0, 13);
            this.custAddress.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Customer:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(74, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // custName
            // 
            this.custName.AutoSize = true;
            this.custName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custName.Location = new System.Drawing.Point(12, 44);
            this.custName.Name = "custName";
            this.custName.Size = new System.Drawing.Size(0, 20);
            this.custName.TabIndex = 17;
            // 
            // openWOs
            // 
            this.openWOs.AllowUserToAddRows = false;
            this.openWOs.AllowUserToDeleteRows = false;
            this.openWOs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.openWOs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Assigned,
            this.Title});
            this.openWOs.Location = new System.Drawing.Point(239, 31);
            this.openWOs.Name = "openWOs";
            this.openWOs.ReadOnly = true;
            this.openWOs.RowHeadersVisible = false;
            this.openWOs.Size = new System.Drawing.Size(329, 190);
            this.openWOs.TabIndex = 19;
            // 
            // ID
            // 
            this.ID.FillWeight = 75F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 40;
            // 
            // Assigned
            // 
            this.Assigned.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Assigned.FillWeight = 50F;
            this.Assigned.HeaderText = "Assigned To";
            this.Assigned.Name = "Assigned";
            this.Assigned.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Work Orders:";
            // 
            // CustomerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 233);
            this.Controls.Add(this.openWOs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.custName);
            this.Controls.Add(this.custEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.custPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.custAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "CustomerInfo";
            this.Text = "Insight - Customer Information";
            this.Load += new System.EventHandler(this.CustomerInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.openWOs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label custEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label custPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label custAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label custName;
        private System.Windows.Forms.DataGridView openWOs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Assigned;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
    }
}