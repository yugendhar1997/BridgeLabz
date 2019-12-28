using System;

namespace Algorithm_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine();
                Console.WriteLine("Press 1  : Vending Machine");
                Console.WriteLine("Press 2  : Day Of Week");
                Console.WriteLine("Press 3  : Temperature Convertion");
                Console.WriteLine("Press 4  : Monthly Payment");
                Console.WriteLine("Press 5  : Sqrt Newtons Method");
                Console.WriteLine("Press 6  : Permutations Of a String");
                Console.WriteLine("Press 7  : Binary Search The Word From Word List");
                Console.WriteLine("Press 8  : Insertion Sort");
                Console.WriteLine("Press 9  : Bubble Sort");
                Console.WriteLine("Press 10 : Merge Sort");
                Console.WriteLine("Press 11 : An Anagram Detection");
                Console.WriteLine("Press 12 : Prime Numbers b/w Range");
                Console.WriteLine("Press 13 : Question to Find your number");
                Console.WriteLine("Press 14 : Message Demonstration using String Function ");

                int press = Convert.ToInt32(Console.ReadLine());

                switch (press)
                {
                    case 3:
                        TemperatureConvertion temperatureConvertion = new TemperatureConvertion();
                        temperatureConvertion.ConvertTemperature();
                        break;

                    case 4:
                        MonthlyPayment monthlyPayment = new MonthlyPayment();
                        monthlyPayment.CalculatePayment();
                        break;

                    case 5:
                        SqrtNewtonMethod sqrtNewtonMethod = new SqrtNewtonMethod();
                        sqrtNewtonMethod.FindSqrtNewtonMethod();
                        break;

                    case 8:
                        Insertion_Sort insertion_Sort = new Insertion_Sort();
                        insertion_Sort.PerformInsertionSort();
                        break;

                    case 9:
                        Bubble_Sort bubble_Sort = new Bubble_Sort();
                        bubble_Sort.Sort();
                        break;

                    case 11:
                        Anagram anagram = new Anagram();
                        anagram.DetectAnagram();
                        break;

                    case 12:
                        Prime_Numbers prime_Numbers = new Prime_Numbers();
                        prime_Numbers.CheckPrime();
                        break;
                }

            } while (true);
        }
    }
}
