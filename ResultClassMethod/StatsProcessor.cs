using System.Linq;

namespace FirstConsoleApp
{
    /// <summary>
    /// This class will perform some basic statistics calculations
    /// </summary>
    /// 
    internal class StatsProcessor
    {
        // data set that is provided to the object is encapsulatd
        internal int[] Numbers { private get; set; }

        internal StatsResult GetStatsProcessorResult()
        {
            var result = new StatsResult();
            result.Mean = CalculateMean();
            result.Median = CalculateMedian();
            result.Mode = CalculateMode();

            return result;
        }

        private double CalculateMean()
        {
            int i;
            double sum = 0;
            double mean = 0;
            for (i = 0; i < Numbers.Count(); i++)
            {
                sum += Numbers[i];
            }
            mean = sum / Numbers.Count();

            return mean;
        }
        
        private int CalculateMedian()
        {
            var sortedData = Numbers.OrderBy(i => i).ToArray();
            var n = sortedData.Length;
            var median = n % 2 == 0
                ? (sortedData[n / 2 - 1] + sortedData[n / 2]) / 2
                : sortedData[n / 2];
            return median;
        }

        private int CalculateMode()
        {
            int i;
            int maxCount = 0;
            int maxNum = 0;
            
            for(i = 0; i < Numbers.Count(); i++)
            {
                int count = 0;

                for (int j = 1; j < Numbers.Count() - 1; j++)
                {
                    if (Numbers[i] == Numbers[j])
                    {
                        count++;
                    }
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    maxNum = Numbers[i];

                }
            }

            return maxNum;
        }




    }
}
