using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> myList = new List<int> { 9, 4, 1, 6, 11 };

        int biggestNumber = FindBiggestNumber(myList);

        Console.WriteLine("Biggest Number: " + biggestNumber);
    }

    static int FindBiggestNumber(List<int> list)
    {
        if (list.Count == 0)
        {
            Console.WriteLine("No numbers to compare.");
            return -1; 
        }

        int biggest = list[0]; 

        foreach (int number in list)
        {
            if (number > biggest)
            {
                biggest = number; 
            }
        }

        return biggest;
    }
}

