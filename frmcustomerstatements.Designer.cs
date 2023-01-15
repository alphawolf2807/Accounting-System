namespace SimpleaccountingSys
{
    partial class frmcustomerstatements
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcustomerstatements));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExport = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1acct = new System.Windows.Forms.ComboBox();
            this.button1ok = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblRecord = new System.Windows.Forms.Label();
            this.txtTotalCredit = new System.Windows.Forms.TextBox();
            this.txtTotalDebit = new System.Windows.Forms.TextBox();
            this.lblTotalCredit = new System.Windows.Forms.Label();
            this.lblTotalDebit = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buttonExport);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox1acct);
            this.panel1.Controls.Add(this.button1ok);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 58);
            this.panel1.TabIndex = 3;
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(452, 27);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(75, 23);
            this.buttonExport.TabIndex = 116;
            this.buttonExport.Text = "Export CSV";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(33, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 113;
            this.label3.Text = "Customer Name";
            // 
            // comboBox1acct
            // 
            this.comboBox1acct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1acct.FormattingEnabled = true;
            this.comboBox1acct.Location = new System.Drawing.Point(179, 6);
            this.comboBox1acct.Name = "comboBox1acct";
            this.comboBox1acct.Size = new System.Drawing.Size(170, 21);
            this.comboBox1acct.TabIndex = 112;
            // 
            // button1ok
            // 
            this.button1ok.Location = new System.Drawing.Point(371, 27);
            this.button1ok.Name = "button1ok";
            this.button1ok.Size = new System.Drawing.Size(75, 23);
            this.button1ok.TabIndex = 4;
            this.button1ok.Text = "OK";
            this.button1ok.UseVisualStyleBackColor = true;
            this.button1ok.Click += new System.EventHandler(this.button1ok_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "To";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(205, 30);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(145, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(36, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(122, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1081, 342);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Location = new System.Drawing.Point(38, 449);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(89, 13);
            this.lblRecord.TabIndex = 15;
            this.lblRecord.Text = "Total Records : 0";
            // 
            // txtTotalCredit
            // 
            this.txtTotalCredit.Location = new System.Drawing.Point(678, 442);
            this.txtTotalCredit.Name = "txtTotalCredit";
            this.txtTotalCredit.Size = new System.Drawing.Size(175, 20);
            this.txtTotalCredit.TabIndex = 12;
            // 
            // txtTotalDebit
            // 
            this.txtTotalDebit.Location = new System.Drawing.Point(918, 442);
            this.txtTotalDebit.Name = "txtTotalDebit";
            this.txtTotalDebit.Size = new System.Drawing.Size(175, 20);
            this.txtTotalDebit.TabIndex = 11;
            // 
            // lblTotalCredit
            // 
            this.lblTotalCredit.AutoSize = true;
            this.lblTotalCredit.Location = new System.Drawing.Point(611, 445);
            this.lblTotalCredit.Name = "lblTotalCredit";
            this.lblTotalCredit.Size = new System.Drawing.Size(61, 13);
            this.lblTotalCredit.TabIndex = 17;
            this.lblTotalCredit.Text = "Total Credit";
            // 
            // lblTotalDebit
            // 
            this.lblTotalDebit.AutoSize = true;
            this.lblTotalDebit.Location = new System.Drawing.Point(853, 445);
            this.lblTotalDebit.Name = "lblTotalDebit";
            this.lblTotalDebit.Size = new System.Drawing.Size(59, 13);
            this.lblTotalDebit.TabIndex = 16;
            this.lblTotalDebit.Text = "Total Debit";
            // 
            // frmcustomerstatements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 475);
            this.Controls.Add(this.lblTotalCredit);
            this.Controls.Add(this.lblTotalDebit);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.txtTotalCredit);
            this.Controls.Add(this.txtTotalDebit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmcustomerstatements";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customer Statement";
            this.Load += new System.EventHandler(this.frmcustomerstatements_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

         
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1ok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1acct;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.TextBox txtTotalCredit;
        private System.Windows.Forms.TextBox txtTotalDebit;
        private System.Windows.Forms.Label lblTotalCredit;
        private System.Windows.Forms.Label lblTotalDebit;
        private System.Windows.Forms.Button buttonExport;
    }
}