using ProjetDLL.ConceptsObjets.Encapsulation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProjetDLL
{
    public class Tools
    {
        public static void MaMethode()
        {
            Console.WriteLine("Appel de la méthode définie dans le projet DLL");
        }

        //Méthode d'écriture dans un fichier
        public static void Ecrire(string path, string content)
        {
            StreamWriter sw = new StreamWriter(path);
            sw.Write(content);
            sw.Close();
        }

        //Méthode de lecture dans un fichier
        public static string Lire(string path)
        {
            StreamReader sr = new StreamReader(path);
            string content = sr.ReadToEnd();
            sr.Close();
            return content;
        }

        //Serialisation binaire
        public static void ExportBIN(string chemin, List<CompteBancaire> liste)
        {
            BinaryFormatter bf = new BinaryFormatter();
            Stream st = new FileStream(chemin, FileMode.Create);
            bf.Serialize(st, liste);
            st.Close();
        }

        //Désérialisation binaire
        public static List<CompteBancaire> ImportBIN(string chemin)
        {
            BinaryFormatter bf = new BinaryFormatter();
            Stream st = new FileStream(chemin, FileMode.Open);
            List<CompteBancaire> liste = (List<CompteBancaire>)bf.Deserialize(st);
            st.Close();
            return liste;
        }

        //Sérialisation XML
        public static void ExportXML(string chemin, List<CompteBancaire> liste)
        {
            XmlSerializer xmlS = new XmlSerializer(liste.GetType());
            Stream st = new FileStream(chemin, FileMode.Create);
            xmlS.Serialize(st, liste);
            st.Close();
        }

        //Méthode de désérialisation XML
        public static List<CompteBancaire> ImportXML(string chemin)
        {
            XmlSerializer xmlS = new XmlSerializer(typeof(List<CompteBancaire>));
            Stream st = new FileStream(chemin, FileMode.Open);
            List<CompteBancaire> liste = (List<CompteBancaire>)xmlS.Deserialize(st);
            st.Close();
            return liste;
        }

        //Méthode de sérialisation JSON
        public static void ExportJSON(string chemin, List<CompteBancaire> liste)
        {
            DataContractJsonSerializer json = new DataContractJsonSerializer(liste.GetType());
            Stream st = new FileStream(chemin, FileMode.Create);
            json.WriteObject(st, liste);
            st.Close();
        }

        //Méthode de désérialisation JSON
        public static List<CompteBancaire> ImportJSON(string chemin)
        {
            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(List<CompteBancaire>));
            Stream st = new FileStream(chemin, FileMode.Open);
            List<CompteBancaire> liste = (List<CompteBancaire>)json.ReadObject(st);
            st.Close();
            return liste;
        }
    }
}
