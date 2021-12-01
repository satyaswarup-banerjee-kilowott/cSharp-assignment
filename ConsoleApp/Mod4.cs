using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Mod4
    {
        public static void ShowOutput()
        {

            int fahrenheit = 88;
            decimal celsius = (fahrenheit - 32m) * (5m / 9m);
            Console.WriteLine($"The temperature is  {celsius} Celsius.");
        }
    }
}
