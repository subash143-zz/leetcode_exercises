// https://leetcode.com/problems/range-sum-of-bst/
// 938. Range Sum of BST

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
    public int RangeSumBST(TreeNode root, int low, int high) {
        if(root == null){
            return 0;
        }
        
        else{
            
            if(root.val > high){
                return this.RangeSumBST(root.left, low, high);
            }
            else if(root.val < low){
                return this.RangeSumBST(root.right, low, high);
            }
            return root.val + this.RangeSumBST(root.left, low, high) + this.RangeSumBST(root.right, low, high);
        }
    }
}