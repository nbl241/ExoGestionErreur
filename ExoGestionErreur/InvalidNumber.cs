using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoGestionErreur
{
    public class InvalidNumber : Exception
    {
        public InvalidNumber()
            : base("Saisie invalide !!")
        {
        }
    }
}
