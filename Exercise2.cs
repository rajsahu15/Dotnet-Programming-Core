using System;
using System.Collections.Generic;
public class Exercise2 {
    static void Main(string[] ar) {
        //declaring an array
        int[] arr1 = { 10, 20, 30, 40, 50 };
        int[] arr2 = new int[5];
        int[] arr3 = new[] { 10, 20, 30, 40, 50 };
        int[] arr4 = new int[5] { 10, 20, 30, 40, 50 };
        //printing an array
        Console.WriteLine(string.Join(", ",arr3));
        foreach (int num in arr1) {
            Console.Write(num+" ");
        }
        //inserting the values in the blank array from another array
        for (int i = 0; i < arr2.Length; i++)
        {
            arr2[i] = arr1[i];
        }
        Console.WriteLine("\n"+string.Join(", ", arr2));

            //About Collections
              
            //1. List
         
            List<string> students = new List<string> { "Ram", "Sita" };
            Console.WriteLine("Initial: " + string.Join(", ", students));

            // 1. Add - Adding at the end
            students.Add("Karn");
            Console.WriteLine("After Add(Karn): " + string.Join(", ", students));

            // 2. Insert - 
            students.Insert(1, "Arjun");
            Console.WriteLine("After Insert(1, Arjun): " + string.Join(", ", students));

            // 3. Remove - 
            students.Remove("Arjun");
            Console.WriteLine("After Remove(Arjun): " + string.Join(", ", students));

            // 4. Contains 
            bool isPresent = students.Contains("Karn");
            Console.WriteLine("Is 'Karn' present? " + isPresent);

            // 5. Count 
            Console.WriteLine("Total Count: " + students.Count);


            // 7. Clear 
            students.Clear();
            Console.WriteLine("After Clear, Count is: " + students.Count);

            //2. Dictionary
            
            Dictionary<int, string> Dstudents = new Dictionary<int, string>();

            Dstudents.Add(101, "Ram");
            Dstudents.Add(102, "Sita");

            Dstudents[103] = "Karn"; // Adds 103
            Dstudents[101] = "Rama"; // Updates 101 from "Ram" to "Rama"

            if (Dstudents.ContainsKey(102))
            {
                Console.WriteLine("ID 102 belongs to: " + Dstudents[102]);
            }

           
            Dstudents.Remove(103);

            // 6. Printing Pairs
            foreach (KeyValuePair<int, string> pair in Dstudents)
            {
                Console.WriteLine("ID: " + pair.Key + ", Name: " + pair.Value);
            }

            // 7. Count 
            Console.WriteLine("Total: " + Dstudents.Count);

            // 8. Clear
            Dstudents.Clear();

            //HashSet
            HashSet<int> studentIds = new HashSet<int>();

            // 1. Add(ele)
            studentIds.Add(101);
            studentIds.Add(102);
            studentIds.Add(103);
            studentIds.Add(104);
            studentIds.Add(105);



        // 2. Remove(ele)
        studentIds.Remove(102);

            // 3. Contains(ele)
            if (studentIds.Contains(101))
            {
                Console.WriteLine("ID 101 is in the set.");
            }

           foreach (int id in studentIds)
            {
                Console.WriteLine(id);
            }

        // QUEUE
        Queue<string> Work = new Queue<string>();

        // 2. Enqueue(T) - Adds an item to the BACK of the queue
        Work.Enqueue("IT");
        Work.Enqueue("Sales");
        Work.Enqueue("Service");

        // 3. Peek() - Looks at the FRONT item WITHOUT removing it
        Console.WriteLine("Next up to print: " + Work.Peek());

        // 4. Dequeue() - Returns and REMOVES the item from the FRONT
        string finishedJob = Work.Dequeue();
        Console.WriteLine("Finished printing: " + finishedJob);

        // Checking the new front
        Console.WriteLine("Now the front is: " + Work.Peek());

        // 5. Contains()
        if (Work.Contains("Sales"))
        {
            Console.WriteLine("Sales is still waiting in line.");
        }

        // 6. Count
        Console.WriteLine("Jobs remaining: " + Work.Count);
        
        //Stack

        Stack<string> Subject = new Stack<string>();

        // 2. Push() - Adds an item to the TOP
        Subject.Push("Math");
        Subject.Push("Science");
        Subject.Push("Hindi");

        // 3. Peek() - Looks at the TOP item WITHOUT removing it
        Console.WriteLine("Current Page: " + Subject.Peek());

        // 4. Pop() - Returns and REMOVES the item from the TOP
        string lastPage = Subject.Pop();
        Console.WriteLine("Navigating back from: " + lastPage);

        // Checking the new top
        Console.WriteLine("Now the current page is: " + Subject.Peek());

        // 5. Contains(T) - Checks if a page is in the stack
        Console.WriteLine("Is Math in Subject? " + Subject.Contains("Math"));

        // 6. Count - How many pages are stored
        Console.WriteLine("Pages in Subject: " + Subject.Count);
    }
}

  
 
