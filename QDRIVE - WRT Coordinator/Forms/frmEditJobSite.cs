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
        public string ins_name;
        frmMain main = (frmMain)Application.OpenForms["frmMain"];

        public frmEditJobSite()
        {
            InitializeComponent();
        }

        private void frmEditJobSite_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbwrtcoordinatorDataSet.tbinsurance' table. You can move, or remove it, as needed.
            this.tbinsuranceTableAdapter.Fill(this.dbwrtcoordinatorDataSet.tbinsurance);
            // TODO: This line of code loads data into the 'dbwrtcoordinatorDataSet.dtempnamejob' table. You can move, or remove it, as needed.
            this.dtempnamejobTableAdapter.Fill(this.dbwrtcoordinatorDataSet.dtempnamejob);
            // TODO: This line of code loads data into the 'dbwrtcoordinatorDataSet.tbemployee' table. You can move, or remove it, as needed.
            this.tbemployeeTableAdapter.Fill(this.dbwrtcoordinatorDataSet.tbemployee);

            //filter strings
            String filterJobSiteEmployees = String.Format("job_id = {0}", jobID);
            String filterEmployees = String.Format("co_id = {0}", coID);

            this.dtempnamejobBindingSource.Filter = filterJobSiteEmployees;
            this.tbemployeeBindingSource.Filter = filterEmployees;

            cbInsurance.Text = ins_name;

            PayStatus();

        }

        private void frmJobSite_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.Enabled = true;
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
            main.dtjobcustBindingSource.Sort = "job_date_start ASC";
        }

        private void txtLabor_TextChanged(object sender, EventArgs e)
        {
            totalUp();
        }

        private void txtEquip_TextChanged(object sender, EventArgs e)
        {
            totalUp();
        }

        private void txtMonitor_TextChanged(object sender, EventArgs e)
        {
            totalUp();
        }

        private void AddEmployees()
        {
            int empJobStatus = 0;
            List<int> jobInJobComm = Database.SelectStatementList("job_id", "tbjobcomm", "job_id", jobID);

            if (lblJobStatus.Text == "Closed" && jobInJobComm.Count > 0)
            {
                if (MessageBox.Show("This job's status will be changed to 'Complete: Pending Commission' in order to pay added employee.",
                    "QDRIVE - WRT Coordinator", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    main.tbempjobTableAdapter.Insert(empJobStatus, Convert.ToInt32(lstEmployees.SelectedValue), jobID);
                    lblJobStatus.Text = "Complete: Pending Commission";

                    txtLabor.Text = Database.SelectStatementDub("jobcomm_labor", "tbjobcomm", "job_id", jobID).ToString();
                    txtEquip.Text = Database.SelectStatementDub("jobcomm_equip", "tbjobcomm", "job_id", jobID).ToString();
                    txtMonitor.Text = Database.SelectStatementDub("jobcomm_mon", "tbjobcomm", "job_id", jobID).ToString();
                    lblTotal.Text = Database.SelectStatementDub("jobcomm_total", "tbjobcomm", "job_id", jobID).ToString();
                    txtHours.Text = Database.SelectStatementDub("jobcomm_hours", "tbjobcomm", "job_id", jobID).ToString();
                    txtAfterHours.Text = Database.SelectStatementDub("jobcomm_after_hours", "tbjobcomm", "job_id", jobID).ToString();
                }
            }
            else if(lblJobStatus.Text == "Closed" && jobInJobComm.Count == 0)
            {
                empJobStatus = 2;
                main.tbempjobTableAdapter.Insert(empJobStatus, Convert.ToInt32(lstEmployees.SelectedValue), jobID);
            }
            else
            {
                main.tbempjobTableAdapter.Insert(empJobStatus, Convert.ToInt32(lstEmployees.SelectedValue), jobID);
            }

            FillEmployeeAdapters();

        }

        private void RemoveEmployees()
        {
            try
            {
                int payStatus = Database.SelectStatementInt("empjob_pay_status", "tbempjob", "empjob_id", Convert.ToInt32(lstJobSiteEmployee.SelectedValue));
                if (payStatus == 0 || payStatus == 2)
                {
                    Database.DeleteStatement("tbempjob", "empjob_id", Convert.ToInt32(lstJobSiteEmployee.SelectedValue));
                    FillEmployeeAdapters();
                }
                else if(payStatus == 1)
                    MessageBox.Show("Unable to remove employee from jobsite. Commission has already been calculated for this employee", "QDRIVE - WRT Coordinator");
            }
            catch (Exception e)
            {
                MessageBox.Show("Show this message to Rob: " + e.GetBaseException().ToString(), "QDRIVE - WRT Coordinator");
            }

        }

        private void PayStatus()
        {
            int paystatus;
            paystatus = Database.SelectStatementInt("empjob_pay_status", "tbempjob", "empjob_id", Convert.ToInt32(lstJobSiteEmployee.SelectedValue));

            if (paystatus == 1)
                lblPayStatus.Text = "Paid";
            else if (paystatus == 0)
                lblPayStatus.Text = "Not Paid";
            else
                lblPayStatus.Text = "Commission not calculated";

        }

        private void FillEmployeeAdapters()
        {
            main.tbempjobTableAdapter.Fill(main.dbwrtcoordinatorDataSet.tbempjob);
            main.dtempnamejobTableAdapter.Fill(main.dbwrtcoordinatorDataSet.dtempnamejob);
            this.tbempjobTableAdapter.Fill(main.dbwrtcoordinatorDataSet.tbempjob);
            this.dtempnamejobTableAdapter.Fill(this.dbwrtcoordinatorDataSet.dtempnamejob);
        }

        private void FillJobAdapters()
        {
            main.tbjobTableAdapter.Fill(main.dbwrtcoordinatorDataSet.tbjob);
            main.dtjobcustTableAdapter.Fill(main.dbwrtcoordinatorDataSet.dtjobcust);
        }

        private void UpdateForm()
        {
            if (dtpJobEnd.Visible)
                Database.updateStatement("tbjob", "job_status", "job_date_start", "job_date_end", "job_id", lblJobStatus.Text, Convert.ToDateTime(dtpJobStart.Text),
                    Convert.ToDateTime(dtpJobEnd.Text), jobID);
            else
                Database.updateStatement("tbjob", "job_status", "job_date_start", "job_id", lblJobStatus.Text, Convert.ToDateTime(dtpJobStart.Text), jobID);

            if (lblJobStatus.Text == "Complete: Pending Commission")
                Database.updateStatement("tbjobcomm", "jobcomm_labor", "jobcomm_equip", "jobcomm_mon", "jobcomm_total", "jobcomm_after_hours", "jobcomm_hours", "job_id",
                    Convert.ToDouble(txtLabor.Text), Convert.ToDouble(txtEquip.Text), Convert.ToDouble(txtMonitor.Text), Convert.ToDouble(lblTotal.Text),
                    Convert.ToDouble(txtAfterHours.Text), Convert.ToDouble(txtHours.Text), jobID);

            Database.updateStatement("tbjob", "ins_id", "job_id", Convert.ToInt32(cbInsurance.SelectedValue), jobID);
            Database.updateStatement("tbjob", "job_claim_number", "job_id", txtClaimNumber.Text, jobID);

            FillJobAdapters();
        }

        public void totalUp()
        {
            double labor;
            double equip;
            double mon;
            double total;

            try
            {
                labor = double.Parse(txtLabor.Text);
            }
            catch
            {
                labor = 0;
            }
            try
            {
                equip = double.Parse(txtEquip.Text);
            }
            catch
            {
                equip = 0;
            }
            try
            {
                mon = double.Parse(txtMonitor.Text);
            }
            catch
            {
                mon = 0;
            }

            total = labor + equip + mon;

            lblTotal.Text = total.ToString();
        }


    }
}
