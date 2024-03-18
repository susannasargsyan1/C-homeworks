using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> myList = new List<int> { 4, 9, 1, 7, 3,};

        List<int> middleElements = FindMiddleElements(myList);

        Console.Write("Middle Element: ");
        foreach (int element in middleElements)
        {
            Console.Write(element + " ");
        }
    }

    static List<int> FindMiddleElements(List<int> list)
    {
        List<int> middleElements = new List<int>();

        if (list.Count == 0)
        {
            Console.WriteLine("The list is empty.");
        }
        else
        {
            int middleIndex = list.Count / 2;
            middleElements.Add(list[middleIndex]);
        }

        return middleElements;
    }
}

