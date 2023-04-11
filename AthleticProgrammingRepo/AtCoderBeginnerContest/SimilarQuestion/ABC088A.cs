using System;
using System.Linq;

namespace AthleticProgrammingRepo.AtCoderBeginnerContest.SimilarQuestion
{
    public static class ABC088A
    {
        // static void Main(string[] args)
        // {
        //     Execute();
        // }
        
        private static void Execute()
        {
            var N = int.Parse(Console.ReadLine() ?? string.Empty);
            var A = int.Parse(Console.ReadLine() ?? string.Empty);
            var ans = IsMatchPaymentAmount(N, A);
            Console.WriteLine($"{ans}");
        }

        private static string IsMatchPaymentAmount(int N, int A)
        {
            var remainder = N % 500;
            return remainder <= A ? "Yes" : "No";
        }
    }
}