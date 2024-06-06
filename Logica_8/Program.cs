using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //If Chef is prone to errors print YES, otherwise print NO.

            string[] s = Console.ReadLine().Split(' ');
            int x = int.Parse(s[0]);
            int y = int.Parse(s[1]);

            
            if (y > x)
            {               
                Console.WriteLine("YES");
            }
            else
            {               
                Console.WriteLine("NO");
            }
            Console.ReadLine();
        }
    }
}
