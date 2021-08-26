// https://leetcode.com/problems/binary-tree-inorder-traversal/
// 94. Binary Tree Inorder Traversal

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
    public IList<int> InorderTraversal(TreeNode root) {
        var retVal = new List<int>();
        DoInOrder(root, retVal);
        return retVal;
    }
    
    public void DoInOrder(TreeNode root, List<int> retVal){
        if(root == null) return;
        
        DoInOrder(root.left, retVal);
        retVal.Add(root.val);
        DoInOrder(root.right, retVal);
    }
}