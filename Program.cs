using System;

namespace SnakeandLadder
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("welcome to snake and ladder");
            int NUMBER_OF_PLAYERS = 1;
            int START_POSITION = 0;
            int presentPosition = 0;
            
            Random random = new Random();
            while (presentPosition <100)
            {
                int numberOnDie = random.Next(1, 7);
                int CheckOption = random.Next(0, 3);
                switch (CheckOption)
                {
                    case 0:
                        break;
                    case 1:
                        presentPosition += numberOnDie;
                        break;
                    case 2:
                        presentPosition -= numberOnDie;
                        break;
                        if (presentPosition <= 0)
                            presentPosition = 0;

                }
                
            }
            Console.WriteLine(presentPosition);
        }
    }
}
