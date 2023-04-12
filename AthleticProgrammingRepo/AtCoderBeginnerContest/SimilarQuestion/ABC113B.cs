using System;
using System.Linq;

namespace AthleticProgrammingRepo.AtCoderBeginnerContest.SimilarQuestion
{
    public static class ABC113B
    {
        // static void Main(string[] args)
        // {
        //     Execute();
        // }
        
        private static void Execute()
        {
            var N = int.Parse(Console.ReadLine() ?? string.Empty);
            var inputTemperature = (Console.ReadLine() ?? string.Empty).Split(' ').Select(int.Parse).ToArray();
            var inputHeights = (Console.ReadLine() ?? string.Empty).Split(' ').Select(int.Parse).ToArray();
            
            var ans = FindNearestTemperature(inputTemperature[0], inputTemperature[1], inputHeights);
            Console.WriteLine($"{ans}");
        }

        private static int FindNearestTemperature(int T, int A, int[] heights)
        {
            // TODO: 高さからその高さの気温を求める。
            var temperatures = heights.Select(x => T - x * 0.006f).ToArray();
            // TODO: 理想気温との差分を求める。
            var temperatureDifferences = temperatures.Select(x => Math.Abs(A - x)).ToArray();
            // TODO: 理想気温との差分が近い高さの番号を求める。
            return Array.IndexOf(temperatureDifferences, temperatureDifferences.Min()) + 1;
        }
    }
}