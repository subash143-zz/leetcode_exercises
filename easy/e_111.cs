// https://leetcode.com/problems/minimum-depth-of-binary-tree/
// 111. Minimum Depth of Binary Tree

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
    int min = 10000000;
    public int MinDepth(TreeNode root) {
        if(root == null) return 0;
        TraverseTree(root, 0);
        return min +1;
    }
    
    public void TraverseTree(TreeNode node, int depth){
        if(node == null) return;
        if(node.left == null && node.right == null){
            min = depth < min ? depth : min;
        }
        TraverseTree(node.left, depth + 1);
        TraverseTree(node.right, depth + 1);
    }
}