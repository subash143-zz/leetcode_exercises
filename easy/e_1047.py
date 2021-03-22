# https://leetcode.com/problems/remove-all-adjacent-duplicates-in-string/
# 1047. Remove All Adjacent Duplicates In String

class Solution(object):
    def removeDuplicates(self, S):
        """
        :type S: str
        :rtype: str
        """
        stack = []
        for c in S:
            if len(stack) == 0:
                stack.append(c)
            else:
                if stack[-1] == c:
                    stack.pop()
                else:
                    stack.append(c)
        return "".join(stack)