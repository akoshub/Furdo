using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrandC
{
    public class Furdo
    {
        public Furdo(string nev, string cim, int ar, int vizhofok)
        {
            Nev = nev;
            Cim = cim;
            Ar = ar;
            Vizhofok = vizhofok;
        }

        public Furdo(string sor)
        {
            string[] elemek = sor.Split(';');
            Nev = elemek[0];
            Cim = elemek[1];
            Ar = int.Parse(elemek[2]);
            Vizhofok = int.Parse(elemek[3]);
        }

        public string Nev { get; private set; }
        public string Cim { get; private set; }
        public int Ar { get; private set; }
        public int Vizhofok { get; private set; }

        public string IRSZ()
        {
            string[] cimek = Cim.Split(' ');

            return cimek[0];
        }

        public string Telepules()
        {
            string[] cimek = Cim.Split(' ');
            return cimek[1].Substring(0, cimek[1].Length - 1);
        }
    }
}
