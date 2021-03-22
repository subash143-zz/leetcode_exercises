# https://leetcode.com/problems/maximum-nesting-depth-of-the-parentheses/
# 1614. Maximum Nesting Depth of the Parentheses

class Solution(object):
    def maxDepth(self, s):
        """
        :type s: str
        :rtype: int
        """
        retVal = 0
        maximum = 0
        for c in s:
            if c == "(":
                retVal += 1
            elif c == ")":
                retVal -=1
            if retVal > maximum:
                maximum = retVal
        return maximum
            