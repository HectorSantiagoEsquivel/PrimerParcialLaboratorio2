using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Entidades
{
    public class Validador
    {
        public static bool ValidarString(string stringAValidar)
        {

            
            if (Regex.Match(stringAValidar, "^[A-Z][a-zA-Z]*$").Success)
            {
                return true;

            }
            return false;
        }

        public static bool ValidarDNI(string dni)
        {
            if (Regex.Match(dni, @"^\d{11}$").Success)
            {
                return true;
            }

            return false;
        }
    }
}
