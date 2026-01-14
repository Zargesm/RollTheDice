using System;

namespace RollTheDice
{
    // This class is responsible ONLY for rolling the dice
    public class DiceRoller
    {
        // This method simulates rolling two dice
        // numRolls = how many times the dice should be rolled
        // It returns an array containing the results
        public int[] RollDice(int numRolls)
        {
            // Create an array to store how many times each dice total appears
            // We use size 13 so we can use indexes 2 through 12 directly
            int[] results = new int[13];

            // Create a Random object to generate random numbers
            Random rand = new Random();

            // Loop once for each dice roll
            for (int i = 0; i < numRolls; i++)
            {
                // Generate a random number between 1 and 6 for the first die
                int die1 = rand.Next(1, 7);

                // Generate a random number between 1 and 6 for the second die
                int die2 = rand.Next(1, 7);

                // Add the two dice together to get the total
                int sum = die1 + die2;

                // Increase the count for this dice total
                // Example: if sum is 7, results[7] increases by 1
                results[sum]++;
            }

            // Return the array back to Program.cs
            return results;
        }
    }
}