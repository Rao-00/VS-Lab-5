using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 98, b = 0;
            double result = 0;

            try
            {
                result = SafeDivision(a, b);
                Console.WriteLine($"{a} divided by {b} = {result}");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Attempted divide by zero.");
            }
        }

        static double SafeDivision(double x, double y)
        {
            // Check if y is zero and throw DivideByZeroException
            if (y == 0)
            {
                throw new DivideByZeroException();
            }

            // Perform division if safe
            return x / y;
        }
    }
}
