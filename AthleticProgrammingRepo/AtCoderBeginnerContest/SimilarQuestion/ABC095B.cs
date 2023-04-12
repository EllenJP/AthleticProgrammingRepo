using System;
using System.Linq;

namespace AthleticProgrammingRepo.AtCoderBeginnerContest.SimilarQuestion
{
    public static class ABC095B
    {
        // static void Main(string[] args)
        // {
        //     Execute();
        // }
        //
        private static void Execute()
        {
            var input = (Console.ReadLine() ?? string.Empty).Split(' ').Select(int.Parse).ToArray();
            var m = new int[input[0]];
            for (int i = 0; i < m.Length; i++)
            {
                m[i] = int.Parse(Console.ReadLine());
            }
            
            var ans = CalculateMaxNumberOfDonuts(input[1], m);
            Console.WriteLine($"{ans}");
        }

        private static int CalculateMaxNumberOfDonuts(int X, int[] mArray)
        {
            // TODO: 全ての種類を一個作り余りの粉を求める。
            foreach (var m in mArray)
                X -= m;
            // TODO: 一番粉の量が少ないドーナツでMaxを求める。
            return X / mArray.Min() + mArray.Length;
        }
    }
}