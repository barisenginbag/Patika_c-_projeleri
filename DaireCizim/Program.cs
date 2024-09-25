using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaireCizim
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dairenin yarıçapını giriniz: ");
            int radius = int.Parse(Console.ReadLine());

            // Daireyi çiz
            CircleDrawer circleDrawer = new CircleDrawer();
            circleDrawer.DrawCircle(radius);

            Console.ReadKey();
        }
    }

    public class CircleDrawer
    {
        
        public void DrawCircle(int radius)
        {
            double thickness = 0.4; 
            char symbol = '*'; 

            
            for (int y = -radius; y <= radius; y++)
            {
                for (int x = -radius; x <= radius; x++)
                {
                    
                    double distance = Math.Sqrt(x * x + y * y);

                    
                    if (distance >= radius - thickness && distance <= radius + thickness)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(" "); 
                    }
                }
                Console.WriteLine(); 
            }
        }
    }
}
