using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QDRIVE___WRT_Coordinator
{


    public partial class frmEditJobSite : Form
    {
        public int jobID;
        public int coID;
        
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
    }
}
