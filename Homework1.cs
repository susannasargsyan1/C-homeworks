/*1. Conditional Statements:
   - Develop a program using an if-else statement to display varying weather conditions depending on the temperature input. For instance, if the temperature falls below 0 degrees, the program should output "Freezing weather."
   - Create a program utilizing an if-else statement to categorize a person's age group. As an example, the program should label someone as "Child" if their age is under 13, "Teenager" if between 13 and 19, and "Adult" for ages beyond that.
   - Implement a program that converts temperatures between Fahrenheit and Celsius scales. Use if-else statements to facilitate the selection process for conversion direction.*/

/*Displaying varying weather conditions:*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the temperature in degrees Celsius: ");
        double temperature = double.Parse(Console.ReadLine());

        if (temperature < 0)
        {
            Console.WriteLine("Freezing weather.");
        }
        else if (temperature >= 0 && temperature <= 10)
        {
            Console.WriteLine("Cold weather.");
        }
        else if (temperature > 10 && temperature <= 20)
        {
            Console.WriteLine("Moderate weather.");
        }
        else
        {
            Console.WriteLine("Warm weather.");
        }
    }
}

/*Categorizing a person's age group:*/
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        if (age < 13)
        {
            Console.WriteLine("Child");
        }
        else if (age >= 13 && age <= 19)
        {
            Console.WriteLine("Teenager");
        }
        else
        {
            Console.WriteLine("Adult");
        }
    }
}
/*Temperature conversion program:*/

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Select conversion direction:");
        Console.WriteLine("1. Fahrenheit to Celsius");
        Console.WriteLine("2. Celsius to Fahrenheit");

        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Console.Write("Enter temperature in Fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"{fahrenheit} degrees Fahrenheit is {celsius} degrees Celsius.");
        }
        else if (choice == 2)
        {
            Console.Write("Enter temperature in Celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"{celsius} degrees Celsius is {fahrenheit} degrees Fahrenheit.");
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }
}
/*2. Array Manipulations:
   - Write a program to find the maximum and minimum elements in a given array.
   - Design a program that reverses the elements in a given array.
   - Design a program that will find the second largest element in an array.
   - Design a program that takes two arrays of numbers and returns a new array. 
This new array should consist of the sums of corresponding elements from the two input arrays.
For example, if the input arrays are [1, 2, 3] and [4, 5, 6], the output should be [5, 7, 9].*/

/*Finding maximum and minimum elements in an array:*/

using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 4, 8, 2, 10, 5 };

        int max = numbers[0];
        int min = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
                max = number;

            if (number < min)
                min = number;
        }

        Console.WriteLine($"Maximum element: {max}");
        Console.WriteLine($"Minimum element: {min}");
    }
}

/*Reversing elements in an array:*/

using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        Array.Reverse(numbers);

        Console.WriteLine("Reversed array:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}

/*Finding the second largest element in an array:*/

using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 5, 8, 2, 7 };

        Array.Sort(numbers);

        if (numbers.Length >= 2)
        {
            int secondLargest = numbers[numbers.Length - 2];
            Console.WriteLine($"Second largest element: {secondLargest}");
        }
        else
        {
            Console.WriteLine("Array doesn't have a second largest element.");
        }
    }
}
