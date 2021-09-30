using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPConceptObjet
{
    public abstract class Employe
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }
        public DateTime Entree { get; set; }

        public Employe(string nom, string prenom, int age, DateTime entree)
        {
            Nom = nom;
            Prenom = prenom;
            Age = age;
            Entree = entree;
        }

        public abstract double CalculerSalaire();
        
        public virtual string GetNom()
        {
            return $"L'employé {Prenom} {Nom}"; 
        }
    }
}
