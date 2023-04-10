using System;
using System.Linq;

namespace AthleticProgrammingRepo.AtCoderBeginnerContest.SimilarQuestion
{
    public static class ABC064A
    {
        // static void Main(string[] args)
        // {
        //     Execute();
        // }
        
        private static void Execute()
        {
            var input = (Console.ReadLine() ?? string.Empty).Split(' ').Select(int.Parse).ToArray();

            var ans = CheckMultipleOfFour(input);
            Console.WriteLine($"{ans}");
        }

        private static string CheckMultipleOfFour(int[] input)
        {
            var total = 100 * input[0] + 10 * input[1] + input[0];
            return total % 4 == 0 ? "YES" : "NO";
        }
    }
}