using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticBauen.Klassen
{
    class Projekt
    {
        private string name;
        List<Bereich> bereiche = new List<Bereich>();
        

        public Projekt(string projektname)
        {
            name = projektname;
        }

        public bool Load(string pfad)
        {
            bool ret = false;

            return ret;
        }

        public bool Save(string pfad)
        {
            bool ret = false;


            return ret;
        }

    }
}
