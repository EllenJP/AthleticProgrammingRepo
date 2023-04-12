using System;
using System.Linq;

namespace AthleticProgrammingRepo.AtCoderBeginnerContest.SimilarQuestion
{
    public class ABC105B
    {
        static void Main(string[] args)
        {
            Execute();
        }
        
        private static void Execute()
        {
            var N = int.Parse(Console.ReadLine() ?? string.Empty);
            var ans = FindMoneyCombination(N);
            Console.WriteLine($"{ans}");
        }

        private static string FindMoneyCombination(int N)
        {
            var fourCount = N / 4;
            var sevenCount = N / 7;
            var elevenCount = N / 11;
            // TODO: 4, 7, 11の倍数なら組み合わせがあるかも。
            for(int a = 0; a <= fourCount; a++)
            {
                for (int b = 0; b <= sevenCount; b++)
                {
                    for (int c = 0; c <= elevenCount; c++)
                    {
                        var total = 4 * a + 7 * b + 11 * c;
                        if (total == N)
                        {
                            return "Yes";
                        }
                    }
                }
            }

            return "No";
        }
    }
}