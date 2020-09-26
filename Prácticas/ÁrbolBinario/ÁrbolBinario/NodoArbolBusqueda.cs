using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÁrbolBinario
{
    public class NodoArbolBusqueda
    {
        public NodoArbol nodoRaíz; //variable para el nodo raíz
        public NodoArbol nodoAnterior; //variable donde se guardará el nodo anterior 
        public NodoArbol nodoSiguiente; //variable donde se guardará el siguiente nodo
        public NodoArbol nodoRecorrido; //variable donde se guardará el recorrido
        public NodoArbol nodoAuxiliar; //variable donde se guardará el auxiliar
        int dato,altura;string nombre;
        bool Encontrado = false;
        public bool Grado1 = false, Grado2 = false;
        public NodoArbolBusqueda()
        {
            nodoRaíz = null;
        }
        public void InsertarNodo()
        {
            NodoArbol NuevoNodo = new NodoArbol(dato, nombre);
            Console.WriteLine("Ingresa el dato para el árbol binario de búsqueda");
            dato = Convert.ToInt32(Console.ReadLine());
            NuevoNodo.Dato = dato;
            if(nodoRaíz == null) //Si el árbol está vacío
            {
                nodoRaíz = NuevoNodo;
            }
            else if(BuscarDato(dato)!= null)
            {
                Console.WriteLine("El valor ingresado " + dato + " ya se encuentra en el árbol");
            }
            else
            {
                NodoArbol nodoAnterior = null; //Aquí está el nodo padre
                NodoArbol nodoRecorrido = nodoRaíz; //Aquí se encuentra el nodo auxiliar
                while(nodoRecorrido != null) //se inicia el while para recorrer el árbol, y si el dato es nulo se detendrá
                {
                    nodoAnterior = nodoRecorrido;
                    if(dato < nodoRecorrido.Dato) //condicional que le indica que el recorrido se va a hacer por la izquierda del árbol en caso de que el dato ingresado sea menor
                    {
                        nodoRecorrido = nodoRecorrido.RamaIzquierda;
                    }
                    else //condicional else que le indica que el recorrido se va a hacer por la derecha del árbol en caso de que el dato ingresado sea mayor
                    {
                        nodoRecorrido = nodoRecorrido.RamaDerecha;
                    }
                }//fin del while
                if(dato < nodoAnterior.Dato) //una vez encontrado el dato se inserta por la izquierda (si es menor) y por la derecha (si es mayor)
                {
                    nodoAnterior.RamaIzquierda = NuevoNodo;
                    Grado1 = true;
                }
                else
                {
                    nodoAnterior.RamaDerecha = NuevoNodo;
                    Grado2 = true;
                }
            }
        }
        private void ImprimirPreOrden(NodoArbol NodoRecorrido) //método para darle instrucciones para hacer el recorrido preorden
        {
            if(NodoRecorrido != null) //condición para iniciar el recorrido en preorden
            {
                Console.WriteLine(NodoRecorrido.Dato + "\t");
                ImprimirPreOrden(NodoRecorrido.RamaIzquierda); //aquí se hace el recorrido por la izquierda en el preorden.
                ImprimirPreOrden(NodoRecorrido.RamaDerecha); //aquí se hace el recorrido por la derecha en el preorden
            }
        }
        public void ImprimirPreOrden() //método para imprimir en pantalla el preorden
        {
            ImprimirPreOrden(nodoRaíz);//se empieza por el nodo raíz
            Console.WriteLine();
        }
        private void ImprimirInOrden(NodoArbol NodoRecorrido) //método para darle instrucciones para hacer el recorrido inorden
        {
            if(NodoRecorrido != null) //condición para iniciar el recorrido en inorden
            {
                ImprimirInOrden(NodoRecorrido.RamaIzquierda);
                Console.WriteLine(NodoRecorrido.Dato + "\t");
                ImprimirInOrden(NodoRecorrido.RamaDerecha);
            }
        }
        public void ImprimirInorden() //método para imprimir en pantalla el inorden
        {
            ImprimirInOrden(nodoRaíz); //se empieza por el nodo raíz
            Console.WriteLine();
        }
        private void ImprimirPostOrden(NodoArbol NodoRecorrido) //método para darle instrucciones para hacer el recorrido postorden
        {
            if(NodoRecorrido !=null) //condición para iniciar el recorrido en postorden
            {
                ImprimirPostOrden(NodoRecorrido.RamaIzquierda);
                ImprimirPostOrden(NodoRecorrido.RamaDerecha);
                Console.WriteLine(NodoRecorrido.Dato + "\t");
            }
        }
        public void ImprimirPostOrden() //método para imprimir en pantalla el postorden
        {
            ImprimirPostOrden(nodoRaíz); //se empieza por el nodo raíz
            Console.WriteLine();
        }
        private void ImprimirInverseOrden(NodoArbol NodoRecorrido) //método para darle instrucciones para hacer el recorrido inverso
        {
            if(NodoRecorrido != null)
            {
                ImprimirInOrden(NodoRecorrido.RamaDerecha);
                Console.WriteLine(NodoRecorrido.Dato + "\t");
                ImprimirInOrden(NodoRecorrido.RamaIzquierda);
            }
        }
        public void ImprimirInverseOrden()//método para imprimir en pantalla el inverso
        {
            ImprimirInverseOrden(nodoRaíz);//se empieza por el nodo raíz
            Console.WriteLine();
        }
        public void BusquedaDato()
        {
            if(nodoRaíz == null) //condicional en caso de que el nodo apunte a nulo
            {
                Console.WriteLine("El árbol está vacío");
            }
            else //Condicional en caso de que el nodo apunte a un dato
            {
                Console.WriteLine("Dame un dato para buscar: ");//Imprimir en pantalla para empezar a buscar
                dato = Convert.ToInt32(Console.ReadLine()); //variable donde se van a convertir y guardar el dato a buscar
                if(dato == nodoRaíz.Dato)//condicional en caso de que el dato buscado es la raíz
                {
                    Console.WriteLine("\t\tValor encontrado\n");
                    Console.WriteLine("El valor buscado "+dato + " es la raíz del árbol ---> "+nodoRaíz.Dato);
                }
                else //en caso de que el dato sea diferente a la raíz
                {
                    if(BuscarDato(dato) == null)
                    {
                        Console.WriteLine("El valor buscado " + dato + " no se encuentra en el árbol");
                    }
                    else
                    {
                        Console.WriteLine("El valor buscado " + dato + " se encuentra en el árbol ---> " + nodoRaíz.Dato);
                    }
                }
            }
        }
        public NodoArbol BuscarDato(int dato) //método en el que se hará el proceso de búsqueda
        {
            NodoArbol NodoRecorrido = nodoRaíz;
            while(NodoRecorrido.Dato != dato)
            {
                if(dato < NodoRecorrido.Dato) //xondición para determinar que el recorrido será a la izquierda si el dato es menor al nodo
                {
                    NodoRecorrido = NodoRecorrido.RamaIzquierda;
                }
                else //condición para determinar que el dato es mayor y el recorrido es a la derecha
                {
                    NodoRecorrido = NodoRecorrido.RamaDerecha;
                }
                if(NodoRecorrido == null)//si no encuentra datos
                {
                    return null;
                }
            }
            return NodoRecorrido;
        }
        public void BorrarMenor()
        {
        	if(nodoRaíz == null) //condición en caso de que el nodo raíz apunte a null
        	{
        		Console.WriteLine("Árbol actualmente está vacío");
        	}
        	else //en caso de que el nodo raíz apunte a algún dato
        	{
                if(nodoRaíz != null)//aquí se empieza a hacer el recorrido del árbol
                {
                    if (nodoRaíz.RamaIzquierda==null) //determina la eliminación del dato si es este corresponde a la raíz, redireccionando las ramas
                    {
                        nodoRaíz = nodoRaíz.RamaDerecha;
                    }
                    else //determina la eliminación del dato que no es la raíz, haciendo el recorrido hasta que encuentre el menor
                    {
                        NodoArbol NodoAtras = nodoRaíz;
                        NodoArbol NodoRecorrido = nodoRaíz.RamaIzquierda;
                        while (NodoRecorrido.RamaIzquierda != null)//aquí empieza el ciclo while para el recorrido por rama izquierda
                        {
                            NodoAtras = NodoRecorrido;//se le va asignando datos al nodo de atrás conforme se va recorriendo
                            NodoRecorrido =NodoRecorrido.RamaIzquierda; //se le va asignando datos al nodo recorrido conforme se va recorriendo por izquierda
                        }
                        NodoAtras.RamaIzquierda = NodoRecorrido.RamaDerecha;
                    }
                    Console.WriteLine("Se eliminó el dato menor del árbol");
                }
        	}
        }//fin del método
        public void BorrarMayor()
        {
            if (nodoRaíz == null) //condición en caso de que el nodo raíz apunte a null
            {
                Console.WriteLine("Árbol actualmente está vacío");
            }
            else //en caso de que el nodo raíz apunte a algún dato
            {
                if (nodoRaíz != null)//aquí se empieza a hacer el recorrido del árbol
                {
                    if (nodoRaíz.RamaDerecha == null) //determina la eliminación del dato si es este corresponde a la raíz, redireccionando las ramas
                    {
                        nodoRaíz = nodoRaíz.RamaIzquierda;
                    }
                    else //determina la eliminación del dato que no es la raíz, haciendo el recorrido hasta que encuentre el mayor
                    {
                        NodoArbol NodoAtras = nodoRaíz;
                        NodoArbol NodoRecorrido = nodoRaíz.RamaDerecha;
                        while (NodoRecorrido.RamaDerecha != null)//aquí empieza el ciclo while para el recorrido por rama derecha
                        {
                            NodoAtras = NodoRecorrido;//se le va asignando datos al nodo de atrás conforme se va recorriendo
                            NodoRecorrido = NodoRecorrido.RamaIzquierda; //se le va asignando datos al nodo recorrido conforme se va recorriendo por derecha
                        }
                        NodoAtras.RamaDerecha = NodoRecorrido.RamaIzquierda;
                    }
                    Console.WriteLine("Se eliminó el dato mayor del árbol");
                }
            }
        }//fin del método
        public Boolean EliminarDato()
        {
            if(nodoRaíz == null) //condición para determinar que el nodo raíz del árbol está apuntando a un dato nulo.
            {
                Console.WriteLine("El árbol está actualmente vacío");
            }
            else //condición para determinar que el nodo raíz del árbol está apuntando a un dato diferente de nulo.
            {
                Console.WriteLine("Ingrese el dato que desea eliminar: ");
                dato = Convert.ToInt32(Console.ReadLine());
                NodoArbol NodoRecorrido = nodoRaíz;
                NodoArbol NodoPadre = nodoRaíz;
                Boolean HijoIzquierdo = true;
                while(NodoRecorrido.Dato != dato) //aquí comienza a hacer la búsqueda en el árbol.
                {
                    NodoPadre = NodoRecorrido;
                    if(dato < NodoRecorrido.Dato)//condición para determinar que se empezará a hacer el recorrido por el lado izquierdo
                    {
                        HijoIzquierdo = true;
                        NodoRecorrido = NodoRecorrido.RamaIzquierda;
                    }
                    else //condición para determinar que se empezará a hacer el recorrido por el lado derecho
                    {
                        HijoIzquierdo = false;
                        NodoRecorrido = NodoRecorrido.RamaDerecha;
                    }
                }//fin del while
                if(NodoRecorrido.RamaIzquierda == null && NodoRecorrido.RamaDerecha == null)//condición para determinar si el nodo es hoja o hijo único
                {
                    if (NodoRecorrido == nodoRaíz) //condición que determinar que el nodo a eliminar es raíz.
                    {
                        nodoRaíz = null;
                    }
                    else if (HijoIzquierdo) //si es nodo hoja y menor a la raíz.
                    {
                        NodoPadre.RamaIzquierda = null;
                    }
                    else //si es nodo hoja y mayor a la raíz
                    {
                        NodoPadre.RamaDerecha = null;
                    }
                }
                else if(NodoRecorrido.RamaDerecha == null) //determina si el dato a eliminar no es hoja y tiene ramas a la izquierda
                {
                    if(NodoRecorrido == nodoRaíz) //condición que determinar que el nodo a eliminar es raíz.
                    {
                        nodoRaíz = NodoRecorrido.RamaDerecha;
                    }
                    else if(HijoIzquierdo) //si es menor a la raíz
                    {
                        NodoPadre.RamaIzquierda = NodoRecorrido.RamaIzquierda;
                    }
                    else //si es mayor a la raíz
                    {
                        NodoPadre.RamaDerecha = NodoRecorrido.RamaIzquierda;
                    }
                }
                else if(NodoRecorrido.RamaIzquierda == null) //determina si el dato a eliminar no es hoja y tiene ramas a la derecha
                {
                    if(NodoRecorrido == nodoRaíz) //condición que determinar que el nodo a eliminar es raíz.
                    {
                        nodoRaíz = NodoRecorrido.RamaDerecha;
                    }
                    else if(HijoIzquierdo) //si es menor a la raíz
                    {
                        NodoPadre.RamaIzquierda = NodoRecorrido.RamaDerecha;
                    }
                    else //si es mayor a la raíz
                    {
                        NodoPadre.RamaDerecha = NodoRecorrido.RamaIzquierda;
                    }
                }
                else //si el dato a eliminar no es hoja, ni tiene una única rama
                {
                    NodoArbol NodoReemplazo = ObtenerNodoReemplazo(NodoRecorrido);
                    if(NodoRecorrido == nodoRaíz) //si es igual a la raíz
                    {
                        nodoRaíz = NodoReemplazo;
                    }
                    else if(HijoIzquierdo) //si es menor el dato
                    {
                        NodoPadre.RamaIzquierda = NodoReemplazo;
                    }
                    else //si es mayor el dato
                    {
                        NodoPadre.RamaDerecha = NodoReemplazo;
                    }
                    NodoReemplazo.RamaIzquierda = NodoRecorrido.RamaIzquierda;  
                }
            }
            return true;
        } //fin del método eliminar
        public NodoArbol ObtenerNodoReemplazo(NodoArbol NodoReemp)//método para reemplazar dato eliminado
        {
            NodoArbol NodoReemplazoPadre = NodoReemp;
            NodoArbol NodoReemplazo = NodoReemp;
            NodoArbol NodoRecorrido = NodoReemp.RamaDerecha;
            while(NodoRecorrido != null)
            {
                NodoReemplazoPadre = NodoReemplazo;
                NodoReemplazo = NodoRecorrido;
                NodoRecorrido = NodoRecorrido.RamaIzquierda;
            }
            if(NodoReemplazo != NodoReemp.RamaDerecha) //condición para acomodar los nodos del árbol
            {
                NodoReemplazoPadre.RamaIzquierda = NodoReemplazo.RamaDerecha;
                NodoReemplazo.RamaDerecha = NodoReemp.RamaDerecha;
            }
            Console.WriteLine("El nodo reemplazo del nodo eliminado es: " + NodoReemplazo.Dato);
            return NodoReemplazo;
        }
        public void EsRaiz() //método para determinar si el dato es raíz o no
        {
            if(nodoRaíz == null) //determina que el árbol está vacío
            {
                Console.WriteLine("Árbol vacío");
            }
            else
            {
                Console.WriteLine("La raíz del árbol es -->  "+nodoRaíz.Dato);
            }
        }
        private void AlturaArbol(NodoArbol NodoRecorrido, int nivel) //método para calcular la altura del árbol
        {
            if (NodoRecorrido != null)//condición para decir que la raíz está apuntando a un dato diferente de nulo
            {
                AlturaArbol(NodoRecorrido.RamaIzquierda, nivel+1);
                if (nivel > altura)
                {
                    altura = nivel;
                }
                AlturaArbol(NodoRecorrido.RamaDerecha, nivel+1);
            }
        }
        public int AlturaArbol()
        {
            altura = 0;
            AlturaArbol(nodoRaíz, 1);
            return altura;
        }

    }
}
