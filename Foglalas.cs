using System;
using System.Collections.Generic;
using System.Text;

namespace TeniszpalyaFoglalas
{
    public class Foglalas
    {
        public string JatekosNev { get; set; }
        public int FoglaltOrak { get; set; }
        public int BereltUtoDb { get; set; }

       public Foglalas(string sor)
        {
            string[] darabol=sor.Split(';');
            JatekosNev= darabol[0];
            FoglaltOrak=int.Parse(darabol[1]);
            BereltUtoDb=int.Parse(darabol[2]);
        }
        public int FizetendoDij()
        {
            return FoglaltOrak * 3500 + BereltUtoDb * 800;
        }
        public override string ToString()
        {
            return $"{JatekosNev}: {FoglaltOrak} óra, {BereltUtoDb} db bérelt ütő - Fizetendő: {FizetendoDij()} Ft";
        }
    }
    
}
