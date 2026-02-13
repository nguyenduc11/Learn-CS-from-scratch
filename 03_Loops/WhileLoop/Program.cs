using System;

namespace HelloWorld
{
    public class Program
    {
        static void Main(string[] args)   
        {
            // While Loop

            // int i = 0;
            // while (i<5){
            //     System.Console.WriteLine(i);
            //     i++;
            // }

            // For Loop
            for (int i = 0; i < 10; i++){
                System.Console.WriteLine(i);
                for (int j = 0; j < 10; j++){
                    System.Console.WriteLine($"i*j equal {i*j}");
                }
            }

            // Array Loop
            string[] cars = {"Volvo","BMW","Ford","Mazda"};
            foreach (string i in cars){
                System.Console.WriteLine(i);
            }
        }
    }
}