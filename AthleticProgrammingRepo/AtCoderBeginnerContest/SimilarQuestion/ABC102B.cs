using System;
using System.Linq;

namespace AthleticProgrammingRepo.AtCoderBeginnerContest.SimilarQuestion
{
    public static class ABC102B
    {
        // static void Main(string[] args)
        // {
        //     Execute();
        // }
        
        private static void Execute()
        {
            var N = int.Parse(Console.ReadLine() ?? string.Empty);
            var input = (Console.ReadLine() ?? string.Empty).Split(' ').Select(int.Parse).ToArray();
            var ans = CalculateMaxAbsoluteDifference(input);
            Console.WriteLine($"{ans}");
        }

        private static int CalculateMaxAbsoluteDifference(int[] input)
        {
            // TODO: 最大値を求める
            var maxValue = input.Max();
            // TODO: 最小値を求める
            var minValue = input.Min();
            return maxValue - minValue;
        }
    }
}