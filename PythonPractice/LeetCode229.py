class Solution(object):
    def majorityElement(self, nums):
        """
        :type nums: List[int]
        :rtype: List[int]
        """
        if len(nums)==0:
            return []
        
        nums.sort()
        lnum = nums[0]
        majority = math.floor(len(nums)/3)
        cnt = 0
        out = []
        for num in nums:
            if num == lnum:
                cnt = cnt + 1
            else:
                cnt = 1
            if (cnt > majority and not num in out):
                    out.append(num)
            lnum = num
        return out