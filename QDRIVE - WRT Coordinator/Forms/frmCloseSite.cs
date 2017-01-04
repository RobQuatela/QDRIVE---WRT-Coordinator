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
        string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\dbwrtcoordinator.accdb";

        public frmCloseSite()
        {
            InitializeComponent();
        }

        private void btnCloseJob_Click(object sender, EventArgs e)
        {
            //insert record into tbjobcomm
            int jobID = int.Parse(lblJobID.Text);
            double labor = double.Parse(txtLabor.Text);

            double equip;
            try { equip = double.Parse(txtEquip.Text); }
            catch { equip = 0; }

            double mon;
            try {mon = double.Parse(txtMonitor.Text);}
            catch {mon = 0;}

            double total = double.Parse(lblTotal.Text);

            double afterHours;
            try {afterHours = double.Parse(txtAfterHours.Text);}
            catch { afterHours = 0; }

            double hours;
            try { hours = double.Parse(txtHours.Text); }
            catch { hours = 0; }

            main.tbjobcommTableAdapter.Insert(labor, equip, mon, total, afterHours, hours, jobID);
            main.tbjobcommTableAdapter.Fill(main.dbwrtcoordinatorDataSet.tbjobcomm);

            //update job status of record in tbjob
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();
                string update = "UPDATE tbjob SET job_status = @status, job_date_end = @end WHERE job_id = @id";
                OleDbCommand cmdUpdate = new OleDbCommand(update, conn);
                cmdUpdate.Parameters.AddWithValue("@status", OleDbType.VarChar).Value = "Complete: Pending Commission";
                cmdUpdate.Parameters.AddWithValue("@end", OleDbType.Date).Value = Convert.ToDateTime(dtpEndDate.Value);
                cmdUpdate.Parameters.AddWithValue("@id", OleDbType.Integer).Value = jobID;
                cmdUpdate.ExecuteNonQuery();
            }

            main.tbjobTableAdapter.Fill(main.dbwrtcoordinatorDataSet.tbjob);
            main.dtjobcustTableAdapter.Fill(main.dbwrtcoordinatorDataSet.dtjobcust);

            Close();
        }

        //method to update total label on text_changed event handlers for labor/equip/mon
        private void totalUp()
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