using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Program
{
    class MyProgram
    {
        public enum MyEnum
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }

        public delegate void MyDelegate();

        public static void Test(MyDelegate my)
        {
            var list = new List<long>();
            Stopwatch watch = new Stopwatch();
            for (int k = 0; k < 100; k++)
            {
                watch.Reset();
                watch.Start();

                for (int i = 0; i < 1000000; i++)
                {
                    my();
                }
                watch.Stop();
                list.Add(watch.ElapsedTicks);
            }
            Console.WriteLine("RunTime " + list.Average());
        }

        private static void Main(string[] args)
        {
            Console.Write("Result of nameof: ");
            Test(() => { var a = nameof(MyEnum) == "January"; });
            Console.Write("Result of nameof + equals: ");
            Test(() => { var a = nameof(MyEnum).Equals("January"); });
            Console.Write("Result of ToString ==: ");
            Test(() => { var a = MyEnum.January.ToString() == "January"; });
            Console.Write("Result of ToString Equals: ");
            Test(() => { var a = MyEnum.January.ToString().Equals("January"); });
            Console.Write("Result of ToString Equals Ignore Case: ");
            Test(() => { var a = MyEnum.January.ToString().Equals("January", StringComparison.OrdinalIgnoreCase); });
        }
    }
}
