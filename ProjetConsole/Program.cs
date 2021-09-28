using System;
using ProjetDLL;

namespace ProjetConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //ceci est un commentaire sur une ligne

            /*
             * Ceci est un commentaire
             * sur plusieurs lignes
            */


            Console.WriteLine("Test de C#");
            Tools.MaMethode();

            #region Variables

            //Variables: zone memoire qui contient une valeur typée
            //Type simple ou type valeur: entier, reel, boolean, char
            //Type complexe ou type reference: tableau, String, date, classe

            //entier: byte(1 o), short(2 o), int(4 o), long(8 o)
            //reel: float(4 o), double(8 o), decimal (16 o)

            //declaration d'une variable: tyoe nom_variable = valeur
            int myint = 10;
            Console.WriteLine("Contenu de myint: " + myint); //+: concaténation

            double mydouble = 10.5;
            char mychar = 'b';
            Boolean myboolean = true;
            string mystring = "b";

            //Mot clé var: c'est le compilateur qui déduit le type à partir de la variable
            var maVariable = "10";
            //maVariable = 10; erreur de compilation

            //Types nullables: .net propose une syntaxe qui permet d'affecter aux types simples null
            //int x = null -> erreur
            int? x = null;
            string str = null;

            //Avant utilisation de x on doit vérifier qu'elle contienne une valeur
            if (x.HasValue)
            {
                Console.WriteLine("x n'est pas null");
            } else
            {
                Console.WriteLine("x est null");
            }

            #endregion

            #region Opérateurs

            //Opérateur mathématiques: +, -, *, /, %
            Console.WriteLine("Reste de la division de 10 par 3: " + 10 % 3);

            //Opérateurs combinés: +=, -=, *=, /=, %=
            myint += 5;

            //Opérateurs d'incrémentation et de décrémentation: ++, --
            int val = 0;
            Console.WriteLine("Pré incrémentation: "+(++val)); //incremente val puis utilise sa valeur
            Console.WriteLine("Post incrémentation: "+(val++)); //utilise val puis l'incrémente
            Console.WriteLine(6+"5"+2); //652
            Console.WriteLine(6+2+"5"); //85
            Console.WriteLine("6"+5+2); //652

            //Opérateurs de comparaison: ==, !=, >, <, >=, <=

            //Opérateur logiques: &&, ||, ^ (ou exclusif)

            //Constante: variable contenant une valeur qu'on ne peut pas modifier
            const double MA_CONSTANTE = 10.5;
            //MA_CONSTANTE = 25; erreur de compilation

            #endregion

            #region Conversion de types

            //Conversion implicite
            byte mybyte = 10;
            int myint2 = mybyte;

            //Conversion explicite (risque de perte de données)
            //Pour les conversions explicites, on peut utiliser le cast
            //CAST: (int), (byte), (double)...
            //La classe Convert
            int myint3 = 20;
            byte mybyte2 = (byte)myint;
            byte mybyte3 = Convert.ToByte(myint3);

            string chaine = "25";
            int myint4 = Convert.ToInt32(chaine);
            int myint5 = int.Parse(chaine);
            #endregion

            #region Conditions

            //Exprimer un test conditionnel: if (condition == vraie) { instructions; } else { instructions; }
            int nb = 5;
            if (nb > 0)
            {
                Console.WriteLine("nb positif");
            } else if (nb == 0)
            {
                Console.WriteLine("nb nul");
            } else
            {
                Console.WriteLine("nb négatif");
            }

            //Switch est une variante de la condition if
            int note = 10;
            switch (note)
            {
                case 0:
                    Console.WriteLine("recalé");
                    break;
                case 10:
                case 11:
                case 12:
                    Console.WriteLine("moyen");
                    break;
                default:
                    Console.WriteLine("autre note");
                    break;
            }

            //Ternaire:
            int maVar = (10 < 5) ? 10 : 5; // maVar = 5

            #endregion

            #region Boucles

            //Boucles conditionnelles: while, do while
            //Boucles iteratives: for, foreach
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("passage n°" + i);
                //Quitter la boucle si i = 6
                if (i == 6)
                {
                    break; //permet de sortir
                }

                //passer à l'itération suivante si i = 3
                if (i == 3)
                {
                    continue;
                }
            }

            int[] tableau = { 1, 2, 3, 4 };
            foreach  (int i in tableau)
            {
                Console.WriteLine("passage n°" + i);
            }

            int valeur = 1;
            while (valeur < 5)
            {
                valeur++;
            }

            //s'execute au moins 1 fois
            do
            {
                Console.WriteLine("passage n°" + valeur);
                valeur++;
            } while (valeur < 10);

            #endregion

            #region Tableaux

            //Tableau: un ensemble d'éléments typés

            //1 dimension

            //Déclaration d'un tableau
            int[] tab = new int[3]; //tableau de 3 cases
            tab[0] = 10;
            tab[1] = 20;
            tab[2] = 30;
            Console.WriteLine("Taille du tableau: " + tab.Length);

            //Parcours du tableau avec la boucle foreach
            foreach (int item in tab)
            {
                Console.WriteLine(item);
            }

            //Parcours du tableau avec la boucle for
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }

            //2e facon de déclarer un tableau
            int[] tab2 = { 10, 20, 30 };

            //2 dimensions
            int[,] matrice = new int[2, 3];
            matrice[0, 0] = 10;
            matrice[0, 1] = 20;
            matrice[0, 2] = 30;
            matrice[1, 0] = 40;
            matrice[1, 1] = 50;
            matrice[1, 2] = 60;

            int[,] matrice2 = { { 10, 15, 58 }, { 12, 25, 32 } };

            Console.WriteLine("Nombre de lignes de la matrice: " + matrice2.GetLength(0)); //2
            Console.WriteLine("Nombre de colonnes de la matrice: " + matrice2.GetLength(1)); //3
            Console.WriteLine("Nombre total d'éléments de la matrice: " + matrice2.Length); //6
            Console.WriteLine("Nombre de dimensions de la matrice: " + matrice2.Rank); //2

            #endregion

            #region Méthodes

            //Méthode : un ensemble d'instructions réutilisables
            //Dans la programmation objet on a 2 types de méthodes
            //Procédure : une méhode qui ne revoit aucune valeur (void)
            //Fonctions : une méthode qui renvoie une valeur : on doit préciser le type du retour

            //Declaration d'une méthode : Visibilité [mot-clé static] type_retour Nom_Methode(paramètres) { instructions; }
            int resultat = MesMethodes.Somme(10, 20);
            Console.WriteLine(resultat);

            int[] monTableau = { 10, 0, 20, 15 };
            MesMethodes.Afficher(monTableau);

            //Test Somme
            Console.WriteLine("************Test Somme*************");
            Console.WriteLine(MesMethodes.Somme(monTableau));

            //Test Moyenne
            Console.WriteLine("************Test Moyenne*************");
            Console.WriteLine(MesMethodes.Moyenne(monTableau));

            //Test Plus petit
            Console.WriteLine("************Test Plus petit*************");
            Console.WriteLine(MesMethodes.PlusPetit(monTableau));

            //Appel de la méthode avec des params optionnels
            MesMethodes.SommeOptionnel(10, 20);
            MesMethodes.SommeOptionnel(10, 20, 30);

            Console.WriteLine("************Test Permute*************");
            int val1 = 10, val2 = 20;
            //interpolation
            Console.WriteLine($"Avant permutation val1 = { val1 } et val2 = { val2 }");
            MesMethodes.Permute(ref val1, ref val2);
            Console.WriteLine($"Après permutation val1 = { val1 } et val2 = { val2 }");

            //Appel de méthode avec des paramètres en sortie
            double somme = 0, moyenne = 0;
            double produit = MesMethodes.Calculer(10, 20, out somme, out moyenne);
            Console.WriteLine($"Produit = { produit }");
            Console.WriteLine($"Somme = { somme }");
            Console.WriteLine($"Moyenne = { moyenne }");

            //Appel de la méthode avec un nombre variable d'arguments
            MesMethodes.Produit(10, 20);
            MesMethodes.Produit(10, 20, 30);
            MesMethodes.Produit(10, 20, 30, 40);

            #endregion

            //Maintenir la console active
            Console.ReadLine();
        }
    }
}
