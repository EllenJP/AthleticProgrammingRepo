using System;
using System.Linq;

namespace AthleticProgrammingRepo.AtCoderBeginnerContest
{
    public static class ABC085C
    {
        // static void Main(string[] args)
        // {
        //     Execute();
        // }

        static void Execute()
        {
            var input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            Console.WriteLine(CalculateMoneyCombination(input[0], input[1]));
        }

        private static string CalculateMoneyCombination(int N, int Y)
        {
            for (int x = 0; x <= N; x++)
            {
                for (int y = 0; y <= N - x; y++)
                {
                    var z = N - x - y;
                    var total = 10000 * x + 5000 * y + 1000 * z;
                    if (total == Y)
                        return $"{x} {y} {z}";
                }
            }

            return "-1 -1 -1";
        }
    }
}