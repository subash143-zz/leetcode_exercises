# https://leetcode.com/problems/subtract-the-product-and-sum-of-digits-of-an-integer/
# 1281. Subtract the Product and Sum of Digits of an Integer


class Solution(object):
    def subtractProductAndSum(self, n):
        """
        :type n: int
        :rtype: int
        """
        digit = str(n)
        product = 1
        summation = 0
        for c in digit:
            product = product * int(c)
            summation = summation + int(c)
        return (product - summation)