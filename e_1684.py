# https://leetcode.com/problems/count-the-number-of-consistent-strings/
# 1684. Count the Number of Consistent Strings

class Solution(object):
    def countConsistentStrings(self, allowed, words):
        """
        :type allowed: str
        :type words: List[str]
        :rtype: int
        """
        retVal = len(words)
        for word in words:
            for c in word:
                if c not in allowed:
                    retVal -= 1
                    break
        return retVal