using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class Distance
    {
        public void FindDistance()
        {
            Console.WriteLine("Enter The X Value");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The Y value");
            int y = Convert.ToInt32(Console.ReadLine());

            CalculateDistance(x, y);

        }

        public void CalculateDistance(int x, int y)
        {
            Console.WriteLine();
            Console.WriteLine("Distance is " + Math.Sqrt((x * x) + (y * y)));
        }
    }
}
