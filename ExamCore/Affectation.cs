using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCore
{
    public class Affectation
    {
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public float Prix { get; set; }
        public Ingenieur Ingenieur { get; set; }
        public Projet Projet { get; set; }

        public Affectation(DateTime dateDebut, DateTime dateFin, float prix, Ingenieur ingenieur)
        {
            DateDebut = dateDebut;
            DateFin = dateFin;
            Prix = prix;
            Ingenieur = ingenieur;
        }

        public Affectation()
        {
            
        }
        public static float operator +(Affectation A1, Affectation A2)
        {
            float tot = 0;
           
                tot = A1.Prix + A2.Prix;
            
            return tot;
        }

    }
}
