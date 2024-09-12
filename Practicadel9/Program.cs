using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicadel9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int cp = 0;
            int ci = 0;
            Console.WriteLine("Digite los datos del arreglo");
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingresa un número");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Datos del arreglo");
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(numeros[i] + ", ");
                if (numeros[i] % 2 == 0) cp++;
                else ci++;
            }
            Console.WriteLine(" ");
            Console.WriteLine("La cantidad de pares es:" + cp);
            Console.WriteLine("La cantidad de impares es:" + ci);
            Console.ReadKey();
        }
    }
}
