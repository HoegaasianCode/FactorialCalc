using System;

namespace FactorialCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(CalcFactorial(5)); // 120
        }

        private static int CalcFactorial(int x)
        {
            int factorSum = 1;
            int x1;
            while (x >= 2)
            {
                x1 = x * (x - 1);
                factorSum *= x1;
                x -= 2;
            }
            return factorSum;
        }
    }
}
