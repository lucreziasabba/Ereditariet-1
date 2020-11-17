using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    public class Studente : Persona
    {
        private string Classe { get; set; }

        public List<Docente> Docenti { get; private set; } = new List<Docente>();
        public object Nome { get; }
        public object Cognome { get; }
        public object DataNascita { get; }

        public Studente(string c)
        {
            Nome = base.Nome;
            Cognome = base.Cognome;
            DataNascita = base.DataNascita;
            Classe = c;
        }

        public void AddDocente(Docente doc)
        {
            Docenti.Add(doc);
        }
    }
}
