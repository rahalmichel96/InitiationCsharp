using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPConceptObjet2
{
    public class Consultant : SalarieManage
    {
        public static int PERIODE_ESSAI_EN_MOIS { get; set; } = 3;
        public Consultant(string nom, int age, double salaire, Manager manager) : base(nom, age, salaire, manager)
        {
        }
    }
}
