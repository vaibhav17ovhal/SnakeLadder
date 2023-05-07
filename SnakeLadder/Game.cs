using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    public class Game
    {
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2, WINNING_POSITION = 100;
        int playerPosition = 0;
        int count = 0;

        Random random = new Random();

        public int DieRoll()
        {
            int num = random.Next(1,7);
            Console.WriteLine($"Die Roll: -----> {num}");
            count++;
            return num;
        }
        public void Play()
        {
            while (this.playerPosition < 100)
            {
                int option = random.Next(0, 3);
                switch (option)
                {
                    case NO_PLAY:
                        break;
                    case LADDER:
                        this.playerPosition += DieRoll();
                        break;
                    case SNAKE:
                        int dieRoll = DieRoll();
                        if (this.playerPosition - dieRoll > 0)
                        {
                            this.playerPosition -= dieRoll;
                        }
                        else
                        {
                            this.playerPosition = 0;
                        }
                        break;
                }
                Console.WriteLine($"Player Position: ------> {playerPosition}");
            }
            if (this.playerPosition == WINNING_POSITION)
            {
                Console.WriteLine($"Player Position: -----> {playerPosition}");
                Console.WriteLine($"Die Count: -----> {count}");
            }
        }
    }
}
