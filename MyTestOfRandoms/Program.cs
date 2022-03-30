using System;

namespace MyTestOfRandoms
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask user for number of dice to roll
            Console.Write("Enter number of dice to roll: ");
            int diceToRoll = int.Parse(Console.ReadLine());

            // init RNG
            Random rnd = new Random();

            // roll dice and find the sum of all the values
            int sumOfDiceValues = 0;
            for (int i = 0; i < diceToRoll; i++)
            {
                int value = rnd.Next(1, 7);
                sumOfDiceValues += value;
            }

            // print sum
            Console.WriteLine($"The sum of all dice values is {sumOfDiceValues}");
        }
    }
}
