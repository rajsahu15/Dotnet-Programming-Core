using System;

public class SortingAlgo {
    static void Main(String[] ar) {
        int[] arr = { 10, 30, 40, 20, 100 };
        //sorting algo

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1]) {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }

        Console.WriteLine(string.Join(", ", arr));
    }


}