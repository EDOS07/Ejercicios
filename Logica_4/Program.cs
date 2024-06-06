using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Chef and Instant Noodles
Chef has invented 1-minute Instant Noodles. As the name suggests, each packet takes exactly 1 minute to cook.

Chef's restaurant has X stoves and only 1 packet can be cooked in a single stove at any minute.

How many customers can Chef serve in Y minutes if each customer orders exactly 1 packet of noodles?

Constraints
1 ≤ 𝑋, 𝑌 ≤ 1000
*/

            
            Console.Write("Ingrese el número de estufas: ");
            int X = int.Parse(Console.ReadLine());            
            Console.Write("Ingrese el número de minutos: ");
            int Y = int.Parse(Console.ReadLine());
            int maxClientes = X * Y;           
            Console.WriteLine("El número máximo de clientes que Chef puede atender es: " + maxClientes);
            Console.ReadLine(); 
        }
    }
}
