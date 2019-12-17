using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding1
{
    class Artiste
    {
        public string nom;
        public List<Chanson> listChanson = new List<Chanson>();
        
        public Artiste(string nom)
        {
            this.nom = nom;
        }
    }
}
