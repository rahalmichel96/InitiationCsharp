using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPConceptObjet
{
    public class Personnel
    {
        

        public List<Employe> Employes { get; set; }

        public Personnel()
        {
            Employes = new List<Employe>();
        }

        public void AjouterEmploye(Employe e)
        {
            Employes.Add(e);
        }

        public void CalculerSalaires()
        {
            foreach (Employe e in Employes)
            {
                Console.WriteLine(e.GetNom() + " a pour salaire " + e.CalculerSalaire());
            }
        }

        public double SalaireMoyen()
        {
            double somme = 0;
            foreach (Employe e in Employes)
            {
                somme += e.CalculerSalaire();
            }

            return somme / Employes.Count;
        }
    }
}
