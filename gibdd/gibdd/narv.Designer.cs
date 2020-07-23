namespace gibdd
{
    partial class narv
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
            this.номеравтоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.регионDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статьяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.narvBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoDataSet1 = new gibdd.autoDataSet1();
            this.narvTableAdapter = new gibdd.autoDataSet1TableAdapters.narvTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narvBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номеравтоDataGridViewTextBoxColumn,
            this.регионDataGridViewTextBoxColumn,
            this.статьяDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.суммаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.narvBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(969, 438);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // номеравтоDataGridViewTextBoxColumn
            // 
            this.номеравтоDataGridViewTextBoxColumn.DataPropertyName = "Номер_авто";
            this.номеравтоDataGridViewTextBoxColumn.HeaderText = "Номер_авто";
            this.номеравтоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номеравтоDataGridViewTextBoxColumn.Name = "номеравтоDataGridViewTextBoxColumn";
            this.номеравтоDataGridViewTextBoxColumn.Width = 125;
            // 
            // регионDataGridViewTextBoxColumn
            // 
            this.регионDataGridViewTextBoxColumn.DataPropertyName = "Регион";
            this.регионDataGridViewTextBoxColumn.HeaderText = "Регион";
            this.регионDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.регионDataGridViewTextBoxColumn.Name = "регионDataGridViewTextBoxColumn";
            this.регионDataGridViewTextBoxColumn.Width = 125;
            // 
            // статьяDataGridViewTextBoxColumn
            // 
            this.статьяDataGridViewTextBoxColumn.DataPropertyName = "Статья";
            this.статьяDataGridViewTextBoxColumn.HeaderText = "Статья";
            this.статьяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.статьяDataGridViewTextBoxColumn.Name = "статьяDataGridViewTextBoxColumn";
            this.статьяDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            this.датаDataGridViewTextBoxColumn.Width = 125;
            // 
            // суммаDataGridViewTextBoxColumn
            // 
            this.суммаDataGridViewTextBoxColumn.DataPropertyName = "Сумма";
            this.суммаDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.суммаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.суммаDataGridViewTextBoxColumn.Name = "суммаDataGridViewTextBoxColumn";
            this.суммаDataGridViewTextBoxColumn.Width = 125;
            // 
            // narvBindingSource
            // 
            this.narvBindingSource.DataMember = "narv";
            this.narvBindingSource.DataSource = this.autoDataSet1;
            // 
            // autoDataSet1
            // 
            this.autoDataSet1.DataSetName = "autoDataSet1";
            this.autoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // narvTableAdapter
            // 
            this.narvTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1035, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавление";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1035, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "Поиск";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1035, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 42);
            this.button3.TabIndex = 3;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1035, 402);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 36);
            this.button4.TabIndex = 4;
            this.button4.Text = "Закрыть";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // narv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 466);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "narv";
            this.Text = "Нарушения водителей";
            this.Load += new System.EventHandler(this.narv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narvBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public autoDataSet1 autoDataSet1;
        public System.Windows.Forms.BindingSource narvBindingSource;
        public autoDataSet1TableAdapters.narvTableAdapter narvTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номеравтоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn регионDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статьяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}