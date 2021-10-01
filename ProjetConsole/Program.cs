using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using ProjetDLL;
using ProjetDLL.ConceptsObjets.Abstraction;
using ProjetDLL.ConceptsObjets.Association;
using ProjetDLL.ConceptsObjets.Encapsulation;
using ProjetDLL.ConceptsObjets.Heritage;

namespace ProjetConsole
{
    enum Profils
    {
        ADMIN,
        MANAGER,
        RH
    }

    enum Etat
    {
        NEUF,
        EXCELLENT,
        BON,
        MAUVAIS
    }
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

            #region Dates

            //Création d'objets de type Date

            DateTime dt = DateTime.Now;
            DateTime dt2 = DateTime.Today;

            //Date avec appel du constructeur
            DateTime dt3 = new DateTime(2019, 5, 1, 15, 23, 45);

            Console.WriteLine("La comparaison de dt et dt2: " + dt.CompareTo(dt2));
            Console.WriteLine("L'égalité de dt et dt2: " + dt.Equals(dt2));

            //Opérations
            Console.WriteLine("Ajouter 2 jours à dt: " + dt.AddDays(2.5));

            Console.WriteLine("dt1 - dt2: " + dt.Subtract(dt2));

            //Recherches
            Console.WriteLine("Date de dt: " + dt.Date);
            Console.WriteLine("Jour du mois de dt: " + dt.Day);
            Console.WriteLine("Jour du la semaine de dt: " + dt.DayOfWeek);
            Console.WriteLine("Jour du l'année de dt: " + dt.DayOfYear);

            //Formatage des objets de type DateTime
            Console.WriteLine("Format long de Date: " + dt.ToLongDateString());
            Console.WriteLine("Format court de Date: " + dt.ToShortDateString());
            Console.WriteLine("Format long de Time: " + dt.ToLongTimeString());
            Console.WriteLine("Format court de Time: " + dt.ToShortTimeString());

            #endregion

            #region Enumérations

            //Enum: liste de constantes
            Etat etat = Etat.EXCELLENT;

            //Afficher le label
            Console.WriteLine(etat);

            Console.WriteLine("Quel est votre profil (0,1,2): ");
            int codeProfil = Convert.ToInt32(Console.ReadLine());

            Profils profil = (Profils)codeProfil;
            Console.WriteLine($"Votre profile est {profil}");

            #endregion

            #region Concepts objets

            //Encapsulation - Héritage - Abstraction - Polymorphisme - Agrégation (association - composition)

            //Mise en place de l'encapsulation
            //1- Rassembler dans une seule et même classe les params et fonctions qui concernent le même objet
            //2- Empêcher l'accès public aux attributs
            //3- L'accès aux attributs doit obligatoirement passer par les getters et setters

            //Plus lisible
            Rectangle r = new Rectangle();
            r.Longueur = 15;
            r.Largeur = 20;

            //Toute classe possède un constructeur par défaut
            CompteBancaire cb = new CompteBancaire();

            //ToString
            Console.WriteLine(cb);

            CompteBancaire c1 = new CompteBancaire("15616515", 500);
            CompteBancaire c2 = new CompteBancaire("15616515", 500);

            //Equals
            Console.WriteLine("C1 et C2 sont-ils égaux ? " + c1.Equals(c2));

            Console.WriteLine($"Le nom de la banque: {CompteBancaire.Banque}");

            //Heritage
            Animal animal = new Animal();
            animal.Nom = "Animal";
            animal.Age = 5;

            Chat chat = new Chat();
            chat.Nom = "chat";
            chat.Age = 3;

            Animal animal2 = new Animal("animal2", 5);
            //Chat chat2 = new Chat("chat2", 6); pas possible si le constructeur n'apparait pas dans la classe enfant

            //Un objet de type animal peut prendre plusieurs formes = Polymorphisme
            //C'est une conséquence de l'Héritage
            //Intérêt: pouvoir manipuler des objets sans se soucier de son type
            Chien chien = new Chien("chien", 4, "caniche");
            Animal animal3 = new Animal();
            Animal animal4 = new Chat();
            Animal animal5 = new Chien();

            string[] tabString = new string[2];
            tabString[0] = "test";
            tabString[1] = "test";

            //Collection polymorphique
            Animal[] animaux = new Animal[3];
            animaux[0] = new Animal();
            animaux[1] = new Chat();
            animaux[2] = new Chien();

            //Toutes les classes héritent de la classe object
            object obj = 1;
            object obj2 = "text";
            object obj3 = false;
            object obj4 = new Animal();
            object obj5 = new Chat();

            //Méthode polymorphique
            Identite(animal);
            Identite(chat);
            Identite(chien);

