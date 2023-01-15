using College_Management_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleaccountingSys
{
    public partial class frmJournalEntry : Form
    {

        DataSet sqlDatasetaccounts = new DataSet();
        ConnectionString cs = new ConnectionString();
        DataSet sqlDatasetbunit = new DataSet();

        public frmJournalEntry()
        {
            InitializeComponent();
        }

        private void frmJournalEntry_Load(object sender, EventArgs e)
        {
            account();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxAmt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //get the textbox that fired the event
                var textBox = sender as TextBox;
                if (textBox == null) return;

                var text = textBox.Text;
                var output = new StringBuilder();
                //use this boolean to determine if the dot already exists
                //in the text so far.
                var dotEncountered = false;
                //loop through all of the text
                for (int i = 0; i < text.Length; i++)
                {
                    var c = text[i];
                    if (char.IsDigit(c))
                    {
                        //append any digit.
                        output.Append(c);
                    }
                    else if (!dotEncountered && c == '.')
                    {
                        //append the first dot encountered
                        output.Append(c);
                        dotEncountered = true;
                    }
                }
                var newText = output.ToString();
                textBox.Text = newText;
                //calago();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        void account()
        {
            sqlDatasetaccounts.Clear();
            SqlDataAdapter FacultyDataAdapter2 = new SqlDataAdapter();
            string cmdStringbunit = " SELECT Account_id,Account,1 AS TYPE from ACCOUNTS  where isnull(is_deleted,0)=0 UNION SELECT Id,Cash_type,2 AS TYPE from Cash_Bank where isnull(is_deleted,0)=0";
            SqlConnection myconnection = new SqlConnection(cs.DBConn);
            myconnection.Open();
            SqlCommand sqlCommandbunit = new SqlCommand(cmdStringbunit, myconnection);

            FacultyDataAdapter2.SelectCommand = sqlCommandbunit;
            FacultyDataAdapter2.Fill(sqlDatasetaccounts, "Accounts");

            cmbAccDebit.DataSource = sqlDatasetaccounts.Tables[0].Copy();
            cmbAccDebit.ValueMember = "Account_id";
            cmbAccDebit.DisplayMember = "Account";
            cmbAccDebit.SelectedIndex = -1;

            cmbAccCredit.DataSource = sqlDatasetaccounts.Tables[0].Copy();
            cmbAccCredit.ValueMember = "Account_id";
            cmbAccCredit.DisplayMember = "Account";
            cmbAccCredit.SelectedIndex = -1;
            myconnection.Close();
        }

        private void saveonebutton_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a Description");
                txtDesc.Focus();
                return;
            }//
            if (cmbAccCredit.Text.Trim() == "")
            {
                MessageBox.Show("Please select Credit account");
                cmbAccCredit.Focus();
                return;
            }
            if (cmbAccDebit.Text.Trim() == "")
            {
                MessageBox.Show("Please select Debit account");
                cmbAccDebit.Focus();
                return;
            }
            if (txtCreditAmt.Text.Trim() == "")//
            {
                MessageBox.Show("Please enter Credit amount");
                txtCreditAmt.Focus();
                return;
            }
            if (txtDebitAmt.Text.Trim() == "")//
            {
                MessageBox.Show("Please enter Debit amount");
                txtDebitAmt.Focus();
                return;
            }
      
            SqlCommand cmd = null;
            SqlConnection con = new SqlConnection(cs.DBConn);
            con.Open();

            string cb2 = "INSERT INTO [dbo].[FIN_JOURNAL]([FDate],[DR_Account_id],[CR_Account_id],[DR_Account_Type],[CR_Account_Type],[DESC],[FCredit],[FDebit],is_deleted)VALUES(@date,@drAcc,@crAcc,@drType,@crType,@desc,@crAmt,@drAmt,0)";

            cmd = new SqlCommand(cb2);
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@date", dtpInvoiceDateFrom.Value);
            cmd.Parameters.AddWithValue("@drAcc", cmbAccDebit.SelectedValue);
            cmd.Parameters.AddWithValue("@crAcc", cmbAccCredit.SelectedValue);

            DataView dv = new DataView();
            DataTable dt = new DataTable();
            dt = (DataTable)cmbAccDebit.DataSource;
            dv = dt.DefaultView;
            dv.RowFilter = "Account_id = '"+ cmbAccDebit.SelectedValue + "'";
            dt = dv.ToTable();
            cmd.Parameters.AddWithValue("@drType", Convert.ToInt32(dt.Rows[0]["TYPE"].ToString()));

            
            dt = (DataTable)cmbAccCredit.DataSource;
            dv = dt.DefaultView;
            dv.RowFilter = "Account_id = '" + cmbAccCredit.SelectedValue + "'";
            dt = dv.ToTable();
            cmd.Parameters.AddWithValue("@crType", Convert.ToInt32(dt.Rows[0]["TYPE"].ToString()));


            cmd.Parameters.AddWithValue("@desc", txtDesc.Text);
            cmd.Parameters.AddWithValue("@drAmt", Convert.ToDouble(txtDebitAmt.Text));
            cmd.Parameters.AddWithValue("@crAmt", Convert.ToDouble(txtCreditAmt.Text));

            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved successfully");
            con.Close();

            reset();
            getdata();
        }

        private void reset()
        {
            txtCreditAmt.Text = "";
            txtDebitAmt.Text = "";
            txtDesc.Text = "";
            cmbAccCredit.SelectedValue = -1;
            cmbAccDebit.SelectedValue = -1;
            saveonebutton.Enabled = true;
            button1.Enabled = false;
            oktwobutton.Enabled = false;
        }
        string fID = "";
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            { 
            reset();

            int ty = e.RowIndex;
            //val = dataGridView1[7, ty].Value.ToString();
            fID = dataGridView1[0, ty].Value.ToString().Trim();
            if (fID == "")
            {
                MessageBox.Show("Please ensure you select the right data");
                return;
            }
            SqlConnection myconnection = new SqlConnection(cs.DBConn);
            myconnection.Open();

            string cb2 = "SELECT DR_ACCOUNT_ID,CR_ACCOUNT_ID,'JV-'+TRIM(STR(FID)) AS [Voucher ID],[FDATE] AS [Date], [DESC] AS [Description],FCREDIT AS [Credit Amount],FDEBIT AS [Debit Amount] FROM FIN_JOURNAL WHERE FID = @a1 and isnull(FIN_JOURNAL.is_deleted,0)=0";


                SqlCommand sqlDataTableactivitylog = new SqlCommand(cb2, myconnection);
            sqlDataTableactivitylog.Parameters.AddWithValue("@a1", SqlDbType.Int).Value = fID;
            SqlDataReader rdr = sqlDataTableactivitylog.ExecuteReader();
            while (rdr.Read())
            {

                cmbAccDebit.SelectedValue = Convert.ToInt32(rdr[0].ToString().Trim());

                cmbAccCredit.SelectedValue = Convert.ToInt32(rdr[1].ToString().Trim());


                txtVID.Text = rdr[2].ToString().Trim();

                dtpInvoiceDateFrom.Text = rdr[3].ToString().Trim();
                txtDesc.Text = rdr[4].ToString().Trim();

                //if (Convert.ToDecimal(rdr[3].ToString().Trim()) > 0)
                //{
                    txtCreditAmt.Text = rdr[5].ToString().Trim();
                    txtDebitAmt.Text = rdr[6].ToString().Trim();
                //    comboBoxdbcr.Text = "Credit";
                //}
                //else
                //{
                //    textBoxdramt.Text = rdr[4].ToString().Trim();
                //    comboBoxdbcr.Text = "Debit";
                //}
                //comboBox1accts.SelectedValue = rdr[6].ToString().Trim();
                //textBox1partic.Text = rdr[5].ToString().Trim();


            }
            rdr.Close();
            myconnection.Close();

            button1.Enabled = false;
            oktwobutton.Enabled = true;
            saveonebutton.Enabled = false;
            }
            catch (Exception ex) { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            getdata();
        }
        void getdata()
        {
            SqlCommand cmd = null;
            SqlConnection con = new SqlConnection(cs.DBConn);
            con.Open();
            DataSet sqlDatasetbunit = new DataSet();
            SqlDataAdapter FacultyDataAdapter2 = new SqlDataAdapter();

            string cb2 = "SELECT FID,DR_ACCOUNT_ID,CR_ACCOUNT_ID,'JV-'+TRIM(STR(FID)) AS [Voucher ID],[FDATE] AS [Date], [DESC] AS [Description],FCREDIT AS [Credit Amount],FDEBIT AS [Debit Amount] FROM FIN_JOURNAL WHERE FDate>=@a1 and FDate<=@a2 and isnull(FIN_JOURNAL.is_deleted,0)=0";
            cmd = new SqlCommand(cb2);
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@a1", dateTimePicker3.Value.Date);//
            cmd.Parameters.AddWithValue("@a2", dateTimePicker4.Value);//
            FacultyDataAdapter2.SelectCommand = cmd;
            FacultyDataAdapter2.Fill(sqlDatasetbunit, "FIN_JOURNAL");
            dataGridView1.DataSource = sqlDatasetbunit.Tables[0];
            dataGridView1.Columns[0].Visible = false;//hide the  id
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;

            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void oktwobutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs.DBConn);
            con.Open();



            string cq1b = "update fin_journal set is_deleted = 1 where FID=@a1";
            SqlCommand cmd = new SqlCommand(cq1b);
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@a1", fID.Trim());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted Successfully");
            reset();




            con.Close();
            reset();
            getdata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string cb2 = "update fin_journal set [desc]=@a1,Category=@a2,Account_No=@a4 where id=@a3 and isnull(is_deleted,0)=0 ";
            //string cb2 = "INSERT INTO [dbo].[FIN_JOURNAL]([FDate],[DR_Account_id],[CR_Account_id],[DR_Account_Type],[CR_Account_Type],[DESC],[FCredit],[FDebit],is_deleted)VALUES(@date,@drAcc,@crAcc,@drType,@crType,@desc,@crAmt,@drAmt,0)";

            //cmd = new SqlCommand(cb2);
            //cmd.Connection = con;
            //cmd.Parameters.AddWithValue("@a1", txtDesc.Text);
            //cmd.Parameters.AddWithValue("@a2", comboBox1acctype.Text);
            //cmd.Parameters.AddWithValue("@a4", textBox1acctno.Text);
            //cmd.Parameters.AddWithValue("@a3", accountid);

            //cmd.ExecuteNonQuery();
            //con.Close();
            //MessageBox.Show("Updated successfully.");
            //reset();
            //load();
        }
    }
}
