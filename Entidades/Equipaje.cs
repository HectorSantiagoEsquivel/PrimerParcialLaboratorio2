using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipaje
    {
        public double peso { get; set; }   
        public Equipaje(double pesoAsignado)
        {
            peso = pesoAsignado;
        }
    
    }

}
