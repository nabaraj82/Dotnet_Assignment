using System;

namespace Assignment
{
    class Q6
    {
        public static void q6()
        {
            for(int i=1; i<=7; i++)
            {
                for(int j =1; j<=7; j++)
                {
                    Console.Write($"{j}");
                    if(j>=i)
                    {
                        for(int k=7; k>i;k--){
                            Console.Write("*");
                        }
                        break;
                    }
                   
                }
                Console.WriteLine();
            }
        }
    }
}

