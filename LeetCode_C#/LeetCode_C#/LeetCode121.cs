using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LeetCode121
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length == 0) { return 0; }

            int maxDiff = 0;
            int min = prices[0];

            for (int i = 0; i < prices.Length; i++)
            {
                min = Math.Min(min, prices[i]);
                maxDiff = Math.Max(maxDiff, prices[i] - min);
            }

            return maxDiff;
        }
    }
}
