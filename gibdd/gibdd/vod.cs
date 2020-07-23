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
    public partial class vod : Form
    {
        public vod()
        {
            InitializeComponent();
        }

        private void vod_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoDataSet.vod". При необходимости она может быть перемещена или удалена.
            this.vodTableAdapter.Fill(this.autoDataSet.vod);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            searhvod newForm = new searhvod();
            newForm.Owner = this;
            newForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addvod newForm = new addvod();
            newForm.Owner = this;
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.vodTableAdapter.Update(this.autoDataSet.vod);
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
