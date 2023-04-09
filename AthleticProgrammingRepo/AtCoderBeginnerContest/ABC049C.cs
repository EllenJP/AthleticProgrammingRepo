using System;
using System.Linq;

namespace AthleticProgrammingRepo.AtCoderBeginnerContest
{
    public static class ABC049C
    {
        // static void Main(string[] args)
        // {
        //     Execute();
        // }

        static void Execute()
        {
            var S = Console.ReadLine();
            Console.WriteLine(CheckStringMatch(S));
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
    }
}