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
            this.txtClaimNumber = new System.Windows.Forms.TextBox();
            this.cbInsurance = new System.Windows.Forms.ComboBox();
            this.tbinsuranceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbwrtcoordinatorDataSet = new QDRIVE___WRT_Coordinator.dbwrtcoordinatorDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblJobStatus = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAfterHours = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMonitor = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtEquip = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtLabor = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.lblPayStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ckJobSiteEnd = new System.Windows.Forms.CheckBox();
            this.dtpJobEnd = new System.Windows.Forms.DateTimePicker();
            this.btnRemove = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstEmployees = new System.Windows.Forms.ListBox();
            this.tbemployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.tbinsuranceTableAdapter = new QDRIVE___WRT_Coordinator.dbwrtcoordinatorDataSetTableAdapters.tbinsuranceTableAdapter();
            this.groupBox20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbinsuranceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbwrtcoordinatorDataSet)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbemployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtempnamejobBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.txtClaimNumber);
            this.groupBox20.Controls.Add(this.cbInsurance);
            this.groupBox20.Controls.Add(this.label4);
            this.groupBox20.Controls.Add(this.label2);
            this.groupBox20.Controls.Add(this.lblJobStatus);
            this.groupBox20.Controls.Add(this.groupBox9);
            this.groupBox20.Controls.Add(this.lblPayStatus);
            this.groupBox20.Controls.Add(this.label1);
            this.groupBox20.Controls.Add(this.ckJobSiteEnd);
            this.groupBox20.Controls.Add(this.dtpJobEnd);
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
            this.groupBox20.Size = new System.Drawing.Size(682, 633);
            this.groupBox20.TabIndex = 5;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Job Site Details";
            // 
            // txtClaimNumber
            // 
            this.txtClaimNumber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaimNumber.Location = new System.Drawing.Point(423, 90);
            this.txtClaimNumber.Name = "txtClaimNumber";
            this.txtClaimNumber.Size = new System.Drawing.Size(146, 22);
            this.txtClaimNumber.TabIndex = 50;
            // 
            // cbInsurance
            // 
            this.cbInsurance.DataSource = this.tbinsuranceBindingSource;
            this.cbInsurance.DisplayMember = "ins_name";
            this.cbInsurance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInsurance.FormattingEnabled = true;
            this.cbInsurance.Location = new System.Drawing.Point(423, 52);
            this.cbInsurance.Name = "cbInsurance";
            this.cbInsurance.Size = new System.Drawing.Size(146, 24);
            this.cbInsurance.TabIndex = 49;
            this.cbInsurance.ValueMember = "ins_id";
            // 
            // tbinsuranceBindingSource
            // 
            this.tbinsuranceBindingSource.DataMember = "tbinsurance";
            this.tbinsuranceBindingSource.DataSource = this.dbwrtcoordinatorDataSet;
            // 
            // dbwrtcoordinatorDataSet
            // 
            this.dbwrtcoordinatorDataSet.DataSetName = "dbwrtcoordinatorDataSet";
            this.dbwrtcoordinatorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(352, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "Claim No:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(349, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "Insurance:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblJobStatus
            // 
            this.lblJobStatus.AutoSize = true;
            this.lblJobStatus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobStatus.Location = new System.Drawing.Point(423, 128);
            this.lblJobStatus.Name = "lblJobStatus";
            this.lblJobStatus.Size = new System.Drawing.Size(42, 16);
            this.lblJobStatus.TabIndex = 46;
            this.lblJobStatus.Text = "label2";
            // 
            // groupBox9
            // 
            this.groupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox9.Controls.Add(this.lblTotal);
            this.groupBox9.Controls.Add(this.label3);
            this.groupBox9.Controls.Add(this.txtHours);
            this.groupBox9.Controls.Add(this.label15);
            this.groupBox9.Controls.Add(this.txtAfterHours);
            this.groupBox9.Controls.Add(this.label16);
            this.groupBox9.Controls.Add(this.txtMonitor);
            this.groupBox9.Controls.Add(this.label17);
            this.groupBox9.Controls.Add(this.txtEquip);
            this.groupBox9.Controls.Add(this.label18);
            this.groupBox9.Controls.Add(this.txtLabor);
            this.groupBox9.Controls.Add(this.label19);
            this.groupBox9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(15, 388);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(454, 183);
            this.groupBox9.TabIndex = 45;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Sales Informtion";
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotal.Location = new System.Drawing.Point(99, 147);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(103, 25);
            this.lblTotal.TabIndex = 22;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Total:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHours
            // 
            this.txtHours.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHours.Location = new System.Drawing.Point(297, 73);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(72, 22);
            this.txtHours.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(245, 79);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 16);
            this.label15.TabIndex = 16;
            this.label15.Text = "Hours:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAfterHours
            // 
            this.txtAfterHours.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAfterHours.Location = new System.Drawing.Point(297, 40);
            this.txtAfterHours.Name = "txtAfterHours";
            this.txtAfterHours.Size = new System.Drawing.Size(72, 22);
            this.txtAfterHours.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(214, 46);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 16);
            this.label16.TabIndex = 14;
            this.label16.Text = "After Hours:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMonitor
            // 
            this.txtMonitor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonitor.Location = new System.Drawing.Point(102, 106);
            this.txtMonitor.Name = "txtMonitor";
            this.txtMonitor.Size = new System.Drawing.Size(104, 22);
            this.txtMonitor.TabIndex = 13;
            this.txtMonitor.TextChanged += new System.EventHandler(this.txtMonitor_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(24, 109);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 16);
            this.label17.TabIndex = 12;
            this.label17.Text = "Monitoring:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEquip
            // 
            this.txtEquip.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquip.Location = new System.Drawing.Point(102, 75);
            this.txtEquip.Name = "txtEquip";
            this.txtEquip.Size = new System.Drawing.Size(104, 22);
            this.txtEquip.TabIndex = 11;
            this.txtEquip.TextChanged += new System.EventHandler(this.txtEquip_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(22, 78);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 16);
            this.label18.TabIndex = 10;
            this.label18.Text = "Equipment:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLabor
            // 
            this.txtLabor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabor.Location = new System.Drawing.Point(102, 40);
            this.txtLabor.Name = "txtLabor";
            this.txtLabor.Size = new System.Drawing.Size(104, 22);
            this.txtLabor.TabIndex = 9;
            this.txtLabor.TextChanged += new System.EventHandler(this.txtLabor_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(52, 43);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 16);
            this.label19.TabIndex = 8;
            this.label19.Text = "Labor:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPayStatus
            // 
            this.lblPayStatus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayStatus.Location = new System.Drawing.Point(423, 342);
            this.lblPayStatus.Name = "lblPayStatus";
            this.lblPayStatus.Size = new System.Drawing.Size(212, 22);
            this.lblPayStatus.TabIndex = 44;
            this.lblPayStatus.Text = "label51";
            this.lblPayStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 345);
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
            this.ckJobSiteEnd.Location = new System.Drawing.Point(423, 191);
            this.ckJobSiteEnd.Name = "ckJobSiteEnd";
            this.ckJobSiteEnd.Size = new System.Drawing.Size(182, 20);
            this.ckJobSiteEnd.TabIndex = 42;
            this.ckJobSiteEnd.Text = "I know the completion date";
            this.ckJobSiteEnd.UseVisualStyleBackColor = true;
            this.ckJobSiteEnd.CheckedChanged += new System.EventHandler(this.ckJobSiteEnd_CheckedChanged);
            // 
            // dtpJobEnd
            // 
            this.dtpJobEnd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpJobEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpJobEnd.Location = new System.Drawing.Point(423, 187);
            this.dtpJobEnd.Name = "dtpJobEnd";
            this.dtpJobEnd.Size = new System.Drawing.Size(103, 22);
            this.dtpJobEnd.TabIndex = 41;
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(202, 300);
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
            this.groupBox3.Size = new System.Drawing.Size(170, 336);
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
            this.lstEmployees.Size = new System.Drawing.Size(157, 292);
            this.lstEmployees.TabIndex = 34;
            this.lstEmployees.ValueMember = "emp_id";
            // 
            // tbemployeeBindingSource
            // 
            this.tbemployeeBindingSource.DataMember = "tbemployee";
            this.tbemployeeBindingSource.DataSource = this.dbwrtcoordinatorDataSet;
            // 
            // btnJobSiteEdit
            // 
            this.btnJobSiteEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnJobSiteEdit.BackColor = System.Drawing.Color.White;
            this.btnJobSiteEdit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJobSiteEdit.Location = new System.Drawing.Point(275, 594);
            this.btnJobSiteEdit.Name = "btnJobSiteEdit";
            this.btnJobSiteEdit.Size = new System.Drawing.Size(119, 33);
            this.btnJobSiteEdit.TabIndex = 14;
            this.btnJobSiteEdit.Text = "Save && Close";
            this.btnJobSiteEdit.UseVisualStyleBackColor = false;
            this.btnJobSiteEdit.Click += new System.EventHandler(this.btnJobSiteEdit_Click);
            // 
            // dtpJobStart
            // 
            this.dtpJobStart.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpJobStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpJobStart.Location = new System.Drawing.Point(423, 156);
            this.dtpJobStart.Name = "dtpJobStart";
            this.dtpJobStart.Size = new System.Drawing.Size(103, 22);
            this.dtpJobStart.TabIndex = 29;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(202, 264);
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
            this.lstJobSiteEmployee.Location = new System.Drawing.Point(426, 228);
            this.lstJobSiteEmployee.Name = "lstJobSiteEmployee";
            this.lstJobSiteEmployee.Size = new System.Drawing.Size(209, 100);
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
            this.label50.Location = new System.Drawing.Point(340, 228);
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
            this.label49.Location = new System.Drawing.Point(319, 192);
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
            this.label48.Location = new System.Drawing.Point(346, 161);
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
            this.label47.Location = new System.Drawing.Point(367, 128);
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
            // tbinsuranceTableAdapter
            // 
            this.tbinsuranceTableAdapter.ClearBeforeFill = true;
            // 
            // frmEditJobSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 652);
            this.Controls.Add(this.groupBox20);
            this.Name = "frmEditJobSite";
            this.Text = "frmEditJobSite";
            this.Load += new System.EventHandler(this.frmEditJobSite_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmJobSite_FormClosed);
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbinsuranceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbwrtcoordinatorDataSet)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbemployeeBindingSource)).EndInit();
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
        public System.Windows.Forms.DateTimePicker dtpJobStart;
        public System.Windows.Forms.DateTimePicker dtpJobEnd;
        public System.Windows.Forms.CheckBox ckJobSiteEnd;
        private System.Windows.Forms.BindingSource dtempnamejobBindingSource;
        private dbwrtcoordinatorDataSetTableAdapters.dtempnamejobTableAdapter dtempnamejobTableAdapter;
        public System.Windows.Forms.Label lblPayStatus;
        private System.Windows.Forms.Label label1;
        private dbwrtcoordinatorDataSetTableAdapters.tbempjobTableAdapter tbempjobTableAdapter;
        private System.Windows.Forms.GroupBox groupBox9;
        public System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.TextBox txtHours;
        public System.Windows.Forms.TextBox txtAfterHours;
        public System.Windows.Forms.TextBox txtMonitor;
        public System.Windows.Forms.TextBox txtEquip;
        public System.Windows.Forms.TextBox txtLabor;
        public System.Windows.Forms.Label lblJobStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource tbinsuranceBindingSource;
        private dbwrtcoordinatorDataSetTableAdapters.tbinsuranceTableAdapter tbinsuranceTableAdapter;
        public System.Windows.Forms.TextBox txtClaimNumber;
        public System.Windows.Forms.ComboBox cbInsurance;
    }
}