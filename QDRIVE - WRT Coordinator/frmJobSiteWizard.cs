using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace QDRIVE___WRT_Coordinator
{
    public partial class frmJobSiteWizard : Form
    {
        //variables to determine panel visibility
        private bool panelCustomer = true;
        //private bool panelJob;
        string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\dbwrtcoordinator.accdb";
        List<int> id = new List<int>();
        List<int> custIDs = new List<int>();
        frmMain main = (frmMain)Application.OpenForms["frmMain"];

        public frmJobSiteWizard()
        {
            InitializeComponent();
        }

        private void matchCustIDs()
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                string sqlGetIDs = "SELECT cust_id FROM tbjob";
                OleDbCommand cmdGetIDs = new OleDbCommand(sqlGetIDs, conn);
                OleDbDataReader reader = cmdGetIDs.ExecuteReader();

                while (reader.Read())
                    custIDs.Add(reader.GetInt32(0));
            }
        }

        private void frmJobSiteWizard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbwrtcoordinatorDataSet.tbjob' table. You can move, or remove it, as needed.
            this.tbjobTableAdapter.Fill(this.dbwrtcoordinatorDataSet.tbjob);
            // TODO: This line of code loads data into the 'dbwrtcoordinatorDataSet.tbcustomer' table. You can move, or remove it, as needed.
            this.tbcustomerTableAdapter.Fill(this.dbwrtcoordinatorDataSet.tbcustomer);
            // TODO: This line of code loads data into the 'dbwrtcoordinatorDataSet.tbinsurance' table. You can move, or remove it, as needed.
            this.tbinsuranceTableAdapter.Fill(this.dbwrtcoordinatorDataSet.tbinsurance);
            // TODO: This line of code loads data into the 'dbwrtcoordinatorDataSet.tbemployee' table. You can move, or remove it, as needed.
            this.tbemployeeTableAdapter.Fill(this.dbwrtcoordinatorDataSet.tbemployee);
            btnAddJobSite.Enabled = false;
            btnPrevious.Enabled = false;
            pnlJob.Visible = false;

            //filter by company
            tbemployeeBindingSource.Filter = "co_id = " + Convert.ToInt32(main.lstCompanies.SelectedValue) + "";
            tbcustomerBindingSource.Filter = "co_id = " + Convert.ToInt32(main.lstCompanies.SelectedValue) + "";
            //tbcustomerBindingSource.Filter = "cust_id <> " + 1 + "";

            //default end date is 3 days after start date
            dtpJobStart.Text = DateTime.Today.ToShortDateString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
           panel();
        }
        
        private void panel()
        {
            if(panelCustomer == true)
            {
                pnlJob.Visible = true;
                btnPrevious.Enabled = true;
                btnNext.Enabled = false;
                btnAddJobSite.Enabled = true;
                panelCustomer = false;
            }
            else
            {
                pnlJob.Visible = false;
                btnPrevious.Enabled = false;
                btnNext.Enabled = true;
                btnAddJobSite.Enabled = false;
                panelCustomer = true;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
           panel();
        }

        private void lstAssignedEmployees_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void lstAssignedEmployees_DragDrop(object sender, DragEventArgs e)
        {
            //lstAssignedEmployees.Items.Add();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql = "SELECT emp_name FROM tbemployee WHERE emp_id = @id";
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", OleDbType.Integer).Value = Convert.ToInt32(lstEmployees.SelectedValue);
                string name = Convert.ToString(cmd.ExecuteScalar());
                lstAssignedEmployees.Items.Add(name);
                id.Add(Convert.ToInt32(lstEmployees.SelectedValue));
            }
        }

        private void btnAddJobSite_Click(object sender, EventArgs e)
        {
            //job data
            int custid;
            lblCustID.Visible = true;
            if (lstCustomer.Visible == true)
                custid = Convert.ToInt32(lstCustomer.SelectedValue);
            else
                custid = Convert.ToInt32(lblCustID.Text);
            int insurance = Convert.ToInt32(cbAddInsurance.SelectedValue);
            //string jobStatus = cbStatus.Text;
            string claim = txtClaimNo.Text;
            DateTime jobStart = DateTime.Parse(dtpJobStart.Text);

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();
                string insert = "INSERT INTO tbjob (job_status, job_claim_number, job_date_start, cust_id, ins_id) VALUES (@status, @claim, @start, @cust, @ins)";
                OleDbCommand cmdInsert = new OleDbCommand(insert, conn);
                cmdInsert.Parameters.AddWithValue("@status", OleDbType.VarChar).Value = "Scoped";
                cmdInsert.Parameters.AddWithValue("@claim", OleDbType.VarChar).Value = claim;
                cmdInsert.Parameters.AddWithValue("@start", OleDbType.Date).Value = jobStart;
                cmdInsert.Parameters.AddWithValue("@cust", OleDbType.Integer).Value = custid;
                cmdInsert.Parameters.AddWithValue("@ins", OleDbType.Integer).Value = insurance;
                cmdInsert.ExecuteNonQuery();
            }

            //empjob data
            int empjobpaystatus = 0;
            int jobid;

            //get job id
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();
                string getJob = "SELECT job_id FROM tbjob WHERE cust_id = @cust AND job_date_start = @date";
                OleDbCommand cmdJob = new OleDbCommand(getJob, conn);
                cmdJob.Parameters.AddWithValue("@cust", OleDbType.Integer).Value = custid;
                cmdJob.Parameters.AddWithValue("@date", OleDbType.Date).Value = jobStart;
                cmdJob.ExecuteNonQuery();
                jobid = Convert.ToInt32(cmdJob.ExecuteScalar());
            }

            //insert empjob array
            for(int i = 0; i < id.Count; i++)
                main.tbempjobTableAdapter.Insert(empjobpaystatus, id[i], jobid);

            //fill datatables
            main.tbjobTableAdapter.Fill(main.dbwrtcoordinatorDataSet.tbjob);
            main.tbempjobTableAdapter.Fill(main.dbwrtcoordinatorDataSet.tbempjob);
            main.dtempnamejobTableAdapter.Fill(main.dbwrtcoordinatorDataSet.dtempnamejob);
            main.dtjobcustTableAdapter.Fill(main.dbwrtcoordinatorDataSet.dtjobcust);
            main.filterJobByEmployee();
            Close();

        }

        private void txtSearchCustomer_CursorChanged(object sender, EventArgs e)
        {
            //txtSearchCustomer.Clear();
        }

        private void txtSearchCustomer_Click(object sender, EventArgs e)
        {
            txtSearchCustomer.Clear();
        }

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            tbcustomerBindingSource.Filter = string.Format("cust_name LIKE '{0}%' AND co_id = " + Convert.ToInt32(main.lstCompanies.SelectedValue) + "", txtSearchCustomer.Text);
        }
    }
}
