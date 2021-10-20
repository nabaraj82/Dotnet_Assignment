using System;
namespace Assignment

{
    class Q8
    {
        public static void q8(){
            int val = 10;
            float val2 = 12.5F;
            string val3 = "50";
            Console.WriteLine($"Integer: {val}");
            Console.WriteLine($"Float: {val2}");
            Console.WriteLine($"String: {val3}");
            float sum = val+ val2 + float.Parse(val3);
            Console.WriteLine($"Added value in Floating Point: {sum}");
            string str = Convert.ToString(val) + Convert.ToString(val2) + val3;
            Console.WriteLine($"Concatenated value: {str}");
            
    }
}
}