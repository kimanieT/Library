namespace mainMDI
{
    partial class ReturnFrm
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
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblBookNumber = new System.Windows.Forms.Label();
            this.lblPersonName = new System.Windows.Forms.Label();
            this.lblPersonId = new System.Windows.Forms.Label();
            this.lblDateToBeReturned = new System.Windows.Forms.Label();
            this.lblDateReturned = new System.Windows.Forms.Label();
            this.txtBookNumber = new System.Windows.Forms.TextBox();
            this.txtPersonName = new System.Windows.Forms.TextBox();
            this.txtPersonId = new System.Windows.Forms.TextBox();
            this.txtDateToBeReturned = new System.Windows.Forms.TextBox();
            this.txtDateReturned = new System.Windows.Forms.TextBox();
            this.lblLateFee = new System.Windows.Forms.Label();
            this.lblBookFee = new System.Windows.Forms.Label();
            this.txtLateFee = new System.Windows.Forms.TextBox();
            this.txtBookFee = new System.Windows.Forms.TextBox();
            this.lblIssue = new System.Windows.Forms.Label();
            this.cobIssue = new System.Windows.Forms.ComboBox();
            this.cobBookTitle = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(289, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(187, 33);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Returned Book";
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Location = new System.Drawing.Point(15, 113);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(52, 13);
            this.lblBookTitle.TabIndex = 1;
            this.lblBookTitle.Text = "BookTitle";
            // 
            // lblBookNumber
            // 
            this.lblBookNumber.AutoSize = true;
            this.lblBookNumber.Location = new System.Drawing.Point(16, 166);
            this.lblBookNumber.Name = "lblBookNumber";
            this.lblBookNumber.Size = new System.Drawing.Size(82, 13);
            this.lblBookNumber.TabIndex = 2;
            this.lblBookNumber.Text = "Book \'s Number";
            // 
            // lblPersonName
            // 
            this.lblPersonName.AutoSize = true;
            this.lblPersonName.Location = new System.Drawing.Point(15, 223);
            this.lblPersonName.Name = "lblPersonName";
            this.lblPersonName.Size = new System.Drawing.Size(78, 13);
            this.lblPersonName.TabIndex = 3;
            this.lblPersonName.Text = "Person\'s Name";
            // 
            // lblPersonId
            // 
            this.lblPersonId.AutoSize = true;
            this.lblPersonId.Location = new System.Drawing.Point(16, 277);
            this.lblPersonId.Name = "lblPersonId";
            this.lblPersonId.Size = new System.Drawing.Size(59, 13);
            this.lblPersonId.TabIndex = 4;
            this.lblPersonId.Text = "Person\'s Id";
            // 
            // lblDateToBeReturned
            // 
            this.lblDateToBeReturned.AutoSize = true;
            this.lblDateToBeReturned.Location = new System.Drawing.Point(15, 332);
            this.lblDateToBeReturned.Name = "lblDateToBeReturned";
            this.lblDateToBeReturned.Size = new System.Drawing.Size(104, 13);
            this.lblDateToBeReturned.TabIndex = 5;
            this.lblDateToBeReturned.Text = "Date to be Returned";
            // 
            // lblDateReturned
            // 
            this.lblDateReturned.AutoSize = true;
            this.lblDateReturned.Location = new System.Drawing.Point(426, 113);
            this.lblDateReturned.Name = "lblDateReturned";
            this.lblDateReturned.Size = new System.Drawing.Size(77, 13);
            this.lblDateReturned.TabIndex = 6;
            this.lblDateReturned.Text = "Date Returned";
            // 
            // txtBookNumber
            // 
            this.txtBookNumber.Location = new System.Drawing.Point(133, 166);
            this.txtBookNumber.Name = "txtBookNumber";
            this.txtBookNumber.Size = new System.Drawing.Size(248, 20);
            this.txtBookNumber.TabIndex = 8;
            // 
            // txtPersonName
            // 
            this.txtPersonName.Location = new System.Drawing.Point(133, 223);
            this.txtPersonName.Name = "txtPersonName";
            this.txtPersonName.Size = new System.Drawing.Size(248, 20);
            this.txtPersonName.TabIndex = 9;
            // 
            // txtPersonId
            // 
            this.txtPersonId.Location = new System.Drawing.Point(133, 277);
            this.txtPersonId.Name = "txtPersonId";
            this.txtPersonId.Size = new System.Drawing.Size(248, 20);
            this.txtPersonId.TabIndex = 10;
            // 
            // txtDateToBeReturned
            // 
            this.txtDateToBeReturned.Location = new System.Drawing.Point(133, 332);
            this.txtDateToBeReturned.Name = "txtDateToBeReturned";
            this.txtDateToBeReturned.Size = new System.Drawing.Size(248, 20);
            this.txtDateToBeReturned.TabIndex = 11;
            // 
            // txtDateReturned
            // 
            this.txtDateReturned.Location = new System.Drawing.Point(513, 110);
            this.txtDateReturned.Name = "txtDateReturned";
            this.txtDateReturned.Size = new System.Drawing.Size(259, 20);
            this.txtDateReturned.TabIndex = 12;
            // 
            // lblLateFee
            // 
            this.lblLateFee.AutoSize = true;
            this.lblLateFee.Location = new System.Drawing.Point(426, 166);
            this.lblLateFee.Name = "lblLateFee";
            this.lblLateFee.Size = new System.Drawing.Size(46, 13);
            this.lblLateFee.TabIndex = 13;
            this.lblLateFee.Text = "Late fee";
            // 
            // lblBookFee
            // 
            this.lblBookFee.AutoSize = true;
            this.lblBookFee.Location = new System.Drawing.Point(426, 216);
            this.lblBookFee.Name = "lblBookFee";
            this.lblBookFee.Size = new System.Drawing.Size(50, 13);
            this.lblBookFee.TabIndex = 14;
            this.lblBookFee.Text = "Book fee";
            // 
            // txtLateFee
            // 
            this.txtLateFee.Location = new System.Drawing.Point(513, 159);
            this.txtLateFee.Name = "txtLateFee";
            this.txtLateFee.Size = new System.Drawing.Size(259, 20);
            this.txtLateFee.TabIndex = 15;
            // 
            // txtBookFee
            // 
            this.txtBookFee.Location = new System.Drawing.Point(513, 223);
            this.txtBookFee.Name = "txtBookFee";
            this.txtBookFee.Size = new System.Drawing.Size(259, 20);
            this.txtBookFee.TabIndex = 16;
            // 
            // lblIssue
            // 
            this.lblIssue.AutoSize = true;
            this.lblIssue.Location = new System.Drawing.Point(426, 276);
            this.lblIssue.Name = "lblIssue";
            this.lblIssue.Size = new System.Drawing.Size(32, 13);
            this.lblIssue.TabIndex = 17;
            this.lblIssue.Text = "Issue";
            // 
            // cobIssue
            // 
            this.cobIssue.FormattingEnabled = true;
            this.cobIssue.Items.AddRange(new object[] {
            "None",
            "Lost",
            "Stolen",
            "Dismantle"});
            this.cobIssue.Location = new System.Drawing.Point(513, 273);
            this.cobIssue.Name = "cobIssue";
            this.cobIssue.Size = new System.Drawing.Size(259, 21);
            this.cobIssue.TabIndex = 18;
            this.cobIssue.Text = "Select an issue";
            // 
            // cobBookTitle
            // 
            this.cobBookTitle.FormattingEnabled = true;
            this.cobBookTitle.Location = new System.Drawing.Point(133, 111);
            this.cobBookTitle.Name = "cobBookTitle";
            this.cobBookTitle.Size = new System.Drawing.Size(248, 21);
            this.cobBookTitle.TabIndex = 19;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(340, 396);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(439, 396);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ReturnFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cobBookTitle);
            this.Controls.Add(this.cobIssue);
            this.Controls.Add(this.lblIssue);
            this.Controls.Add(this.txtBookFee);
            this.Controls.Add(this.txtLateFee);
            this.Controls.Add(this.lblBookFee);
            this.Controls.Add(this.lblLateFee);
            this.Controls.Add(this.txtDateReturned);
            this.Controls.Add(this.txtDateToBeReturned);
            this.Controls.Add(this.txtPersonId);
            this.Controls.Add(this.txtPersonName);
            this.Controls.Add(this.txtBookNumber);
            this.Controls.Add(this.lblDateReturned);
            this.Controls.Add(this.lblDateToBeReturned);
            this.Controls.Add(this.lblPersonId);
            this.Controls.Add(this.lblPersonName);
            this.Controls.Add(this.lblBookNumber);
            this.Controls.Add(this.lblBookTitle);
            this.Controls.Add(this.lblTitle);
            this.Name = "ReturnFrm";
            this.Text = "CollectFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblBookNumber;
        private System.Windows.Forms.Label lblPersonName;
        private System.Windows.Forms.Label lblPersonId;
        private System.Windows.Forms.Label lblDateToBeReturned;
        private System.Windows.Forms.Label lblDateReturned;
        private System.Windows.Forms.TextBox txtBookNumber;
        private System.Windows.Forms.TextBox txtPersonName;
        private System.Windows.Forms.TextBox txtPersonId;
        private System.Windows.Forms.TextBox txtDateToBeReturned;
        private System.Windows.Forms.TextBox txtDateReturned;
        private System.Windows.Forms.Label lblLateFee;
        private System.Windows.Forms.Label lblBookFee;
        private System.Windows.Forms.TextBox txtLateFee;
        private System.Windows.Forms.TextBox txtBookFee;
        private System.Windows.Forms.Label lblIssue;
        private System.Windows.Forms.ComboBox cobIssue;
        private System.Windows.Forms.ComboBox cobBookTitle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}