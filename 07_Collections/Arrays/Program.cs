using System;
namespace Collections;
public class Program{
    static void Main(string[] args){
        System.Console.WriteLine("let's learn C# collections");
        string[] cars = {"volvo","bmw","ford","mazda"};
        int[] myNum = {1,2,3,4,5,6,7};
        System.Console.WriteLine(cars);
        System.Console.WriteLine(myNum);

        for (int i=0; i < cars.Length; i++){
            System.Console.WriteLine(cars[i]);
        }

        foreach (int num in myNum){
            System.Console.WriteLine(num);
        }
    }
}