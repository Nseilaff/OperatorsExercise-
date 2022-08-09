using System;

namespace OperatorsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Methods.Add(5, 5));
            Console.WriteLine(Methods.Sub(20, 6));
            Console.WriteLine(Methods.Multiply(15, 6));
            Console.WriteLine(Methods.Divide(27, 5));
            Console.WriteLine(Methods.Mod(27, 5));
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            if (a == 17 && b == 4)
            {
                Console.WriteLine($"{a} / {b} = {quotient} with a remainder of {remainder}" );
            }

            Console.WriteLine("Put in the size of you circle");
            var userInput = double.Parse(Console.ReadLine());
            Console.WriteLine(Methods.AreaOfCircle(userInput));
        }
    }
}
