using System;

namespace DefineClass
{
    // Define a Player class
    public class Player
    {
        // class field
        string name;
        int age;

        // constructor

        public Player(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // class method
        public void Introduce(string country)
        {
            System.Console.WriteLine($"Hi, I am {name} from {country}. I am {age} years old");
        }

    }


    // Defince a Car class
    public class Car
    {
        string model;
        string color;
        int year;

        public Car(string model, string color, int year)
        {
            this.model = model;
            this.color = color;
            this.year = year;
        }

        public void ShowColor()
        {
            System.Console.WriteLine($"This car has {color} colour");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("let's learn C# Classes and Objects");

            // instantiate object
            Player messi = new Player("Messi", 35);
            messi.Introduce("Argentina");

            // other object from Player class
            Player suarez = new Player("Suarez", 37);
            suarez.Introduce("Uruguay");


            Car car01 = new Car("Mustang","red",1969);
            Car car02 = new Car("Astra","white",2025);
            System.Console.WriteLine(car01.model);
            car01.ShowColor();

        }
    };
}


