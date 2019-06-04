using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LeetCode169
    {
        public int MajorityElement(int[] nums)
        {

            int majorityElement = nums[0];
            int majorityCount = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (majorityElement == nums[i])
                {
                    majorityCount++;
                }
                else
                {
                    majorityCount--;
                }

                if (majorityCount == 0)
                {
                    majorityElement = nums[i];
                    majorityCount = 1;
                }
            }

            return majorityElement;
        }
    }
}
