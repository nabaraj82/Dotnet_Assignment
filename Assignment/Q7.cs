using System;

namespace Assignment
{
    class Q7
    {
        public static void q7(){
            Console.WriteLine("Enter your first-term score(%):");
            double first_term_score = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your second-term score(%):");
            double second_term_score = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your third-term score(%):");
            double third_term_score = Convert.ToDouble(Console.ReadLine());
            double final_score = (first_term_score+second_term_score+third_term_score)*100/300;

            if ( final_score >= 90)
            {
                Console.WriteLine("Your Grade is A");
            }
            else if( final_score >= 70 && final_score < 90)
            {
                Console.WriteLine("Your Grade is B");
                
            }
            else if ( final_score >= 50 && final_score < 70)
            {
                Console.WriteLine("Your Grade is C");

            }
            else if ( final_score >= 35 && final_score < 50)
            {
                Console.WriteLine("Your Grade is D");

            }
            else
            {
                Console.WriteLine("Your Grade is F");

            }
            
        }
    }
}