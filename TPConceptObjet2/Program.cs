using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPConceptObjet2
{
    class Program
    {
        static void Main(string[] args)
        {
            Salarie dev = new Dev("dev", 25, 2500, null);
            //Message d'erreur
            dev.ModifierSalaire(dev, 4000);
            Console.WriteLine(dev.Salaire);
            Salarie m = new Manager("mana", 30, 4000);
            m.ModifierSalaire(dev, 3500);
            Console.WriteLine(dev.Salaire);
            Console.ReadKey();
        }
    }
}
