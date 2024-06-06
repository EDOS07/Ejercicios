using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* In the new CodeChef Learn module, under the "Learn Problem Solving" section, there are two courses for each language. For eg. "Python Beginner - Part 1" and "Python Beginner - Part 2". These courses help you get started with CodeChef contests.

Currently there are courses for 4 languages, and hence there are 8 courses in this section. But suppose there are courses for 10 languages, what will be the total number of courses in this section? */

            var cursosIdeomas = 10;
            var cursosSection = 2;

            var total = cursosIdeomas * cursosSection;

            Console.WriteLine($"El numero de cursos es: {total}");
            Console.ReadLine();

        }
    }
}
