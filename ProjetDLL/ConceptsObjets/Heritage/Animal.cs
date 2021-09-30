using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.ConceptsObjets.Heritage
{
    public class Animal
    {
        public string Nom { get; set; }
        public int Age { get; set; }

        public Animal()
        {

        }

        public Animal(string nom, int age)
        {
            Nom = nom;
            Age = age;
        }

        public override string ToString()
        {
            return $"Nom: {Nom} - Age: {Age}";
        }

        public virtual void Identite()
        {
            Console.WriteLine("Je suis un animal");
        }

        //Méthode inacessible par la classe enfant
        private void MethodePrivee()
        {
            Console.WriteLine("Méthode Privee");
        }
    }
}
