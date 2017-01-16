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
    public partial class frmChangeEquip : Form
    {
        frmMain main = (frmMain)Application.OpenForms["frmMain"];
        public int coID;

        public frmChangeEquip()
        {
            InitializeComponent();
        }

        private void frmChangeEquip_Load(object sender, EventArgs e)
        {
            this.tbequipmentTableAdapter.Fill(this.dbwrtcoordinatorDataSet.tbequipment);
        }

        private void txtEditIn_TextChanged(object sender, EventArgs e)
        {
            lblEditStock.Text = FindStock(txtEditIn.Text, lblEditOut.Text);
        }

        private string FindStock(object inStock, object outStock)
        {
            int stock = 0;
            try
            {
                stock += Convert.ToInt32(inStock);
            }
            catch
            {
                stock += 0;
            }
            try
            {
                stock += Convert.ToInt32(outStock);
            }
            catch
            {
                stock += 0;
            }

            return stock.ToString();
        }

        private int getEquipId()
        {
            lblEquipId.Visible = true;
            int equipId = Convert.ToInt32(lblEquipId.Text);
            lblEquipId.Visible = false;
            return equipId;
        }

        private void btnSaveEquip_Click(object sender, EventArgs e)
        {
            Database.updateStatement("tbequipment", "equip_name", "equip_stock_in", "equip_id",
                txtEditEquipName.Text, Convert.ToInt32(txtEditIn.Text), getEquipId());

            this.tbequipmentTableAdapter.Fill(this.dbwrtcoordinatorDataSet.tbequipment);
            main.tbequipmentTableAdapter.Fill(main.dbwrtcoordinatorDataSet.tbequipment);
        }

        private void btnDeleteEquip_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove this equipment??", "QDRIVE - WRT Coordinator",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                List<string> list = Database.SelectStatementList("cust_name", "tbcustomer", "tbjob", "tbjobequip", "tbjob.job_id",
                    "tbjobequip.job_id", "tbcustomer.cust_id", "tbjob.cust_id", "tbjobequip.jobequip_status", "tbjobequip.equip_id",
                     0, getEquipId());

                if (list.Count > 0)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("Unable to remove this equipment. There is outstanding equipment of this type on the following job(s):\n\n");
                    foreach (string s in list)
                        sb.Append(s + "\n");

                    MessageBox.Show(sb.ToString(), "QDRIVE - WRT Coordinator", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Database.DeleteStatement("tbequipment", "equip_id", getEquipId());
                    this.tbequipmentTableAdapter.Fill(this.dbwrtcoordinatorDataSet.tbequipment);
                    main.tbequipmentTableAdapter.Fill(main.dbwrtcoordinatorDataSet.tbequipment);
                }
            }
        }

        private void btnAddEquip_Click(object sender, EventArgs e)
        {
            try
            {
                Database.insertStatement("tbequipment", "equip_name", "co_id", "equip_stock_in", "equip_stock_out", txtNewEquipName.Text,
                    coID, Convert.ToInt32(txtNewStock.Text), 0);
            }
            catch(Exception ex)
            {
                Database.MessageBoxError(ex);
            }
            this.tbequipmentTableAdapter.Fill(this.dbwrtcoordinatorDataSet.tbequipment);
            main.tbequipmentTableAdapter.Fill(main.dbwrtcoordinatorDataSet.tbequipment);
        }
    }
}
