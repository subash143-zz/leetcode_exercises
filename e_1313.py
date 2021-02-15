# https://leetcode.com/problems/decompress-run-length-encoded-list/
# 1313. Decompress Run-Length Encoded List

class Solution(object):
    def decompressRLElist(self, nums):
        """
        :type nums: List[int]
        :rtype: List[int]
        """
        retVal = []
        i = 0
        while i < len(nums):
            for j in range(nums[i]):
                retVal.append(nums[i+1])
            i += 2
        return retVal