using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Stats
    {
        public static void ShowOutput()

        {
            List<int> data = new List<int> { 40, 38, 37, 36, 34, 33, 32, 31, 30, 30, 30, 29, 26, 26, 19 };

            double mean;
            int maxCount = 0;
            int maxNum = 0;
            double sum = 0;
            int i;
            int n = data.Count();
          //Mean
            for(i = 0; i < data.Count(); i++)
            {
                sum += data[i];
            }
            mean = sum / data.Count();

            //Median
         
            data.Sort();
            int median = 0;
            if(n%2 != 0)
            {
                 median = data[n / 2];

            }
            else
            {
                median = (data[(n-1) / 2] + data[n/2]) / 2;
            }

            //Mode
            for ( i = 0; i < data.Count(); i++)
            {
                int count = 0;
                
                for (int j = 1; j < data.Count()-1; j++)
                {
                    if (data[i] == data[j])
                    {
                        count++;
                    }
                }
                if (count > maxCount)
                {
                     maxCount = count;
                    maxNum = data[i];
                    
                }
            }

            Console.WriteLine($"Mean: {mean}");
            Console.WriteLine($"Median: {median}");
            Console.WriteLine($"Mode: { maxNum}");
            
        }
           
            






        
    }
}
