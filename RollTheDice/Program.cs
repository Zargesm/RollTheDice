using System;
using RollTheDice; // Allows us to use the DiceRoller class

// Welcome message
Console.WriteLine("Welcome to the dice throwing simulator!");

// Ask the user how many times to roll the dice
Console.Write("How many dice rolls would you like to simulate? ");

// Read the user's input and convert it from text to a number
int numRolls = int.Parse(Console.ReadLine());

// Create a DiceRoller object
DiceRoller roller = new DiceRoller();

// Roll the dice and get the results array back
int[] results = roller.RollDice(numRolls);

// Print headers
Console.WriteLine();
Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
Console.WriteLine($"Total number of rolls = {numRolls}.");
Console.WriteLine();

// Loop through possible dice totals (2 through 12)
for (int i = 2; i <= 12; i++)
{
    // Calculate percentage for this dice total
    double percentage = (double)results[i] / numRolls * 100;

    // Convert percentage to number of stars
    int stars = (int)Math.Floor(percentage);

    // Print the dice total label
    Console.Write($"{i}: ");

    // Print one star per 1%
    for (int j = 0; j < stars; j++)
    {
        Console.Write("*");
    }

    // Move to the next line
    Console.WriteLine();
}

// Goodbye message
Console.WriteLine();
Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");