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
            // var inputCount = int.Parse(Console.ReadLine() ?? string.Empty);
            // var input = (Console.ReadLine() ?? string.Empty).Split(' ').Select(x => int.Parse(x)).ToArray();
            var input = Console.ReadLine();
            // var input = new int[inputCount];
            // for (int i = 0; i < inputCount; i++)
            // {
            //     input[i] = int.Parse(Console.ReadLine() ?? string.Empty);
            // }

            var ans = CheckStringMatch(input);
            Console.WriteLine($"{ans}");
        }

        private static string CheckStringMatch(string S)
        {
            var addStrings = new string[]
            {
                "dream",
                "dreamer",
                "erase",
                "eraser",
            };
            
            // TODO: SとaddStringsを逆順にする。
            var reverseS = new string(S.Reverse().ToArray());
            var reverseAddStrings = new string[addStrings.Length];
            for (int i = 0; i < addStrings.Length; i++)
            {
                reverseAddStrings[i] = new String(addStrings[i].Reverse().ToArray());
            }
            
            // TODO: reverseSの先頭からreverseAddStringsの要素をマッチするか判定する。マッチすればindexを進めて、全てマッチしなければNOを出力。
            var index = 0;
            while (index < reverseS.Length)
            {
                var isMatch = false;
                foreach (var reverseAddString in reverseAddStrings)
                {
                    // TODO: 残りの文字数が比較文字列よりも少ない場合はスキップする。
                    if (reverseS.Length - index < reverseAddString.Length)
                        continue;
                    // TODO: index位置からの文字列と比較文字列が等しい場合は、indexを更新する。
                    if (reverseS.Substring(index, reverseAddString.Length) == reverseAddString)
                    {
                        index += reverseAddString.Length;
                        isMatch = true;
                        break;
                    }
                }
                
                // TODO: 全ての要素で一致しなければNOを返す。
                if (!isMatch)
                {
                    return "NO";
                }
            }

            return "YES";
        }
        

        private static string CalculateMoneyCombinations(int N, int Y)
        {
            for (int x = 0; x <= N; x++)
            {
                for (int y = 0; y <= N - x; y++)
                {
                    var z = N - x - y;
                    if (10000 * x + 5000 * y + 1000 * z == Y)
                        return $"{x} {y} {z}";
                }
            }

            return "-1 -1 -1";
        }
        
        private static int CountKagamiMochiLayer(int[] input)
        {
            var layerCount = input.Distinct().Count();
            return layerCount;
        }
        
        private static int CalculatePointDifference(int[] input)
        {
            // TODO: カードをソートして降順に並べる
            Array.Sort(input);
            Array.Reverse(input);
            // TODO: 偶数の添え字で合計を出す。
            var alicePoint = input.Where((_, index) => index % 2 == 0).Sum();
            // TODO: 奇数の添え字で合計を出す。
            var bobPoint = input.Where((_, index) => index % 2 != 0).Sum();

            return alicePoint - bobPoint;
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