using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKE_LADDER_BATCH222
{
    internal class USERCASE
    {
        static void Main()
        {
            int START_POSITION = 0;
            int WIN_POSITION = 100;
            int CURRENTPOSITION = 0;
            const int forward = 1;
            const int snakebite = 2;
            Console.WriteLine("Welcome to snake and Ladder");
            Console.WriteLine("Player will Start at Zero Position,Player position :{0}", START_POSITION);
            Random random = new Random();
            Random random1 = new Random();
            while (CURRENTPOSITION < WIN_POSITION)
            {
                int checkOptions = random1.Next(0, 3);
                int dieRoll = random.Next(1, 7);
                switch (checkOptions)
                {
                    case forward:
                        {
                            Console.WriteLine("Player will move forward");
                            if (CURRENTPOSITION < 100)
                            {
                                CURRENTPOSITION += dieRoll;
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
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("There will be no play. Player stays at same position");
                        }
                        break;

                }
                Console.WriteLine("CURRENTPOSITION is " + CURRENTPOSITION);


            }
        }
    }
}