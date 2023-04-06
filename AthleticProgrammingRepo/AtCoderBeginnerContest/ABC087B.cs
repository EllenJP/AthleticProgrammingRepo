using System;

namespace AthleticProgrammingRepo.AtCoderBeginnerContest
{
    public static class ABC087B
    {
        // static void Main(string[] args)
        // {
        //     Execute();
        // }

        private static void Execute()
        {
            var A = int.Parse(Console.ReadLine());
            var B = int.Parse(Console.ReadLine());
            var C = int.Parse(Console.ReadLine());
            var X = int.Parse(Console.ReadLine());
            Console.WriteLine(CountCoinCombinations(A, B, C, X));
        }
        
        static int CountCoinCombinations(int A, int B, int C, int X)
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
    }
}