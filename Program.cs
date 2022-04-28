// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
class SnakeLadderProblem
{
    //public static object rollDice;
    //public static object random;
    public const int IS_PLAYER_POSITION = 0;
    public const int IS_SNAKE_POSITION = 1;

    int playPos = 0;
    static void Main(string[] args)
    {
        int player = 0;
        Random random = new();
        int rollDice = random.Next(0, 7);
        switch (rollDice)
        {
            case IS_PLAYER_POSITION:
                player += rollDice;
                break;
            case IS_SNAKE_POSITION:
                player -= rollDice;
                break;
            default:
                player = 0;
                break;
        }
        Console.WriteLine("Rolled Dice number is :" + rollDice);
    }
}

