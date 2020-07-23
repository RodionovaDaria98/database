namespace gibdd
{
    partial class nar
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
            this.autoDataSet2 = new gibdd.autoDataSet2();
            this.narBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.narTableAdapter = new gibdd.autoDataSet2TableAdapters.narTableAdapter();
            this.статьяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наимнарушDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаминDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммамаксDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.скоростьминDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.скоростьмаксDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фиксацияКамеройDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.статьяDataGridViewTextBoxColumn,
            this.наимнарушDataGridViewTextBoxColumn,
            this.суммаминDataGridViewTextBoxColumn,
            this.суммамаксDataGridViewTextBoxColumn,
            this.скоростьминDataGridViewTextBoxColumn,
            this.скоростьмаксDataGridViewTextBoxColumn,
            this.фиксацияКамеройDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.narBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1209, 610);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // autoDataSet2
            // 
            this.autoDataSet2.DataSetName = "autoDataSet2";
            this.autoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // narBindingSource
            // 
            this.narBindingSource.DataMember = "nar";
            this.narBindingSource.DataSource = this.autoDataSet2;
            // 
            // narTableAdapter
            // 
            this.narTableAdapter.ClearBeforeFill = true;
            // 
            // статьяDataGridViewTextBoxColumn
            // 
            this.статьяDataGridViewTextBoxColumn.DataPropertyName = "Статья";
            this.статьяDataGridViewTextBoxColumn.HeaderText = "Статья";
            this.статьяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.статьяDataGridViewTextBoxColumn.Name = "статьяDataGridViewTextBoxColumn";
            this.статьяDataGridViewTextBoxColumn.Width = 125;
            // 
            // наимнарушDataGridViewTextBoxColumn
            // 
            this.наимнарушDataGridViewTextBoxColumn.DataPropertyName = "Наим_наруш";
            this.наимнарушDataGridViewTextBoxColumn.HeaderText = "Наим_наруш";
            this.наимнарушDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.наимнарушDataGridViewTextBoxColumn.Name = "наимнарушDataGridViewTextBoxColumn";
            this.наимнарушDataGridViewTextBoxColumn.Width = 125;
            // 
            // суммаминDataGridViewTextBoxColumn
            // 
            this.суммаминDataGridViewTextBoxColumn.DataPropertyName = "Сумма(мин)";
            this.суммаминDataGridViewTextBoxColumn.HeaderText = "Сумма(мин)";
            this.суммаминDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.суммаминDataGridViewTextBoxColumn.Name = "суммаминDataGridViewTextBoxColumn";
            this.суммаминDataGridViewTextBoxColumn.Width = 125;
            // 
            // суммамаксDataGridViewTextBoxColumn
            // 
            this.суммамаксDataGridViewTextBoxColumn.DataPropertyName = "Сумма(макс)";
            this.суммамаксDataGridViewTextBoxColumn.HeaderText = "Сумма(макс)";
            this.суммамаксDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.суммамаксDataGridViewTextBoxColumn.Name = "суммамаксDataGridViewTextBoxColumn";
            this.суммамаксDataGridViewTextBoxColumn.Width = 125;
            // 
            // скоростьминDataGridViewTextBoxColumn
            // 
            this.скоростьминDataGridViewTextBoxColumn.DataPropertyName = "Скорость(мин)";
            this.скоростьминDataGridViewTextBoxColumn.HeaderText = "Скорость(мин)";
            this.скоростьминDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.скоростьминDataGridViewTextBoxColumn.Name = "скоростьминDataGridViewTextBoxColumn";
            this.скоростьминDataGridViewTextBoxColumn.Width = 125;
            // 
            // скоростьмаксDataGridViewTextBoxColumn
            // 
            this.скоростьмаксDataGridViewTextBoxColumn.DataPropertyName = "Скорость(макс)";
            this.скоростьмаксDataGridViewTextBoxColumn.HeaderText = "Скорость(макс)";
            this.скоростьмаксDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.скоростьмаксDataGridViewTextBoxColumn.Name = "скоростьмаксDataGridViewTextBoxColumn";
            this.скоростьмаксDataGridViewTextBoxColumn.Width = 125;
            // 
            // фиксацияКамеройDataGridViewTextBoxColumn
            // 
            this.фиксацияКамеройDataGridViewTextBoxColumn.DataPropertyName = "Фиксация камерой";
            this.фиксацияКамеройDataGridViewTextBoxColumn.HeaderText = "Фиксация камерой";
            this.фиксацияКамеройDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фиксацияКамеройDataGridViewTextBoxColumn.Name = "фиксацияКамеройDataGridViewTextBoxColumn";
            this.фиксацияКамеройDataGridViewTextBoxColumn.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1228, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1228, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавление";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1228, 344);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 45);
            this.button3.TabIndex = 3;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1228, 558);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 40);
            this.button4.TabIndex = 4;
            this.button4.Text = "Закрыть";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // nar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 610);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "nar";
            this.Text = "Штрафы ГИБДД";
            this.Load += new System.EventHandler(this.nar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

       public System.Windows.Forms.DataGridView dataGridView1;
        public autoDataSet2 autoDataSet2;
        public System.Windows.Forms.BindingSource narBindingSource;
        public autoDataSet2TableAdapters.narTableAdapter narTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn статьяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наимнарушDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаминDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммамаксDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn скоростьминDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn скоростьмаксDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фиксацияКамеройDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}