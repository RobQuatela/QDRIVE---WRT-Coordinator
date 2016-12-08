namespace QDRIVE___WRT_Coordinator
{
    partial class frmAssignEquip
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
            this.lstInventory = new System.Windows.Forms.ListBox();
            this.tbequipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbwrtcoordinatorDataSet = new QDRIVE___WRT_Coordinator.dbwrtcoordinatorDataSet();
            this.tbequipmentTableAdapter = new QDRIVE___WRT_Coordinator.dbwrtcoordinatorDataSetTableAdapters.tbequipmentTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDatePickedUp = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDateAssign = new System.Windows.Forms.DateTimePicker();
            this.btnAssign = new System.Windows.Forms.Button();
            this.txtAssign = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtEquipNameJobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblJobID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstAssigned = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.dtEquipNameJobTableAdapter = new QDRIVE___WRT_Coordinator.dbwrtcoordinatorDataSetTableAdapters.dtEquipNameJobTableAdapter();
            this.tbjobequipTableAdapter = new QDRIVE___WRT_Coordinator.dbwrtcoordinatorDataSetTableAdapters.tbjobequipTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbequipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbwrtcoordinatorDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtEquipNameJobBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lstInventory
            // 
            this.lstInventory.DataSource = this.tbequipmentBindingSource;
            this.lstInventory.DisplayMember = "equip_name";
            this.lstInventory.FormattingEnabled = true;
            this.lstInventory.ItemHeight = 16;
            this.lstInventory.Location = new System.Drawing.Point(6, 21);
            this.lstInventory.Name = "lstInventory";
            this.lstInventory.Size = new System.Drawing.Size(142, 212);
            this.lstInventory.TabIndex = 0;
            this.lstInventory.ValueMember = "equip_id";
            // 
            // tbequipmentBindingSource
            // 
            this.tbequipmentBindingSource.DataMember = "tbequipment";
            this.tbequipmentBindingSource.DataSource = this.dbwrtcoordinatorDataSet;
            // 
            // dbwrtcoordinatorDataSet
            // 
            this.dbwrtcoordinatorDataSet.DataSetName = "dbwrtcoordinatorDataSet";
            this.dbwrtcoordinatorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbequipmentTableAdapter
            // 
            this.tbequipmentTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventory on Hand:";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbequipmentBindingSource, "equip_stock_in", true));
            this.lblCount.Location = new System.Drawing.Point(264, 21);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(36, 16);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "label2";
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
            this.groupBox1.Size = new System.Drawing.Size(368, 245);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Equipment Inventory";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(166, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Date Pickup:";
            // 
            // dtpDatePickedUp
            // 
            this.dtpDatePickedUp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatePickedUp.Location = new System.Drawing.Point(239, 130);
            this.dtpDatePickedUp.Name = "dtpDatePickedUp";
            this.dtpDatePickedUp.Size = new System.Drawing.Size(102, 22);
            this.dtpDatePickedUp.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(154, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Date Assigned:";
            // 
            // dtpDateAssign
            // 
            this.dtpDateAssign.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateAssign.Location = new System.Drawing.Point(239, 102);
            this.dtpDateAssign.Name = "dtpDateAssign";
            this.dtpDateAssign.Size = new System.Drawing.Size(102, 22);
            this.dtpDateAssign.TabIndex = 6;
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(161, 194);
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
            this.txtAssign.Size = new System.Drawing.Size(65, 22);
            this.txtAssign.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Assign:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lblJobID);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lstAssigned);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblCustName);
            this.groupBox2.Location = new System.Drawing.Point(386, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 245);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Assign Equipment";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtEquipNameJobBindingSource, "jobequip_date_pickup", true));
            this.label13.Location = new System.Drawing.Point(271, 163);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 16);
            this.label13.TabIndex = 13;
            this.label13.Text = "label2";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtEquipNameJobBindingSource
            // 
            this.dtEquipNameJobBindingSource.DataMember = "dtEquipNameJob";
            this.dtEquipNameJobBindingSource.DataSource = this.dbwrtcoordinatorDataSet;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtEquipNameJobBindingSource, "jobequip_date_assign", true));
            this.label12.Location = new System.Drawing.Point(271, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "label2";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(198, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Date Pickup:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Job ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(186, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Date Assigned:";
            // 
            // lblJobID
            // 
            this.lblJobID.AutoSize = true;
            this.lblJobID.Location = new System.Drawing.Point(73, 34);
            this.lblJobID.Name = "lblJobID";
            this.lblJobID.Size = new System.Drawing.Size(36, 16);
            this.lblJobID.TabIndex = 8;
            this.lblJobID.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Inventory Assigned:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtEquipNameJobBindingSource, "jobequip_count", true));
            this.label5.Location = new System.Drawing.Point(271, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "label2";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstAssigned
            // 
            this.lstAssigned.DataSource = this.dtEquipNameJobBindingSource;
            this.lstAssigned.DisplayMember = "equip_name";
            this.lstAssigned.FormattingEnabled = true;
            this.lstAssigned.ItemHeight = 16;
            this.lstAssigned.Location = new System.Drawing.Point(15, 101);
            this.lstAssigned.Name = "lstAssigned";
            this.lstAssigned.Size = new System.Drawing.Size(142, 132);
            this.lstAssigned.TabIndex = 3;
            this.lstAssigned.ValueMember = "jobequip_id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer:";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(73, 62);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(36, 16);
            this.lblCustName.TabIndex = 4;
            this.lblCustName.Text = "label2";
            // 
            // dtEquipNameJobTableAdapter
            // 
            this.dtEquipNameJobTableAdapter.ClearBeforeFill = true;
            // 
            // tbjobequipTableAdapter
            // 
            this.tbjobequipTableAdapter.ClearBeforeFill = true;
            // 
            // frmAssignEquip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 276);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAssignEquip";
            this.Text = "Assign Equipment";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAssignEquip_FormClosed);
            this.Load += new System.EventHandler(this.frmAssignEquip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbequipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbwrtcoordinatorDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtEquipNameJobBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstInventory;
        private dbwrtcoordinatorDataSet dbwrtcoordinatorDataSet;
        private dbwrtcoordinatorDataSetTableAdapters.tbequipmentTableAdapter tbequipmentTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCount;
        public System.Windows.Forms.BindingSource tbequipmentBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstAssigned;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.TextBox txtAssign;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpDatePickedUp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDateAssign;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label lblCustName;
        public System.Windows.Forms.Label lblJobID;
        private System.Windows.Forms.BindingSource dtEquipNameJobBindingSource;
        private dbwrtcoordinatorDataSetTableAdapters.dtEquipNameJobTableAdapter dtEquipNameJobTableAdapter;
        private dbwrtcoordinatorDataSetTableAdapters.tbjobequipTableAdapter tbjobequipTableAdapter;
    }
}