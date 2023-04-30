using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLaderProblem
{
    public class Play
    {
        private int playerPosition;
        private Random random;

        public Play()
        {
            playerPosition = 0;
            random = new Random();
        }

        public void PlaySnakeAndLadder(int roll)
        {
            Console.WriteLine("Starting Snake and Ladder game...");
            Console.WriteLine("Your starting position is {0}.", playerPosition);

            playerPosition += roll;
            Console.WriteLine("You rolled {0}. Your new position is {1}.", roll, playerPosition);
        }

    }
}

