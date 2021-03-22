# https://leetcode.com/problems/unique-number-of-occurrences/
# 1207. Unique Number of Occurrences

class Solution(object):
    def uniqueOccurrences(self, arr):
        """
        :type arr: List[int]
        :rtype: bool
        """
        dic = {}
        for item in arr:
            if item in dic:
                dic[item] += 1
            else:
                dic[item] = 1
        return len(dic.values()) == len(set(dic.values()))