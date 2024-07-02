using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassEntidades;
using ClassPersistencia;
using Newtonsoft.Json;

namespace ClassLogicaNegocios
{
  public class ArbolB
  {
        private Arbol ArbolBina = new Arbol();

        public string AgregarAArbol(NodoArbol valor)
        {
            return ArbolBina.Insertar(valor);
        }
        public List<int> ObtenerValoresInOrden()
        {
            List<int> valores = new List<int>();
            ArbolBina.RecorrerInorden1(ArbolBina.raiz, valores);
            return valores;
        }

        public List<int> ObtenerValoresPreOrden()
        {
            List<int> valores = new List<int>();
            ArbolBina.RecorrerPreorden1(ArbolBina.raiz, valores);
            return valores;
        }

        public List<int> ObtenerValoresPostOrden()
        {
            List<int> valores = new List<int>();
            ArbolBina.RecorrerPostOrden1(ArbolBina.raiz, valores);
            return valores;
        }
        public List<int> ObtenerValoresNiveles()
        {
            return ArbolBina.RecorrerNiveles();
        }
        public string Buscar(int valor)
        {
            return ArbolBina.BuscarNodo(valor);
        }
    }
}
