using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Validador
    {
        public static bool ValidarString(string stringAValidar)
        {

            bool retorno = false;
            if (stringAValidar != null && stringAValidar != "")
            {
                retorno = true;

            }
            return retorno;
        }
    }
}
