using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AutomaticBauen.Klassen
{
    public class Projekt
    {
        private string name;
        public ObservableCollection<Bereich> bereiche = new ObservableCollection<Bereich>();

        public string Name { get { return name; } set { name = value; } }

        public bool AddBereich(string newbereichname)
        {
            bool ret = false;

            var item = bereiche.FirstOrDefault(x => x.Name == newbereichname);

            if (item != null)
            {
                ret = false;
            }
            else
            {
                Bereich newbereich = new Bereich();
                newbereich.Name = newbereichname;
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

        

    }
}
