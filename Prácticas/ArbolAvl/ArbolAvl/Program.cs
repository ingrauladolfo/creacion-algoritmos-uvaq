using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolAvl
{
    class Nodo
    {

        public int dato;
        public Nodo izq;
        public Nodo der;
    }
    class Arbol
    {
        public Nodo nPadre;
        public bool padreOk;
        public Nodo raiz;
        public void recorrido(Nodo a)
        {
            if (a == null)
            {
                return;
            }
            recorrido(a.izq);
            Console.WriteLine(a.dato);
            recorrido(a.der);

        }
        public Nodo buscaPadre(Nodo var, Nodo nuevo)
        {
            if (padreOk == true)
            {
                return null;
            }
            if (var == null)
            {
                return null;
            }
            if (nuevo.dato < var.dato && var.izq == null)
            {
                padreOk = true;
                nPadre = var;
                return null;
            }
            Nodo tizq = buscaPadre(var.izq, nuevo);
            if (nuevo.dato > var.dato && var.der == null)
            {
                padreOk = true;
                nPadre = var;
                return null;
            }
            Nodo tder = buscaPadre(var.der, nuevo);
            return null;
        }
        public void agregar(Arbol a, int b)
        {

            Nodo x = new Nodo();
            x.dato = b;
            //Cuando la raíz es null.
            if (raiz == null)
            {
                raiz = x;
                return;
            }
            //Ubica el apuntador rootTemp en el nodo padre del nuevo nodo
            padreOk = false;
            Nodo rootTemp = buscaPadre(raiz, x);
            rootTemp = nPadre;
            //Agrega otro elemento
            if (rootTemp.izq == null && rootTemp.der == null)
            {

                if (x.dato < rootTemp.dato)
                {
                    rootTemp.izq = x;
                }
                else
                {
                    rootTemp.der = x;
                }
                return;
            }

            if (rootTemp.dato > x.dato && rootTemp.izq == null)
            {
                rootTemp.izq = x;
                return;
            }
            if (rootTemp.dato < x.dato && rootTemp.der == null)
            {
                rootTemp.der = x;
                return;
            }
            if (rootTemp.dato < x.dato && rootTemp.der != null && rootTemp.izq == null)
            {
                Nodo temp = new Nodo();
                temp = rootTemp;
                rootTemp = rootTemp.der;
                rootTemp.der = x;
                temp.der = null;
                rootTemp.izq = temp;


            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Arbol exa = new Arbol();
                exa.agregar(exa, 4);
                exa.agregar(exa, 9);
                exa.agregar(exa, 11);
                exa.agregar(exa, 3);
                exa.agregar(exa, 2);
                exa.agregar(exa, 10);
                Console.ReadLine();
            }
        }
    }
}
