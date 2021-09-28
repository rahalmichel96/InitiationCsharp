using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{
    public class MesMethodes
    {
        //Une classe peut contenir 2 types de méthodes
        //Méthode de classe - méthode static: accessible via la classe directement
        //Méthode d'instance: pas de mot clé static et accessible via une instance de la classe (via un objet de la classe)
        /// <summary>
        /// Méthode qui calcule la somme de 2 entiers
        /// </summary>
        /// <param name="x">est un entier</param>
        /// <param name="y">est un entier</param>
        /// <returns>Somme entière de x et de y</returns>
        public static int Somme(int x, int y)
        {
            return x + y;
        }

        //Surcharge(overload): le fait de pouvoir définir la même méthode dans la même classe avec uniquement la liste des paramètres qui changent
        /// <summary>
        /// Méthode qui calcule la somme de deux réels
        /// </summary>
        /// <param name="x">est un réel</param>
        /// <param name="y">est un réel</param>
        /// <returns>Somme réelle de x et de y</returns>
        public static double Somme(double x, double y)
        {
            return x + y;
        }

        public static void Afficher()
        {
            Console.WriteLine("Méthode void sans type de retour");
        }

        //Méthode pour lister le contenu d'un tableau
        public static void Afficher(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("L'élément numéro " + i + " est " + tab[i]);
            }
        }

        //Méthode qui renvoie la somme des éléments d'un tableau d'entiers
        public static int Somme(int[] tab)
        {
            int sum = 0;
            foreach (var item in tab)
            {
                sum += item;
            }

            return sum;
        }

        //Méthode qui renvoie la moyenne des éléments d'un tableau d'entiers
        public static double Moyenne(int[] tab)
        {
            double sum = Somme(tab);
            return sum / tab.Length;
        }

        //Méthode qui renvoie l'élément le plus petit d'un tableau d'entiers
        public static int PlusPetit(int[] tab)
        {
            int min = tab[0];
            for (int i = 1; i < tab.Length; i++)
            {
                if (tab[i] < min)
                {
                    min = tab[i];
                }
            }
            return min;
        }

        //Paramètres optionnels d'une méthode : possède des valeurs par défaut
        public static int SommeOptionnel(int x, int y, int z=10)
        {
            return x + y + z;
        }

        //Définir une méthode qui permute 2 entiers
        //ref: concerne que les types simples
        //Passage de paramètres par référence
        public static void Permute(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        //Paramètres en sortie
        public static double Calculer(double x, double y, out double somme, out double moyenne)
        {
            somme = x + y;
            moyenne = (x + y) / 2;
            return x * y;
        }


        //Nombre variable de paramètres d'une méthode
        public static int Produit(params int[] tab)
        {
            int prod = 1;
            foreach (var item in tab)
            {
                prod *= item;
            }
            return prod;
        }
    }
}
