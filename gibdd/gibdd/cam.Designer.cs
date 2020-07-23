namespace gibdd
{
    partial class cam
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.регионDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номеравтоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.превышениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cameraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cameraDataSet = new gibdd.CameraDataSet();
            this.cameraTableAdapter = new gibdd.CameraDataSetTableAdapters.cameraTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.регионDataGridViewTextBoxColumn,
            this.номеравтоDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.превышениеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cameraBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(784, 560);
            this.dataGridView1.TabIndex = 0;
            // 
            // регионDataGridViewTextBoxColumn
            // 
            this.регионDataGridViewTextBoxColumn.DataPropertyName = "Регион";
            this.регионDataGridViewTextBoxColumn.HeaderText = "Регион";
            this.регионDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.регионDataGridViewTextBoxColumn.Name = "регионDataGridViewTextBoxColumn";
            this.регионDataGridViewTextBoxColumn.Width = 125;
            // 
            // номеравтоDataGridViewTextBoxColumn
            // 
            this.номеравтоDataGridViewTextBoxColumn.DataPropertyName = "Номер_авто";
            this.номеравтоDataGridViewTextBoxColumn.HeaderText = "Номер_авто";
            this.номеравтоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номеравтоDataGridViewTextBoxColumn.Name = "номеравтоDataGridViewTextBoxColumn";
            this.номеравтоDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            this.датаDataGridViewTextBoxColumn.Width = 125;
            // 
            // превышениеDataGridViewTextBoxColumn
            // 
            this.превышениеDataGridViewTextBoxColumn.DataPropertyName = "Превышение";
            this.превышениеDataGridViewTextBoxColumn.HeaderText = "Превышение";
            this.превышениеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.превышениеDataGridViewTextBoxColumn.Name = "превышениеDataGridViewTextBoxColumn";
            this.превышениеDataGridViewTextBoxColumn.Width = 125;
            // 
            // cameraBindingSource
            // 
            this.cameraBindingSource.DataMember = "camera";
            this.cameraBindingSource.DataSource = this.cameraDataSet;
            // 
            // cameraDataSet
            // 
            this.cameraDataSet.DataSetName = "CameraDataSet";
            this.cameraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cameraTableAdapter
            // 
            this.cameraTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(809, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 572);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "cam";
            this.Text = "Данные с камер наблюдения";
            this.Load += new System.EventHandler(this.cam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CameraDataSet cameraDataSet;
        private System.Windows.Forms.BindingSource cameraBindingSource;
        private CameraDataSetTableAdapters.cameraTableAdapter cameraTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn регионDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номеравтоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn превышениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}