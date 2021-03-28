// https://leetcode.com/problems/reverse-linked-list/
// 206. Reverse Linked List

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode current = null;
        var next = head;
        while(next != null){
            var temp = next.next;
            next.next = current;
            current = next;
            next = temp;
        }
        return current;
        
    }
}