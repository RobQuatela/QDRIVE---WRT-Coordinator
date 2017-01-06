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


    public partial class frmEditJobSite : Form
    {
        public int jobID;
        public int coID;
        public static string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\dbwrtcoordinator.accdb";

        public frmEditJobSite()
        {
            InitializeComponent();
        }

        private void frmEditJobSite_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbwrtcoordinatorDataSet.dtempnamejob' table. You can move, or remove it, as needed.
            this.dtempnamejobTableAdapter.Fill(this.dbwrtcoordinatorDataSet.dtempnamejob);
            // TODO: This line of code loads data into the 'dbwrtcoordinatorDataSet.tbemployee' table. You can move, or remove it, as needed.
            this.tbemployeeTableAdapter.Fill(this.dbwrtcoordinatorDataSet.tbemployee);

            //filter strings
            String filterJobSiteEmployees = String.Format("job_id = {0}", jobID);
            String filterEmployees = String.Format("co_id = {0}", coID);

            this.dtempnamejobBindingSource.Filter = filterJobSiteEmployees;
            this.tbemployeeBindingSource.Filter = filterEmployees;

            PayStatus();

        }

        private void lstJobSiteEmployee_SelectedValueChanged(object sender, EventArgs e)
        {
            PayStatus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEmployees();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveEmployees();
        }

        private void ckJobSiteEnd_CheckedChanged(object sender, EventArgs e)
        {
            ckJobSiteEnd.Visible = false;
            dtpJobEnd.Visible = true;
        }

        private void btnJobSiteEdit_Click(object sender, EventArgs e)
        {
            UpdateForm();
            this.Close();
        }

        private void AddEmployees()
        {
            int empJobStatus = 0;
            frmMain main = (frmMain)Application.OpenForms["frmMain"];
            main.tbempjobTableAdapter.Insert(empJobStatus, Convert.ToInt32(lstEmployees.SelectedValue), jobID);
            FillEmployeeAdapters();
            
        }

        private void RemoveEmployees()
        {
            try
            {
                int payStatus = Database.SelectStatement("empjob_pay_status", "tbempjob", "empjob_id", Convert.ToInt32(lstJobSiteEmployee.SelectedValue));
                if (payStatus == 0)
                {
                    Database.DeleteStatement("tbempjob", "empjob_id", Convert.ToInt32(lstJobSiteEmployee.SelectedValue));
                    FillEmployeeAdapters();
                }
                else
                    MessageBox.Show("Unable to remove employee from jobsite. Commission has already been calculated for this employee", "QDRIVE - WRT Coordinator");
            }
            catch(Exception e)
            {
                MessageBox.Show("Show this message to Rob: " + e.GetBaseException().ToString(), "QDRIVE - WRT Coordinator");
            }

        }

        private void PayStatus()
        {
            int paystatus;

            try
            {
                paystatus = Database.SelectStatement("empjob_pay_status", "tbempjob", "empjob_id", Convert.ToInt32(lstJobSiteEmployee.SelectedValue));

                if (paystatus == 1)
                    lblPayStatus.Text = "Paid";
                else
                    lblPayStatus.Text = "Not Paid";
            }
            catch(Exception e)
            {
                MessageBox.Show(e.GetBaseException().ToString());
            }

        }

        private void FillEmployeeAdapters()
        {
            frmMain main = (frmMain)Application.OpenForms["frmMain"];
            main.tbempjobTableAdapter.Fill(main.dbwrtcoordinatorDataSet.tbempjob);
            main.dtempnamejobTableAdapter.Fill(main.dbwrtcoordinatorDataSet.dtempnamejob);
            this.tbempjobTableAdapter.Fill(main.dbwrtcoordinatorDataSet.tbempjob);
            this.dtempnamejobTableAdapter.Fill(this.dbwrtcoordinatorDataSet.dtempnamejob);
        }

        private void FillJobAdapters()
        {
            frmMain main = (frmMain)Application.OpenForms["frmMain"];
            main.tbjobTableAdapter.Fill(main.dbwrtcoordinatorDataSet.tbjob);
            main.dtjobcustTableAdapter.Fill(main.dbwrtcoordinatorDataSet.dtjobcust);
        }

        private void UpdateForm()
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                string update = "UPDATE tbjob SET job_status = @status, job_date_start = @start, job_date_end = @end WHERE job_id = @id";
                OleDbCommand cmdUpdate = new OleDbCommand(update, conn);
                cmdUpdate.Parameters.AddWithValue("@status", OleDbType.WChar).Value = cbJobSiteStatus.Text;
                cmdUpdate.Parameters.AddWithValue("@start", OleDbType.Date).Value = Convert.ToDateTime(dtpJobStart.Text);
                cmdUpdate.Parameters.AddWithValue("@end", OleDbType.Date).Value = Convert.ToDateTime(dtpJobEnd.Text);
                cmdUpdate.Parameters.AddWithValue("@id", OleDbType.Integer).Value = jobID;
                conn.Open();
                cmdUpdate.ExecuteNonQuery();
            }

            FillJobAdapters();
        }

    }
}
