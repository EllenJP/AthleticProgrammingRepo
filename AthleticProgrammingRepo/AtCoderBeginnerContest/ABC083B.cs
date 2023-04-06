using System;
using System.Linq;

namespace AthleticProgrammingRepo.AtCoderBeginnerContest
{
    public static class ABC083B
    {
        // static void Main(string[] args)
        // {
        //     Execute();
        // }

        private static void Execute()
        {
            var input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            Console.WriteLine(SumOfDigitsFromAToB(input[0], input[1], input[2]));
        }

        private static int SumOfDigitsFromAToB(int N, int A, int B)
        {
            var sumDigit = 0;
            for (int i = 1; i <= N; i++)
            {
                var value = i;
                var sumValue = 0;
                while (value > 0)
                {
                    var remainder = value % 10;
                    sumValue += remainder;
                    value /= 10;
                }
                if (A <= sumValue && sumValue <= B)
                {
                    sumDigit += i;
                }
            }
            return sumDigit;
        }

    }
}