using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCore
{
  public  class Personne
    {
        public int Id { get; set; }
        public String Nom { get; set; }
        public String Prenom { get; set; }
        public String Email { get; set; }

        public Personne(int id, string nom, string prenom, string email)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Email = email;
        }
        public Personne()
        {
            
        }


        public override string ToString()
        {
            return "Id personne :" + Id +"nom personne :" + Nom + "prenom Personne :" + Prenom + "Email Personne :" + Email + "\n";
        }
    }
}
