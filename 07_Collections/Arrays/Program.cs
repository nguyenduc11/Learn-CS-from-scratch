using System;
using System.Linq;
using System.Collections.Generic;
namespace Collections;

public class Program
{

    // C# method
    static double AverageValue(double num1, double num2)
    {
        double value = (num1 + num2) / 2;
        return value;
    }

    static void SayHi()
    {
        System.Console.WriteLine("HI, method executed");
    }


    static void Main(string[] args)
    {
        System.Console.WriteLine("let's learn C# collections");
        // string[] cars = {"volvo","bmw","ford","mazda"};
        // Array.Sort(cars);
        // int[] myNum = {1,2,3,4,5,6,700};
        // System.Console.WriteLine(myNum.Max());
        // System.Console.WriteLine(cars);
        // System.Console.WriteLine(myNum);

        // for (int i=0; i < cars.Length; i++){
        //     System.Console.WriteLine(cars[i]);
        // }

        // foreach (int num in myNum){
        //     System.Console.WriteLine(num);
        // }

        System.Console.WriteLine(AverageValue(100, 300));
        SayHi();
    }
}