using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Usuario
    {
        static readonly Dictionary<string, string> usuarios = new Dictionary<string, string>
       {
           {"Pepe", "Pepi" },
           {"Santiago", "Esquivel" },
           {"Usuario", "contraseña" },
           {"Uno", "Dos" }
       };


        public static bool ValidarUsuario(string usuarioIngresado, string contraIngresada)
        {
            
            bool retorno =false;
            if (usuarioIngresado != null && contraIngresada != "" && usuarios.ContainsKey(usuarioIngresado) &&usuarios[usuarioIngresado].Contains(contraIngresada))
            {
                retorno=true;

            }
            return retorno;
        }
    }
}

