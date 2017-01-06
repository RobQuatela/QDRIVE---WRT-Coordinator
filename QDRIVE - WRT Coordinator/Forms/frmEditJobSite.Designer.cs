namespace QDRIVE___WRT_Coordinator
{
    partial class frmEditJobSite
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
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.lblPayStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ckJobSiteEnd = new System.Windows.Forms.CheckBox();
            this.dtpJobEnd = new System.Windows.Forms.DateTimePicker();
            this.cbJobSiteStatus = new System.Windows.Forms.ComboBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstEmployees = new System.Windows.Forms.ListBox();
            this.tbemployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbwrtcoordinatorDataSet = new QDRIVE___WRT_Coordinator.dbwrtcoordinatorDataSet();
            this.btnJobSiteEdit = new System.Windows.Forms.Button();
            this.dtpJobStart = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblJobSiteCustomer = new System.Windows.Forms.Label();
            this.lstJobSiteEmployee = new System.Windows.Forms.ListBox();
            this.dtempnamejobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label50 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.tbemployeeTableAdapter = new QDRIVE___WRT_Coordinator.dbwrtcoordinatorDataSetTableAdapters.tbemployeeTableAdapter();
            this.dtempnamejobTableAdapter = new QDRIVE___WRT_Coordinator.dbwrtcoordinatorDataSetTableAdapters.dtempnamejobTableAdapter();
            this.tbempjobTableAdapter = new QDRIVE___WRT_Coordinator.dbwrtcoordinatorDataSetTableAdapters.tbempjobTableAdapter();
            this.groupBox20.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbemployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbwrtcoordinatorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtempnamejobBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.lblPayStatus);
            this.groupBox20.Controls.Add(this.label1);
            this.groupBox20.Controls.Add(this.ckJobSiteEnd);
            this.groupBox20.Controls.Add(this.dtpJobEnd);
            this.groupBox20.Controls.Add(this.cbJobSiteStatus);
            this.groupBox20.Controls.Add(this.btnRemove);
            this.groupBox20.Controls.Add(this.groupBox3);
            this.groupBox20.Controls.Add(this.btnJobSiteEdit);
            this.groupBox20.Controls.Add(this.dtpJobStart);
            this.groupBox20.Controls.Add(this.btnAdd);
            this.groupBox20.Controls.Add(this.lblJobSiteCustomer);
            this.groupBox20.Controls.Add(this.lstJobSiteEmployee);
            this.groupBox20.Controls.Add(this.label50);
            this.groupBox20.Controls.Add(this.label49);
            this.groupBox20.Controls.Add(this.label48);
            this.groupBox20.Controls.Add(this.label47);
            this.groupBox20.Controls.Add(this.label45);
            this.groupBox20.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox20.Location = new System.Drawing.Point(14, 12);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(613, 363);
            this.groupBox20.TabIndex = 5;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Job Site Details";
            // 
            // lblPayStatus
            // 
            this.lblPayStatus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayStatus.Location = new System.Drawing.Point(423, 257);
            this.lblPayStatus.Name = "lblPayStatus";
            this.lblPayStatus.Size = new System.Drawing.Size(121, 22);
            this.lblPayStatus.TabIndex = 44;
            this.lblPayStatus.Text = "label51";
            this.lblPayStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Pay Status:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ckJobSiteEnd
            // 
            this.ckJobSiteEnd.AutoSize = true;
            this.ckJobSiteEnd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckJobSiteEnd.Location = new System.Drawing.Point(423, 115);
            this.ckJobSiteEnd.Name = "ckJobSiteEnd";
            this.ckJobSiteEnd.Size = new System.Drawing.Size(182, 20);
            this.ckJobSiteEnd.TabIndex = 42;
            this.ckJobSiteEnd.Text = "I know the completion date";
            this.ckJobSiteEnd.UseVisualStyleBackColor = true;
            this.ckJobSiteEnd.CheckedChanged += new System.EventHandler(this.ckJobSiteEnd_CheckedChanged);
            // 
            // dtpJobEnd
            // 
            this.dtpJobEnd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpJobEnd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpJobEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpJobEnd.Location = new System.Drawing.Point(423, 111);
            this.dtpJobEnd.Name = "dtpJobEnd";
            this.dtpJobEnd.Size = new System.Drawing.Size(103, 22);
            this.dtpJobEnd.TabIndex = 41;
            // 
            // cbJobSiteStatus
            // 
            this.cbJobSiteStatus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJobSiteStatus.FormattingEnabled = true;
            this.cbJobSiteStatus.Items.AddRange(new object[] {
            "Scoped",
            "Equipment Assigned",
            "Equipment Picked Up",
            "Complete: Pending Total",
            "Complete: Pending Commission",
            "Closed"});
            this.cbJobSiteStatus.Location = new System.Drawing.Point(423, 52);
            this.cbJobSiteStatus.Name = "cbJobSiteStatus";
            this.cbJobSiteStatus.Size = new System.Drawing.Size(164, 24);
            this.cbJobSiteStatus.TabIndex = 40;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRemove.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(202, 228);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(145, 28);
            this.btnRemove.TabIndex = 39;
            this.btnRemove.Text = "<< Remove Selected";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstEmployees);
            this.groupBox3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(15, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(170, 245);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Assign Employees";
            // 
            // lstEmployees
            // 
            this.lstEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstEmployees.DataSource = this.tbemployeeBindingSource;
            this.lstEmployees.DisplayMember = "emp_name";
            this.lstEmployees.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEmployees.FormattingEnabled = true;
            this.lstEmployees.ItemHeight = 16;
            this.lstEmployees.Location = new System.Drawing.Point(6, 27);
            this.lstEmployees.Name = "lstEmployees";
            this.lstEmployees.Size = new System.Drawing.Size(157, 212);
            this.lstEmployees.TabIndex = 34;
            this.lstEmployees.ValueMember = "emp_id";
            // 
            // tbemployeeBindingSource
            // 
            this.tbemployeeBindingSource.DataMember = "tbemployee";
            this.tbemployeeBindingSource.DataSource = this.dbwrtcoordinatorDataSet;
            // 
            // dbwrtcoordinatorDataSet
            // 
            this.dbwrtcoordinatorDataSet.DataSetName = "dbwrtcoordinatorDataSet";
            this.dbwrtcoordinatorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnJobSiteEdit
            // 
            this.btnJobSiteEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnJobSiteEdit.BackColor = System.Drawing.Color.White;
            this.btnJobSiteEdit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJobSiteEdit.Location = new System.Drawing.Point(240, 324);
            this.btnJobSiteEdit.Name = "btnJobSiteEdit";
            this.btnJobSiteEdit.Size = new System.Drawing.Size(119, 33);
            this.btnJobSiteEdit.TabIndex = 14;
            this.btnJobSiteEdit.Text = "Save && Close";
            this.btnJobSiteEdit.UseVisualStyleBackColor = false;
            this.btnJobSiteEdit.Click += new System.EventHandler(this.btnJobSiteEdit_Click);
            // 
            // dtpJobStart
            // 
            this.dtpJobStart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpJobStart.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpJobStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpJobStart.Location = new System.Drawing.Point(423, 80);
            this.dtpJobStart.Name = "dtpJobStart";
            this.dtpJobStart.Size = new System.Drawing.Size(103, 22);
            this.dtpJobStart.TabIndex = 29;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(202, 192);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 28);
            this.btnAdd.TabIndex = 38;
            this.btnAdd.Text = "Add Selected >>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblJobSiteCustomer
            // 
            this.lblJobSiteCustomer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobSiteCustomer.Location = new System.Drawing.Point(423, 17);
            this.lblJobSiteCustomer.Name = "lblJobSiteCustomer";
            this.lblJobSiteCustomer.Size = new System.Drawing.Size(121, 22);
            this.lblJobSiteCustomer.TabIndex = 9;
            this.lblJobSiteCustomer.Text = "label51";
            this.lblJobSiteCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstJobSiteEmployee
            // 
            this.lstJobSiteEmployee.DataSource = this.dtempnamejobBindingSource;
            this.lstJobSiteEmployee.DisplayMember = "emp_name";
            this.lstJobSiteEmployee.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstJobSiteEmployee.FormattingEnabled = true;
            this.lstJobSiteEmployee.ItemHeight = 16;
            this.lstJobSiteEmployee.Location = new System.Drawing.Point(426, 152);
            this.lstJobSiteEmployee.Name = "lstJobSiteEmployee";
            this.lstJobSiteEmployee.Size = new System.Drawing.Size(161, 100);
            this.lstJobSiteEmployee.TabIndex = 5;
            this.lstJobSiteEmployee.ValueMember = "empjob_id";
            this.lstJobSiteEmployee.SelectedValueChanged += new System.EventHandler(this.lstJobSiteEmployee_SelectedValueChanged);
            // 
            // dtempnamejobBindingSource
            // 
            this.dtempnamejobBindingSource.DataMember = "dtempnamejob";
            this.dtempnamejobBindingSource.DataSource = this.dbwrtcoordinatorDataSet;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(340, 152);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(77, 16);
            this.label50.TabIndex = 4;
            this.label50.Text = "Employees:";
            this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(319, 116);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(98, 16);
            this.label49.TabIndex = 3;
            this.label49.Text = "Date Complete:";
            this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(346, 85);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(71, 16);
            this.label48.TabIndex = 2;
            this.label48.Text = "Date Start:";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(367, 55);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(50, 16);
            this.label47.TabIndex = 1;
            this.label47.Text = "Status:";
            this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(349, 20);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(68, 16);
            this.label45.TabIndex = 0;
            this.label45.Text = "Customer:";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbemployeeTableAdapter
            // 
            this.tbemployeeTableAdapter.ClearBeforeFill = true;
            // 
            // dtempnamejobTableAdapter
            // 
            this.dtempnamejobTableAdapter.ClearBeforeFill = true;
            // 
            // tbempjobTableAdapter
            // 
            this.tbempjobTableAdapter.ClearBeforeFill = true;
            // 
            // frmEditJobSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 389);
            this.Controls.Add(this.groupBox20);
            this.Name = "frmEditJobSite";
            this.Text = "frmEditJobSite";
            this.Load += new System.EventHandler(this.frmEditJobSite_Load);
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbemployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbwrtcoordinatorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtempnamejobBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.Button btnJobSiteEdit;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstEmployees;
        private System.Windows.Forms.Button btnAdd;
        private dbwrtcoordinatorDataSet dbwrtcoordinatorDataSet;
        private System.Windows.Forms.BindingSource tbemployeeBindingSource;
        private dbwrtcoordinatorDataSetTableAdapters.tbemployeeTableAdapter tbemployeeTableAdapter;
        public System.Windows.Forms.Label lblJobSiteCustomer;
        public System.Windows.Forms.ListBox lstJobSiteEmployee;
        public System.Windows.Forms.ComboBox cbJobSiteStatus;
        public System.Windows.Forms.DateTimePicker dtpJobStart;
        public System.Windows.Forms.DateTimePicker dtpJobEnd;
        public System.Windows.Forms.CheckBox ckJobSiteEnd;
        private System.Windows.Forms.BindingSource dtempnamejobBindingSource;
        private dbwrtcoordinatorDataSetTableAdapters.dtempnamejobTableAdapter dtempnamejobTableAdapter;
        public System.Windows.Forms.Label lblPayStatus;
        private System.Windows.Forms.Label label1;
        private dbwrtcoordinatorDataSetTableAdapters.tbempjobTableAdapter tbempjobTableAdapter;
    }
}