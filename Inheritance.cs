using System;

class Car {
    public void Drive() {
        Console.WriteLine("Driver is Driving the Car");
    }
}
//single level
class SportsCar:Car {
    public void TurboMode() {
        Console.WriteLine("Sports cars have turbo mode.");
    }
}
//Hierarchical
class NormalCar : Car {
    public void SaveMode()
    {
        Console.WriteLine("Normal cars have energy saving mode");
    } 
}
//multilevel
class BMW : SportsCar
{
    public void wake()
    {
        Console.WriteLine("BMW is the topclass Sports Class");

    }
}


public class Inheritance {
    public static void Main(String[] args) { 
     //main class code 
     BMW bMW = new BMW();
        bMW.Drive();
        bMW.TurboMode();
        bMW.wake();


    }
}