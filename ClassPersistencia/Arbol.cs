using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassEntidades;
using Newtonsoft.Json;

namespace ClassPersistencia
{
    public class Arbol
    {
        [JsonProperty]
        public Nodo raiz = null;    //Referencia a la clase de nodo "raíz"
        private Nodo InsertarR(Nodo nodo, NodoArbol entidad)
        {
            if (nodo == null)
            { //Es el primer nodo "Raiz"
                raiz = new Nodo(entidad);
                return raiz;
            }
            if (entidad.Valor < nodo.dato.Valor)
            {
                nodo.Izquierda = InsertarR(nodo.Izquierda, entidad);
            }
            else if (entidad.Valor > nodo.dato.Valor)
            {
                nodo.Derecha = InsertarR(nodo.Derecha, entidad);
            }
            return nodo;
        }
        public string Insertar(NodoArbol entidad)
        {
            Nodo nuevo = new Nodo(entidad);
            string mensaje = "";
            if (raiz == null)
            {
                raiz = nuevo;
                mensaje = "Se inserto el primer nodo, Raiz";

            }
            else
            {
                raiz = InsertarR(raiz, entidad);
                mensaje = "Se inserto correctamente el nodo";
            }
            return mensaje;
        }
        public void RecorrerInorden1(Nodo nodo, List<int> valores)
        {
            if (nodo != null)
            {
                RecorrerInorden1(nodo.Izquierda, valores);
                valores.Add(nodo.dato.Valor); // Agregar el valor a la lista en lugar de imprimirlo
                RecorrerInorden1(nodo.Derecha, valores);
            }
        }
        public void RecorrerInorden()
        {
            List<int> valoresInOrden = new List<int>(); // Crea una lista para almacenar los valores de postorden
            RecorrerInorden1(raiz, valoresInOrden); // Pasa la lista como segundo argumento
        }

        public void RecorrerPreorden1(Nodo nodo, List<int> valores)
        {
            if (nodo != null)
            {
                valores.Add(nodo.dato.Valor); // Agregar el valor a la lista en lugar de imprimirlo
                RecorrerPreorden1(nodo.Izquierda, valores);
                RecorrerPreorden1(nodo.Derecha, valores);
            }
        }
        public void RecorrerPreorden()
        {
            List<int> valoresPreOrden = new List<int>(); // Crea una lista para almacenar los valores de postorden
            RecorrerPreorden1(raiz, valoresPreOrden); // Pasa la lista como segundo argumento
        }

        public void RecorrerPostOrden1(Nodo nodo, List<int> valores)
        {
            if (nodo != null)
            {
                RecorrerPostOrden1(nodo.Izquierda, valores);
                RecorrerPostOrden1(nodo.Derecha, valores);
                valores.Add(nodo.dato.Valor); // Agregar el valor a la lista en lugar de imprimirlo
            }
        }
        public void RecorrerPostOrden()
        {
            List<int> valoresPostOrden = new List<int>(); // Crea una lista para almacenar los valores de postorden
            RecorrerPostOrden1(raiz, valoresPostOrden); // Pasa la lista como segundo argumento
        }

        public List<int> RecorrerNiveles()
        {
            List<int> valoresPorNiveles = new List<int>();
            if (raiz == null)
            { //Si la raiz es null se regresa una lista vacía
                return valoresPorNiveles;
            }
            Queue<Nodo> Cola = new Queue<Nodo>();
            Cola.Enqueue(raiz);
            while (Cola.Count > 0)
            {
                //Devolver el primer elemento de la cola
                Nodo actual = Cola.Dequeue();
                valoresPorNiveles.Add(actual.dato.Valor);

                if (actual.Izquierda != null)
                {//Enqueue va a añadir un elemento al final de la cola
                    Cola.Enqueue(actual.Izquierda);
                }
                if (actual.Derecha != null)
                {
                    Cola.Enqueue(actual.Derecha);
                }
            }
            return valoresPorNiveles;
        }

        public Nodo Buscar(Nodo nodo, int valor)
        {
            if (nodo == null || nodo.dato.Valor == valor)
            {
                return nodo;
            }
            if (valor < nodo.dato.Valor)
            {
                return Buscar(nodo.Izquierda, valor);
            }
            return Buscar(nodo.Derecha, valor);
        }
        public string BuscarNodo(int valor)
        {
            Nodo nodoEncontrado = Buscar(raiz, valor);
            string mensaje = "";
            if (nodoEncontrado != null)
            {
                mensaje = $"Se encontro el nodo: {valor}";
            }
            else
            {
                mensaje = $"No se encontró el nodo";
            }
            return mensaje;
        }
    }
}
