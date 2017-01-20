namespace CarDealer.Forms
{
    partial class frmManufacturers
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
            this.dgvManufacturers = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.websiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carModelsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manifactureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManufacturers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manifactureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvManufacturers
            // 
            this.dgvManufacturers.AllowUserToOrderColumns = true;
            this.dgvManufacturers.AutoGenerateColumns = false;
            this.dgvManufacturers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManufacturers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.websiteDataGridViewTextBoxColumn,
            this.carModelsDataGridViewTextBoxColumn});
            this.dgvManufacturers.DataSource = this.manifactureBindingSource;
            this.dgvManufacturers.Location = new System.Drawing.Point(13, 13);
            this.dgvManufacturers.Name = "dgvManufacturers";
            this.dgvManufacturers.Size = new System.Drawing.Size(363, 208);
            this.dgvManufacturers.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // websiteDataGridViewTextBoxColumn
            // 
            this.websiteDataGridViewTextBoxColumn.DataPropertyName = "Website";
            this.websiteDataGridViewTextBoxColumn.HeaderText = "Website";
            this.websiteDataGridViewTextBoxColumn.Name = "websiteDataGridViewTextBoxColumn";
            // 
            // carModelsDataGridViewTextBoxColumn
            // 
            this.carModelsDataGridViewTextBoxColumn.DataPropertyName = "CarModels";
            this.carModelsDataGridViewTextBoxColumn.HeaderText = "CarModels";
            this.carModelsDataGridViewTextBoxColumn.Name = "carModelsDataGridViewTextBoxColumn";
            // 
            // manifactureBindingSource
            // 
            this.manifactureBindingSource.DataSource = typeof(CarDealer.DataLayer.Manifacture);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(13, 257);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(363, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Chiudi";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(13, 227);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(363, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Salva";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmManufacturers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 292);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvManufacturers);
            this.Name = "frmManufacturers";
            this.Text = "Produttori";
            this.Load += new System.EventHandler(this.frmManufacturers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManufacturers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manifactureBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvManufacturers;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource manifactureBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn websiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carModelsDataGridViewTextBoxColumn;
    }
}