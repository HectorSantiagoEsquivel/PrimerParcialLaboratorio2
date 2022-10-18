using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Destino
    {
        public string nombreDestino { get; set; }
        public double acumuladorFacturacion;
        public int acumuladorVecesElegido;
        public TipoServicio tipoServicio;
        public List<Vuelo> vuelosRealizados;
        public Destino instancia { get; }

        public Destino(string nombreDestinoAsignado, TipoServicio tipoServicioAsignado)
        {
            nombreDestino = nombreDestinoAsignado;
            tipoServicio = tipoServicioAsignado;
            acumuladorFacturacion = 0;
            acumuladorVecesElegido = 0;
            vuelosRealizados = new List<Vuelo>();
            instancia = this;
        }

        public static List<Destino> InicializarListaDestinos()
        {
            List<Destino> listaDestinos = new List<Destino>()
            {
                //Vuelos Nacionales
                new Destino("Santa Rosa", TipoServicio.cabotaje),
                new Destino("Bariloche", TipoServicio.cabotaje),
                new Destino("Corrientes", TipoServicio.cabotaje),
                new Destino("Córdoba", TipoServicio.cabotaje),
                new Destino("Jujuy", TipoServicio.cabotaje),
                new Destino("Mendoza", TipoServicio.cabotaje),
                new Destino("Neuquén", TipoServicio.cabotaje),
                new Destino("Posadas", TipoServicio.cabotaje),
                new Destino("Iguazú", TipoServicio.cabotaje),
                new Destino("Salta", TipoServicio.cabotaje),
                new Destino("Santiago Del Estero", TipoServicio.cabotaje),
                new Destino("Trelew", TipoServicio.cabotaje),
                new Destino("Tucumán", TipoServicio.cabotaje),
                new Destino("Puerto Madryn", TipoServicio.cabotaje),
                new Destino("Ushuaia", TipoServicio.cabotaje),
                //Vuelos Internacionales
                new Destino("Recife", TipoServicio.internacional),
                new Destino("Roma", TipoServicio.internacional),
                new Destino("Acapulco", TipoServicio.internacional),
                new Destino("Miami", TipoServicio.internacional)
            };

            return listaDestinos;
        }

        public static double acumularRecaudacionDestinos(List <Destino> listaDestinos, TipoServicio servicio)
        {
            double auxiliarAcumulador=0;
            foreach(var Destino in listaDestinos.Where(Destino=>Destino.tipoServicio==servicio))
            {
                auxiliarAcumulador = auxiliarAcumulador + Destino.acumuladorFacturacion;
            }
            return auxiliarAcumulador;
        }

        public static string buscarDestinoMasElegido(List <Destino> listaDestinos)
        {
            int acumuladorDestinoMasElegido = 0;
            string nombreMasElegidoAuxiliar="Error";
            foreach (var Destino in listaDestinos)
            {
                if (Destino.acumuladorVecesElegido > acumuladorDestinoMasElegido)
                {
                    acumuladorDestinoMasElegido = Destino.acumuladorVecesElegido;
                    nombreMasElegidoAuxiliar = Destino.nombreDestino;
                }
            }
            return nombreMasElegidoAuxiliar;
        }

        public TipoServicio TipoServicio
        {
            get => default;
            set
            {
            }
        }
    }

    public enum TipoServicio
    {
        cabotaje,
        internacional

    }
}
