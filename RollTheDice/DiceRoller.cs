using System;

namespace RollTheDice
{
    public class DiceRoller
    {
        public int[] RollDice(int numRolls)
        {
            int[] results = new int[13];
            Random rand = new Random();

            for (int i = 0; i < numRolls; i++)
            {
                int die1 = rand.Next(1, 7);
                int die2 = rand.Next(1, 7);
                int sum = die1 + die2;

                results[sum]++;
            }

            return results;
        }
    }
}