using System;

namespace Assignment
{
    class Q4
    {
        public static void q4()
        {
            Console.WriteLine("Enter the total number you would like to enter:");
            int n= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter {n} numbers:");
            int[] array = new int[n];
            int max = array[0];
            for(int i=0; i<n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i=0; i<n; i++)
            {
                if(array[i]>max)
                {
                    max=array[i];
                }
            }

            Console.WriteLine($"Largest number is {max}");
            
        }
    }
}
