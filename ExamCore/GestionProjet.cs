using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCore
{
   public sealed class GestionProjet
    {
        public List<Affectation> Affectations { get; set; }
        public List<Projet> Projets { get; set; }
        public List<ChefProjet> ChefProjets { get; set; }

        public int countGlErp()
        {

           return  Projets
               .Find(projet => projet.Nom=="ERP")
               .Affectations
               .Count(affectation => affectation.Ingenieur.Specialite == Specialite.GL);
        }

        public float totalPrimes()
        {
            return Affectations
                .FindAll(affectation => (affectation.DateDebut.Year == 2017)&& (affectation.DateFin < affectation.Projet.Deadline))
                .Sum(affectation => totalPrimes() *  0.001f);

        }

      

        public Projet TrouverProjet(String nom)
        {
            foreach (var projet in Projets)
            {
                if (projet.Nom == nom)
                {
                    return projet;
                }
                
            }
            throw new ProjetIntrouvable();
        }

    }
}
