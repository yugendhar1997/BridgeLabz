using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class Coupon_Numbers
    {
        public void GenerateCoupons()
        {
            Random random = new Random();
            Console.WriteLine("How many Distinct Coupon Codes Do you Want Generate?");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(input + " Distinct Coupon Codes are: ");
            for (int i = 1; i <= input; i++)
            {
                int num = random.Next(100000, 999999);
                Console.WriteLine(i + " : " + num);
            }
        }
    }
}
