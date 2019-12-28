using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    class Anagram
    {

        public void DetectAnagram()
        {
            Console.WriteLine("Enter 1st Word");
            string string1 = Console.ReadLine().ToUpper();

            Console.WriteLine("Enter 2nd Word");
            string string2 = Console.ReadLine().ToUpper();

            char[] charArray1 = string1.ToCharArray();
            char[] charArray2 = string2.ToCharArray();

            Array.Sort(charArray1);
            Array.Sort(charArray2);

            string newword1 = new string(charArray1);
            string newword2 = new string(charArray2);

            if (newword1 == newword2)
            {
                Console.WriteLine("Both The Strings Are Anagram");
            }

            else
            {
                Console.WriteLine("Both The Strings Are Not Anagram");
            }
        }
    }
}
