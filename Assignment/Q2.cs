using System;

namespace Assignment
{
    class Q2
    {
        public static void q2()
        {
            int max;
            Console.WriteLine("Enter Three Integers Numbers:");
            int num1= Convert.ToInt32(Console.ReadLine());
            int num2= Convert.ToInt32(Console.ReadLine());
            int num3= Convert.ToInt32(Console.ReadLine());

            if(num1 > num2 && num1 > num3)
            {
                max= num1;
            }
            else
            {
              if(num2 > num3){
                  max = num2;
              }else{
                  max = num3;
              }
            }

            Console.WriteLine($"Max Integer is {max}");
        }
    }
}
