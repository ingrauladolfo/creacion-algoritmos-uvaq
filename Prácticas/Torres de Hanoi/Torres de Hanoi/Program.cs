using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void TorresHanoi(int n,int o, int aux, int d)
        {
            if (n > 0)
            {
                TorresHanoi(n - 1, o, aux, d);
                Console.WriteLine("Se mueve el anillo "+n+" desde la torre " + o + " hasta la torre " + d);
                TorresHanoi(n - 1, aux, d, o);
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("De favor ingrese el número de discos: ");
            n = int.Parse(Console.ReadLine());
            TorresHanoi(n, 1,3,2);
            Console.ReadKey();
        }
    }
}
