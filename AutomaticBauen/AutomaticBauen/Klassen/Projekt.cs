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

        public bool AddBereich(string newbereichname)
        {
            bool ret = false;
            bool bereichname_alreadyexist= false;
            
            foreach(var i in bereiche)
            {
                if(i.Name == newbereichname)
                {
                    bereichname_alreadyexist = true;
                }
            }

            if(bereichname_alreadyexist == true)
            {
                ret = false;
            }
            else
            {
                Bereich newbereich = new Bereich(newbereichname);
                bereiche.Add(newbereich);
                ret = true;
            }

            return ret;
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
