using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCore
{
    public class ChefProjet: Personne

    {
        public DateTime DatePriseFn { get; set; }
        public int Experiance { get; set; }
        public List<Projet> Projets { get; set; }

        public ChefProjet()
        {
            
        }

        public ChefProjet(int id, string nom, string prenom, string email,DateTime datePriseFn, int experiance, List<Projet> projets)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Email = email;
            DatePriseFn = datePriseFn;
            Experiance = experiance;
            Projets = projets;
        }
        public ChefProjet(DateTime datePriseFn, int experiance, List<Projet> projets)
        {
            DatePriseFn = datePriseFn;
            Experiance = experiance;
            Projets = projets;
        }
    }
}
