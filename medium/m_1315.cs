// https://leetcode.com/problems/sum-of-nodes-with-even-valued-grandparent/
// 1315. Sum of Nodes with Even-Valued Grandparent

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
    int sum = 0;
    public int SumEvenGrandparent(TreeNode root) {
        TraverseTree(root);
        return sum;
    }
    
    public void TraverseTree(TreeNode root){
        if(root == null) return;
        if(root.val %2 == 0){
            sum += SumEvenGrandparent(root, 2);
        }
        TraverseTree(root.left);
        TraverseTree(root.right);
    }
    
    public int SumEvenGrandparent(TreeNode root, int level){
        if(root == null) return 0;
        if(level == 0) return root.val;
        return SumEvenGrandparent(root.left, level - 1) + SumEvenGrandparent(root.right, level - 1);
    }
}