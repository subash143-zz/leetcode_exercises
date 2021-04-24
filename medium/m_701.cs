// https://leetcode.com/problems/insert-into-a-binary-search-tree/
// 701. Insert into a Binary Search Tree

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
    public TreeNode InsertIntoBST(TreeNode root, int val) {
        var retVal = root;
        if(root == null){
            return new TreeNode(val);
        }
        while(true){
            if(val > root.val){
                if(root.right ==  null){
                    root.right = new TreeNode(val);
                    break;
                }
                else{
                    root = root.right;
                }
            }
            else{
                if(root.left == null){
                    root.left = new TreeNode(val);
                    break;
                }
                else{
                    root = root.left;
                }
            }
            
        }
        return retVal;
        
    }
}