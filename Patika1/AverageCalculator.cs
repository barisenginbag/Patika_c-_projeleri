using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika1
{
    public class AverageCalculator
    {
        public double CalculateAverage(List<int> numbers)
        {
            if(numbers == null || numbers.Count == 0) return 0;

            return numbers.Average();
        }
    }
}
