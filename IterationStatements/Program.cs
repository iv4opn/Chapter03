using System;
using static System.Console;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // int x = 0;
            // while (x < 10)
            // {
            //     WriteLine(x);
            //     x++;
            // }

            // string password = string.Empty;
            // sbyte count = 0;
            // do
            // {
            //     Write("Enter your password:");
            //     password = ReadLine();

            //     if (count == 3)
            //     {
            //         WriteLine("You enter 10 times wrong password!");
            //         return;
            //     }
            //     count++;
            // } while (password != "Pa$$w0rd");

            // WriteLine("Correct!");

            string[] names = { "Adam", "Barry", "Charlie" };
            foreach (string name in names)
            {
                WriteLine($"{name} has {name.Length} characters.");
            }
        }
    }
}
