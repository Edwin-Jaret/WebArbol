using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassEntidades
{
    public class NodoArbol
    {
        [JsonProperty]
        public int Valor { get; set; }
    }
}
