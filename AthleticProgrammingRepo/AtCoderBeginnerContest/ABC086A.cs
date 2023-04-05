using System;
using System.Linq;

namespace AthleticProgrammingRepo.AtCoderBeginnerContest
{
    public static class ABC086A
    {
        static void Main(string[] args)
        {
            Execute();
        }

        private static void Execute()
        {
            var input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            Console.WriteLine(IsEven(input[0], input[1]) ? "Even" : "Odd");
        }

        private static bool IsEven(int a, int b)
        {
            return a * b % 2 == 0;
        }
    }
}