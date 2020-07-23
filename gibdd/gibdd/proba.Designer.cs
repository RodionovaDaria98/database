namespace gibdd
{
    partial class proba
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.statya = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naim_narush = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skorostmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skorostmax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fixcamera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomer,
            this.region,
            this.adres,
            this.prev});
            this.dataGridView2.Location = new System.Drawing.Point(30, 30);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1285, 179);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.statya,
            this.naim_narush,
            this.summin,
            this.summax,
            this.skorostmin,
            this.skorostmax,
            this.fixcamera});
            this.dataGridView3.Location = new System.Drawing.Point(30, 258);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(1285, 170);
            this.dataGridView3.TabIndex = 2;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            this.dataGridView3.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView3_UserDeletingRow);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1369, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Отобразить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1391, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // statya
            // 
            this.statya.DataPropertyName = "statya";
            this.statya.HeaderText = "Статья";
            this.statya.MinimumWidth = 6;
            this.statya.Name = "statya";
            this.statya.Width = 125;
            // 
            // naim_narush
            // 
            this.naim_narush.DataPropertyName = "naim_narush";
            this.naim_narush.HeaderText = "Наим_наруш";
            this.naim_narush.MinimumWidth = 6;
            this.naim_narush.Name = "naim_narush";
            this.naim_narush.Width = 125;
            // 
            // summin
            // 
            this.summin.DataPropertyName = "summin";
            this.summin.HeaderText = "Сумма(мин)";
            this.summin.MinimumWidth = 6;
            this.summin.Name = "summin";
            this.summin.Width = 125;
            // 
            // summax
            // 
            this.summax.DataPropertyName = "summax";
            this.summax.HeaderText = "Сумма(макс)";
            this.summax.MinimumWidth = 6;
            this.summax.Name = "summax";
            this.summax.Width = 125;
            // 
            // skorostmin
            // 
            this.skorostmin.DataPropertyName = "skorostmin";
            this.skorostmin.HeaderText = "Скорость(мин)";
            this.skorostmin.MinimumWidth = 6;
            this.skorostmin.Name = "skorostmin";
            this.skorostmin.Width = 125;
            // 
            // skorostmax
            // 
            this.skorostmax.DataPropertyName = "skorostmax";
            this.skorostmax.HeaderText = "Скорость(макс)";
            this.skorostmax.MinimumWidth = 6;
            this.skorostmax.Name = "skorostmax";
            this.skorostmax.Width = 125;
            // 
            // fixcamera
            // 
            this.fixcamera.DataPropertyName = "fixcamera";
            this.fixcamera.HeaderText = "Фиксация камерой";
            this.fixcamera.MinimumWidth = 6;
            this.fixcamera.Name = "fixcamera";
            this.fixcamera.Width = 125;
            // 
            // nomer
            // 
            this.nomer.DataPropertyName = "nomer";
            this.nomer.HeaderText = "Номер_автомобиля";
            this.nomer.MinimumWidth = 6;
            this.nomer.Name = "nomer";
            this.nomer.Width = 125;
            // 
            // region
            // 
            this.region.DataPropertyName = "region";
            this.region.HeaderText = "Регион";
            this.region.MinimumWidth = 6;
            this.region.Name = "region";
            this.region.Width = 125;
            // 
            // adres
            // 
            this.adres.DataPropertyName = "adres";
            this.adres.HeaderText = "Адрес";
            this.adres.MinimumWidth = 6;
            this.adres.Name = "adres";
            this.adres.Width = 125;
            // 
            // prev
            // 
            this.prev.DataPropertyName = "prev";
            this.prev.HeaderText = "Превышение";
            this.prev.MinimumWidth = 6;
            this.prev.Name = "prev";
            this.prev.Width = 125;
            // 
            // proba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Name = "proba";
            this.Text = "Список данных о нарушителях ПДД, зафиксированный камерой";
            this.Load += new System.EventHandler(this.proba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn region;
        private System.Windows.Forms.DataGridViewTextBoxColumn adres;
        private System.Windows.Forms.DataGridViewTextBoxColumn prev;
        private System.Windows.Forms.DataGridViewTextBoxColumn statya;
        private System.Windows.Forms.DataGridViewTextBoxColumn naim_narush;
        private System.Windows.Forms.DataGridViewTextBoxColumn summin;
        private System.Windows.Forms.DataGridViewTextBoxColumn summax;
        private System.Windows.Forms.DataGridViewTextBoxColumn skorostmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn skorostmax;
        private System.Windows.Forms.DataGridViewTextBoxColumn fixcamera;
    }
}