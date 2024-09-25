using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika1
{
    public class FibonacciGenerator
    {
        public List<int> GenerateSeries(int depth)
        {
            List<int> series = new List<int>();

            series.Add(0);
            if (depth == 1) return series;
            series.Add(1);
            for(int i = 2; i < depth; i++)
            {
                int next = series[i - 1] + series[i-2];
                series.Add(next);
            }

            return series;
        }
    }
}
