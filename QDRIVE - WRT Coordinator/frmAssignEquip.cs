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
    public partial class frmAssignEquip : Form
    {
        public frmAssignEquip()
        {
            InitializeComponent();
        }

        frmMain main = (frmMain)Application.OpenForms["frmMain"];

        private void frmAssignEquip_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbwrtcoordinatorDataSet.dtEquipNameJob' table. You can move, or remove it, as needed.
            this.dtEquipNameJobTableAdapter.Fill(this.dbwrtcoordinatorDataSet.dtEquipNameJob);
            // TODO: This line of code loads data into the 'dbwrtcoordinatorDataSet.tbequipment' table. You can move, or remove it, as needed.
            this.tbequipmentTableAdapter.Fill(this.dbwrtcoordinatorDataSet.tbequipment);
            tbequipmentBindingSource.Filter = "co_id = " + Convert.ToInt32(main.lstCompanies.SelectedValue) + "";
            dtEquipNameJobBindingSource.Filter = "job_id = " + Convert.ToInt32(main.lblScopedJobID.Text) + "";
            main.lblScopedJobID.Visible = false;
            txtAssign.Focus();
        }

        private void frmAssignEquip_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.Enabled = true;
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            //insert record into tbjobequip
            DateTime jobAssign = Convert.ToDateTime(dtpDateAssign.Text);
            DateTime jobPickUp = Convert.ToDateTime(dtpDatePickedUp.Text);
            int count = Convert.ToInt32(txtAssign.Text);
            int status = 0;
            int jobID = Convert.ToInt32(lblJobID.Text);
            int equipID = Convert.ToInt32(lstInventory.SelectedValue);

            tbjobequipTableAdapter.Insert(jobAssign, jobPickUp, count, status, jobID, equipID);
            tbjobequipTableAdapter.Fill(main.dbwrtcoordinatorDataSet.tbjobequip);
            //tbjobequipTableAdapter.Fill(dbwrtcoordinatorDataSet.tbjobequip);
            dtEquipNameJobTableAdapter.Fill(dbwrtcoordinatorDataSet.dtEquipNameJob);


            //update inventory count

            using (OleDbConnection conn = new OleDbConnection(main.connString))
            {
                conn.Open();
                //get stock in amount
                string getStockIn = "SELECT equip_stock_in FROM tbequipment WHERE equip_id = @id";
                OleDbCommand cmdGetStockIn = new OleDbCommand(getStockIn, conn);
                cmdGetStockIn.Parameters.AddWithValue("@id", OleDbType.Integer).Value = equipID;
                int stockIn = Convert.ToInt32(cmdGetStockIn.ExecuteScalar());

                //get stock out amount
                string getStockOut = "SELECT equip_stock_out FROM tbequipment WHERE equip_id = @id";
                OleDbCommand cmdGetStockOut = new OleDbCommand(getStockOut, conn);
                cmdGetStockOut.Parameters.AddWithValue("@id", OleDbType.Integer).Value = equipID;
                int stockOut = Convert.ToInt32(cmdGetStockOut.ExecuteScalar());

                //update stockin and stockout values
                string updateCount = "UPDATE tbequipment SET equip_stock_out = @out, equip_stock_in = @in WHERE equip_id = @id";
                int stockOutNew = stockOut + Convert.ToInt32(txtAssign.Text);
                int stockInNew = stockIn - Convert.ToInt32(txtAssign.Text);
                OleDbCommand cmdCount = new OleDbCommand(updateCount, conn);
                cmdCount.Parameters.AddWithValue("@out", OleDbType.Integer).Value = stockOutNew;
                cmdCount.Parameters.AddWithValue("@in", OleDbType.Integer).Value = stockInNew;
                cmdCount.Parameters.AddWithValue("@id", OleDbType.Integer).Value = equipID;
                cmdCount.ExecuteNonQuery();
            }

            tbequipmentTableAdapter.Fill(main.dbwrtcoordinatorDataSet.tbequipment);
            tbequipmentTableAdapter.Fill(dbwrtcoordinatorDataSet.tbequipment);
            main.filterEquipInventoryReport();

            //change customer status
            string updateCustStatus = "UPDATE tbjob SET job_status = @status WHERE job_id = @id";
            using (OleDbConnection conn = new OleDbConnection(main.connString))
            {
                conn.Open();
                OleDbCommand cmdUpdate = new OleDbCommand(updateCustStatus, conn);
                cmdUpdate.Parameters.AddWithValue("@status", OleDbType.VarChar).Value = "Equipment Assigned";
                cmdUpdate.Parameters.AddWithValue("@id", OleDbType.Integer).Value = jobID;
                cmdUpdate.ExecuteNonQuery();
            }

            main.tbjobTableAdapter.Fill(main.dbwrtcoordinatorDataSet.tbjob);
            main.dtjobcustTableAdapter.Fill(main.dbwrtcoordinatorDataSet.dtjobcust);
            main.dtCityJobsTableAdapter.Fill(main.dbwrtcoordinatorDataSet.dtCityJobs);
            main.fillFilterCityJob();

            txtAssign.Clear();
            txtAssign.Focus();

        }
    }
}
