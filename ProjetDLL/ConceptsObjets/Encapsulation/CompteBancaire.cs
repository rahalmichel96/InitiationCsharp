using ProjetDLL.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.ConceptsObjets.Encapsulation
{
    [DataContract] //Cette annotation informe le compilateur que les objets de type CompteBancaire sont sérialisables en JSON
    [Serializable] //Cette annotation informe le compilateur que les objets de type CompteBancaire sont sérialisables en binaire
    public class CompteBancaire
    {
        //Caractérise une classe de type objet
        //Les variables locales doivent être initialisés
        //Les propriétés sont appelés aussi variables de classe
        //Ces dernières possèdent des valeurs par défaut
        //Propriété de type numérique: valeur par défaut 0
        //Propriété de type boolean: valeur par défaut false
        //Propriété de type objet: valeur par défaut null
        #region Champs - Propriétés
        //[XmlIgnore] permet d'ignorer ce champs pour la serialisation xml
        //[NonSerialized permet d'ignorer ce champs pour la serialisation binaire
        [DataMember]
        public string Numero { get; set; }
        [DataMember]
        public double Solde { get; set; }

        //Attribut global
        public static string Banque { get; set; } = "BNP";
        public static int Compteur { get; set; } = 0;

        #endregion

        #region Constructeurs

        //C'est une méthode public qui porte le nom de la classe
        //dont le rôle est d'initialiser ses attributs
        public CompteBancaire(string Numero, double Solde) : this(Numero)
        {
            this.Solde = Solde;
        }

        public CompteBancaire(string Numero) : this()
        {
            this.Numero = Numero;
        }

        public CompteBancaire()
        {
            Compteur++;
        }

        #endregion

        #region Méthodes

        public void Depot(double montant)
        {
            Solde += montant;
        }

        /// <summary>
        /// Si le solde est inférieur au montant la méthode génère une exception
        /// </summary>
        /// <param name="montant">Le montant à retirer</param>
        public void Retrait(double montant)
        {
            if (Solde >= montant)
            {
                Solde -= montant;
            } else
            {
                //Console.WriteLine("Solde insuffisant !");
                throw new SoldeInsuffisantException("Solde insuffisant pour effectuer un retrait de " + montant);
            }
        }

        //Méthode ToString
        public override string ToString()
        {
            return $"Numéro: {Numero} - Solde: {Solde}";
        }

        public override bool Equals(object obj)
        {
            //return obj is CompteBancaire bancaire &&
            //       Numero == bancaire.Numero;
            CompteBancaire cb = (CompteBancaire)obj;
            return Numero == cb.Numero;
        }


        #endregion

    }
}
