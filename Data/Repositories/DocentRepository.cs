using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tussentijdsexamen.Data.Repositories
{
    public class DocentRepository: IDocentRepository
    {
        // Zet de volgende code uit commentaar wanneer je de models hebt geprogrammeerd:
        private List<Docent> Docenten = new()
        {
            new Docent() { Voornaam = "Jan", Achternaam = "de Vries", Id = 1},
            new Docent() { Voornaam = "Sophie", Achternaam = "Jansen", Id = 2 },
            new Docent() { Voornaam = "Mark", Achternaam = "van Dijk", Id = 3},
        };
        public List<Docent> GetDocenten()
        {
            return Docenten;
        }
        public Docent GetById(int id)
        {
            foreach (var item in Docenten)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
