using System;
using System.Collections.Generic;

namespace cSharpKata.Katas
{
    class FizzBuzz
    {
        public void Write()
        {
            List<int> collection = new List<int>();

            for (int x = 0; x < collection.Count; x++)
            {
                //val   3,5

                //x     0,1

                // so 3 / 3 = 1, no remainder (0 zero means there's no remainder)

                Console.WriteLine(x);

                // does the same but with the 5
                if (collection[x] % 3 == 0 && collection[x] % 5 == 0)
                {
                    Console.WriteLine($"{x}, FizzBuzz");
                }
                else if (collection[x] % 3 == 0)
                {
                    Console.WriteLine($"{x}, Fizz");
                }
                else if (collection[x] % 5 == 0)
                {
                    Console.WriteLine($"{x}, Buzz");
                }
            }
        }
    }
}
