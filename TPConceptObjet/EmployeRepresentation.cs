using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPConceptObjet
{
    public class EmployeRepresentation : Commercial
    {
        public static double POURCENT_REPRESENTANT { get; set; } = 0.2;
        public static double BONUS_REPRESENTANT { get; set; } = 800;

        public EmployeRepresentation(string nom, string prenom, int age, DateTime entree, double chiffreAffaires) : base(nom, prenom, age, entree, chiffreAffaires)
        {
        }

        public override double CalculerSalaire()
        {
            return POURCENT_REPRESENTANT * ChiffreAffaires + BONUS_REPRESENTANT;
        }

        public override string GetNom()
        {
            return $"L'employé en représentation {Prenom} {Nom}";
        }
    }
}
