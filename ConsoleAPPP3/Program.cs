using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAPPP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            {
                int[,] tabla1 = new int[3, 3];
                int f, c;

                Console.WriteLine("Arrays bidimensionales");
                Console.WriteLine("Digita los datos del array");

                // Llenar el array
                for (f = 0; f < 3; f++)
                {
                    for (c = 0; c < 3; c++)
                    {
                        tabla1[f, c] = int.Parse(Console.ReadLine());
                    }
                }

                // Imprimir el array
                Console.WriteLine("Imprimiendo el Array");
                for (f = 0; f < 3; f++)
                {
                    for (c = 0; c < 3; c++)
                    {
                        Console.Write(tabla1[f, c] + " , ");
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
        }
    }


}

