// https://leetcode.com/problems/n-ary-tree-postorder-traversal/
// 590. N-ary Tree Postorder Traversal

/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public IList<int> Postorder(Node root) {
        var retVal = new List<int>();
        DoPostOrder(root, retVal);
        return retVal;
    }
    
    public void DoPostOrder(Node root, List<int> retVal){
        if(root == null) return;
        foreach(Node child in root.children){
            DoPostOrder(child, retVal);
        }
        retVal.Add(root.val);        
    }
}

