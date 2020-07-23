namespace gibdd
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ведениеТаблицToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.водителиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.автомобилиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нарушенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нарушенияВодителейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.данныеСКамерНаблюденияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.названиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокНарушителейПДДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ведениеТаблицToolStripMenuItem,
            this.данныеСКамерНаблюденияToolStripMenuItem1,
            this.отчетыToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(997, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ведениеТаблицToolStripMenuItem
            // 
            this.ведениеТаблицToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.водителиToolStripMenuItem,
            this.автомобилиToolStripMenuItem,
            this.нарушенияToolStripMenuItem,
            this.нарушенияВодителейToolStripMenuItem});
            this.ведениеТаблицToolStripMenuItem.Name = "ведениеТаблицToolStripMenuItem";
            this.ведениеТаблицToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.ведениеТаблицToolStripMenuItem.Text = "Ведение таблиц";
            // 
            // водителиToolStripMenuItem
            // 
            this.водителиToolStripMenuItem.Name = "водителиToolStripMenuItem";
            this.водителиToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.водителиToolStripMenuItem.Text = "Водители";
            this.водителиToolStripMenuItem.Click += new System.EventHandler(this.водителиToolStripMenuItem_Click);
            // 
            // автомобилиToolStripMenuItem
            // 
            this.автомобилиToolStripMenuItem.Name = "автомобилиToolStripMenuItem";
            this.автомобилиToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.автомобилиToolStripMenuItem.Text = "Автомобили";
            this.автомобилиToolStripMenuItem.Click += new System.EventHandler(this.автомобилиToolStripMenuItem_Click);
            // 
            // нарушенияToolStripMenuItem
            // 
            this.нарушенияToolStripMenuItem.Name = "нарушенияToolStripMenuItem";
            this.нарушенияToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.нарушенияToolStripMenuItem.Text = "Штрафы ГИБДД";
            this.нарушенияToolStripMenuItem.Click += new System.EventHandler(this.нарушенияToolStripMenuItem_Click);
            // 
            // нарушенияВодителейToolStripMenuItem
            // 
            this.нарушенияВодителейToolStripMenuItem.Name = "нарушенияВодителейToolStripMenuItem";
            this.нарушенияВодителейToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.нарушенияВодителейToolStripMenuItem.Text = "Нарушения водителей ";
            this.нарушенияВодителейToolStripMenuItem.Click += new System.EventHandler(this.нарушенияВодителейToolStripMenuItem_Click);
            // 
            // данныеСКамерНаблюденияToolStripMenuItem1
            // 
            this.данныеСКамерНаблюденияToolStripMenuItem1.Name = "данныеСКамерНаблюденияToolStripMenuItem1";
            this.данныеСКамерНаблюденияToolStripMenuItem1.Size = new System.Drawing.Size(228, 24);
            this.данныеСКамерНаблюденияToolStripMenuItem1.Text = "Данные с камер наблюдения";
            this.данныеСКамерНаблюденияToolStripMenuItem1.Click += new System.EventHandler(this.данныеСКамерНаблюденияToolStripMenuItem1_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.названиеToolStripMenuItem,
            this.списокНарушителейПДДToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.отчетыToolStripMenuItem.Text = "Отчеты ";
            // 
            // названиеToolStripMenuItem
            // 
            this.названиеToolStripMenuItem.Name = "названиеToolStripMenuItem";
            this.названиеToolStripMenuItem.Size = new System.Drawing.Size(572, 26);
            this.названиеToolStripMenuItem.Text = "Список данных о нарушителях ПДД, зафиксированных инспектором";
            this.названиеToolStripMenuItem.Click += new System.EventHandler(this.названиеToolStripMenuItem_Click);
            // 
            // списокНарушителейПДДToolStripMenuItem
            // 
            this.списокНарушителейПДДToolStripMenuItem.Name = "списокНарушителейПДДToolStripMenuItem";
            this.списокНарушителейПДДToolStripMenuItem.Size = new System.Drawing.Size(572, 26);
            this.списокНарушителейПДДToolStripMenuItem.Text = "Список данных о нарушителях ПДД, зафиксированных камерой";
            this.списокНарушителейПДДToolStripMenuItem.Click += new System.EventHandler(this.списокНарушителейПДДToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::gibdd.Properties.Resources.гибдд;
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(991, 489);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 529);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Нарушение правил дорожного движения";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem названиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокНарушителейПДДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ведениеТаблицToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem водителиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem автомобилиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem нарушенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem нарушенияВодителейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem данныеСКамерНаблюденияToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

