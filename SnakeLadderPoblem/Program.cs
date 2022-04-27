// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
class SnakeLadderProblem
{
    public static object rollDice;
    public static object random;
    int playPos = 0;
    static void Main(string[] args)
    {
       
        Random random = new Random();
        int rollDice = random.Next(1, 7);
        Console.WriteLine("Rolled Dice number is :" +rollDice);
    }
}
