using System;
using System.Linq;

namespace AthleticProgrammingRepo.AtCoderBeginnerContest.SimilarQuestion
{
    public abstract class Abc068B
    {
        // static void Main(string[] args)
        // {
        //     Execute();
        // }
        
        private static void Execute()
        {
            var N = int.Parse(Console.ReadLine() ?? string.Empty);
            var target = 1;
            var maxDivisibleCount = 0;
            // TODO: N回繰り返す
            for (int i = 1; i <= N; i++)
            {
                var count = CountDivisibleByTwo(i);
                if (count >= maxDivisibleCount)
                {
                    target = i;
                    maxDivisibleCount = count;
                }
            }
            
            Console.WriteLine($"{target}");
        }

        private static int CountDivisibleByTwo(int i)
        {
            var count = 0;
            while (i > 0)
            {
                if (i % 2 == 0)
                {
                    count++;
                    i /= 2;
                }
                else
                {
                    break;
                }
            }

            return count;
        }
    }
}