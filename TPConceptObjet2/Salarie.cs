using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPConceptObjet2
{
    public abstract class Salarie
    {
        public string Nom { get; set; }
        private int age;
        public int Age { 
            get { return age; } 
            set
            {
                if (value >= 18 && value <= 62)
                {
                    age = value;
                } else if (value < 18)
                {
                    Console.WriteLine("Le candidat est trop jeune");
                } else
                {
                    Console.WriteLine("Le candidat est trop vieux");
                }
            }
        }
        private double salaire;
        public double Salaire { 
            get { return salaire; }
            private set
            {
                if (value >= 2000)
                {
                    salaire = value;
                } else 
                {
                    Console.WriteLine("Le salaire est inférieur au salaire minimum");
                }
            } 
        }
        public Boolean EstPresent { get; set; }

        public Salarie(string nom, int age, double salaire)
        {
            Nom = nom;
            Age = age;
            Salaire = salaire;
            EstPresent = false;
        }

        public void Pointer()
        {
            EstPresent = !EstPresent;
        }

        public override bool Equals(object obj)
        {
            Salarie s = (Salarie)obj;
            return s.Nom.Equals(this.Nom);
        }

        public void ModifierSalaire(Salarie s, double salaire)
        {
            if (this is Manager)
            {
                s.Salaire = salaire;
            }
            else
            {
                Console.WriteLine("Seul un manager a le droit de modifier un salaire");
            }
        }
    }
}
