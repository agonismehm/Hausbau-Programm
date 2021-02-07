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
        InnereWaendeBrutto = 1,
        InnereWaendeNetto = 2,
        Bodenflaechebrutto = 3,
        Bodenflaechenetto = 4,
        Fenster = 5,
        BalkonflaecheBrutto = 6
    }

    public class Flaeche
    {
        private string name;
        private int flaeche;
        Flaechenart flaechentyp;
        private int seite1;
        private int seite2;

        public Flaeche(string newname, Flaechenart flaechenart)
        {
            name = newname;
            flaechentyp = flaechenart;
        }

        public Flaechenart Flaechentyp { get { return flaechentyp; } }

        public string Name{ get { return name; } }

        public int Seite1 { get { return seite1;} set { seite1 = value; } }

        public int Seite2 { get { return seite2; } set { seite2 = value; } }

        public int Ergebnis {
            get
            {
                if (seite1 != 0 && seite2 != 0)
                {
                    return flaeche = seite1 * seite2 / 100;
                }
                else
                {
                    return 0;
                }
            }
        }

    }
}
