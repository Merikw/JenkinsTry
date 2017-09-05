using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Algo_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1
                        string[] input = { "word", "localization", "internationalization", "pneumonoultramicroscopicsilicovolcanoconiosis"};

                        DateTime dt1 = DateTime.Now;
                        List<string> result = CreateAbrv(input);
                        DateTime dt2 = DateTime.Now;

                        TimeSpan time = dt2 - dt1;

                        Console.WriteLine($"Time: {time.ToString()} and memory used: {GC.GetTotalMemory(false) / 10000000}");

                        foreach (string r in result)
                        {
                            Console.WriteLine(r);
                        }
                        #endregion 1

            #region 2
            DateTime dt11 = DateTime.Now;
            int result2 = SoldierBananas(3, 17, 4);
            DateTime dt22 = DateTime.Now;

            TimeSpan time2 = dt22 - dt11;

            Console.WriteLine($"Time: {time2.ToString()} and memory used: {GC.GetTotalMemory(false) / 10000000}");

            Console.WriteLine(result2);
            #endregion 2

            #region 3

            DateTime dt111 = DateTime.Now;
            int result3 = CalculatingFuction(999);
            DateTime dt222 = DateTime.Now;

            TimeSpan time3 = dt222 - dt111;

            Console.WriteLine($"Time: {time3.ToString()} and memory used: {GC.GetTotalMemory(false) / 10000000}");

            Console.WriteLine(result3);

            #endregion 3

            DateTime dt11 = DateTime.Now;
            int result2 = SoldierBananas(3, 17, 4);
            DateTime dt22 = DateTime.Now;

            TimeSpan time2 = dt22 - dt11;

            Console.WriteLine($"Time: {time2.ToString()} and memory used: {GC.GetTotalMemory(false) / 10000000}");

            Console.WriteLine(result2);

            Console.ReadLine();
        }

        public static List<string> CreateAbrv(string[] input)
        {
            List<string> result = new List<string>();

            foreach(string s in input)
            {
                if (s.Length > 10)
                {
                    string resultWord;
                    char[] c = s.ToCharArray();
                    resultWord = c[0] +  (c.Length - 2).ToString() + c[c.Length - 1];
                    result.Add(resultWord);
                } else
                {
                    result.Add(s);
                }
            }

            return result;
        }

        public static int SoldierBananas(int k, int n, int w)
        {
            int sum = 0;
            for(int x = 1; x <= w; x++)
            {
                sum = sum + (x * k);
            }

            return sum - n;
        }

        public static int CalculatingFuction(int input)
        {
            int result = 0;
            for(int i = 1; i <= input; i++)
            {
                if((i % 2) == 0)
                {
                    result = result + i;
                } else
                {
                    result = result - i;
                }
            }

            return result;
        }

        public static int DreamoonAndStairs(int steps, int multiple)
        {
            List<int> numberOfSteps = new List<int>();


        }
    }
}
