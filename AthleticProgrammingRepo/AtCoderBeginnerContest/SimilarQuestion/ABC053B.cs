using System;

namespace AthleticProgrammingRepo.AtCoderBeginnerContest.SimilarQuestion
{
    public static class ABC053B
    {
        // static void Main(string[] args)
        // {
        //     Execute();
        // }
        
        private static void Execute()
        {
            var input = Console.ReadLine();
            var ans = GetLengthAZString(input);
            Console.WriteLine($"{ans}");
        }

        private static int GetLengthAZString(string S)
        {
            var startIndex = S.IndexOf('A');
            var endIndex = S.LastIndexOf('Z');
            return endIndex - startIndex + 1;
        }
    }
}