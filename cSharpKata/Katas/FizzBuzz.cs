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
                if (collection[x] % 3 == 0 && collection[x] % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (collection[x] % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (collection[x] % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
            }
        }
    }
}
