using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÁrbolBinario
{
    public class NodoArbol //Aquí está la clase de la estructura del árbol binario
    {
        public NodoArbol RamaIzquierda { get; set; }
        public int Dato { get; set; }
        public string Nombre { get; set; }
        public NodoArbol RamaDerecha{get; set; }
        public NodoArbol(int dato, string nombre)
        {
            RamaIzquierda = null;
            this.Dato = dato;
            this.Nombre = nombre;
            RamaDerecha = null;
        }
    }
}
