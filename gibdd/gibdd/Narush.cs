using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace gibdd
{
    class Narush
    {
        
        public string statya { get; set; }
        public string naim_narush { get; set; }
        public string summin { get; set; }
        public string summax { get; set; }

        public string skorostmin { get; set; }

        public string skorostmax { get; set; }
        
        public string fixcamera { get; set; }
        public Narush(string statya, string naim_narush, string summin, string summax, string skorostmin, string skorostmax, string fixcamera)
        {
            this.statya = statya;
            this.naim_narush = naim_narush;
            this.summin = summin;
            this.summax = summax;
            this.skorostmin = skorostmin;
            this.skorostmax= skorostmax;
            this.fixcamera = fixcamera;


        }


        
    }
}
