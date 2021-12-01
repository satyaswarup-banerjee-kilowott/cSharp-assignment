using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsTechnique_assignment
{
    internal class Stats
    {
        internal int[] Numbers { private get; set; }


        internal double CalculateMean()
        {
            double m = 0;
            double sum = 0;
            int i;
            int n = Numbers.Count();

            for (i = 0; i < Numbers.Count(); i++)
            {
                sum += Numbers[i];
            }
            m = sum / Numbers.Count();


            return m;
        }

        internal int CalculateMedian()
        {
            Array.Sort(Numbers);
            int med = 0;
            int n = Numbers.Count();
            if (n % 2 != 0)
            {
                med = Numbers[n / 2];    

            }
            return med; 
        }

        internal int CalculateMode()
        {
            int i;
            int mCount = 0;
            int maxNum = 0;
            for (i = 0; i < Numbers.Count(); i++)
            {
                int count = 0;

                for (int j = 1; j < Numbers.Count() - 1; j++)
                {
                    if (Numbers[i] == Numbers[j])
                    {
                        count++;
                    }
                }
                if (count > mCount)
                {
                    mCount = count;
                    maxNum = Numbers[i];

                }
            }
            return maxNum;
        }
    }
}
