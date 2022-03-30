using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvionKlasa
{
    internal class Avion
    {
        public string ImeObjekta { get; set; }
        public int BrojPutnika { get; set; }
        public string NazivKompanije { get; set; }
        public double SirinaKrila { get; set; }
         public void Poletanje ()

    {
        

           
            {
                Console.WriteLine(ImeObjekta + " kompanije " + NazivKompanije + " se sprema za poletanje");
            }
    }
        public void Letenje ()
        {
            Console.WriteLine(SirinaKrila + " je sirina krila " + " broj putnika je " + BrojPutnika + ImeObjekta + " trenutno leti");
        }
        public void Sletanje ()
        {
            Console.WriteLine(ImeObjekta + " se sprema za sletanje");
        }
        public void Parkiranje ()
        {
            Console.WriteLine(BrojPutnika + " putnika je bezbedno sletelo " + NazivKompanije + " Vam zeli ugodan dan");
        }
    }
   


}
