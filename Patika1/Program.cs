using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen derinlik giriniz");
            int derinlik = Convert.ToInt32(Console.ReadLine());

            FibonacciGenerator generator = new FibonacciGenerator();
            List<int> fibonacciSeries = generator.GenerateSeries(derinlik);

            AverageCalculator averageCalculator = new AverageCalculator();
            double average = averageCalculator.CalculateAverage(fibonacciSeries);

            Console.WriteLine("Fibonnaci serisinin ortalaması : "+ average);

            Console.ReadKey();
        }
    }
}
