using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using College_Management_System;

namespace SimpleaccountingSys
{
    public partial class frmChartofaccts : Form
    {
        DataSet sqlDatasetaccounts = new DataSet();
        ConnectionString cs = new ConnectionString();
        SqlCommand cmd = null;
        Boolean clickFlag = false; 
        public frmChartofaccts()
        {
            InitializeComponent();
        }
        
        private void saveonebutton_Click(object sender, EventArgs e)
        {
            if (cmbAccount.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select Account Type.");
                return;
            }
            else if (cmbSubAccount.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select Sub Account.");
                return;
            }
           else if (cmbControlAccount.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select Control Account.");
                return;
            }
            else if (textBoxaccounts.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Account Name");
                textBoxaccounts.Focus();
                return;
            }
            
            SqlConnection con = new SqlConnection(cs.DBConn);
            con.Open();
          
            string cb2 = "INSERT INTO ACCOUNTS (CONTROL_ACCOUNT_ID,ACCOUNT,is_deleted) values(@a1,@a2,0) ";

            cmd = new SqlCommand(cb2);
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@a1", cmbControlAccount.SelectedValue.ToString());//
            cmd.Parameters.AddWithValue("@a2", textBoxaccounts.Text);//

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record saved successfully.");
            reset();
            load();
        }
        void reset()
        {
            textBoxaccounts.Text = "";
            cmbAccount.Text = "";
            cmbSubAccount.Text = "";
            cmbControlAccount.Text = "";
            accountid = "";
            accountTypeId = "";
            accountSubId = "";
            accountControlId = "";

        }
        string accountid = "";
        string accountTypeId = "";
        string accountSubId = "";
        string accountControlId = "";


        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbAccount.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select Account Type.");
                return;
            }
            else if (cmbSubAccount.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select Sub Account.");
                return;
            }
            else if (cmbControlAccount.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select Control Account.");
                return;
            }
            else if (textBoxaccounts.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Account Name");
                textBoxaccounts.Focus();
                return;
            }

            SqlConnection con = new SqlConnection(cs.DBConn);
            con.Open();
           
            string cb2 = "update Accounts set CONTROL_ACCOUNT_ID=@a1,Account=@a2 where Account_id=@a3 ";

