using System;
using System.Linq;

namespace AthleticProgrammingRepo.AtCoderBeginnerContest.SimilarQuestion
{
    public static class ABC095A
    {
        // static void Main(string[] args)
        // {
        //     Execute();
        // }
        
        private static void Execute()
        {
            var input = Console.ReadLine();
            var ans = CalculateOrderTotal(input);
            Console.WriteLine($"{ans}");
        }

        private static int CalculateOrderTotal(string input)
        {
            var price = 700;
            var toppingFee = 100;
            return price + input.ToArray().Count(x => x == 'o') * toppingFee;
        }
    }
}