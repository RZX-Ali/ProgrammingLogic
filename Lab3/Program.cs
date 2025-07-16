namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        // Problem 2

        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
        
        // Problem 3

        int count = 5;
        while (count >= 1)
        {
            Console.WriteLine(count);
            count--;
        }

        // Problem 4

        int number = 10;
        while (number <= 1000)
        {
            Console.WriteLine(number);
            number += 10;
        }

        // Problem 5
        string[] seasons = { "Spring", "Summer", "Fall", "Winter" };

        foreach (string season in seasons)
        {
            Console.WriteLine(season);
        }

        // Problem 6

        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        Console.Write("Enter a number (1-7): ");
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int dayNumber) && dayNumber >= 1 && dayNumber <= 7)
        {
            Console.WriteLine($"Day {dayNumber}: {days[dayNumber - 1]}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number/integer/digit between 1 and 7.");
        }

        //Problem 7

        string[] books = { "To Kill a Mockingbird", "Fahrenheit 451", "The Outsiders" };
        string[] authors = { "Harper Lee", "Ray Bradbury", "S.E. Hinton" };

        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine($"{books[i]} by {authors[i]}");
        }

        // Problem 8

        int[] temperatures = { 77, 67, 75, 90, 55 };
       
        Array.Sort(temperatures);
        Console.WriteLine("Sorted temperatures:");
        foreach (int temp in temperatures)
        {
            Console.WriteLine(temp);
        }

        Console.WriteLine($"\nHighest temperature: {temperatures[temperatures.Length - 1]}");
        Console.WriteLine($"Lowest temperature: {temperatures[0]}");

        // Problem 9
        
        int[] countdown = { 5, 4, 3, 2, 1 };

        Array.Reverse(countdown);

        Console.WriteLine("Reversed Countdown:");
        for (int i = 0; i < countdown.Length; i++)
        {
            Console.WriteLine(countdown[i]);
        }
    }
}
