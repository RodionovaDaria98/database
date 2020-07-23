using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gibdd
{
    public partial class narv : Form
    {
        public narv()
        {
            InitializeComponent();
        }

        private void narv_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoDataSet1.narv". При необходимости она может быть перемещена или удалена.
            this.narvTableAdapter.Fill(this.autoDataSet1.narv);

        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.narvTableAdapter.Update(this.autoDataSet1.narv);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            searhnarv newForm = new searhnarv();
            newForm.Owner = this;
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addnarv newForm = new addnarv();
            newForm.Owner = this;
            newForm.Show();
        }
    }
}
