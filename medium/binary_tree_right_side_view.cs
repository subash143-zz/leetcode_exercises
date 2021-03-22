// https://leetcode.com/problems/binary-tree-right-side-view/
// 199. Binary Tree Right Side View

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
    
    public Dictionary<int, int> items = new Dictionary<int, int>();

    public IList<int> RightSideView(TreeNode root) {
        if(root == null){
            return new List<int>();
        }
        
        items[0] = root.val;
        TraverseTree(root, 1);
        return items.Select(x=>x.Value).ToList();
        
    }
    
    public void TraverseTree(TreeNode root, int level){
        if(root != null){
            if(root.left !=  null){
                items[level] =  root.left.val;
                TraverseTree(root.left, level+1);
            }
            if(root.right != null){
                items[level] = root.right.val;
                TraverseTree(root.right, level+1);
            }
        }
    }
}