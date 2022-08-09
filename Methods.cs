using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorsExercise
{
    internal class Methods
    {
        public static int Add(int x, int y)
        {
            return (x + y);
        }
        public static int Sub(int x, int y)
        {
            return (x - y);
        }
        public static int Multiply(int a, int b)
        {
            return (a * b);
        }
        public static int Divide(int a, int b)
        {
            return a / b;
        }
        public static int Mod(int a, int b)
        {
            return a % b;
        }
        public static double AreaOfCircle(double r)
        {
             var answer =  Math.PI * Math.Pow(r, 2);
            return Math.Round(answer, 2);
        }
    }
}
