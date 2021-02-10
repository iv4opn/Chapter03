using System;
using static System.Console;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if ( i % 15 == 0 )
                {
                    Write("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    Write("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Write("Fizz");
                }
                else
                {
                    Write($"{i}");
                }
                if (i == 100)
                    break;
                Write(", ");
            }
        }
    }
}
