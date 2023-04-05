using System;
using System.Linq;

namespace AthleticProgrammingRepo.AtCoderBeginnerContest
{
    public static class Sample
    {
        static void Main(string[] args)
        {
            Execute();
        }
        
        private static void Execute()
        {
            var inputCount = int.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            // var input = Console.ReadLine();
            Console.WriteLine(CountDivisionByTwo(input));
        }

        private static int CountDivisionByTwo(int[] input)
        {
            var count = 0;
            while (true)
            {
                if (input.Any(x => x % 2 != 0))
                    break;
                input = input.Select(x => x / 2).ToArray();
                count++;
            }
            return count;
        }

        private static int CountSquareNumOne(string input)
        {
            return input.Count(x => x == '1');
        }
        
        private static bool IsEven(int a, int b)
        {
            return a * b % 2 == 0;
        }
    }
}