using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace gibdd
{
    public partial class addnarv : Form
    {
        public addnarv()
        {
            InitializeComponent();
        }

        private void addnarv_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Debug.Assert(Owner != null, nameof(Owner) + " != null");
            narv main = Owner as narv;
            DataRow nRow = main.autoDataSet1.Tables[0].NewRow();
            if (main != null)
            {
               
                nRow[0] = tbn.Text;
                nRow[1] = tbr.Text;
                nRow[2] = tbs.Text;
                nRow[3] = tbd.Text;
                nRow[4] = tbsum.Text;

                main.autoDataSet1.Tables[0].Rows.Add(nRow);
                main.narvTableAdapter.Update(main.autoDataSet1.narv);
                main.autoDataSet1.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
               
                tbn.Text = "";
                tbr.Text = "";
                tbs.Text = "";
                tbd.Text = "";
                tbsum.Text = "" ;

            }
        }
    }
}
