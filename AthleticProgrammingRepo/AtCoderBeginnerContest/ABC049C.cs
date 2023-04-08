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
            Console.WriteLine(CheckStringEquality(S));
        }

        static string CheckStringEquality(string S)
        {
            var addStrings = new string[] { "dream", "dreamer", "erase", "eraser" };
            // TODO: 末尾に追加する文字列とSをリバースする。
            var reverseS = new string(S.Reverse().ToArray());
            var reverseAddStrings = new string[addStrings.Length];
            for (int i = 0; i < addStrings.Length; i++)
            {
                reverseAddStrings[i] = new String(addStrings[i].Reverse().ToArray());
            }

            int index = 0;
            while (index < reverseS.Length)
            {
                // TODO: 先頭要素から追加文字列の文字数分で比較する。
                var isMatch = false;
                foreach (var reverseAddString in reverseAddStrings)
                {
                    if (reverseS.Length - index >= reverseAddString.Length && reverseS.Substring(index, reverseAddString.Length) == reverseAddString)
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