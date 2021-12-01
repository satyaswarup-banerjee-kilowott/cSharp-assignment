using System.Collections.Generic;
using System.Linq;

namespace OopsTechnique_assignment
{
    internal class Program
    {
        static int[] data = { 40, 38, 37, 36, 34, 33, 32, 31, 30, 30, 30, 29, 26, 26, 19 };
        static void Main(string[] args)
        {
            var spObject = new Stats();
            var spObject1 = new Stats();
            var spObject2 = new Stats();

            spObject.Numbers = data;
            spObject1.Numbers = data;
            spObject2.Numbers = data;

            var mean = spObject.CalculateMean();
            var median = spObject1.CalculateMedian();
            var mode = spObject2.CalculateMode();

            Console.WriteLine($"Mean: {mean}");
            Console.WriteLine($"Median: {median}");
            Console.WriteLine($"Mode: {mode}");


        }
    }
}

