using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace gibdd
{
    public partial class addnar : Form
    {
        public addnar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Debug.Assert(Owner != null, nameof(Owner) + " != null");
            nar main = Owner as nar;
            if (main != null)
            {
                DataRow nRow = main.autoDataSet2.Tables[0].NewRow();

                nRow[0] = tbs.Text;
                nRow[1] = tbnn.Text;
                nRow[2] = tbmin.Text;
                nRow[3] = tbmax.Text;
                nRow[4] = tbspeedmin.Text;
                nRow[5] = tbspeedmax.Text;
                nRow[6] = tbfixcamera;


                main.autoDataSet2.Tables[0].Rows.Add(nRow);
                main.narTableAdapter.Update(main.autoDataSet2.nar);
                main.autoDataSet2.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
                tbs.Text = "";
                tbnn.Text = "";
                tbmin.Text = "";
                tbmax.Text = "";
                tbspeedmin.Text = "";
                tbspeedmax.Text = "";
                tbfixcamera.Text = "";


            }
        }

        private void addnar_Load(object sender, EventArgs e)
        {

        }
    }
}
