using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Calculatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            char choix = '\0';
            double valeur1 = 0, valeur2 = 0;
            Console.WriteLine("--------------Calculatrice----------------");
            Console.WriteLine("Veuillez faire un choix:");
            Console.WriteLine("Addition tapez a");
            Console.WriteLine("Soustraction tapez s");
            Console.WriteLine("Mutliplication tapez m");
            Console.WriteLine("Division tapez d");
            Console.WriteLine("Arrêter tapez !");

            do
            {
                //Rédcupérer le choix de l'utilisateur (s'il n'est pas valide on l'invite à retaper)
                choix = char.Parse(Console.ReadLine());

                if (choix == '!')
                {
                    Console.WriteLine("Au revoir !!!");
                    break;
                }

                //Demander la saisie de la valeur1
                valeur1 = int.Parse(Console.ReadLine());

                //Demander la saisie de la valeur2
                valeur2 = int.Parse(Console.ReadLine());

                //Afficher le résultat
                switch (choix)
                {
                    case 'a':
                        Console.WriteLine("Le résultat est: " + (valeur1 + valeur2));
                        break;
                    case 's':
                        Console.WriteLine("Le résultat est: " + (valeur1 - valeur2));
                        break;
                    case 'm':
                        Console.WriteLine("Le résultat est: " + (valeur1 * valeur2));
                        break;
                    case 'd':
                        Console.WriteLine("Le résultat est: " + (valeur1 / valeur2));
                        break;
                    default:
                        Console.WriteLine("Le choix n'est pas valide, veuillez recommencer");
                        break;
                }
            } while (true);

            Console.ReadLine();
        }
    }
}
