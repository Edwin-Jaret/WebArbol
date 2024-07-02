using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

using ClassEntidades;

namespace ClassPersistencia
{
    public class Nodo
    {
        [JsonProperty]
        public NodoArbol dato { get; set; }
        [JsonProperty]
        public Nodo Izquierda { get; set; }
        [JsonProperty]
        public Nodo Derecha { get; set; }

        //Metodo constructor para el nodo
        public Nodo(NodoArbol entidad)
        {
            dato = entidad;
            Izquierda = null;
            Derecha = null;
        }
    }
}
