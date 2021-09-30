using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.ConceptsObjets.Abstraction
{
    public abstract class Personne
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public Personne(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
        }

        public Personne()
        {
        }

        public override string ToString()
        {
            return $"Nom: {Nom} - Prénom: {Prenom}";
        }

        public virtual void Afficher()
        {

        }

        //Méthode abstraite
        public abstract void Identite();
    }
}
