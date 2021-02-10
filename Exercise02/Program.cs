using System;
using static System.Console;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                try
                {
                    int max = 500;
                    for (byte i = 0; i < max; i++)
                    {
                        WriteLine(i);
                    }
                }
                catch (OverflowException ex)
                {
                    WriteLine($"Out of the  bound, the type should not be {ex.HResult.GetType().Name}");
                }
            }
        }
    }
}
