using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LeetCode122
    {
        public int MaxProfit(int[] prices)
        {

            if (prices.Length == 0) return 0;

            int lastBuyIn = prices[0];
            int profit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (lastBuyIn <= prices[i])
                { //Price is above or equal last buy in. Sell.
                    profit += prices[i] - lastBuyIn; //Sell the stock, take profit
                    lastBuyIn = prices[i]; //Rebuy in case it goes up the next day
                }
                else
                { //lastBuyIn > nextPrice (Price goes below last buy in)
                    lastBuyIn = prices[i]; //Buy at the lower price instead
                }
            }

            return profit;
        }
    }
}
