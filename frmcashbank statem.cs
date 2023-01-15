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
using System.IO;
using System.Web.Configuration;

namespace SimpleaccountingSys
{
    public partial class frmcashbank_statem : Form
    {
        public frmcashbank_statem()
        {
            InitializeComponent();
        }
        ConnectionString cs = new ConnectionString();
        DataSet sqlDatasetaccounts = new DataSet();
        void account()
        {
            sqlDatasetaccounts.Clear();
            SqlDataAdapter FacultyDataAdapter2 = new SqlDataAdapter();
            string cmdStringbunit = " select Id,Cash_type" +
                    " from Cash_Bank where isnull(is_deleted,0) = 0";
            SqlConnection myconnection = new SqlConnection(cs.DBConn);
            myconnection.Open();
            SqlCommand sqlCommandbunit = new SqlCommand(cmdStringbunit, myconnection);

            FacultyDataAdapter2.SelectCommand = sqlCommandbunit;
            FacultyDataAdapter2.Fill(sqlDatasetaccounts, "Cash_Bank");
            comboBox1acct.DataSource = sqlDatasetaccounts.Tables[0];
            comboBox1acct.ValueMember = "Id";
            comboBox1acct.DisplayMember = "Cash_type";
            comboBox1acct.SelectedIndex = -1;
            myconnection.Close();
        }
        private void button1ok_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
               
                SqlCommand cmd = new SqlCommand();
                SqlConnection myConnection = default(SqlConnection);
                SqlDataAdapter myDA = new SqlDataAdapter();
                DataSet myDS = new DataSet();
            
                myConnection = new SqlConnection(cs.DBConn);
                cmd.Connection = myConnection;

                if (comboBox1acct.SelectedValue == null || Convert.ToInt32(comboBox1acct.SelectedValue) < 0)
                {
                    MessageBox.Show("Please select an account first.");
                    return;
                }
                myConnection.Open();
                string accnames = "";
                //sum all previous balances
                    string cmdStringbunit1 = "SELECT sum(FDebit) as mysum from  TFinancials " +
                   " where  FDate<=@a4 and id=@a3 and isnull(is_deleted,0)=0";
                    SqlCommand sqlCommandbunit1 = new SqlCommand(cmdStringbunit1, myConnection);
                    sqlCommandbunit1.Parameters.AddWithValue("@a3", SqlDbType.NVarChar).Value = comboBox1acct.SelectedValue;
                    sqlCommandbunit1.Parameters.AddWithValue("@a4", SqlDbType.NVarChar).Value = dateTimePicker1.Value.Date.AddDays(-1);
                    //sqlCommandbunit1.Parameters.AddWithValue("@a4", SqlDbType.NVarChar).Value = dateTimePicker4.Value.Date;
                    SqlDataReader comp2 = sqlCommandbunit1.ExecuteReader();
                    comp2.Read();
                    string deb = comp2[0].ToString();
                    decimal deb1 = 0;
                    if (deb != "")
                    {
                        deb1 = Convert.ToDecimal(deb);
                    }
                    comp2.Close();

                    string cmdStringbunit12 = "SELECT sum(FCredit) as mysum from  TFinancials " +
                   " where  FDate<=@a4 and id=@a3 and isnull(is_deleted,0)=0 ";
                    sqlCommandbunit1 = new SqlCommand(cmdStringbunit12, myConnection);
                    //sqlCommandbunit1.Parameters.AddWithValue("@a1", SqlDbType.Int).Value = Convert.ToInt16(val);
                    sqlCommandbunit1.Parameters.AddWithValue("@a3", SqlDbType.NVarChar).Value = comboBox1acct.SelectedValue;
                    sqlCommandbunit1.Parameters.AddWithValue("@a4", SqlDbType.NVarChar).Value = dateTimePicker1.Value.Date.AddDays(-1);
                    comp2 = sqlCommandbunit1.ExecuteReader();
                    comp2.Read();
                    string deb2 = comp2[0].ToString();
                    decimal creditdeb12 = 0;
                    if (deb2 != "")
                    {
                        creditdeb12 = Convert.ToDecimal(deb2);
                    }
                    comp2.Close();
                    decimal sum = 0;
                //sum = deb1 + creditdeb12;

                //    string cmdStrinzz = "SELECT     Cash_Bank.Cash_type as Customer_name,  TFinancials.FDate, CASE WHEN TFinancials.ID = 1 then 'PV-'+TRIM(STR(FID)) ELSE 'RV-'+TRIM(STR(FID)) END AS [VOUCHER ID], TFinancials.Particular, " +
                //        "TFinancials.FCredit, TFinancials.FDebit, TFinancials.Names"+
                //" FROM            TFinancials INNER JOIN " +
                //    "     Cash_Bank ON TFinancials.id = Cash_Bank.id " +
                //" WHERE   " +
                //       "  (TFinancials.FDate >= @a2) AND (TFinancials.FDate <= @a3) and (TFinancials.id = @a1) ";

