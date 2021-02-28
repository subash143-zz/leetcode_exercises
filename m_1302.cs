// https://leetcode.com/problems/deepest-leaves-sum/
// 1302. Deepest Leaves Sum

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
    public int max = 0;
    public int val = 0;
    
    public int DeepestLeavesSum(TreeNode root) {
        FindSum(root, 0);
        return val;
    }
    
    public void FindSum(TreeNode root, int level){
        if(root!=null && root.left == null && root.right == null){
            if(level > max){
                max = level;
                val = root.val;
            }
            else if(level == max){
                val += root.val;
            }   
        }
        else{
            if(root.left != null){
                FindSum(root.left, level+1);
            } 
            if(root.right != null){
                FindSum(root.right, level+1);
            }
        }
    }
}