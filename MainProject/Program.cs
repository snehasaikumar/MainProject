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
            Console.WriteLine("I know it works... ;)");

            var helper = new Helper();
            Console.WriteLine(helper.GetStatus());

            Console.ReadLine();

        }
    }
}
