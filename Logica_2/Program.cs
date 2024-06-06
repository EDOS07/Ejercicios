using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Rearrange Code
               You want to input two integers, and output their sum.
               Rearrange the code given, so that it does the above task.*/

            Console.WriteLine("Ingresa tu primer numero: ");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa tu segundo numero: ");            
            var b = int.Parse(Console.ReadLine());            
            var sum = a + b;            
            Console.WriteLine($"La suma de tus dos numero es {sum}");
            Console.ReadLine();
        }
    }
}
