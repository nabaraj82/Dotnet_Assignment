using System;

namespace Assignment
{
    class Q5
    {
        public static void q5()
        {
            Console.WriteLine("Enter fist number:");
            int num1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Operator:");
            string opt = Console.ReadLine();
            Console.WriteLine("Enter second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if( opt == "+")
            {
                int sum = num1+num2;
                Console.WriteLine($"Result is {sum}");
            }
            if(opt == "-")
            {
                int sub = num1 - num2;
                Console.WriteLine($"Result is {sub}");
            }
            if(opt == "*")
            {
                int mul = num1 * num2;
                Console.WriteLine($"Result is {mul}");
            }
            if(opt == "/")
            {
                double div = (double)num1 / num2;
                Console.WriteLine($"Result is {div}");
            }
        }
    }
}
