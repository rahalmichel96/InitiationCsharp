using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPConceptObjet
{
    public abstract class Commercial : Employe
    {
        public double ChiffreAffaires { get; set; }
        public Commercial(string nom, string prenom, int age, DateTime entree, double chiffreAffaires) : base(nom, prenom, age, entree)
        {
            ChiffreAffaires = chiffreAffaires;
        }
    }
}
