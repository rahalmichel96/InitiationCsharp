using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.ConceptsObjets.Association
{
    public class Client
    {
        public string Nom { get; set; }
        public Adresse Adresse { get; set; } // Association: un objet de type Adresse fait partie des attributs d'un objet client
    }
}
