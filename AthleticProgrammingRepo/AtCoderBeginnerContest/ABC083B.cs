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
            var N = input[0];
            var A = input[1];
            var B = input[2];
            var list = Enumerable.Range(1, N);
            var ans = list.Where(X => CheckSumDigitRangeAToB(X, A, B)).Sum();
            Console.WriteLine(ans);
        }

        private static bool CheckSumDigitRangeAToB(int X, int A, int B)
        {
            var sum = 0;
            while (X > 0)
            {
                sum += X % 10;
                X /= 10;
            }
            return A <= sum && sum <= B;
        }
    }
}