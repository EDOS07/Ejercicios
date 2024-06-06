using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_11
{
    internal class Program
    {
        static void Main(string[] args)
        { // Definir los pares a verificar
            int[,] pairs = {
                {1, 55},
                {55, 1},
                {7, 13},
                {7, 14}
            };

            // Verificar cada par
            for (int i = 0; i < pairs.GetLength(0); i++)
            {
                int a = pairs[i, 0];
                int b = pairs[i, 1];

                if (IsOnefulPair(a, b))
                {
                    Console.WriteLine($"({a}, {b}) es un Oneful Pair");
                }
                else
                {
                    Console.WriteLine($"({a}, {b}) no es un Oneful Pair");
                }                
            }
            Console.ReadLine();
        }

        // Método para determinar si un par es un "Oneful Pair"
        static bool IsOnefulPair(int a, int b)
        {
            return a + b + (a * b) == 111;
        }
    }
}
