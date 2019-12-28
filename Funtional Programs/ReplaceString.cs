using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class ReplaceString
    {
        public void ReplaceStrings()
        {
            Console.WriteLine("Enter The Source Term of String");
            string source = Console.ReadLine();

            Console.WriteLine("Enter The Search Term of String");
            string search = Console.ReadLine();

            Console.WriteLine("Enter The Replace Term of String");
            string replace = Console.ReadLine();

            string output = source.Replace(search, replace);

            Console.WriteLine();
            Console.WriteLine("Befor Replacing The String : " + source);
            Console.WriteLine("After Reaplacing The String : " + output);
        }
    }
}
