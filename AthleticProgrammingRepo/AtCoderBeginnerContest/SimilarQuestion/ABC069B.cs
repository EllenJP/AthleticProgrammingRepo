using System;

namespace AthleticProgrammingRepo.AtCoderBeginnerContest.SimilarQuestion
{
    public static class ABC069B
    {
        // static void Main(string[] args)
        // {
        //     Execute();
        // }
        
        private static void Execute()
        {
            var S = Console.ReadLine();
            var ans = ShortenMiddleString(S);
            Console.WriteLine($"{ans}");
        }

        private static string ShortenMiddleString(string S)
        {
            return S[0] + (S.Length - 2).ToString() + S[^1];
        }
    }
}