// https://leetcode.com/problems/add-two-numbers/submissions/
// 2. Add Two Numbers

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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var retVal = new ListNode(-1);
        var head = retVal;
        
        int carry = 0;
        while(l1 != null || l2 != null){
            int sum = (l1 != null ? l1.val : 0) + ( l2 != null ? l2.val : 0) + carry;
            if(l1 != null) l1 = l1.next;
            if(l2 != null) l2 = l2.next;
            carry = sum / 10;
            sum = sum % 10;
            head.next = new ListNode(sum);
            head = head.next;
        }
        if(carry > 0){
            head.next = new ListNode(carry);
        }
        
        return retVal.next;
        
    }
}