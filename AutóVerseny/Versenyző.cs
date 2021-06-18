using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutóVerseny
{
    class Versenyző
    {
        public string Csapat { get; set; }
        public string Név { get; set; }
        public int Életkor { get; set; }
        public string Pálya { get; set; }
        public TimeSpan Köridő { get; set; }
        public int Kör { get; set; }

        public Versenyző(string sor)
        {
            string[] tmp = sor.Split(';');
            Csapat = tmp[0];
            Név = tmp[1];
            Életkor = int.Parse(tmp[2]);
            Pálya = tmp[3];
            Köridő = TimeSpan.Parse(tmp[4]);
            Kör = int.Parse(tmp[5]);
        }
    }
}
