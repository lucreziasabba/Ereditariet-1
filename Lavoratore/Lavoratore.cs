using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    public class Lavoratore : Persona
    {
        public double Stipendio { get; set; }

        public Lavoratore(double s)
        {
            Nome = base.Nome;
            Cognome = base.Cognome;
            Stipendio = s;
            DataNascita = base.DataNascita;
        }
    }
}
