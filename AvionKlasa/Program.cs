using System;

namespace AvionKlasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var avion=new Avion();
            avion.ImeObjekta = "Avio";

            avion.BrojPutnika = 140;
            avion.NazivKompanije = "Air Serbia";
            avion.SirinaKrila = 15.32;
            Console.WriteLine(avion.ImeObjekta + " ima " + avion.BrojPutnika + " broj putnika " + avion.SirinaKrila + " su mu sirina krila " + avion.NazivKompanije + " je naziv kompanije");

            var helikopter = new Avion();
             helikopter.ImeObjekta = "Helikopter";
            Console.WriteLine(helikopter.ImeObjekta);
        }
    }
}
