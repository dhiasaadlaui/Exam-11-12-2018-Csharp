using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExamCore
{
    public static class ProjetExt
    {
        public static void AjoutProjet(this GestionProjet gp, Projet p)
        {
            gp.Projets.Add(p);
        }
    }
}
