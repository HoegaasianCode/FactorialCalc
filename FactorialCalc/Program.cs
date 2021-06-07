using System;

namespace FactorialCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(CalcFactorial(5)); // 120
        }

        private static int CalcFactorial(int n)
        {
            int factorSum = 1;
            int temp;
            while (n > 2)
            {
                temp = n * (n - 1);
                factorSum *= temp;
                n -= 2;
            }
            return factorSum;
        }
    }
}
