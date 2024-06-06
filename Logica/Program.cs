using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Ingresa un numero: ");
            Console.WriteLine($"El numero que ingresaste es: {Console.ReadLine()}");
            string input = Console.ReadLine();

            Console.WriteLine(input);
            Console.ReadLine();
        }
    }
}


/* Number Mirror
Write a program that takes a number N as the input, and prints it to the output.

Input Format
The only line of input contains a single integer.

Output Format
Output the answer in a single line.

Constraints
0 ≤ 𝑁 ≤ 10 5 ≤ N ≤ 10 5
 
Sample 1:
Input
Output
123
123
Explanation:
The input is 123. So the output is also 123.

Sample 2:
Input
Output
15
15
Explanation:
The input is 15. So the output is also 15.*/