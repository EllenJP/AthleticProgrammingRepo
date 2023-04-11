using System;

namespace AthleticProgrammingRepo.AtCoderBeginnerContest.SimilarQuestion
{
    public static class ABC157A
    {
        // static void Main(string[] args)
        // {
        //     Execute();
        // }
        
        private static void Execute()
        {
            var N = int.Parse(Console.ReadLine() ?? string.Empty);
            var ans = CalculateRequiredSheets(N);
            Console.WriteLine($"{ans}");
        }

        private static int CalculateRequiredSheets(int N)
        {
            return (N / 2) + (N % 2);
        }
    }
}