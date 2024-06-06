using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_14
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            int T = int.Parse(Console.ReadLine());
           
            for (int i = 0; i < T; i++)
            {               
                string[] inputs = Console.ReadLine().Split(' ');
                int A = int.Parse(inputs[0]);
                int B = int.Parse(inputs[1]);
                
                int sum = A + B;                
                Console.WriteLine(sum);
            }
            Console.ReadLine();
        }
    }
}
