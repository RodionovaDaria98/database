using System;

namespace gibdd
{
    class Violator
    {
      
    
  

        public string inn { get; set; }
        public string fio { get; set; }
        public string adres { get; set; }
        public DateTime data { get; set; }
        public string nomer { get; set; }
        public string region { get; set; }
        public string statya { get; set; }
       
        public string sum { get; set; } 
        public string nn { get; set; }


        public Violator(string inn, string fio, string adres, DateTime data, string nomer,string region,  string statya, string sum, string nn)
        {
            this.inn = inn;
            this.fio = fio;
            this.adres = adres;
            this.data = data;
            this.nomer = nomer;
            this.region = region;
            this.statya = statya;
            this.sum = sum;
            this.nn=nn;


        }

     
    }
}