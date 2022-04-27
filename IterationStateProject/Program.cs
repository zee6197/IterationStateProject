using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }

           /* for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }*/
            

            var numbers = new List<int>();
            int num = 0;

            do
            {
                num++;
                numbers.Add(num);

            } while (num < 100);


            while (num < 200)
            {
                num++;
                numbers.Add(num);
            }


            // This is to show the user that the numbers will start increasing on the console
            Console.WriteLine("Increase:");


            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }


            Console.WriteLine("");
            Console.WriteLine("Decrease:");


            for (int i = 199; i >= 0 && i <= numbers.Count; i--)
            {
                Console.WriteLine(numbers[i]);
            }

        }
    }
}
