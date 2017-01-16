namespace QDRIVE___WRT_Coordinator
{
    partial class frmJobSiteWizard
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
            this.pnlCustomerAdd = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCustID = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.txtClaimNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstCustomer = new System.Windows.Forms.ListBox();
            this.tbcustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbwrtcoordinatorDataSet = new QDRIVE___WRT_Coordinator.dbwrtcoordinatorDataSet();
            this.cbAddInsurance = new System.Windows.Forms.ComboBox();
            this.tbinsuranceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label42 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlJob = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstEmployees = new System.Windows.Forms.ListBox();
            this.tbemployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lstAssignedEmployees = new System.Windows.Forms.ListBox();
            this.dtpJobStart = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.tbjobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnAddJobSite = new System.Windows.Forms.Button();
            this.tbemployeeTableAdapter = new QDRIVE___WRT_Coordinator.dbwrtcoordinatorDataSetTableAdapters.tbemployeeTableAdapter();
            this.tbinsuranceTableAdapter = new QDRIVE___WRT_Coordinator.dbwrtcoordinatorDataSetTableAdapters.tbinsuranceTableAdapter();
            this.tbcustomerTableAdapter = new QDRIVE___WRT_Coordinator.dbwrtcoordinatorDataSetTableAdapters.tbcustomerTableAdapter();
            this.tbjobTableAdapter = new QDRIVE___WRT_Coordinator.dbwrtcoordinatorDataSetTableAdapters.tbjobTableAdapter();
            this.pnlCustomerAdd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbcustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbwrtcoordinatorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbinsuranceBindingSource)).BeginInit();
            this.pnlJob.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbemployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbjobBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCustomerAdd
            // 
            this.pnlCustomerAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCustomerAdd.BackColor = System.Drawing.Color.White;
            this.pnlCustomerAdd.Controls.Add(this.groupBox1);
            this.pnlCustomerAdd.Location = new System.Drawing.Point(4, 2);
            this.pnlCustomerAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlCustomerAdd.Name = "pnlCustomerAdd";
            this.pnlCustomerAdd.Size = new System.Drawing.Size(539, 295);
            this.pnlCustomerAdd.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblCustID);
            this.groupBox1.Controls.Add(this.lblCustomer);
            this.groupBox1.Controls.Add(this.txtSearchCustomer);
            this.groupBox1.Controls.Add(this.txtClaimNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lstCustomer);
            this.groupBox1.Controls.Add(this.cbAddInsurance);
            this.groupBox1.Controls.Add(this.label42);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(519, 291);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Location = new System.Drawing.Point(26, 95);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(46, 20);
            this.lblCustID.TabIndex = 35;
            this.lblCustID.Text = "label3";
            this.lblCustID.Visible = false;
            // 
            // lblCustomer
            // 
            this.lblCustomer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(114, 53);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(151, 25);
            this.lblCustomer.TabIndex = 34;
            this.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCustomer.Visible = false;
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCustomer.Location = new System.Drawing.Point(114, 26);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(151, 22);
            this.txtSearchCustomer.TabIndex = 33;
            this.txtSearchCustomer.Text = "Search Customers";
            this.txtSearchCustomer.Click += new System.EventHandler(this.txtSearchCustomer_Click);
            this.txtSearchCustomer.CursorChanged += new System.EventHandler(this.txtSearchCustomer_CursorChanged);
            this.txtSearchCustomer.TextChanged += new System.EventHandler(this.txtSearchCustomer_TextChanged);
            // 
            // txtClaimNo
            // 
            this.txtClaimNo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaimNo.Location = new System.Drawing.Point(114, 233);
            this.txtClaimNo.Name = "txtClaimNo";
            this.txtClaimNo.Size = new System.Drawing.Size(135, 22);
            this.txtClaimNo.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Claim No:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lstCustomer
            // 
            this.lstCustomer.DataSource = this.tbcustomerBindingSource;
            this.lstCustomer.DisplayMember = "cust_name";
            this.lstCustomer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCustomer.FormattingEnabled = true;
            this.lstCustomer.ItemHeight = 16;
            this.lstCustomer.Location = new System.Drawing.Point(114, 57);
            this.lstCustomer.Name = "lstCustomer";
            this.lstCustomer.Size = new System.Drawing.Size(151, 116);
            this.lstCustomer.TabIndex = 29;
            this.lstCustomer.ValueMember = "cust_id";
            // 
            // tbcustomerBindingSource
            // 
            this.tbcustomerBindingSource.DataMember = "tbcustomer";
            this.tbcustomerBindingSource.DataSource = this.dbwrtcoordinatorDataSet;
            // 
            // dbwrtcoordinatorDataSet
            // 
            this.dbwrtcoordinatorDataSet.DataSetName = "dbwrtcoordinatorDataSet";
            this.dbwrtcoordinatorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbAddInsurance
            // 
            this.cbAddInsurance.DataSource = this.tbinsuranceBindingSource;
            this.cbAddInsurance.DisplayMember = "ins_name";
            this.cbAddInsurance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAddInsurance.FormattingEnabled = true;
            this.cbAddInsurance.Location = new System.Drawing.Point(114, 185);
            this.cbAddInsurance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbAddInsurance.Name = "cbAddInsurance";
            this.cbAddInsurance.Size = new System.Drawing.Size(135, 24);
            this.cbAddInsurance.TabIndex = 27;
            this.cbAddInsurance.ValueMember = "ins_id";
            // 
            // tbinsuranceBindingSource
            // 
            this.tbinsuranceBindingSource.DataMember = "tbinsurance";
            this.tbinsuranceBindingSource.DataSource = this.dbwrtcoordinatorDataSet;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(40, 189);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(68, 16);
            this.label42.TabIndex = 26;
            this.label42.Text = "Insurance:";
            this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Customer:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlJob
            // 
            this.pnlJob.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlJob.BackColor = System.Drawing.Color.White;
            this.pnlJob.Controls.Add(this.groupBox2);
            this.pnlJob.Location = new System.Drawing.Point(4, 2);
            this.pnlJob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlJob.Name = "pnlJob";
            this.pnlJob.Size = new System.Drawing.Size(545, 295);
            this.pnlJob.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lstAssignedEmployees);
            this.groupBox2.Controls.Add(this.dtpJobStart);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(525, 291);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Job Information";
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRemove.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(182, 105);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(145, 28);
            this.btnRemove.TabIndex = 39;
            this.btnRemove.Text = "<< Remove Selected";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(182, 70);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 28);
            this.btnAdd.TabIndex = 38;
            this.btnAdd.Text = "Add Selected >>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstEmployees);
            this.groupBox3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 26);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Employees:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lstAssignedEmployees
            // 
            this.lstAssignedEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lstAssignedEmployees.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAssignedEmployees.FormattingEnabled = true;
            this.lstAssignedEmployees.ItemHeight = 16;
            this.lstAssignedEmployees.Location = new System.Drawing.Point(346, 33);
            this.lstAssignedEmployees.Name = "lstAssignedEmployees";
            this.lstAssignedEmployees.Size = new System.Drawing.Size(145, 100);
            this.lstAssignedEmployees.TabIndex = 35;
            this.lstAssignedEmployees.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstAssignedEmployees_DragDrop);
            this.lstAssignedEmployees.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstAssignedEmployees_DragEnter);
            // 
            // dtpJobStart
            // 
            this.dtpJobStart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpJobStart.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpJobStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpJobStart.Location = new System.Drawing.Point(346, 172);
            this.dtpJobStart.Name = "dtpJobStart";
            this.dtpJobStart.Size = new System.Drawing.Size(103, 22);
            this.dtpJobStart.TabIndex = 29;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(269, 177);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(71, 16);
            this.label20.TabIndex = 28;
            this.label20.Text = "Date Start:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbjobBindingSource
            // 
            this.tbjobBindingSource.DataMember = "tbjob";
            this.tbjobBindingSource.DataSource = this.dbwrtcoordinatorDataSet;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(377, 305);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 28);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevious.Location = new System.Drawing.Point(296, 305);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 28);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnAddJobSite
            // 
            this.btnAddJobSite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddJobSite.Location = new System.Drawing.Point(458, 305);
            this.btnAddJobSite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddJobSite.Name = "btnAddJobSite";
            this.btnAddJobSite.Size = new System.Drawing.Size(75, 28);
            this.btnAddJobSite.TabIndex = 3;
            this.btnAddJobSite.Text = "Finish";
            this.btnAddJobSite.UseVisualStyleBackColor = true;
            this.btnAddJobSite.Click += new System.EventHandler(this.btnAddJobSite_Click);
            // 
            // tbemployeeTableAdapter
            // 
            this.tbemployeeTableAdapter.ClearBeforeFill = true;
            // 
            // tbinsuranceTableAdapter
            // 
            this.tbinsuranceTableAdapter.ClearBeforeFill = true;
            // 
            // tbcustomerTableAdapter
            // 
            this.tbcustomerTableAdapter.ClearBeforeFill = true;
            // 
            // tbjobTableAdapter
            // 
            this.tbjobTableAdapter.ClearBeforeFill = true;
            // 
            // frmJobSiteWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(545, 350);
            this.Controls.Add(this.btnAddJobSite);
            this.Controls.Add(this.pnlJob);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.pnlCustomerAdd);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmJobSiteWizard";
            this.Text = "Job Site Wizard";
            this.Load += new System.EventHandler(this.frmJobSiteWizard_Load);
            this.pnlCustomerAdd.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbcustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbwrtcoordinatorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbinsuranceBindingSource)).EndInit();
            this.pnlJob.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbemployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbjobBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCustomerAdd;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnAddJobSite;
        private dbwrtcoordinatorDataSet dbwrtcoordinatorDataSet;
        private System.Windows.Forms.BindingSource tbemployeeBindingSource;
        private dbwrtcoordinatorDataSetTableAdapters.tbemployeeTableAdapter tbemployeeTableAdapter;
        private System.Windows.Forms.BindingSource tbinsuranceBindingSource;
        private dbwrtcoordinatorDataSetTableAdapters.tbinsuranceTableAdapter tbinsuranceTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlJob;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstEmployees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstAssignedEmployees;
        private System.Windows.Forms.DateTimePicker dtpJobStart;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbAddInsurance;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource tbjobBindingSource;
        private dbwrtcoordinatorDataSetTableAdapters.tbjobTableAdapter tbjobTableAdapter;
        private System.Windows.Forms.TextBox txtClaimNo;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblCustomer;
        public System.Windows.Forms.ListBox lstCustomer;
        public System.Windows.Forms.TextBox txtSearchCustomer;
        public System.Windows.Forms.BindingSource tbcustomerBindingSource;
        public dbwrtcoordinatorDataSetTableAdapters.tbcustomerTableAdapter tbcustomerTableAdapter;
        public System.Windows.Forms.Label lblCustID;
    }
}