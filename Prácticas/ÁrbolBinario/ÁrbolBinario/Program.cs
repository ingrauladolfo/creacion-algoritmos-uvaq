using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÁrbolBinario
{
    class Program
    {
        static void MENU()
        {
            try
            {
                NodoArbolBusqueda ABB = new NodoArbolBusqueda();
                byte Opcion = 0, Opcion1= 0, Opcion2;
                do
                {
                    Console.WriteLine("...Menú principal..."); //imprime el menú principal
                    Console.WriteLine("1.- Insertar nodo en el árbol"); //imprime
                    Console.WriteLine("2.- Buscar nodo en el árbol");
                    Console.WriteLine("3.- Eliminar nodo en el árbol");
                    Console.WriteLine("4.- Imprimir recorridos del árbol");
                    Console.WriteLine("5.- Imprimir la altura del árbol");
                    Console.WriteLine("6.- Salir");
                    Console.WriteLine("Seleccione una opción:");
                    Opcion = Convert.ToByte(Console.ReadLine());
                    switch (Opcion)
                    {
                        case 1:
                            Console.WriteLine("Insertar nodo en el árbol");
                            ABB.InsertarNodo();
                            break;
                        case 2:
                            Console.WriteLine("Buscar nodo en el árbol");
                            ABB.BusquedaDato();
                            break;
                        case 3:
                            try
                            {
                                do
                                {
                                    Console.WriteLine("...Menú para eliminar los nodos del árbol...");
                                    Console.WriteLine("1.- Eliminar nodo dado por el usuario");
                                    Console.WriteLine("2.- Eliminar dato mayor");
                                    Console.WriteLine("3.- Eliminar dato menor");
                                    Console.WriteLine("4.- Regresar al menú principal");
                                    Console.WriteLine("...Seleccione una opción...");
                                    Opcion1 = Convert.ToByte(Console.ReadLine());
                                    switch (Opcion1)
                                    {
                                        case 1:
                                            Console.WriteLine("Eliminar nodo dado por el usuario");
                                            ABB.EliminarDato();
                                            break;
                                        case 2:
                                            Console.WriteLine("Eliminar dato mayor");
                                            ABB.BorrarMayor();
                                            break;
                                        case 3:
                                            Console.WriteLine("Eliminar dato menor");
                                            ABB.BorrarMenor();
                                            break;
                                        case 4:
                                            Console.WriteLine("Regresar al menú principal");
                                            break;
                                        default:
                                            Console.WriteLine("Opción incorrecta");
                                            Console.ReadKey();
                                            break;
                                    }
                                } while (Opcion1 != 4);
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine("Error: " + e.Message);
                            }
                            break;
                        case 4:
                            try
                            {
                                do
                                {
                                    Console.WriteLine("...Menú para imprimir los recorrido de los nodos del árbol...");
                                    Console.WriteLine("1.- Imprimir en preorden"); //preorden
                                    Console.WriteLine("2.- Imprimir en inorden de forma ascendente"); //de forma ascendente
                                    Console.WriteLine("3.- Imprimir en postorden"); //postorden
                                    Console.WriteLine("4.- Imprimir en inorden de forma descendente"); //de forma descendente
                                    Console.WriteLine("5.- Regresar al menú");
                                    Console.WriteLine("...Seleccione una opción...");
                                    Opcion2 = Convert.ToByte(Console.ReadLine());
                                    switch (Opcion2)
                                    {
                                        case 1:
                                            ABB.ImprimirPreOrden();
                                            break;
                                        case 2:
                                            ABB.ImprimirInorden();
                                            break;
                                        case 3:
                                            ABB.ImprimirPostOrden();
                                            break;
                                        case 4:
                                            ABB.ImprimirInverseOrden();
                                            break;
                                        case 5:
                                            Console.WriteLine("Regresar al menú principal");
                                            break;
                                        default:
                                            Console.WriteLine("Opción incorrecta");
                                            Console.ReadKey();
                                            break;
                                    }
                                } while (Opcion2 != 5);
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine("Error: " + e.Message);
                            }
                            break;
                        case 5:
                            Console.WriteLine("La altura del árbol es: "+ABB.AlturaArbol());
                            break;
                        case 6:
                            Environment.Exit(0);
                            break;
                    }
                } while(Opcion != 6);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
        static void Main(string[] args)
        {
            MENU();
        }
    }
}
