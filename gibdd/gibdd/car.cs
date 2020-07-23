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
    public partial class car : Form
    {
        public car()
        {
            InitializeComponent();
        }

        private void car_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoDataSet3.car". При необходимости она может быть перемещена или удалена.
            this.carTableAdapter.Fill(this.autoDataSet3.car);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.carTableAdapter.Update(this.autoDataSet3.car);
        }

        private void button2_Click(object sender, EventArgs e)
        {
             addcar newForm = new addcar();
            newForm.Owner = this;
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            searhcar newForm = new searhcar();
            newForm.Owner = this;
            newForm.Show();
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
