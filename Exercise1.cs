using System;
public class Exercise1 {
    static void Main(String[] ar) {
        //Program For Method Call:-
        Show();
        Console.WriteLine(Get());
        Console.WriteLine(Add(10, 20));
        Display("Raj",20);


    
    }
    //1.Without Parameter Without Return 
    static void Show() {
        Console.WriteLine("This is the Without Parameter,No Return Method)");
    }
    //2.Without Parameter With Return
    static string Get() {
        return "Method Executed- Without Parameter With Return";
    }
    //3.With Parameter With Return 
    static int Add(int a, int b) {
        return a + b;
    }
    //4.With Parameter Without Return
    static void Display(string name, int age) {
        Console.WriteLine("Username :-"+name +"\nAge :-"+age);
    }

}