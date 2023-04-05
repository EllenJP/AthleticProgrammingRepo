using System;
using System.Linq;

namespace AthleticProgrammingRepo.AtCoderBeginnerContest
{
    public static class ABC081A
    {
        // static void Main(string[] args)
        // {
        //     Execute();
        // }

        private static void Execute()
        {
            var input = Console.ReadLine();
            Console.WriteLine(CountSquareNumOne(input));
        }

        private static int CountSquareNumOne(string input)
        {
            return input.Count(x => x == '1');
        }

        private static int redundancy_CountSquareNumOne(string input)
        {
            var count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '1')
                {
                    count++;
                }
            }
            return count;
        }
    }
}