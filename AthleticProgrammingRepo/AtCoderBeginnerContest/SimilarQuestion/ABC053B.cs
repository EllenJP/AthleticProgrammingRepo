using System;

namespace AthleticProgrammingRepo.AtCoderBeginnerContest.SimilarQuestion
{
    public static class ABC053B
    {
        static void Main(string[] args)
        {
            Execute();
        }
        
        private static void Execute()
        {
            var input = Console.ReadLine();
            var ans = CreateStringWithEvenIndex(input);
            Console.WriteLine($"{ans}");
        }
    }
}