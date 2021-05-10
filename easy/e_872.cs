// https://leetcode.com/problems/leaf-similar-trees/
// 872. Leaf-Similar Trees

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
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        
        var leaves_1 = TraverseTree(root1);
        var leaves_2 = TraverseTree(root2);
        
        return leaves_1 == leaves_2;
    }
    
    //Using stack to do get the left nodes in order
    public string TraverseTree(TreeNode root){
        var retVal = new StringBuilder();
        Stack<TreeNode> stack= new Stack<TreeNode>();
        stack.Push(root);
        
        while(stack.Count != 0){
            var node = stack.Pop();
            if(node.right != null){
                stack.Push(node.right);
            }
            if(node.left != null){
                stack.Push(node.left);
            }            
            if(node.right == null && node.left == null){
                retVal.Append("-" + node.val);
            }
        }
        return retVal.ToString();
    }
}