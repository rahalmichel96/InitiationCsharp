using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.Exceptions
{
    //Pour créer ses propres exceptions 2 choses à faire
    //1- On doit hériter de la classe exception
    //2- On doit appeler le constructeur de la classe exception
    class SoldeInsuffisantException : Exception
    {
        public SoldeInsuffisantException(string message) : base(message)
        {
        }
    }
}
