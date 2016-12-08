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
    public partial class frmMain : Form
    {
        //booleans for tab visibility
        private bool tabCompany;
        private bool tabEmployee;
        private bool tabInsurance;
        private bool tabCustomer;
        private bool tabJobs;
        private bool tabComm;
        private bool tabReport;
        private bool tabEquipment;

        //jobcommid to insert with empcomm
        private int jobCommID;

        //database string
        public string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\dbwrtcoordinator.accdb";


        //report settings variable
        System.Drawing.Printing.PageSettings pg = new System.Drawing.Printing.PageSettings();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbwrtcoordinatorDataSet.dtEmployeeComm' table. You can move, or remove it, as needed.
            this.dtEmployeeCommTableAdapter.Fill(this.dbwrtcoordinatorDataSet.dtEmployeeComm);
            // TODO: This line of code loads data into the 'dbwrtcoordinatorDataSet.dtReportCommDetailEmp' table. You can move, or remove it, as needed.
            this.dtReportCommDetailEmpTableAdapter.Fill(this.dbwrtcoordinatorDataSet.dtReportCommDetailEmp);
            // TODO: This line of code loads data into the 'dbwrtcoordinatorDataSet.dtReportCommDetail' table. You can move, or remove it, as needed.
            this.dtReportCommDetailTableAdapter.Fill(this.dbwrtcoordinatorDataSet.dtReportCommDetail);
            // TODO: This line of code loads data into the 'dbwrtcoordinatorDataSet.dtReportCommDetail' table. You can move, or remove it, as needed.
            this.dtReportCommDetailTableAdapter.Fill(this.dbwrtcoordinatorDataSet.dtReportCommDetail);
            // TODO: This line of code loads data into the 'dbwrtcoordinatorDataSet.dtReportCommDetail' table. You can move, or remove it, as needed.
            this.dtReportCommDetailTableAdapter.Fill(this.dbwrtcoordinatorDataSet.dtReportCommDetail);
            // TODO: This line of code loads data into the 'dbwrtcoordinatorDataSet.dtReportCommDetail' table. You can move, or remove it, as needed.
            this.dtReportCommDetailTableAdapter.Fill(this.dbwrtcoordinatorDataSet.dtReportCommDetail);
            // TODO: This line of code loads data into the 'dbwrtcoordinatorDataSet.dtReportCommSumm' table. You can move, or remove it, as needed.
            this.dtReportCommSummTableAdapter.Fill(this.dbwrtcoordinatorDataSet.dtReportCommSumm);
            // TODO: This line of code loads data into the 'dbwrtcoordinatorDataSet.dtCustomerOpenJobCenter' table. You can move, or remove it, as needed.
            //this.dtCustomerJobCenterTableAdapter.Fill(this.dbwrtcoordinatorDataSet.dtCustomerJobCenter);
            // TODO: This line of code loads data into the 'dbwrtcoordinatorDataSet1.dtCustomerJobCenter' table. You can move, or remove it, as needed.
            //this.dtCustomerClosedJobCenterTableAdapter.Fill(this.dbwrtcoordinatorDataSet1.dtCustomerClosedJobCenter);
            // TODO: This line of code loads data into the 'dbwrtcoordinatorDataSet1.dtCustomerClaim' table. You can move, or remove it, as needed.
            this.dtCustomerClaimTableAdapter.Fill(this.dbwrtcoordinatorDataSet.dtCustomerClaim);
            // TODO: This line of code loads data into the 'dbwrtcoordinatorDataSet1.dtReportSales' table. You can move, or remove it, as needed.
            this.dtReportSalesTableAdapter.Fill(this.dbwrtcoordinatorDataSet.dtReportSales);
            // TODO: This line of code loads data into the 'dbwrtcoordinatorDataSet.dtEquipNameJob' table. You can move, or remove it, as needed.
            this.dtEquipNameJobTableAdapter.Fill(this.dbwrtcoordinatorDataSet.dtEquipNameJob);
            // TODO: This line of code loads data into the 'dbwrtcoordinatorDataSet.dtCityJobs' table. You can move, or remove it, as needed.
            this.dtCityJobsTableAdapter.Fill(this.dbwrtcoordinatorDataSet.dtCityJobs);
            // TODO: This line of code loads data into the 'dbwrtcoordinatorDataSet.dtCityJobs' table. You can move, or remove it, as needed.
            this.dtCityJobsTableAdapter.Fill(this.dbwrtcoordinatorDataSet.dtCityJobs);
            // TODO: This line of code loads data into the 'dbwrtcoordinatorDataSet.dtEquipNameJob' table. You can move, or remove it, as needed.
            this.dtEquipNameJobTableAdapter.Fill(this.dbwrtcoordinatorDataSet.dtEquipNameJob);
            // TODO: This line of code loads data into the 'dbwrtcoordinatorDataSet.tbequipment' table. You can move, or remove it, as needed.
            this.tbequipmentTableAdapter.Fill(this.dbwrtcoordinatorDataSet.tbequipment);
            // TODO: This line of code loads data into the 'dbwrtcoordinatorDataSet.tbjob' table. You can move, or remove it, as needed.
            //this.tbjobTableAdapter.Fill(this.dbwrtcoordinatorDataSet.tbjob);
            this.dtjobcustTableAdapter.Fill(this.dbwrtcoordinatorDataSet.dtjobcust);
            this.dtempnamejobTableAdapter.Fill(this.dbwrtcoordinatorDataSet.dtempnamejob);
            // TODO: This line of code loads data into the 'dbwrtcoordinatorDataSet.tbcustomer' table. You can move, or remove it, as needed.
            this.tbcustomerTableAdapter.Fill(this.dbwrtcoordinatorDataSet.tbcustomer);
            // TODO: This line of code loads data into the 'dbwrtcoordinatorDataSet.tbinsurance' table. You can move, or remove it, as needed.
            this.tbinsuranceTableAdapter.Fill(this.dbwrtcoordinatorDataSet.tbinsurance);
            // TODO: This line of code loads data into the 'dbwrtcoordinatorDataSet.tbemployee' table. You can move, or remove it, as needed.
            this.tbemployeeTableAdapter.Fill(this.dbwrtcoordinatorDataSet.tbemployee);
            this.tbempcommTableAdapter.Fill(this.dbwrtcoordinatorDataSet.tbempcomm);
            
            
            // TODO: This line of code loads data into the 'dbwrtcoordinatorDataSet.tbcompany' table. You can move, or remove it, as needed.
            this.tbcompanyTableAdapter.Fill(this.dbwrtcoordinatorDataSet.tbcompany);

            //hide tabs from start load
            tcMain.TabPages.Remove(tbEmployee);
            tcMain.TabPages.Remove(tbCompany);
            tcMain.TabPages.Remove(tbInsurance);
            tcMain.TabPages.Remove(tbCustomer);
            tcMain.TabPages.Remove(tbJobSite);
            tcMain.TabPages.Remove(tbEquipment);
            tcMain.TabPages.Remove(tbComm);
            tcMain.TabPages.Remove(tbReport);

            //job site center status
            cbJobSiteStatus.SelectedIndex = 0;

            //filtering statements
            filterByCompany();
            //filterEmployeeInformation();
            filterJobByEmployee();
            filterEmpCommByJob();
            filterLaborEquipMon();
            filterEquipByAssignedJob();
            fillFilterCityJob();
            filterEquipByPickupJob();
            filterJobsByCustomer();

            //sort statements
            tbcustomerBindingSource.Sort = "cust_name ASC";
            tbemployeeBindingSource.Sort = "emp_name ASC";
            bsReportEmpCommSumm.Sort = "emp_name ASC";
            bsCommDetailEmp.Sort = "emp_name ASC";


            //filter the reports
            filterEquipPickupReport();
            filterEmpCommSummaryReport();
            filterEmpCommDetailReport();

            //set date for comm summ reports
            dtpCommSummFrom.Text = DateTime.Today.AddDays(-7).ToShortDateString();
            dtpCommSummTo.Text = DateTime.Today.ToShortDateString();

            //refresh the reports
            refreshReports();


        }

        public void refreshReports()
        {
            List<Microsoft.Reporting.WinForms.ReportViewer> reports = new List<Microsoft.Reporting.WinForms.ReportViewer>();
            reports.Add(rvEquipPickup);
            reports.Add(rvEquipmentInventory);
            reports.Add(rvCommDetail);
            reports.Add(rvCommSummary);
            for(int i = 0; i < reports.Count; i++)
            {
                reports[i].SetPageSettings(printPreview(pg));
                reports[i].SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reports[i].RefreshReport();
            }
        }

        //methods to load/filter/refresh reports
        public void filterEquipPickupReport()
        {
            bsEquipPickCustomerList.Filter = "job_status = 'Equipment Assigned' AND co_id = " + Convert.ToInt32(lstCompanies.SelectedValue) + "";
            dtEquipPickupCustJobBindingSource.Filter = "job_id = " + Convert.ToInt32(lstJobSiteByLocation.SelectedValue) + "";
            dtEquipNameReportBindingSource.Filter = "job_id = " + Convert.ToInt32(lstJobSiteByLocation.SelectedValue) + "";
            rvEquipPickup.RefreshReport();
        }

        public void filterEquipInventoryReport()
        {
            rvEquipmentInventory.RefreshReport();
        }

        public void filterEmpCommSummaryReport()
        {
            DateTime from = dtpCommSummFrom.Value;
            DateTime to = dtpCommSummTo.Value;
            string insurance;

            //set report parameters
            Microsoft.Reporting.WinForms.ReportParameter paramFrom = new Microsoft.Reporting.WinForms.ReportParameter("dateFrom", from.ToString());
            Microsoft.Reporting.WinForms.ReportParameter paramTo = new Microsoft.Reporting.WinForms.ReportParameter("dateTo", to.ToString());      

            //what to do if filter by insurance is checked
            if (ckFilterbyIns.Checked)
            {
                lstCommIns.Visible = true;
                dtReportCommSummBindingSource.Filter = "emp_id = " + Convert.ToInt32(lstCommSummEmp.SelectedValue) + " AND ins_id = " + Convert.ToInt32(lstCommIns.SelectedValue) + " AND job_date_end >= '" + from + "' AND job_date_end <= '" + to + "'";
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    string select = "SELECT ins_name FROM tbinsurance WHERE ins_id = @id";
                    OleDbCommand cmdSelect = new OleDbCommand(select, conn);
                    conn.Open();
                    cmdSelect.Parameters.AddWithValue("@id", OleDbType.Integer).Value = lstCommIns.SelectedValue;
                    insurance = cmdSelect.ExecuteScalar().ToString();
                }
            }
            else
            {
                lstCommIns.Visible = false;
                dtReportCommSummBindingSource.Filter = "emp_id = " + Convert.ToInt32(lstCommSummEmp.SelectedValue) + " AND job_date_end >= '" + from + "' AND job_date_end <= '" + to + "'";
                insurance = "All";
            }

            Microsoft.Reporting.WinForms.ReportParameter insParam = new Microsoft.Reporting.WinForms.ReportParameter("insurance", insurance);

            rvCommSummary.LocalReport.SetParameters(paramFrom);
            rvCommSummary.LocalReport.SetParameters(paramTo);
            rvCommSummary.LocalReport.SetParameters(insParam);
            rvCommSummary.RefreshReport();
        }

        public void filterEmpCommDetailReport()
        {
            bsCommDetailReport.Filter = "emp_id = " + Convert.ToInt32(lstCommDetailEmp.SelectedValue) + "";
            bsCommDetailReport.Sort = "cust_name ASC";
            bsReportCommDetail.Filter = "jobcomm_id = " + Convert.ToInt32(lstCommDetailJobs.SelectedValue) + "";

            //query to find the empcomm_id to filter the report empcomm dataset binding source to
            int empcomm_id;
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();
                string sqlSelect = "SELECT empcomm_id FROM tbempcomm WHERE emp_id = @emp AND jobcomm_id = @jobcomm";
                OleDbCommand cmdSelect = new OleDbCommand(sqlSelect, conn);
                cmdSelect.Parameters.AddWithValue("@emp", OleDbType.Integer).Value = Convert.ToInt32(lstCommDetailEmp.SelectedValue) + "";
                cmdSelect.Parameters.AddWithValue("@jobcomm", OleDbType.Integer).Value = Convert.ToInt32(lstCommDetailJobs.SelectedValue) + "";
                empcomm_id = Convert.ToInt32(cmdSelect.ExecuteScalar());
            }

            bsCommDetailReportEmp.Filter = "empcomm_id = " + empcomm_id + "";
            
            rvCommDetail.RefreshReport();
        }

        //method to set reports into print preview mode
        public System.Drawing.Printing.PageSettings printPreview(System.Drawing.Printing.PageSettings p)
        {
            p.Margins.Top = 50;
            p.Margins.Bottom = 50;
            p.Margins.Left = 0;
            p.Margins.Right = 0;
            return p;
        }

        //method to update empcom totalPay
        public void updateTotalPay(string labor, string laborPer, string equip, string equipPer,
            string mon, string monPer, string comPer, string hourlyWage, string hours)
        {
            double l;
            double e;
            double m;
            double lp;
            double ep;
            double mp;
            double cp;
            double wage;
            double h;

            
            try
            {
                l = double.Parse(labor);
            }
            catch
            {
                l = 0;
            }
            try
            {
                lp = double.Parse(laborPer);
            }
            catch
            {
                lp = 0;
            }
            try
            {
                e = double.Parse(equip);
            }
            catch
            {
                e = 0;
            }
            try
            {
                ep = double.Parse(equipPer);
            }
            catch
            {
                ep = 0;
            }
            try
            {
                m = double.Parse(mon);
            }
            catch
            {
                m = 0;
            }
            try
            {
                mp = double.Parse(monPer);
            }
            catch
            {
                mp = 0;
            }
            try
            {
                if (double.Parse(comPer) >= 1)
                    cp = double.Parse(comPer) / 100;
                else
                    cp = double.Parse(comPer);
            }
            catch
            {
                cp = 0;
            }
            try
            {
                wage = double.Parse(hourlyWage);
            }
            catch
            {
                wage = 0;
            }
            try
            {
                h = double.Parse(hours);
            }
            catch
            {
                h = 0;
            }
            double totalPay = ((l * lp) + (e * ep) + (m * mp)) * cp;
            double initPay = wage * h * -1;
            double netPay = totalPay + initPay;
            txtTotalPay.Text = totalPay.ToString();
            txtInitialWage.Text = initPay.ToString();
            txtNetCommission.Text = netPay.ToString();
        }

        //method to update net pay


        //filtering method
        private void filterByCompany()
        {
            try
            {
                this.Text = "QDRIVE - WRT Coordinator (" + lstCompanies.Text + ")";
                List<BindingSource> bs = new List<BindingSource>();
                bs.Add(tbemployeeBindingSource);
                bs.Add(tbcustomerBindingSource);
                bs.Add(dtCustomerClaimBindingSource);
                bs.Add(dtjobcustBindingSource);
                bs.Add(dtjobcustBindingSourceCOMM);
                bs.Add(dtjobcustBindingSourceEQUIP);
                bs.Add(tbequipmentBindingSource);
                bs.Add(dtCityJobsBindingSource);
                bs.Add(bsEquipInvCoReport);
                bs.Add(bsReportEmpCommSumm);
                bs.Add(bsCommDetailEmp);

                for (int i = 0; i < bs.Count; i++)
                {
                    bs[i].Filter = "co_id = " + Convert.ToInt32(lstCompanies.SelectedValue) + "";
                }

                dtjobcustBindingSource.Filter = "job_status = '" + cbJobSiteStatus.Text + "' AND co_id = " + Convert.ToInt32(lstCompanies.SelectedValue) + "";
                dtjobcustBindingSourceCOMM.Filter = "job_status = 'Complete: Pending Commission' AND co_id = " + Convert.ToInt32(lstCompanies.SelectedValue) + "";
                dtjobcustBindingSourceEQUIP.Filter = "job_status = 'Scoped' AND co_id = " + Convert.ToInt32(lstCompanies.SelectedValue) + "";
                dtjobcustBindingSourceASSIGNED.Filter = "job_status = 'Equipment Assigned' AND co_id = " + Convert.ToInt32(lstCompanies.SelectedValue) + "";
                dtjobcustTableAdapter.Fill(dbwrtcoordinatorDataSet.dtjobcust);
                filterEquipInventoryReport();
            }
            catch
            {
                //MessageBox.Show("Error on start");
            }

        }

        //filter equipment by assigned job site

        public void filterEquipByAssignedJob()
        {
            try
            {
                lbljobIDASSIGNED.Visible = true;
                dtEquipNameJobTableAdapter.Fill(dbwrtcoordinatorDataSet.dtEquipNameJob);
                Binding jobId = new Binding("Text", dtjobcustBindingSourceASSIGNED, "job_id");
                lbljobIDASSIGNED.DataBindings.Clear();
                lbljobIDASSIGNED.DataBindings.Add(jobId);
                int id = Convert.ToInt32(lbljobIDASSIGNED.Text);
                dtEquipNameJobBindingSource.Filter = "job_id = " + id + "";
                //dgvJobLocation.DataSource = dtjobcustTableAdapter.CityJobSites();
            }
            catch
            {

            }
            finally
            {
                lbljobIDASSIGNED.Visible = false;
            }
        }

        private void filterEquipByPickupJob()
        {
            try
            {
                dtEquipNameJobTableAdapter.Fill(dbwrtcoordinatorDataSet.dtEquipNameJob);
                int id = Convert.ToInt32(lstJobSiteByLocation.SelectedValue);
                dtEquipNameJobBindingSourcePICKUP.Filter = "job_id = " + id + "";
            }
            catch
            {

            }
        }

        private void filterEmpCommByJob()
        {
            lblCOMMJobID.Visible = true;
            int jobId;
            try
            {
                jobId = int.Parse(lblCOMMJobID.Text);
            }
            catch
            {
                jobId = 0;
            }
            dtempnamejobBindingSourceCOMM.Filter = "job_id = " + jobId + " AND empjob_pay_status = 0";
            lblCOMMJobID.Visible = false;
        }
        
        private void filterLaborEquipMon()
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                //currency variables
                double commLabor;
                double commEquip;
                double commMon;

                
                conn.Open();
                string labor = "SELECT jobcomm_labor FROM tbjobcomm WHERE job_id = @id";
                string equip = "SELECT jobcomm_equip FROM tbjobcomm WHERE job_id = @id";
                string mon = "SELECT jobcomm_mon FROM tbjobcomm WHERE job_id = @id";
                string commJobId = "SELECT jobcomm_id FROM tbjobcomm WHERE job_id = @id";
                string commPer = "SELECT emp_per FROM tbemployee WHERE emp_id = @emp";
                string jobHours = "SELECT jobcomm_hours FROM tbjobcomm WHERE job_id = @id";
                OleDbCommand cmdLabor = new OleDbCommand(labor, conn);
                OleDbCommand cmdEquip = new OleDbCommand(equip, conn);
                OleDbCommand cmdMon = new OleDbCommand(mon, conn);
                OleDbCommand cmdCommID = new OleDbCommand(commJobId, conn);
                OleDbCommand cmdCommPer = new OleDbCommand(commPer, conn);
                OleDbCommand cmdjobHours = new OleDbCommand(jobHours, conn);
                try
                {
                    cmdLabor.Parameters.AddWithValue("@id", OleDbType.Integer).Value = int.Parse(lblCOMMJobID.Text);
                    cmdEquip.Parameters.AddWithValue("@id", OleDbType.Integer).Value = int.Parse(lblCOMMJobID.Text);
                    cmdMon.Parameters.AddWithValue("@id", OleDbType.Integer).Value = int.Parse(lblCOMMJobID.Text);
                    cmdCommID.Parameters.AddWithValue("@id", OleDbType.Integer).Value = int.Parse(lblCOMMJobID.Text);
                    cmdCommPer.Parameters.AddWithValue("@emp", OleDbType.Integer).Value = Convert.ToInt32(lstAssignedEmployees.SelectedValue);
                    cmdjobHours.Parameters.AddWithValue("@id", OleDbType.Integer).Value = int.Parse(lblCOMMJobID.Text);
                    commLabor = Convert.ToDouble(cmdLabor.ExecuteScalar());
                    commEquip = Convert.ToDouble(cmdEquip.ExecuteScalar());
                    commMon = Convert.ToDouble(cmdMon.ExecuteScalar());
                    jobCommID = Convert.ToInt32(cmdCommID.ExecuteScalar());
                    lblCommComm.Text = Convert.ToString(cmdCommPer.ExecuteScalar());
                    lblHours.Text = Convert.ToString(cmdjobHours.ExecuteScalar());

                    lblCommLabor.Text = commLabor.ToString();
                    lblCommEquip.Text = commEquip.ToString();
                    lblCommMonitor.Text = commMon.ToString();
                }
                catch
                {

                }
            }
        }

        //method to filter assigned employees by job site
        public void filterJobByEmployee()
        {
            try
            {
                lblJobID.Visible = true;
                int id = Convert.ToInt32(lblJobID.Text);
                dtempnamejobBindingSource.Filter = "job_id = " + id + "";
            }
            catch
            {

            }
            finally
            {
                lblJobID.Visible = false;
            }
        }

        //fill and filter city and job count by city
        public void fillFilterCityJob()
        {
            //if (ckFilterByLocation.Checked)
            //{
            //dgvJobLocation.Enabled = true;
            //dtCityJobsTableAdapter.Fill(dbwrtcoordinatorDataSet.dtCityJobs);
            lblCity.Visible = true;
                if (ckFilterByDate.Checked)
                {
                    dtpLocationDate.Enabled = true;
                    dtCityJobsBindingSource.Filter = "jobequip_date_pickup = '" + Convert.ToDateTime(dtpLocationDate.Text) + "' AND co_id = " + Convert.ToInt32(lstCompanies.SelectedValue) + "";
                }
                else if (ckFilterByDate.Checked == false)
                {
                    dtCityJobsBindingSource.Filter = "co_id = " + Convert.ToInt32(lstCompanies.SelectedValue) + "";
                }
                dtCustByCityTableAdapter.Fill(dbwrtcoordinatorDataSet.dtCustByCity);
                dtCustByCityBindingSource.Filter = "cust_city = '" + lblCity.Text + "'";
            filterEquipPickupReport();
            lblCity.Visible = false;
            //}
           /* else
            {
                dgvJobLocation.Enabled = false;
                dtCustByCityTableAdapter.Fill(dbwrtcoordinatorDataSet.dtCustByCity);
                if(ckFilterByDate.Checked)
                {
                    dtpLocationDate.Enabled = true;
                    dtCustByCityBindingSource.Filter = "jobequip_date_pickup = '" + Convert.ToDateTime(dtpLocationDate.Text) + "' AND co_id = " + Convert.ToInt32(lstCompanies.SelectedValue) + "";
                }
                else if (ckFilterByDate.Checked == false)
                {
                    dtCustByCityBindingSource.Filter = "co_id = " + Convert.ToInt32(lstCompanies.SelectedValue) + "";
                }
            } */
        }

        //method to filter jobs by customer in customer center
        public void filterJobsByCustomer()
        {
            dtCustomerJobCenterTableAdapter.Fill(dbwrtcoordinatorDataSet.dtCustomerJobCenter);
            dtCustomerJobCenterBindingSource.Filter = "cust_id = " + Convert.ToInt32(lstCustomers.SelectedValue) + "";
        }

        //method to filter employee information in employee center
        public void filterEmployeeInformation()
        {
            lblEmpID.Visible = true;
            tbempcommBindingSource.Filter = "emp_id = " + Convert.ToInt32(lblEmpID.Text) + "";
            bsEmployeeComm.Filter = "emp_id = " + Convert.ToInt32(lblEmpID.Text) + "";
            lblEmpID.Visible = false;
        }

        //event handlers for tab visibility

        //method to manage tab pages that are visisble/non-visible
        private bool tabManager(TabPage tab, bool open, ToolStripMenuItem menuItem)
        {
            if(open)
            {
                tcMain.TabPages.Remove(tab);
                open = false;
                menuItem.Font = new Font(menuItem.Font, FontStyle.Regular);
                return open;
            }
            else
            {
                tcMain.TabPages.Add(tab);
                tcMain.SelectedTab = tab;
                open = true;
                menuItem.Font = new Font(menuItem.Font, FontStyle.Bold);
                tcMain.TabPages.Remove(tbWelcome);
                return open;
            }
        }

        private void menuCompany_Click(object sender, EventArgs e)
        {
            tabCompany = tabManager(tbCompany, tabCompany, menuCompany);
        }

        private void menuEmployee_Click(object sender, EventArgs e)
        {
            tabEmployee = tabManager(tbEmployee, tabEmployee, menuEmployee);
        }

        private void menuInsurance_Click(object sender, EventArgs e)
        {
            tabInsurance = tabManager(tbInsurance, tabInsurance, menuInsurance);
        }

        private void menuCustomer_Click(object sender, EventArgs e)
        {
            tabCustomer = tabManager(tbCustomer, tabCustomer, menuCustomer);
        }

        private void menuJobs_Click(object sender, EventArgs e)
        {
            tabJobs = tabManager(tbJobSite, tabJobs, menuJobs);
        }

        private void menuEquipment_Click(object sender, EventArgs e)
        {
            tabEquipment = tabManager(tbEquipment, tabEquipment, menuEquipment);
        }

        private void menuCommission_Click(object sender, EventArgs e)
        {
            tabComm = tabManager(tbComm, tabComm, menuCommission);
        }

        private void menuReports_Click(object sender, EventArgs e)
        {
            tabReport = tabManager(tbReport, tabReport, menuReports);
        }

        private void lstCompanies_SelectedValueChanged(object sender, EventArgs e)
        {
            filterByCompany();
            filterJobByEmployee();
            fillFilterCityJob();
        }

        private void btnCreateJobSite_Click(object sender, EventArgs e)
        {
            frmJobSiteWizard jobSiteWizard = new frmJobSiteWizard();
            jobSiteWizard.Show();
        }

        //database functions
        
        private void saveEmployees(int id, string name, double percent)
        {
            string sqlSave = "UPDATE tbemployee SET emp_name = @name, emp_per = @per WHERE emp_id = @id";
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();
                OleDbCommand cmdSave = new OleDbCommand(sqlSave, conn);
                cmdSave.Parameters.AddWithValue("@name", OleDbType.VarChar).Value = name;
                cmdSave.Parameters.AddWithValue("@per", OleDbType.Double).Value = percent;
                cmdSave.Parameters.AddWithValue("@id", OleDbType.Integer).Value = id;
                cmdSave.ExecuteNonQuery();
                
            }

            tbemployeeTableAdapter.Fill(dbwrtcoordinatorDataSet.tbemployee);
        }

        //generic method to show selected dgv rows in textboxes
        private void selectRowDataGridView(DataGridView dgv, List<TextBox> txt)
        {
            int i = dgv.CurrentRow.Index;
            for(int j = 0; j < txt.Count; j++)
            {
                txt[j].Text = Convert.ToString(dgv[j+1, i].Value);
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(lstCompanies.SelectedValue);
                double percent;
                if (double.Parse(txtEmpNewPercent.Text) >= 1)
                    percent = double.Parse(txtEmpNewPercent.Text) / 100;
                else
                    percent = double.Parse(txtEmpNewPercent.Text);

                tbemployeeTableAdapter.Insert(txtEmpNewName.Text, percent, id);
                tbemployeeTableAdapter.Fill(dbwrtcoordinatorDataSet.tbemployee);
                txtEmpNewName.Clear();
                txtEmpNewPercent.Clear();
            }
            catch
            {
                MessageBox.Show("Please make sure all fields are filled out correctly.", "QDRIVE - WRT Coordinator");
            }
        }

        //add insurance company to database
        private void btnAddInsurance_Click(object sender, EventArgs e)
        {
            tbinsuranceTableAdapter.Insert(txtAddInsurance.Text);
            tbinsuranceTableAdapter.Fill(dbwrtcoordinatorDataSet.tbinsurance);
            txtAddInsurance.Clear();
        }

        //update insurance name
        private void btnEditInsurance_Click(object sender, EventArgs e)
        {
            string sqlEdit = "UPDATE tbinsurance SET ins_name = @name WHERE ins_id = @id";

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();
                OleDbCommand cmdEdit = new OleDbCommand(sqlEdit, conn);
                cmdEdit.Parameters.AddWithValue("@name", OleDbType.VarChar).Value = txtEditInsurance.Text;
                cmdEdit.Parameters.AddWithValue("@id", OleDbType.Integer).Value = lstInsurance.SelectedValue;
                cmdEdit.ExecuteNonQuery();
            }

            tbinsuranceTableAdapter.Fill(dbwrtcoordinatorDataSet.tbinsurance);
        }

        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            lblEmpID.Visible = true;
            int id = int.Parse(lblEmpID.Text);
            string name = txtEmpEditName.Text;
            double percent;
            if (double.Parse(txtEmpEditPercent.Text) >= 1)
                percent = double.Parse(txtEmpEditPercent.Text) / 100;
            else
                percent = double.Parse(txtEmpEditPercent.Text);
            saveEmployees(id, name, percent);
            lblEmpID.Visible = false;
        }

        private void cbJobSiteStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtjobcustBindingSource.Filter = "job_status = '" + cbJobSiteStatus.Text + "' AND co_id = " + Convert.ToInt32(lstCompanies.SelectedValue) + "";
            filterJobByEmployee();
        }

        private void btnJobSiteEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lblJobID.Text);
        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            //insert customer into tbcustomer
            string custName = txtCustNewName.Text;
            tbcustomerTableAdapter.Insert(custName, txtCustNewAddress.Text, txtCustNewCity.Text,
                txtCustNewState.Text, txtCustNewZip.Text, Convert.ToInt32(lstCompanies.SelectedValue));
            this.dbwrtcoordinatorDataSet.tbcustomer.Clear();
            this.tbcustomerTableAdapter.Fill(this.dbwrtcoordinatorDataSet.tbcustomer);
            this.dtCustomerClaimTableAdapter.Fill(this.dbwrtcoordinatorDataSet.dtCustomerClaim);
            
            filterJobsByCustomer();

            txtCustNewName.Clear();
            txtCustNewAddress.Clear();
            txtCustNewCity.Clear();
            txtCustNewState.Clear();
            txtCustNewZip.Clear();

            //messagebox to add job site as soon as user adds customer to tbcustomer
            if(MessageBox.Show("Do you want to create a job site for this customer?", "QDRIVE - WRT Coordinator", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmJobSiteWizard jobSiteWizard = new frmJobSiteWizard();
                jobSiteWizard.tbcustomerTableAdapter.Fill(dbwrtcoordinatorDataSet.tbcustomer);
                jobSiteWizard.txtSearchCustomer.Visible = false;
                jobSiteWizard.lstCustomer.Visible = false;
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    string select = "SELECT MAX(cust_id) FROM tbcustomer WHERE co_id = @id";
                    conn.Open();
                    OleDbCommand cmdSelect = new OleDbCommand(select, conn);
                    cmdSelect.Parameters.AddWithValue("@id", OleDbType.Integer).Value = Convert.ToInt32(lstCompanies.SelectedValue);
                    jobSiteWizard.lblCustID.Text = cmdSelect.ExecuteScalar().ToString();
                }
                jobSiteWizard.lblCustomer.Visible = true;
                jobSiteWizard.lblCustomer.Text = custName;
                jobSiteWizard.Show();
            }
            
        }
        
        private void btnCompleteWork_Click(object sender, EventArgs e)
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                lblJobID.Visible = true;
                conn.Open();
                string update = "UPDATE tbjob SET job_status = @status WHERE job_id = @id";
                OleDbCommand cmdUpdate = new OleDbCommand(update, conn);
                cmdUpdate.Parameters.AddWithValue("@status", OleDbType.VarChar).Value = "Complete: Pending Total";
                cmdUpdate.Parameters.AddWithValue("@id", OleDbType.Integer).Value = Convert.ToInt32(lblJobID.Text);
                cmdUpdate.ExecuteNonQuery();
                lblJobID.Visible = false;
            }

            tbjobTableAdapter.Fill(dbwrtcoordinatorDataSet.tbjob);
            dtjobcustTableAdapter.Fill(dbwrtcoordinatorDataSet.dtjobcust);
        }

        private void btnCloseSite_Click(object sender, EventArgs e)
        {
            lblJobID.Visible = true;
            frmCloseSite closeSite = new frmCloseSite();
            closeSite.lblJobID.Text = lblJobID.Text;
            closeSite.lblCustomer.Text = lblJobSiteCustomer.Text;
            closeSite.Show();
            lblJobID.Visible = false;
        }

        private void dgvCompleteJobSites_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            filterEmpCommByJob();
            filterLaborEquipMon();
            updateTotalPay(lblCommLabor.Text, txtMultiLabor.Text, lblCommEquip.Text,
                 txtMultiEquip.Text, lblCommMonitor.Text, txtMultiMonitor.Text, txtMultiComm.Text, txtHourlyWage.Text, lblHours.Text);
        }

        private void txtMultiComm_TextChanged(object sender, EventArgs e)
        {
            updateTotalPay(lblCommLabor.Text, txtMultiLabor.Text, lblCommEquip.Text,
                 txtMultiEquip.Text, lblCommMonitor.Text, txtMultiMonitor.Text, txtMultiComm.Text, txtHourlyWage.Text, lblHours.Text);
        }

        private void lstAssignedEmployees_SelectedValueChanged(object sender, EventArgs e)
        {
            filterLaborEquipMon();
        }

        private void txtMultiLabor_TextChanged(object sender, EventArgs e)
        {
            updateTotalPay(lblCommLabor.Text, txtMultiLabor.Text, lblCommEquip.Text,
                             txtMultiEquip.Text, lblCommMonitor.Text, txtMultiMonitor.Text, txtMultiComm.Text, txtHourlyWage.Text, lblHours.Text);
        }

        private void txtMultiEquip_TextChanged(object sender, EventArgs e)
        {
            updateTotalPay(lblCommLabor.Text, txtMultiLabor.Text, lblCommEquip.Text,
                             txtMultiEquip.Text, lblCommMonitor.Text, txtMultiMonitor.Text, txtMultiComm.Text, txtHourlyWage.Text, lblHours.Text);
        }

        private void txtMultiMonitor_TextChanged(object sender, EventArgs e)
        {
            updateTotalPay(lblCommLabor.Text, txtMultiLabor.Text, lblCommEquip.Text,
                             txtMultiEquip.Text, lblCommMonitor.Text, txtMultiMonitor.Text, txtMultiComm.Text, txtHourlyWage.Text, lblHours.Text);
        }

        private void txtHourlyWage_TextChanged(object sender, EventArgs e)
        {
            updateTotalPay(lblCommLabor.Text, txtMultiLabor.Text, lblCommEquip.Text,
                 txtMultiEquip.Text, lblCommMonitor.Text, txtMultiMonitor.Text, txtMultiComm.Text, txtHourlyWage.Text, lblHours.Text);
        }

        private void btnAddComm_Click(object sender, EventArgs e)
        {
            try
            {
                //insert record into tbeempcomm
                double laborComm = double.Parse(txtMultiLabor.Text);
                double equipComm = double.Parse(txtMultiEquip.Text);
                double monComm = double.Parse(txtMultiMonitor.Text);
                double perComm;
                if (double.Parse(txtMultiComm.Text) >= 1)
                    perComm = double.Parse(txtMultiComm.Text) / 100;
                else
                    perComm = double.Parse(txtMultiComm.Text);
                double totalPay = double.Parse(txtTotalPay.Text);
                int empID = Convert.ToInt32(lstAssignedEmployees.SelectedValue);
                double hourlyWage;
                try
                {
                    hourlyWage = double.Parse(txtHourlyWage.Text);
                }
                catch
                {
                    hourlyWage = 0;
                }
                double initialWage = double.Parse(txtInitialWage.Text);
                double netPay = double.Parse(txtNetCommission.Text);

                tbempcommTableAdapter.Insert(laborComm, equipComm, monComm,
                    perComm, totalPay, jobCommID, empID, hourlyWage, initialWage, netPay);
                tbempcommTableAdapter.Fill(dbwrtcoordinatorDataSet.tbempcomm);

                //update record from empjob
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    lblCOMMJobID.Visible = true;
                    conn.Open();
                    string update = "UPDATE tbempjob SET empjob_pay_status = @status WHERE emp_id = @emp AND job_id = @job";
                    OleDbCommand cmdUpdate = new OleDbCommand(update, conn);
                    cmdUpdate.Parameters.AddWithValue("@status", OleDbType.Integer).Value = 1;
                    cmdUpdate.Parameters.AddWithValue("@emp", OleDbType.Integer).Value = Convert.ToInt32(lstAssignedEmployees.SelectedValue);
                    cmdUpdate.Parameters.AddWithValue("@job", OleDbType.Integer).Value = Convert.ToInt32(lblCOMMJobID.Text);
                    cmdUpdate.ExecuteNonQuery();
                    lblCOMMJobID.Visible = false;
                }

                tbempjobTableAdapter.Fill(dbwrtcoordinatorDataSet.tbempjob);
                dtempnamejobTableAdapter.Fill(dbwrtcoordinatorDataSet.dtempnamejob);
                filterEmpCommByJob();
                dtReportCommSummTableAdapter.Fill(dbwrtcoordinatorDataSet.dtReportCommSumm);
                dtReportCommDetailTableAdapter.Fill(dbwrtcoordinatorDataSet.dtReportCommDetail);
                dtReportCommDetailEmpTableAdapter.Fill(dbwrtcoordinatorDataSet.dtReportCommDetailEmp);
                filterEmpCommDetailReport();

                txtMultiLabor.Text = "1.00";
                txtMultiEquip.Text = "0.50";
                txtMultiMonitor.Text = "0.50";
                txtHourlyWage.Text = "0.00";
                txtMultiComm.Clear();
                txtTotalPay.Clear();
                txtInitialWage.Text = "";
                txtNetCommission.Clear();
                txtMultiComm.Focus();
            }
            catch
            {
                MessageBox.Show("Please make sure there is an employee and customer selected.", "QDRIVE - WRT Coordinator");
            }
        }

        private void btnCloseJob_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    lbljobCommID.Visible = true;
                    string update = "UPDATE tbjob SET job_status = 'Closed' WHERE job_id = @id";
                    OleDbCommand cmdUpdate = new OleDbCommand(update, conn);
                    cmdUpdate.Parameters.AddWithValue("@id", OleDbType.Integer).Value = Convert.ToInt32(lbljobCommID.Text);
                    cmdUpdate.ExecuteNonQuery();
                    lbljobCommID.Visible = false;
                }

                tbjobTableAdapter.Fill(dbwrtcoordinatorDataSet.tbjob);
                dtjobcustTableAdapter.Fill(dbwrtcoordinatorDataSet.dtjobcust);
            }
            catch
            {
                MessageBox.Show("Please make sure there is a job to close out.", "QDRIVE - WRT Coordinator");
            }
        }

        private void btnAssignEquip_Click(object sender, EventArgs e)
        {
            frmAssignEquip assignEquip = new frmAssignEquip();
            assignEquip.tbequipmentBindingSource.Filter = "co_id = " + Convert.ToInt32(lstCompanies.SelectedValue);
            

            lblScopedCustID.Visible = true;
            lblScopedJobID.Visible = true;
            assignEquip.lblJobID.Text = lblScopedJobID.Text;
            assignEquip.lblCustName.Text = lblScopedCustID.Text;
            lblScopedCustID.Visible = false;

            assignEquip.Show();
            this.Enabled = false;
        }

        private void dgvAssignedJobSites_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            filterEquipByAssignedJob();
        }

        private void dgvJobSite_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            filterJobByEmployee();
        }

        private void dgvJobLocation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fillFilterCityJob();
            filterEquipByPickupJob();
            filterEquipPickupReport();
        }

        private void lstJobSiteByLocation_SelectedValueChanged(object sender, EventArgs e)
        {
            filterEquipByPickupJob();
        }

        private void ckFilterByDate_CheckedChanged(object sender, EventArgs e)
        {
            fillFilterCityJob();
        }

        private void dtpLocationDate_ValueChanged(object sender, EventArgs e)
        {
            //dtCityJobsBindingSource.Filter = "jobequip_date_pickup = '" + Convert.ToDateTime(dtpLocationDate.Text) + "'";
            fillFilterCityJob();
        }

        private void btnPickupEquip_Click(object sender, EventArgs e)
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();

                //get count of tbjobequip equipment types in job and store in array
                string sqlGetTypes = "SELECT equip_id FROM tbjobequip WHERE job_id = @id";
                OleDbCommand cmdGetTypes = new OleDbCommand(sqlGetTypes, conn);
                cmdGetTypes.Parameters.AddWithValue("@id", OleDbType.Integer).Value = Convert.ToInt32(lstJobSiteByLocation.SelectedValue);
                OleDbDataReader reader = cmdGetTypes.ExecuteReader();
                List<int> lstEquipIds = new List<int>();

                while (reader.Read())
                    lstEquipIds.Add(reader.GetInt32(0));

                //get count of tbjobequip equipment in job and store in array
                string sqlGetCount = "SELECT jobequip_count FROM tbjobequip WHERE job_id = @id";
                OleDbCommand cmdGetCount = new OleDbCommand(sqlGetCount, conn);
                cmdGetCount.Parameters.AddWithValue("@id", OleDbType.Integer).Value = Convert.ToInt32(lstJobSiteByLocation.SelectedValue);
                OleDbDataReader countReader = cmdGetCount.ExecuteReader();
                List<int> lstEquipCount = new List<int>();

                while (countReader.Read())
                    lstEquipCount.Add(countReader.GetInt32(0));

                //get current stockin count of equip id and store it in a list
                string sqlCurrentInCount = "SELECT equip_stock_in FROM tbequipment WHERE equip_id = @id";
                OleDbCommand[] cmdCurrentInCount = new OleDbCommand[lstEquipIds.Count];
                List<int> lstCurrentInCount = new List<int>();
                for (int i = 0; i < cmdCurrentInCount.Length; i++)
                {
                    cmdCurrentInCount[i] = new OleDbCommand(sqlCurrentInCount, conn);
                    cmdCurrentInCount[i].Parameters.AddWithValue("@id", OleDbType.Integer).Value = lstEquipIds[i];
                    lstCurrentInCount.Add(Convert.ToInt32(cmdCurrentInCount[i].ExecuteScalar()));
                }

                //get current stockout count of equip id and store it in a list
                string sqlCurrentOutCount = "SELECT equip_stock_out FROM tbequipment WHERE equip_id = @id";
                OleDbCommand[] cmdCurrentOutCount = new OleDbCommand[lstEquipIds.Count];
                List<int> lstCurrentOutCount = new List<int>();
                for(int i = 0; i < cmdCurrentOutCount.Length; i++)
                {
                    cmdCurrentOutCount[i] = new OleDbCommand(sqlCurrentOutCount, conn);
                    cmdCurrentOutCount[i].Parameters.AddWithValue("@id", OleDbType.Integer).Value = lstEquipIds[i];
                    lstCurrentOutCount.Add(Convert.ToInt32(cmdCurrentOutCount[i].ExecuteScalar()));
                }
                

                //add count and stock together in new equipment list
                List<int> lstNewInCount = new List<int>();
                for(int i = 0; i < lstCurrentInCount.Count; i++)
                    lstNewInCount.Add(lstCurrentInCount[i] + lstEquipCount[i]);

                //subtract count and stockout in new equipment list
                List<int> lstNewOutCount = new List<int>();
                for (int i = 0; i < lstCurrentOutCount.Count; i++)
                    lstNewOutCount.Add(lstCurrentOutCount[i] - lstEquipCount[i]);

                //update equipment table with new stockin/stockout count using the new count list
                string sqlUpdateCount = "UPDATE tbequipment SET equip_stock_in = @in, equip_stock_out = @out WHERE equip_id = @id";
                OleDbCommand[] cmdUpdateCount = new OleDbCommand[lstNewInCount.Count];
                for(int i = 0; i < cmdUpdateCount.Length; i++)
                {
                    cmdUpdateCount[i] = new OleDbCommand(sqlUpdateCount, conn);
                    cmdUpdateCount[i].Parameters.AddWithValue("@in", OleDbType.Integer).Value = lstNewInCount[i];
                    cmdUpdateCount[i].Parameters.AddWithValue("@out", OleDbType.Integer).Value = lstNewOutCount[i];
                    cmdUpdateCount[i].Parameters.AddWithValue("@id", OleDbType.Integer).Value = lstEquipIds[i];
                    cmdUpdateCount[i].ExecuteNonQuery();
                }

                //update equipment status of tbjobequip
                string updateEquip = "UPDATE tbjobequip SET jobequip_status = 1 WHERE job_id = @id";
                OleDbCommand cmdEquip = new OleDbCommand(updateEquip, conn);
                cmdEquip.Parameters.AddWithValue("@id", OleDbType.Integer).Value = Convert.ToInt32(lstJobSiteByLocation.SelectedValue);
                cmdEquip.ExecuteNonQuery();
                
                //update job status
                string updateJob = "UPDATE tbjob SET job_status = 'Equipment Picked Up' WHERE job_id = @id";
                OleDbCommand cmdJob = new OleDbCommand(updateJob, conn);
                cmdJob.Parameters.AddWithValue("@id", OleDbType.Integer).Value = Convert.ToInt32(lstJobSiteByLocation.SelectedValue);
                cmdJob.ExecuteNonQuery();


            }

            tbequipmentTableAdapter.Fill(dbwrtcoordinatorDataSet.tbequipment);
            tbjobTableAdapter.Fill(dbwrtcoordinatorDataSet.tbjob);
            dtjobcustTableAdapter.Fill(dbwrtcoordinatorDataSet.dtjobcust);
            dtCityJobsTableAdapter.Fill(dbwrtcoordinatorDataSet.dtCityJobs);
            fillFilterCityJob();
            filterEquipByAssignedJob();
            filterEquipInventoryReport();
        }

        private void btnSaveCustom_Click(object sender, EventArgs e)
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();
                string update = "UPDATE tbcustomer SET cust_name = @name, cust_address = @address, cust_city = @city, cust_state = @state, cust_zip = @zip WHERE cust_id = @id";
                OleDbCommand cmdUpdate = new OleDbCommand(update, conn);
                cmdUpdate.Parameters.AddWithValue("@name", OleDbType.VarChar).Value = txtCustEditName.Text;
                cmdUpdate.Parameters.AddWithValue("@address", OleDbType.VarChar).Value = txtCustEditAddress.Text;
                cmdUpdate.Parameters.AddWithValue("@city", OleDbType.VarChar).Value = txtCustEditCity.Text;
                cmdUpdate.Parameters.AddWithValue("@state", OleDbType.VarChar).Value = txtCustEditState.Text;
                cmdUpdate.Parameters.AddWithValue("@zip", OleDbType.VarChar).Value = txtCustEditZip.Text;
                cmdUpdate.Parameters.AddWithValue("@id", OleDbType.Integer).Value = Convert.ToInt32(lstCustomers.SelectedValue);
                cmdUpdate.ExecuteNonQuery();
            }

            tbcustomerTableAdapter.Fill(dbwrtcoordinatorDataSet.tbcustomer);
            fillFilterCityJob();
            dtjobcustTableAdapter.Fill(dbwrtcoordinatorDataSet.dtjobcust);
        }

        private void txtSearchClaim_TextChanged(object sender, EventArgs e)
        {
            dtCustomerClaimBindingSource.Filter = string.Format("job_claim_number LIKE '{0}%' AND co_id = " + Convert.ToInt32(lstCompanies.SelectedValue) + "", txtSearchClaim.Text);
        }

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            tbcustomerBindingSource.Filter = string.Format("cust_name LIKE '{0}%' AND co_id = " + Convert.ToInt32(lstCompanies.SelectedValue) + "", txtSearchCustomer.Text);
        }

        private void lklblClaim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dtCustomerClaimTableAdapter.Fill(dbwrtcoordinatorDataSet.dtCustomerClaim);
            lstCustomers.DataSource = dtCustomerClaimBindingSource;
            lstCustomers.ValueMember = "cust_id";
            lstCustomers.DisplayMember = "cust_name";
            dtCustomerClaimBindingSource.Filter = "co_id = " + Convert.ToInt32(lstCompanies.SelectedValue) + "";
            dtCustomerClaimBindingSource.Sort = "cust_name ASC";
            lblCustFilter.Text = "Claim";
            lklblRelease.Visible = true;
            txtSearchClaim.Enabled = true;
            txtSearchCustomer.Clear();
            txtSearchCustomer.Enabled = false;
        }

        private void lklblName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lstCustomers.DataSource = tbcustomerBindingSource;
            lstCustomers.ValueMember = "cust_id";
            lstCustomers.DisplayMember = "cust_name";
            tbcustomerBindingSource.Filter = "co_id = " + Convert.ToInt32(lstCompanies.SelectedValue) + "";
            tbcustomerBindingSource.Sort = "cust_name ASC";
            lblCustFilter.Text = "Name";
            lklblRelease.Visible = true;
            txtSearchCustomer.Enabled = true;
            txtSearchClaim.Clear();
            txtSearchClaim.Enabled = false;
        }

        private void lklblRelease_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lstCustomers.DataSource = tbcustomerBindingSource;
            lstCustomers.ValueMember = "cust_id";
            lstCustomers.DisplayMember = "cust_name";
            tbcustomerBindingSource.Filter = "co_id = " + Convert.ToInt32(lstCompanies.SelectedValue) + "";
            tbcustomerBindingSource.Sort = "cust_name ASC";
            txtSearchClaim.Clear();
            txtSearchCustomer.Clear();
            txtSearchClaim.Enabled = false;
            txtSearchCustomer.Enabled = false;
            lklblRelease.Visible = false;
            lblCustFilter.Text = "";
        }

        private void lstCustomers_SelectedValueChanged(object sender, EventArgs e)
        {
            filterJobsByCustomer();
        }

        private void lstReportCustomer_SelectedValueChanged(object sender, EventArgs e)
        {
            filterEquipPickupReport();
        }

        private void lstCommSummEmp_SelectedValueChanged(object sender, EventArgs e)
        {
            filterEmpCommSummaryReport();
        }

        private void dtpCommSummFrom_ValueChanged(object sender, EventArgs e)
        {
            filterEmpCommSummaryReport();
        }

        private void dtpCommSummTo_ValueChanged(object sender, EventArgs e)
        {
            filterEmpCommSummaryReport();
        }

        private void lstCommDetailEmp_SelectedValueChanged(object sender, EventArgs e)
        {
            filterEmpCommDetailReport();
        }

        private void lstCommDetailJobs_SelectedValueChanged(object sender, EventArgs e)
        {
            filterEmpCommDetailReport();
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            filterEmployeeInformation();
        }

        private void txtInitialWage_TextChanged(object sender, EventArgs e)
        {
            updateTotalPay(lblCommLabor.Text, txtMultiLabor.Text, lblCommEquip.Text,
     txtMultiEquip.Text, lblCommMonitor.Text, txtMultiMonitor.Text, txtMultiComm.Text, txtHourlyWage.Text, lblHours.Text);
        }

        private void ckFilterbyIns_CheckedChanged(object sender, EventArgs e)
        {
            filterEmpCommSummaryReport();
        }

        private void lstCommIns_SelectedValueChanged(object sender, EventArgs e)
        {
            filterEmpCommSummaryReport();
        }
    }
}
