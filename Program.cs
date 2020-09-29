using System;

namespace SnakeandLadder
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("welcome to snake and ladder");
            const int Start_Position = 0;
            Random random = new Random();
            int numberOnDie = random.Next(1, 7);
            Console.WriteLine("Die Number is {0}", numberOnDie);
        }
    }
}
