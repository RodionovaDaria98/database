using System;
using System.Windows.Forms;

namespace gibdd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void автомобилиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            car newForm = new car();
            newForm.Owner = this;
            newForm.Show();
        }

        private void водителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
          vod newForm = new vod();
            newForm.Owner = this;
            newForm.Show();
        }

        private void нарушенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nar newForm = new nar();
            newForm.Owner = this;
            newForm.Show();
        }

        private void нарушенияВодителейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            narv newForm = new narv();
            newForm.Owner = this;
            newForm.Show();
        }

        private void названиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            otchot newForm = new otchot();
            newForm.Owner = this;
            newForm.Show(); 
        }

        private void данныеСКамерНаблюденияToolStripMenuItem1_Click(object sender, EventArgs e)
        { cam newForm = new cam();
            newForm.Owner = this;
            newForm.Show();
        }

        private void списокНарушителейПДДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            proba newForm = new proba();
            newForm.Owner = this;
            newForm.Show();
        }

        private void пробаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            proba newForm = new proba();
            newForm.Owner = this;
            newForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
