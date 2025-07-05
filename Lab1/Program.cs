namespace Lab1;

class Program
{
    static void Main(string[] args)
    {
        // Step 1
        /*
            Ali Sahi
            IT-1050 - Lab 1

            By the way, I wasn't sure if you wanted me to put an asterisk (*) at the beginning of each line for better readibility.
        */

        // Step 2

        Console.WriteLine("Ali Sahi");
        Console.WriteLine("IT-1050");

        // Step 3
        int favoriteNumber = 7;
        string favoriteLanguage = "Python";
        double programsWritten = 20;
        bool hasProgrammingExperience = true;

        Console.WriteLine("My favorite Number: " + favoriteNumber);
        Console.WriteLine("My Favorite Programming Language: " + favoriteLanguage);
        Console.WriteLine("I've programmed " + programsWritten + " programs Before This.");
        Console.WriteLine("Has Programming Experience: " + hasProgrammingExperience);

        // Step 4
        const string schoolName = "Tri-C";
        Console.WriteLine("School Name: " + schoolName);

        // Step 5
        double myDouble = 9.78;
        int myInt = (int)myDouble;
        Console.WriteLine(myInt.GetType());
        string intString = Convert.ToString(myInt);
        Console.WriteLine(intString.GetType());
        string boolString = Convert.ToString(hasProgrammingExperience);
        Console.WriteLine(boolString.GetType());

        Console.WriteLine("double: " + myDouble);
        Console.WriteLine("Previous programming experience: " + hasProgrammingExperience);

        // Step 6
        // I attempted to do this step a little more rigorously as I have some background experience. 
        string? userName;
        while (true)
        {
            Console.Write("Enter your name: ");
            /*
            * I do want to explain what I did here. For some reason, I kept getting the error:
            * Converting null literal or possible null value to non-nullable type.
            * Thus, I just declared 'userName' as a nullable string (string?) to handle the possibility of Console.ReadLine()
            * returning 'null' as a possible solution.
            * The null-coalescing operator (??) just makes sure that 'userName' is assigned an empty string
            * ('string.Empty') if 'null' is returned.
            */
            userName = Console.ReadLine() ?? string.Empty;

            if (string.IsNullOrEmpty(userName))
            {
                Console.WriteLine("Name cannot be empty. Please enter a valid name.");
            }
            else
            {

                break; //If a name is actually entered, then it will exit the loop. Just like in python.
            }
        }

        Console.Write("Enter your age: ");
        int userAge = Convert.ToInt32(Console.ReadLine());
        if (userAge >= 0 && userAge <= 130)
        {
            Console.WriteLine("Hello, " + userName + $"! You're {userAge} years old!");
        }
        else
        {
            Console.WriteLine("Hello, you are " + userName + $"! I am not quite sure about your age though, maybe you are " + userAge +".");
        }


        // Step 7
        // I just used string interpolation rather than concatenation (by the way). Fun fact, I used the digits in today's date (might have changed for you).
        int num1 = 7;
        int num2 = 4;

        Console.WriteLine("Original num1: " + num1);
        Console.WriteLine("Original num2: " + num2);

        int additionResult = num1 + 10;
        Console.WriteLine($"Addition (num1 + 10): {additionResult}");

        int subtractionResult = num2 - 2;
        Console.WriteLine($"Subtraction (num2 - 2): {subtractionResult}");

        int multiplicationResult = num1 * 3;
        Console.WriteLine($"Multiplication (num1 * 3): {multiplicationResult}");

        int divisionResult = num2 / 2;
        Console.WriteLine($"Division (num2 / 2): {divisionResult}");

        int modulusResult = num1 % 2;
        Console.WriteLine($"Modulus (num1 % 2): {modulusResult}");


        // Step 8
        float floatValue = 1.123456789f;
        double doubleValue = 1.123456789;
        Console.WriteLine("Float value: " + floatValue);
        Console.WriteLine("Double value: " + doubleValue);

        // This is just like in Java. The float type in C# has about 7 digits of precision whilst the double type has like 16 digits of precision. 32 bit vs 64 bit.

        // Step 9
        int value = 10;

        value++;
        Console.WriteLine("After increment: " + value);

        value--;
        Console.WriteLine("After decrement: " + value);
    }

    
}
