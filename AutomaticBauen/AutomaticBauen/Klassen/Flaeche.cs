using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticBauen.Klassen
{
    public enum Flaechenart
    {
        InnereWaendeBrutto,
        InnereWaendeNetto,
        Bodenflaechebrutto,
        Bodenflaechenetto,
        Fenster,
        BalkonflaecheBrutto,


    }

    public class Flaeche
    {
        private string name;
        private int flaeche;
        Flaechenart flaechentyp;
        public int seite1;
        public int seite2;

        public Flaeche(string newname, Flaechenart flaechenart)
        {
            name = newname;
            flaechentyp = flaechenart;
        }

        public Flaechenart Flaechentyp { get { return flaechentyp; } }

        public int Ergebnis {
            get
            {
                if (seite1 != 0 && seite2 != 0)
                {
                    return flaeche = seite1 * seite2;
                }
                else
                {
                    return 0;
                }
            }
        }

    }
}
