using System;

namespace MethodBasics
{
    public class Program
    {
        // method that not return anything
        public static void SayHi(string country)
        {
            System.Console.WriteLine($"Hi, I am from {country}");
        }

        // method return double and accept integer arguments
        public static double CalAverage(int num1, int num2)
        {
            double calValue = (double)(num1 + num2) / 2;
            return calValue;
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("Let's learn C# methods");

            SayHi("Vietnam");
            double userValue = CalAverage(5, 100);
            System.Console.WriteLine(userValue);
        }
    }
}