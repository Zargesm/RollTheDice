using System;
using RollTheDice;

Console.WriteLine("Welcome to the dice throwing simulator!");
Console.Write("How many dice rolls would you like to simulate? ");
int numRolls = int.Parse(Console.ReadLine());

// Create DiceRoller and roll dice
DiceRoller roller = new DiceRoller();
int[] results = roller.RollDice(numRolls);

Console.WriteLine();
Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
Console.WriteLine($"Total number of rolls = {numRolls}.");
Console.WriteLine();

// Print histogram
for (int i = 2; i <= 12; i++)
{
    double percentage = (double)results[i] / numRolls * 100;
    int stars = (int)Math.Round(percentage);

    Console.Write($"{i}: ");
    for (int j = 0; j < stars; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");