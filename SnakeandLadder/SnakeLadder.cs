using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class SnakeLadder
    {
        static void Main()
        {
            int START_POSITION = 0;
            int WIN_POSITION = 100;
            int CURRENTPOSITION = 0;

            const int ladder = 1;
            const int snakebite = 2;
            Console.WriteLine("Welcome to snake and Ladder");
            Console.WriteLine("Player will Start at Zero Position,Player position :{0}", START_POSITION);
            Random random = new Random();
            Random random1 = new Random(); int die_count = 0;
            while (CURRENTPOSITION < WIN_POSITION)
            {
                int checkOptions = random1.Next(0, 3);
                int dieRoll = random.Next(1, 7);
                switch (checkOptions)
                {
                    case ladder:
                        {
                            Console.WriteLine("Player will move forward");
                            CURRENTPOSITION += dieRoll;
                            if (CURRENTPOSITION > 100)
                            {
                                CURRENTPOSITION -= dieRoll;
                            }

                        }
                        break;
                    case snakebite:
                        {
                            Console.WriteLine("Player is bitten by a snake");
                            if (CURRENTPOSITION > 0)
                            {
                                CURRENTPOSITION -= dieRoll;
                            }
                            else if (CURRENTPOSITION < 0)
                            {
                                CURRENTPOSITION = START_POSITION;
                            }
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("There will be no play. Player stays at same position");
                        }
                        break;

                }
                die_count++;


            }
            Console.WriteLine("CURRENTPOSITION is " + CURRENTPOSITION);
            Console.WriteLine("Dice throw count value is {0}", die_count);
        }
    }
}