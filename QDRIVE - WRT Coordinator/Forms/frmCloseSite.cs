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
    public partial class frmCloseSite : Form
    {
        frmMain main = (frmMain)Application.OpenForms["frmMain"];
        int manual = 0;

        public frmCloseSite()
        {
            InitializeComponent();
        }

        private void btnCloseJob_Click(object sender, EventArgs e)
        {
            //insert record into tbjobcomm
            int jobID = int.Parse(lblJobID.Text);

            double labor;
            try { labor = double.Parse(txtLabor.Text); }
            catch { labor = 0; }

            double equip;
            try { equip = double.Parse(txtEquip.Text); }
            catch { equip = 0; }

            double mon;
            try {mon = double.Parse(txtMonitor.Text);}
            catch {mon = 0;}

            double total;
            try { total = double.Parse(lblTotal.Text); }
            catch { total = 0; }

            double afterHours;
            try {afterHours = double.Parse(txtAfterHours.Text);}
            catch { afterHours = 0; }

            double hours;
            try { hours = double.Parse(txtHours.Text); }
            catch { hours = 0; }



            //update job status of record in tbjob
            if (manual == 0)
            {
                Database.updateStatement("tbjob", "job_status", "job_date_end", "job_id", "Complete: Pending Commission",
                    Convert.ToDateTime(dtpEndDate.Value), jobID);
                main.tbjobcommTableAdapter.Insert(labor, equip, mon, total, afterHours, hours, jobID, manual);
                main.tbjobcommTableAdapter.Fill(main.dbwrtcoordinatorDataSet.tbjobcomm);
            }
            else
            {
                Database.updateStatement("tbjob", "job_status", "job_date_end", "job_id", "Closed",
                    Convert.ToDateTime(dtpEndDate.Text), jobID);
                //update pay status for employees to 2. this would mean they are not getting commission calculated manually
                Database.updateStatement("tbempjob", "empjob_pay_status", "job_id", 2, jobID);
            }

            main.tbjobTableAdapter.Fill(main.dbwrtcoordinatorDataSet.tbjob);
            main.dtjobcustTableAdapter.Fill(main.dbwrtcoordinatorDataSet.dtjobcust);

            Close();
        }

        private void ckManual_CheckedChanged(object sender, EventArgs e)
        {
            IsCommCalc();
        }

        private void IsCommCalc()
        {
            if (ckManual.Checked)
                manual = 0;
            else
            {
                manual = 1;
                txtLabor.Enabled = false;
                txtEquip.Enabled = false;
                txtMonitor.Enabled = false;
                lblTotal.Enabled = false;
                txtAfterHours.Enabled = false;
                txtHours.Enabled = false;
            }
        }

        //method to update total label on text_changed event handlers for labor/equip/mon
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

        private void frmCloseSite_Load(object sender, EventArgs e)
        {
            txtLabor.Focus();
            dtpEndDate.Text = DateTime.Today.ToShortDateString();
        }


    }
}