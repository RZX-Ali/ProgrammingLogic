using System;

class Car
{
    public string model;
    public string color;
    public int year;

    // Example method to display car details.
    public void Display()
    {
        Console.WriteLine("Car Details:");
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Color: " + color);
        Console.WriteLine("Year: " + year);
    }
    // Problem 1
    public void Start()
    {
        Console.WriteLine("The car is starting.");
    }

    // Problem 2
    public void Drive(int miles)
    {
        Console.WriteLine($"The car drove {miles} miles.");
    }

    // Problem 3
    public string GetDescription()
    {
        return $"{year} {color} {model}";
    }

    // Problem 4
     public void Repaint(string newColor)
    {
        color = newColor;
        Console.WriteLine($"The car has been repainted to {newColor}.");
    }
}

class Program
{
    static void Main()
    {
        // Creating a Car object and assigning values to its properties
        Car myCar = new Car();
        myCar.model = "Civic";
        myCar.color = "Black";
        myCar.year = 2020;

        myCar.Display(); // Calling the Display method

        // Problem/Step 1
        myCar.Start();

        // Problem/Step 2
        myCar.Drive(50);

        // Problem 3 - fun solution
        string description = myCar.GetDescription();
        Console.WriteLine(description);

        // Problem 4
        myCar.Repaint("red");
        Console.WriteLine($"Confirmation of new color: {myCar.color}");
    }
}