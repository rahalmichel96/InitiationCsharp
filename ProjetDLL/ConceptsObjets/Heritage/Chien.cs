using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.ConceptsObjets.Heritage
{
    public class Chien : Animal
    {
        public string Race { get; set; }

        public Chien(string nom, int age, string race) : base(nom, age)
        {
            Race = race;
        }

        public Chien()
        {
        }
    }
}