            //Abstraction
            //Une classe abstraite est une classe qu'on ne peut pas instancier
            Personne p = new Homme("n", "p");

            //Association
            Client cli = new Client();
            cli.Nom = "nomClient";
            cli.Adresse = new Adresse() { Num = 15, Rue = "rue de Paris" };
            #endregion

            #region Exception

            //Exception : c'est une erreur qui provoque l'arrêt de l'application
            //Pour éviter l'arrêt de l'application on doit gérer l'exception
            //Pour ce faire on utilise le bloc try - catch
            Console.WriteLine("---------------Exception---------------");
            int nombre = 10;
            try
            {
                //Dès que l'exception est généré on execute pas la suite du code
                //On passe directement au bloc catch
                Console.WriteLine(nombre / 0);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception traitée");
            }

            Console.WriteLine("Suite de l'application.........");

            int[] tabEntiers = { 1, 2 };

            try
            {
                Console.WriteLine(tabEntiers[3]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("La case 3 n'est pas accessible"); ;
            }

            //Toutes les exceptions héritent de la classe Exception
            //On peut donc catch n'importe quelle exception grâce à un paramètre de type exception
            try
            {
                Console.WriteLine(nombre / 0);
                Console.WriteLine(tabEntiers[3]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Les excetpions ont été traités");
            }

            //Le bloc finally est optionnel
            //Il s'exécute à chaque fois et sert à libérer les ressources éventuellement utilisées dans le bloc try
            //Par exemple lorsqu'on lit un fichier, il faut fermer le flux
            try
            {
                Console.WriteLine(nombre / 0);
            }
            catch (Exception)
            {
                Console.WriteLine("Division par zéro suivi d'un finally");
            }
            finally
            {
                Console.WriteLine("Bloc finally");
            }

            try
            {
                Division(0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            CompteBancaire compte = new CompteBancaire("1556665", 1000);
            try
            {
                compte.Retrait(2000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            #endregion

            #region Class String
            Console.WriteLine("-------------Class String-----------------");
            //On peut créer des string sans faire appel au constructeur via une chaine littérale
            string nouvelleChaine = " ceci est une chaine ";
            nouvelleChaine = nouvelleChaine.ToUpper();
            //Les objets de type string sont immuables. Une fois créés on ne peut pas les modifier en mémoire
            Console.WriteLine(nouvelleChaine);

            string nouvelleChaine2 = " CECI EST UNE CHAINE ";
            Console.WriteLine("Comparaison du contenu: " + nouvelleChaine.Equals(nouvelleChaine2));
            Console.WriteLine("Comparaison des références: " + object.ReferenceEquals(nouvelleChaine,nouvelleChaine2));

            //Quelques méthodes
            Console.WriteLine("Taille de la chaine: " + nouvelleChaine.Length); //21 - un objet string est un tableau de char
            Console.WriteLine("Premier caractère de la chaine: " + nouvelleChaine[0]);
            Console.WriteLine("La chaine commence-t-elle par C ? " + nouvelleChaine.StartsWith("C"));
            Console.WriteLine("La chaine se termine-t-elle par un espace ? " + nouvelleChaine.EndsWith(" "));
            Console.WriteLine("Eliminer les espaces de début et de fin de chaine: " + nouvelleChaine.Trim());
            Console.WriteLine("Remplacer une chaine par une autre: " + nouvelleChaine.Replace("UNE CHAINE","UN PARAGRAPHE"));

            //Extractions de sous chaines
            Console.WriteLine(nouvelleChaine.Substring(1));
            Console.WriteLine(nouvelleChaine.Substring(1, 3)); //CEC

            //Chaine CSV
            //Découpage d'une chaine: Split
            string chaineCSV = "dawan;jehann;paris";
            string[] tabCSV = chaineCSV.Split(';');
            foreach (var item in tabCSV)
            {
                Console.WriteLine(item);
            }

            //Join
            string[] mots = { "ceci", "est", "un", "join" };
            string phrase = string.Join(" ", mots);
            Console.WriteLine(phrase);

            Console.WriteLine("Nombre de mots dans la chaine: " + MesMethodes.NbMotsDansChaine(nouvelleChaine));
            Console.WriteLine("Inverse de la chaine: " + MesMethodes.Inverse(nouvelleChaine));
            Console.WriteLine("Test Palindrome: " + MesMethodes.Pallindrome("ressasser"));

            #endregion

            #region Collections
            Console.WriteLine("----------------Collections--------------");
            //Ce sont des tableaux dynamiques (à taille variable)
            //2 Catégories

            //Les collections faiblement typées

            //ArrayList
            ArrayList list = new ArrayList();
            Console.WriteLine("Taille du tableau dynamique: " + list.Count); //0
            list.Add(5);
            list.Add(false);
            list.Add("test");

            Console.WriteLine("Taille du tableau dynamique: " + list.Count); //3
            Console.WriteLine("La liste contient-elle la chaine test ? " + list.Contains("test"));
            list.Remove("test");
            Console.WriteLine("La liste contient-elle la chaine test ? " + list.Contains("test"));
            Console.WriteLine("La position du booléen: " + list.IndexOf(false)); //1
            list.Insert(1, "dawan");
            Console.WriteLine("La position du booléen: " + list.IndexOf(false)); //2

            //Afficher le contenu du tableau
            foreach (var elt in list)
            {
                Console.WriteLine(elt);
            }

            //Pile - Stack - LIFO
            Stack pile = new Stack();

            pile.Push(5);
            pile.Push(false);
            pile.Push("test");
            pile.Push(15.5);

            Console.WriteLine("Nombre d'éléments de la pile: " + pile.Count); //4
            Console.WriteLine("La pile contient-elle 15.5 ? " + pile.Contains(15.5)); //True

            //Supprime le dernier élément
            pile.Pop();
            Console.WriteLine("La pile contient-elle 15.5 ? " + pile.Contains(15.5)); //False
            Console.WriteLine("Le dernier élément de la pile: " + pile.Peek());

            //File - Queue - FIFO
            Queue file = new Queue();
            file.Enqueue(5);
            file.Enqueue("test");
            file.Enqueue(true);
            file.Enqueue(20.2);

            Console.WriteLine("Taille de fifo: " + file.Count); //4
            Console.WriteLine("La file contient-elle le chiffre 5? " + file.Contains(5)); //True
            file.Dequeue();
            Console.WriteLine("La file contient-elle le chiffre 5? " + file.Contains(5)); //False

            //Collections fortement typées

            //List
            List<string> jours = new List<string>();
            Console.WriteLine("Taille de la liste: " + jours.Count); //0
            jours.Add("lundi");
            jours.Add("mardi");
            jours.Add("mercredi");
            jours.Add("jeudi");
            jours.Add("vendredi");
            jours.Add("samedi");
            jours.Add("dimanche");
            Console.WriteLine("La liste contient-elle mardi? " + jours.Contains("mardi")); //True
            jours.Remove("mardi");
            Console.WriteLine("La liste contient-elle mardi? " + jours.Contains("mardi")); //False
            foreach (string jour in jours)
            {
                Console.WriteLine(jour);
            }

            //Vider la liste
            jours.Clear();
            Console.WriteLine("Taille de la liste: " + jours.Count); //0

            //Dictionary : Stockage clé - valeur
            Dictionary<int, string> dictionnaire = new Dictionary<int,string>();
            Console.WriteLine("Taille du dictionnaire: " + dictionnaire.Count);
            dictionnaire.Add(10, "admin");
            dictionnaire.Add(150, "password");

            //Chercher "admin"
            if (dictionnaire.ContainsKey(10))
            {
                Console.WriteLine(dictionnaire[10]);
            }

            if (dictionnaire.ContainsKey(100))
            {
                Console.WriteLine(dictionnaire[100]);
            } else
            {
                Console.WriteLine("Le dictionnaire ne contient pas la clé 100");
            }

            //Afficher les valeurs + clés du dictionnaire

            foreach (int key in dictionnaire.Keys)
            {
                Console.WriteLine($"Cle: {key} - Valeur: {dictionnaire[key]}");
            }

            Dictionary<string, List<CompteBancaire>> mesComptes = new Dictionary<string, List<CompteBancaire>>();
            List<CompteBancaire> debiteurs = new List<CompteBancaire>();
            debiteurs.Add(new CompteBancaire("1255151", -1500));
            debiteurs.Add(new CompteBancaire("1615655", -2500));
            debiteurs.Add(new CompteBancaire("65565", -4500));
            List<CompteBancaire> crediteurs = new List<CompteBancaire>();
            crediteurs.Add(new CompteBancaire("565664", 1500));
            crediteurs.Add(new CompteBancaire("54464565", 2500));
            crediteurs.Add(new CompteBancaire("5456465", 4500));

            //Ajout des deux listes dans le dictionnaire
            mesComptes.Add("debiteurs", debiteurs);
            mesComptes.Add("crediteurs", crediteurs);

            //Afficher uniquement les comptes créditeurs
            if (mesComptes.ContainsKey("crediteurs"))
            {
                foreach (CompteBancaire cpt in mesComptes["crediteurs"])
                {
                    Console.WriteLine(cpt.ToString());
                }
            }

            #endregion

            #region Fichiers
            Console.WriteLine("---------------Fichier-----------------");
            //.net nous fournit un certain nombre de classes qui nous permettent de manipuler les fichiers et les dossiers
            //Dossier: Directory
            //Fichier: File et FileInfo (présentent pratiquement les mêmes méthodes à la seule différence qu'elles sont static pour File et d'instance pour FileInfo
            //Pour les opérations de lecture et d'écriture: StreamReader et StreamWriter

            //Caractères d'échappement \n: retour à la ligne - \t: tabulation - \\: échapper le \

            //chaine verbatim : permet d'indiquer qu'on veut que le paragraphe soit traduit tel quel
            Console.WriteLine(@"    Bonjour,
Je suis en formation chez Dawan.
Formation c#");

            //Création d'un répertoire
            Directory.CreateDirectory("dossier"); //chemin relatif à l'executable du projet bin/debug
            Directory.CreateDirectory("c:\\dossier"); //chemin absolu

            //Récupérer les fichiers d'un dossier
            string[] files = Directory.GetFiles("c:\\rep");

            foreach (var f in files)
            {
                Console.WriteLine(f);
            }

            string fichierSource = "c:\\rep\\fichier.txt";
            string fichierCible = "c:\\rep\\fichierCopie.txt";

            try
            {
                File.Copy(fichierSource, fichierCible);
            }
            catch (Exception e)
            {
                if (File.Exists(fichierCible))
                {
                    File.Delete(fichierCible);
                }
                Console.WriteLine(e.Message);
            }

            //Utilisation de FileInfo pour récupérer les infos concernant un fichier particulier
            FileInfo info = new FileInfo(fichierSource);
            Console.WriteLine("Date de création du fichier: " + info.CreationTime);
            Console.WriteLine("Date de dernière modification du fichier: " + info.LastWriteTime);
            Console.WriteLine("Date de dernier accès au fichier: " + info.LastAccessTime);
            Console.WriteLine("Extension du fichier: " + info.Extension);
            Console.WriteLine("Taille du fichier: " + info.Length);

            //Lecture - Ecriture de fichiers
            //Flux : canal entre la source et la destination
            //1- Charger le fichier dans un flux (lecture ou écriture)
            //2- Exécuter les opérations (lecture ou écriture)
            //3- Libérer/Fermer le flux
            string chemin = "c:\\rep\\ecriture.txt";
            StreamWriter sw = new StreamWriter(chemin);
            sw.Write("ceci est mon texte.................");
            sw.Close();

            StreamReader sr = new StreamReader(chemin);
            string contenu = sr.ReadToEnd();
            sr.Close();
            Console.WriteLine(contenu);

            //Utilisation de la classe Tools définie dans le projet DLL
            Tools.Ecrire(@"c:\rep\test.txt", "contenu du fichier test.txt");
            Console.WriteLine(Tools.Lire(@"c:\rep\test.txt"));

            #endregion

            #region Serialisation
            Console.WriteLine("--------------------Serialisation----------------------");
            //C'est un mécanisme qui nou permet de sauvegarder un objet dans un fichier
            //3 types de sérialisation
            //Binaire : BinaryFormatter
            //XML : XMLSerializer
            //JSON : DataContractJsonSerializer

            List<CompteBancaire> comptesBancaires = new List<CompteBancaire>();
            Tools.ExportBIN(@"c:\rep\comptes.bin", mesComptes["crediteurs"]);

            List<CompteBancaire> listeARecup = Tools.ImportBIN(@"c:\rep\comptes.bin");
            foreach (var item in listeARecup)
            {
                Console.WriteLine(item);
            }

            //Serialisation XML
            Tools.ExportXML(@"c:\rep\comptes.xml", mesComptes["crediteurs"]);

            List<CompteBancaire> listeFromXML = Tools.ImportXML(@"c:\rep\comptes.xml");

            //Serialisation JSON
            Tools.ExportJSON(@"c:\rep\comptes.json", mesComptes["crediteurs"]);

            List<CompteBancaire> listeFromJSON = Tools.ImportJSON(@"c:\rep\comptes.json");
            foreach (var item in listeFromJSON)
            {
                Console.WriteLine(item);
            }

            #endregion

            //Maintenir la console active
            Console.ReadLine();
        }

        public static void Identite(Animal animal)
        {
            animal.Identite();
        }

        /// <summary>
        /// Cette méthode peut générer une exception
        /// </summary>
        /// <param name="x"></param>
        public static void Division(int x)
        {
            if (x!=0)
            {
                Console.WriteLine(10/x);
            } 
            //Permet de remonter une exception
            //La gestion de l'exception reste à la charge de l'utilisateur
            else
            {
                throw new Exception();
            }
        }
    }
}
