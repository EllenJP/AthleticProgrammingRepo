using System;
using System.Linq;

namespace AthleticProgrammingRepo.AtCoderBeginnerContest
{
    public static class ABC081B
    {
        static void Main(string[] args)
        {
            Execute();
        }

        private static void Execute()
        {
            var inputCount = int.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            Console.WriteLine(CountDivisionsByTwo(input));
        }

        private static int CountDivisionsByTwo(int[] input)
        {
            var count = 0;
            while (true)
            {
                if (input.Any(x => x % 2 != 0))
                    break;
                input = input.Select(x => x /= 2).ToArray();
                count++;
            }
            return count;
        }


        private static int redundancy_CountDivisionsByTwo(int[] input)
        {
            var count = 0;
            var indivisible = false;
            while (true)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] % 2 != 0)
                    {
                        indivisible = true;
                        break;
                    }
                }
                if (indivisible)
                {
                    return count;
                }
                count++;
                for (int i = 0; i < input.Length; i++)
                {
                    input[i] /= 2;
                }
            }
        }
    }
}