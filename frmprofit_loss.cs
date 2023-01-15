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
using System.Web.Configuration;
using System.IO;

namespace SimpleaccountingSys
{
  
    public partial class frmprofit_loss : Form
    {
        public frmprofit_loss()
        {
            InitializeComponent();
        }
        ConnectionString cs = new ConnectionString();
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
                
                myConnection.Open();
            
                    string cmdStrinzz = "SELECT  TFinancials.FDate,  CASE WHEN TFinancials.ID = 1 then 'PV-'+TRIM(STR(FID)) ELSE 'RV-'+TRIM(STR(FID)) END AS [VOUCHER ID],TFinancials.Particular, TFinancials.FCredit," +
                        " TFinancials.FDebit, TFinancials.Names, Cash_Bank.Cash_type,"+
                        " CASE WHEN TFinancials.FDebit > 0 THEN 'Expense' ELSE 'Income' END AS Transaction_type " +//take note of the if else statement in there use for the p/l statement
                    " FROM            TFinancials INNER JOIN "+
                      "   Cash_Bank ON TFinancials.Id = Cash_Bank.Id INNER JOIN "+
                       "  Accounts ON TFinancials.Account_id = Accounts.Account_id" +
                       "  where (TFinancials.FDate >= @a2) AND (TFinancials.FDate <= @a3) AND ISNULL(TFinancials.IS_DELETED,0)=0 AND ISNULL(Cash_Bank.IS_DELETED,0)=0 AND ISNULL(Accounts.IS_DELETED,0)=0";
                    cmd = new SqlCommand(cmdStrinzz, myConnection);
                   
                    cmd.Parameters.AddWithValue("@a2", SqlDbType.Date).Value = (dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@a3", SqlDbType.Date).Value = (dateTimePicker2.Value);


                    myDA.SelectCommand = cmd;
                  
                myDA.Fill(myDS, "S_And_C_statment");
                lblRecord.Text = "Total Records : " + myDS.Tables[0].Rows.Count.ToString();
                double totalDebit = 0;
                double totalCredit = 0;
                foreach (DataRow dr in myDS.Tables[0].Rows)
                {
                    totalDebit += Convert.ToDouble(dr["FDebit"].ToString());
                    totalCredit += Convert.ToDouble(dr["FCredit"].ToString());
                }
                txtTotalCredit.Text = totalCredit.ToString();
                txtTotalDebit.Text = totalDebit.ToString();
                dataGridView1.DataSource = myDS.Tables[0];
                dataGridView1.DataSource = myDS.Tables[0];

                    //rptpandlst rpt3 = new rptpandlst();

                //rpt3.SetDataSource(myDS);



                //ParameterFieldDefinitions crParameterFieldDefinitions;
                //ParameterFieldDefinition crParameterFieldDefinition;
                //ParameterValues crParameterValues = new ParameterValues();
                //ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();


                //crParameterDiscreteValue.Value = "BIG LTD Profit And Loss Statement "
                //    + Environment.NewLine + " For the period of " + dateTimePicker1.Value.ToShortDateString() + " To " + dateTimePicker2.Value.ToShortDateString();

                //crParameterFieldDefinitions = rpt3.DataDefinition.ParameterFields;



                //crParameterFieldDefinition = crParameterFieldDefinitions["My Parameter"];
                //crParameterValues = crParameterFieldDefinition.CurrentValues;

                //crParameterValues.Clear();
                //crParameterValues.Add(crParameterDiscreteValue);
                //crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);


                ////frmcashsummary frm2 = new frmcashsummary();
                //crystalReportViewer1.ReportSource = rpt3;

                //frm2.ShowDialog();


                myConnection.Close();
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show("Error " + ex);
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count >0)
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
            File.WriteAllText(WebConfigurationManager.AppSettings["FilePath"] + "ProfitLossReport" + System.DateTime.Now.ToString("yyyy-MM-dd") + ".csv", csv);

                MessageBox.Show("File Exported Successfully");
            }
            else
            {
                MessageBox.Show("No data found to export.");
            }
        }
    }
}
