namespace QDRIVE___WRT_Coordinator
{
    partial class frmEditAssignedEquip
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dtEquipNameJobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbwrtcoordinatorDataSet = new QDRIVE___WRT_Coordinator.dbwrtcoordinatorDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDatePickedUp = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDateAssign = new System.Windows.Forms.DateTimePicker();
            this.btnAssign = new System.Windows.Forms.Button();
            this.txtAssign = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.tbequipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lstInventory = new System.Windows.Forms.ListBox();
            this.tbequipmentTableAdapter = new QDRIVE___WRT_Coordinator.dbwrtcoordinatorDataSetTableAdapters.tbequipmentTableAdapter();
            this.dtEquipNameJobTableAdapter = new QDRIVE___WRT_Coordinator.dbwrtcoordinatorDataSetTableAdapters.dtEquipNameJobTableAdapter();
            this.tbjobequipTableAdapter = new QDRIVE___WRT_Coordinator.dbwrtcoordinatorDataSetTableAdapters.tbjobequipTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEquipID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRemoveEquip = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAssignedCount = new System.Windows.Forms.Label();
            this.lstAssigned = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtEquipNameJobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbwrtcoordinatorDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbequipmentBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtEquipNameJobBindingSource
            // 
            this.dtEquipNameJobBindingSource.DataMember = "dtEquipNameJob";
            this.dtEquipNameJobBindingSource.DataSource = this.dbwrtcoordinatorDataSet;
            // 
            // dbwrtcoordinatorDataSet
            // 
            this.dbwrtcoordinatorDataSet.DataSetName = "dbwrtcoordinatorDataSet";
            this.dbwrtcoordinatorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtpDatePickedUp);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtpDateAssign);
            this.groupBox1.Controls.Add(this.btnAssign);
            this.groupBox1.Controls.Add(this.txtAssign);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblCount);
            this.groupBox1.Controls.Add(this.lstInventory);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 267);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Equipment Inventory";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(166, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Date Pickup:";
            // 
            // dtpDatePickedUp
            // 
            this.dtpDatePickedUp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatePickedUp.Location = new System.Drawing.Point(239, 130);
            this.dtpDatePickedUp.Name = "dtpDatePickedUp";
            this.dtpDatePickedUp.Size = new System.Drawing.Size(102, 20);
            this.dtpDatePickedUp.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(154, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Date Assigned:";
            // 
            // dtpDateAssign
            // 
            this.dtpDateAssign.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateAssign.Location = new System.Drawing.Point(239, 102);
            this.dtpDateAssign.Name = "dtpDateAssign";
            this.dtpDateAssign.Size = new System.Drawing.Size(102, 20);
            this.dtpDateAssign.TabIndex = 6;
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(157, 210);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(107, 39);
            this.btnAssign.TabIndex = 5;
            this.btnAssign.Text = "Assign Equipment";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // txtAssign
            // 
            this.txtAssign.Location = new System.Drawing.Point(240, 62);
            this.txtAssign.Name = "txtAssign";
            this.txtAssign.Size = new System.Drawing.Size(65, 20);
            this.txtAssign.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Assign:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventory on Hand:";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbequipmentBindingSource, "equip_stock_in", true));
            this.lblCount.Location = new System.Drawing.Point(264, 21);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(35, 13);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "label2";
            // 
            // tbequipmentBindingSource
            // 
            this.tbequipmentBindingSource.DataMember = "tbequipment";
            this.tbequipmentBindingSource.DataSource = this.dbwrtcoordinatorDataSet;
            // 
            // lstInventory
            // 
            this.lstInventory.DataSource = this.tbequipmentBindingSource;
            this.lstInventory.DisplayMember = "equip_name";
            this.lstInventory.FormattingEnabled = true;
            this.lstInventory.Location = new System.Drawing.Point(6, 21);
            this.lstInventory.Name = "lstInventory";
            this.lstInventory.Size = new System.Drawing.Size(142, 225);
            this.lstInventory.TabIndex = 0;
            this.lstInventory.ValueMember = "equip_id";
            // 
            // tbequipmentTableAdapter
            // 
            this.tbequipmentTableAdapter.ClearBeforeFill = true;
            // 
            // dtEquipNameJobTableAdapter
            // 
            this.dtEquipNameJobTableAdapter.ClearBeforeFill = true;
            // 
            // tbjobequipTableAdapter
            // 
            this.tbjobequipTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblEquipID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnRemoveEquip);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblAssignedCount);
            this.groupBox2.Controls.Add(this.lstAssigned);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblCustName);
            this.groupBox2.Location = new System.Drawing.Point(386, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 267);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Assign Equipment";
            // 
            // lblEquipID
            // 
            this.lblEquipID.AutoSize = true;
            this.lblEquipID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtEquipNameJobBindingSource, "equip_id", true));
            this.lblEquipID.Location = new System.Drawing.Point(271, 118);
            this.lblEquipID.Name = "lblEquipID";
            this.lblEquipID.Size = new System.Drawing.Size(35, 13);
            this.lblEquipID.TabIndex = 16;
            this.lblEquipID.Text = "label2";
            this.lblEquipID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Equipment ID:";
            // 
            // btnRemoveEquip
            // 
            this.btnRemoveEquip.Location = new System.Drawing.Point(162, 210);
            this.btnRemoveEquip.Name = "btnRemoveEquip";
            this.btnRemoveEquip.Size = new System.Drawing.Size(115, 39);
            this.btnRemoveEquip.TabIndex = 14;
            this.btnRemoveEquip.Text = "Remove Equipment";
            this.btnRemoveEquip.UseVisualStyleBackColor = true;
            this.btnRemoveEquip.Click += new System.EventHandler(this.btnRemoveEquip_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtEquipNameJobBindingSource, "jobequip_date_pickup", true));
            this.label13.Location = new System.Drawing.Point(271, 169);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "label2";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtEquipNameJobBindingSource, "jobequip_date_assign", true));
            this.label12.Location = new System.Drawing.Point(271, 141);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "label2";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(198, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Date Pickup:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(186, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Date Assigned:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Equipment Assigned:";
            // 
            // lblAssignedCount
            // 
            this.lblAssignedCount.AutoSize = true;
            this.lblAssignedCount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtEquipNameJobBindingSource, "jobequip_count", true));
            this.lblAssignedCount.Location = new System.Drawing.Point(271, 93);
            this.lblAssignedCount.Name = "lblAssignedCount";
            this.lblAssignedCount.Size = new System.Drawing.Size(35, 13);
            this.lblAssignedCount.TabIndex = 6;
            this.lblAssignedCount.Text = "label2";
            this.lblAssignedCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstAssigned
            // 
            this.lstAssigned.DataSource = this.dtEquipNameJobBindingSource;
            this.lstAssigned.DisplayMember = "equip_name";
            this.lstAssigned.FormattingEnabled = true;
            this.lstAssigned.Location = new System.Drawing.Point(6, 85);
            this.lstAssigned.Name = "lstAssigned";
            this.lstAssigned.Size = new System.Drawing.Size(142, 160);
            this.lstAssigned.TabIndex = 3;
            this.lstAssigned.ValueMember = "jobequip_id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer:";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(76, 45);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(35, 13);
            this.lblCustName.TabIndex = 4;
            this.lblCustName.Text = "label2";
            // 
            // frmEditAssignedEquip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 291);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEditAssignedEquip";
            this.Text = "frmEditAssignedEquip";
            this.Load += new System.EventHandler(this.frmEditAssignedEquip_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEditAssignEquip_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dtEquipNameJobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbwrtcoordinatorDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbequipmentBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpDatePickedUp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDateAssign;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.TextBox txtAssign;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.ListBox lstInventory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblEquipID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRemoveEquip;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAssignedCount;
        private System.Windows.Forms.ListBox lstAssigned;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblCustName;
        public dbwrtcoordinatorDataSet dbwrtcoordinatorDataSet;
        public System.Windows.Forms.BindingSource tbequipmentBindingSource;
        public dbwrtcoordinatorDataSetTableAdapters.tbequipmentTableAdapter tbequipmentTableAdapter;
        public System.Windows.Forms.BindingSource dtEquipNameJobBindingSource;
        public dbwrtcoordinatorDataSetTableAdapters.dtEquipNameJobTableAdapter dtEquipNameJobTableAdapter;
        public dbwrtcoordinatorDataSetTableAdapters.tbjobequipTableAdapter tbjobequipTableAdapter;
    }
}