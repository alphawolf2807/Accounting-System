
namespace SimpleaccountingSys
{
    partial class frmJournalEntry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJournalEntry));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAccTitle = new System.Windows.Forms.Label();
            this.lblCredit = new System.Windows.Forms.Label();
            this.txtCreditAmt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbAccCredit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpInvoiceDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblDebit = new System.Windows.Forms.Label();
            this.txtDebitAmt = new System.Windows.Forms.TextBox();
            this.cmbAccDebit = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.saveonebutton = new System.Windows.Forms.Button();
            this.oktwobutton = new System.Windows.Forms.Button();
            this.businessbutton3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txtVID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblAccTitle);
            this.panel1.Controls.Add(this.lblCredit);
            this.panel1.Controls.Add(this.txtCreditAmt);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbAccCredit);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpInvoiceDateFrom);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtDesc);
            this.panel1.Controls.Add(this.lblDebit);
            this.panel1.Controls.Add(this.txtDebitAmt);
            this.panel1.Controls.Add(this.cmbAccDebit);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Location = new System.Drawing.Point(12, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 251);
            this.panel1.TabIndex = 91;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblAccTitle
            // 
            this.lblAccTitle.AutoSize = true;
            this.lblAccTitle.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccTitle.Location = new System.Drawing.Point(189, 145);
            this.lblAccTitle.Name = "lblAccTitle";
            this.lblAccTitle.Size = new System.Drawing.Size(111, 15);
            this.lblAccTitle.TabIndex = 171;
            this.lblAccTitle.Text = "Account Title";
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredit.Location = new System.Drawing.Point(556, 145);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(55, 15);
            this.lblCredit.TabIndex = 170;
            this.lblCredit.Text = "Credit";
            // 
            // txtCreditAmt
            // 
            this.txtCreditAmt.Location = new System.Drawing.Point(526, 218);
            this.txtCreditAmt.Name = "txtCreditAmt";
            this.txtCreditAmt.Size = new System.Drawing.Size(158, 20);
            this.txtCreditAmt.TabIndex = 169;
            this.txtCreditAmt.TextChanged += new System.EventHandler(this.textBoxAmt_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 168;
            this.label7.Text = "Cr Account";
            // 
            // cmbAccCredit
            // 
            this.cmbAccCredit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccCredit.FormattingEnabled = true;
            this.cmbAccCredit.Items.AddRange(new object[] {
            "Credit",
            "Debit"});
            this.cmbAccCredit.Location = new System.Drawing.Point(133, 218);
            this.cmbAccCredit.Name = "cmbAccCredit";
            this.cmbAccCredit.Size = new System.Drawing.Size(233, 21);
            this.cmbAccCredit.TabIndex = 167;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 160;
            this.label4.Text = "Date";
            // 
            // dtpInvoiceDateFrom
            // 
            this.dtpInvoiceDateFrom.Location = new System.Drawing.Point(116, 14);
            this.dtpInvoiceDateFrom.Name = "dtpInvoiceDateFrom";
            this.dtpInvoiceDateFrom.Size = new System.Drawing.Size(233, 20);
            this.dtpInvoiceDateFrom.TabIndex = 159;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 158;
            this.label3.Text = "Description";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(116, 51);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDesc.Size = new System.Drawing.Size(446, 25);
            this.txtDesc.TabIndex = 157;
            // 
            // lblDebit
            // 
            this.lblDebit.AutoSize = true;
            this.lblDebit.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebit.Location = new System.Drawing.Point(417, 145);
            this.lblDebit.Name = "lblDebit";
            this.lblDebit.Size = new System.Drawing.Size(45, 15);
            this.lblDebit.TabIndex = 156;
            this.lblDebit.Text = "Debit";
            // 
            // txtDebitAmt
            // 
            this.txtDebitAmt.Location = new System.Drawing.Point(372, 172);
            this.txtDebitAmt.Name = "txtDebitAmt";
            this.txtDebitAmt.Size = new System.Drawing.Size(158, 20);
            this.txtDebitAmt.TabIndex = 155;
            this.txtDebitAmt.TextChanged += new System.EventHandler(this.textBoxAmt_TextChanged);
            // 
            // cmbAccDebit
            // 
            this.cmbAccDebit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccDebit.FormattingEnabled = true;
            this.cmbAccDebit.Location = new System.Drawing.Point(133, 172);
            this.cmbAccDebit.Name = "cmbAccDebit";
            this.cmbAccDebit.Size = new System.Drawing.Size(233, 21);
            this.cmbAccDebit.TabIndex = 114;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(11, 176);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(70, 17);
            this.label24.TabIndex = 115;
            this.label24.Text = "Dr Account";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(69, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 25);
            this.button1.TabIndex = 162;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveonebutton
            // 
            this.saveonebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveonebutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.saveonebutton.Location = new System.Drawing.Point(12, 461);
            this.saveonebutton.Name = "saveonebutton";
            this.saveonebutton.Size = new System.Drawing.Size(50, 25);
            this.saveonebutton.TabIndex = 161;
            this.saveonebutton.Text = "Save";
            this.saveonebutton.UseVisualStyleBackColor = true;
            this.saveonebutton.Click += new System.EventHandler(this.saveonebutton_Click);
            // 
            // oktwobutton
            // 
            this.oktwobutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.oktwobutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.oktwobutton.Location = new System.Drawing.Point(148, 461);
            this.oktwobutton.Name = "oktwobutton";
            this.oktwobutton.Size = new System.Drawing.Size(50, 25);
            this.oktwobutton.TabIndex = 163;
            this.oktwobutton.Text = "Delete";
            this.oktwobutton.UseVisualStyleBackColor = true;
            this.oktwobutton.Click += new System.EventHandler(this.oktwobutton_Click);
            // 
            // businessbutton3
            // 
            this.businessbutton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.businessbutton3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.businessbutton3.Location = new System.Drawing.Point(202, 461);
            this.businessbutton3.Name = "businessbutton3";
            this.businessbutton3.Size = new System.Drawing.Size(50, 25);
            this.businessbutton3.TabIndex = 164;
            this.businessbutton3.Text = "Close";
            this.businessbutton3.UseVisualStyleBackColor = true;
            this.businessbutton3.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView1.Location = new System.Drawing.Point(707, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(562, 428);
            this.dataGridView1.TabIndex = 197;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.dateTimePicker4);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.dateTimePicker3);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(707, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(562, 40);
            this.panel2.TabIndex = 198;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(491, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 25);
            this.button3.TabIndex = 17;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(304, 10);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(181, 20);
            this.dateTimePicker4.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(276, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "To";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(67, 10);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(181, 20);
            this.dateTimePicker3.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "From";
            // 
            // txtVID
            // 
            this.txtVID.Enabled = false;
            this.txtVID.Location = new System.Drawing.Point(129, 42);
            this.txtVID.Name = "txtVID";
            this.txtVID.Size = new System.Drawing.Size(158, 20);
            this.txtVID.TabIndex = 172;
            this.txtVID.Text = "Auto...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 172;
            this.label1.Text = "Voucher ID";
            // 
            // frmJournalEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 498);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVID);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.saveonebutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.oktwobutton);
            this.Controls.Add(this.businessbutton3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmJournalEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "General Journal";
            this.Load += new System.EventHandler(this.frmJournalEntry_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbAccCredit;
        private System.Windows.Forms.Button businessbutton3;
        private System.Windows.Forms.Button oktwobutton;
        private System.Windows.Forms.Button saveonebutton;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpInvoiceDateFrom;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDesc;
        internal System.Windows.Forms.Label lblDebit;
        private System.Windows.Forms.TextBox txtDebitAmt;
        private System.Windows.Forms.ComboBox cmbAccDebit;
        internal System.Windows.Forms.Label label24;
        internal System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.TextBox txtCreditAmt;
        private System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.Label lblAccTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtVID;
        internal System.Windows.Forms.Label label1;
    }
}