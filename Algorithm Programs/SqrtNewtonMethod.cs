using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    class SqrtNewtonMethod
    {
        public void FindSqrtNewtonMethod()
        {
            Console.WriteLine("Enter C value to find Square Root By using Newtons Method");
            double c = Convert.ToDouble(Console.ReadLine());

            double epsilon = 1e-15;    // relative error tolerance
            double t = c;              // estimate of the square root of c



            // repeatedly apply Newton update step until desired precision is achieved
            while (Math.Abs(t - c / t) > epsilon * t)
            {
                t = (c / t + t) / 2.0;
            }


            // print out the estimate of the square root of c
            Console.WriteLine("Square Root of "+ c + " is "+t);
        }
    }
}
