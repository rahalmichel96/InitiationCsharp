using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPConceptObjet
{
    public class EmployeProduction : Employe
    {
        public int NbUnitesProduites { get; set; }
        public static double PRIX_UNITE { get; set; } = 5;

        public EmployeProduction(string nom, string prenom, int age, DateTime entree, int nbUnitesProduites) : base(nom, prenom, age, entree)
        {
            NbUnitesProduites = nbUnitesProduites;
        }

        public override double CalculerSalaire()
        {
            return NbUnitesProduites * PRIX_UNITE;
        }

        public override string GetNom()
        {
            return $"L'employé en production {Prenom} {Nom}";
        }
    }
}
