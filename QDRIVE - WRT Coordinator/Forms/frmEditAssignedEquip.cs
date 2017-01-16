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
    public partial class frmEditAssignedEquip : Form
    {
        public frmEditAssignedEquip()
        {
            InitializeComponent();
        }

        frmMain main = (frmMain)Application.OpenForms["frmMain"];
        public int jobId;

        private void frmEditAssignedEquip_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbwrtcoordinatorDataSet.dtEquipNameJob' table. You can move, or remove it, as needed.
            this.dtEquipNameJobTableAdapter.Fill(this.dbwrtcoordinatorDataSet.dtEquipNameJob);
            // TODO: This line of code loads data into the 'dbwrtcoordinatorDataSet.tbequipment' table. You can move, or remove it, as needed.
            this.tbequipmentTableAdapter.Fill(this.dbwrtcoordinatorDataSet.tbequipment);
            string equipmentFilter = String.Format("co_id = {0}", Convert.ToInt32(main.lstCompanies.SelectedValue));
            string equipNameJobFilter = String.Format("job_id = {0}", jobId);
            tbequipmentBindingSource.Filter = equipmentFilter;
            dtEquipNameJobBindingSource.Filter = equipNameJobFilter;

            txtAssign.Focus();
        }

        private void frmEditAssignEquip_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.Enabled = true;

            //change customer status
            if (Database.SelectStatementList("job_id", "tbjobequip", "job_id", jobId).Count == 0)
                Database.updateStatement("tbjob", "job_status", "job_id", "Scoped", jobId);
            else
                Database.updateStatement("tbjob", "job_status", "job_id", "Equipment Assigned", jobId);

            main.tbjobTableAdapter.Fill(main.dbwrtcoordinatorDataSet.tbjob);
            main.dtjobcustTableAdapter.Fill(main.dbwrtcoordinatorDataSet.dtjobcust);
            main.dtCityJobsTableAdapter.Fill(main.dbwrtcoordinatorDataSet.dtCityJobs);
            main.fillFilterCityJob();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            //insert record into tbjobequip
            DateTime jobAssign = Convert.ToDateTime(dtpDateAssign.Text);
            DateTime jobPickUp = Convert.ToDateTime(dtpDatePickedUp.Text);
            int count = Convert.ToInt32(txtAssign.Text);
            int status = 0;
            int equipID = Convert.ToInt32(lstInventory.SelectedValue);

            if (count < Database.SelectStatementInt("equip_stock_in", "tbequipment", "equip_id", equipID))
            {
                tbjobequipTableAdapter.Insert(jobAssign, jobPickUp, count, status, jobId, equipID);

                tbjobequipTableAdapter.Fill(main.dbwrtcoordinatorDataSet.tbjobequip);
                //tbjobequipTableAdapter.Fill(dbwrtcoordinatorDataSet.tbjobequip);
                dtEquipNameJobTableAdapter.Fill(dbwrtcoordinatorDataSet.dtEquipNameJob);


                //update inventory count
                int stockIn = Database.SelectStatementInt("equip_stock_in", "tbequipment", "equip_id", equipID);
                int stockOut = Database.SelectStatementInt("equip_stock_out", "tbequipment", "equip_id", equipID);

                //update stockin and stockout values
                int stockOutNew = stockOut + Convert.ToInt32(txtAssign.Text);
                int stockInNew = stockIn - Convert.ToInt32(txtAssign.Text);

                Database.updateStatement("tbequipment", "equip_stock_out", "equip_stock_in", "equip_id", stockOutNew, stockInNew, equipID);

                tbequipmentTableAdapter.Fill(main.dbwrtcoordinatorDataSet.tbequipment);
                tbequipmentTableAdapter.Fill(dbwrtcoordinatorDataSet.tbequipment);
                main.filterEquipInventoryReport();

                txtAssign.Clear();
                txtAssign.Focus();
            }
            else
            {
                MessageBox.Show("Assignment cannot exceed equipment in stock", "QDRIVE - WRT Coordinator", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAssign.Clear();
                txtAssign.Focus();
            }
        }

        private void btnRemoveEquip_Click(object sender, EventArgs e)
        {
            if (Database.SelectStatementList("job_id", "tbjobequip", "job_id", jobId).Count > 0)
            {
                int equipID = Convert.ToInt32(lblEquipID.Text);
                Database.DeleteStatement("tbjobequip", "jobequip_id", Convert.ToInt32(lstAssigned.SelectedValue));

                //update inventory count
                int stockIn = Database.SelectStatementInt("equip_stock_in", "tbequipment", "equip_id", equipID);
                int stockOut = Database.SelectStatementInt("equip_stock_out", "tbequipment", "equip_id", equipID);

                //update stockin and stockout values
                int stockOutNew = stockOut - Convert.ToInt32(lblAssignedCount.Text);
                int stockInNew = stockIn + Convert.ToInt32(lblAssignedCount.Text);

                Database.updateStatement("tbequipment", "equip_stock_out", "equip_stock_in", "equip_id", stockOutNew, stockInNew, equipID);

                tbequipmentTableAdapter.Fill(main.dbwrtcoordinatorDataSet.tbequipment);
                tbequipmentTableAdapter.Fill(dbwrtcoordinatorDataSet.tbequipment);
                dtEquipNameJobTableAdapter.Fill(dbwrtcoordinatorDataSet.dtEquipNameJob);
                main.filterEquipInventoryReport();
            }
            else
                MessageBox.Show("test");
        }
    }
}
