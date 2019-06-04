class Solution(object):
    def trap(self, height):
        """
        :type height: List[int]
        :rtype: int
        """
        if len(height)==0:
            return 0
        
        lMax = 0
        rMax = 0 
        lIndex = 0
        rIndex = len(height) - 1
        highestPeak = max(height)
        waterCollected = 0
        
        while height[lIndex]!=highestPeak:
            curHeight = height[lIndex]
            if (curHeight > lMax):
                lMax = curHeight
            else:
                waterCollected += lMax - curHeight
            lIndex = lIndex + 1
                
        while height[rIndex]!=highestPeak:
            curHeight = height[rIndex]
            if (curHeight > rMax):
                rMax = curHeight
            else:
                waterCollected += rMax - curHeight
            rIndex = rIndex - 1
            
        while lIndex != rIndex:
            lIndex = lIndex + 1
            waterCollected +=  highestPeak - height[lIndex]

        return waterCollected
            