using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.ConceptsObjets.Heritage
{
    public class Chat : Animal
    {
        public override void Identite()
        {
            Console.WriteLine("Je suis un chat"); ;
        }

        //Le mot clé base nous permet d'appeler le constructeur de la classe parente
        public Chat(string nom, int age) : base(nom, age)
        {

        }

        public Chat()
        {
        }
    }
}
