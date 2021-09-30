using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPConceptObjet2
{
    public class Dev : SalarieManage
    {
        public static int PERIODE_ESSAI_EN_MOIS { get; set; } = 2;
        public Dev(string nom, int age, double salaire, Manager manager) : base(nom, age, salaire, manager)
        {
        }
    }
}
