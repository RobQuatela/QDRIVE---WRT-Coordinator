namespace QDRIVE___WRT_Coordinator
{
    partial class frmChangeEquip
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangeEquip));
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.dataGridView10 = new System.Windows.Forms.DataGridView();
            this.equipnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipstockinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipstockoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipstockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbequipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbwrtcoordinatorDataSet = new QDRIVE___WRT_Coordinator.dbwrtcoordinatorDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddEquip = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNewStock = new System.Windows.Forms.TextBox();
            this.txtNewEquipName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEditOut = new System.Windows.Forms.Label();
            this.btnDeleteEquip = new System.Windows.Forms.Button();
            this.btnSaveEquip = new System.Windows.Forms.Button();
            this.txtEditIn = new System.Windows.Forms.TextBox();
            this.txtEditEquipName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEquipId = new System.Windows.Forms.Label();
            this.tbequipmentTableAdapter = new QDRIVE___WRT_Coordinator.dbwrtcoordinatorDataSetTableAdapters.tbequipmentTableAdapter();
            this.lblEditStock = new System.Windows.Forms.Label();
            this.groupBox22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbequipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbwrtcoordinatorDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.dataGridView10);
            this.groupBox22.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox22.Location = new System.Drawing.Point(12, 12);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(391, 370);
            this.groupBox22.TabIndex = 5;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "Equipment Inventory";
            // 
            // dataGridView10
            // 
            this.dataGridView10.AllowUserToAddRows = false;
            this.dataGridView10.AllowUserToDeleteRows = false;
            this.dataGridView10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView10.AutoGenerateColumns = false;
            this.dataGridView10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView10.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.equipnameDataGridViewTextBoxColumn,
            this.equipstockinDataGridViewTextBoxColumn,
            this.equipstockoutDataGridViewTextBoxColumn,
            this.equipstockDataGridViewTextBoxColumn});
            this.dataGridView10.DataSource = this.tbequipmentBindingSource;
            this.dataGridView10.Location = new System.Drawing.Point(6, 21);
            this.dataGridView10.Name = "dataGridView10";
            this.dataGridView10.ReadOnly = true;
            this.dataGridView10.RowHeadersVisible = false;
            this.dataGridView10.Size = new System.Drawing.Size(379, 343);
            this.dataGridView10.TabIndex = 0;
            // 
            // equipnameDataGridViewTextBoxColumn
            // 
            this.equipnameDataGridViewTextBoxColumn.DataPropertyName = "equip_name";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipnameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.equipnameDataGridViewTextBoxColumn.HeaderText = "Equipment";
            this.equipnameDataGridViewTextBoxColumn.Name = "equipnameDataGridViewTextBoxColumn";
            this.equipnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.equipnameDataGridViewTextBoxColumn.Width = 200;
            // 
            // equipstockinDataGridViewTextBoxColumn
            // 
            this.equipstockinDataGridViewTextBoxColumn.DataPropertyName = "equip_stock_in";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipstockinDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.equipstockinDataGridViewTextBoxColumn.HeaderText = "In";
            this.equipstockinDataGridViewTextBoxColumn.Name = "equipstockinDataGridViewTextBoxColumn";
            this.equipstockinDataGridViewTextBoxColumn.ReadOnly = true;
            this.equipstockinDataGridViewTextBoxColumn.Width = 50;
            // 
            // equipstockoutDataGridViewTextBoxColumn
            // 
            this.equipstockoutDataGridViewTextBoxColumn.DataPropertyName = "equip_stock_out";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipstockoutDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.equipstockoutDataGridViewTextBoxColumn.HeaderText = "Out";
            this.equipstockoutDataGridViewTextBoxColumn.Name = "equipstockoutDataGridViewTextBoxColumn";
            this.equipstockoutDataGridViewTextBoxColumn.ReadOnly = true;
            this.equipstockoutDataGridViewTextBoxColumn.Width = 50;
            // 
            // equipstockDataGridViewTextBoxColumn
            // 
            this.equipstockDataGridViewTextBoxColumn.DataPropertyName = "equip_stock";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipstockDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.equipstockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.equipstockDataGridViewTextBoxColumn.Name = "equipstockDataGridViewTextBoxColumn";
            this.equipstockDataGridViewTextBoxColumn.ReadOnly = true;
            this.equipstockDataGridViewTextBoxColumn.Width = 75;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddEquip);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNewStock);
            this.groupBox1.Controls.Add(this.txtNewEquipName);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(409, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 161);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Equipment";
            // 
            // btnAddEquip
            // 
            this.btnAddEquip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddEquip.BackColor = System.Drawing.Color.White;
            this.btnAddEquip.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEquip.Location = new System.Drawing.Point(142, 111);
            this.btnAddEquip.Name = "btnAddEquip";
            this.btnAddEquip.Size = new System.Drawing.Size(117, 33);
            this.btnAddEquip.TabIndex = 25;
            this.btnAddEquip.Text = "Add Equipment";
            this.btnAddEquip.UseVisualStyleBackColor = false;
            this.btnAddEquip.Click += new System.EventHandler(this.btnAddEquip_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Equipment Name:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(90, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Stock:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNewStock
            // 
            this.txtNewStock.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewStock.Location = new System.Drawing.Point(142, 71);
            this.txtNewStock.Name = "txtNewStock";
            this.txtNewStock.Size = new System.Drawing.Size(106, 22);
            this.txtNewStock.TabIndex = 22;
            // 
            // txtNewEquipName
            // 
            this.txtNewEquipName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewEquipName.Location = new System.Drawing.Point(142, 30);
            this.txtNewEquipName.Name = "txtNewEquipName";
            this.txtNewEquipName.Size = new System.Drawing.Size(199, 22);
            this.txtNewEquipName.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblEditStock);
            this.groupBox2.Controls.Add(this.lblEditOut);
            this.groupBox2.Controls.Add(this.btnDeleteEquip);
            this.groupBox2.Controls.Add(this.btnSaveEquip);
            this.groupBox2.Controls.Add(this.txtEditIn);
            this.groupBox2.Controls.Add(this.txtEditEquipName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblEquipId);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(409, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 203);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adjust Equipment";
            // 
            // lblEditOut
            // 
            this.lblEditOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEditOut.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbequipmentBindingSource, "equip_stock_out", true));
            this.lblEditOut.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditOut.Location = new System.Drawing.Point(142, 90);
            this.lblEditOut.Name = "lblEditOut";
            this.lblEditOut.Size = new System.Drawing.Size(63, 22);
            this.lblEditOut.TabIndex = 19;
            this.lblEditOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDeleteEquip
            // 
            this.btnDeleteEquip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteEquip.BackColor = System.Drawing.Color.White;
            this.btnDeleteEquip.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEquip.Location = new System.Drawing.Point(225, 155);
            this.btnDeleteEquip.Name = "btnDeleteEquip";
            this.btnDeleteEquip.Size = new System.Drawing.Size(129, 33);
            this.btnDeleteEquip.TabIndex = 18;
            this.btnDeleteEquip.Text = "Remove Equipment";
            this.btnDeleteEquip.UseVisualStyleBackColor = false;
            this.btnDeleteEquip.Click += new System.EventHandler(this.btnDeleteEquip_Click);
            // 
            // btnSaveEquip
            // 
            this.btnSaveEquip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveEquip.BackColor = System.Drawing.Color.White;
            this.btnSaveEquip.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEquip.Location = new System.Drawing.Point(39, 155);
            this.btnSaveEquip.Name = "btnSaveEquip";
            this.btnSaveEquip.Size = new System.Drawing.Size(117, 33);
            this.btnSaveEquip.TabIndex = 16;
            this.btnSaveEquip.Text = "Save Equipment";
            this.btnSaveEquip.UseVisualStyleBackColor = false;
            this.btnSaveEquip.Click += new System.EventHandler(this.btnSaveEquip_Click);
            // 
            // txtEditIn
            // 
            this.txtEditIn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbequipmentBindingSource, "equip_stock_in", true));
            this.txtEditIn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditIn.Location = new System.Drawing.Point(142, 62);
            this.txtEditIn.Name = "txtEditIn";
            this.txtEditIn.Size = new System.Drawing.Size(63, 22);
            this.txtEditIn.TabIndex = 6;
            this.txtEditIn.TextChanged += new System.EventHandler(this.txtEditIn_TextChanged);
            // 
            // txtEditEquipName
            // 
            this.txtEditEquipName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbequipmentBindingSource, "equip_name", true));
            this.txtEditEquipName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditEquipName.Location = new System.Drawing.Point(142, 34);
            this.txtEditEquipName.Name = "txtEditEquipName";
            this.txtEditEquipName.Size = new System.Drawing.Size(199, 22);
            this.txtEditEquipName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Out:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "In:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stock:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Equipment Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEquipId
            // 
            this.lblEquipId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbequipmentBindingSource, "equip_id", true));
            this.lblEquipId.Location = new System.Drawing.Point(23, 65);
            this.lblEquipId.Name = "lblEquipId";
            this.lblEquipId.Size = new System.Drawing.Size(10, 10);
            this.lblEquipId.TabIndex = 17;
            this.lblEquipId.Text = "label9";
            this.lblEquipId.Visible = false;
            // 
            // tbequipmentTableAdapter
            // 
            this.tbequipmentTableAdapter.ClearBeforeFill = true;
            // 
            // lblEditStock
            // 
            this.lblEditStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEditStock.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbequipmentBindingSource, "equip_stock", true));
            this.lblEditStock.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditStock.Location = new System.Drawing.Point(142, 115);
            this.lblEditStock.Name = "lblEditStock";
            this.lblEditStock.Size = new System.Drawing.Size(63, 22);
            this.lblEditStock.TabIndex = 20;
            this.lblEditStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmChangeEquip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 399);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox22);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChangeEquip";
            this.Text = "Equipment Manager";
            this.Load += new System.EventHandler(this.frmChangeEquip_Load);
            this.groupBox22.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbequipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbwrtcoordinatorDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.DataGridView dataGridView10;
        private dbwrtcoordinatorDataSet dbwrtcoordinatorDataSet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private dbwrtcoordinatorDataSetTableAdapters.tbequipmentTableAdapter tbequipmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipstockinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipstockoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipstockDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtEditIn;
        private System.Windows.Forms.TextBox txtEditEquipName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddEquip;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNewStock;
        private System.Windows.Forms.TextBox txtNewEquipName;
        private System.Windows.Forms.Button btnSaveEquip;
        public System.Windows.Forms.BindingSource tbequipmentBindingSource;
        private System.Windows.Forms.Label lblEquipId;
        private System.Windows.Forms.Button btnDeleteEquip;
        private System.Windows.Forms.Label lblEditOut;
        private System.Windows.Forms.Label lblEditStock;
    }
}