using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    public class Docente : Lavoratore
    {
        private string Materia { get; set; }
        public List<Studente> Studenti { get; private set; } = new List<Studente>();

        public Docente(string m)
        {
            Nome = base.Nome;
            Cognome = base.Cognome;
            Materia = m;
            Stipendio = base.Stipendio;
            DataNascita = base.DataNascita;
        }

        public void AddStudente(Studente stud)
        {
            Studenti.Add(stud);
        }
    }
}
