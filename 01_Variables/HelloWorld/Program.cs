using System;

namespace HelloWorld
{
    public class Program
    {
        public class People
        {
            public string name;

            public int age;


        }
        static void Main(string[] args)   
        {
            // Integer variables
            int age = 25;
            int score = 100;

            // String variables
            string name = "John";
            string message = "Hello, World!";

            // Display variables
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");

            People messi = new People();
            messi.name = "Messi";
            messi.age =45;

            Console.WriteLine($"Name: {messi.name}");
            Console.WriteLine($"Age: {messi.age}");
            

        }
    }
}