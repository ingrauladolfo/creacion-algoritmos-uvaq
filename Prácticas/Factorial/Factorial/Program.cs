using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Factorial
{
    class Program
    {
       public static int factorial(int numero)
        {
            if (numero == 0 || numero == 1)
            {
                Console.WriteLine("1 x");
                return 1;
            }
            Console.WriteLine("{0} x ", numero);
            return numero * factorial(numero - 1);
        }
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Introduce un número: ");
            String n = Console.ReadLine();
            if(int.TryParse(n,out numero))
            {
                numero = factorial(numero);
                int resultado = numero;
                Console.WriteLine("El factorial de "+n+" es: "+resultado);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Datos inválidos");
            }
        }
    }
}
