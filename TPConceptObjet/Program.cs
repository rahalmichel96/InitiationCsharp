using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPConceptObjet
{
    class Program
    {
        static void Main(string[] args)
        {
            Personnel p = new Personnel();
            p.AjouterEmploye(new EmployeVente("Pierre", "Business", 45, new DateTime(1999,12,31), 30000));
            p.AjouterEmploye(new EmployeRepresentation("Léon", "Vendtout", 25, new DateTime(2001, 12, 31), 20000));
            p.AjouterEmploye(new EmployeProduction("Yves", "Bosseur", 28, new DateTime(1998, 12, 31), 1000));
            p.AjouterEmploye(new EmployeManutention("Jeanne", "Stocketout", 32, new DateTime(1998, 12, 31), 45));
            p.AjouterEmploye(new EmployeProductionRisque("Jean", "Flippe", 28, new DateTime(2000, 12, 31), 1000));
            p.AjouterEmploye(new EmployeManutentionRisque("Al", "Abordage", 30, new DateTime(2001, 12, 31), 45));
            p.CalculerSalaires();
            Console.WriteLine("Le salaire moyen dans l'entreprise est de " + p.SalaireMoyen() + " Euros.");
            //garder la console ouverte (en attendant d'appuyer sur une touche)
            Console.ReadKey();
        }
    }
}
