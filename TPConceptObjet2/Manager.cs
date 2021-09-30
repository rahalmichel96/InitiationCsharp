using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPConceptObjet2
{
    public class Manager : Salarie
    {
        public List<Salarie> Salaries { get; set; }
        public Manager(string nom, int age, double salaire) : base(nom, age, salaire)
        {
            Salaries = new List<Salarie>();
        }
    }
}
