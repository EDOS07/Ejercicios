using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Chef defines a pair of positive integers (𝑎,𝑏) to be a Oneful Pair, if
            𝑎+𝑏+(𝑎⋅𝑏)=111
            For example,(1,55) is a Oneful Pair, since 1+55+(1⋅55)=56+55=111 
            But (1,56) is not a Oneful Pair, since 1+56+(1⋅56)=57+56=113≠111

            Given two positive integers 𝑎 and 𝑏, output Yes if they are a Oneful Pair. And No otherwise.*/
            Console.WriteLine("dado uno y dos");
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            
            if (a + b + (a * b) == 111)
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
