using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservacionAvion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[] asientos = new bool[10];
            while (true)
            {
                Console.WriteLine("Please type 1 for \"smoking\"");
                Console.WriteLine("Please type 2 for \"nonsmoking\"");
                int opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    if (!AsignarAsiento(asientos, 0, 5))
                    {
                        Console.WriteLine("La sección de fumar está llena. ¿Desea su asiento en la sección de no fumar? (s/n)");
                        if (Console.ReadLine().ToLower() == "s")
                        {
                            if (!AsignarAsiento(asientos, 5, 10))
                            {
                                Console.WriteLine("Next flight leaves in 3 hours.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Next flight leaves in 3 hours.");
                        }
                    }
                }
                else if (opcion == 2)
                {
                    if (!AsignarAsiento(asientos, 5, 10))
                    {
                        Console.WriteLine("La sección de no fumar está llena. ¿Desea su asiento en la sección de fumar? (s/n)");
                        if (Console.ReadLine().ToLower() == "s")
                        {
                            if (!AsignarAsiento(asientos, 0, 5))
                            {
                                Console.WriteLine("Next flight leaves in 3 hours.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Next flight leaves in 3 hours.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                }
            }
        }

        static bool AsignarAsiento(bool[] asientos, int inicio, int fin)
        {
            for (int i = inicio; i < fin; i++)
            {
                if (!asientos[i])
                {
                    asientos[i] = true;
                    Console.WriteLine($"Su número de asiento es {i + 1}. {(inicio == 0 ? "Sección de fumar" : "Sección de no fumar")}");
                    return true;
                }
            }
            return false;
        }
    }
}