using System;

namespace DoubleInput
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "What number would you like to multiply by 5?";
            double value = GetDoubleInputFromUser(answer);
            double final = value * 5;

            Console.WriteLine($"{value} * 5 = {final}");
        }
        static double GetDoubleInputFromUser(string value)
        {
            Console.WriteLine(value);
            string answer = Console.ReadLine();
            double numb = 0;

            while (double.TryParse(answer, out numb) == false)
            {
                Console.WriteLine("Please input a number");
                answer = Console.ReadLine();
            }

            return numb;

        }
        
    }
}
