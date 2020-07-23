using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gibdd
{
    class Camera1
    {
        public string region { get; set; }
        public string nomer { get; set; }
        public DateTime data { get; set; }
        public string prev { get; set; }

        public Camera1(string region, string nomer, DateTime data, string prev)
        {
            this.region = region;
            this.nomer = nomer;
            this.data = data;
            this.prev = prev;


        }

      
    }
}
