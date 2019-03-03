namespace mainMDI
{
    partial class LoanFrm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.cobBookTitle = new System.Windows.Forms.ComboBox();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblBookNumber = new System.Windows.Forms.Label();
            this.lblPersonId = new System.Windows.Forms.Label();
            this.lblPersonName = new System.Windows.Forms.Label();
            this.lblDateIssue = new System.Windows.Forms.Label();
            this.lblDateToBeReturned = new System.Windows.Forms.Label();
            this.txtBookNumber = new System.Windows.Forms.TextBox();
            this.txtPersonName = new System.Windows.Forms.TextBox();
            this.txtDateToBeReturned = new System.Windows.Forms.TextBox();
            this.txtDateIssue = new System.Windows.Forms.TextBox();
            this.txtPersonId = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblLibarian = new System.Windows.Forms.Label();
            this.txtLibarian = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(340, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(140, 33);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Loan Book";
            // 
            // cobBookTitle
            // 
            this.cobBookTitle.FormattingEnabled = true;
            this.cobBookTitle.Location = new System.Drawing.Point(231, 97);
            this.cobBookTitle.Name = "cobBookTitle";
            this.cobBookTitle.Size = new System.Drawing.Size(415, 21);
            this.cobBookTitle.TabIndex = 1;
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Location = new System.Drawing.Point(120, 97);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(62, 13);
            this.lblBookTitle.TabIndex = 2;
            this.lblBookTitle.Text = "Book\'s Title";
            // 
            // lblBookNumber
            // 
            this.lblBookNumber.AutoSize = true;
            this.lblBookNumber.Location = new System.Drawing.Point(120, 148);
            this.lblBookNumber.Name = "lblBookNumber";
            this.lblBookNumber.Size = new System.Drawing.Size(79, 13);
            this.lblBookNumber.TabIndex = 3;
            this.lblBookNumber.Text = "Book\'s Number";
            // 
            // lblPersonId
            // 
            this.lblPersonId.AutoSize = true;
            this.lblPersonId.Location = new System.Drawing.Point(120, 241);
            this.lblPersonId.Name = "lblPersonId";
            this.lblPersonId.Size = new System.Drawing.Size(58, 13);
            this.lblPersonId.TabIndex = 4;
            this.lblPersonId.Text = "Person\'s id";
            // 
            // lblPersonName
            // 
            this.lblPersonName.AutoSize = true;
            this.lblPersonName.Location = new System.Drawing.Point(120, 196);
            this.lblPersonName.Name = "lblPersonName";
            this.lblPersonName.Size = new System.Drawing.Size(78, 13);
            this.lblPersonName.TabIndex = 5;
            this.lblPersonName.Text = "Person\'s Name";
            // 
            // lblDateIssue
            // 
            this.lblDateIssue.AutoSize = true;
            this.lblDateIssue.Location = new System.Drawing.Point(120, 333);
            this.lblDateIssue.Name = "lblDateIssue";
            this.lblDateIssue.Size = new System.Drawing.Size(58, 13);
            this.lblDateIssue.TabIndex = 6;
            this.lblDateIssue.Text = "Date Issue";
            // 
            // lblDateToBeReturned
            // 
            this.lblDateToBeReturned.AutoSize = true;
            this.lblDateToBeReturned.Location = new System.Drawing.Point(120, 378);
            this.lblDateToBeReturned.Name = "lblDateToBeReturned";
            this.lblDateToBeReturned.Size = new System.Drawing.Size(99, 13);
            this.lblDateToBeReturned.TabIndex = 7;
            this.lblDateToBeReturned.Text = "Date to be returned";
            // 
            // txtBookNumber
            // 
            this.txtBookNumber.Location = new System.Drawing.Point(231, 148);
            this.txtBookNumber.Name = "txtBookNumber";
            this.txtBookNumber.Size = new System.Drawing.Size(415, 20);
            this.txtBookNumber.TabIndex = 8;
            // 
            // txtPersonName
            // 
            this.txtPersonName.Location = new System.Drawing.Point(231, 196);
            this.txtPersonName.Name = "txtPersonName";
            this.txtPersonName.Size = new System.Drawing.Size(415, 20);
            this.txtPersonName.TabIndex = 9;
            // 
            // txtDateToBeReturned
            // 
            this.txtDateToBeReturned.Location = new System.Drawing.Point(231, 378);
            this.txtDateToBeReturned.Name = "txtDateToBeReturned";
            this.txtDateToBeReturned.Size = new System.Drawing.Size(415, 20);
            this.txtDateToBeReturned.TabIndex = 10;
            // 
            // txtDateIssue
            // 
            this.txtDateIssue.Location = new System.Drawing.Point(231, 333);
            this.txtDateIssue.Name = "txtDateIssue";
            this.txtDateIssue.Size = new System.Drawing.Size(415, 20);
            this.txtDateIssue.TabIndex = 11;
            // 
            // txtPersonId
            // 
            this.txtPersonId.Location = new System.Drawing.Point(231, 241);
            this.txtPersonId.Name = "txtPersonId";
            this.txtPersonId.Size = new System.Drawing.Size(415, 20);
            this.txtPersonId.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(424, 420);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(327, 420);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblLibarian
            // 
            this.lblLibarian.AutoSize = true;
            this.lblLibarian.Location = new System.Drawing.Point(120, 289);
            this.lblLibarian.Name = "lblLibarian";
            this.lblLibarian.Size = new System.Drawing.Size(44, 13);
            this.lblLibarian.TabIndex = 15;
            this.lblLibarian.Text = "Libarian";
            // 
            // txtLibarian
            // 
            this.txtLibarian.Location = new System.Drawing.Point(231, 289);
            this.txtLibarian.Name = "txtLibarian";
            this.txtLibarian.Size = new System.Drawing.Size(415, 20);
            this.txtLibarian.TabIndex = 16;
            // 
            // LoanFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.txtLibarian);
            this.Controls.Add(this.lblLibarian);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPersonId);
            this.Controls.Add(this.txtDateIssue);
            this.Controls.Add(this.txtDateToBeReturned);
            this.Controls.Add(this.txtPersonName);
            this.Controls.Add(this.txtBookNumber);
            this.Controls.Add(this.lblDateToBeReturned);
            this.Controls.Add(this.lblDateIssue);
            this.Controls.Add(this.lblPersonName);
            this.Controls.Add(this.lblPersonId);
            this.Controls.Add(this.lblBookNumber);
            this.Controls.Add(this.lblBookTitle);
            this.Controls.Add(this.cobBookTitle);
            this.Controls.Add(this.lblTitle);
            this.Name = "LoanFrm";
            this.Text = "LoanFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cobBookTitle;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblBookNumber;
        private System.Windows.Forms.Label lblPersonId;
        private System.Windows.Forms.Label lblPersonName;
        private System.Windows.Forms.Label lblDateIssue;
        private System.Windows.Forms.Label lblDateToBeReturned;
        private System.Windows.Forms.TextBox txtBookNumber;
        private System.Windows.Forms.TextBox txtPersonName;
        private System.Windows.Forms.TextBox txtDateToBeReturned;
        private System.Windows.Forms.TextBox txtDateIssue;
        private System.Windows.Forms.TextBox txtPersonId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblLibarian;
        private System.Windows.Forms.TextBox txtLibarian;
    }
}