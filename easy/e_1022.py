# https://leetcode.com/problems/sum-of-root-to-leaf-binary-numbers/
# 1022. Sum of Root To Leaf Binary Numbers

# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def sumRootToLeaf(self, root: TreeNode) -> int:
        self.s = []
        self.getSum(root, "")
        return sum([int(i,2) for i in self.s])
        
    def getSum(self, node, bit):
        if node.left is None and node.right is None:
            self.s.append(bit + str(node.val))
        else:
            if node.left:
                self.getSum(node.left, bit + str(node.val))
            if node.right:
                self.getSum(node.right, bit + str(node.val))
                
                
