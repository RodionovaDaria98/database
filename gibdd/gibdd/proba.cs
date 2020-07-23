using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace gibdd
{
    public partial class proba : Form
    {
        public proba()
        {
            InitializeComponent();
        }

        private void proba_Load(object sender, EventArgs e)
        {
            var listofNarush = new List<Narush>();
            var toVoditeli = Properties.Settings.Default.vodconstring;
            using (var conn = new SqlConnection(toVoditeli))
            {

                var cmd2 = new SqlCommand(" SELECT *FROM nar ", conn);
                conn.Open();
                using (SqlDataReader result2 = cmd2.ExecuteReader())

                    while (result2.Read())
                    {
                        var sts = result2.GetString(0);
                        var stname = result2.GetString(1);
                        var stsmin = result2.GetString(2);
                        var stsmax = result2.safeGetString(3);



                        var spmin = result2.safeGetString(4);
                        var spmax = result2.safeGetString(5);

                        var fxc = result2.safeGetString(6);
                        var narush = new Narush(sts, stname, stsmin, stsmax, spmin, spmax, fxc);


                        listofNarush.Add(narush);
                    }
                conn.Close();
            }

            dataGridView3.DataSource = listofNarush;
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var listOfViolator = new List<Violator>();
            var listofCamera = new List<Camera1>();
            
            var listofVod = new List<Voditel>();
            var tocam = Properties.Settings.Default.CameraConnectionString1;
            var toVoditeli = Properties.Settings.Default.vodconstring;
            using (var conn = new SqlConnection(toVoditeli))
            {

                //var cmd = new SqlCommand("SELECT *FROM  vod    inner join narv  ON vod.ИНН= narv.ИНН");
                var cmd2 = new SqlCommand(" SELECT *FROM nar ", conn);
                var cmd3 = new SqlCommand(
                    "select vod.[ИНН], vod.[ФИО], vod.[Адрес], car.[Номер_авто] , car.[Регион]  from vod inner join car on car.[ИНН]=vod.[ИНН] ",
                    conn);
                conn.Open();

                using (SqlDataReader result3 = cmd3.ExecuteReader())
                {
                    while (result3.Read())
                    {
                        var stinn = result3.safeGetString(0);
                        var stfio = result3.safeGetString(1);
                        var stadr = result3.safeGetString(2);
                        var stnum = result3.safeGetString(3);
                        var str = result3.safeGetString(4);

                        var vodit = new Voditel(stinn, stfio, stadr, stnum, str);
                        listofVod.Add(vodit);
                    }
                }

                conn.Close();
            }
           

            using (var conn = new SqlConnection(tocam))
            {
                var cmd4 = new SqlCommand(
                    "SELECT camera.[Регион], camera.[Номер_авто],camera.[Дата], camera.[Превышение] FROM camera", conn);

                conn.Open();
                using (SqlDataReader result4 = cmd4.ExecuteReader())
                {
                    while (result4.Read())
                    {
                        var str = result4.GetString(0);
                        var stnum = result4.safeGetString(1);
                        var stdata = result4.GetDateTime(2);
                        var stprev = result4.safeGetString(3);
                        var camera = new Camera1(str, stnum, stdata, stprev);
                        listofCamera.Add(camera);
                    }
                }

                conn.Close();
            }




            var res = from Cam in listofCamera
                join vod in listofVod on Cam.nomer equals vod.nomer
                select new {Cam.nomer, Cam.region, vod.adres, Cam.prev};

            //  foreach (var v in res)
            // {
            //       Console.WriteLine(v.vod.fio + ":" + v.Cam.nomer + ":"+ v.Cam.region + ":"+v.vod.adres+":"+v.Cam.prev);


            // }



            dataGridView2.AutoGenerateColumns = true;
            dataGridView2.DataSource = res.ToList();

           

        }
    }
}


