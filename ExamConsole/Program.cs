using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using ExamCore;

namespace ExamConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            GestionProjet gs = new GestionProjet();

            Ingenieur j1 = new Ingenieur()
            {
                Id =  1,
                Nom = "Dhia",
                Prenom = "Saadlaui",
                Email = "dhiasaadlaui@gmail.com",Specialite = Specialite.GL
            };
            Ingenieur j2 = new Ingenieur()
            {
                Id = 1,
                Nom = "Amal",
                Prenom = "aaaaaaaaaaaa",
                Email = "aaaaaaaaaaaa",
                Specialite = Specialite.GL
            };

            Ingenieur j3 = new Ingenieur()
            {
                Id = 1,
                Nom = "Dhia",
                Prenom = "Saadlaui",
                Email = "dhiasaadlaui@gmail.com",
                Specialite = Specialite.GL
            };

            Ingenieur j4 = new Ingenieur()
            {
                Id = 1,
                Nom = "Dhia",
                Prenom = "Saadlaui",
                Email = "dhiasaadlaui@gmail.com",
                Specialite = Specialite.GL
            };
            ChefProjet cf1 = new ChefProjet()
            {
                // here to fill object props
            };
            ChefProjet cf2 = new ChefProjet()
            {
                // here to fill object props
            };
            Affectation af1 = new Affectation()
            {
                // here to fill object props

            };
            Affectation af2 = new Affectation()
            {
                // here to fill object props
            };
           
            //TO TEST Extension Method
          //  gs.AjoutProjet(new Projet(){Nom = "projet1"});

            // METHOD 1
            
            var Query =
                from AFF in gs.Affectations
                join chef in gs.ChefProjets on AFF.Projet.chef equals chef
                group AFF by AFF.Projet into g
                where g.Key.chef.Experiance > 7
                select g; 


            foreach (var aff in Query)
            {
                Console.WriteLine(aff.GetEnumerator());
            }
            // METHOD 2
            var innerJoinQuery =
                from chef in gs.ChefProjets
                where chef.Experiance>7
                select chef;
            

            foreach (var chef in innerJoinQuery)
            {
                foreach (var projet in chef.Projets)
                {
                    Console.WriteLine(gs.Affectations.FindAll(affectation => affectation.Projet == projet));               
                }
            }

            Console.ReadKey();

        }
    }
}
