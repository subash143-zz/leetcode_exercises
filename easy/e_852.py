# https://leetcode.com/problems/peak-index-in-a-mountain-array/
# 852. Peak Index in a Mountain Array

class Solution(object):
    def peakIndexInMountainArray(self, arr):
        """
        :type arr: List[int]
        :rtype: int
        """
        for i in range(1, len(arr)-1, 1):
            if arr[i-1] < arr[i] > arr[i+1]:
                return i