namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
        // Step 1
        // I was programming in python before this and when I tried to this C# project - I kept messing up the syntax due to muscle memory.
        int a, b, c;
        a = 10;
        b = 5;
        c = 15;

        bool aGreaterThanB = a > b;
        bool aLessThanC = a < c;
        bool aGreaterThanBC = (a > b) && (a > c);
        // By the way, I abbreviated combination with combo
        bool andCombo = (a > b) && (a < c);
        bool orCombo = (a > b) || (a > c);

        Console.WriteLine($"a > b: {aGreaterThanB}");
        Console.WriteLine($"a < c: {aLessThanC}");
        Console.WriteLine($"a > b AND a > c: {aGreaterThanBC}");
        Console.WriteLine($"a > b AND a < c: {andCombo}");
        Console.WriteLine($"a > b OR a > c: {orCombo}");

        // Step 2
        bool isRaining = true;
        bool haveUmbrella = false;

        if (isRaining && !haveUmbrella)
        {
            Console.WriteLine("Take an umbrella!");
        }
        else
        {
            Console.WriteLine("You're good to go!");
        }

        // Step 3
        Console.Write("Please enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        
        
        if (age < 5)
        {
            Console.WriteLine("Ticket is free!");
        }
        else if (age >= 5 && age <= 12)
        {
            Console.WriteLine("Child ticket: $5");
        }
        else if (age >= 13 && age <= 64)
        {
            Console.WriteLine("Standard ticket: $10");
        }
        else
        {
            Console.WriteLine("Senior ticket: $6");
        }


        // Step 4 
        // Fun fact: I saw something super similiar to this task on a youtube C# 4-hour tutorial before as an example of switch

        Console.Write("Enter day number (1-7): ");
        int dayNumber = Convert.ToInt32(Console.ReadLine());

        switch (dayNumber)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
               break;
            // By the way, this default will handle other cases that weren't explicitly defined as above.
            default:
                Console.WriteLine("Invalid input, enter a digit next time from 1 to 7 (inclusive).");
                break;
            }

        }
    }


