using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gibdd
{
    class Voditel
    {
        public string inn { get; set; }
        public  string fio { get; set; }
        public string adres { get; set; }
        public string nomer { get; set; }
        public string region { get; set; }

        public Voditel(string inn, string fio, string adres, string nomer, string region)
        {
            this.inn = inn;
            this.fio = fio;
            this.adres = adres;
            this.nomer = nomer;
            this.region = region; 
        }
    }
}
