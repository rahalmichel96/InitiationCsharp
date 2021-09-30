using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPConceptObjet
{
    public class EmployeManutentionRisque : EmployeManutention
    {
        public static double PRIME_MENSUELLE { get; set; } = 200;
        public EmployeManutentionRisque(string nom, string prenom, int age, DateTime entree, double nbHeures) : base(nom, prenom, age, entree, nbHeures)
        {
        }

        public override double CalculerSalaire()
        {
            return base.CalculerSalaire() + PRIME_MENSUELLE;
        }
    }
}
