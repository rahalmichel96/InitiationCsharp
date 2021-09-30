using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPConceptObjet
{
    public class EmployeVente : Commercial
    {
        public static double POURCENT_VENDEUR { get; set; } = 0.2;
        public static double BONUS_VENDEUR { get; set; } = 400;

        public EmployeVente(string nom, string prenom, int age, DateTime entree, double chiffreAffaires) : base(nom, prenom, age, entree, chiffreAffaires)
        {
        }

        public override double CalculerSalaire()
        {
            return POURCENT_VENDEUR * ChiffreAffaires + BONUS_VENDEUR;
        }

        public override string GetNom()
        {
            return $"L'employé en vente {Prenom} {Nom}";
        }
    }
}
