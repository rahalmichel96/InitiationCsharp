using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPConceptObjet
{
    public class EmployeManutention : Employe
    {
        public double NbHeures { get; set; }
        public static double TAUX_HORAIRE { get; set; } = 65;


        public EmployeManutention(string nom, string prenom, int age, DateTime entree, double nbHeures) : base(nom, prenom, age, entree)
        {
            NbHeures = nbHeures;
        }

        public override double CalculerSalaire()
        {
            return NbHeures * TAUX_HORAIRE;
        }

        public override string GetNom()
        {
            return $"L'employé en manutention {Prenom} {Nom}";
        }
    }
}
