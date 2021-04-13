// https://leetcode.com/problems/rotate-list/submissions/
// 61. Rotate List

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
    public ListNode RotateRight(ListNode head, int k) {
        
        if(head == null || head.next == null) return head;
        
        var first = head;
        
        //Getting length of LinkedList
        int length = 1;
        while(head.next != null){
            head = head.next;
            length++;
        }
        
        var last = head;
        
        //Position to break
        int position = length - k % length;
        
        //Get the node just infront of the position
        head = first;
        while(position > 1){
            head = head.next;
            position--;
        }
        
        
        var tail = head;        
        last.next = first;
        head = tail.next;
        tail.next = null;
        
        return head;
    }
}