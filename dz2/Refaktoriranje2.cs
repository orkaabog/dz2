using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AverageCalculator
    {
        public List<double> CalculateAverages(List<double[]> arraysList)
        {
            List<double> averages = new List<double>();

            foreach (double[] array in arraysList)
            {
                double sum = 0;
                foreach (double value in array)
                {
                    sum += value;
                }
                averages.Add(sum / array.Length);
            }

            return averages;
        }
    }
}
