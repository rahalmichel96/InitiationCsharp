using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.ConceptsObjets.Abstraction
{
    public class Homme : Personne
    {
        public Homme(string nom, string prenom) : base(nom, prenom)
        {
        }

        public override void Identite()
        {
            Console.WriteLine("Je suis un homme");
        }
    }
}
