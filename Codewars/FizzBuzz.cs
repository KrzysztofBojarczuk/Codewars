using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public class FizzBuzz
    {
        public static void FizzBuzzList() {

            var fizzBuzzList = Enumerable.Range(1, 10)
                .Select(number =>
                    (number % 3 == 0, number % 5 == 0) switch
                    {
                        (true, true) => "FizzBuzz",
                        (true, false) => "Fizz",
                        (false, true) => "Buzz",
                        _ => number.ToString()
                    });

            foreach (var result in fizzBuzzList)
            {
                Console.WriteLine(result);
            }

            Console.WriteLine("_________________");

            for (int i = 1; i <= 10; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
