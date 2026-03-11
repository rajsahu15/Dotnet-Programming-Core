using System;

public class Car {
    decimal price { get; set; } 
    string name { get; set; }

    public void Display()
    {
       
        Console.WriteLine("Name of the Car is :- "+name);
        Console.WriteLine("Price of the car is :- "+price);

    }
    public static void Main(string[] args) { 
       Car car = new Car();
        car.price = 8989888989.928m;
        car.name = "BMW";
        car.Display();
    }
}