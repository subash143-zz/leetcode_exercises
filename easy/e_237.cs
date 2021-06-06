// https://leetcode.com/problems/delete-node-in-a-linked-list/
// 237. Delete Node in a Linked List

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public void DeleteNode(ListNode node) {
        while(node.next != null){
            node.val = node.next.val;
            if(node.next.next == null){
                node.next = null;
                return;
            }
            node = node.next;
        }
    }
}