using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tussentijdsexamen.Data.Repositories
{
    public class StudentRepository: IStudentRepository
    {
        //Zet de volgende code uit commentaar wanneer je de models hebt geprogrammeerd:
        private List<Student> Studenten = new()
        {
            new Student() { Id = 1, Voornaam = "Lisa", Achternaam = "Bakker", DocentId = 1},
            new Student() { Id = 2,Voornaam = "Tom", Achternaam = "Verhoeven", DocentId = 1 },
            new Student() { Id = 3,Voornaam = "Emma", Achternaam = "Smit", DocentId = 1  },
            new Student() { Id = 4,Voornaam = "Daan", Achternaam = "Willems", DocentId = 2 },
            new Student() { Id = 5,Voornaam = "Julia", Achternaam = "de Groot", DocentId = 2 },
            new Student() { Id = 6,Voornaam = "Max", Achternaam = "Peters", DocentId = 3 },
            new Student() { Id = 7,Voornaam = "Sanne", Achternaam = "Mulder", DocentId = 3 },
         };
        public List<Student> GetStudenten()
        {
            return Studenten;
        }
        public List<Student> GetByDocentId(int docentId)
        {
            List<Student> studenten = new();
            foreach (var item in Studenten)
            {
                if (item.DocentId == docentId)
                {
                    studenten.Add(item);
                }
            }
            return studenten;
        }
    }
}
