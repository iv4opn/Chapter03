using System;
using static System.Console;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Write("Enter a number between 0 and 255: ");
                byte a = byte.Parse(ReadLine());
                Write("Enter another number between 0 and 255: ");
                byte b = byte.Parse(ReadLine());
                //byte c = (byte)a/(byte)b;
                // WriteLine($"{a} divided by {b} is {c}");
            }
            catch (OverflowException)
            {
                WriteLine("Valid number format but it is either too big or small.");
            }
            catch (FormatException)
            {
                WriteLine("Input string was not in a correct format."); 
            }
        }
    }
}
