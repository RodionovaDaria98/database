using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


namespace gibdd
{
    public partial class otchot : Form
    {

        public otchot()
        {
            InitializeComponent();
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadData()
        {

        }

        private void otchot_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var listOfViolator = new List<Violator>();
            var toVoditeli = Properties.Settings.Default.vodconstring;
            using (var conn = new SqlConnection(toVoditeli))
            {
                var cmd = new SqlCommand(
                    "SELECT vod.[ФИО] , vod.[ИНН], vod.[Адрес],  narv.[Дата]," +
                    " narv.[Номер_авто], narv.[Регион], narv.[Статья],  nar.[Наим_наруш], narv.[Сумма] " +
                    "FROM  vod    inner join  car   on car.[ИНН] = vod.[ИНН] " +
                    " join narv on narv.[Номер_авто]=car.[Номер_авто] join nar on  narv.[Статья]=nar.[Статья]",
                    conn);

                conn.Open();
                using (SqlDataReader result1 = cmd.ExecuteReader())
                {
                    while (result1.Read())
                    {
                        var myString = result1.safeGetString(1);
                        var str = result1.safeGetString(0);
                        var st = result1.safeGetString(2);
                        var std = result1.GetDateTime(3);
                        var stn = result1.safeGetString(4);
                        var streg = result1.safeGetString(5);
                        var sts = result1.safeGetString(6);
                        var stsum = result1.safeGetString(8);
                        var stnn = result1.safeGetString(7);
                        var narushitel = new Violator(myString, str, st, std, stn, streg, sts, stsum, stnn);



                        listOfViolator.Add(narushitel);

                    }
                    conn.Close();
                }






                dataGridView1.DataSource = listOfViolator;
            }
        }

               







       

            /*private void button3_Click(object sender, EventArgs e)
            {
                otchot main = this.Owner as otchot;
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
            }*/
        
    }
}