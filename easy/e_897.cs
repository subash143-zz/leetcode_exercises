// https://leetcode.com/problems/increasing-order-search-tree/
// 897. Increasing Order Search Tree

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
    public TreeNode IncreasingBST(TreeNode root) {
        List<int> vals = new List<int>();
        InOrder(root, vals);
        
        TreeNode retVal = new TreeNode(vals.First());
        var cur = retVal;
        foreach(int v in vals.Skip(1)){
            cur.right = new TreeNode(v);
            cur = cur.right;
        }
        
        return retVal;
        
    }
    
    public void InOrder(TreeNode node, List<int> vals){
        if(node == null) return;
        InOrder(node.left, vals);
        vals.Add(node.val);
        InOrder(node.right, vals);
    }
}