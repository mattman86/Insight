namespace Insight
{
    partial class WorkOrders
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
            this.dgWorkOrders = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssignedTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wOTitle = new System.Windows.Forms.Label();
            this.gbDescription = new System.Windows.Forms.GroupBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.gbSteps = new System.Windows.Forms.GroupBox();
            this.lbSteps = new System.Windows.Forms.ListBox();
            this.gbComments = new System.Windows.Forms.GroupBox();
            this.tbComments = new System.Windows.Forms.TextBox();
            this.cbShowOption = new System.Windows.Forms.CheckBox();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.btnAddComment = new System.Windows.Forms.Button();
            this.btnUpdateTitle = new System.Windows.Forms.Button();
            this.btnUpdateDescription = new System.Windows.Forms.Button();
            this.btnUpdateSteps = new System.Windows.Forms.Button();
            this.btnCloseWorkOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgWorkOrders)).BeginInit();
            this.gbDescription.SuspendLayout();
            this.gbSteps.SuspendLayout();
            this.gbComments.SuspendLayout();
            this.gbOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgWorkOrders
            // 
            this.dgWorkOrders.AllowUserToAddRows = false;
            this.dgWorkOrders.AllowUserToDeleteRows = false;
            this.dgWorkOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWorkOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Date,
            this.Customer,
            this.AssignedTo,
            this.Title});
            this.dgWorkOrders.Location = new System.Drawing.Point(12, 12);
            this.dgWorkOrders.Name = "dgWorkOrders";
            this.dgWorkOrders.ReadOnly = true;
            this.dgWorkOrders.RowHeadersVisible = false;
            this.dgWorkOrders.Size = new System.Drawing.Size(910, 126);
            this.dgWorkOrders.TabIndex = 0;
            this.dgWorkOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgWorkOrders_CellClick);
            // 
            // ID
            // 
            this.ID.FillWeight = 75F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 40;
            // 
            // Date
            // 
            this.Date.FillWeight = 50F;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 95;
            // 
            // Customer
            // 
            this.Customer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Customer.FillWeight = 40F;
            this.Customer.HeaderText = "Customer";
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            // 
            // AssignedTo
            // 
            this.AssignedTo.FillWeight = 50F;
            this.AssignedTo.HeaderText = "Assigned To";
            this.AssignedTo.Name = "AssignedTo";
            this.AssignedTo.ReadOnly = true;
            this.AssignedTo.Width = 95;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // wOTitle
            // 
            this.wOTitle.AutoSize = true;
            this.wOTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wOTitle.Location = new System.Drawing.Point(29, 141);
            this.wOTitle.Name = "wOTitle";
            this.wOTitle.Size = new System.Drawing.Size(0, 20);
            this.wOTitle.TabIndex = 1;
            // 
            // gbDescription
            // 
            this.gbDescription.Controls.Add(this.tbDescription);
            this.gbDescription.Location = new System.Drawing.Point(16, 164);
            this.gbDescription.Name = "gbDescription";
            this.gbDescription.Size = new System.Drawing.Size(457, 146);
            this.gbDescription.TabIndex = 2;
            this.gbDescription.TabStop = false;
            this.gbDescription.Text = "Description:";
            // 
            // tbDescription
            // 
            this.tbDescription.BackColor = System.Drawing.SystemColors.Window;
            this.tbDescription.Location = new System.Drawing.Point(6, 19);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.Size = new System.Drawing.Size(445, 121);
            this.tbDescription.TabIndex = 0;
            // 
            // gbSteps
            // 
            this.gbSteps.Controls.Add(this.lbSteps);
            this.gbSteps.Location = new System.Drawing.Point(479, 164);
            this.gbSteps.Name = "gbSteps";
            this.gbSteps.Size = new System.Drawing.Size(443, 146);
            this.gbSteps.TabIndex = 3;
            this.gbSteps.TabStop = false;
            this.gbSteps.Text = "Steps To Recreate:";
            // 
            // lbSteps
            // 
            this.lbSteps.FormattingEnabled = true;
            this.lbSteps.Location = new System.Drawing.Point(6, 19);
            this.lbSteps.Name = "lbSteps";
            this.lbSteps.Size = new System.Drawing.Size(431, 121);
            this.lbSteps.TabIndex = 0;
            // 
            // gbComments
            // 
            this.gbComments.Controls.Add(this.tbComments);
            this.gbComments.Location = new System.Drawing.Point(16, 316);
            this.gbComments.Name = "gbComments";
            this.gbComments.Size = new System.Drawing.Size(457, 146);
            this.gbComments.TabIndex = 4;
            this.gbComments.TabStop = false;
            this.gbComments.Text = "Comments:";
            // 
            // tbComments
            // 
            this.tbComments.BackColor = System.Drawing.SystemColors.Window;
            this.tbComments.Location = new System.Drawing.Point(6, 19);
            this.tbComments.Multiline = true;
            this.tbComments.Name = "tbComments";
            this.tbComments.ReadOnly = true;
            this.tbComments.Size = new System.Drawing.Size(445, 121);
            this.tbComments.TabIndex = 0;
            // 
            // cbShowOption
            // 
            this.cbShowOption.AutoSize = true;
            this.cbShowOption.Checked = true;
            this.cbShowOption.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowOption.Location = new System.Drawing.Point(762, 144);
            this.cbShowOption.Name = "cbShowOption";
            this.cbShowOption.Size = new System.Drawing.Size(160, 17);
            this.cbShowOption.TabIndex = 5;
            this.cbShowOption.Text = "Show open work orders only";
            this.cbShowOption.UseVisualStyleBackColor = true;
            this.cbShowOption.CheckedChanged += new System.EventHandler(this.cbShowOption_CheckedChanged);
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.btnCloseWorkOrder);
            this.gbOptions.Controls.Add(this.btnUpdateSteps);
            this.gbOptions.Controls.Add(this.btnUpdateDescription);
            this.gbOptions.Controls.Add(this.btnUpdateTitle);
            this.gbOptions.Controls.Add(this.btnAddComment);
            this.gbOptions.Location = new System.Drawing.Point(479, 316);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(443, 146);
            this.gbOptions.TabIndex = 6;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // btnAddComment
            // 
            this.btnAddComment.Location = new System.Drawing.Point(6, 106);
            this.btnAddComment.Name = "btnAddComment";
            this.btnAddComment.Size = new System.Drawing.Size(107, 23);
            this.btnAddComment.TabIndex = 0;
            this.btnAddComment.Text = "Add Comment";
            this.btnAddComment.UseVisualStyleBackColor = true;
            // 
            // btnUpdateTitle
            // 
            this.btnUpdateTitle.Location = new System.Drawing.Point(6, 19);
            this.btnUpdateTitle.Name = "btnUpdateTitle";
            this.btnUpdateTitle.Size = new System.Drawing.Size(107, 23);
            this.btnUpdateTitle.TabIndex = 1;
            this.btnUpdateTitle.Text = "Update Title";
            this.btnUpdateTitle.UseVisualStyleBackColor = true;
            // 
            // btnUpdateDescription
            // 
            this.btnUpdateDescription.Location = new System.Drawing.Point(6, 48);
            this.btnUpdateDescription.Name = "btnUpdateDescription";
            this.btnUpdateDescription.Size = new System.Drawing.Size(107, 23);
            this.btnUpdateDescription.TabIndex = 2;
            this.btnUpdateDescription.Text = "Update Description";
            this.btnUpdateDescription.UseVisualStyleBackColor = true;
            // 
            // btnUpdateSteps
            // 
            this.btnUpdateSteps.Location = new System.Drawing.Point(6, 77);
            this.btnUpdateSteps.Name = "btnUpdateSteps";
            this.btnUpdateSteps.Size = new System.Drawing.Size(107, 23);
            this.btnUpdateSteps.TabIndex = 3;
            this.btnUpdateSteps.Text = "UpdateSteps";
            this.btnUpdateSteps.UseVisualStyleBackColor = true;
            // 
            // btnCloseWorkOrder
            // 
            this.btnCloseWorkOrder.Location = new System.Drawing.Point(119, 19);
            this.btnCloseWorkOrder.Name = "btnCloseWorkOrder";
            this.btnCloseWorkOrder.Size = new System.Drawing.Size(107, 23);
            this.btnCloseWorkOrder.TabIndex = 4;
            this.btnCloseWorkOrder.Text = "Close Work Order";
            this.btnCloseWorkOrder.UseVisualStyleBackColor = true;
            this.btnCloseWorkOrder.Click += new System.EventHandler(this.btnCloseWorkOrder_Click);
            // 
            // WorkOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 501);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.cbShowOption);
            this.Controls.Add(this.gbComments);
            this.Controls.Add(this.gbSteps);
            this.Controls.Add(this.gbDescription);
            this.Controls.Add(this.wOTitle);
            this.Controls.Add(this.dgWorkOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "WorkOrders";
            this.Text = "Insight - Work Orders";
            this.Load += new System.EventHandler(this.WorkOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgWorkOrders)).EndInit();
            this.gbDescription.ResumeLayout(false);
            this.gbDescription.PerformLayout();
            this.gbSteps.ResumeLayout(false);
            this.gbComments.ResumeLayout(false);
            this.gbComments.PerformLayout();
            this.gbOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgWorkOrders;
        private System.Windows.Forms.Label wOTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignedTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.GroupBox gbDescription;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.GroupBox gbSteps;
        private System.Windows.Forms.ListBox lbSteps;
        private System.Windows.Forms.GroupBox gbComments;
        private System.Windows.Forms.TextBox tbComments;
        private System.Windows.Forms.CheckBox cbShowOption;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.Button btnAddComment;
        private System.Windows.Forms.Button btnCloseWorkOrder;
        private System.Windows.Forms.Button btnUpdateSteps;
        private System.Windows.Forms.Button btnUpdateDescription;
        private System.Windows.Forms.Button btnUpdateTitle;
    }
}