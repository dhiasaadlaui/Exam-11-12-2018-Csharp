using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCore
{
    class ChefProjet: Personne

    {
        public DateTime DatePriseFn { get; set; }
        public int Experiance { get; set; }

        public ChefProjet()
        {
            
        }

        public ChefProjet(DateTime datePriseFn, int experiance)
        {
            DatePriseFn = datePriseFn;
            Experiance = experiance;
        }

    }
}
