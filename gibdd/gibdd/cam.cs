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
    public partial class cam : Form
    {
        public cam()
        {
            InitializeComponent();
        }

        private void cam_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cameraDataSet.camera". При необходимости она может быть перемещена или удалена.
            this.cameraTableAdapter.Fill(this.cameraDataSet.camera);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