            cmd = new SqlCommand(cb2);
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@a1", cmbControlAccount.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@a2", textBoxaccounts.Text);
            cmd.Parameters.AddWithValue("@a3", accountid);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record updated successfully.");
            reset();
            load();
        }

        void FillAccountCombo()
        {
            clickFlag = true;
            sqlDatasetaccounts = new DataSet();
            SqlDataAdapter FacultyDataAdapter2 = new SqlDataAdapter();
            string cmdStringbunit = " SELECT ID,ACCOUNT_TYPE FROM ACCOUNTS_TYPE";

            SqlConnection myconnection = new SqlConnection(cs.DBConn);
            myconnection.Open();
            SqlCommand sqlCommandbunit = new SqlCommand(cmdStringbunit, myconnection);

            FacultyDataAdapter2.SelectCommand = sqlCommandbunit;
            FacultyDataAdapter2.Fill(sqlDatasetaccounts, "ACCOUNT_TYPE");
            DataTable dt = sqlDatasetaccounts.Tables[0].Copy();
            DataRow dr = dt.NewRow();
            dr[0] = "0";
            dr[1] = "<--Select-->";
            dt.Rows.InsertAt(dr, 0);
            cmbAccount.DataSource = dt;
            cmbAccount.ValueMember = "ID";
            cmbAccount.DisplayMember = "ACCOUNT_TYPE";
           
            myconnection.Close();

          
                sqlDatasetaccounts = new DataSet();

                 FacultyDataAdapter2 = new SqlDataAdapter();
                cmdStringbunit = " SELECT ID,ACCOUNT_SUB_TYPE FROM ACCOUNTS_SUB_TYPE";

                 myconnection = new SqlConnection(cs.DBConn);
                myconnection.Open();
                 sqlCommandbunit = new SqlCommand(cmdStringbunit, myconnection);

                FacultyDataAdapter2.SelectCommand = sqlCommandbunit;
                FacultyDataAdapter2.Fill(sqlDatasetaccounts, "ACCOUNT_SUB_TYPE");

                 dt = sqlDatasetaccounts.Tables[0].Copy();
                 dr = dt.NewRow();
                dr[0] = "0";
                dr[1] = "<--Select-->";
                dt.Rows.InsertAt(dr, 0);

                cmbSubAccount.DataSource = dt;
                cmbSubAccount.ValueMember = "ID";
                cmbSubAccount.DisplayMember = "ACCOUNT_SUB_TYPE";
               
                myconnection.Close();
            
                sqlDatasetaccounts = new DataSet();
                 FacultyDataAdapter2 = new SqlDataAdapter();
                 cmdStringbunit = " SELECT ID,ACCOUNT_CONTROL FROM ACCOUNTS_CONTROL";

                 myconnection = new SqlConnection(cs.DBConn);
                myconnection.Open();
                 sqlCommandbunit = new SqlCommand(cmdStringbunit, myconnection);

                FacultyDataAdapter2.SelectCommand = sqlCommandbunit;
                FacultyDataAdapter2.Fill(sqlDatasetaccounts, "ACCOUNT_CONTROL");

                 dt = sqlDatasetaccounts.Tables[0].Copy();
                 dr = dt.NewRow();
                dr[0] = "0";
                dr[1] = "<--Select-->";
                dt.Rows.InsertAt(dr, 0);

                cmbControlAccount.DataSource = dt;
                cmbControlAccount.ValueMember = "ID";
                cmbControlAccount.DisplayMember = "ACCOUNT_CONTROL";
                
                myconnection.Close();
           
        }
        void load()
        {
            SqlConnection con = new SqlConnection(cs.DBConn);
            con.Open();
            DataSet sqlDatasetbunit = new DataSet();
            SqlDataAdapter FacultyDataAdapter2 = new SqlDataAdapter();

            string cb2 = "SELECT ACCOUNTS.ACCOUNT_ID,ACCOUNTS_TYPE.ID,ACCOUNTS_SUB_TYPE.ID,ACCOUNTS_CONTROL.ID,[ACCOUNTS_TYPE].ACCOUNT_TYPE AS [Account Type],ACCOUNTS_SUB_TYPE.ACCOUNT_SUB_TYPE AS [Sub Type]," +
                "ACCOUNTS_CONTROL.ACCOUNT_CONTROL AS [Account Control],ACCOUNTS.Account FROM ACCOUNTS INNER JOIN ACCOUNTS_CONTROL ON ACCOUNTS.CONTROL_ACCOUNT_ID = ACCOUNTS_CONTROL.ID INNER JOIN ACCOUNTS_SUB_TYPE " +
                "ON ACCOUNTS_CONTROL.SUB_ACCOUNT_ID = ACCOUNTS_SUB_TYPE.ID INNER JOIN ACCOUNTS_TYPE ON ACCOUNTS_SUB_TYPE.ACCOUNT_ID = ACCOUNTS_TYPE.ID where isnull(accounts.is_deleted,0)=0";

            cmd = new SqlCommand(cb2);
            cmd.Connection = con;
            FacultyDataAdapter2.SelectCommand = cmd;
            FacultyDataAdapter2.Fill(sqlDatasetbunit, "Accounts");
            dataGridView1.DataSource = sqlDatasetbunit.Tables[0];
            dataGridView1.Columns[0].Visible = false;//hide the id column. this will be used for update purpose
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                load(); 
            }
            catch(Exception exe)// code to prevent annoying errors......
            {
                MessageBox.Show(exe.Message.ToString());
            }
        }
        
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                reset();//clear data from textbox or combo before adding selected item
                int ty = e.RowIndex;

                accountid = dataGridView1[0, ty].Value.ToString().Trim();// id is located in column 0
                if (accountid == "")// check it is not empty
                {
                    MessageBox.Show("Please ensure you select the right data");
                    return;
                }
                accountTypeId = dataGridView1[1, ty].Value.ToString().Trim();
                if (accountTypeId == "")// check it is not empty
                {
                    MessageBox.Show("Please ensure you select the right data");
                    return;
                }
                accountSubId = dataGridView1[2, ty].Value.ToString().Trim();
                if (accountSubId == "")// check it is not empty
                {
                    MessageBox.Show("Please ensure you select the right data");
                    return;
                }
                accountControlId = dataGridView1[3, ty].Value.ToString().Trim();
                if (accountControlId == "")// check it is not empty
                {
                    MessageBox.Show("Please ensure you select the right data");
                    return;
                }

                FillAccountCombo();
                SqlConnection con = new SqlConnection(cs.DBConn);
                con.Open();

                string activitylog = " select accounts.ACCOUNT_ID,accounts.CONTROL_ACCOUNT_ID,accounts.ACCOUNT,ACCOUNTS_CONTROL.SUB_ACCOUNT_ID,ACCOUNTS_SUB_TYPE.ACCOUNT_ID" +
                    " from accounts INNER JOIN ACCOUNTS_CONTROL ON ACCOUNTS.CONTROL_ACCOUNT_ID = ACCOUNTS_CONTROL.ID INNER JOIN ACCOUNTS_SUB_TYPE ON ACCOUNTS_CONTROL.SUB_ACCOUNT_ID" +
                    " = ACCOUNTS_SUB_TYPE.ID INNER JOIN ACCOUNTS_TYPE ON ACCOUNTS_SUB_TYPE.ACCOUNT_ID = ACCOUNTS_TYPE.ID where accounts.Account_id = @a1 and" +
                    "  isnull(accounts.is_deleted,0)=0 ";//select item to update based on id selected from grid


                cmd = new SqlCommand(activitylog, con);
                cmd.Parameters.AddWithValue("@a1", SqlDbType.Int).Value = accountid;
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cmbControlAccount.SelectedValue = rdr[1].ToString().Trim();// pass value to textbox or combox
                    textBoxaccounts.Text = rdr[2].ToString().Trim();
                    cmbSubAccount.SelectedValue = rdr[3].ToString().Trim();
                    cmbAccount.SelectedValue = rdr[4].ToString().Trim();
                }
                rdr.Close();
                con.Close();
                clickFlag = false;
            }
            catch (Exception ex) { }
        }

        private void cmbAccount_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbAccount.SelectedIndex > 0 && clickFlag == false)
            {
                sqlDatasetaccounts = new DataSet();

                SqlDataAdapter FacultyDataAdapter2 = new SqlDataAdapter();
                string cmdStringbunit = " SELECT ID,ACCOUNT_SUB_TYPE FROM ACCOUNTS_SUB_TYPE WHERE ACCOUNT_ID = " + cmbAccount.SelectedValue.ToString();

                SqlConnection myconnection = new SqlConnection(cs.DBConn);
                myconnection.Open();
                SqlCommand sqlCommandbunit = new SqlCommand(cmdStringbunit, myconnection);

                FacultyDataAdapter2.SelectCommand = sqlCommandbunit;
                FacultyDataAdapter2.Fill(sqlDatasetaccounts, "ACCOUNT_SUB_TYPE");

                DataTable dt = sqlDatasetaccounts.Tables[0].Copy();
                DataRow dr = dt.NewRow();
                dr[0] = "0";
                dr[1] = "<--Select-->";
                dt.Rows.InsertAt(dr, 0);

                cmbSubAccount.DataSource = dt;
                cmbSubAccount.ValueMember = "ID";
                cmbSubAccount.DisplayMember = "ACCOUNT_SUB_TYPE";
                cmbSubAccount.SelectedIndex = 0;
                myconnection.Close();
            }
        }

        private void cmbSubAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbSubAccount.SelectedIndex > 0 && clickFlag == false)
            {
                sqlDatasetaccounts = new DataSet();
                SqlDataAdapter FacultyDataAdapter2 = new SqlDataAdapter();
                string cmdStringbunit = " SELECT ID,ACCOUNT_CONTROL FROM ACCOUNTS_CONTROL WHERE SUB_ACCOUNT_ID = " + cmbSubAccount.SelectedValue.ToString();

                SqlConnection myconnection = new SqlConnection(cs.DBConn);
                myconnection.Open();
                SqlCommand sqlCommandbunit = new SqlCommand(cmdStringbunit, myconnection);

                FacultyDataAdapter2.SelectCommand = sqlCommandbunit;
                FacultyDataAdapter2.Fill(sqlDatasetaccounts, "ACCOUNT_CONTROL");

                DataTable dt = sqlDatasetaccounts.Tables[0].Copy();
                DataRow dr = dt.NewRow();
                dr[0] = "0";
                dr[1] = "<--Select-->";
                dt.Rows.InsertAt(dr, 0);

                cmbControlAccount.DataSource = dt;
                cmbControlAccount.ValueMember = "ID";
                cmbControlAccount.DisplayMember = "ACCOUNT_CONTROL";
                cmbControlAccount.SelectedIndex = 0;
                myconnection.Close();
                
            }
        }

        private void cmbAccount_Click(object sender, EventArgs e)
        {
            sqlDatasetaccounts = new DataSet();
            SqlDataAdapter FacultyDataAdapter2 = new SqlDataAdapter();
            string cmdStringbunit = " SELECT ID,ACCOUNT_TYPE FROM ACCOUNTS_TYPE";

            SqlConnection myconnection = new SqlConnection(cs.DBConn);
            myconnection.Open();
            SqlCommand sqlCommandbunit = new SqlCommand(cmdStringbunit, myconnection);

            FacultyDataAdapter2.SelectCommand = sqlCommandbunit;
            FacultyDataAdapter2.Fill(sqlDatasetaccounts, "ACCOUNT_TYPE");
            DataTable dt = sqlDatasetaccounts.Tables[0].Copy();
            DataRow dr = dt.NewRow();
            dr[0] = "0";
            dr[1] = "<--Select-->";
            dt.Rows.InsertAt(dr, 0);
            cmbAccount.DataSource = dt;
            cmbAccount.ValueMember = "ID";
            cmbAccount.DisplayMember = "ACCOUNT_TYPE";
            cmbAccount.SelectedIndex = 0;
            cmbSubAccount.DataSource = null;
            cmbControlAccount.DataSource = null;
         myconnection.Close();
        }

        private void cmbSubAccount_Click(object sender, EventArgs e)
        {
            cmbControlAccount.DataSource = null;
        }

        private void oktwobutton_Click(object sender, EventArgs e)
        {
            if (cmbAccount.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select a row");
                return;
            }
            else if (cmbSubAccount.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select a row");
                return;
            }
            else if (cmbControlAccount.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select a row");
                return;
            }
            else if (textBoxaccounts.Text.Trim() == "")
            {
                MessageBox.Show("Please select a row");
                textBoxaccounts.Focus();
                return;
            }

            SqlConnection con = new SqlConnection(cs.DBConn);
            con.Open();

            string commandText = "SELECT COUNT(*) FROM TFinancials WHERE ACCOUNT_ID =" + accountid.Trim() + " and isnull(is_deleted,0)=0 ;";
            SqlCommand cmd = new SqlCommand(commandText);
            cmd.Connection = con;
            Object oValue = cmd.ExecuteScalar();
            Int32 count;
            if (Int32.TryParse(oValue.ToString(), out count))
            {
                if (count > 0)
                {
                    MessageBox.Show("Cannot delete account. Already Used in transactions.");
                    return;
                }
            }

            string cb2 = "update Accounts set is_deleted = 1 where Account_id=@a3 ";

            cmd = new SqlCommand(cb2);
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@a3", accountid);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record deleted successfully.");
            reset();
            load();
        }

        private void cmbControlAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
