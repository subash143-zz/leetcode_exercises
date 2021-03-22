# https://leetcode.com/problems/shortest-distance-to-a-character/
# 821. Shortest Distance to a Character

class Solution(object):
    def shortestToChar(self, s, c):
        """
        :type s: str
        :type c: str
        :rtype: List[int]
        """
        indices = []
        for i in range(len(s)):
            char = s[i]
            if char == c:
                indices.append(i)
        
        retVal = []
        for i in range(len(s)):
            if i not in indices:
                minimum = min(abs(i-x) for x in indices)
                retVal.append(minimum)
            else:
                retVal.append(0)
        return retVal
                