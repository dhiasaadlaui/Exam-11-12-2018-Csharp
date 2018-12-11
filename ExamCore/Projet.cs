using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCore
{
    class Projet
    {
        public int Id { get; set; }
        public String Nom { get; set; }
        public DateTime Deadline { get; set; }
        public List<Affectation> Affectations { get; set; }

        public Projet()
        {
            Affectations = new List<Affectation>();
        }
        public Projet(int id, string nom, DateTime deadline)
        {
            Affectations = new List<Affectation>();
            Id = id;
            Nom = nom;
            Deadline = deadline;
        }

        public override string ToString()
        {
            return "nom projet :" + Nom + "\n";
        }
    }
}
