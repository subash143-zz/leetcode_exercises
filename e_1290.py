# https://leetcode.com/problems/convert-binary-number-in-a-linked-list-to-integer/
# 1290. Convert Binary Number in a Linked List to Integer


# Definition for singly-linked list.
# class ListNode(object):
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution(object):
    def getDecimalValue(self, head):
        """
        :type head: ListNode
        :rtype: int
        """
        numbers = []
        while head!= None:
            numbers.insert(0, head.val)
            head = head.next
        
        retVal = 0
        for i in range(len(numbers)):
            retVal += numbers[i] * (2**i)
        return retVal
        