using System;
using System.Linq;

namespace AthleticProgrammingRepo.AtCoderBeginnerContest
{
    public static class ABC086C
    {
        static void Main(string[] args)
        {
            Execute();
        }

        static void Execute()
        {
            var inputCount = int.Parse(Console.ReadLine() ?? string.Empty);
            var points = new Point[inputCount];
            points[0] = new Point(0, 0, 0);
            for (int i = 1; i < inputCount; i++)
            {
                var input = (Console.ReadLine() ?? String.Empty).Split(' ').Select(int.Parse).ToArray();
                points[i] = new Point(input[0], input[1], input[2]);
            }
            
            Console.WriteLine(CheckMoveToPoint(points));
        }

        static string CheckMoveToPoint(Point[] points)
        {
            for (int i = 0; i < points.Length - 1; i++)
            {
                // TODO: 前後の時刻差を求める。
                var timeDifference = points[i + 1].T - points[i].T;
                // TODO: 前後の座標における距離を求める。
                var distanceDifference = Math.Abs(points[i + 1].X - points[i].X) - (points[i + 1].X - points[i].X);
                // TODO: 時間差による移動量と座標間の距離がマッチするか    
            }
            
            
        }
    }

    struct Point
    {
        public int T { get; }
        public int X { get; }
        public int Y { get; }

        public Point(int t, int x, int y)
        {
            this.T = t;
            this.X = x;
            this.Y = y;
        }
    }
}