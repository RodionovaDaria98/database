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
    public partial class searhcar : Form
    {
        public searhcar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

             car  main = this.Owner as car;
            if (main != null)
            {
                for (int i = 0; i < main.dataGridView1.RowCount; i++)
                {
                    main.dataGridView1.Rows[1].Selected = false;
                    for (int j = 0; j < main.dataGridView1.ColumnCount; j++)
                        if (main.dataGridView1.Rows[i].Cells[j].Value != null)
                            if (main.dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(tbstr.Text))
                            {
                                main.dataGridView1.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void searhcar_Load(object sender, EventArgs e)
        {

        }
    }
}
