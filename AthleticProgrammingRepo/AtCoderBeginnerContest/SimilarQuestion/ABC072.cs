using System;
using System.Linq;

namespace AthleticProgrammingRepo.AtCoderBeginnerContest.SimilarQuestion
{
    public static class ABC072
    {
        // static void Main(string[] args)
        // {
        //     Execute();
        // }
        
        private static void Execute()
        {
            var input = Console.ReadLine();
            var ans = CreateStringWithEvenIndex(input);
            Console.WriteLine($"{ans}");
        }

        // 添え字番号偶数=奇数文字目だけの文字列
        private static string CreateStringWithEvenIndex(string input)
        {
            return new string(input.Where((_, index) => index % 2 == 0).ToArray());
        }
    }
}