using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasGit
{
    public class Ciutat
    {
        public string Nom { get; set; }
        public string CP { get; set; }

        public Ciutat(string nom, string cp)
        {
            Nom = nom;
            CP = cp;
        }

        public override string ToString()
        {
            return $"Ciutat: {Nom}, CP: {CP}";
        }
    }
}
