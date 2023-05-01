using System;

namespace SnakeLaderProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake Lader Problem");
           
            Play play = new Play();
            PlayerRollTheDie playerRollTheDie = new PlayerRollTheDie();

            int roll = playerRollTheDie.RollDie();
            play.PlaySnakeAndLadder(roll);
        }
    }
}