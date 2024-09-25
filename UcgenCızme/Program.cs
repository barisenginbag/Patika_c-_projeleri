using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcgenCızme
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Üçgenin boyutunu giriniz: ");
            int size = int.Parse(Console.ReadLine());

            TriangleDrawer triangle = new TriangleDrawer();
            triangle.DrawTriangle(size);
            Console.ReadKey();
        }
    }
    public class TriangleDrawer
    {
        public void DrawTriangle(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
        }
    }
}
