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
    public partial class nar : Form
    {
        public nar()
        {
            InitializeComponent();
        }

        private void nar_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoDataSet2.nar". При необходимости она может быть перемещена или удалена.
            this.narTableAdapter.Fill(this.autoDataSet2.nar);

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

        private void button1_Click(object sender, EventArgs e)
        {

            searhnar newForm = new searhnar();
            newForm.Owner = this;
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addnar newForm = new addnar();
            newForm.Owner = this;
            newForm.Show();
        }
    }
}
