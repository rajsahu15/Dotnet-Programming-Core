using System;

interface Inter1 { 
    void Display() { 
    Console.WriteLine("This is the display method");
    }
    void Show();

}
class ImplementingClass : Inter1 {
    public void Show() { 
        Console.WriteLine("Body Created"); 
    }
}

public class Interface {
    public static void Main(string[] args) { 
     ImplementingClass implementingClass = new ImplementingClass();
       // implementingClass.Display();--this will give the error

        implementingClass.Show();
        Inter1 implement1 = implementingClass();
        implement1.Show();
    }
}