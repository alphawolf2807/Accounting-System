
namespace SimpleaccountingSys
{
    partial class frmReceiptVoucher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReceiptVoucher));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1accts = new System.Windows.Forms.ComboBox();
            this.comboBoxdbcr = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpInvoiceDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1partic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxdramt = new System.Windows.Forms.TextBox();
            this.comboBoxcust = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1acct = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.businessbutton3 = new System.Windows.Forms.Button();
            this.oktwobutton = new System.Windows.Forms.Button();
            this.saveonebutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.comboBox1accts);
            this.panel1.Controls.Add(this.comboBoxdbcr);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpInvoiceDateFrom);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox1partic);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxdramt);
            this.panel1.Controls.Add(this.comboBoxcust);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1acct);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Location = new System.Drawing.Point(7, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 359);
            this.panel1.TabIndex = 198;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 168;
            this.label7.Text = "Accounts";
            // 
            // comboBox1accts
            // 
            this.comboBox1accts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1accts.FormattingEnabled = true;
            this.comboBox1accts.Items.AddRange(new object[] {
            "Credit",
            "Debit"});
            this.comboBox1accts.Location = new System.Drawing.Point(126, 154);
            this.comboBox1accts.Name = "comboBox1accts";
            this.comboBox1accts.Size = new System.Drawing.Size(233, 21);
            this.comboBox1accts.TabIndex = 167;
            // 
            // comboBoxdbcr
            // 
            this.comboBoxdbcr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxdbcr.FormattingEnabled = true;
            this.comboBoxdbcr.Items.AddRange(new object[] {
            "Credit",
            "Debit"});
            this.comboBoxdbcr.Location = new System.Drawing.Point(7, 335);
            this.comboBoxdbcr.Name = "comboBoxdbcr";
            this.comboBoxdbcr.Size = new System.Drawing.Size(127, 21);
            this.comboBoxdbcr.TabIndex = 165;
            this.comboBoxdbcr.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 166;
            this.label5.Text = "Post To";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 160;
            this.label4.Text = "Date";
            // 
            // dtpInvoiceDateFrom
            // 
            this.dtpInvoiceDateFrom.Location = new System.Drawing.Point(126, 111);
            this.dtpInvoiceDateFrom.Name = "dtpInvoiceDateFrom";
            this.dtpInvoiceDateFrom.Size = new System.Drawing.Size(233, 20);
            this.dtpInvoiceDateFrom.TabIndex = 159;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 158;
            this.label3.Text = "Particulars";
            // 
            // textBox1partic
            // 
            this.textBox1partic.Location = new System.Drawing.Point(126, 247);
            this.textBox1partic.Multiline = true;
            this.textBox1partic.Name = "textBox1partic";
            this.textBox1partic.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1partic.Size = new System.Drawing.Size(233, 107);
            this.textBox1partic.TabIndex = 157;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 156;
            this.label2.Text = "Amount";
            // 
            // textBoxdramt
            // 
            this.textBoxdramt.Location = new System.Drawing.Point(126, 200);
            this.textBoxdramt.Name = "textBoxdramt";
            this.textBoxdramt.Size = new System.Drawing.Size(233, 20);
            this.textBoxdramt.TabIndex = 155;
            this.textBoxdramt.TextChanged += new System.EventHandler(this.textBoxdrsalary_TextChanged);
            // 
            // comboBoxcust
            // 
            this.comboBoxcust.FormattingEnabled = true;
            this.comboBoxcust.Location = new System.Drawing.Point(126, 67);
            this.comboBoxcust.Name = "comboBoxcust";
            this.comboBoxcust.Size = new System.Drawing.Size(233, 21);
            this.comboBoxcust.TabIndex = 116;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 117;
            this.label1.Text = "Name";
            // 
            // comboBox1acct
            // 
            this.comboBox1acct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1acct.FormattingEnabled = true;
            this.comboBox1acct.Location = new System.Drawing.Point(126, 25);
            this.comboBox1acct.Name = "comboBox1acct";
            this.comboBox1acct.Size = new System.Drawing.Size(233, 21);
            this.comboBox1acct.TabIndex = 114;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(11, 29);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(67, 17);
            this.label24.TabIndex = 115;
            this.label24.Text = "Cash/Bank";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.dateTimePicker4);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.dateTimePicker3);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(446, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(724, 40);
            this.panel2.TabIndex = 197;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(649, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 25);
            this.button3.TabIndex = 17;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(462, 10);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(181, 20);
            this.dateTimePicker4.TabIndex = 16;
            this.dateTimePicker4.Value = new System.DateTime(2021, 11, 27, 18, 56, 41, 0);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(432, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "To";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(225, 10);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(181, 20);
            this.dateTimePicker3.TabIndex = 15;
            this.dateTimePicker3.Value = new System.DateTime(2021, 11, 27, 18, 56, 25, 0);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(180, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "From";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(446, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(724, 381);
            this.dataGridView1.TabIndex = 196;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // businessbutton3
            // 
            this.businessbutton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.businessbutton3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.businessbutton3.Location = new System.Drawing.Point(205, 411);
            this.businessbutton3.Name = "businessbutton3";
            this.businessbutton3.Size = new System.Drawing.Size(50, 25);
            this.businessbutton3.TabIndex = 202;
            this.businessbutton3.Text = "Close";
            this.businessbutton3.UseVisualStyleBackColor = true;
            this.businessbutton3.Visible = false;
            // 
            // oktwobutton
            // 
            this.oktwobutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.oktwobutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.oktwobutton.Location = new System.Drawing.Point(151, 411);
            this.oktwobutton.Name = "oktwobutton";
            this.oktwobutton.Size = new System.Drawing.Size(50, 25);
            this.oktwobutton.TabIndex = 201;
            this.oktwobutton.Text = "Delete";
            this.oktwobutton.UseVisualStyleBackColor = true;
            this.oktwobutton.Click += new System.EventHandler(this.oktwobutton_Click);
            // 
            // saveonebutton
            // 
            this.saveonebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveonebutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.saveonebutton.Location = new System.Drawing.Point(15, 411);
            this.saveonebutton.Name = "saveonebutton";
            this.saveonebutton.Size = new System.Drawing.Size(50, 25);
            this.saveonebutton.TabIndex = 199;
            this.saveonebutton.Text = "Save";
            this.saveonebutton.UseVisualStyleBackColor = true;
            this.saveonebutton.Click += new System.EventHandler(this.saveonebutton_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(72, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 25);
            this.button1.TabIndex = 200;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmReceiptVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 448);
            this.Controls.Add(this.businessbutton3);
            this.Controls.Add(this.oktwobutton);
            this.Controls.Add(this.saveonebutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReceiptVoucher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Receipt Voucher";
            this.Load += new System.EventHandler(this.frmReceiptVoucher_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1accts;
        private System.Windows.Forms.ComboBox comboBoxdbcr;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpInvoiceDateFrom;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1partic;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxdramt;
        private System.Windows.Forms.ComboBox comboBoxcust;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1acct;
        internal System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button businessbutton3;
        private System.Windows.Forms.Button oktwobutton;
        private System.Windows.Forms.Button saveonebutton;
        private System.Windows.Forms.Button button1;
    }
}