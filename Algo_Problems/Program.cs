﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Algo_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Head h = new Head();

            #region 1
            string[] input = { "word", "localization", "internationalization", "pneumonoultramicroscopicsilicovolcanoconiosis"};

            DateTime dt1 = DateTime.Now;
            List<string> result = h.CreateAbrv(input);
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
            int result2 = h.SoldierBananas(3, 17, 4);
            DateTime dt22 = DateTime.Now;

            TimeSpan time2 = dt22 - dt11;

            Console.WriteLine($"Time: {time2.ToString()} and memory used: {GC.GetTotalMemory(false) / 10000000}");

            Console.WriteLine(result2);
            #endregion 2

            #region 3

            DateTime dt111 = DateTime.Now;
            int result3 = h.CalculatingFuction(999);
            DateTime dt222 = DateTime.Now;

            TimeSpan time3 = dt222 - dt111;

            Console.WriteLine($"Time: {time3.ToString()} and memory used: {GC.GetTotalMemory(false) / 10000000}");

            Console.WriteLine(result3);

            #endregion 3

            Console.ReadKey();
        }
    }
}
