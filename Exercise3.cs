using System;

public class Exercise3
{
    static void Main(String[] ar)
    {
        //1---Selection Statements 
        //if ,else if ,else
        int score = 85;

        if (score >= 90)
        {
            Console.WriteLine("Grade: A");
        }
        else if (score >= 80)
        { // Checks this only if the first condition was false
            Console.WriteLine("Grade: B");
        }
        else
        {
            Console.WriteLine("Grade: C or lower");
        }
        //Switch Case
        string day = "Monday";
        switch (day)
        {
            case "Monday":
                Console.WriteLine("Today Is Monday");
                break;
            case "Tuesday":
                Console.WriteLine("Today Is Tuesday");
                break;
            case "Wednesday":
                Console.WriteLine("Today Is Wednesday");
                break;
            default: Console.WriteLine("Not A Valid Day");
                break;
         }


        //2---Iteration Statements (Loops)
        //While ,Do While ,For ,foreach

        int[] numbers = { 10, 20, 30 };

        foreach (int num in numbers)
        {
            Console.WriteLine("ForEachLoop: " + num);
        }

        for (int j = 0; j < 5; j++)
        {
            Console.WriteLine("For Loop Iteration: " + j);
        }
        int i = 1;
        while (i < 5) {
            Console.WriteLine("While Loop Iteration: " + i);
            i++;
        }
        do{
            Console.WriteLine("Do While Loop Iteration: " + i);
            
        }while (i < 5);
        //3 Jump Statements
        //break ,continue ,return
    }

}