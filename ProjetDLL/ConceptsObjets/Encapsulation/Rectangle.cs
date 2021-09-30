using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.ConceptsObjets.Encapsulation
{
    public class Rectangle
    {
        //private double largeur;
        //private double longueur;
        //public double Surface()
        //{
        //    return longueur * largeur;
        //}
        //public double GetLargeur()
        //{
        //    return largeur;
        //}
        //public void SetLargeur(double value)
        //{
        //    if (value < 0)
        //    {
        //        Console.WriteLine("la largueur ne peut être négative");
        //    } else
        //    {
        //        largeur = value;
        //    }
        //}
        //public double GetLongeur()
        //{
        //    return longueur;
        //}
        //public void SetLongueur(double value)
        //{
        //    if (value < 0)
        //    {
        //        Console.WriteLine("la longueur ne peut être négative");
        //    }
        //    else
        //    {
        //        longueur = value;
        //    }
        //}

        private double largeur;

        public double Largeur
        {
            get { return largeur; }
            set 
            {
                if (value < 0)
                {
                    Console.WriteLine("la largueur ne peut être négative");
                }
                else
                {
                    largeur = value;
                }
            }
        }

        private double longueur;

        public double Longueur
        {
            get { return longueur; }
            set 
            {
                if (value < 0)
                {
                    Console.WriteLine("la longueur ne peut être négative");
                }
                else
                {
                    longueur = value;
                }
            }
        }

        //Propriété automatique
        public int Auto { get; set; }

        //Si les attributs possèdent des contraintes on utilise une propriété full (champ privé + propriété)
        //Sinon on utilise une propriété automatique
    }
}
