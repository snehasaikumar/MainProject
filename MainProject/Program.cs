using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Submodule;

namespace MainProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hellooooo");


            //test
            var calculate = new Calculate();
            Console.WriteLine("Adding numbers 1728 and 1: " + calculate.Add(1728, 1));
            Console.WriteLine("Subtracting numbers 1730 and 1: " + calculate.Subtract(1730, 1));
            Console.ReadLine();

        }
    }
}
