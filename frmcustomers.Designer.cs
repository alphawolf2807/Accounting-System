namespace SimpleaccountingSys
{
    partial class frmcustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcustomers));
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1acctno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.businessbutton3 = new System.Windows.Forms.Button();
            this.oktwobutton = new System.Windows.Forms.Button();
            this.saveonebutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxaccounts = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1address = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 196;
            this.label5.Text = "Phone no";
            // 
            // textBox1acctno
            // 
            this.textBox1acctno.Location = new System.Drawing.Point(127, 93);
            this.textBox1acctno.Name = "textBox1acctno";
            this.textBox1acctno.Size = new System.Drawing.Size(170, 20);
            this.textBox1acctno.TabIndex = 195;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 192;
            this.label1.Text = "Address";
            // 
            // businessbutton3
            // 
            this.businessbutton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.businessbutton3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.businessbutton3.Location = new System.Drawing.Point(236, 287);
            this.businessbutton3.Name = "businessbutton3";
            this.businessbutton3.Size = new System.Drawing.Size(50, 25);
            this.businessbutton3.TabIndex = 190;
            this.businessbutton3.Text = "Close";
            this.businessbutton3.UseVisualStyleBackColor = true;
            this.businessbutton3.Visible = false;
            // 
            // oktwobutton
            // 
            this.oktwobutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.oktwobutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.oktwobutton.Location = new System.Drawing.Point(182, 287);
            this.oktwobutton.Name = "oktwobutton";
            this.oktwobutton.Size = new System.Drawing.Size(50, 25);
            this.oktwobutton.TabIndex = 189;
            this.oktwobutton.Text = "Delete";
            this.oktwobutton.UseVisualStyleBackColor = true;
            this.oktwobutton.Click += new System.EventHandler(this.oktwobutton_Click);
            // 
            // saveonebutton
            // 
            this.saveonebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveonebutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.saveonebutton.Location = new System.Drawing.Point(29, 287);
            this.saveonebutton.Name = "saveonebutton";
            this.saveonebutton.Size = new System.Drawing.Size(68, 25);
            this.saveonebutton.TabIndex = 187;
            this.saveonebutton.Text = "Save";
            this.saveonebutton.UseVisualStyleBackColor = true;
            this.saveonebutton.Click += new System.EventHandler(this.saveonebutton_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(103, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 25);
            this.button1.TabIndex = 188;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 186;
            this.label2.Text = "Customer Name";
            // 
            // textBoxaccounts
            // 
            this.textBoxaccounts.Location = new System.Drawing.Point(127, 47);
            this.textBoxaccounts.Name = "textBoxaccounts";
            this.textBoxaccounts.Size = new System.Drawing.Size(170, 20);
            this.textBoxaccounts.TabIndex = 185;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(318, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 305);
            this.dataGridView1.TabIndex = 184;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // textBox1address
            // 
            this.textBox1address.Location = new System.Drawing.Point(127, 142);
            this.textBox1address.Multiline = true;
            this.textBox1address.Name = "textBox1address";
            this.textBox1address.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1address.Size = new System.Drawing.Size(170, 51);
            this.textBox1address.TabIndex = 197;
            // 
            // frmcustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 329);
            this.Controls.Add(this.textBox1address);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1acctno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.businessbutton3);
            this.Controls.Add(this.oktwobutton);
            this.Controls.Add(this.saveonebutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxaccounts);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmcustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customer Form";
            this.Load += new System.EventHandler(this.frmcustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1acctno;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button businessbutton3;
        private System.Windows.Forms.Button oktwobutton;
        private System.Windows.Forms.Button saveonebutton;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxaccounts;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1address;
    }
}