using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace gibdd
{
    public partial class addcar : Form
    {
        public addcar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Debug.Assert(Owner != null, nameof(Owner) + " != null");
            car main = Owner as car;
            if (main != null)
            {
                DataRow nRow = main.autoDataSet3.Tables[0].NewRow();

                nRow[0] = tbn.Text;
                nRow[1] = tbr.Text;
                nRow[2] = tby.Text;
                nRow[3] = tbinn.Text;

                main.autoDataSet3.Tables[0].Rows.Add(nRow);
                main.carTableAdapter.Update(main.autoDataSet3.car);
                main.autoDataSet3.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
                tbn.Text = "";
                tbr.Text = "";
                tby.Text = "";
                tbinn.Text = "";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addcar_Load(object sender, EventArgs e)
        {

        }
    }
}
