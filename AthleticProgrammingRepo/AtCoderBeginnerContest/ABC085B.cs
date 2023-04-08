using System;
using System.Linq;

namespace AthleticProgrammingRepo.AtCoderBeginnerContest
{
    public static class ABC085B
    {
        // static void Main(string[] args)
        // {
        //     Execute();
        // }

        static void Execute()
        {
            var inputCount = int.Parse(Console.ReadLine());
            var input = new int[inputCount];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(CountKagamiMochiLayers(input));
        }

        private static int CountKagamiMochiLayers(int[] input)
        {
            return input.Distinct().ToArray().Length;
        }
    }
}