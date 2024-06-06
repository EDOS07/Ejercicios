using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Logica_7
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            Multiple Choice Question
            In C#, what statement do you use to check whether a variable A is equal to 2 ?
            And if it is, print 9.

            Option 1:

            if (a = 2):
                    Console.WriteLine(9);
            Option 2:

            if (a == 2):
                    Console.WriteLine(9);

            Option 3:

            if (a == 2)
            {
                    Console.WriteLine(9);
            }
            Option 4:

            if (a = 2)
            {
                    Console.WriteLine(9);
            }*/

            //opcion 2
            var a = 2;

            if (a == 2)
            {
                Console.WriteLine(9);
                Console.ReadLine(); 
            }
        }
    }
}