                string cmdStrinzz = "SELECT *, Sum(DEBIT-CREDIT)Over(Order by DATE) AS Balance  FROM ("
                                    + " select* from("
                                    + " SELECT TFinancials.FDate AS [Date], CASE WHEN TFinancials.ID = 1 then 'PV-' + TRIM(STR(FID)) ELSE 'RV-' + TRIM(STR(FID)) END AS[Voucher Id], "
                                    + " TFinancials.Particular, TFinancials.FCredit AS Credit, TFinancials.FDebit AS Debit, TFinancials.Names,Cash_Bank.Cash_type AS[On Account] FROM TFinancials"
                                    + " INNER JOIN Cash_Bank ON TFinancials.id = Cash_Bank.id WHERE(TFinancials.ID = @a1) AND isnull(TFinancials.is_deleted,0)=0 AND isnull(Cash_Bank.is_deleted,0)=0 "
                                    + " UNION"
                                    + " SELECT[Date],'JV-' + TRIM(STR(FID)) AS[Voucher Id],Particular,FDebit AS Debit, Credit,Names,Cash_type AS[On Account] FROM("
                                    + " SELECT * FROM("
                                    + " SELECT FID, ACCOUNTS.ACCOUNT_ID, FDATE AS[Date],[DESC] AS Particular, FDebit, 0 AS Credit, '' AS Names, ACCOUNTS.ACCOUNT AS Cash_type"
                                    + " FROM FIN_JOURNAL INNER JOIN ACCOUNTS ON FIN_JOURNAL.DR_Account_id = ACCOUNTS.ACCOUNT_ID WHERE FIN_JOURNAL.DR_Account_Type = 1 AND isnull(FIN_JOURNAL.is_deleted,0)=0 and isnull(ACCOUNTS.is_deleted,0)=0 "
                                    + " UNION"
                                    + " SELECT FID, ACCOUNTS.ACCOUNT_ID, FDATE AS[Date],[DESC] AS Particular, 0 AS Debit, FCredit AS Credit, '' AS Names, ACCOUNTS.ACCOUNT AS Cash_type FROM "
                                    + " FIN_JOURNAL INNER JOIN ACCOUNTS ON FIN_JOURNAL.CR_Account_id = ACCOUNTS.ACCOUNT_ID  WHERE FIN_JOURNAL.CR_Account_Type = 1 AND isnull(FIN_JOURNAL.is_deleted,0)=0 and isnull(ACCOUNTS.is_deleted,0)=0 "
                                    + " UNION"
                                    + " SELECT FID, Cash_Bank.ID AS ACCOUNT_ID, FDATE AS[Date],[DESC] AS Particular, FDebit AS Debit, 0 AS Credit, '' AS Names, Cash_Bank.Cash_type FROM"
                                    + " FIN_JOURNAL INNER JOIN CASH_BANK ON FIN_JOURNAL.DR_Account_id = Cash_Bank.ID WHERE DR_Account_Type = 2  AND isnull(FIN_JOURNAL.is_deleted,0)=0 and isnull(CASH_BANK.is_deleted,0)=0 "
                                    + " UNION"
                                    + " SELECT FID, Cash_Bank.ID AS ACCOUNT_ID, FDATE AS[Date],[DESC] AS Particular, 0 AS Debit, FCredit AS Credit, '' AS Names, Cash_Bank.Cash_type "
                                    + " FROM FIN_JOURNAL INNER JOIN CASH_BANK ON FIN_JOURNAL.CR_Account_id = Cash_Bank.ID WHERE CR_Account_Type = 2 AND isnull(FIN_JOURNAL.is_deleted,0)=0 and isnull(CASH_BANK.is_deleted,0)=0 "
                                    + " )TBL WHERE ACCOUNT_ID = @a1) TBL2"
                                    + " )TBL3) TBL4 WHERE"
                                    + " (Date >= @a2) AND(Date <= @a3)  ORDER BY[Date] ";

                    cmd = new SqlCommand(cmdStrinzz, myConnection);
                    // string cmdStringbunit = "SELECT [Account name],[Acc number],[Starting bal],[Starting date],cash_id from cash_Table where cash_id=@a1 ORDER BY Open_date desc";

                    // SqlCommand sqlCommandbunit = new SqlCommand(cmdStringbunit, myconnection);
                    cmd.Parameters.AddWithValue("@a2", SqlDbType.Date).Value = (dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@a3", SqlDbType.Date).Value = (dateTimePicker2.Value);
                    cmd.Parameters.AddWithValue("@a1", SqlDbType.NVarChar).Value = comboBox1acct.SelectedValue;

                   
                    myDA.SelectCommand = cmd;
                    myDA.Fill(myDS , "S_And_C_statment");
                    lblRecord.Text = "Total Records : "+myDS.Tables[0].Rows.Count.ToString();
                double totalDebit = 0;
                double totalCredit = 0;
                    foreach (DataRow dr in myDS.Tables[0].Rows)
                    {
                    totalDebit += Convert.ToDouble(dr["Debit"].ToString());
                    totalCredit += Convert.ToDouble(dr["Credit"].ToString());
                }
                txtTotalCredit.Text = totalCredit.ToString();
                txtTotalDebit.Text = totalDebit.ToString();
                dataGridView1.DataSource = myDS.Tables[0];

                myConnection.Close();
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show("Error " + ex);
            }
        }

        private void frmcashbank_statem_Load(object sender, EventArgs e)
        {
            account();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                //Build the CSV file data as a Comma separated string.
                string csv = string.Empty;

                //Add the Header row for CSV file.
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    csv += column.HeaderText + ',';
                }

                //Add new line.
                csv += "\r\n";

                //Adding the Rows
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                    {
                        //Add the Data rows.
                        csv += cell.Value.ToString().Replace(",", ";") + ',';
                    }

                    //Add new line.
                    csv += "\r\n";
                }

                //Exporting to CSV.
                File.WriteAllText(WebConfigurationManager.AppSettings["FilePath"] + "AccountsLedgerStatement" + System.DateTime.Now.ToString("yyyy-MM-dd") + ".csv", csv);

                MessageBox.Show("File Exported Successfully");
            }
            else
            {
                MessageBox.Show("No data found to export.");
            }

        }
    }
}
