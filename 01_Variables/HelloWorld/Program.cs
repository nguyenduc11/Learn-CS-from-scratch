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

            // String variables
            string name = "John";

            // Display variables
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");

            People messi = new People();
            messi.name = "Messi";
            messi.age =45;

            Console.WriteLine($"Name: {messi.name}");
            Console.WriteLine($"Age: {messi.age}");
            
            // Read user keyboard

            // System.Console.WriteLine("Enter username");
            // string userName = Console.ReadLine();
            // System.Console.WriteLine("Username is " + userName);

            int checkNumber = 10;
            if (checkNumber % 2 == 0){
                System.Console.WriteLine("so chan");
            }
            else if (checkNumber % 2 == 1){
                System.Console.WriteLine("so le");
            }

            System.Console.WriteLine(checkNumber>5);
            string clubName = "Barcelona";
            int stringLength = clubName.Length;
            System.Console.WriteLine(stringLength);

            // String Interpolation
            System.Console.WriteLine($"My club is: {clubName}");

            bool isFavBook = true;
            System.Console.WriteLine(isFavBook);

        }
    }
}