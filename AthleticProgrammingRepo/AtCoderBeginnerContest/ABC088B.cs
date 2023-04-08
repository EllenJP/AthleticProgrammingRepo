using System;
using System.Linq;

namespace AthleticProgrammingRepo.AtCoderBeginnerContest
{
    public static class ABC088B
    {
        // static void Main(string[] args)
        // {
        //     Execute();
        // }
        //
        private static void Execute()
        {
            var inputCount = int.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            Console.WriteLine(CalculatePointDifference(input));
        }

        private static int CalculatePointDifference(int[] input)
        {
            // TODO: 降順にソート
            Array.Sort(input);
            Array.Reverse(input);
            // TODO: 添え字の偶数奇数で合計を出す。
            var sumPointAlice = input.Where((_, index) => index % 2 == 0).Sum();
            var sumPointBob = input.Where((_, index) => index % 2 != 0).Sum();
            return sumPointAlice - sumPointBob;
        }
    }
}