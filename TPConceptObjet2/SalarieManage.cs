using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPConceptObjet2
{
    public abstract class SalarieManage : Salarie
    {
        //On ne peut pas choisir son manager
        public Manager Manager { get; }
        public SalarieManage(string nom, int age, double salaire, Manager manager) : base(nom, age, salaire)
        {
            Manager = manager;
        }
    }
}
