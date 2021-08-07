// https://leetcode.com/problems/diameter-of-binary-tree/
// 543. Diameter of Binary Tree

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    int max = 0;
    public int DiameterOfBinaryTree(TreeNode root) {
        DFS(root);
        return max;
    }
    
    public int DFS(TreeNode node){
        
        if(node == null) 
            return -1;
        
        int leftHeight =  1 + DFS(node.left);
        int rightHeight = 1 + DFS(node.right);
        
        max = Math.Max(leftHeight + rightHeight, max);
        
        return Math.Max(leftHeight, rightHeight);
        
    }
}