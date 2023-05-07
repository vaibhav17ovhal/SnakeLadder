using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    public class Game
    {
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
    }
}
