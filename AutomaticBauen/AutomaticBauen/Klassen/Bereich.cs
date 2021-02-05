﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticBauen.Klassen
{
    public class Bereich
    {
        private string name;
        private List<Flaeche> listflaechen = new List<Flaeche>();
        public string Name{ get { return name; } }

        public Bereich(string bereichname)
        {
            name = bereichname;
        }

        public bool Rename(string newname)
        {
            bool ret = false;

            if(true) //Überprüfen ob name so übernommen werden kann
            {
                name = newname;
                ret = true;
            }

            return ret;
        }

        public bool AddNewFlaeche(Flaeche newflaeche)
        {
            bool ret = false;

            listflaechen.Add(newflaeche);

            return ret;
        }
    }
}