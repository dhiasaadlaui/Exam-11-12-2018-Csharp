using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCore
{
    public enum Specialite { GL, BI, CLOUD, EMBARQUE, RESEAU, TELECOME }
  public  class Ingenieur : Personne
    {
        public Specialite Specialite { get; set; }
        public List<Affectation> Affectations { get; set; }

        public Ingenieur(Specialite specialite)
        {
            Affectations = new List<Affectation>();
            Specialite = specialite;
        }

        public Ingenieur(int id, string nom, string prenom, string email,Specialite specialite, List<Affectation> affectations)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Email = email;
            Specialite = specialite;
            Affectations = affectations;
        }
        public Ingenieur()
        {
            Affectations = new List<Affectation>();
        }
    }

}
