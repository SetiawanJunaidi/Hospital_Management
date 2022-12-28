namespace HospitalManagementSystemCSharp
{
    partial class ViewwPatientCheckOut
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkoutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet3 = new HospitalManagementSystemCSharp.hospitalDataSet3();
            this.checkoutTableAdapter = new HospitalManagementSystemCSharp.hospitalDataSet3TableAdapters.checkoutTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diseaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkoutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(329, 44);
            this.label3.TabIndex = 117;
            this.label3.Text = "Patient Checkout";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(109, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(341, 22);
            this.textBox1.TabIndex = 116;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 115;
            this.label1.Text = "Patient Id";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HospitalManagementSystemCSharp.Properties.Resources.hms2;
            this.pictureBox1.Location = new System.Drawing.Point(479, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 118;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(456, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 27);
            this.button1.TabIndex = 161;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.genDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.addrDataGridViewTextBoxColumn,
            this.diseaseDataGridViewTextBoxColumn,
            this.dateinDataGridViewTextBoxColumn,
            this.dateoutDataGridViewTextBoxColumn,
            this.buildDataGridViewTextBoxColumn,
            this.rnoDataGridViewTextBoxColumn,
            this.rtypeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.medpriceDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.checkoutBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(561, 327);
            this.dataGridView1.TabIndex = 162;
            // 
            // checkoutBindingSource
            // 
            this.checkoutBindingSource.DataMember = "checkout";
            this.checkoutBindingSource.DataSource = this.hospitalDataSet3;
            // 
            // hospitalDataSet3
            // 
            this.hospitalDataSet3.DataSetName = "hospitalDataSet3";
            this.hospitalDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkoutTableAdapter
            // 
            this.checkoutTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // genDataGridViewTextBoxColumn
            // 
            this.genDataGridViewTextBoxColumn.DataPropertyName = "gen";
            this.genDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genDataGridViewTextBoxColumn.Name = "genDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            // 
            // addrDataGridViewTextBoxColumn
            // 
            this.addrDataGridViewTextBoxColumn.DataPropertyName = "addr";
            this.addrDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addrDataGridViewTextBoxColumn.Name = "addrDataGridViewTextBoxColumn";
            // 
            // diseaseDataGridViewTextBoxColumn
            // 
            this.diseaseDataGridViewTextBoxColumn.DataPropertyName = "disease";
            this.diseaseDataGridViewTextBoxColumn.HeaderText = "Disease";
            this.diseaseDataGridViewTextBoxColumn.Name = "diseaseDataGridViewTextBoxColumn";
            // 
            // dateinDataGridViewTextBoxColumn
            // 
            this.dateinDataGridViewTextBoxColumn.DataPropertyName = "date_in";
            this.dateinDataGridViewTextBoxColumn.HeaderText = "Date_in";
            this.dateinDataGridViewTextBoxColumn.Name = "dateinDataGridViewTextBoxColumn";
            // 
            // dateoutDataGridViewTextBoxColumn
            // 
            this.dateoutDataGridViewTextBoxColumn.DataPropertyName = "date_out";
            this.dateoutDataGridViewTextBoxColumn.HeaderText = "Date_out";
            this.dateoutDataGridViewTextBoxColumn.Name = "dateoutDataGridViewTextBoxColumn";
            // 
            // buildDataGridViewTextBoxColumn
            // 
            this.buildDataGridViewTextBoxColumn.DataPropertyName = "build";
            this.buildDataGridViewTextBoxColumn.HeaderText = "Building";
            this.buildDataGridViewTextBoxColumn.Name = "buildDataGridViewTextBoxColumn";
            // 
            // rnoDataGridViewTextBoxColumn
            // 
            this.rnoDataGridViewTextBoxColumn.DataPropertyName = "r_no";
            this.rnoDataGridViewTextBoxColumn.HeaderText = "Room No.";
            this.rnoDataGridViewTextBoxColumn.Name = "rnoDataGridViewTextBoxColumn";
            // 
            // rtypeDataGridViewTextBoxColumn
            // 
            this.rtypeDataGridViewTextBoxColumn.DataPropertyName = "r_type";
            this.rtypeDataGridViewTextBoxColumn.HeaderText = "Room Type";
            this.rtypeDataGridViewTextBoxColumn.Name = "rtypeDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // medpriceDataGridViewTextBoxColumn
            // 
            this.medpriceDataGridViewTextBoxColumn.DataPropertyName = "med_price";
            this.medpriceDataGridViewTextBoxColumn.HeaderText = "Medicine Price";
            this.medpriceDataGridViewTextBoxColumn.Name = "medpriceDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // ViewwPatientCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(585, 447);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ViewwPatientCheckOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewwPatientCheckOut";
            this.Load += new System.EventHandler(this.ViewwPatientCheckOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkoutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private hospitalDataSet3 hospitalDataSet3;
        private System.Windows.Forms.BindingSource checkoutBindingSource;
        private hospitalDataSet3TableAdapters.checkoutTableAdapter checkoutTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diseaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}