using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    class Prime_Numbers
    {
        int i, j, count;
        public void CheckPrime()
        {
            Console.WriteLine("\nPrime Numbers b/w 0 - 1000");
            for (i = 0; i < 1000; i++)
            {
                count = 0;
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }

                if (count == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
