using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using College_Management_System;
using System.Data.SqlClient;

namespace SimpleaccountingSys
{
    public partial class frmcashbank : Form
    {
        public frmcashbank()
        {
            InitializeComponent();
        }
        ConnectionString cs = new ConnectionString();
        SqlCommand cmd = null;
        private void saveonebutton_Click(object sender, EventArgs e)
        {
            if (comboBox1acctype.Text == "")
            {
                MessageBox.Show("Please enter account type");
                return;
            }
            if (textBoxaccounts.Text == "")
            {
                MessageBox.Show("Please enter account");
                textBoxaccounts.Focus();
                return;
            }
            SqlConnection con = new SqlConnection(cs.DBConn);
            con.Open();

            string cb2 = "insert into Cash_Bank (Cash_type,Category,Account_No,is_deleted) values(@a1,@a2,@a3,0) ";

            cmd = new SqlCommand(cb2);
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@a1", textBoxaccounts.Text);//
            cmd.Parameters.AddWithValue("@a2", comboBox1acctype.Text);//
            cmd.Parameters.AddWithValue("@a3", textBox1acctno.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Saved successfully.");
            reset();
            load();
        }
        string accountid = "";
        void reset()
        {
            textBoxaccounts.Text = "";
            comboBox1acctype.Text = "";
            accountid = "";
            textBox1acctno.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1acctype.Text == "")
            {
                MessageBox.Show("Please enter account type");
                return;
            }
            if (textBoxaccounts.Text == "")
            {
                MessageBox.Show("Please enter account");
                textBoxaccounts.Focus();
                return;
            }
            SqlConnection con = new SqlConnection(cs.DBConn);
            con.Open();

            string cb2 = "update Cash_Bank set Cash_type=@a1,Category=@a2,Account_No=@a4 where id=@a3 and isnull(is_deleted,0)=0 ";

            cmd = new SqlCommand(cb2);
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@a1", textBoxaccounts.Text);
            cmd.Parameters.AddWithValue("@a2", comboBox1acctype.Text);
            cmd.Parameters.AddWithValue("@a4", textBox1acctno.Text);
            cmd.Parameters.AddWithValue("@a3", accountid);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated successfully.");
            reset();
            load();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try { 
            reset();//clear data from textbox or combo before adding selected item
            int ty = e.RowIndex;

            accountid = dataGridView1[0, ty].Value.ToString().Trim();// id is located in column 0
            if (accountid == "")// check it is not empty
            {
                MessageBox.Show("Please ensure you select the right data");
                return;
            }
            SqlConnection con = new SqlConnection(cs.DBConn);
            con.Open();

            string activitylog = "select * from Cash_Bank where id=@a1 and isnull(Cash_Bank.is_deleted,0)=0 ";//select item to update based on id selected from grid


            cmd = new SqlCommand(activitylog, con);
            cmd.Parameters.AddWithValue("@a1", SqlDbType.Int).Value = accountid;
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                textBoxaccounts.Text=rdr[1].ToString().Trim();// pass value to textbox or combox
                comboBox1acctype.Text=rdr[2].ToString().Trim();// pass value to textbox or combox
                textBox1acctno.Text=rdr[3].ToString().Trim();// pass value to textbox or combox

               
            }
            rdr.Close();
            con.Close();
            }
            catch (Exception ex) { }
        }
        void load()
        {
            SqlConnection con = new SqlConnection(cs.DBConn);
            con.Open();
            DataSet sqlDatasetbunit = new DataSet();
            SqlDataAdapter FacultyDataAdapter2 = new SqlDataAdapter();

            string cb2 = "select * from Cash_Bank where isnull(Cash_Bank.is_deleted,0)=0 ";

            cmd = new SqlCommand(cb2);
            cmd.Connection = con;
            FacultyDataAdapter2.SelectCommand = cmd;
            FacultyDataAdapter2.Fill(sqlDatasetbunit, "Cash_Bank");
            dataGridView1.DataSource = sqlDatasetbunit.Tables[0];
            dataGridView1.Columns[0].Visible = false;//hide the id column. this will be used for update purpose
            dataGridView1.Columns[4].Visible = false;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void frmcashbank_Load(object sender, EventArgs e)
        {
            try
            {
                load();
            }
            catch (Exception exe)//always place try and catch in your code to prevent annoying errors........................
            {

            }
        }

        private void oktwobutton_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(cs.DBConn);
            con.Open();

            string cq1b = "update cash_bank set is_deleted = 1 where id=@a1";
            SqlCommand cmd = new SqlCommand(cq1b);
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@a1", accountid.Trim());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted Successfully");
            reset();

            con.Close();
            reset();
            load();
        }
    }
}
