using System;

namespace Number_guessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int winNum = r.Next(0, 100);

            bool win = false;

            do
            {
                Console.WriteLine("Guess a number between 0 and 100: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num > winNum)
                    Console.WriteLine("Too high! Guess number smaller than {0}",num);
                else if (num < winNum)
                    Console.WriteLine("Too low! Guess a number higher than {0}",num);
                else if (num == winNum)
                {
                    win = true;

                    Console.WriteLine("You win!!!");
                }
            }
            while (win == false) ;
            Console.WriteLine("Enter any key to quit game ");
            Console.ReadKey(true);
        }
    }
}

