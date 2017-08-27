namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.comboBoxSubCategory = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxAuthorName = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxAuthorName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxIssueTo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxIssued = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerPurchasedOn = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonReferenceBook = new System.Windows.Forms.RadioButton();
            this.radioButtonTextBook = new System.Windows.Forms.RadioButton();
            this.radioButtonJournal = new System.Windows.Forms.RadioButton();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.dateTimePickerIssueDate = new System.Windows.Forms.DateTimePicker();
            this.buttonMove = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sub Category:";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(189, 111);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(181, 21);
            this.comboBoxCategory.TabIndex = 2;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // comboBoxSubCategory
            // 
            this.comboBoxSubCategory.FormattingEnabled = true;
            this.comboBoxSubCategory.Location = new System.Drawing.Point(189, 139);
            this.comboBoxSubCategory.Name = "comboBoxSubCategory";
            this.comboBoxSubCategory.Size = new System.Drawing.Size(181, 21);
            this.comboBoxSubCategory.TabIndex = 3;
            this.comboBoxSubCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubCategory_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxAuthorName);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.textBoxAuthorName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(15, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 251);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Authors";
            // 
            // listBoxAuthorName
            // 
            this.listBoxAuthorName.FormattingEnabled = true;
            this.listBoxAuthorName.Location = new System.Drawing.Point(174, 87);
            this.listBoxAuthorName.Name = "listBoxAuthorName";
            this.listBoxAuthorName.Size = new System.Drawing.Size(100, 134);
            this.listBoxAuthorName.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(292, 39);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(57, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxAuthorName
            // 
            this.textBoxAuthorName.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.textBoxAuthorName.Location = new System.Drawing.Point(174, 39);
            this.textBoxAuthorName.Name = "textBoxAuthorName";
            this.textBoxAuthorName.Size = new System.Drawing.Size(100, 20);
            this.textBoxAuthorName.TabIndex = 1;
            this.textBoxAuthorName.TextChanged += new System.EventHandler(this.textBoxAuthorName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Author Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePickerIssueDate);
            this.groupBox2.Controls.Add(this.textBoxIssueTo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.checkBoxIssued);
            this.groupBox2.Location = new System.Drawing.Point(173, 415);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 136);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Issuance";
            // 
            // textBoxIssueTo
            // 
            this.textBoxIssueTo.Location = new System.Drawing.Point(94, 62);
            this.textBoxIssueTo.Name = "textBoxIssueTo";
            this.textBoxIssueTo.Size = new System.Drawing.Size(100, 20);
            this.textBoxIssueTo.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Issue Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Issued To:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // checkBoxIssued
            // 
            this.checkBoxIssued.AutoSize = true;
            this.checkBoxIssued.Location = new System.Drawing.Point(6, 29);
            this.checkBoxIssued.Name = "checkBoxIssued";
            this.checkBoxIssued.Size = new System.Drawing.Size(63, 17);
            this.checkBoxIssued.TabIndex = 0;
            this.checkBoxIssued.Text = "Issued: ";
            this.checkBoxIssued.UseVisualStyleBackColor = true;
            this.checkBoxIssued.CheckedChanged += new System.EventHandler(this.checkBoxIssued_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "ISBN:";
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(189, 29);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(181, 20);
            this.textBoxISBN.TabIndex = 6;
            this.textBoxISBN.TextChanged += new System.EventHandler(this.textBoxISBN_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Title";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(189, 59);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(181, 20);
            this.textBoxTitle.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Purchased On:";
            // 
            // dateTimePickerPurchasedOn
            // 
            this.dateTimePickerPurchasedOn.Location = new System.Drawing.Point(189, 85);
            this.dateTimePickerPurchasedOn.Name = "dateTimePickerPurchasedOn";
            this.dateTimePickerPurchasedOn.Size = new System.Drawing.Size(181, 20);
            this.dateTimePickerPurchasedOn.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonJournal);
            this.groupBox3.Controls.Add(this.radioButtonTextBook);
            this.groupBox3.Controls.Add(this.radioButtonReferenceBook);
            this.groupBox3.Location = new System.Drawing.Point(15, 408);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(152, 143);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Type";
            // 
            // radioButtonReferenceBook
            // 
            this.radioButtonReferenceBook.AutoSize = true;
            this.radioButtonReferenceBook.Location = new System.Drawing.Point(9, 40);
            this.radioButtonReferenceBook.Name = "radioButtonReferenceBook";
            this.radioButtonReferenceBook.Size = new System.Drawing.Size(103, 17);
            this.radioButtonReferenceBook.TabIndex = 11;
            this.radioButtonReferenceBook.TabStop = true;
            this.radioButtonReferenceBook.Text = "Reference Book";
            this.radioButtonReferenceBook.UseVisualStyleBackColor = true;
            this.radioButtonReferenceBook.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonTextBook
            // 
            this.radioButtonTextBook.AutoSize = true;
            this.radioButtonTextBook.Location = new System.Drawing.Point(9, 60);
            this.radioButtonTextBook.Name = "radioButtonTextBook";
            this.radioButtonTextBook.Size = new System.Drawing.Size(74, 17);
            this.radioButtonTextBook.TabIndex = 12;
            this.radioButtonTextBook.TabStop = true;
            this.radioButtonTextBook.Text = "Text Book";
            this.radioButtonTextBook.UseVisualStyleBackColor = true;
            // 
            // radioButtonJournal
            // 
            this.radioButtonJournal.AutoSize = true;
            this.radioButtonJournal.Location = new System.Drawing.Point(9, 83);
            this.radioButtonJournal.Name = "radioButtonJournal";
            this.radioButtonJournal.Size = new System.Drawing.Size(59, 17);
            this.radioButtonJournal.TabIndex = 13;
            this.radioButtonJournal.TabStop = true;
            this.radioButtonJournal.Text = "Journal";
            this.radioButtonJournal.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(214, 563);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 11;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(298, 563);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 12;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // dateTimePickerIssueDate
            // 
            this.dateTimePickerIssueDate.Location = new System.Drawing.Point(94, 91);
            this.dateTimePickerIssueDate.Name = "dateTimePickerIssueDate";
            this.dateTimePickerIssueDate.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerIssueDate.TabIndex = 4;
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(15, 563);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(152, 23);
            this.buttonMove.TabIndex = 13;
            this.buttonMove.Text = "Move To Library";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 598);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dateTimePickerPurchasedOn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxSubCategory);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.ComboBox comboBoxSubCategory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxAuthorName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxAuthorName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxIssueTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxIssued;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerPurchasedOn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonReferenceBook;
        private System.Windows.Forms.RadioButton radioButtonJournal;
        private System.Windows.Forms.RadioButton radioButtonTextBook;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DateTimePicker dateTimePickerIssueDate;
        private System.Windows.Forms.Button buttonMove;
    }
}

