using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Logica_10
{
    internal class Program
    {
        //Alice has scored X marks in her test and Bob has scored Y marks in the same test.Alice is happy if she scored at least twice the marks
        //of Bob’s score.Determine whether she is happy or not.
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe la puntaciono de Alice y de Bob: ");
            string[] s = Console.ReadLine().Split(' ');
            int x = int.Parse(s[0]);
            int y = int.Parse(s[1]);

            if (x >= 2 * y)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.ReadLine();
        }
    }
}
