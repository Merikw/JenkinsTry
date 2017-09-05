using System;
using System.Collections.Generic;
using System.Text;

namespace Algo_Problems
{
    public class Head
    {

        public Head()
        {

        }

        public List<string> CreateAbrv(string[] input)
        {
            List<string> result = new List<string>();

            foreach (string s in input)
            {
                if (s.Length > 10)
                {
                    string resultWord;
                    char[] c = s.ToCharArray();
                    resultWord = c[0] + (c.Length - 2).ToString() + c[c.Length - 1];
                    result.Add(resultWord);
                }
                else
                {
                    result.Add(s);
                }
            }

            return result;
        }

        public int SoldierBananas(int k, int n, int w)
        {
            int sum = 0;
            for (int x = 1; x <= w; x++)
            {
                sum = sum + (x * k);
            }

            return sum - n;
        }

        public int CalculatingFuction(int input)
        {
            int result = 0;
            for (int i = 1; i <= input; i++)
            {
                if ((i % 2) == 0)
                {
                    result = result + i;
                }
                else
                {
                    result = result - i;
                }
            }

            return result;
        }
    }
}
