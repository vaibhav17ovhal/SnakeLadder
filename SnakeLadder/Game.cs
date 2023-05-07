using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    public class Game
    {
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2;
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
            int option = random.Next(0,3);
            switch (option)
            {
                case NO_PLAY:
                    break; 
                case LADDER:
                    this.playerPosition += DieRoll();
                    break;
                case SNAKE:
                    this.playerPosition -= DieRoll();
                    break;
            }
        }
    }
}
