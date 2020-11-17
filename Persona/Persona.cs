using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    public class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataNascita { get; set; }

        public Persona(string n, string c, DateTime d)
        {
            Nome = n;
            Cognome = c;
            DataNascita = d;
        }
    }
}
