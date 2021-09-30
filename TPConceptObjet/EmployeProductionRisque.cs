using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPConceptObjet
{
    public class EmployeProductionRisque : EmployeProduction
    {
        public static double PRIME_MENSUELLE { get; set; } = 200;
        public EmployeProductionRisque(string nom, string prenom, int age, DateTime entree, int nbUnitesProduites) : base(nom, prenom, age, entree, nbUnitesProduites)
        {
        }

        public override double CalculerSalaire()
        {
            return base.CalculerSalaire() + PRIME_MENSUELLE;
        }
    }
}
