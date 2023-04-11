using System;
using System.Linq;

namespace AthleticProgrammingRepo.AtCoderBeginnerContest.SimilarQuestion
{
    public static class ABC082B
    {
        // static void Main(string[] args)
        // {
        //     Execute();
        // }
        
        private static void Execute()
        {
            var s = Console.ReadLine();
            var t = Console.ReadLine();
            var ans = CompareDictionaryOrder(s, t);
            Console.WriteLine($"{ans}");
        }

        private static string CompareDictionaryOrder(string s, string t)
        {
            // TODO: s' < t'にするために、sは昇順に、tは降順に並び替える。
            var sDash = new string(s.OrderBy(c => c).ToArray());
            var tDash = new string(t.OrderByDescending(c => c).ToArray());
            if (string.Compare(sDash, tDash) < 0)
                return "Yes";
            else
                return "No";

        }
    }
}