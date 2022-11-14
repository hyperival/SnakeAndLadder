using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadder
{
    internal class SnakeLadder
    {
        static void Main(string[] args)
        {
            int Pos = 0;
            int numofPlayers = 0;
            Console.WriteLine("single player at start position :" + Pos);
            RollDice();
        }
        public static void RollDice()
        {
            Random random = new Random();
            int dice = random.Next(1, 7);
            dice = dice + 1;
            Console.WriteLine("Dice Num :" + dice);
        }
    }
}
