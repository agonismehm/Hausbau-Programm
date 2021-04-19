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
        private Flaechenart flaechentyp;
        private int seite1;
        private int seite2;

        public Flaechenart Flaechentyp { get { return flaechentyp; } set { flaechentyp = value; } }

        public string Name{ get { return name; } set { name = value; } }

        public int Seite1 { get { return seite1;} set { seite1 = value; } }

        public int Seite2 { get { return seite2; } set { seite2 = value; } }

        public float Ergebnis {
            get
            {
                if (seite1 != 0 && seite2 != 0)
                {
                    return flaeche = seite1 * seite2 / 10000;
                }
                else
                {
                    return 0;
                }
            }
        }

    }
}
