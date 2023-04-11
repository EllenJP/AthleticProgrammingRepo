using System;
using System.Text.RegularExpressions;

namespace AthleticProgrammingRepo.AtCoderBeginnerContest.SimilarQuestion
{
    public static class ABC085A
    {
        // static void Main(string[] args)
        // {
        //     Execute();
        // }
        
        private static void Execute()
        {
            var input = Console.ReadLine();
            var ans = ModifyDate(input);
            Console.WriteLine($"{ans}");
        }

        private static string ModifyDate(string input)
        {
            var pattern = @"^\d{4}";
            var replacement = "2018";
            return Regex.Replace(input, pattern, replacement);
        }
    }
}