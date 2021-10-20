using System;
namespace Assignment
{
    class Q9
    {
        public static void q9()
        {
            Random rand = new Random();
            Console.WriteLine("Guess the number");
            char point = 'y';
            while (point == 'y')
            {
                Console.WriteLine("Enter your guess:");
                int guess = Convert.ToInt32(Console.ReadLine());
                int num = rand.Next(1, 6);
                if (num == guess)
                {
                    Console.WriteLine("You Won !!!");
                }
                else
                {
                    Console.WriteLine("You lose !!!");
                }

                Console.WriteLine("Do you want to continue (y/n):");
                point = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}