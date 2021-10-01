using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPConjugaison
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objectif: extractions, comparaisos et concaténations de chaines

            //L'utilisateur devra saisir un verbe du premier groupe
            //On devra le conjuguer
            string[] sujets = { "Je", "Tu", "Il/Elle", "Nous", "Vous", "Ils/Elles" };
            string[] terminaisons = { "e", "es", "e", "ons", "ez", "ent" };

            //Verbe du premier groupe se terminant par er autre que le verbe aller
            string verbe = null;

            //Saisie du verbe
            do
            {
                Console.WriteLine("Saisir le verbe:");
                verbe = Console.ReadLine();
            } while (!verbe.EndsWith("er") || verbe.Trim().ToLower().Equals("aller"));

            //Afficher le verbe conjugué
            for (int i = 0; i < sujets.Length; i++)
            {
                Console.WriteLine(sujets[i] + " " + verbe.Remove(verbe.Length - 2) + terminaisons[i]);
            }

            Console.ReadKey();
        }
    }
}
