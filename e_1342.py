# https://leetcode.com/problems/number-of-steps-to-reduce-a-number-to-zero/
# 1342. Number of Steps to Reduce a Number to Zero

class Solution(object):
    def numberOfSteps (self, num):
        """
        :type num: int
        :rtype: int
        """
        steps = 0
        while num != 0:
            if num%2 == 0:
                num = num //2
            else:
                num = num - 1
            steps += 1
        return steps
        