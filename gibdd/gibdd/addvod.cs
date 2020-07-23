using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace gibdd
{
    public partial class addvod : Form
    {
        public addvod()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Debug.Assert(Owner != null, nameof(Owner) + " != null");
            vod main = Owner as vod;
            if (main != null)
            {
                DataRow nRow = main.autoDataSet.Tables[0].NewRow();

                nRow[0] = tbinn.Text;
                nRow[1] = tbfio.Text;
                nRow[2] = tbad.Text;


                main.autoDataSet.Tables[0].Rows.Add(nRow);
                main.vodTableAdapter.Update(main.autoDataSet.vod);
                main.autoDataSet.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
                tbinn.Text = "";
                tbfio.Text = "";
                tbad.Text = "";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addvod_Load(object sender, EventArgs e)
        {

        }
    }
}
