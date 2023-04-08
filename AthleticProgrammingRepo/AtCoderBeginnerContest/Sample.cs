using System;
using System.Linq;

namespace AthleticProgrammingRepo.AtCoderBeginnerContest
{
    public static class Sample
    {
        // static void Main(string[] args)
        // {
        //     Execute();
        // }

        private static void Execute()
        {
            // var inputCount = int.Parse(Console.ReadLine());
            // var input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            // var input = Console.ReadLine();
        
            var input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            var ans = SumOfDigitFromAToB(input[0], input[1], input[2]);
            Console.WriteLine($"{ans}");
        }

        private static int SumOfDigitFromAToB(int N, int A, int B)
        {
            var sumTotal = 0;
            for (int i = 1; i <=N; i++)
            {
                var value = i;
                var sumDigits = 0;
                while (value > 0)
                {
                    var remainder = value % 10;
                    sumDigits += remainder;
                    value /= 10;
                }

                if (A <= sumDigits && sumDigits <= B)
                {
                    sumTotal += i;
                }
            }
            return sumTotal;
        }

        private static int CountCoinCombinations(int A, int B, int C, int X)
        {
            var count = 0;
            for (int a = 0; a <= A; a++)
            {
                for (int b = 0; b <= B; b++)
                {
                    for (int c = 0; c <= C; c++)
                    {
                        if (500 * a + 100 * b + 50 * c == X)
                            count++;
                    }
                }
            }

            return count;
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