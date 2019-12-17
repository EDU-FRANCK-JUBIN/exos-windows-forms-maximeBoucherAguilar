using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding1
{
    public class Chanson
    {
        public string nomArtiste;
        public string titreChanson;

        public Chanson(string nomArtiste, string titreChanson)
        {
            this.nomArtiste = nomArtiste;
            this.titreChanson = titreChanson;
        }
    }
}
