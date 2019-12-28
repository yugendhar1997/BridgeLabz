using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class PowerOf2
    {
        public void PowerOfTwo()
        {
            Console.WriteLine("Enter a Digit to Find Power Of 2 Which Should be Less than 32");
            int power = Convert.ToInt32(Console.ReadLine());

            while (power > 31)
            {
                Console.WriteLine("Integer Range OverFlowed");
                Console.WriteLine("Enter a Digit less than 32");
                power = Convert.ToInt32(Console.ReadLine());
            }

            checkPower(power);
        }


        static void checkPower(int power)
        {
            int value = 1;

            for (int i = 1; i <= power; i++)
            {
                value = value * 2;
                Console.WriteLine();
                Console.WriteLine(value);
            }
        }

    }
}
