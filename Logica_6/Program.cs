using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Currently there are courses for 4 languages, and hence there are 8 courses in this section. But suppose there are courses for 𝑁
               N languages, what will be the total number of courses in this section?*/
            
            Console.WriteLine("Ingrese el número de idiomas: ");
            int N = int.Parse(Console.ReadLine());
            int totalCursos = 2 * N;

            Console.WriteLine($"El número total de cursos en la sección es: {totalCursos}");
            Console.ReadLine();
        }
    }
}
